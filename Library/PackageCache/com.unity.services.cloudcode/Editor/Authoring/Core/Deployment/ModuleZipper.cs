using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration.Exceptions;
using Unity.Services.CloudCode.Authoring.Editor.Core.IO;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment
{
    class ModuleZipper : IModuleZipper
    {
        const string k_ZipFileExtension = "ccm";

        readonly IFileSystem m_FileSystem;

        public ModuleZipper(IFileSystem fileSystem)
        {
            m_FileSystem = fileSystem;
        }

        public async Task<string> ZipCompilation(
            string srcPath, string dstPath, string moduleName, CancellationToken cancellationToken = default)
        {
            try
            {
                var directoryPath = Path.GetDirectoryName(srcPath);
                if (directoryPath == null)
                {
                    throw new DirectoryNotFoundException();
                }

                var zippedFileName = Path.ChangeExtension(moduleName, k_ZipFileExtension);
                var dstFileFullPath = Path.Join(dstPath, zippedFileName);
                // Remove previously generated module
                if (m_FileSystem.FileExists(dstFileFullPath))
                {
                    await m_FileSystem.Delete(dstFileFullPath, cancellationToken);
                }

                m_FileSystem.CreateZipFromDirectory(srcPath, dstFileFullPath);
                return dstFileFullPath;
            }
            catch (IOException e)
            {
                throw new FailedZipCompilationException(e);
            }
        }
    }
}
