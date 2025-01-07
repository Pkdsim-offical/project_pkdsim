using System;
using System.IO;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions;
using Unity.Services.CloudCode.Authoring.Editor.Core.IO;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration
{
    class ModuleProjectRetriever : IModuleProjectRetriever
    {
        readonly IFileSystem m_FileSystem;

        public ModuleProjectRetriever(IFileSystem fileSystem)
        {
            m_FileSystem = fileSystem;
        }

        public string GetMainEntryProjectName(string solutionPath)
        {
            if (!m_FileSystem.FileExists(solutionPath))
            {
                throw new FileNotFoundException($"No solution found at {solutionPath}. " +
                                                "You can generate a solution for this ccmr by clicking on " +
                                                "the ccmr asset associated with this solution path, then \"Generate Solution\" in its " +
                                                "inspector. If a solution already exists, make sure that the " +
                                                "reference path in the ccmr corresponds to the path of the solution.");
            }

            try
            {
                var pubXmlPath = GetPublishProfilePath(solutionPath);

                var csProjFilePath = GetCsProjFilePath(pubXmlPath, solutionPath);

                return Path.GetFileNameWithoutExtension(csProjFilePath);
            }
            catch (FailedProjectRetrieverException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception($"Could not find main project name for solution {solutionPath}. " +
                                     "Make sure that the solution and .csproj exist. Full exception:" +
                                     $"{Environment.NewLine} {e}");
            }
        }

        string GetCsProjFilePath(string pubXmlPath, string solutionPath)
        {
            var xml = Path.GetDirectoryName(pubXmlPath)!;
            string[] csprojFiles = m_FileSystem.DirectoryGetFiles(xml, "*.csproj");

            while (m_FileSystem.DirectoryGetParent(xml) != null &&
                   csprojFiles.Length == 0 &&
                   IsChildPath(Path.GetDirectoryName(solutionPath), xml))
            {
                xml = m_FileSystem.DirectoryGetParent(xml)!.ToString();
                csprojFiles = m_FileSystem.DirectoryGetFiles(xml, "*.csproj");
            }

            if (csprojFiles.Length == 0)
            {
                throw new FailedProjectRetrieverException("Could not find the Project associated with the publishing profile. " +
                    "Please make sure your .pubxml file is under the Project hierarchy.");
            }
            else if (csprojFiles.Length >= 2)
            {
                var projectsString = string.Join($"{Environment.NewLine}- ", csprojFiles);
                throw new FailedProjectRetrieverException($"There is more than one project associated with the pubxml at '{pubXmlPath}', please leave only one project. "
                    + $"{Environment.NewLine}Projects:{Environment.NewLine}- {projectsString}");
            }

            return csprojFiles[0];
        }

        static bool IsChildPath(string parentPath, string childPath)
        {
            // Get the full, normalized paths
            string fullPathParent = Path.GetFullPath(parentPath);
            string fullPathChild = Path.GetFullPath(childPath);

            if (fullPathChild.Equals(fullPathParent, StringComparison.OrdinalIgnoreCase))
            {
                return false; // Child path cannot be the same as the parent path
            }

            // Check if the child path starts with the parent path
            return fullPathChild.StartsWith(fullPathParent, StringComparison.OrdinalIgnoreCase);
        }

        string GetPublishProfilePath(string solutionPath)
        {
            var pubXmls = m_FileSystem.DirectoryGetFiles(
                m_FileSystem.GetDirectoryName(solutionPath)!, "*.pubxml",
                SearchOption.AllDirectories);

            if (pubXmls.Length != 1)
            {
                if (pubXmls.Length > 1)
                {
                    throw new FailedProjectRetrieverException("Too many Publish Profiles. Please update your solution to only have 1 .pubxml.");
                }
                throw new FailedProjectRetrieverException("Could not find a Publish Profile.");
            }

            return pubXmls[0];
        }
    }
}
