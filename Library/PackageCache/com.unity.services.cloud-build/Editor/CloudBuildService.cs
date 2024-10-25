using Unity.Services.Core.Editor;

namespace Unity.Services.CloudBuild.Editor
{
    class CloudBuildService : IEditorGameService
    {
        public string Name => "Build";
        public IEditorGameServiceIdentifier Identifier { get; } = new CloudBuildIdentifier();
        public bool RequiresCoppaCompliance => false;
        public bool HasDashboard => true;

        public string GetFormattedDashboardUrl() => CloudBuildDashboardUrls.GetAboutUrl();

        internal CloudBuildApiClient ApiClient { get; } = new CloudBuildApiClient();

        public IEditorGameServiceEnabler Enabler { get; } = new CloudBuildEditorGameServiceEnabler();
    }
}
