using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;
using Unity.Services.CloudCode.Authoring.Editor.Projects;
using Unity.Services.CloudCode.Authoring.Editor.Scripts;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Infrastructure.Threading;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace Unity.Services.CloudCode.Authoring.Editor.Parameters.UI
{
    [CloudCodeImporter]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.services.cloudcode@2.8/manual/Authoring/cloud_code_scripts.html")]
    class CloudCodeScriptImporter : ScriptedImporter
    {
        static readonly string k_FailedToLoadParametersMsg = "Failed to load in-script parameters.";

        const string k_JsScriptAssetIdentifier = "JsScript";

        public List<CloudCodeParameter> Parameters;
        public ParameterSource Source;

        static void AddFailedToLoadParametersState(Script script, string errorDetail)
        {
            var containFailedToLoadParameters = script.States != null &&
                script.States.Any(state => state.Description == k_FailedToLoadParametersMsg);

            if (containFailedToLoadParameters)
            {
                return;
            }

            var failedToLoadAssetState = new AssetState(k_FailedToLoadParametersMsg, errorDetail, SeverityLevel.Error);
            script.States?.Add(failedToLoadAssetState);
        }

        public static void RemoveFailedToLoadParametersState(Script script)
        {
            var state = script.States.FirstOrDefault(state => state.Description == k_FailedToLoadParametersMsg);
            script.States.Remove(state);
        }

        public override void OnImportAsset(AssetImportContext ctx)
        {
            var jsScript = CloudCodeAuthoringServices.Instance.GetService<ObservableCloudCodeScripts>()
                .GetOrCreateInstance(ctx.assetPath);
            jsScript.Model.Parameters = Parameters?.ToList() ?? new List<CloudCodeParameter>();
            Source = ParameterSource.Editor;

            var path = ctx.assetPath; //getter must be called on the main thread
            jsScript.name = jsScript.Model.Name.GetNameWithoutExtension();
            ctx.AddObjectToAsset(k_JsScriptAssetIdentifier, jsScript, CloudCodeResources.Icon);
            ctx.SetMainObject(jsScript);
            RemoveFailedToLoadParametersState(jsScript.Model);

            if (CloudCodeProject.IsInitialized())
            {
                var loader = CloudCodeAuthoringServices.Instance.GetService<IInScriptParameters>();
                LoadInScriptParameters(loader, path, jsScript);
            }
        }

        // this must be synchronous: every data change outside of the time life of the OnImportAsset is useless
        void LoadInScriptParameters(IInScriptParameters loader, string path, CloudCodeScript jsScript)
        {
            try
            {
                List<CloudCodeParameter> inScriptParams = Sync.RunInBackgroundThread(() => loader.GetParametersFromPath(path)).Result;

                if (inScriptParams != null)
                {
                    Parameters = inScriptParams;
                    Source = ParameterSource.InScript;
                    jsScript.Model.Parameters = Parameters?.ToList() ?? new List<CloudCodeParameter>();
                }
            }
            catch (Exception e)
            {
                AddFailedToLoadParametersState(jsScript.Model, e.InnerException?.Message);
            }
        }
    }
}
