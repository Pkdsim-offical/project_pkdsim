using System;
using Unity.Services.Deployment.Core.Logging;
using SharedLogger = Unity.Services.Deployment.Editor.Shared.Logging.Logger;

namespace Unity.Services.Deployment.Editor.Logging
{
    class Logger : ILogger
    {
        public void LogError(object message)
        {
            SharedLogger.LogError(message);
        }

        public void LogWarning(object message)
        {
            SharedLogger.LogWarning(message);
        }

        public void LogInfo(object message)
        {
            SharedLogger.Log(message);
        }

        public void LogVerbose(object message)
        {
            SharedLogger.LogVerbose(message);
        }

        public void LogException(
            Exception exception)
        {
            SharedLogger.LogException(exception);
        }
    }
}
