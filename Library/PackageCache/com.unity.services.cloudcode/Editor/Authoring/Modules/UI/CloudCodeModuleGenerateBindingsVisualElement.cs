using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings;
using UnityEditor;
// Required for older unity versions.
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.Services.CloudCode.Authoring.Editor.Modules.UI
{
    class CloudCodeModuleGenerateBindingsVisualElement : VisualElement
    {
        static readonly string k_Uxml =
            Path.Combine(
                CloudCodePackage.EditorPath,
                "Authoring", "Modules", "UI" ,
                "Assets", "CloudCodeModuleGenerateBindingsProjectSettings.uxml");

        static readonly string k_Uss =
            Path.Combine(CloudCodePackage.EditorPath,
                "Authoring", "Modules", "UI",
                "Assets", "CloudCodeModuleGenerateBindingsProjectSettings.uss");

        /// <summary>
        /// The button to generate all modules bindings found in the current project.
        /// </summary>
        Button GenerateAllModulesBindingsButton { get; }

        public CloudCodeModuleGenerateBindingsVisualElement()
        {
            var containerAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(k_Uxml);
            if (containerAsset != null)
            {
                var containerUI = containerAsset.CloneTree().contentContainer;

                var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(k_Uss);
                if (styleSheet != null)
                {
                    containerUI.styleSheets.Add(styleSheet);
                }
                else
                {
                    throw new Exception("Asset not found: " + k_Uss);
                }

                GenerateAllModulesBindingsButton = containerUI.Q<Button>("generate-bindings-btn");
                GenerateAllModulesBindingsButton.clicked += GenerateAllModulesBindingsClicked;

                Add(containerUI);
            }
            else
            {
                throw new Exception("Asset not found: " + k_Uxml);
            }
        }

        async void GenerateAllModulesBindingsClicked()
        {
            await GenerateModuleBindingsAsync();
        }

        async Task GenerateModuleBindingsAsync()
        {
            SetEnabled(false);

            var ccmrs = CloudCodeAuthoringServices.Instance
                .GetService<CloudCodeModuleReferenceCollection>().ToList();

            var results = await CloudCodeAuthoringServices.Instance
                .GetService<ICloudCodeModuleBindingsGenerator>()
                    .GenerateModuleBindings(ccmrs);

            var failedResults = results
                .Select(x => x.Exception)
                .Where(x => x != null).ToList();

            CloudCodeAuthoringServices.Instance.GetService<ICloudCodeModuleBindingsGenerationAnalytics>()
                .SendCodeGenerationFromProjectSettingsEvent(
                    failedResults.Any() ? new AggregateException(failedResults) : null);

            SetEnabled(true);
        }
    }
}
