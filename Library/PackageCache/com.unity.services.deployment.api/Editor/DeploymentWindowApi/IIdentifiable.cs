namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary> Auxiliary interface to represent an object with a unique resource identifier </summary>
    public interface IIdentifiable
    {
        /// <summary> The unique resource ID </summary>
        public string ResourceId { get; }
    }
}
