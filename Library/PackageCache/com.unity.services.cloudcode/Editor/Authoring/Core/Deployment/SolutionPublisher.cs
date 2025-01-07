using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Dotnet;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment
{
    class SolutionPublisher : ISolutionPublisher
    {
        readonly IDotnetRunner m_DotnetRunner;

        public SolutionPublisher(IDotnetRunner dotnetRunner)
        {
            m_DotnetRunner = dotnetRunner;
        }

        public async Task PublishSolutionLinux64(
            string solutionPath,
            string outputPath,
            CancellationToken cancellationToken = default)
            => await PublishSolution(solutionPath, outputPath, "linux-x64", cancellationToken);

        public async Task PublishSolutionCrossPlatform(
            string solutionPath,
            string outputPath,
            CancellationToken cancellationToken = default)
            => await PublishSolution(solutionPath, outputPath, "any", cancellationToken);

        async Task PublishSolution(
            string solutionPath,
            string outputPath,
            string runtimeIdentifier,
            CancellationToken cancellationToken = default)
        {
            await m_DotnetRunner.ExecuteDotnetAsync(
                new[] { $"publish \"{solutionPath}\" -c Release -r \"{runtimeIdentifier}\" -o \"{outputPath}\"" },
                cancellationToken);
        }
    }
}
