using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.Deployment.Editor.Interface.UI;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;

namespace Unity.Services.Deployment.Editor
{
    class DefaultDeploymentWindowImpl : IDeploymentWindow
    {
        const string k_NotImplementedMessage = "Deployment Window must be opened for this operation.";

        public EditorWindow OpenWindow()
        {
            return DeploymentWindow.ShowWindow();
        }

        public Task<DeploymentResult<IDeploymentItem>> Deploy(
            IReadOnlyList<IDeploymentItem> items,
            CancellationToken token = default)
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public List<IDeploymentItem> GetFromFiles(
            IReadOnlyList<string> filePaths)
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public List<IDeploymentDefinitionItem> GetDeploymentDefinitions()
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public event Action<IReadOnlyList<IDeploymentItem>> DeploymentStarting
        {
            add => throw new InvalidOperationException(k_NotImplementedMessage);
            remove => throw new InvalidOperationException(k_NotImplementedMessage);
        }
        public event Action<IReadOnlyList<IDeploymentItem>> DeploymentEnded
        {
            add => throw new InvalidOperationException(k_NotImplementedMessage);
            remove => throw new InvalidOperationException(k_NotImplementedMessage);
        }
        public DeploymentScope GetCurrentDeployment()
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public List<IDeploymentItem> GetChecked()
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public List<IDeploymentItem> GetSelected()
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public void Select(
            IReadOnlyList<IDeploymentItem> deploymentItems)
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public void ClearSelection()
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public void Check(
            IReadOnlyList<IDeploymentItem> deploymentItems)
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }

        public void ClearChecked()
        {
            throw new InvalidOperationException(k_NotImplementedMessage);
        }
    }
}
