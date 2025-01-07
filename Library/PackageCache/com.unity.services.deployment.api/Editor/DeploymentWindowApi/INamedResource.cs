namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary> Auxiliary interface to represent an object with a unique name identifier </summary>
    public interface INamedResource
    {
        /// <summary> The unique resource name </summary>
        public string ResourceName { get; }
    }
}
