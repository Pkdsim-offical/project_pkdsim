using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Unity.Services.CloudCode.Authoring.Editor.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;
using Unity.Services.CloudCode.Authoring.Editor.Core.Modules.Bindings;
using Unity.Services.CloudCode.Authoring.Editor.Deployment;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Analytics;
using Unity.Services.CloudCode.Authoring.Editor.Shared.EditorUtils;
using Unity.Services.CloudCode.Authoring.Editor.Shared.UI.DeploymentConfigInspectorFooter;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Task = System.Threading.Tasks.Task;

namespace Unity.Services.CloudCode.Authoring.Editor.Modules.UI
{
    [CustomEditor(typeof(CloudCodeModuleReference))]
    [CanEditMultipleObjects]
    class CloudCodeModuleReferenceInspector : UnityEditor.Editor
    {
        static readonly string k_UxmlPath =
            Path.Combine(CloudCodePackage.EditorPath, "Authoring/Modules/UI/Assets/CloudCodeModuleReferenceUi.uxml");

        CloudCodeModuleReference ModuleReference => (CloudCodeModuleReference)serializedObject.targetObject;

        ApplyRevertChangeTracker<CloudCodeModuleReference> m_ChangeTracker;
        VisualElement m_ApplyFooter;
        VisualElement m_HandleSolutionContainer;
        VisualElement m_GenerateBindingsContainer;

        PropertyField m_PropertyModulePath;
        Button m_ButtonBrowse;
        Button m_SolutionHandlerButton; // Can either generate or open the solution
        HelpBox m_MessageBox;

        bool m_SolutionExists;

        public override VisualElement CreateInspectorGUI()
        {
            DisableReadonlyFlags();
            m_ChangeTracker = new ApplyRevertChangeTracker<CloudCodeModuleReference>(serializedObject);

            var uxmlAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(k_UxmlPath);
            var rootElement = new VisualElement();
            uxmlAsset.CloneTree(rootElement);

            BindControls(rootElement);
            SetupConfigFooter(rootElement);

            return rootElement;
        }

        void SetupConfigFooter(VisualElement rootElement)
        {
            var deploymentConfigInspectorFooter = rootElement.Q<DeploymentConfigInspectorFooter>();
            var assetPath = AssetDatabase.GetAssetPath(target);
            var assetName = Path.GetFileNameWithoutExtension(assetPath);
            deploymentConfigInspectorFooter.BindGUI(
                assetPath,
                CloudCodeAuthoringServices.Instance.GetService<ICommonAnalytics>(),
                "cloudcode");
            deploymentConfigInspectorFooter.DashboardLinkUrlGetter = () => CloudCodeAuthoringServices.Instance
                .GetService<IDashboardUrlResolver>()
                .CloudCodeModule(assetName);
        }

        void BindControls(VisualElement rootElement)
        {
            rootElement.Bind(m_ChangeTracker.SerializedObject);

            m_ButtonBrowse = rootElement.Q<Button>("button-browse-file");
            m_ButtonBrowse.clickable.clicked += OnBrowseButtonClicked;

            m_SolutionHandlerButton = rootElement.Q<Button>(UxmlNames.HandleSolutionButton);

            BindApplyFooter(rootElement);

            m_PropertyModulePath = rootElement.Q<PropertyField>();
            m_PropertyModulePath.RegisterValueChangeCallback(_ => UpdateApplyRevertEnabled());

            UpdateApplyRevertEnabled();

            m_MessageBox = new HelpBox("help", HelpBoxMessageType.Error);
            m_MessageBox.visible = false;
            rootElement.Add(m_MessageBox);


            UpdateSolutionExistenceStatus();
        }

        void UpdateSolutionExistenceStatus()
        {
            m_SolutionExists = !string.IsNullOrEmpty(ModuleReference.SolutionPath) &&
                File.Exists(ModuleReference.SolutionPath);
            m_SolutionHandlerButton.text = m_SolutionExists ? "Open Solution" : "Generate Solution";
            m_GenerateBindingsContainer.SetEnabled(m_SolutionExists);
        }

        void OpenSolution()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = ModuleReference.SolutionPath;
                process.StartInfo.UseShellExecute = true;
                process.Start();
                UpdateMessageBox("Solution opened.", true, HelpBoxMessageType.Info);
            }
            catch (Exception e)
            {
                UpdateMessageBox("Solution failed to open: " + e.Message, true, HelpBoxMessageType.Error);
            }
        }

        void OnBrowseButtonClicked()
        {
            var slnPath = EditorUtility.OpenFilePanel("Select a Cloud Code Module solution",
                GetSolutionPathRelativeToProject(), "sln");
            if (!string.IsNullOrEmpty(slnPath))
            {
                var textField = m_PropertyModulePath.Q<TextField>();
                textField.value = slnPath;

                var serializedProp = serializedObject.FindProperty(m_PropertyModulePath.bindingPath);
                serializedProp.stringValue = slnPath;
            }
        }

        string GetSolutionPathRelativeToProject()
        {
            string projectPath = Directory.GetParent(Application.dataPath) !.FullName;
            var dir = Path.GetDirectoryName(
                Path.GetRelativePath(projectPath, ModuleReference.SolutionPath));
            // if the directory doesnt exist return the Assets folder
            return Directory.Exists(dir) ? dir : Application.dataPath;
        }

        void BindApplyFooter(VisualElement rootElement)
        {
            m_ApplyFooter = rootElement.Q<VisualElement>(UxmlNames.ApplyFooter);
            m_HandleSolutionContainer = rootElement.Q<VisualElement>(UxmlNames.HandleSolutionContainer);
            m_GenerateBindingsContainer = rootElement.Q<VisualElement>(UxmlNames.GenerateBindingsContainer);

            rootElement.Q<Button>(UxmlNames.Apply).clicked += ApplyChanges;
            rootElement.Q<Button>(UxmlNames.Revert).clicked += RevertChanges;
            rootElement.Q<Button>(UxmlNames.HandleSolutionButton).clicked += OnSolutionHandlerButtonClicked;
            rootElement.Q<Button>(UxmlNames.GenerateBindingsButton).clicked += GenerateModuleBindings;
        }

        void ApplyChanges()
        {
            var newObj = (CloudCodeModuleReference)m_ChangeTracker.SerializedObject.targetObject;
            if (IsPathValid(newObj.ModulePath))
            {
                m_ChangeTracker.Apply();
                ModuleReference.SaveChanges();
                UpdateApplyRevertEnabled();
                AssetDatabase.Refresh();
            }
            else
            {
                var errorMsg = "Failed to apply the current path - " +
                    "Please make sure your path does not contain any invalid characters and ends with a solution file.";
                UpdateMessageBox(errorMsg, true, HelpBoxMessageType.Error);
            }
        }

        bool IsPathValid(string path)
        {
            bool isValid = Path.GetExtension(path).Equals(".sln") &&
                (path.IndexOfAny(Path.GetInvalidPathChars()) == -1);

            return isValid;
        }

        void RevertChanges()
        {
            m_ChangeTracker.Reset();
            UpdateApplyRevertEnabled();
        }

        void OnSolutionHandlerButtonClicked()
        {
            if (!m_SolutionExists)
            {
                GenerateSolution();
            }
            else
            {
                OpenSolution();
            }
            UpdateSolutionExistenceStatus();
        }

        void GenerateSolution()
        {
            var task = GenerateSolutionCommand.GenerateSolution(ModuleReference);
            if (task.Exception != null)
            {
                UpdateMessageBox("Solution failed to generate: " + task.Exception?.Message, true, HelpBoxMessageType.Error);
            }
            else
            {
                UpdateMessageBox("Solution generated successfully.", true, HelpBoxMessageType.Info);
            }
        }

        async Task GenerateModuleBindingsAsync()
        {
            Exception ex = null;
            try
            {
                var taskResult = await CloudCodeAuthoringServices.Instance
                    .GetService<ICloudCodeModuleBindingsGenerator>()
                        .GenerateModuleBindings(new List<IModuleItem>() { ModuleReference }, CancellationToken.None);

                var generationResult = taskResult.First();
                if (generationResult.IsSuccessful)
                {
                    UpdateMessageBox($"Bindings generated successfully in {generationResult.OutputPath}.", true, HelpBoxMessageType.Info);
                    SelectInProjectWindow(generationResult.OutputPath);
                }
                else
                {
                    UpdateMessageBox("Bindings failed to generate: " + generationResult.Exception !.Message, true, HelpBoxMessageType.Error);
                    ex = generationResult.Exception;
                }
            }
            catch (Exception e)
            {
                UpdateMessageBox("Bindings failed to generate: " + e.Message, true, HelpBoxMessageType.Error);
                ex = e;
            }
            finally
            {
                m_GenerateBindingsContainer.SetEnabled(true);

                CloudCodeAuthoringServices.Instance.GetService<ICloudCodeModuleBindingsGenerationAnalytics>()
                    .SendCodeGenerationFromInspectorBtnEvent(ex);
            }
        }

        void GenerateModuleBindings()
        {
            m_GenerateBindingsContainer.SetEnabled(false);
            _ = GenerateModuleBindingsAsync();
            UpdateSolutionExistenceStatus();
        }

        void UpdateMessageBox(string message, bool isVisible, HelpBoxMessageType messageType)
        {
            if (m_MessageBox != null)
            {
                m_MessageBox.text = message;
                m_MessageBox.visible = isVisible;
                m_MessageBox.messageType = messageType;
            }
        }

        void UpdateApplyRevertEnabled()
        {
            m_ApplyFooter.SetEnabled(m_ChangeTracker.IsDirty());
            m_HandleSolutionContainer.SetEnabled(!m_ChangeTracker.IsDirty());
            m_GenerateBindingsContainer.SetEnabled(!m_ChangeTracker.IsDirty());
            UpdateSolutionExistenceStatus();
        }

        void DisableReadonlyFlags()
        {
            serializedObject.targetObject.hideFlags = HideFlags.None;
        }

        static void SelectInProjectWindow(string path)
        {
            var asset = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
            Selection.activeObject = asset;

            var types = TypeCache
                .GetTypesDerivedFrom<EditorWindow>()
                .ToList();
            var pb = types
                .FirstOrDefault(t => t.Name == "ProjectBrowser");
            if (pb != null)
            {
                var window = EditorWindow.GetWindow(pb);
                window?.ShowTab();
            }
        }

        static class UxmlNames
        {
            public const string Apply = "Apply";
            public const string Revert = "Revert";
            public const string ApplyFooter = "Apply Footer";
            public const string HandleSolutionButton = "handle-solution-button";
            public const string GenerateBindingsButton = "GenerateModuleBindings";
            public const string HandleSolutionContainer = "handle-solution-container";
            public const string GenerateBindingsContainer = "GenerateBindingsContainer";
        }
    }
}
