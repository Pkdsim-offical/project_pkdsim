using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Services.Deployment.Editor.Interface.UI.Views;
using Unity.Services.Deployment.Editor.Model;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;
using PathIO = System.IO.Path;

namespace Unity.Services.Deployment.Editor.Interface.UI
{
    partial class DeploymentWindow : IDeploymentWindow
    {
        public void Select(IReadOnlyList<IDeploymentItem> deploymentItems)
        {
            var views = GetViews(deploymentItems);
            foreach (var v in views)
                v.Selected = true;
        }

        public void ClearSelection()
        {
            var views = GetViews();
            foreach (var v in views)
                v.Selected = false;
        }

        public void Check(IReadOnlyList<IDeploymentItem> deploymentItems)
        {
            var views = GetViews(deploymentItems);
            foreach (var v in views)
                v.Checked = true;
        }

        public void ClearChecked()
        {
            var views = GetViews();
            foreach (var v in views)
                v.Checked = false;
        }

        public List<IDeploymentItem> GetChecked()
        {
            return GetViews()
                .Where(v => v.Checked)
                .Select(GetFromView)
                .ToList();
        }

        public List<IDeploymentItem> GetSelected()
        {
            return GetViews()
                .Where(v => v.Selected)
                .Select(GetFromView)
                .ToList();
        }

        public EditorWindow OpenWindow()
        {
            return ShowWindow();
        }

        IDeploymentItem GetFromView(DeploymentElementViewBase view)
        {
            if (view is DeploymentItemView div)
                return m_DeploymentView.GetModelFromView(div);

            if (view is DeploymentDefinitionView ddefView)
                return DeploymentDefinitionDeploymentItem.FromViewModel(ddefView.DeploymentDefinition);

            throw new ArgumentOutOfRangeException(
                $"View '{view.Model}' is neither a DeploymentItem nor a DeploymentDefinition");
        }

        List<DeploymentElementViewBase> GetViews(
            IReadOnlyList<IDeploymentItem> items)
        {
            var views = new List<DeploymentElementViewBase>();
            foreach (var deploymentItem in items)
            {
                bool found = false;
                foreach (var ddefView in m_DeploymentView.GetDeploymentDefinitionViews())
                {
                    if (ddefView.DeploymentDefinition.Path == deploymentItem.Path)
                    {
                        views.Add(ddefView);
                        found = true;
                        break;
                    }

                    foreach (var divm in ddefView.ItemViews)
                    {
                        if (divm.Item.OriginalItem == deploymentItem)
                        {
                            views.Add(divm);
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                    throw new InvalidOperationException($"DeploymentItem '{deploymentItem.Path}' was not found.");
            }

            return views;
        }

        List<DeploymentElementViewBase> GetViews()
        {
            var views = new List<DeploymentElementViewBase>();

            foreach (var ddefView in m_DeploymentView.GetDeploymentDefinitionViews())
            {
                views.Add(ddefView);

                foreach (var divm in ddefView.ItemViews)
                    views.Add(divm);
            }

            return views;
        }
    }
}
