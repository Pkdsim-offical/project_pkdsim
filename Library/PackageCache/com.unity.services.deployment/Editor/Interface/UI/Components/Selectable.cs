using Unity.Services.Deployment.Editor.Interface.UI.Events;
using UnityEditor;
using UnityEngine.UIElements;
using Toggle = UnityEngine.UIElements.Toggle;

namespace Unity.Services.Deployment.Editor.Interface.UI.Components
{
#if UNITY_2023_3_OR_NEWER
    [UxmlElement]
#endif
    partial class Selectable : Toggle
    {
        const string k_TemplatePath = "Packages/com.unity.services.deployment/Editor/Interface/UI/Assets/Selectable.uss";

        public Selectable()
        {
            styleSheets.Add(AssetDatabase.LoadAssetAtPath<StyleSheet>(k_TemplatePath));
            RegisterCallback<PointerDownEvent>(e =>
            {
                if (e.button == 1)
                {
#if !UNITY_EDITOR_OSX || (!UNITY_2023_2_OR_NEWER && UNITY_EDITOR_OSX)
                    e.StopPropagation();
#endif
                    RightClickedEvent.Send(this);
                }
            });
        }

#if !UNITY_2023_3_OR_NEWER
        new class UxmlFactory : UxmlFactory<Selectable> {}
#endif
    }
}
