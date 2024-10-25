using System;
using System.Reflection;
using UnityEngine;
using Unity.Services.Core.Editor;

namespace Unity.Services.CloudBuild.Editor
{
    class CloudBuildEditorGameServiceEnabler : EditorGameServiceFlagEnabler
    {
        protected override string FlagName { get; } = "build";

        protected override void EnableLocalSettings()
        {
            SetLegacyEnabledSetting(true);
        }

        protected override void DisableLocalSettings()
        {
            SetLegacyEnabledSetting(false);
        }

        public override bool IsEnabled()
        {
            return GetLegacyEnabledSetting();
        }

        const string k_LegacyEnabledSettingName = "Build";
        static bool GetLegacyEnabledSetting()
        {
            var playerSettingsType = Type.GetType("UnityEditor.PlayerSettings,UnityEditor.dll");
            var isEnabled = false;
            if (playerSettingsType != null)
            {
                var getCloudServiceEnabledMethod = playerSettingsType.GetMethod("GetCloudServiceEnabled", BindingFlags.Static | BindingFlags.NonPublic);
                if (getCloudServiceEnabledMethod != null)
                {
                    var enabledStateResult = getCloudServiceEnabledMethod.Invoke(null, new object[] {k_LegacyEnabledSettingName});
                    isEnabled = Convert.ToBoolean(enabledStateResult);
                }
            }

            return isEnabled;
        }

        static void SetLegacyEnabledSetting(bool value)
        {
            var playerSettingsType = Type.GetType("UnityEditor.PlayerSettings,UnityEditor.dll");
            if (playerSettingsType != null)
            {
                var setCloudServiceEnabledMethod = playerSettingsType.GetMethod("SetCloudServiceEnabled", BindingFlags.Static | BindingFlags.NonPublic);
                if (setCloudServiceEnabledMethod != null)
                {
                    setCloudServiceEnabledMethod.Invoke(null, new object[] {k_LegacyEnabledSettingName, value});
                }
            }
        }
    }
}
