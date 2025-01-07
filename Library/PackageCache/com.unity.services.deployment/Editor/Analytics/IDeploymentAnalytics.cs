using System;
using System.Collections.Generic;
using Unity.Services.Deployment.Editor.Shared.Analytics;
using Unity.Services.DeploymentApi.Editor;

namespace Unity.Services.Deployment.Editor.Analytics
{
    interface IDeploymentAnalytics : ICommonAnalytics
    {
        IDeployEvent BeginDeploy(IReadOnlyDictionary<string, List<IDeploymentItem>> itemsPerProvider, string source);
        void SendDeploymentDefinitionDeployedEvent(int itemsNumber);
        interface IDeployEvent
        {
            void SendSuccess();
            void SendFailure(Exception exception);
        }
    }
}
