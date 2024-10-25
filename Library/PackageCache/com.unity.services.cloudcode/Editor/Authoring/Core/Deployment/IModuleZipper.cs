using System;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment
{
    interface IModuleZipper
    {
        Task<string> ZipCompilation(string srcPath, string dstPath, string moduleName, CancellationToken cancellationToken);
    }
}
