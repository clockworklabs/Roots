using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    [Serializable]
    public class RootsStyleSheet
    {
        [SerializeField]
        private StyleSheet _nativeStyleSheet;
        private StyleSheet NativeStyleSheet => _nativeStyleSheet;
        
        [SerializeField]
        private ResponsiveStyleSheet _responsiveStyleSheet;
        private ResponsiveStyleSheet ResponsiveStyleSheet => _responsiveStyleSheet;

        internal ResponsiveStyleSheet GetResponsive() => NativeStyleSheet != null ? NativeStyleSheet : ResponsiveStyleSheet;
    }
}
