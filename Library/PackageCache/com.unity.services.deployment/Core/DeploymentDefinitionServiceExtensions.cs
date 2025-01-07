using System.IO;
using System.Linq;
using System.Text;
using GlobExpressions;
using Unity.Services.Deployment.Core.Model;

namespace Unity.Services.Deployment.Core
{
    static class DeploymentDefinitionServiceExtensions
    {
        public static bool HasDuplicateDeploymentDefinitions(this IDeploymentDefinitionService service, out string duplicationError)
        {
            duplicationError = string.Empty;
            var paths = service.DeploymentDefinitions
                .Select(dDef => Path.GetDirectoryName(dDef.Path));
            var duplicates = paths
                .GroupBy(p => p)
                .Where(g => g.Count() > 1)
                .Select(x => x.Key)
                .ToList();

            if (duplicates.Any())
            {
                var error = new StringBuilder();
                duplicates.ForEach(path =>
                    error.AppendLine($"Folder <{path}> contains multiple deployment definition files."));

                duplicationError = error.ToString().TrimEnd();

                return true;
            }

            return false;
        }

        public static bool IsPathExcludedByDeploymentDefinition(
            this IDeploymentDefinitionService service,
            string path,
            IDeploymentDefinition deploymentDefinition)
        {
            var isExcluded = false;
            foreach (var excludePath in deploymentDefinition.ExcludePaths)
            {
                var normalizedPath = GetNormalizedPath(path);
                var normalizedItemFullPath = GetNormalizedPath(Path.GetFullPath(path));
                var normalizedExcludePath = GetNormalizedPath(excludePath);

                if (Glob.IsMatch(normalizedPath, normalizedExcludePath)
                    || Glob.IsMatch(normalizedItemFullPath, normalizedExcludePath)
                    || Glob.IsMatch(Path.GetFileName(normalizedPath), normalizedExcludePath))
                {
                    isExcluded = true;
                }

                // see if relative path is a match
                if (!isExcluded)
                {
                    var parentDir = Directory.GetParent(deploymentDefinition.Path);
                    if (parentDir != null)
                    {
                        // transform the relative path into a full path
                        var normalizedExcludeFullPath = GetNormalizedPath(Path.GetFullPath(Path.Combine(parentDir.FullName, excludePath)));
                        isExcluded = Glob.IsMatch(normalizedExcludeFullPath, normalizedItemFullPath);
                    }
                }

                if (isExcluded)
                {
                    return true;
                }
            }

            return false;
        }

        static string GetNormalizedPath(string path)
        {
            return path.Replace('\\', '/');
        }
    }
}
