using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.Services.CloudBuild.Editor
{
    static class CloudBuildSettingsContainerUI
    {
        const string k_CommonUxml = "Packages/com.unity.services.cloud-build/Editor/UXML/CloudBuildProjectSettings.uxml";
        const string k_CommonUss = "Packages/com.unity.services.cloud-build/Editor/USS/CloudBuildStyleSheet.uss";
        const string k_CloudBuild = "cloudbuild";
        const string k_ScrollContainer = "scroll-container";
        const string k_LearnMore = "LearnMore";
        const string k_LearnMoreUrl = "https://unity.com/solutions/ci-cd";

        public static VisualElement Create(CloudBuildService service)
        {
            var commonUIAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(k_CommonUxml);
            VisualElement commonUI = null;
            if (commonUIAsset != null)
            {
                commonUI = commonUIAsset.CloneTree().contentContainer;
                SetupStyleSheets(commonUI);

                VisualElement uiPanel;
                if (service.Enabler.IsEnabled())
                {
                    uiPanel = CloudBuildSettingsEnabledUI.Create(service.ApiClient);
                }
                else
                {
                    CloudBuildPoller.Instance.StopPolling();
                    CloudBuildPoller.Instance.EverEnabled = false;
                    uiPanel = CloudBuildSettingsDisabledUI.Create();
                }

                if (uiPanel != null)
                {
                    var scrollContainer = commonUI.Q(className: k_ScrollContainer);
                    scrollContainer.Clear();
                    scrollContainer.Add(uiPanel);
                }

                SetupLearnMoreButton(commonUI);
            }
            return commonUI;
        }

        static void SetupStyleSheets(VisualElement parentElement)
        {
            parentElement.AddToClassList(k_CloudBuild);
            var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(k_CommonUss);
            if (styleSheet != null)
                parentElement.styleSheets.Add(styleSheet);
        }

        static void SetupLearnMoreButton(VisualElement parentElement)
        {
            var learnMoreButton = parentElement.Q(k_LearnMore);
            if (learnMoreButton != null)
            {
                var clickable = new Clickable(() =>
                {
                    EditorGameServiceAnalyticsSender.SendProjectSettingsLearnMoreEvent();
                    Application.OpenURL(L10n.Tr(k_LearnMoreUrl));
                });
                learnMoreButton.AddManipulator(clickable);
            }
        }
    }
}
