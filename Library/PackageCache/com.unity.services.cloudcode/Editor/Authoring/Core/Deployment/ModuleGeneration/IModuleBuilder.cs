using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration
{
    interface IModuleBuilder
    {
        Task CreateCloudCodeModuleFromSolution(IModuleItem deploymentItem, CancellationToken cancellationToken = default);
    }
}
