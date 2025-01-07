using System;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.AdminApi;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;
using Unity.Services.Core.Editor.Environments;
using Unity.Services.Core.Editor.OrganizationHandler;

#if DEPLOYMENT_API_AVAILABLE_V1_1
using IProjectID = Unity.Services.DeploymentApi.Editor.IProjectIdentifierProvider;
#else
using IProjectID = Unity.Services.CloudCode.Authoring.Editor.Deployment.IProjectIdentifierProvider;
#endif


namespace Unity.Services.CloudCode.Authoring.Editor.Deployment
{
    class DashboardUrlResolver : IDashboardUrlResolver
    {
        readonly IEnvironmentsApi m_EnvironmentsApi;
        readonly IProjectID m_ProjectIdProvider;
        readonly IOrganizationHandler m_OrganizationHandler;
        readonly ICloudCodeModulesClient m_ModuleClient;
        readonly ICloudCodeScriptsClient m_ScriptClient;

        public DashboardUrlResolver(
            IEnvironmentsApi environmentsApi,
            IProjectID projectIdProvider,
            IOrganizationHandler organizationHandler,
            ICloudCodeScriptsClient scriptClient,
            ICloudCodeModulesClient moduleClient)
        {
            m_EnvironmentsApi = environmentsApi;
            m_ProjectIdProvider = projectIdProvider;
            m_OrganizationHandler  = organizationHandler;
            m_ModuleClient = moduleClient;
            m_ScriptClient = scriptClient;
        }

        static async Task<string> GetDashboardUrl(string itemName, string baseUrl, ICloudCodeClient client)
        {
            try
            {
                // check existence of item
                await client.Get(new ScriptName(itemName));
            }
            catch (Exception)
            {
                // fallback to generic url
                return baseUrl;
            }
            // return item url
            return $"{baseUrl}/{itemName}";
        }

        string GetBaseUrl()
        {
            var projectId = m_ProjectIdProvider.ProjectId;
            var envId = m_EnvironmentsApi.ActiveEnvironmentId;
            var orgId = m_OrganizationHandler.Key;
            return $"https://cloud.unity.com/home/organizations/{orgId}/projects/{projectId}/environments/{envId}/cloud-code";
        }

        public async Task<string> CloudCodeScript(string name)
        {
            var url = $"{GetBaseUrl()}/scripts";
            return await GetDashboardUrl(name, url, m_ScriptClient);
        }

        public async Task<string> CloudCodeModule(string name)
        {
            var url = $"{GetBaseUrl()}/modules";
            return await GetDashboardUrl(name, url, m_ModuleClient);
        }
    }
}
