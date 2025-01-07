using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Unity.Services.Analytics.Editor")]

#if UNITY_INCLUDE_TESTS
[assembly: InternalsVisibleTo("Unity.Services.CloudCode.Authoring.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.Services.Deployment.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.Services.DeploymentApi.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.Services.RemoteConfig.Tests.Editor.Authoring")]
[assembly: InternalsVisibleTo("Unity.Services.Multiplay.Authoring.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.Services.Analytics.Authoring.Tests.Editor")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif
[assembly: InternalsVisibleTo("Unity.Services.Deployment")]
