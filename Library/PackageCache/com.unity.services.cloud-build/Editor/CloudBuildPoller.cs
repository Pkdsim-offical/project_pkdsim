using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Unity.Services.CloudBuild.Editor
{
    class CloudBuildPoller
    {
        const int k_IntervalSeconds = 15;
        const string k_BuildStatusCanceled = "canceled";
        const string k_BuildStatusFailure = "failure";
        const string k_BuildStatusQueued = "queued";
        const string k_BuildStatusSentToBuilder = "sentToBuilder";
        const string k_BuildStatusSentRestarted = "restarted";
        const string k_BuildStatusSuccess = "success";
        const string k_BuildStatusStarted = "started";
        const string k_BuildStatusStartedMessage = "building";
        const string k_BuildStatusUnknown = "unknown";
        const string k_BuildFinishedWithStatusMsg = "Build #{0} {1} {2}.";

        public static CloudBuildPoller Instance { get; } = new CloudBuildPoller();
        public bool Enabled { get; private set; }
        public bool EverEnabled { get; set; }

        string m_Url;
        CloudBuildTickTimer m_Timer = new CloudBuildTickTimer(k_IntervalSeconds);
        CloudBuildApiClient m_ApiClient;
        List<string> m_BuildsToReportOn = new List<string>();

        public void StartPolling(string url, CloudBuildApiClient apiClient)
        {
            EverEnabled = true;
            StopPolling();

            m_Url = url;
            m_ApiClient = apiClient;
            m_Timer.Reset();
            EditorApplication.update += Update;
            Enabled = true;
        }

        public void StopPolling()
        {
            if (Enabled)
            {
                Enabled = false;
                m_Url = string.Empty;
                m_ApiClient = null;
                EditorApplication.update -= Update;
            }
        }

        void Update()
        {
            if (m_Timer.Tick())
            {
                m_ApiClient.GetBuildTargetStatus(m_Url, BuildStatusHandler, Debug.LogException);
            }
        }

        void BuildStatusHandler(List<BuildTargetStatus> buildTargetStatus)
        {
            var buildsToStopTracking = new List<string>(m_BuildsToReportOn);
            foreach (var build in buildTargetStatus)
            {
                var buildId = $"{build.BuildTargetId}_{build.Build}";
                var buildStatus = build.BuildStatus.ToLower();
                var buildNumber = build.Build;
                var buildTargetName = build.BuildTargetName;

                buildsToStopTracking.Remove(buildId);

                if (m_BuildsToReportOn.Contains(buildId)
                    && (k_BuildStatusCanceled.Equals(buildStatus)
                        || k_BuildStatusFailure.Equals(buildStatus)
                        || k_BuildStatusSuccess.Equals(buildStatus)
                        || k_BuildStatusUnknown.Equals(buildStatus)))
                {
                    if (!k_BuildStatusStarted.Equals(buildStatus) && !k_BuildStatusUnknown.Equals(buildStatus))
                        m_BuildsToReportOn.Remove(buildId);

                    ReportOnBuildProgress(build);
                }
                else if (!m_BuildsToReportOn.Contains(buildId)
                         && (k_BuildStatusQueued.Equals(buildStatus)
                             || k_BuildStatusStarted.Equals(buildStatus)
                             || k_BuildStatusSentToBuilder.Equals(buildStatus)
                             || k_BuildStatusSentRestarted.Equals(buildStatus)
                         )
                )
                {
                    if (k_BuildStatusSentRestarted.Equals(buildStatus))
                    {
                        var message = string.Format(L10n.Tr(k_BuildFinishedWithStatusMsg),
                            buildNumber, buildTargetName, k_BuildStatusSentRestarted);
                        Debug.Log(message);
                    }

                    m_BuildsToReportOn.Add(buildId);
                }
            }

            foreach (var buildToRemove in buildsToStopTracking)
                m_BuildsToReportOn.Remove(buildToRemove);
        }

        static void ReportOnBuildProgress(BuildTargetStatus build)
        {
            var buildNumber = build.Build;
            var buildStatus = build.BuildStatus.ToLower();
            var buildTargetName = build.BuildTargetName;

            switch (buildStatus)
            {
                case k_BuildStatusCanceled:
                {
                    var message = string.Format(L10n.Tr(k_BuildFinishedWithStatusMsg),
                        buildNumber, buildTargetName, k_BuildStatusCanceled);
                    Debug.LogWarning(message);
                    break;
                }

                case k_BuildStatusFailure:
                {
                    var message = string.Format(L10n.Tr(k_BuildFinishedWithStatusMsg),
                        buildNumber, buildTargetName, k_BuildStatusFailure);
                    Debug.LogError(message);
                    break;
                }

                case k_BuildStatusStarted:
                {
                    var message = string.Format(L10n.Tr(k_BuildFinishedWithStatusMsg),
                        buildNumber, buildTargetName, k_BuildStatusStartedMessage);
                    Debug.Log(message);
                    break;
                }
                case k_BuildStatusSuccess:
                {
                    var message = string.Format(L10n.Tr(k_BuildFinishedWithStatusMsg),
                        buildNumber, buildTargetName, k_BuildStatusSuccess);
                    Debug.Log(message);
                    break;
                }
                case k_BuildStatusUnknown:
                {
                    var message = string.Format(L10n.Tr(k_BuildFinishedWithStatusMsg),
                        buildNumber, buildTargetName, k_BuildStatusUnknown);
                    Debug.LogWarning(message);
                    break;
                }
            }
        }
    }
}
