using Newtonsoft.Json;

namespace Unity.Services.CloudBuild.Editor
{
    class Link
    {
        public string href { get; set; }
    }

    class ProjectInfoLinks
    {
        [JsonProperty("self")]
        public Link Self { get; set; }

        [JsonProperty("list_buildTargets")]
        public Link BuildTargets { get; set; }

        [JsonProperty("latest_builds")]
        public Link LatestBuilds { get; set; }
    }

    class GetProjectInfoResponse
    {
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("links")]
        public ProjectInfoLinks Links;
    }

    class EffectiveBillingPlan
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }

    class GetProjectBillingPlanResponse
    {
        [JsonProperty("effective")]
        public EffectiveBillingPlan Effective;
    }

    class ProjectBuildTargetLinks
    {
        [JsonProperty("start_builds")]
        public Link StartBuilds { get; set; }
    }

    class ProjectBuildTarget
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("buildtargetid")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public ProjectBuildTargetLinks Links { get; set; }
    }

    class GetApiStatusResponse
    {
        [JsonProperty("text")]
        public string NotificationText { get; set; }

        [JsonProperty("alertType")]
        public string NotificationAlertType { get; set; }

        [JsonProperty("billingPlan")]
        public string BillingPlan { get; set; }
    }

    class LaunchBuildRequest
    {
        [JsonProperty("clean")]
        public bool Clean { get; set; }
    }

    class LaunchedBuildResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("build")]
        public float Build { get; set; }
    }

    class BuildTargetStatus
    {
        [JsonProperty("build")]
        public float Build { get; set; }

        [JsonProperty("buildtargetid")]
        public string BuildTargetId { get; set; }

        [JsonProperty("buildStatus")]
        public string BuildStatus { get; set; }

        [JsonProperty("buildTargetName")]
        public string BuildTargetName { get; set; }
    }
}
