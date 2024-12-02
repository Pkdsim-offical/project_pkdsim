using System;
using UnityEditor;
using UnityEngine;

namespace LoM.Super.Editor
{
    internal class SuperBehaviourPreferenceCoreProvider : SuperBehaviourPreferenceProvider
    {
        // Getters
        public override string Name => "Default";
        public override int Order => -999;

        // OnGUI
        public override void OnGUI()
        {
            RenderTitle("Inspector");
            
            // Pre-Caching
            bool allowPreCaching = RenderToggle("Allow Pre-Caching", "PreCache.Enabled", true);
            if (allowPreCaching)
            {
                RenderBoolField("   Include Plugins", "PreCache.SuperPlugins", true);
                RenderTextField("   Scripts Folder", "PreCache.ScriptsPath", "Scripts");
            }
            else
            {
                EditorGUILayout.HelpBox("Pre-Caching is disabled. This may cause performance issues when opening SuperBehaviour scripts in the inspector.", MessageType.Warning);
            }
        }
        
        // Register provider on domain reload
        [InitializeOnLoadMethod]
        private static void RegisterProvider() => SuperBehaviourPreferences.RegisterPreferenceProvider<SuperBehaviourPreferenceCoreProvider>();
    }
}