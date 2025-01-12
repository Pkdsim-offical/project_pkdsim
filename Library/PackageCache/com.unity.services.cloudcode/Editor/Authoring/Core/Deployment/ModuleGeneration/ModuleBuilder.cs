using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions;
using Unity.Services.CloudCode.Authoring.Editor.Core.IO;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;
using Unity.Services.DeploymentApi.Editor;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration
{
    class ModuleBuilder : IModuleBuilder
    {
        readonly ISolutionPublisher m_SolutionPublisher;
        readonly IModuleProjectRetriever m_ProjectRetriever;
        readonly IModuleZipper m_ModuleZipper;
        readonly IFileSystem m_FileSystem;

        public ModuleBuilder(
            ISolutionPublisher solutionPublisher,
            IModuleProjectRetriever projectRetriever,
            IModuleZipper moduleZipper,
            IFileSystem fileSystem)
        {
            m_SolutionPublisher = solutionPublisher;
            m_ProjectRetriever = projectRetriever;
            m_ModuleZipper = moduleZipper;
            m_FileSystem = fileSystem;
        }

        public async Task CreateCloudCodeModuleFromSolution(
            IModuleItem deploymentItem,
            CancellationToken cancellationToken = default)
        {
            var slnName = Path.GetFileNameWithoutExtension(deploymentItem.SolutionPath);
            var tempFolderPath = Path.Combine(Path.GetTempPath(), slnName);
            var slnOutputPath = Path.Combine(tempFolderPath, "module-compilation");

            try
            {
                await ClearModuleCompilationFolder(slnOutputPath);

                if (!SetAndValidateEntryProject(deploymentItem))
                    return;

                if (!await Publish(deploymentItem, slnOutputPath, cancellationToken) ||
                    cancellationToken.IsCancellationRequested)
                    return;

                await Zip(deploymentItem, slnOutputPath, tempFolderPath, cancellationToken);
            }
            finally
            {
                await ClearModuleCompilationFolder(slnOutputPath);
            }
        }

        async Task ClearModuleCompilationFolder(string slnOutputPath)
        {
            if (!m_FileSystem.DirectoryExists(slnOutputPath))
            {
                return;
            }

            await m_FileSystem.DeleteDirectory(slnOutputPath, true);
        }

        bool SetAndValidateEntryProject(IModuleItem deploymentItem)
        {
            try
            {
                deploymentItem.ModuleName = m_ProjectRetriever.GetMainEntryProjectName(deploymentItem.SolutionPath) + ".ccm";
                return true;
            }
            catch (FailedProjectRetrieverException e)
            {
                UpdateStatusFailed(deploymentItem, "Failed to retrieve main project", e.Message);
                return false;
            }
        }

        async Task<bool> Publish(IModuleItem deploymentItem, string slnOutputPath, CancellationToken cancellationToken)
        {
            try
            {
                deploymentItem.UpdateLogStatus(new DeploymentStatus("Compiling..."));
                await m_SolutionPublisher.PublishSolutionLinux64(deploymentItem.SolutionPath, slnOutputPath, cancellationToken);
                UpdateStatusAndProgress(deploymentItem, 33f, ModuleBuilderStatuses.CompiledSuccessfully);
                return true;
            }
            catch (DotnetNotFoundException e)
            {
                UpdateStatusFailed(deploymentItem, ModuleBuilderStatuses.FailedToCompile, e.Message);
                return false;
            }
        }

        async Task Zip(IModuleItem deploymentItem, string slnOutputPath, string tempFolderPath, CancellationToken cancellationToken)
        {
            try
            {
                deploymentItem.CcmPath =
                    await m_ModuleZipper.ZipCompilation(
                        slnOutputPath,
                        tempFolderPath,
                        Path.GetFileNameWithoutExtension(deploymentItem.ModuleName),
                        cancellationToken);
                UpdateStatusAndProgress(deploymentItem, 66f, ModuleBuilderStatuses.ZippedSuccessfully);
            }
            catch (FailedZipCompilationException e)
            {
                UpdateStatusFailed(deploymentItem, ModuleBuilderStatuses.FailedToZip, e.Message);
            }
        }

        static void UpdateStatusAndProgress(IModuleItem item, float progress, string statusMessage)
        {
            item.Progress = progress;
            item.UpdateLogStatus(new DeploymentStatus(statusMessage));
        }

        static void UpdateStatusFailed(IModuleItem item, string statusMessage, string errorMessage)
        {
            item.UpdateLogStatus(new DeploymentStatus(statusMessage, errorMessage, SeverityLevel.Error));
        }
    }
}
