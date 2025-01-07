using System.Collections.Generic;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary> Represents information about the ongoing Deployment operation </summary>
    public class DeploymentScope
    {
        /// <summary> Creates a deployment </summary>
        protected internal DeploymentScope() {}
        /// <summary>Items currently being deployed</summary>
        public List<IDeploymentItem> DeploymentList { get; set; }
        /// <summary>Whether the current operation constitutes a DryRun</summary>
        public bool IsDryRun { get; set; }
        /// <summary>Whether the current operation constitutes a Reconcile</summary>
        public bool IsReconcile { get; set; }
    }
}
