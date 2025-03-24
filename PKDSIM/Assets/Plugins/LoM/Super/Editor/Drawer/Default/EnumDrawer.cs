using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using LoM.Super.Serialization;
using System;

namespace LoM.Super.Editor.Drawer
{
    [CustomSuperPropertyDrawer(typeof(Enum))]
    public class EnumDrawer : SuperPropertyDrawer
    {
        private static Color m_backgroundColor = new Color(81f / 255f, 81f / 255f, 81f / 255f);
        
        public override void OnGUI(Rect position, SuperSerializedProperty property, GUIContent label)
        {            
            // Check if has Flag attribute
            bool isFlag = property.Type.GetCustomAttributes(typeof(FlagsAttribute), false).Length > 0;
            
            if (isFlag)
            {
                // Draw flag enum
                EditorGUI.showMixedValue = MixModeEnabledFlag(property);
                EditorGUI.BeginChangeCheck();
                Enum enumValue = (Enum)Enum.ToObject(property.Type, property.enumValueFlag);
                enumValue = EditorGUI.EnumFlagsField(position, label, enumValue);
                if (EditorGUI.EndChangeCheck())
                {
                    property.enumValueFlag = Convert.ToInt32(enumValue);
                }
            }
            else
            {
                // Draw normal enum
                EditorGUI.showMixedValue = MixModeEnabledEnum(property);
                EditorGUI.BeginChangeCheck();
                Enum enumValue = (Enum)Enum.ToObject(property.Type, property.enumValueIndex);
                enumValue = EditorGUI.EnumPopup(position, label, enumValue);
                if (EditorGUI.EndChangeCheck())
                {
                    property.enumValueIndex = Convert.ToInt32(enumValue);
                }
            }
            
            EditorGUI.showMixedValue = false;
        }
        
        private bool MixModeEnabledEnum(SuperSerializedProperty property)
        {
            if (property.superSerializedObject.isEditingMultipleObjects)
            {
                int[] values = property.superSerializedObject.FindAllPropertiesByPath(property.propertyPath).Select(p => p.enumValueIndexSingle).ToArray();
                return values.Any(v => v != values[0]);
            }
            return false;
        }
        
        private bool MixModeEnabledFlag(SuperSerializedProperty property)
        {
            if (property.superSerializedObject.isEditingMultipleObjects)
            {
                int[] values = property.superSerializedObject.FindAllPropertiesByPath(property.propertyPath).Select(p => p.enumValueFlagSingle).ToArray();
                return values.Any(v => v != values[0]);
            }
            return false;
        }
    }
}