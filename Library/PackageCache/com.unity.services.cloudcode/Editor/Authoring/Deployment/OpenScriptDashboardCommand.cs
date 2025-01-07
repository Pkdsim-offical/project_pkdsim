using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Scripts;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;
using UnityEngine;

namespace Unity.Services.CloudCode.Authoring.Editor.Deployment
{
    class OpenScriptDashboardCommand : Command
    {
        readonly JsAssetHandler m_JsAssetHandler;
        readonly IDashboardUrlResolver m_DashboardUrlResolver;
        public override string Name => L10n.Tr("Open in Dashboard");

        public OpenScriptDashboardCommand(JsAssetHandler jsAssetHandler, IDashboardUrlResolver dashboardUrlResolver)
        {
            m_JsAssetHandler = jsAssetHandler;
            m_DashboardUrlResolver = dashboardUrlResolver;
        }

        public override async Task ExecuteAsync(IEnumerable<IDeploymentItem> items, CancellationToken cancellationToken = default)
        {
            var scriptNames = items.Select(x => x.Name.TrimEnd(".js".ToCharArray()));

            foreach (var name in scriptNames)
            {
                Application.OpenURL(await m_DashboardUrlResolver.CloudCodeScript(name));
            }
        }
    }
}
