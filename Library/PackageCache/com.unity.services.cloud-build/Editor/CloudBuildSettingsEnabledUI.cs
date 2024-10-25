using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.Services.CloudBuild.Editor
{
    static class CloudBuildSettingsEnabledUI
    {
        const string k_EnabledUxml = "Packages/com.unity.services.cloud-build/Editor/UXML/CloudBuildProjectSettingsStateEnabled.uxml";

        const string k_PollFooter = "PollFooter";
        const string k_PollFooterSection = "PollFooterSection";
        const string k_PollToggle = "PollToggle";
        const string k_HistoryButton = "HistoryButton";
        const string k_UploadButton = "UploadButton";
        const string k_ManageTargetButton = "ManageTargetButton";
        const string k_NoTargetContainer = "NoTargetContainer";

        const string k_CloudBuildContainer = "cloud-build-container";
        const string k_CloudProgress = "cloud-progress";
        const string k_TargetContainerTitle = "target-container-title";
        const string k_TargetContainer = "target-container";
        const string k_Separator = "separator";

        const string k_LabelConfiguredTargets = "Build targets";
        const string k_SubscriptionPersonal = "personal";
        const string k_SubscriptionTeamsBasic = "teams basic";

        const string k_NumberOfBuildsToQuery = "25";

        public static VisualElement Create(CloudBuildApiClient apiClient)
        {
            var enabledUIAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(k_EnabledUxml);
            VisualElement enabledUI = null;
            if (enabledUIAsset != null)
            {
                enabledUI = enabledUIAsset.CloneTree().contentContainer;
                enabledUI.Q(className: k_CloudBuildContainer).style.display = DisplayStyle.None;
                enabledUI.Q(k_PollFooterSection).style.display = DisplayStyle.None;

                SetupHistoryButton(enabledUI);
                SetupUploadButton(enabledUI);
                SetupManageTargetButton(enabledUI);

                CloudBuildSettingsProjectInfoQuery.Fetch(apiClient, OnProjectInfoFetched, Debug.LogException);
            }

            return enabledUI;

            void OnProjectInfoFetched(CloudBuildSettingsProjectInfoQueryResult projectInfo)
            {
                var buildingAllowed = BuildingAllowed(projectInfo.BillingLabel);
                SetupBuildTargets(enabledUI, projectInfo, buildingAllowed, apiClient);
                SetupPollerToggle(enabledUI, projectInfo, apiClient);
                enabledUI.Q(className: k_CloudBuildContainer).style.display = DisplayStyle.Flex;
                enabledUI.Q(className: k_CloudProgress).style.display = DisplayStyle.None;
            }
        }

        static void SetupHistoryButton(VisualElement parentElement)
        {
            BindButton(parentElement, k_HistoryButton, OnHistoryClicked);
        }

        static void OnHistoryClicked()
        {
            EditorGameServiceAnalyticsSender.SendProjectSettingsBuildHistoryEvent();
            var url = CloudBuildDashboardUrls.GetHistoryUrl();
            Application.OpenURL(url);
        }

        static void SetupUploadButton(VisualElement parentElement)
        {
            BindButton(parentElement, k_UploadButton, OnUploadClicked);
        }

        static void OnUploadClicked()
        {
            EditorGameServiceAnalyticsSender.SendProjectSettingsUploadBuildEvent();
            var url = CloudBuildDashboardUrls.GetUploadUrl();
            Application.OpenURL(url);
        }

        static void SetupManageTargetButton(VisualElement parentElement)
        {
            var manageTargetButton = BindButton(parentElement, k_ManageTargetButton, OnManageTargetClicked);
        }

        static void OnManageTargetClicked()
        {
            EditorGameServiceAnalyticsSender.SendProjectSettingsManageTargetEvent();
            var url = CloudBuildDashboardUrls.GetConfigUrl();
            Application.OpenURL(url);
        }

        static void SetupBuildTargets(VisualElement parentElement, CloudBuildSettingsProjectInfoQueryResult projectInfo,
            bool buildingAllowed, CloudBuildApiClient apiClient)
        {
            if (projectInfo.Targets.Count > 0)
            {
                parentElement.Q(k_NoTargetContainer).style.display = DisplayStyle.None;
                parentElement.Q(k_PollFooter).style.display = DisplayStyle.Flex;
                parentElement.Q(k_PollFooterSection).style.display = DisplayStyle.Flex;

                parentElement.Q<TextElement>(className: k_TargetContainerTitle).text = k_LabelConfiguredTargets;
                var targetContainer = parentElement.Q(className: k_TargetContainer);
                foreach (var target in projectInfo.Targets)
                {
                    if (target.Enabled)
                        AddBuildTarget(targetContainer, target, buildingAllowed, apiClient);
                }
            }
        }

        static void AddBuildTarget(VisualElement parentContainer, ProjectBuildTarget target, bool buildingAllowed,
            CloudBuildApiClient apiClient)
        {
            var targetUI = CloudBuildSettingsBuildTargetUI.Create(target, buildingAllowed, apiClient);
            if (targetUI != null)
            {
                parentContainer.Add(targetUI);
                var separator = new VisualElement();
                separator.AddToClassList(k_Separator);
                parentContainer.Add(separator);
            }
        }

        static void SetupPollerToggle(VisualElement parentElement, CloudBuildSettingsProjectInfoQueryResult projectInfo,
            CloudBuildApiClient apiClient)
        {
            if (projectInfo.Targets.Count > 0)
            {
                var finalPollingHref = projectInfo.PollingHref.Remove(projectInfo.PollingHref.Length - 1, 1)
                    + k_NumberOfBuildsToQuery;
                var pollerToggle = parentElement.Q<Toggle>(k_PollToggle);
                if (!CloudBuildPoller.Instance.EverEnabled)
                    CloudBuildPoller.Instance.StartPolling(finalPollingHref, apiClient);

                pollerToggle.SetValueWithoutNotify(CloudBuildPoller.Instance.Enabled);
                pollerToggle.RegisterValueChangedCallback(OnPollerToggleValueChanged);

                void OnPollerToggleValueChanged(ChangeEvent<bool> changeEvent)
                {
                    EditorGameServiceAnalyticsSender.SendProjectSettingsBuildNotificationsEvent(changeEvent.newValue);
                    if (changeEvent.newValue)
                        CloudBuildPoller.Instance.StartPolling(finalPollingHref, apiClient);
                    else
                        CloudBuildPoller.Instance.StopPolling();
                }
            }
            else
            {
                CloudBuildPoller.Instance.StopPolling();
            }
        }

        static VisualElement BindButton(VisualElement parentElement, string uxmlNode, Action onClick)
        {
            var button = parentElement.Q<Button>(uxmlNode);
            if (button != null)
                button.clicked += onClick;
            return button;
        }

        static bool BuildingAllowed(string billingPlan)
        {
            bool allowed = !(billingPlan.Equals(k_SubscriptionPersonal, StringComparison.InvariantCultureIgnoreCase)
                || billingPlan.Equals(k_SubscriptionTeamsBasic, StringComparison.InvariantCultureIgnoreCase));
            return allowed;
        }
    }
}
