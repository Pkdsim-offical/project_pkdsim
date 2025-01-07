using System.Collections.Generic;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary>
    /// This interface represents a Deployment Item that is composite
    /// so it has other deployment items inside of it
    /// </summary>
    public interface ICompositeItem : IDeploymentItem
    {
        /// <summary>
        /// The children of the deployment item
        /// </summary>
        IReadOnlyList<IDeploymentItem> Children { get; }
    }
}
