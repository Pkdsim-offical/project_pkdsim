using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions;
using Unity.Services.CloudCode.Authoring.Editor.Core.IO;
using Unity.Services.CloudCode.Authoring.Editor.Core.Logging;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment
{
    class ModuleZipper : IModuleZipper
    {
        const string k_ZipFileExtension = "ccm";

        readonly IFileSystem m_FileSystem;
        readonly ILogger m_Logger;

        public ModuleZipper(IFileSystem fileSystem, ILogger logger)
        {
            m_FileSystem = fileSystem;
            m_Logger = logger;
        }

        public async Task<string> ZipCompilation(
            string srcPath, string dstPath, string moduleName, CancellationToken cancellationToken = default)
        {
            try
            {
                var directoryPath = Path.GetDirectoryName(srcPath);
                if (directoryPath == null)
                {
                    throw new DirectoryNotFoundException();
                }

                var zippedFileName = Path.ChangeExtension(moduleName, k_ZipFileExtension);
                var dstFileFullPath = Path.Join(dstPath, zippedFileName);
                m_Logger.LogVerbose($"Zipping from '{srcPath}' to '{dstFileFullPath}'");
                // Remove previously generated module
                if (m_FileSystem.FileExists(dstFileFullPath))
                {
                    await m_FileSystem.Delete(dstFileFullPath, cancellationToken);
                }

                m_FileSystem.CreateZipFromDirectory(srcPath, dstFileFullPath);
                return dstFileFullPath;
            }
            catch (IOException e)
            {
                m_Logger.LogVerbose($"Fail to zip {e}");
                throw new FailedZipCompilationException(e);
            }
        }
    }
}
