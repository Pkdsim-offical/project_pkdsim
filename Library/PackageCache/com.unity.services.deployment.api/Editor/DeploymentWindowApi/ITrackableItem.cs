namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary> An item implementing this will override the way of determining the status of a IDeploymentItem,
    /// By default, the last file timestamp will be used to know if a file has been modified.</summary>
    public interface ITrackableItem
    {
        /// <summary> A request to update the status of an item </summary>
        public void TrackOrUpdate();
    }
}
