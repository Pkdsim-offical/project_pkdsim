namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary> Represents a class capable of returning the current ProjectID </summary>
    public interface IProjectIdentifierProvider
    {
        /// <summary> The current object ID </summary>
        public string ProjectId { get; }
    }
}
