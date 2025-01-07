using Unity.Services.DeploymentApi.Editor;
using UnityEditor;

namespace Unity.Services.Deployment.Editor.Environments
{
    class ProjectIdProvider : IProjectIdentifierProvider
    {
        public string ProjectId => CloudProjectSettings.projectId;
    }
}
