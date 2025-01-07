using System;
using UnityEditor;
using UnityEngine.UIElements;

namespace Unity.Services.Deployment.Editor.Interface.UI.Components
{
#if UNITY_2023_3_OR_NEWER
    [UxmlElement]
#endif
    partial class TreeViewElement : TemplateContainer
    {
        const string k_TemplatePath = "Packages/com.unity.services.deployment/Editor/Interface/UI/Assets/Templates/TreeViewTemplate.uxml";

        public MultiSelect MultiSelect { get; }
        readonly KeyboardShortcutsContainer m_ShortcutsContainer;

        public event Action OnSelectionChanged
        {
            add => MultiSelect.OnSelectionChanged += value;
            remove => MultiSelect.OnSelectionChanged -= value;
        }

        public TreeViewElement()
        {
            var visualTreeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(k_TemplatePath);
            visualTreeAsset.CloneTree(this);
            MultiSelect = this.Q<MultiSelect>();
            m_ShortcutsContainer = this.Q<KeyboardShortcutsContainer>();
        }

        public void BindGUI(IKeyboardShortcuts keyboardShortcuts)
        {
            m_ShortcutsContainer.BindGUI(keyboardShortcuts);
        }

#if !UNITY_2023_3_OR_NEWER
        new class UxmlFactory : UxmlFactory<TreeViewElement> {}
#endif
    }
}
