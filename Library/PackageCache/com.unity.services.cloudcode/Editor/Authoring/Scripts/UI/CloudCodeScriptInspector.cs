using System;
using System.IO;
using System.Linq;
using Unity.Services.CloudCode.Authoring.Editor.Deployment;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Shared.UI.DeploymentConfigInspectorFooter;
using UnityEditor;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

namespace Unity.Services.CloudCode.Authoring.Editor.Scripts.UI
{
    [CustomEditor(typeof(CloudCodeScript))]
    [CanEditMultipleObjects]
    class CloudCodeScriptInspector : UnityEditor.Editor
    {
        const int k_MaxLines = 75;
        const string k_Template = "Packages/com.unity.services.cloudcode/Editor/Authoring/Scripts/UI/Assets/CloudCodeScriptInspector.uxml";

        public override VisualElement CreateInspectorGUI()
        {
            var myInspector = new VisualElement();
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(k_Template);
            visualTree.CloneTree(myInspector);

            ShowScriptBody(myInspector);
            SetupConfigFooter(myInspector);

            return myInspector;
        }

        void SetupConfigFooter(VisualElement rootElement)
        {
            var assetPath = AssetDatabase.GetAssetPath(target);
            var assetName = Path.GetFileNameWithoutExtension(assetPath);
            var deploymentConfigInspectorFooter = rootElement.Q<DeploymentConfigInspectorFooter>();
            deploymentConfigInspectorFooter.BindGUI(
                assetPath,
                CloudCodeAuthoringServices.Instance.GetService<ICommonAnalytics>(),
                "cloudcode");
            deploymentConfigInspectorFooter.DashboardLinkUrlGetter = () => CloudCodeAuthoringServices.Instance
                .GetService<IDashboardUrlResolver>()
                .CloudCodeScript(assetName);
        }

        void ShowScriptBody(VisualElement myInspector)
        {
            var body = myInspector.Q<TextField>();
            if (targets.Length == 1)
            {
                body.visible = true;
                body.value = ReadScriptBody(targets[0]);
            }
            else
            {
                body.visible = false;
            }
        }

        static string ReadScriptBody(Object script)
        {
            var path = AssetDatabase.GetAssetPath(script);
            var lines = File.ReadLines(path).Take(k_MaxLines).ToList();
            if (lines.Count == k_MaxLines)
            {
                lines.Add("...");
            }
            return string.Join(Environment.NewLine, lines);
        }
    }
}
