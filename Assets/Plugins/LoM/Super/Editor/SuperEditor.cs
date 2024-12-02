using System.Collections.Generic;
using System.Linq; 
using System.Reflection;
using UnityEngine;
using UnityEditor;
using System;
using LoM.Super.Serialization;
using LoM.Super.Internal;

namespace LoM.Super.Editor
{
    /// <summary>
    /// Derive from this base class to create a custom inspector or editor for your SuperBehaviour object.
    /// </summary>
    public abstract class SuperEditor<T> : UnityEditor.Editor where T : SuperBehaviour
    {        
        // Static Variables
        private static Color s_controlBackgroundColor = new Color(48f / 255f, 48f / 255f, 48f / 255f);
        
        // Member Variables
        private SuperSerializedObject m_serializedObject;
        private SuperBehaviourIcon m_lastIconAssigned = SuperBehaviourIcon.None;
        
        /// <summary>
        /// The target object of this editor
        /// </summary>
        public new T target => base.target as T;
        
        /// <summary>
        /// The target objects of this editor
        /// </summary>
        public new T[] targets => base.targets.Cast<T>().ToArray();
        
        /// <summary>
        /// Returns if script should be displayed in inspector
        /// </summary>
        public virtual bool ShowScript() => true;
        
        /// <summary>
        /// Override OnInspectorFieldsGUI or OnInspectorPropertiesGUI instead
        /// </summary>
        public sealed override void OnInspectorGUI()
        {
            UpdateIcon();
            OnInspectorFieldsGUI();
            OnInspectorPropertiesGUI();
        }
        
        // On Enable
        private void OnEnable()
        {
            if (targets.Length == 1)
            { 
                m_serializedObject = new SuperSerializedObject(target);
            }
            else
            {
                m_serializedObject = new SuperSerializedObject(targets);
            }
            UpdateIcon();
            AfterOnEnable();
        }
        
        /// <summary>
        /// Implement this function to use the OnEnable function.
        /// </summary>
        protected virtual void AfterOnEnable() {}
        
        // On Disable
        private void OnDisable()
        {
            m_serializedObject?.Dispose();
            AfterOnDisable();
        }
        
        /// <summary>
        /// Implement this function to use the OnDisable function.
        /// </summary>
        protected virtual void AfterOnDisable() {}
        
        /// <summary>
        /// Implement this function to make a custom inspector.
        /// </summary>
        public virtual void OnInspectorFieldsGUI()
        {
            DrawDefaultInspector();
        }
        
        /// <summary>
        /// Implement this function to override the properties inspector.
        /// </summary>
        public new void DrawDefaultInspector()
        {
            // Preview the script
            if (ShowScript())
            {
                EditorGUI.BeginDisabledGroup(true);
                EditorGUILayout.ObjectField("Script", MonoScript.FromMonoBehaviour(target), typeof(MonoScript), false);
                EditorGUI.EndDisabledGroup();
            }
            
            // Draw all fields
            m_serializedObject.Update();
            foreach (SuperSerializedProperty field in m_serializedObject.Fields)
            {
                if (!field.Attributes.IsActive) continue;
                
                bool enabledBefore = GUI.enabled;
                if (field.Attributes.IsReadOnly) GUI.enabled = false;
                
                if (field.Attributes.IsLayer 
                 || field.Attributes.IsTag 
                 || field.Attributes.IsHDRColor)
                {
                    if (field.Attributes.IsHeader)
                    {
                        Rect rect = EditorGUILayout.GetControlRect(false, 26);
                        rect.y += 8;
                        EditorGUI.LabelField(rect, field.Attributes.Header.Header, EditorStyles.boldLabel);
                    }
                    DrawImprovedFields(field);
                    GUI.enabled = enabledBefore;
                    continue;
                }
                
                EditorSuperGUILayout.PropertyField(field);
                GUI.enabled = enabledBefore;
            }
            
            // Apply changes
            if (GUI.changed)
            {
                m_serializedObject.ApplyModifiedProperties();
            }
        }
        
        /// <summary>
        /// Implement this function to override the properties inspector.
        /// </summary>
        public virtual void OnInspectorPropertiesGUI()
        {
            if (m_serializedObject.Properties.Length == 0) return;
            
            // Draw separator
            Rect rect = EditorGUILayout.GetControlRect(false, 16);
            rect.xMin = 0;
            rect.width += 15;
            rect.height += 4;
            rect.y += EditorGUIUtility.standardVerticalSpacing * 3;
            EditorGUI.DrawRect(rect, s_controlBackgroundColor);
            
            // Draw Collapasable Label
            rect.x += 18;
            target.ShowProperties = EditorGUI.Foldout(rect, target.ShowProperties, "Properties", true, EditorStyles.foldout.Variant("SuperEditor_Foldout", style => {
                style.normal.background = null;
                style.normal.textColor = Color.gray;
                style.onNormal.textColor = Color.gray;
            }));
            if (!target.ShowProperties) return;
            
            // Fix height
            rect = EditorGUILayout.GetControlRect(false, 13);
            
            // Draw all properties
            m_serializedObject.Update();
            foreach (SuperSerializedProperty property in m_serializedObject.Properties)
            {                
                if (!property.Attributes.IsActive) continue;
                bool enabledBefore = GUI.enabled;
                if (property.Attributes.IsReadOnly || !Application.isPlaying || m_serializedObject.isEditingMultipleObjects) GUI.enabled = false;
                
                // Draw header
                if (property.Attributes.IsHeader)
                {
                    rect = EditorGUILayout.GetControlRect(false, 26);
                    rect.y += 8;
                    EditorGUI.LabelField(rect, property.Attributes.Header.Header, EditorStyles.boldLabel);
                }
                
                // Draw property
                EditorSuperGUILayout.PropertyField(property);
                GUI.enabled = enabledBefore;
            }
        }
        
        // DrawImprovedFields
        private void DrawImprovedFields(SuperSerializedProperty field)
        {
            if (!field.IsField) return;
            
            // Label
            GUIContent label = new GUIContent(field.displayName, field.tooltip);
            
            // Layer
            if (field.Attributes.IsLayer)
            {
                EditorGUI.showMixedValue = MixModeEnabledLayer(field);
                int layer = field.intValue;
                int newLayer = EditorGUILayout.LayerField(label, layer);
                if (!field.Attributes.IsReadOnly && layer != newLayer) 
                {
                    field.intValue = newLayer;
                    EditorUtility.SetDirty(target);
                }
            }
            
            // Tag
            else if (field.Attributes.IsTag)
            {
                EditorGUI.showMixedValue = MixModeEnabledTag(field);
                string tag = field.stringValue;
                string newTag = EditorGUILayout.TagField(label, tag);
                if (!field.Attributes.IsReadOnly && tag != newTag) 
                {
                    field.stringValue = newTag;
                    EditorUtility.SetDirty(target);
                }
            }
            
            // HDR Color
            else if (field.Attributes.IsHDRColor)
            {
                EditorGUI.showMixedValue = MixModeEnabledHDRColor(field);
                Color color = field.colorValue;
                Color newColor = EditorGUILayout.ColorField(label, color);
                if (!field.Attributes.IsReadOnly && color != newColor) 
                {
                    field.colorValue = newColor;
                    EditorUtility.SetDirty(target);
                }
            }
            
            EditorGUI.showMixedValue = false;
        }
        
        // Helper: Get if mix mode is enabled for Layer
        private bool MixModeEnabledLayer(SuperSerializedProperty property)
        {
            if (property.superSerializedObject.isEditingMultipleObjects)
            {
                int[] values = property.superSerializedObject.FindAllPropertiesByPath(property.propertyPath).Select(p => p.intValueSingle).ToArray();
                return values.Any(v => v != values[0]);
            }
            return false;
        }
        
        // Helper: Get if mix mode is enabled for Tag
        private bool MixModeEnabledTag(SuperSerializedProperty property)
        {
            if (property.superSerializedObject.isEditingMultipleObjects)
            {
                string[] values = property.superSerializedObject.FindAllPropertiesByPath(property.propertyPath).Select(p => p.stringValueSingle).ToArray();
                return values.Any(v => v != values[0]);
            }
            return false;
        }
        
        // Helper: Get if mix mode is enabled for HDR Color
        private bool MixModeEnabledHDRColor(SuperSerializedProperty property)
        {
            if (property.superSerializedObject.isEditingMultipleObjects)
            {
                Color[] values = property.superSerializedObject.FindAllPropertiesByPath(property.propertyPath).Select(p => p.colorValueSingle).ToArray();
                return values.Any(v => v != values[0]);
            }
            return false;
        }
        
        // Updates the icon of the class
        private void UpdateIcon()
        {
            SuperBehaviourIcon icon = IconUtility.GetIconByClassName(m_serializedObject?.TypeName);
            if (m_lastIconAssigned == icon) return;
            EditorGUIUtility.SetIconForObject(target, IconUtility.GetIconTexture(icon));
            m_lastIconAssigned = icon;
        }
    }
}