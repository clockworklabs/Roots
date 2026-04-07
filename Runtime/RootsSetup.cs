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

        private RishRoot RishRoot { get; set; }

        private List<StyleSheet> BaseStyleSheets { get; } = new();

        private VisualElement _rootVisualElement;
        private VisualElement RootVisualElement
        {
            get => _rootVisualElement;
            set
            {
                if (_rootVisualElement == value) return;

                if (_rootVisualElement != null)
                {
                    _rootVisualElement.UnregisterCallback<GeometryChangedEvent>(Sappy.OnGeometryChanged);
                    
                    _rootVisualElement.styleSheets.Clear();
                    for(int i = 0, n = BaseStyleSheets.Count; i < n; i++)
                    {
                        _rootVisualElement.styleSheets.Add(BaseStyleSheets[i]);
                    }
                }
                
                BaseStyleSheets.Clear();
                
                _rootVisualElement = value;

                if (value != null)
                {
                    value.RegisterCallback<GeometryChangedEvent>(Sappy.OnGeometryChanged);
                    
                    var baseStyleSheetsCount = value.styleSheets.count;
                    for(var i = 0; i < baseStyleSheetsCount; i++)
                    {
                        var styleSheet = value.styleSheets[i];
                        BaseStyleSheets.Add(styleSheet);
                    }
            
                    foreach (var responsiveStyleSheet in SortedStyleSheets)
                    {
                        if (responsiveStyleSheet.MinWidth > 0)
                        {
                            break;
                        }
                
                        value.styleSheets.Add(responsiveStyleSheet.StyleSheet);
                    }
                    
                    OnNewSize(null, _rootVisualElement.layout.width);
                }
            }
        }

        private void Awake()
        {
            UIDocument = GetComponent<UIDocument>();
            
            var styleSheets = StyleSheets.Where(ss => ss != null && ss.GetResponsive() != null).SelectMany(ss => ss.GetResponsive().StyleSheets).ToList();
            _sortedStyleSheets = styleSheets.OrderBy(styleSheet => styleSheet.MinWidth).ToList().AsReadOnly();
            
            RishRoot = gameObject.GetComponent<RishRoot>();
            if (RishRoot != null)
            {
                RishRoot.OnStart.Add(Sappy.SetupRishRoot);
            }
        }
        private void OnDestroy()
        {
            if (RishRoot != null)
            {
                RishRoot.OnStart.Remove(Sappy.SetupRishRoot);
            }
            
            RootVisualElement = null;
        }

        [SapTarget]
        private void SetupRishRoot()
        {
            RootVisualElement = UIDocument.rootVisualElement;
        }

        [SapTarget(typeof(EventCallback<GeometryChangedEvent>))]
        private void OnGeometryChanged(GeometryChangedEvent evt)
        {
            var oldWidth = evt.oldRect.width;
            var newWidth = evt.newRect.width;

            if (Mathf.Approximately(oldWidth, newWidth)) return;
            
            OnNewSize(oldWidth, newWidth);
        }
        
        private void OnNewSize(float? oldWidth, float newWidth)
        {
            if (newWidth < 0 || float.IsNaN(newWidth) || float.IsInfinity(newWidth)) return;

            if (newWidth < oldWidth)
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
                    
                    RootVisualElement.styleSheets.Remove(styleSheet.StyleSheet);
                }
            }
            else
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
                    
                    RootVisualElement.styleSheets.Add(styleSheet.StyleSheet);
                }
            }
        }
    }
}
