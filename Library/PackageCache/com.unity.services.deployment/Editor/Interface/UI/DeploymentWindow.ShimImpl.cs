using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.DeploymentApi.Editor;
using PathIO = System.IO.Path;

namespace Unity.Services.Deployment.Editor.Interface.UI
{
    partial class DeploymentWindow : IDeploymentWindow
    {
        public Task<DeploymentResult<IDeploymentItem>> Deploy(
            IReadOnlyList<IDeploymentItem> items,
            CancellationToken token = default)
        {
            return ((IDeploymentWindow)m_DeploymentViewModel).Deploy(items, token);
        }

        public List<IDeploymentItem> GetFromFiles(IReadOnlyList<string> filePaths)
        {
            return ((IDeploymentWindow)m_DeploymentViewModel).GetFromFiles(filePaths);
        }

        public List<IDeploymentDefinitionItem> GetDeploymentDefinitions()
        {
            return ((IDeploymentWindow)m_DeploymentViewModel).GetDeploymentDefinitions();
        }

        public event Action<IReadOnlyList<IDeploymentItem>> DeploymentStarting
        {
            add => ((IDeploymentWindow)m_DeploymentViewModel).DeploymentStarting += value;
            remove => ((IDeploymentWindow)m_DeploymentViewModel).DeploymentStarting -= value;
        }

        public event Action<IReadOnlyList<IDeploymentItem>> DeploymentEnded
        {
            add => ((IDeploymentWindow)m_DeploymentViewModel).DeploymentEnded += value;
            remove => ((IDeploymentWindow)m_DeploymentViewModel).DeploymentEnded -= value;
        }

        public DeploymentScope GetCurrentDeployment()
        {
            return ((IDeploymentWindow)m_DeploymentViewModel).GetCurrentDeployment();
        }
    }
}
