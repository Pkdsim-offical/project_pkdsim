using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings;
using Unity.Services.CloudCode.Authoring.Editor.Modules;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;

namespace Unity.Services.CloudCode.Authoring.Editor.Deployment.Modules
{
    class CloudCodeModuleGenerateBindingsCommand : Command<CloudCodeModuleReference>
    {
        public override string Name => L10n.Tr("Generate Code Bindings");

        ICloudCodeModuleBindingsGenerator m_EditorCloudCodeModuleGenerateBindings;

        public CloudCodeModuleGenerateBindingsCommand(
            ICloudCodeModuleBindingsGenerator editorCloudCodeModuleGenerateBindings)
        {
            m_EditorCloudCodeModuleGenerateBindings = editorCloudCodeModuleGenerateBindings;
        }

        public override async Task ExecuteAsync(
            IEnumerable<CloudCodeModuleReference> ccmrs,
            CancellationToken cancellationToken = default)
        {
            var results =
                await m_EditorCloudCodeModuleGenerateBindings.GenerateModuleBindings(ccmrs, cancellationToken);

            var failedResults = results
                .Select(x => x.Exception)
                .Where(x => x != null).ToList();

            CloudCodeAuthoringServices.Instance.GetService<ICloudCodeModuleBindingsGenerationAnalytics>()
                .SendCodeGenerationFromCommandEvent(
                    failedResults.Any() ? new AggregateException(failedResults) : null);
        }
    }
}
