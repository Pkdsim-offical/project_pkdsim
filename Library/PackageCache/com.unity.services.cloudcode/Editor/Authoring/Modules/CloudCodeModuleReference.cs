using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Unity.Services.CloudCode.Authoring.Editor.Core.Model;
using Unity.Services.CloudCode.Authoring.Editor.Shared.Assets;
using Unity.Services.CloudCode.Authoring.Editor.Shared.EditorUtils;
using Unity.Services.DeploymentApi.Editor;
using UnityEngine;
using WebSocketSharp;
using SystemPath = System.IO.Path;

namespace Unity.Services.CloudCode.Authoring.Editor.Modules
{
    class CloudCodeModuleReference : ScriptableObject, ICopyable<CloudCodeModuleReference>, IPath, IModuleItem
    {
        static readonly JsonSerializerSettings k_JsonSerializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        const string SolutionExtension = ".sln";

        [SerializeField]
        string m_ModulePath;
        string m_Path;
        string m_AssetName;
        float m_Progress;
        string m_Type = "C# Module";
        DeploymentStatus m_Status;

        string m_ModuleName;
        public string ModuleName
        {
            get => m_ModuleName;
            set => SetField(ref m_ModuleName, value);
        }
        public string Name
        {
            get
            {
                if (m_AssetName.IsNullOrEmpty())
                {
                    return SystemPath.GetFileName(Path);
                }
                return m_AssetName;
            }
            set => SetField(ref m_AssetName, value);
        }

        public string Type
        {
            get => m_Type;
        }

        public string Path
        {
            get => m_Path;
            set
            {
                SetName(value);
                SetField(ref m_Path, value);
            }
        }

        void SetName(string path)
        {
            Name = string.IsNullOrEmpty(path) ? string.Empty : System.IO.Path.GetFileName(path);
        }

        public string SolutionPath => GetSolutionPath();

        public string CcmPath { get; set; }

        public float Progress
        {
            get { return m_Progress; }
            set { SetField(ref m_Progress, value); }
        }

        public DeploymentStatus Status
        {
            get { return m_Status; }
            set { SetField(ref m_Status, value); }
        }

        public ObservableCollection<AssetState> States { get; set; }

        public string ModulePath
        {
            get => m_ModulePath;
            set => SetValidPath(value);
        }

        string GetSolutionPath()
        {
            var ccmrDir = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(m_Path));
            var targetPath = System.IO.Path.Combine(ccmrDir, ModulePath);
            return System.IO.Path.GetFullPath(targetPath);
        }

        void SetValidPath(string newModulePath)
        {
            var finalPath = newModulePath;
            if (!System.IO.Path.GetExtension(finalPath).Equals(SolutionExtension))
            {
                finalPath =
                    System.IO.Path.Combine(
                        newModulePath , System.IO.Path.GetFileNameWithoutExtension(Name) + SolutionExtension);
            }
            SetField(ref m_ModulePath, finalPath);
        }

        public CloudCodeModuleReference()
        {
            Progress = 0;
            Status = DeploymentStatus.Empty;
            States = new ObservableCollection<AssetState>();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(
                new
                {
                    ModulePath
                },
                k_JsonSerializerSettings);
        }

        public void FromJson(string json)
        {
            JsonConvert.PopulateObject(json, this, k_JsonSerializerSettings);
        }

        public void SaveChanges()
        {
            var json = ToJson();
            File.WriteAllText(Path, json);
        }

        public void CopyTo(CloudCodeModuleReference value)
        {
            value.ModulePath = ModulePath;
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
