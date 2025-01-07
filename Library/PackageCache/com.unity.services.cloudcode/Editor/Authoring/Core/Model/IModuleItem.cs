using Unity.Services.DeploymentApi.Editor;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Model
{
    interface IModuleItem : IDeploymentItem, ITypedItem
    {
        string SolutionPath { get; }
        string CcmPath { get; set; }
        string ModuleName { get; set; }

        new float Progress { get; set; }
    }
}
