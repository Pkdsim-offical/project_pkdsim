using System;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions
{
    class FailedProjectRetrieverException : Exception
    {
        public FailedProjectRetrieverException(string message)
            : base(message)
        {
        }
    }
}
