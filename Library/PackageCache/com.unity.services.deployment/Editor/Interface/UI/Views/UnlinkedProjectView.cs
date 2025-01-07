using UnityEditor;
using UnityEngine.UIElements;

namespace Unity.Services.Deployment.Editor.Interface.UI.Views
{
#if UNITY_2023_3_OR_NEWER
    [UxmlElement]
#endif
    partial class UnlinkedProjectView : ViewBase
    {
        protected override string UxmlName => "DeploymentWindow_UnlinkedProject";

        public UnlinkedProjectView()
        {
            var settingsBtn = this.Q<Button>();
            settingsBtn.clicked += OnSettingsClicked;
        }

        void OnSettingsClicked()
        {
            SettingsService.OpenProjectSettings("Project/Services");
        }

#if !UNITY_2023_3_OR_NEWER
        new class UxmlFactory : UxmlFactory<UnlinkedProjectView> {}
#endif
    }
}
