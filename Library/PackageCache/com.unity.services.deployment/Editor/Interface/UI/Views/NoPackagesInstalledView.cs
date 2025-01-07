using UnityEngine.UIElements;

namespace Unity.Services.Deployment.Editor.Interface.UI.Views
{
#if UNITY_2023_3_OR_NEWER
    [UxmlElement]
#endif
    partial class NoPackagesInstalledView : ViewBase
    {
        const string k_SupportedPackagesAnchor = "supported-packages";
        const string k_DocumentationButton = "DocumentationButton";
        protected override string UxmlName => "DeploymentWindow_NoPackagesInstalled";

        public NoPackagesInstalledView()
        {
            var documentationButton = this.Q<Button>(k_DocumentationButton);
            documentationButton.clicked += () => DocumentationHelper.OpenHelpDocumentation(k_SupportedPackagesAnchor);
        }

#if !UNITY_2023_3_OR_NEWER
        new class UxmlFactory : UxmlFactory<NoPackagesInstalledView> {}
#endif
    }
}
