using System;
using UnityEngine;
using Unity.Services.Core.Editor;
using UnityEditor;
using UnityEngine.UIElements;

namespace Unity.Services.CloudBuild.Editor
{
    class CloudBuildSettingsProvider : EditorGameServiceSettingsProvider
    {
        const string k_ProjectSettingsPath = "Build Automation";
        CloudBuildSettingsProvider()
            : base(GetSettingsPath(), SettingsScope.Project)
        {
        }

        internal static string GetSettingsPath()
        {
            return GenerateProjectSettingsPath(k_ProjectSettingsPath);
        }

        protected override IEditorGameService EditorGameService => EditorGameServiceRegistry.Instance.GetEditorGameService<CloudBuildIdentifier>();
        protected override string Title => "Build Automation";
        protected override string Description => "Build games faster";

        protected override VisualElement GenerateServiceDetailUI()
        {
            return CloudBuildSettingsContainerUI.Create(EditorGameService as CloudBuildService);
        }

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
#if ENABLE_EDITOR_GAME_SERVICES
            return new CloudBuildSettingsProvider();
#else
            return null;
#endif
        }
    }
}
