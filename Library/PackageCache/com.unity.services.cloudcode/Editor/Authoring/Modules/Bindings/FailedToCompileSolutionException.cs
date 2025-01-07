using System;

namespace Unity.Services.CloudCode.Authoring.Editor.Modules.Bindings
{
    class FailedToCompileSolutionException : Exception
    {
        public FailedToCompileSolutionException(string solutionPath, Exception ex)
            : base($"Failed to compile solution '{solutionPath}'. " +
                   $"Details: {Environment.NewLine}{ex}", ex) {}
    }
}
