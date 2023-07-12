using System.Collections.Generic;
using System.Linq;
using RishUI;
using UnityEngine;

namespace Roots
{
    public class RootsSetup : MonoBehaviour
    {
        [SerializeField]
        private ResponsiveStyleSheet[] _styleSheets;
        private ResponsiveStyleSheet[] StyleSheets => _styleSheets;

        private IReadOnlyList<MediaQueryStyleSheet> _sortedStyleSheets;
        private IReadOnlyList<MediaQueryStyleSheet> SortedStyleSheets => _sortedStyleSheets;
        
        private RishRoot RishRoot { get; set; }

        private void Awake()
        {
            var styleSheets = StyleSheets.SelectMany(group => group.StyleSheets).ToList();
            styleSheets.Sort((a, b) => a.MinWidth.CompareTo(b.MinWidth));
            _sortedStyleSheets = styleSheets.AsReadOnly();
            
            RishRoot.OnStart += OnRishStart;
        }
        private void OnDestroy()
        {
            SetRishRoot(null);
            RishRoot.OnStart -= OnRishStart;
        }

        private void OnRishStart(RishRoot root)
        {
            if (root.gameObject != gameObject)
            {
                return;
            }

            SetRishRoot(root);
        }

        private void SetRishRoot(RishRoot root)
        {
            if (RishRoot != null)
            {
                RishRoot.OnResize -= OnResize;

                foreach (var styleSheet in SortedStyleSheets)
                {
                    RishRoot.RemoveStyleSheet(styleSheet.StyleSheet);
                }
            }

            if (root == null)
            {
                return;
            }

            root.OnResize += OnResize;

            foreach (var styleSheet in SortedStyleSheets)
            {
                if (styleSheet.MinWidth > 0)
                {
                    break;
                }
                
                root.AddStyleSheet(styleSheet.StyleSheet);
            }

            RishRoot = root;
        }

        private void OnResize(Vector2 oldSize, Vector2 newSize)
        {
            if (RishRoot == null)
            {
                return;
            }
            
            var oldWidth = oldSize.x;
            var newWidth = newSize.x;

            if (Mathf.Approximately(oldWidth, newWidth))
            {
                return;
            }

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
                    
                    RishRoot.AddStyleSheet(styleSheet.StyleSheet);
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
                    
                    RishRoot.RemoveStyleSheet(styleSheet.StyleSheet);
                }
            }
        }
    }
}
