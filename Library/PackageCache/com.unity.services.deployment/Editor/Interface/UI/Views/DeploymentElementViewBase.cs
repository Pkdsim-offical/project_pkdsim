using System;
using Unity.Services.Deployment.Editor.Interface.UI.Components;
using UnityEditor;
using UnityEngine.UIElements;

namespace Unity.Services.Deployment.Editor.Interface.UI.Views
{
    class DeploymentElementViewBase : VisualElement
    {
        public bool Selected
        {
            get => this.Q<Selectable>().value;
            set => this.Q<Selectable>().value = value;
        }

        public bool Checked
        {
            get => this.Q<CheckmarkToggle>().value;
            set => this.Q<CheckmarkToggle>().value = value;
        }

        public object Model { get; protected set; }
        public event Action<DeploymentElementViewBase, ContextualMenuPopulateEvent> ContextMenuRequested;
        public event Action<DeploymentElementViewBase> DoubleClickDeployed;

        protected DeploymentElementViewBase(string templatePath)
        {
            var visualTreeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(templatePath);
            visualTreeAsset.CloneTree(this);
            Setup();
        }

        protected void Setup()
        {
            focusable = true;
            pickingMode = PickingMode.Position;
            this.AddManipulator(new ContextualMenuManipulator(BuildContextMenu));

            RegisterCallback<ClickEvent>(OnClick);
        }

        protected void BuildContextMenu(ContextualMenuPopulateEvent evt)
        {
            ContextMenuRequested?.Invoke(this, evt);
        }

        protected void OnDoubleClickDeployed()
        {
            DoubleClickDeployed?.Invoke(this);
        }

        protected virtual void OnClick(ClickEvent click)
        {
            var collapseToggle = this.Q<CollapseToggle>();
            bool targetIsCollapseToggle = click.target == collapseToggle;
            if (click.clickCount == 2 && !targetIsCollapseToggle)
            {
                OnDoubleClickDeployed();
            }
        }
    }
}
