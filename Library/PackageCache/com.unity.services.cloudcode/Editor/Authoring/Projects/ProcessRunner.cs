using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.CloudCode.Authoring.Editor.Projects
{
    interface IProcessRunner
    {
        Task<ProcessOutput> RunAsync(
            ProcessStartInfo startInfo,
            string stdIn = default,
            CancellationToken cancellationToken = default);
        bool Start(ProcessStartInfo startInfo);
    }

    struct ProcessOutput
    {
        public string StdOut { get; set; }
        public string StdErr { get; set; }
        public int ExitCode { get; set; }
    }

    class ProcessRunner : IProcessRunner
    {
        public async Task<ProcessOutput> RunAsync(
            ProcessStartInfo startInfo,
            string stdIn = default,
            CancellationToken cancellationToken = default)
        {
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;

            using var process = new Process();
            var exitTask = WrapProcessInTask(process, cancellationToken);

            process.StartInfo = startInfo;
            process.EnableRaisingEvents = true;
            process.Start();

            if (!string.IsNullOrEmpty(stdIn))
            {
                await process.StandardInput.WriteAsync(stdIn);
                process.StandardInput.Close();
            }

            await exitTask;

            return new ProcessOutput
            {
                ExitCode = process.ExitCode,
                StdOut = AddLastNewLineIfNecessary(await process.StandardOutput.ReadToEndAsync()),
                StdErr = AddLastNewLineIfNecessary(await process.StandardError.ReadToEndAsync()),
            };
        }

        public bool Start(ProcessStartInfo startInfo)
        {
            using var process = new Process();
            process.StartInfo = startInfo;
            return process.Start();
        }

        static string AddLastNewLineIfNecessary(string s)
        {
            if (!s.EndsWith(Environment.NewLine))
            {
                s += Environment.NewLine;
            }

            return s;
        }

        static Task WrapProcessInTask(Process process, CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<object>();
            process.Exited += (_, _) => tcs.TrySetResult(null);

            if (cancellationToken != default)
                cancellationToken.Register(() => tcs.SetCanceled());

            return tcs.Task;
        }
    }
}
