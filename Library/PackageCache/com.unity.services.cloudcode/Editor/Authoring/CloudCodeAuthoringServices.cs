using System;
using System.Collections.ObjectModel;
using Unity.Services.CloudCode.Authoring.Client;
using Unity.Services.CloudCode.Authoring.Client.Apis.Default;
using Unity.Services.CloudCode.Authoring.Client.ErrorMitigation;
using Unity.Services.CloudCode.Authoring.Client.Http;
using Unity.Services.CloudCode.Authoring.Editor.AdminApi;
using Unity.Services.CloudCode.Authoring.Editor.AdminApi.Readers;
using Unity.Services.CloudCode.Authoring.Editor.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Analytics.Deployment;
using Unity.Services.CloudCode.Authoring.Editor.Bundling;
using Unity.Services.CloudCode.Authoring.Editor.Core.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Core.Bundling;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration;
using Unity.Services.CloudCode.Authoring.Editor.Core.Dotnet;
using Unity.Services.CloudCode.Authoring.Editor.Core.IO;
using Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings;
using Unity.Services.CloudCode.Authoring.Editor.Core.Solution;
using Unity.Services.CloudCode.Authoring.Editor.Deployment;
using Unity.Services.CloudCode.Authoring.Editor.Deployment.Modules;
using Unity.Services.CloudCode.Authoring.Editor.IO;
using Unity.Services.CloudCode.Authoring.Editor.Modules;
using Unity.Services.CloudCode.Authoring.Editor.Modules.Bindings;
using Unity.Services.CloudCode.Authoring.Editor.Package;
using Unity.Services.CloudCode.Authoring.Editor.Parameters;
using Unity.Services.CloudCode.Authoring.Editor.Projects;
using Unity.Services.CloudCode.Authoring.Editor.Projects.Dotnet;
using Unity.Services.CloudCode.Authoring.Editor.Projects.Settings;
using Unity.Services.CloudCode.Authoring.Editor.Shared.DependencyInversion;
using Unity.Services.CloudCode.Authoring.Editor.Scripts;
using Unity.Services.CloudCode.Authoring.Editor.Scripts.Validation;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Assets;
using Unity.Services.CloudCode.Authoring.Editor.Shared.UI;
using Unity.Services.CloudCode.Authoring.Editor.UI;
using Unity.Services.Core.Editor;
using Unity.Services.Core.Editor.Environments;
using Unity.Services.Core.Editor.OrganizationHandler;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;
using static Unity.Services.CloudCode.Authoring.Editor.Shared.DependencyInversion.Factories;
using IDeploymentEnvironmentProvider = Unity.Services.DeploymentApi.Editor.IEnvironmentProvider;
using ICoreLogger = Unity.Services.CloudCode.Authoring.Editor.Core.Logging.ILogger;
using IEnvironmentProvider = Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.IEnvironmentProvider;
using Logger = Unity.Services.CloudCode.Authoring.Editor.Logging.Logger;

#if DEPLOYMENT_API_AVAILABLE_V1_1
using IProjectID = Unity.Services.DeploymentApi.Editor.IProjectIdentifierProvider;
#else
using IProjectID = Unity.Services.CloudCode.Authoring.Editor.Deployment.IProjectIdentifierProvider;
#endif

namespace Unity.Services.CloudCode.Authoring.Editor
{
    class CloudCodeAuthoringServices : AbstractRuntimeServices<CloudCodeAuthoringServices>
    {
        [InitializeOnLoadMethod]
        static void Initialize()
        {
            Instance.Initialize(new ServiceCollection());

            var provider = Instance.GetService<CloudCodeModuleDeploymentProvider>();
            Deployments.Instance.DeploymentProviders.Add(provider);

            var deploymentItemProvider = Instance.GetService<DeploymentProvider>();
            ((CloudCodeDeploymentProvider)deploymentItemProvider).ValidateDeploymentStatus();
            Deployments.Instance.DeploymentProviders.Add(deploymentItemProvider);
        }

        protected override void Register(ServiceCollection collection)
        {
            collection.RegisterSingleton(Default<ICloudCodeProjectSettings, CloudCodeProjectSettings>);
            collection.Register(Default<IProcessRunner, ProcessRunner>);
            collection.Register(Default<INodeJsRunner, NodePackageManager>);
            collection.Register(Default<INpmScriptRunner, NodePackageManager>);
            collection.Register(Default<INodePackageManager, NodePackageManager>);
            collection.Register(Default<IPackageVersionProvider, PackageVersionProvider>);
            collection.Register(Default<NodePackageManager>);

            collection.Register(Default<IInScriptParameters, InScriptParameters>);
            collection.RegisterSingleton(Default<ObservableCollection<IDeploymentItem>, ObservableCloudCodeScripts>);
            collection.Register(col => (ObservableCloudCodeScripts)col.GetService(typeof(ObservableCollection<IDeploymentItem>)));
            collection.RegisterStartupSingleton(Default<DuplicateNameValidator>);
            collection.RegisterStartupSingleton(Default<CloudCodeModuleReferenceCollection>);

            collection.Register(Default<IAccessTokens, AccessTokens>);

            collection.Register(Default<IScriptReader, ScriptReader>);

            collection.Register(Default<INotifications, Notifications>);

            collection.RegisterSingleton(Default<IDeploymentAnalytics, DeploymentAnalytics>);
            collection.Register(Default<ICommonAnalytics, CommonAnalytics>);
            collection.Register(Default<CloudScriptCreationAnalytics>);
            collection.Register(Default<CloudModuleCreationAnalytics>);
            collection.Register(Default<ICloudCodeModuleBindingsGenerationAnalytics, CloudCodeModuleBindingsGenerationAnalytics>);

            collection.Register(Default<IDotnetRunner, DotnetRunner>);
            collection.Register(Default<IFileStream, CloudCodeFileStream>);
            collection.Register(Default<IFileContentRetriever, FileContentRetriever>);
            collection.Register(Default<IModuleZipper, ModuleZipper>);
            collection.Register(Default<ISolutionPublisher, SolutionPublisher>);
            collection.Register(Default<IFileSystem, FileSystem>);
            collection.Register(Default<IPathResolver, PathResolver>);
            collection.Register(Default<ITemplateInfo, TemplateInfo>);
            collection.Register(Default<IFileCopier, FileCopier>);
            collection.Register(Default<IModuleProjectRetriever, ModuleProjectRetriever>);
            collection.Register(Default<IModuleBuilder, ModuleBuilder>);
            collection.Register(Default<CloudCodeModuleSolutionGenerator>);
            collection.Register(Default<ICloudCodeModuleBindingsGenerator, CloudCodeModuleBindingsGenerator>);

            collection.Register(Default<EditorCloudCodeDeploymentHandler>);
            collection.Register(Default<EditorCloudCodeModuleDeploymentHandler>);
            collection.Register(Default<DeployCommand>);
            collection.Register(Default<OpenCommand>);
            collection.Register(Default<GenerateSolutionCommand>);
            collection.Register(Default<CloudCodeModuleDeployCommand>);
            collection.Register(Default<OpenScriptDashboardCommand>);
            collection.Register(Default<OpenModuleDashboardCommand>);

            collection.Register(Default<JsAssetHandler>);
            collection.Register(Default<IExternalCodeEditor, ExternalCodeEditor>);
            collection.Register(Default<ICoreLogger, Logger>);

            collection.RegisterStartupSingleton(Default<DeploymentProvider, CloudCodeDeploymentProvider>);
            collection.RegisterStartupSingleton(Default<CloudCodeModuleDeploymentProvider>);

            collection.Register(_ => new Configuration(null, null, null, null));
            collection.Register(Default<IRetryPolicyProvider, RetryPolicyProvider>);
            collection.Register(Default<IHttpClient, HttpClient>);
            collection.Register(Default<IDefaultApiClient, DefaultApiClient>);
            collection.Register(Default<IPreDeployValidator, EditorPreDeployValidator>);
            collection.Register(Default<ICloudCodeScriptsClient, CloudCodeClient>);
            collection.Register(Default<ICloudCodeModulesClient, CloudCodeModulesClient>);
            collection.Register(Default<IFileReader, FileReader>);

            collection.Register(Default<IEnvironmentProvider, EnvironmentProvider>);
            collection.Register(_ => new Lazy<IDeploymentEnvironmentProvider>(() => Deployments.Instance.EnvironmentProvider));
            collection.Register(_ => OrganizationProvider.Organization);

            collection.Register(Default<IScriptBundler, EditorScriptBundler>);
            collection.RegisterSingleton(Default<AssetPostprocessorProxy>);
            collection.RegisterSingleton(Default<IScriptModifiedTracker, ScriptModifiedTracker>);

            collection.Register(Default<IEditorGUIUtils, EditorGUIUtils>);
            collection.Register(Default<InScriptParamsUIHandler>);

            collection.Register(Default<CloudCodeModuleGenerateBindingsCommand>);
            collection.Register(Default<IDashboardUrlResolver, DashboardUrlResolver>);
            collection.Register(_ => EnvironmentsApi.Instance);
            collection.Register(Default<IProjectID, ProjectIdentifierProvider>);
        }
    }
}
