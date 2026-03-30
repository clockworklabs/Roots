using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    [Serializable]
    public class MediaQueryStyleSheet
    {
        [SerializeField]
        private int _minWidth;
        internal int MinWidth => _minWidth;
        
        [SerializeField]
        private StyleSheet _styleSheet;
        internal StyleSheet StyleSheet => _styleSheet;

        public static implicit operator MediaQueryStyleSheet(StyleSheet styleSheet) => new()
        {
            _minWidth = 0,
            _styleSheet = styleSheet
        };
    }
    
    [CreateAssetMenu(fileName = "New ResponsiveStyleSheet", menuName = "Roots/ResponsiveStyleSheet", order = 100)]
    public class ResponsiveStyleSheet : ScriptableObject
    {
        [SerializeField]
        private MediaQueryStyleSheet[] _styleSheets;
        internal MediaQueryStyleSheet[] StyleSheets => _styleSheets;

        public static implicit operator ResponsiveStyleSheet(StyleSheet styleSheet)
        {
            var instance = CreateInstance<ResponsiveStyleSheet>();
            instance._styleSheets = new MediaQueryStyleSheet[] { styleSheet };

            return instance;
        }
    }
}
