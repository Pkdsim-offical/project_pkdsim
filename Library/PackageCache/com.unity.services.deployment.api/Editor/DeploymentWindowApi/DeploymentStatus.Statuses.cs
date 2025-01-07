using System;

namespace Unity.Services.DeploymentApi.Editor
{
    public partial struct DeploymentStatus
    {
        /// <summary> A status to represent an item that is up to date with the remote. </summary>
        public static readonly DeploymentStatus UpToDate = new DeploymentStatus("Up to date", string.Empty, SeverityLevel.Success);
        /// <summary> A status to represent an item that was modified locally. </summary>
        public static readonly DeploymentStatus ModifiedLocally = new DeploymentStatus("Modified locally, deploy to update", string.Empty, SeverityLevel.Warning);
        /// <summary>A status to represent an item that failed to deploy. </summary>
        public static readonly DeploymentStatus FailedToDeploy = new DeploymentStatus("Failed to deploy", string.Empty, SeverityLevel.Error);
        /// <summary> An empty status. </summary>
        public static readonly DeploymentStatus Empty = new DeploymentStatus(string.Empty, string.Empty, SeverityLevel.None);

        /// <summary> Helper method for Failed to fetch status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFailedToFetch(string details)
            => new("Failed to fetch", details, SeverityLevel.Error);
        /// <summary> Helper field for Failed to fetching status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFetching(string details) => new("Fetching", details, SeverityLevel.Info);
        /// <summary> Helper method for Fetched status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFetched(string details) => new("Fetched", details, SeverityLevel.Success);

        /// <summary> Helper method for Failed to deploy status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFailedToDeploy(string details)
            => new("Failed to deploy", details, SeverityLevel.Error);
        /// <summary> Helper method for Deploying status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetDeploying(string details = null)
            => new("Deploying", details ?? string.Empty, SeverityLevel.Info);
        /// <summary> Helper method for Deployed status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetDeployed(string details)
            => new("Deployed",  details, SeverityLevel.Success);

        /// <summary> Helper method for Failed to load status </summary>
        /// <param name="e">Exception details</param>
        /// <param name="path">Path of asset that failed</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFailedToLoad(Exception e, string path)
            => new("Failed to load", $"Failed to load '{path}'. Reason: {e.Message}", SeverityLevel.Error);
        /// <summary> Helper method for Failed to read status </summary>
        /// <param name="e">Exception details</param>
        /// <param name="path">Path of asset that failed</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFailedToRead(Exception e, string path)
            => new("Failed to read", $"Failed to read '{path}'. Reason: {e.Message}", SeverityLevel.Error);
        /// <summary> Helper method for Failed to write status </summary>
        /// <param name="e">Exception details</param>
        /// <param name="path">Path of asset that failed</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFailedToWrite(Exception e, string path)
            => new("Failed to write", $"Failed to write '{path}'. Reason: {e.Message}", SeverityLevel.Error);
        /// <summary> Helper method for Failed to serialize status </summary>
        /// <param name="e">Exception details</param>
        /// <param name="path">Path of asset that failed</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFailedToSerialize(Exception e, string path)
            => new("Failed to serialize", $"Failed to serialize '{path}'. Reason: {e.Message}", SeverityLevel.Error);
        /// <summary> Helper method for Failed to delete status </summary>
        /// <param name="e">Exception details</param>
        /// <param name="path">Path of asset that failed</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetFailedToDelete(Exception e, string path)
            => new("Failed to serialize", $"Failed to delete '{path}'. Reason: {e.Message}", SeverityLevel.Error);

        /// <summary> Helper method for Partial deploy status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetPartialDeploy(string details)
            => new DeploymentStatus(
            "Partially deployed",
            details ?? "Some items were not successfully deployed, see sub-items for details",
            SeverityLevel.Warning);

        /// <summary> Helper method for Partial fetch status </summary>
        /// <param name="details">Details of the status</param>
        /// <returns>The Deployment Status</returns>
        public static DeploymentStatus GetPartialFetch(string details)
            => new DeploymentStatus(
            "Partially deployed",
            details ?? "Some items were not successfully fetched, see sub-items for details",
            SeverityLevel.Warning);
    }
}
