using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.Services.CloudBuild.Editor
{
    static class CloudBuildSettingsDisabledUI
    {
        const string k_DisabledUxml = "Packages/com.unity.services.cloud-build/Editor/UXML/CloudBuildProjectSettingsStateDisabled.uxml";
        const string k_StartUsingCloudBuild = "StartUsingCloudBuild";
        const string k_StartUsingCloudBuildUrl = "https://docs.unity.com/devops/en/manual/unity-build-automation";

        public static VisualElement Create()
        {
            var disabledUIAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(k_DisabledUxml);
            VisualElement disabledUI = null;
            if (disabledUIAsset != null)
            {
                disabledUI = disabledUIAsset.CloneTree().contentContainer;
                SetupStartUsingCloudBuildButton(disabledUI);
            }

            return disabledUI;
        }

        static void SetupStartUsingCloudBuildButton(VisualElement parentElement)
        {
            var startUsing = parentElement.Q(k_StartUsingCloudBuild);
            if (startUsing != null)
            {
                var clickable = new Clickable(() =>
                {
                    Application.OpenURL(k_StartUsingCloudBuildUrl);
                });
                startUsing.AddManipulator(clickable);
            }
        }
    }
}
