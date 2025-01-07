using System;

namespace Unity.Services.CloudCode.Authoring.Editor.Modules.Bindings
{
    class FailedToGenerateBindingsException : Exception
    {
        public FailedToGenerateBindingsException(string solutionPath, Exception ex)
            : base($"Failed to generate code bindings for solution '{solutionPath}'. " +
                   $"Details: {Environment.NewLine}{ex}", ex) {}
    }
}
