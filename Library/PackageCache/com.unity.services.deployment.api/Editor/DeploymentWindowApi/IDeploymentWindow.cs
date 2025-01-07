using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary> Provides access to the Deployment Window operations </summary>
    public interface IDeploymentWindow
    {
        /// <summary>
        /// Deploys the specified items
        /// </summary>
        /// <param name="items">The deployment items to be deployed</param>
        /// <param name="token">Cancellation token for the operation</param>
        /// <returns>The DeploymentResult object</returns>
        Task<DeploymentResult<IDeploymentItem>> Deploy(
            IReadOnlyList<IDeploymentItem> items,
            CancellationToken token = default);

        /// <summary>
        /// Gets the associated IDeploymentItems for the given paths.
        /// If no item is found, null will be returned in its ordinal position.
        /// If more than one item is found, a <see cref="ICompositeItem"/> will be returned instead.
        /// </summary>
        /// <param name="filePaths">The paths for which to find the associated IDeploymentItems</param>
        /// <returns>The items associated with the paths</returns>
        List<IDeploymentItem> GetFromFiles(
            IReadOnlyList<string> filePaths);

        /// <summary> Gets the deployment definitions that are currently available</summary>
        /// <returns>The deployment definitions</returns>
        List<IDeploymentDefinitionItem> GetDeploymentDefinitions();

        #if UNITY_EDITOR
        /// <summary> Opens the Deployment Window </summary>
        UnityEditor.EditorWindow OpenWindow();
        #else
        /// <summary> Opens the Deployment Window </summary>
        void OpenWindow();
        #endif

        /// <summary> This event is fired before when a deployment is triggered in the deployment window </summary>
        event Action<IReadOnlyList<IDeploymentItem>> DeploymentStarting;
        /// <summary> This event is fired after a deployment has ended</summary>
        event Action<IReadOnlyList<IDeploymentItem>> DeploymentEnded;
        /// <summary> Represents information about the ongoing Deployment operation </summary>
        /// <returns>The current scope. Null, if no deployment in progress</returns>
        DeploymentScope GetCurrentDeployment();

        /// <summary>Gets the currently selected items. Only available if the DeploymentWindow is open.</summary>
        /// <returns>The selected items.</returns>
        List<IDeploymentItem> GetChecked();

        /// <summary>Gets the currently checked items. Only available if the DeploymentWindow is open.</summary>
        /// <returns>The selected items.</returns>
        List<IDeploymentItem> GetSelected();

        /// <summary>Selects the associated Deployment Items if they exist in the DeploymentWindow.
        /// Only available if the DeploymentWindow is open.</summary>
        /// <param name="deploymentItems">The deployment items to select</param>
        void Select(IReadOnlyList<IDeploymentItem> deploymentItems);

        /// <summary>
        /// Clears the current Deployment Window selection. Only available if the DeploymentWindow is open.
        /// </summary>
        void ClearSelection();

        /// <summary>Checks the associated Deployment Items if they exist in the DeploymentWindow.
        /// Only available if the DeploymentWindow is open.</summary>
        /// <param name="deploymentItems">The deployment items to check</param>
        void Check(
            IReadOnlyList<IDeploymentItem> deploymentItems);

        /// <summary>
        /// Clears the current Deployment Window checked state.
        /// </summary>
        void ClearChecked();
    }

    /// <summary> Provides additional methods to facilitate using IDeploymentWindow </summary>
    public static class DeploymentWindowExtensions
    {
        /// <summary>
        /// Deploys the specified deployment items by path.
        /// </summary>
        /// <param name="self">The IDeploymentWindow implementation</param>
        /// <param name="filePaths">The File Paths to deploy</param>
        /// <param name="token">Cancellation token for the operation</param>
        /// <returns>The DeploymentResult object</returns>
        public static Task<DeploymentResult<IDeploymentItem>> Deploy(
            this IDeploymentWindow self,
            IReadOnlyList<string> filePaths,
            CancellationToken token = default)
        {
            var items = self.GetFromFiles(filePaths);
            return self.Deploy(items, token);
        }

        /// <summary>
        /// Gets all the currently available DeploymentItems
        /// </summary>
        /// <param name="self">The IDeploymentWindow implementation</param>
        /// <param name="includeDeploymentDefinitions">Whether or not to include the DeploymentDefinitions as part of the result</param>
        /// <returns>The found DeploymentItems</returns>
        public static List<IDeploymentItem> GetAllDeploymentItems(
            this IDeploymentWindow self,
            bool includeDeploymentDefinitions = false)
        {
            var ddefs = self.GetDeploymentDefinitions();
            var res = new List<IDeploymentItem>();
            foreach (IDeploymentDefinitionItem ddef in ddefs)
            {
                if (includeDeploymentDefinitions)
                    res.Add(ddef);
                res.AddRange(ddef.Children);
            }

            return res;
        }
    }
}
