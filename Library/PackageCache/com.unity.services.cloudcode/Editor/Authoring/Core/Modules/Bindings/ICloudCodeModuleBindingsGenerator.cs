using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings
{
    interface ICloudCodeModuleBindingsGenerator
    {
        public Task<List<CloudCodeModuleBindingsGenerationResult>> GenerateModuleBindings(
            IEnumerable<IModuleItem> moduleItems,
            CancellationToken cancellationToken = default);
    }
}
