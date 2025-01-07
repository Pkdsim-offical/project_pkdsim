using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;
using UnityEngine;

namespace Unity.Services.CloudCode.Authoring.Editor.Deployment
{
    class OpenModuleDashboardCommand : Command
    {
        readonly IDashboardUrlResolver m_DashboardUrlResolver;
        public override string Name => L10n.Tr("Open in Dashboard");

        public OpenModuleDashboardCommand(IDashboardUrlResolver dashboardUrlResolver)
        {
            m_DashboardUrlResolver = dashboardUrlResolver;
        }

        public override async Task ExecuteAsync(IEnumerable<IDeploymentItem> items, CancellationToken cancellationToken = default)
        {
            var moduleNames = items.Select(x => x.Name.TrimEnd(".ccmr".ToCharArray()));

            foreach (var name in moduleNames)
            {
                Application.OpenURL(await m_DashboardUrlResolver.CloudCodeModule(name));
            }
        }
    }
}
