using UnityEngine.UIElements;

namespace Unity.Services.Deployment.Editor.Interface.UI.Views
{
#if UNITY_2023_3_OR_NEWER
    [UxmlElement]
#endif
    partial class NoConnectionView : ViewBase
    {
        protected override string UxmlName => "DeploymentWindow_NoConnection";

#if !UNITY_2023_3_OR_NEWER
        new class UxmlFactory : UxmlFactory<NoConnectionView> {}
#endif
    }
}
