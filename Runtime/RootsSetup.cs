using System.Collections.Generic;
using System.Linq;
using RishUI;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    [RequireComponent(typeof(UIDocument))]
    [RequireComponent(typeof(RishRoot))]
    [DisallowMultipleComponent]
    public partial class RootsSetup : MonoBehaviour
    {
        [SerializeField]
        private RootsStyleSheet[] _styleSheets;
        private RootsStyleSheet[] StyleSheets => _styleSheets;
        
        private UIDocument UIDocument { get; set; }

        private IReadOnlyList<MediaQueryStyleSheet> _sortedStyleSheets;
        private IReadOnlyList<MediaQueryStyleSheet> SortedStyleSheets => _sortedStyleSheets;

        private List<StyleSheet> BaseStyleSheets { get; } = new();

        private RishRoot RishRoot { get; set; }
        
        private void Awake()
        {
            UIDocument = GetComponent<UIDocument>();
            
            var styleSheets = StyleSheets.SelectMany(ss => ss.GetResponsive().StyleSheets).ToList();
            styleSheets.Sort((a, b) => a.MinWidth.CompareTo(b.MinWidth));
            _sortedStyleSheets = styleSheets.AsReadOnly();
            
            RishRoot = gameObject.GetComponent<RishRoot>();
            if (RishRoot != null)
            {
                RishRoot.OnStart += SappySetupRishRoot;
            }

            ResponsiveContext.OnResize += SappyOnResponsiveResize;
        }
        private void OnDestroy()
        {
            if (RishRoot != null)
            {
                RishRoot.OnStart -= SappySetupRishRoot;
            }
            ResponsiveContext.OnResize -= SappyOnResponsiveResize;
        }

        [SapTarget]
        private void SetupRishRoot()
        {
            var root = UIDocument.rootVisualElement;
            
            BaseStyleSheets.Clear();
            var baseStyleSheetsCount = root.styleSheets.count;
            for(var i = 0; i < baseStyleSheetsCount; i++)
            {
                var styleSheet = root.styleSheets[i];
                BaseStyleSheets.Add(styleSheet);
            }
            
            root.styleSheets.Clear();
            
            foreach (var responsiveStyleSheet in SortedStyleSheets)
            {
                if (responsiveStyleSheet.MinWidth > 0)
                {
                    break;
                }
                
                root.styleSheets.Add(responsiveStyleSheet.StyleSheet);
            }
            
            for(var i = 0; i < baseStyleSheetsCount; i++)
            {
                var styleSheet = BaseStyleSheets[i];
                root.styleSheets.Add(styleSheet);
            }
        }
        
        [SapTarget(typeof(OnResponsiveContextResize))]
        private void OnResponsiveResize(ResponsiveContext responsive, float oldWidth, float newWidth)
        {
            if (!TreeContains(responsive)) return;
            
            if (newWidth > oldWidth)
            {
                foreach (var styleSheet in SortedStyleSheets)
                {
                    if (styleSheet.MinWidth <= oldWidth)
                    {
                        continue;
                    }

                    if (styleSheet.MinWidth > newWidth)
                    {
                        break;
                    }
                    
                    responsive.styleSheets.Add(styleSheet.StyleSheet);
                }
            }
            else
            {
                foreach (var styleSheet in SortedStyleSheets)
                {
                    if (styleSheet.MinWidth <= newWidth)
                    {
                        continue;
                    }

                    if (styleSheet.MinWidth > oldWidth)
                    {
                        break;
                    }
                    
                    responsive.styleSheets.Remove(styleSheet.StyleSheet);
                }
            }
        }

        private bool TreeContains(VisualElement body) => UIDocument.rootVisualElement.Contains(body);
    }
}
