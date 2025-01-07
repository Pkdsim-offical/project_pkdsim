using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Unity.Services.CloudBuild.Editor
{
    class CloudBuildSettingsProjectInfoQueryResult
    {
        public string BillingLabel { get; set; }
        public List<ProjectBuildTarget> Targets { get; set; }
        public string PollingHref { get; set; }
    }

    static class CloudBuildSettingsProjectInfoQuery
    {
        const string k_ErrorProjectStateMismatch = "There is a mismatch between local and web configuration for Unity Build Automation. Please open the Unity Build Automation web dashboard and enable the current project.";
        const string k_ErrorForProjectTeamData = "An unexpected error occurred while querying Unity Build Automation for current project team data. See the console for more information.";
        const string k_ErrorForProjectBuildTargetsData = "An unexpected error occurred while querying Unity Build Automation for current project configured build targets. See the console for more information.";
        const string k_ErrorForApiStatusData = "An unexpected error occurred while querying Unity Build Automation for api status. See the console for more information.";
        const string k_MessageProjectStateMismatch = "There is a mismatch between local and web configuration for Unity Build Automation. Please open the Unity Build Automation web dashboard and enable the current project.";

        const string k_WarningAlertType = "warning";
        const string k_ErrorAlertType = "error";
        const string k_InfoAlertType = "info";

        public static void Fetch(
            CloudBuildApiClient apiClient,
            Action<CloudBuildSettingsProjectInfoQueryResult> onSuccess, Action<Exception> onError)
        {
            apiClient.GetProjectInfo(
                OnGetProjectInfoSucceeded,
                exception => HandleFetchError(k_ErrorProjectStateMismatch, exception, onError));

            void OnGetProjectInfoSucceeded(GetProjectInfoResponse projectInfoResponse)
            {
                if (!projectInfoResponse.Disabled)
                {
                    apiClient.GetProjectBillingPlan(
                        projectInfoResponse.Links.Self.href,
                        OnGetBillingPlanSucceeded,
                        exception => HandleFetchError(k_ErrorForProjectTeamData, exception, onError));
                }
                else
                {
                    Debug.LogError(L10n.Tr(k_MessageProjectStateMismatch));
                }

                void OnGetBillingPlanSucceeded(GetProjectBillingPlanResponse billingResponse)
                {
                    apiClient.GetProjectBuildTargets(
                        projectInfoResponse.Links.BuildTargets.href,
                        OnGetBuildTargetsSucceeded,
                        exception => HandleFetchError(k_ErrorForProjectBuildTargetsData, exception, onError));

                    GetApiStatus(apiClient, billingResponse.Effective.Label);

                    void OnGetBuildTargetsSucceeded(List<ProjectBuildTarget> buildTargets)
                    {
                        var projectInfo = new CloudBuildSettingsProjectInfoQueryResult
                        {
                            BillingLabel = billingResponse.Effective.Label,
                            Targets = buildTargets,
                            PollingHref = projectInfoResponse.Links.LatestBuilds.href
                        };
                        onSuccess?.Invoke(projectInfo);
                    }
                }
            }
        }

        static void HandleFetchError(string notificationMessage, Exception exception, Action<Exception> errorCallback)
        {
            Debug.LogError(notificationMessage);
            Debug.LogException(exception);
            errorCallback?.Invoke(exception);
        }

        static void GetApiStatus(CloudBuildApiClient apiClient, string currentBillingPlan)
        {
            apiClient.GetApiStatus(
                OnGetApiStatusSucceeded,
                exception => HandleFetchError(k_ErrorForApiStatusData, exception, null));

            void OnGetApiStatusSucceeded(List<GetApiStatusResponse> apiStatusList)
            {
                foreach (var apiStatus in apiStatusList)
                {
                    if (string.IsNullOrEmpty(apiStatus.BillingPlan)
                        || apiStatus.BillingPlan.Equals(currentBillingPlan, StringComparison.InvariantCultureIgnoreCase))
                    {
                        switch (apiStatus.NotificationAlertType.ToLower())
                        {
                            case k_WarningAlertType:
                                Debug.LogWarning(apiStatus.NotificationText);
                                break;
                            case k_ErrorAlertType:
                                Debug.LogError(apiStatus.NotificationText);
                                break;
                            case k_InfoAlertType:
                                Debug.Log(apiStatus.NotificationText);
                                break;
                        }
                    }
                }
            }
        }
    }
}
