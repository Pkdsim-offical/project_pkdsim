using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;
using Unity.Services.CloudCode.Authoring.Editor.Modules;
using Unity.Services.CloudCode.Authoring.Editor.Scripts;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Infrastructure.Collections;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;

namespace Unity.Services.CloudCode.Authoring.Editor.Deployment.Modules
{
    class CloudCodeModuleDeployCommand : Command<CloudCodeModuleReference>
    {
        public override string Name => L10n.Tr("Deploy");

        readonly IModuleBuilder m_ModuleBuilder;

        readonly EditorCloudCodeModuleDeploymentHandler m_EditorCloudCodeDeploymentHandler;
        readonly bool m_Reconcile;
        readonly bool m_DryRun;

        public CloudCodeModuleDeployCommand(
            IModuleBuilder moduleBuilder,
            EditorCloudCodeModuleDeploymentHandler editorCloudCodeDeploymentHandler)
        {
            m_ModuleBuilder = moduleBuilder;

            m_EditorCloudCodeDeploymentHandler = editorCloudCodeDeploymentHandler;
            m_Reconcile = false;
            m_DryRun = false;
        }

        public override async Task ExecuteAsync(IEnumerable<CloudCodeModuleReference> items, CancellationToken cancellationToken = new CancellationToken())
        {
            var cloudCodeModuleReferences = items.ToList();
            OnDeploy(cloudCodeModuleReferences);
            var compiled = await Compile(cloudCodeModuleReferences, cancellationToken);
            m_EditorCloudCodeDeploymentHandler.SetReferenceFiles(cloudCodeModuleReferences.ToList());
            await m_EditorCloudCodeDeploymentHandler.DeployAsync(compiled, m_Reconcile, m_DryRun);
        }

        static void OnDeploy(IEnumerable<CloudCodeModuleReference> items)
        {
            items.ForEach(i =>
            {
                i.Progress = 0f;
                i.Status = new DeploymentStatus();
                i.States.Clear();
            });
        }

        internal async Task<List<IScript>> Compile(IEnumerable<CloudCodeModuleReference> items, CancellationToken cancellationToken = default)
        {
            var generationList = new List<IScript>();
            foreach (var ccmr in items)
            {
                try
                {
                    await m_ModuleBuilder.CreateCloudCodeModuleFromSolution(ccmr, cancellationToken);
                    if (ccmr.Status.MessageSeverity == SeverityLevel.Error)
                    {
                        continue;
                    }

                    generationList.Add(GenerateModule(ccmr.ModuleName, ccmr.CcmPath));
                }
                catch (Exception e)
                {
                    ccmr.Status = new DeploymentStatus("Failed to compile", e.Message, SeverityLevel.Error);
                }
            }

            return generationList;
        }

        static IScript GenerateModule(string moduleName, string filePath)
        {
            var name = new ScriptName(moduleName);
            return new Script(filePath)
            {
                Name = name,
                Body = string.Empty,
                Parameters = new List<CloudCodeParameter>(),
                Language = Language.CS
            };
        }
    }
}
