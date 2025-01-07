using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.Services.CloudBuild.Editor
{
    static class CloudBuildSettingsBuildTargetUI
    {
        const string k_ClassNameTargetEntry = "target-entry";
        const string k_ClassNameTitle = "title";
        const string k_ClassNameBuildButton = "build-button";
        const string k_BuildButtonNamePrefix = "BuildBtn_";
        const string k_LabelBuildButton = "Build";
        const string k_MessageLaunchingBuild = "Starting build {0}.";
        const string k_MessageLaunchedBuildSuccess = "Build #{0} {1} added to queue";
        const string k_MessageLaunchedBuildFailedWithMsg = "Build {0} wasn't launched: {1}";
        const string k_MessageLaunchedBuildFailure = "Unable to build project";

        public static VisualElement Create(
            ProjectBuildTarget target, bool buildingAllowed, CloudBuildApiClient apiClient)
        {
            var targetContainer = new VisualElement();
            targetContainer.AddToClassList(k_ClassNameTargetEntry);

            AddTitle(targetContainer, target.Name);
            AddBuildButton(targetContainer, target, buildingAllowed, apiClient);

            return targetContainer;
        }

        static void AddTitle(VisualElement parentElement, string title)
        {
            var buildNameTextElement = new TextElement();
            buildNameTextElement.AddToClassList(k_ClassNameTitle);
            buildNameTextElement.text = title;
            parentElement.Add(buildNameTextElement);
        }

        static void AddBuildButton(
            VisualElement parentElement, ProjectBuildTarget target, bool buildingAllowed, CloudBuildApiClient apiClient)
        {
            var buildButton = new Button();
            buildButton.name = k_BuildButtonNamePrefix + target.Id;
            buildButton.AddToClassList(k_ClassNameBuildButton);
            buildButton.SetEnabled(buildingAllowed);
            buildButton.text = k_LabelBuildButton;
            buildButton.clicked += OnBuildButtonClicked;

            parentElement.Add(buildButton);

            void OnBuildButtonClicked()
            {
                var launchingMessage = string.Format(L10n.Tr(k_MessageLaunchingBuild), target.Name);
                Debug.Log(launchingMessage);

                EditorGameServiceAnalyticsSender.SendProjectSettingsBuildEvent();

                apiClient.LaunchBuild(
                    target.Links.StartBuilds.href, new LaunchBuildRequest { Clean = false },
                    OnLaunchBuildSucceeded, OnLaunchBuildFailed);
            }

            void OnLaunchBuildSucceeded(List<LaunchedBuildResponse> launchedBuilds)
            {
                foreach (var launchedBuild in launchedBuilds)
                {
                    if (!string.IsNullOrEmpty(launchedBuild.Error))
                    {
                        var message = string.Format(L10n.Tr(k_MessageLaunchedBuildFailedWithMsg), target.Name, launchedBuild.Error);
                        Debug.LogError(message);
                    }
                    else
                    {
                        var message = string.Format(L10n.Tr(k_MessageLaunchedBuildSuccess), launchedBuild.Build, target.Name);
                        Debug.Log(message);
                    }
                }
            }

            void OnLaunchBuildFailed(Exception error)
            {
                Debug.LogError(L10n.Tr(k_MessageLaunchedBuildFailure));
            }
        }
    }
}
