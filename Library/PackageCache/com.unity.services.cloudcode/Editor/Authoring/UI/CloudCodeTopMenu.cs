using System;
using System.Linq;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings;
using Unity.Services.CloudCode.Authoring.Editor.Modules;
using UnityEditor;

namespace Unity.Services.CloudCode.Authoring.Editor.UI
{
    static class CloudCodeTopMenu
    {
        const int k_ConfigureMenuPriority = 100;
        const string k_ServiceMenuRoot = "Services/CloudCode/";

        [MenuItem(k_ServiceMenuRoot + "Generate All Modules Bindings", priority = k_ConfigureMenuPriority)]
        static void GenerateModuleBindings()
        {
            _ = GenerateModuleBindingsAsync();
        }

        static async Task GenerateModuleBindingsAsync()
        {
            var ccmrs = CloudCodeAuthoringServices.Instance
                .GetService<CloudCodeModuleReferenceCollection>().ToList();

            var results = await CloudCodeAuthoringServices.Instance
                .GetService<ICloudCodeModuleBindingsGenerator>()
                    .GenerateModuleBindings(ccmrs);

            var failedResults = results
                .Select(x => x.Exception)
                .Where(x => x != null).ToList();

            CloudCodeAuthoringServices.Instance.GetService<ICloudCodeModuleBindingsGenerationAnalytics>()
                .SendCodeGenerationFromTopMenuEvent(
                    failedResults.Any() ? new AggregateException(failedResults) : null);
        }
    }
}
