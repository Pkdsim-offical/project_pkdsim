using UnityEditor;

namespace Unity.Services.CloudBuild.Editor
{
    static class CloudBuildTopMenu
    {
        const int k_ConfigureMenuPriority = 100;
        const string k_ServiceMenuRoot = "Services/Build Automation/";
        const string k_ServiceMenuConfigure = k_ServiceMenuRoot + "Configure";

        [MenuItem(k_ServiceMenuConfigure, priority = k_ConfigureMenuPriority)]
        static void ShowProjectSettings()
        {
            EditorGameServiceAnalyticsSender.SendTopMenuConfigureEvent();
            SettingsService.OpenProjectSettings(CloudBuildSettingsProvider.GetSettingsPath());
        }
    }
}
