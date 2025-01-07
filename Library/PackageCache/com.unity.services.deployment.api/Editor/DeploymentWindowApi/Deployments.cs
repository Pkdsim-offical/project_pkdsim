using System.Collections.ObjectModel;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary>
    /// Deployments acts as a container for deployment and environment providers.
    /// </summary>
    public class Deployments
    {
        /// <summary>
        /// Instance of the deployments.
        /// </summary>
        public static Deployments Instance { get; internal set; } = new Deployments();

        /// <summary>
        /// Environment Provider.
        /// </summary>
        public IEnvironmentProvider EnvironmentProvider { get; set; }

        /// <summary>
        /// Project ID provider
        /// </summary>
        public IProjectIdentifierProvider ProjectIdProvider { get; set; }

        /// <summary>
        /// API on current deployment window
        /// </summary>
        public IDeploymentWindow DeploymentWindow { get; set; }

        /// <summary>
        /// Collection of the deployment providers present in the project.
        /// </summary>
        public ObservableCollection<DeploymentProvider> DeploymentProviders { get; } = new ObservableCollection<DeploymentProvider>();

        internal Deployments()
        {
        }
    }
}
