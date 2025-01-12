using System;
using System.Collections.Generic;
using System.Text;
using Unity.Services.DeploymentApi.Editor;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Model
{
    interface IModuleItem : IDeploymentItem, ITypedItem
    {
        string SolutionPath { get; }
        string CcmPath { get; set; }
        string ModuleName { get; set; }
        List<(DateTime, DeploymentStatus)> StatusLog { get; }

        new float Progress { get; set; }
    }

    static class IModuleItemExtensions
    {
        public static void UpdateLogStatus(this IModuleItem self, DeploymentStatus status)
        {
            self.StatusLog.Add((DateTime.Now, status));
            var builder = new StringBuilder();
            var statusLevel = SeverityLevel.Info;
            foreach (var(t, s) in self.StatusLog)
            {
                string detail = string.IsNullOrEmpty(s.MessageDetail) ? string.Empty : "- " + s.MessageDetail;
                builder.Append($"[{t:HH:mm:ss.fff}] {s.Message}{detail}{Environment.NewLine}");
                if (statusLevel < s.MessageSeverity)
                    statusLevel = s.MessageSeverity;
            }

            self.Status = new DeploymentStatus(status.Message, builder.ToString(), statusLevel);
        }

        public static void ClearLogStatus(this IModuleItem self)
        {
            self.StatusLog.Clear();
            self.Status = DeploymentStatus.Empty;
        }
    }
}
