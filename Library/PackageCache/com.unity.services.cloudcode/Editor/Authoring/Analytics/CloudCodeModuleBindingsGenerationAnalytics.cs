using System;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Shared.EditorUtils;
using ILogger = Unity.Services.CloudCode.Authoring.Editor.Core.Logging.ILogger;

namespace Unity.Services.CloudCode.Authoring.Editor.Analytics
{
    class CloudCodeModuleBindingsGenerationAnalytics : ICloudCodeModuleBindingsGenerationAnalytics
    {
        const string k_EventNameBindingGenFromInspector = "ccm_bindings_inspector_btn";
        const string k_EventNameBindingGenFromTopMenu = "ccm_bindings_topmenu";
        const string k_EventNameBindingGenFromProjectSettings = "ccm_bindings_project_settings";
        const string k_EventNameBindingGenFromCommand = "ccm_bindings_command";

        readonly ILogger m_Logger;
        readonly ICommonAnalytics m_CommonAnalytics;

        public CloudCodeModuleBindingsGenerationAnalytics(ICommonAnalytics commonAnalytics, ILogger logger)
        {
            m_CommonAnalytics = commonAnalytics;
            m_Logger = logger;
        }

        public void SendCodeGenerationFromInspectorBtnEvent(Exception exception = null)
        {
            Sync.RunNextUpdateOnMain(() =>
            {
                var result = m_CommonAnalytics.Send(new ICommonAnalytics.CommonEventPayload
                {
                    action = k_EventNameBindingGenFromInspector,
                    context = nameof(CloudCodeModuleBindingsGenerationAnalytics),
                    exception = exception?.GetType().FullName
                });
                m_Logger.LogVerbose($"Sent Analytics Event: {k_EventNameBindingGenFromInspector}. Result: {result}");
            });
        }

        public void SendCodeGenerationFromTopMenuEvent(Exception exception = null)
        {
            Sync.RunNextUpdateOnMain(() =>
            {
                var result = m_CommonAnalytics.Send(new ICommonAnalytics.CommonEventPayload
                {
                    action = k_EventNameBindingGenFromTopMenu,
                    context = nameof(CloudCodeModuleBindingsGenerationAnalytics),
                    exception = exception?.GetType().FullName
                });
                m_Logger.LogVerbose($"Sent Analytics Event: {k_EventNameBindingGenFromTopMenu}. Result: {result}");
            });
        }

        public void SendCodeGenerationFromProjectSettingsEvent(Exception exception = null)
        {
            Sync.RunNextUpdateOnMain(() =>
            {
                var result = m_CommonAnalytics.Send(new ICommonAnalytics.CommonEventPayload
                {
                    action = k_EventNameBindingGenFromProjectSettings,
                    context = nameof(CloudCodeModuleBindingsGenerationAnalytics),
                    exception = exception?.GetType().FullName
                });
                m_Logger.LogVerbose($"Sent Analytics Event: {k_EventNameBindingGenFromProjectSettings}. Result: {result}");
            });
        }

        public void SendCodeGenerationFromCommandEvent(Exception exception = null)
        {
            Sync.RunNextUpdateOnMain(() =>
            {
                var result = m_CommonAnalytics.Send(new ICommonAnalytics.CommonEventPayload
                {
                    action = k_EventNameBindingGenFromCommand,
                    context = nameof(CloudCodeModuleBindingsGenerationAnalytics),
                    exception = exception?.GetType().FullName
                });
                m_Logger.LogVerbose($"Sent Analytics Event: {k_EventNameBindingGenFromCommand}. Result: {result}");
            });
        }
    }
}
