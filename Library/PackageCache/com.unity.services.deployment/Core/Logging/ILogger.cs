using System;

namespace Unity.Services.Deployment.Core.Logging
{
    interface ILogger
    {
        void LogError(object message);
        void LogWarning(object message);
        void LogInfo(object message);
        void LogVerbose(object message);
        void LogException(Exception exception);
    }
}
