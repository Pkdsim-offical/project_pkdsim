using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.Deployment.Editor.Model;
using Unity.Services.Deployment.Editor.Shared.Analytics;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;
using PathIO = System.IO.Path;

namespace Unity.Services.Deployment.Editor.Interface
{
    partial class DeploymentViewModel : IDeploymentWindow
    {
        const string k_NotImplementedMessage = "Deployment Window must be opened for this operation.";

        DeploymentScope m_DeploymentScope = null;

        public async Task<DeploymentResult<IDeploymentItem>> Deploy(
            IReadOnlyList<IDeploymentItem> items,
            CancellationToken token = default)
        {
            if (items.Any(i => i == null))
                throw new ArgumentException("One or more items are null.", nameof(items));
            var divms = GetDeploymentItemViewModels(items);
            m_Analytics.Send(new ICommonAnalytics.CommonEventPayload { action = "deployment_api_deploy" });
            await DeployItemsAsync(divms, new int[0]);
            return new DeploymentResult<IDeploymentItem>(items);
        }

        public DeploymentScope GetCurrentDeployment()
        {
            return m_DeploymentScope;
        }

        public List<IDeploymentItem> GetFromFiles(IReadOnlyList<string> filePaths)
        {
            m_Analytics.Send(new ICommonAnalytics.CommonEventPayload { action = "deployment_api_get_files" });
            var map = CreatePathToDeploymentItemMap();

            var result = new List<IDeploymentItem>();
            foreach (var filePath in filePaths)
            {
                var normalizedPath = Path
                    .GetFullPath(filePath)
                    .Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

                if (map.TryGetValue(normalizedPath, out IDeploymentItem item))
                    result.Add(item);
                else
                    result.Add(null);
            }

            return result;
        }

        public List<IDeploymentDefinitionItem> GetDeploymentDefinitions()
        {
            var list = new List<IDeploymentDefinitionItem>();
            foreach (var ddefvm in DeploymentDefinitions)
            {
                var ddefdi = DeploymentDefinitionDeploymentItem.FromViewModel(ddefvm);
                list.Add(ddefdi);
            }
            return list;
        }

        class TemporaryCompositeItem : DeploymentItem, ICompositeItem
        {
            public TemporaryCompositeItem(IDeploymentItem first)
            {
                Path = first.Path;
                Name = PathIO.GetFileNameWithoutExtension(Path);
                MutableChildren.Add(first);
            }

            public IReadOnlyList<IDeploymentItem> Children => MutableChildren;
            internal List<IDeploymentItem> MutableChildren { get; } = new List<IDeploymentItem>();
        }

        Dictionary<string, IDeploymentItem> CreatePathToDeploymentItemMap()
        {
            var map = new Dictionary<string, IDeploymentItem>();
            foreach (var ddef in DeploymentDefinitions)
            {
                var ddefdi = DeploymentDefinitionDeploymentItem.FromViewModel(ddef);
                var path = NormalizePath(ddefdi.Path);
                map.Add(path, ddefdi);

                foreach (var di in ddef.DeploymentItemViewModels)
                {
                    var normalized = NormalizePath(di.Path);

                    if (map.TryGetValue(normalized, out IDeploymentItem item))
                    {
                        //Deal with Multiplay
                        var composite = (item as TemporaryCompositeItem) ?? new TemporaryCompositeItem(item);
                        composite.MutableChildren.Add(di.OriginalItem);
                        map[normalized] = composite;
                    }
                    else
                    {
                        map.Add(normalized, di.OriginalItem);
                    }
                }
            }

            return map;
        }

        static string NormalizePath(string path)
        {
            return Path
                .GetFullPath(path)
                .Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }

        HashSet<IDeploymentItemViewModel> GetDeploymentItemViewModels(IReadOnlyList<IDeploymentItem> items)
        {
            var divms = new HashSet<IDeploymentItemViewModel>();
            foreach (var deploymentItem in items)
            {
                bool found = SearchForDeploymentItem(deploymentItem, divms);

                if (!found)
                    throw new InvalidOperationException($"DeploymentItem '{deploymentItem.Path}' was not found.");
            }

            return divms;
        }

        bool SearchForDeploymentItem(IDeploymentItem deploymentItem, HashSet<IDeploymentItemViewModel> divms)
        {
            bool found = false;
            foreach (var ddef in DeploymentDefinitions)
            {
                if (ddef.Model.Path == deploymentItem.Path)
                {
                    foreach (var divm in ddef.DeploymentItemViewModels)
                        divms.Add(divm);
                    found = true;
                    break;
                }

                foreach (var divm in ddef.DeploymentItemViewModels)
                {
                    if (divm.OriginalItem == deploymentItem)
                    {
                        divms.Add(divm);
                        found = true;
                        break;
                    }
                }
            }

            return found;
        }

        void ResolveDependencies(IReadOnlyList<IDeploymentItem> items)
        {
            foreach (var dependant in items.OfType<IDependentItem>())
            {
                if (!IsValidDependent(dependant))
                    continue;

                dependant.ResolvedDependencies.Clear();
                foreach (var dependency in dependant.Dependencies)
                {
                    IDeploymentItem resolved = null;
                    try
                    {
                        resolved = dependency.Resolve(items);
                    }
                    catch (Exception e)
                    {
                        //user-code error
                        m_Logger.LogError($"Resolved dependency '{dependency}' for '{dependant.Name}' of type '{dependant.GetType().Name}' failed. Reason: {e}");
                    }
                    dependant.ResolvedDependencies.Add(resolved);
                }
            }
        }

        bool IsValidDependent(IDependentItem dependant)
        {
            if (dependant.Dependencies == null)
            {
                m_Logger.LogError(
                    $"Item '{dependant}' has uninitialized '{nameof(IDependentItem.ResolvedDependencies)}' list ");
                return false;
            }

            if (dependant.ResolvedDependencies == null)
            {
                m_Logger.LogError($"Item '{dependant}' has uninitialized '{nameof(IDependentItem.Dependencies)}' list ");
                return false;
            }

            return true;
        }

        void ClearDependencies(IReadOnlyList<IDeploymentItem> items)
        {
            foreach (var item in items.OfType<IDependentItem>())
            {
                if (item.ResolvedDependencies == null)
                    continue;

                item.ResolvedDependencies.Clear();
            }
        }

        EditorWindow IDeploymentWindow.OpenWindow() { throw new InvalidOperationException(k_NotImplementedMessage); }
        List<IDeploymentItem> IDeploymentWindow.GetChecked() { throw new InvalidOperationException(k_NotImplementedMessage); }
        List<IDeploymentItem> IDeploymentWindow.GetSelected() { throw new InvalidOperationException(k_NotImplementedMessage); }
        void IDeploymentWindow.Select(IReadOnlyList<IDeploymentItem> deploymentItems) { throw new InvalidOperationException(k_NotImplementedMessage); }
        void IDeploymentWindow.ClearSelection() { throw new InvalidOperationException(k_NotImplementedMessage); }
        void IDeploymentWindow.Check(IReadOnlyList<IDeploymentItem> deploymentItems) { throw new InvalidOperationException(k_NotImplementedMessage); }
        void IDeploymentWindow.ClearChecked() { throw new InvalidOperationException(k_NotImplementedMessage); }
    }
}
