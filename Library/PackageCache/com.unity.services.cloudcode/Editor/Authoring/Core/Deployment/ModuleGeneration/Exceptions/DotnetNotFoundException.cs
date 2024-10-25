using System;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions
{
    class DotnetNotFoundException : Exception
    {
        static readonly string s_CallToAction
            = "Please make sure that your development environment is properly set up. " +
                "Preferences > Cloud Code Modules > .NET development environment";

        public DotnetNotFoundException(string message, Exception ex)
            : base($"Failed to locate dotnet executable. " + message, ex) {}

        public DotnetNotFoundException(string message)
            : base(message + " Failed to locate dotnet executable. " + s_CallToAction) {}

        public DotnetNotFoundException(Exception ex)
            : this($"Failed to locate dotnet executable. " + s_CallToAction, ex) {}
    }
}
