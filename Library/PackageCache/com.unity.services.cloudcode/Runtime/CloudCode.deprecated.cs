using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Unity.Services.CloudCode
{
    /// <summary>
    /// Obsolete, please use CloudCodeService.Instance
    /// </summary>
    [Obsolete("The interface provided by CloudCode has moved to CloudCodeService.Instance, and should be accessed from there instead. This API will be removed in an upcoming release.")]
    public static class CloudCode
    {
        /// <summary>
        /// Obsolete, please use CloudCodeService.Instance
        /// </summary>
        /// <param name="function">Obsolete, please use CloudCodeService.Instance</param>
        /// <param name="args">Obsolete, please use CloudCodeService.Instance</param>
        /// <returns>Obsolete, please use CloudCodeService.Instance</returns>
        [Obsolete("The interface provided by CloudCode.CallEndpointAsync(string, object) has been replaced by CloudCodeService.Instance.CallEndpointAsync(string, Dictionary<string, object>), and should be accessed from there instead. This API will be removed in an upcoming release.", false)]
        public static async Task<string> CallEndpointAsync(string function, object args)
        {
            return await CloudCodeService.Instance.CallEndpointAsync(function, ConvertObjectToDictionary(args));
        }

        /// <summary>
        /// Obsolete, please use CloudCodeService.Instance
        /// </summary>
        /// <param name="function">Obsolete, please use CloudCodeService.Instance</param>
        /// <param name="args">Obsolete, please use CloudCodeService.Instance</param>
        /// <typeparam name="TResult">Obsolete, please use CloudCodeService.Instance</typeparam>
        /// <returns>Obsolete, please use CloudCodeService.Instance</returns>
        [Obsolete("The interface provided by CloudCode.CallEndpointAsync<TResult>(string, object) has been replaced by CloudCodeService.Instance.CallEndpointAsync<TResult>(string, Dictionary<string, object>), and should be accessed from there instead. This API will be removed in an upcoming release.", false)]
        public static async Task<TResult> CallEndpointAsync<TResult>(string function, object args)
        {
            return await CloudCodeService.Instance.CallEndpointAsync<TResult>(function, ConvertObjectToDictionary(args));
        }

        private static Dictionary<string, object> ConvertObjectToDictionary(object args)
        {
            var dictionaryArgs = new Dictionary<string, object>();

            var fields = args?.GetType().GetFields();

            if (fields != null)
            {
                foreach (var field in fields)
                {
                    dictionaryArgs[field.Name] = field.GetValue(args);
                }
            }

            return dictionaryArgs;
        }
    }
}
