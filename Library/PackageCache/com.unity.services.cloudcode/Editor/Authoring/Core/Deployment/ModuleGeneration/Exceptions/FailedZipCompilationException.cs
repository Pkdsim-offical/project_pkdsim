using System;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions
{
    class FailedZipCompilationException : Exception
    {
        public FailedZipCompilationException(Exception ex)
            : base(ex.Message, ex)
        {
        }
    }
}
