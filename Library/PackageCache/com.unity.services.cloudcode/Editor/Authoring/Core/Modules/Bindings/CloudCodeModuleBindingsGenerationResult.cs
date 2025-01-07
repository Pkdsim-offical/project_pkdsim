using System;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings
{
    class CloudCodeModuleBindingsGenerationResult
    {
        public IModuleItem ModuleItem { get; }
        public string OutputPath { get; set; }
        public bool IsSuccessful { get; }
        public Exception Exception { get; }

        public CloudCodeModuleBindingsGenerationResult(
            IModuleItem moduleItem,
            string outputPath,
            bool isSuccessful,
            Exception exception = null)
        {
            ModuleItem = moduleItem;
            OutputPath = outputPath;
            IsSuccessful = isSuccessful;
            Exception = exception;
        }
    }
}
