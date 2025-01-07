using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions;
using Unity.Services.CloudCode.Authoring.Editor.Core.Dotnet;
using Unity.Services.CloudCode.Authoring.Editor.Core.Logging;
using Unity.Services.CloudCode.Authoring.Editor.Projects.Settings;

namespace Unity.Services.CloudCode.Authoring.Editor.Projects.Dotnet
{
    class DotnetRunner : IDotnetRunner
    {
        readonly IProcessRunner m_ProcessRunner;
        readonly ICloudCodeProjectSettings m_ProjectSettings;
        readonly ILogger m_Logger;

        static readonly string k_VersionCommand = "--version";
        static readonly string k_DotnetDefaultPathFallback = "dotnet";

        public DotnetRunner(IProcessRunner processRunner, ICloudCodeProjectSettings settings, ILogger logger)
        {
            m_ProcessRunner = processRunner;
            m_ProjectSettings = settings;
            m_Logger = logger;
        }

        public async Task<bool> IsDotnetAvailable()
        {
            try
            {
                await ExecuteDotnetAsync(new List<string>
                {
                    k_VersionCommand
                });
                return true;
            }
            catch (Exception)
            {
                try
                {
                    m_ProjectSettings.DotnetPath = k_DotnetDefaultPathFallback;
                    m_ProjectSettings.WriteToEditorPrefs();

                    await ExecuteDotnetAsync(new List<string>
                    {
                        k_VersionCommand
                    });
                    return true;
                }
                catch (Exception e)
                {
                    m_Logger.LogVerbose($"Error executing .NET: {e}");
                    return false;
                }
            }
        }

        public async Task<string> ExecuteDotnetAsync(IEnumerable<string> arguments = default, CancellationToken cancellationToken = default)
        {
            var startInfo = new ProcessStartInfo(m_ProjectSettings.DotnetPath, string.Join(" ", arguments))
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            try
            {
                m_Logger.LogVerbose($"Running dotnet with '{string.Join(" ", arguments ?? Array.Empty<string>())}'");
                var output = await m_ProcessRunner.RunAsync(startInfo, null, cancellationToken);
                if (output.ExitCode != 0)
                {
                    throw new Exception($"DotNet failed with Error Code {output.ExitCode}. Details: {output.StdOut}. StdErr: {output.StdErr}");
                }

                return output.StdOut;
            }
            catch (Win32Exception e)
            {
                m_Logger.LogVerbose($"Error {e}");
                throw new DotnetNotFoundException(e);
            }
            catch (Exception e)
            {
                m_Logger.LogVerbose($"Error {e}");
                throw;
            }
        }

        public async Task<List<SemVersion>> GetAvailableCoreRuntimes(CancellationToken ct = default)
        {
            var executionResult = await ExecuteDotnetAsync(new[] {"--list-runtimes"}, ct);
            var versions = executionResult
                .Split("\n", StringSplitOptions.RemoveEmptyEntries)
                .Where(s => s.StartsWith("Microsoft.NETCore.App"))
                .Select(s =>
                {
                    s = s.Trim();
                    return SemVersion.ParseString(s);
                })
                .ToList();

            return versions;
        }
    }
}
