using System;
using System.Collections.Generic;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary>A deployment item that declares dependencies</summary>
    public interface IDependentItem : IDeploymentItem
    {
        /// <summary> The dependencies declared by the item </summary>
        public IReadOnlyList<IDependency> Dependencies { get; }
        /// <summary>Resolved dependencies. Populated during deployment only.
        /// The implementation should initialize this list, as it should not be null.</summary>
        public List<IDeploymentItem> ResolvedDependencies { get; }
    }

    /// <summary> Represents a reference to a dependency that will be resolved before deployment.
    /// Most likely, it is not a Deployment Item, but some unique way to find it</summary>
    public interface IDependency
    {
        /// <summary> Returns the DeploymentItem that matches the dependency, null otherwise </summary>
        /// <param name="deployedItems">Items that are being deployed</param>
        /// <returns>Item that satisfies the dependency, null otherwise</returns>
        IDeploymentItem Resolve(IReadOnlyList<IDeploymentItem> deployedItems);

        /// <summary>
        /// Depth-first search over the Dependency Items tree over a predicate.Nu
        /// </summary>
        /// <param name="deployedItems">Deployment Items to search through</param>
        /// <param name="predicate">Function to identify relevant item</param>
        /// <returns>First item that matches the predicate</returns>
        static IDeploymentItem Resolve(
            IReadOnlyList<IDeploymentItem> deployedItems,
            Func<IDeploymentItem, bool> predicate)
        {
            if (deployedItems == null || deployedItems.Count == 0)
                return null;

            foreach (IDeploymentItem item in deployedItems)
            {
                if (predicate(item))
                {
                    return item;
                }

                if (item is ICompositeItem compositeItem)
                {
                    var result = Resolve(compositeItem.Children, predicate);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }
    }

    /// <summary> Represents a dependency described by an identifier</summary>
    public class IdentifiedDependency : IDependency
    {
        /// <summary> The identifier of the dependency </summary>
        public string ResourceId { get; set; }

        /// <inheritdoc/>
        public IDeploymentItem Resolve(
            IReadOnlyList<IDeploymentItem> deployedItems)
        {
            return IDependency.Resolve(
                deployedItems,
                di => di is IIdentifiable id && id.ResourceId == ResourceId);
        }

        /// <summary>Returns a string representation of the object</summary>
        /// <returns>The string representation</returns>
        public override string ToString()
        {
            return $"{GetType().Name} - '{ResourceId}'";
        }
    }

    /// <summary> Represents a dependency described by a name</summary>
    public class NamedDependency : IDependency
    {
        /// <summary> The name of the dependency </summary>
        public string ResourceName { get; set; }

        /// <inheritdoc/>
        public IDeploymentItem Resolve(
            IReadOnlyList<IDeploymentItem> deployedItems)
        {
            return IDependency.Resolve(
                deployedItems,
                di => di is INamedResource id && id.ResourceName == ResourceName);
        }

        /// <summary>Returns a string representation of the object</summary>
        /// <returns>The string representation</returns>
        public override string ToString()
        {
            return $"{GetType().Name} - '{ResourceName}'";
        }
    }
}
