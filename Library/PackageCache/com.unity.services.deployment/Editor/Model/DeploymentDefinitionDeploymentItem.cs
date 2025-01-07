using System.Collections.Generic;
using System.Linq;
using Unity.Services.Deployment.Editor.Interface;
using Unity.Services.DeploymentApi.Editor;
using CoreDdef = Unity.Services.Deployment.Core.Model.IDeploymentDefinition;

namespace Unity.Services.Deployment.Editor.Model
{
    class DeploymentDefinitionDeploymentItem : DeploymentItem, IDeploymentDefinitionItem
    {
        public IReadOnlyList<IDeploymentItem> Children { get; internal set; }
        public IReadOnlyList<string> ExcludePaths { get; internal set; }

        public bool IsDefault { get; internal set; }

        public static DeploymentDefinitionDeploymentItem FromViewModel(
            IDeploymentDefinitionViewModel definitionViewModel)
        {
            var ddef = new DeploymentDefinitionDeploymentItem();
            ddef.Name = definitionViewModel.Name;
            ddef.Path = definitionViewModel.Path;

            var children = new List<IDeploymentItem>();
            ddef.Children = children;
            foreach (var di in definitionViewModel.DeploymentItemViewModels.Select(vm => vm.OriginalItem))
            {
                children.Add(di);
            }

            var excludePaths = new List<string>();
            ddef.ExcludePaths = excludePaths;
            foreach (var path in definitionViewModel.ExcludePaths)
            {
                excludePaths.Add(path);
            }

            return ddef;
        }
    }
}
