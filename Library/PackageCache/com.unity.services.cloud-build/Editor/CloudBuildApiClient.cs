using System;
using System.Collections.Generic;
using System.Text;
using Unity.Services.Core.Editor;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

namespace Unity.Services.CloudBuild.Editor
{
    class CloudBuildApiClient
    {
        class CloudBuildApiConfig
        {
            [JsonProperty("build-api")]
            public string BuildApi { get; set; } = "https://build-api.cloud.unity3d.com";

            [JsonProperty("build")]
            public string Build { get; set; } = "https://dashboard.unity3d.com";
        }

        CdnConfiguredEndpoint<CloudBuildApiConfig> m_ClientConfig;

        public CloudBuildApiClient()
        {
            m_ClientConfig = new CdnConfiguredEndpoint<CloudBuildApiConfig>();
        }

        public void GetProjectInfo(Action<GetProjectInfoResponse> onSuccess, Action<Exception> onError)
        {
            CreateJsonGetRequest(GetEndPointUrl, onSuccess, onError);

            string GetEndPointUrl(CloudBuildApiConfig config)
            {
                return $"{config.BuildApi}/api/v1/orgs/{CloudProjectSettings.organizationId}/projects/{CloudProjectSettings.projectId}";
            }
        }

        public void GetProjectBillingPlan(
            string projectHref, Action<GetProjectBillingPlanResponse> onSuccess, Action<Exception> onError)
        {
            CreateJsonGetRequest(GetEndPointUrl, onSuccess, onError);

            string GetEndPointUrl(CloudBuildApiConfig config)
            {
                return $"{config.BuildApi}{projectHref}/billingplan";
            }
        }

        public void GetProjectBuildTargets(
            string buildTargetsHref, Action<List<ProjectBuildTarget>> onSuccess, Action<Exception> onError)
        {
            CreateJsonGetRequest(GetEndPointUrl, onSuccess, onError);

            string GetEndPointUrl(CloudBuildApiConfig config)
            {
                return $"{config.BuildApi}{buildTargetsHref}";
            }
        }

        public void GetApiStatus(Action<List<GetApiStatusResponse>> onSuccess, Action<Exception> onError)
        {
            CreateJsonGetRequest(GetEndPointUrl, onSuccess, onError);

            string GetEndPointUrl(CloudBuildApiConfig config)
            {
                return $"{config.BuildApi}/api/v1/status";
            }
        }

        public void LaunchBuild(
            string buildHref, LaunchBuildRequest request,
            Action<List<LaunchedBuildResponse>> onSuccess, Action<Exception> onError)
        {
            CreateJsonPostRequest(GetEndPointUrl, request, onSuccess, onError);

            string GetEndPointUrl(CloudBuildApiConfig config)
            {
                return $"{config.BuildApi}{buildHref}";
            }
        }

        public void GetBuildTargetStatus(
            string statusHref, Action<List<BuildTargetStatus>> onSuccess, Action<Exception> onError)
        {
            CreateJsonGetRequest(GetEndPointUrl, onSuccess, onError);

            string GetEndPointUrl(CloudBuildApiConfig config)
            {
                return $"{config.BuildApi}{statusHref}";
            }
        }

        void CreateJsonGetRequest<T>(
            Func<CloudBuildApiConfig, string> endpointConstructor, Action<T> onSuccess, Action<Exception> onError)
        {
            m_ClientConfig.GetConfiguration(OnGetConfigurationCompleted);

            void OnGetConfigurationCompleted(CloudBuildApiConfig configuration)
            {
                try
                {
                    var url = endpointConstructor(configuration);
                    var getRequest = new UnityWebRequest(url, UnityWebRequest.kHttpVerbGET)
                    {
                        downloadHandler = new DownloadHandlerBuffer()
                    };
                    Authorize(getRequest);
                    getRequest.SendWebRequest().completed += CreateJsonResponseHandler(onSuccess, onError);
                }
                catch (Exception reason)
                {
                    onError?.Invoke(reason);
                }
            }
        }

        void CreateJsonPostRequest<TRequestType, TResponseType>(
            Func<CloudBuildApiConfig, string> endpointConstructor, TRequestType request,
            Action<TResponseType> onSuccess, Action<Exception> onError)
        {
            m_ClientConfig.GetConfiguration(OnGetConfigurationCompleted);

            void OnGetConfigurationCompleted(CloudBuildApiConfig configuration)
            {
                try
                {
                    var url = endpointConstructor(configuration);
                    var payload = JsonConvert.SerializeObject(request);
                    var uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(payload));
                    var postRequest = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST)
                    {
                        downloadHandler = new DownloadHandlerBuffer(),
                        uploadHandler = uploadHandler
                    };
                    postRequest.SetRequestHeader("Content-Type", "application/json;charset=utf-8");
                    Authorize(postRequest);
                    postRequest.SendWebRequest().completed += CreateJsonResponseHandler(onSuccess, onError);
                }
                catch (Exception reason)
                {
                    onError?.Invoke(reason);
                }
            }
        }

        static Action<AsyncOperation> CreateJsonResponseHandler<T>(Action<T> onSuccess, Action<Exception> onError)
        {
            return JsonResponseHandler;

            void JsonResponseHandler(AsyncOperation unityOperation)
            {
                var callbackWebRequest = ((UnityWebRequestAsyncOperation)unityOperation).webRequest;
                if (WebRequestSucceeded(callbackWebRequest))
                {
                    try
                    {
                        var deserializedObject = JsonConvert.DeserializeObject<T>(
                            callbackWebRequest.downloadHandler.text);
                        onSuccess?.Invoke(deserializedObject);
                    }
                    catch (Exception deserializeError)
                    {
                        onError?.Invoke(deserializeError);
                    }
                }
                else
                {
                    onError?.Invoke(new Exception(callbackWebRequest.error));
                }

                callbackWebRequest.Dispose();
            }
        }

        static bool WebRequestSucceeded(UnityWebRequest request)
        {
#if UNITY_2020_2_OR_NEWER
            return request.result == UnityWebRequest.Result.Success;
#else
            return request.isDone && !request.isHttpError && !request.isNetworkError;
#endif
        }

        static void Authorize(UnityWebRequest request)
        {
            request.SetRequestHeader("AUTHORIZATION", $"Bearer {CloudProjectSettings.accessToken}");
        }
    }
}
