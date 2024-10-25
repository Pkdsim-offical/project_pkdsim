using Unity.Services.CloudCode;

namespace Unity.Services.Core
{
    /// <summary>
    /// Cloud code extension methods
    /// </summary>
    public static class UnityServicesExtensions
    {
        /// <summary>
        /// Retrieve the cloud code service from the core service registry
        /// </summary>
        /// <param name="unityServices">The core services instance</param>
        /// <returns>The cloud code service instance</returns>
        public static ICloudCodeService GetCloudCodeService(this IUnityServices unityServices)
        {
            return unityServices.GetService<ICloudCodeService>();
        }
    }
}
