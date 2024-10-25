using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment
{
    interface ISolutionPublisher
    {
        public Task PublishSolutionLinux64(string solutionPath, string outputPath, CancellationToken cancellationToken = default);
        public Task PublishSolutionCrossPlatform(string solutionPath, string outputPath, CancellationToken cancellationToken = default);
    }
}
