using UnityEngine;

namespace Roots
{
    public class StyleSheetsGroup : ScriptableObject
    {
        [SerializeField]
        private ResponsiveStyleSheet[] _styleSheets;
        internal ResponsiveStyleSheet[] StyleSheets => _styleSheets;
    }
}
