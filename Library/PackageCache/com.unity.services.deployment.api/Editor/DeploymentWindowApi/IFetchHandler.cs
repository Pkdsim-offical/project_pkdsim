using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary> Represents the object that is capable of updating, deleting or creating local IDeploymentItems
    /// for a given set of APIs. This class is auxiliary for CLI integration. </summary>
    /// <typeparam name="TIn">The DeploymentItem type</typeparam>
    /// <typeparam name="TOut">The FetchResult type</typeparam>
    public interface IFetchHandler<in TIn, TOut>
        where TOut : DeploymentResult<TIn>
        where TIn : IDeploymentItem
    {
        /// <summary>Fetch into the specified resources asynchronously</summary>
        /// <param name="rootDirectory">The reference directory into which new items may be created</param>
        /// <param name="localResources">Local Resources to deploy</param>
        /// <param name="dryRun">Whether to only perform a dry-run</param>
        /// <param name="reconcile">Whether remote resources not part of a deployment should be deleted</param>
        /// <param name="token">Operation's cancellation token</param>
        /// <returns>The DeploymentResult object</returns>
        Task<TOut> FetchAsync(
            string rootDirectory,
            IReadOnlyList<TIn> localResources,
            bool dryRun = false,
            bool reconcile = false,
            CancellationToken token = default);
    }

    /// <summary> Represents information regarding the result of a deployment </summary>
    /// <typeparam name="T">The DeploymentItem type</typeparam>
    public class FetchResult<T> where T : IDeploymentItem
    {
        /// <summary>Creates a new instance of the DeploymentResult </summary>
        public FetchResult()
        {
            Fetched = new List<T>();
        }

        /// <summary>Creates a new instance of the DeploymentResult from a specified list</summary>
        /// <param name="items">The items</param>
        public FetchResult(IReadOnlyList<T> items)
        {
            Fetched = items.ToList();
        }

        /// <summary>The items affected by the operation.</summary>
        public List<T> Fetched { get; }
    }
}
