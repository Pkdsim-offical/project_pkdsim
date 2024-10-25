using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

namespace Unity.Services.CloudBuild.Editor
{
    static class CloudBuildDashboardUrls
    {
        const string k_HomeFormat = "https://dashboard.unity3d.com/organizations/{0}/projects/{1}/cloud-build";

        public static string GetHomeUrl()
            => FillUrlWithOrganizationAndProjectIds(k_HomeFormat);

        public static string GetAboutUrl()
            => FillUrlWithOrganizationAndProjectIds($"{k_HomeFormat}/history");

        public static string GetHistoryUrl()
            => FillUrlWithOrganizationAndProjectIds($"{k_HomeFormat}/history");

        public static string GetConfigUrl()
            => FillUrlWithOrganizationAndProjectIds($"{k_HomeFormat}/config");

        public static string GetUploadUrl()
            => FillUrlWithOrganizationAndProjectIds($"{k_HomeFormat}/history?upload=true");

        static string FillUrlWithOrganizationAndProjectIds(string url)
        {
#if ENABLE_EDITOR_GAME_SERVICES
            var organization = CloudProjectSettings.organizationKey;
#else
            var organization = CloudProjectSettings.organizationId;
#endif
            var filledUrl = string.Format(url, organization, CloudProjectSettings.projectId);

            return filledUrl;
        }
    }
}
