using System.Collections;
using System.Collections.Generic;
#if DEPLOYMENT_API_AVAILABLE_V1_0
using Unity.Services.CloudCode.Authoring.Editor.Modules.UI;
#endif
using Unity.Services.Core.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.Services.CloudCode.Settings
{
    internal class CloudCodeSettingsProvider : EditorGameServiceSettingsProvider
    {
        const string k_Title = "Cloud Code";
        const string k_GoToDashboardContainer = "dashboard-button-container";
        const string k_GoToDashboardBtn = "dashboard-link-button";

        static readonly CloudCodeEditorGameService k_GameService = new CloudCodeEditorGameService();

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new CloudCodeSettingsProvider(SettingsScope.Project);
        }

        protected override IEditorGameService EditorGameService => k_GameService;
        protected override string Title => k_Title;
        protected override string Description => "Connect your game's frameworks through the cloud. Create scripts, interact with your backend services, and effortlessly scale your code based on demand.";

#if DEPLOYMENT_API_AVAILABLE_V1_0

        static CloudCodeModuleGenerateBindingsVisualElement Element { get; set; }
#endif

        public CloudCodeSettingsProvider(SettingsScope scopes)
            : base(GenerateProjectSettingsPath(k_Title), scopes) {}

        protected override VisualElement GenerateServiceDetailUI()
        {
#if DEPLOYMENT_API_AVAILABLE_V1_0
            if (Element == null)
            {
                Element = new CloudCodeModuleGenerateBindingsVisualElement();
            }
            return Element;
#else
            return new VisualElement();
#endif
        }

        /// <summary>
        /// The generator for the UI when unsupported.
        /// </summary>
        /// <returns>The visual element added to the Settings Project page when unsupported.</returns>
        protected override VisualElement GenerateUnsupportedDetailUI()
        {
            return GenerateServiceDetailUI();
        }

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            base.OnActivate(searchContext, rootElement);
            SetDashboardButton(rootElement);
        }

        static void SetDashboardButton(VisualElement rootElement)
        {
            rootElement.Q(k_GoToDashboardContainer).style.display = DisplayStyle.Flex;
            var goToDashboard = rootElement.Q(k_GoToDashboardBtn);

            if (goToDashboard != null)
            {
                var clickable = new Clickable(() =>
                {
                    Application.OpenURL(k_GameService.GetFormattedDashboardUrl());
                });
                goToDashboard.AddManipulator(clickable);
            }
        }
    }
}
