using Unity.Services.DeploymentApi.Editor;
#if DEPLOYMENT_API_AVAILABLE_V1_1
using IProjectID = Unity.Services.DeploymentApi.Editor.IProjectIdentifierProvider;
#endif

namespace Unity.Services.CloudCode.Authoring.Editor.Deployment
{
    interface IProjectIdentifierProvider
    {
        public string ProjectId { get; }
    }

    class ProjectIdentifierProvider
#if DEPLOYMENT_API_AVAILABLE_V1_1
        : IProjectID
    {
        public string ProjectId => Deployments.Instance?.ProjectIdProvider?.ProjectId ?? string.Empty;
    }
#else
        : IProjectIdentifierProvider
    {
        public string ProjectId => UnityEditor.CloudProjectSettings.projectId;
    }
#endif
}
