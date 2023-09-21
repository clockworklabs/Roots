using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UIElements;

namespace Roots.Editor {
    [CustomPropertyDrawer(typeof(RootsStyleSheet))]
    public class RootsStyleSheetDrawer : PropertyDrawer
    {
        private SerializedObject SerializedObject { get; set; }
        private SerializedProperty NativeProperty { get; set; }
        private SerializedProperty ResponsiveProperty { get; set; }
        
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            SerializedObject = property.serializedObject;
            NativeProperty = property.FindPropertyRelative("_nativeStyleSheet");
            ResponsiveProperty = property.FindPropertyRelative("_responsiveStyleSheet");
            
            var container = new VisualElement();
            
            var styleSheetField = new ObjectField
            {
                allowSceneObjects = false,
                objectType = typeof(ScriptableObject),
                value = NativeProperty.objectReferenceValue != null 
                    ? NativeProperty.objectReferenceValue 
                    :  ResponsiveProperty.objectReferenceValue
            };
            styleSheetField.RegisterValueChangedCallback(OnChange);

            container.Add(styleSheetField);

            return container;
        }

        private void OnChange(ChangeEvent<Object> evt)
        {
            if (evt.target is not ObjectField target)
            {
                return;
            }

            var value = evt.newValue;
            if (value == null)
            {
                Set(null, null);
                return;
            }

            switch (evt.newValue)
            {
                case StyleSheet nativeValue:
                    Set(nativeValue, null);
                    break;
                case ResponsiveStyleSheet responsiveValue:
                    Set(null, responsiveValue);
                    break;
                default:
                    if (evt.newValue != null)
                    {
                        target.UnregisterValueChangedCallback(OnChange);
                        target.value = evt.previousValue;
                        target.RegisterValueChangedCallback(OnChange);
                    }

                    break;
            }
        }

        private void Set(StyleSheet nativeValue, ResponsiveStyleSheet responsiveValue)
        {
            SetNative(nativeValue);
            SetResponsive(responsiveValue);
            ApplyChanges();
        }

        private void SetNative(StyleSheet value) => NativeProperty.objectReferenceValue = value;
        private void SetResponsive(ResponsiveStyleSheet value) => ResponsiveProperty.objectReferenceValue = value;
        private void ApplyChanges() => SerializedObject.ApplyModifiedProperties();
    }
}