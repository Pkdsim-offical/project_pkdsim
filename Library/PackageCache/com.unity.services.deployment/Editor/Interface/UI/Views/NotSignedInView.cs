using UnityEditor;
using UnityEngine.UIElements;

namespace Unity.Services.Deployment.Editor.Interface.UI.Views
{
#if UNITY_2023_3_OR_NEWER
    [UxmlElement]
#endif
    partial class NotSignedInView : ViewBase
    {
        protected override string UxmlName => "DeploymentWindow_NotSignedIn";

        public NotSignedInView()
        {
            var settingsBtn = this.Q<Button>();
            settingsBtn.clicked += OnSettingsClicked;
        }

        static void OnSettingsClicked()
        {
            SettingsService.OpenProjectSettings("Project/Services");
        }

#if !UNITY_2023_3_OR_NEWER
        new class UxmlFactory : UxmlFactory<NotSignedInView> {}
#endif
    }
}
