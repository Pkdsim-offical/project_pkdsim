using System.Collections.Generic;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary>Information regarding a deployment definition</summary>
    public interface IDeploymentDefinitionItem : ICompositeItem
    {
        /// <summary> The paths excluded by the DeploymentDefinition </summary>
        IReadOnlyList<string> ExcludePaths { get; }
    }
}
