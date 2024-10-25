using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration;
using Unity.Services.CloudCode.Authoring.Editor.Core.Dotnet;
using Unity.Services.CloudCode.Authoring.Editor.Core.IO;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;
using Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Infrastructure.Collections;
using UnityEditor;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

namespace Unity.Services.CloudCode.Authoring.Editor.Modules.Bindings
{
    class CloudCodeModuleBindingsGenerator : ICloudCodeModuleBindingsGenerator
    {
        readonly IDotnetRunner m_DotnetRunner;
        readonly ISolutionPublisher m_SolutionPublisher;
        readonly IModuleProjectRetriever m_ModuleProjectRetriever;
        readonly IFileSystem m_FileSystem;
        readonly ILogger m_Logger;

        const string k_AssemblyDefinitionFileName = "Unity.Services.CloudCode.GeneratedBindings.asmdef";

        static readonly string k_BindingsOutputFolder =
            Path.Combine("Assets", "CloudCode", "GeneratedModuleBindings");

        public CloudCodeModuleBindingsGenerator(
            IDotnetRunner dotnetRunner,
            ISolutionPublisher solutionPublisher,
            IModuleProjectRetriever moduleProjectRetriever,
            IFileSystem fileSystem,
            ILogger logger)
        {
            m_DotnetRunner = dotnetRunner;
            m_SolutionPublisher = solutionPublisher;
            m_ModuleProjectRetriever = moduleProjectRetriever;
            m_FileSystem = fileSystem;
            m_Logger = logger;
        }

        public async Task<List<CloudCodeModuleBindingsGenerationResult>> GenerateModuleBindings(
            IEnumerable<IModuleItem> moduleItems,
            CancellationToken cancellationToken = default)
        {
            var moduleItemsList = moduleItems.EnumerateOnce();
            if (!moduleItemsList.Any())
            {
                m_Logger.Log($"No Cloud Code Module Reference file was found in the project." +
                    $" To create one right-click in the Project window, then select Create > Services > Cloud Code C# Module Reference.");
                return new List<CloudCodeModuleBindingsGenerationResult>() {};
            }

            m_Logger.Log($"Generating Cloud Code Module Bindings for: {GetModuleItemNames(moduleItemsList)}.");

            // start module generations
            var generationTasks = new List<Task<CloudCodeModuleBindingsGenerationResult>>();
            foreach (var item in moduleItemsList)
            {
                generationTasks.Add(CompileAndGenerateModuleBindings(item, cancellationToken));
            }

            var generationResults = await Task.WhenAll(generationTasks);
            try
            {
                await MoveCodeBindingsToEditorContext(generationResults.ToList());
                await GenerateAssemblyDefinition(k_BindingsOutputFolder, cancellationToken);
            }
            catch (Exception e)
            {
                m_Logger.LogError("[Cloud Code]", $"Failed to generate code bindings. Error: {e.Message}");
            }
            finally
            {
                AssetDatabase.Refresh();
            }

            return generationResults.ToList();
        }

        async Task MoveCodeBindingsToEditorContext(List<CloudCodeModuleBindingsGenerationResult> bindingsGenerationResults)
        {
            if (!bindingsGenerationResults.Any(x => x.IsSuccessful))
                return;

            await m_FileSystem.CreateDirectory(k_BindingsOutputFolder);

            // Move generated code to editor context
            foreach (var result in bindingsGenerationResults)
            {
                if (!result.IsSuccessful)
                {
                    m_Logger.LogError("[Cloud Code]", $"Failed to generate code bindings of {result.ModuleItem.Name}. Error: {result.Exception.Message}");
                    continue;
                }

                var outputFolder = GetModuleOutputFolder(result.ModuleItem);
                await MoveDirectoryToNewLocation(result.OutputPath, outputFolder);
                result.OutputPath = outputFolder;
                m_Logger.Log($"Bindings of {result.ModuleItem.Name} generated successfully in {result.OutputPath}.");
            }
        }

        static string GetModuleItemNames(IEnumerable<IModuleItem> moduleItems)
        {
            var allNames = string.Join(", ", moduleItems.Select(item => item.Name));
            return allNames;
        }

        /// <summary>
        /// Generates the Cloud Code Bindings for a C# Module
        /// </summary>
        /// <param name="moduleItem"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        internal async Task<CloudCodeModuleBindingsGenerationResult> CompileAndGenerateModuleBindings(
            IModuleItem moduleItem,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var moduleName = m_ModuleProjectRetriever.GetMainEntryProjectName(moduleItem.SolutionPath);
                var tempFolder = GetBindingsGenerationOutputTempFolder(moduleName);
                var solutionCompilationOutputPath = GetSolutionCompilationOutputPath(moduleItem.SolutionPath);

                try
                {
                    await DeleteExistingDirectory(solutionCompilationOutputPath);
                    await CompileSolution(moduleItem.SolutionPath, cancellationToken);
                    await GenerateBindings(moduleItem.SolutionPath, tempFolder, cancellationToken);
                }
                finally
                {
                    await DeleteExistingDirectory(solutionCompilationOutputPath);
                }

                return new CloudCodeModuleBindingsGenerationResult(moduleItem, tempFolder, true);
            }
            catch (Exception e)
            {
                return new CloudCodeModuleBindingsGenerationResult(moduleItem, "", false, e);
            }
        }

        async Task DeleteExistingDirectory(string dirPath)
        {
            if (m_FileSystem.DirectoryExists(dirPath))
            {
                await m_FileSystem.DeleteDirectory(dirPath, true);
            }
        }

        async Task MoveDirectoryToNewLocation(string srcDirectoryPath, string dstDirectoryPath)
        {
            // Ensure that the source does exists.
            if (m_FileSystem.DirectoryExists(srcDirectoryPath))
            {
                // clear existing destination directory
                if (m_FileSystem.DirectoryExists(dstDirectoryPath))
                {
                    await m_FileSystem.DeleteDirectory(dstDirectoryPath, true);
                }

                m_FileSystem.MoveDirectory(srcDirectoryPath, dstDirectoryPath);
            }
            else
            {
                throw new Exception($"The source directory does not exist: {srcDirectoryPath}");
            }
        }

        internal async Task CompileSolution(string solutionPath, CancellationToken cancellationToken)
        {
            try
            {
                var solutionCompilationOutputPath = GetSolutionCompilationOutputPath(solutionPath);

                await m_SolutionPublisher.PublishSolutionCrossPlatform(
                    solutionPath,
                    solutionCompilationOutputPath,
                    cancellationToken);
            }
            catch (Exception e)
            {
                throw new FailedToCompileSolutionException(solutionPath, e);
            }
        }

        internal async Task GenerateBindings(
            string solutionPath,
            string bindingsOutputFolderPath,
            CancellationToken cancellationToken)
        {
            try
            {
                var moduleName = m_ModuleProjectRetriever.GetMainEntryProjectName(solutionPath);
                var moduleDllPath =
                    GetSolutionGeneratedDllPath(GetSolutionCompilationOutputPath(solutionPath), moduleName);

                if (!m_FileSystem.FileExists(moduleDllPath))
                {
                    throw new FileNotFoundException($"Generated binaries for the '{solutionPath}' " +
                        $"solution were not found at the expected '${moduleDllPath}' path.");
                }

                await m_FileSystem.CreateDirectory(bindingsOutputFolderPath);

                await m_DotnetRunner.ExecuteDotnetAsync(
                    new[] {$"\"{GetGeneratorPath()}\"", $"\"{moduleDllPath}\"", $"\"{bindingsOutputFolderPath}\""},
                    cancellationToken);
            }
            catch (Exception e)
            {
                throw new FailedToGenerateBindingsException(solutionPath, e);
            }
        }

        async Task GenerateAssemblyDefinition(string bindingsOutputFolderPath, CancellationToken cancellationToken)
        {
            var assemblyDefPath = GetAssemblyDefinitionPath();

            if (!m_FileSystem.FileExists(assemblyDefPath))
            {
                await m_FileSystem.CreateDirectory(bindingsOutputFolderPath);
                var content = await m_FileSystem.ReadAllText(GetAsmdefContentPath(), cancellationToken);
                await m_FileSystem.WriteAllText(assemblyDefPath, content, cancellationToken);
            }
        }

        internal static string GetGeneratorPath()
            => Path.GetFullPath(Path.Combine(
                "Packages", "com.unity.services.cloudcode", "Editor", ".CloudCodeBindingsGenerator",
                "CloudCodeBindingsGenerator.dll"));

        internal static string GetAsmdefContentPath()
            => Path.GetFullPath(Path.Combine(
                "Packages", "com.unity.services.cloudcode", "Editor", "Authoring", "Modules", "Bindings",
                "CloudCodeModuleBindingsAsmdefContent.json"));

        internal static string GetSolutionCompilationOutputPath(string solutionPath)
            => Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(solutionPath),
                "module-compilation-cross-platform");

        internal static string GetSolutionGeneratedDllPath(string solutionCompilationOutputPath, string moduleName)
            => Path.Combine(solutionCompilationOutputPath, moduleName + ".dll");

        internal static string GetAssemblyDefinitionPath()
            => Path.Combine(k_BindingsOutputFolder, k_AssemblyDefinitionFileName);

        internal static string GetBindingsGenerationOutputTempFolder(string moduleName)
            => Path.Combine(Path.GetTempPath(), "bindings-generation-" + moduleName);

        internal string GetModuleOutputFolder(IModuleItem moduleItem)
            => Path.Combine(k_BindingsOutputFolder, m_ModuleProjectRetriever.GetMainEntryProjectName(moduleItem.SolutionPath));
    }
}
