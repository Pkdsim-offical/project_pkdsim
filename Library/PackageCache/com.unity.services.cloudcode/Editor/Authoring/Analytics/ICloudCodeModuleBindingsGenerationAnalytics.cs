using System;

namespace Unity.Services.CloudCode.Authoring.Editor.Analytics
{
    interface ICloudCodeModuleBindingsGenerationAnalytics
    {
        public void SendCodeGenerationFromInspectorBtnEvent(Exception exception = null);
        public void SendCodeGenerationFromTopMenuEvent(Exception exception = null);
        public void SendCodeGenerationFromProjectSettingsEvent(Exception exception = null);
        public void SendCodeGenerationFromCommandEvent(Exception exception = null);
    }
}
