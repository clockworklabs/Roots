using System;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;
using Translate = UnityEngine.UIElements.Translate;

namespace Roots
{
    internal partial class Menu : RishElement<MenuProps, MenuState>, IMountingListener, IPropsListener
    {
        private ContextualContext Context { get; set; }
        
        public Menu()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<ContextualContext>();
            Context?.RegisterMenu(this);
        }
        void IMountingListener.ComponentWillUnmount() { 
            Context?.UnregisterMenu(this);
        }

        void IPropsListener.PropsDidChange()
        {
            var local = Context.WorldToLocal(Props.position);
            var contextSize = Context.ContentRect.size;
            var style = new Style
            {
                position = Position.Absolute,
                // visibility = Visibility.Hidden, // Changing visibility blurs the element
                opacity = 0
            };
            switch (Props.anchor)
            {
                case Contextual.Anchor.TopLeft:
                    style.left = local.x;
                    style.top = local.y;
                    break;
                case Contextual.Anchor.BottomLeft:
                    style.left = local.x;
                    style.bottom = contextSize.y - local.y;
                    break;
                case Contextual.Anchor.TopRight:
                    style.right = contextSize.x - local.x;
                    style.top = local.y;
                    break;
                case Contextual.Anchor.BottomRight:
                    style.right = contextSize.x - local.x;
                    style.bottom = contextSize.y - local.y;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            SetStyle(style);
        }
        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => Div.Create(style: State.style, children: Props.element);
        
        private void OnVisualChange(VisualChangeEvent evt)
        {
            var parentSize = Context.ContentRect.size;
            
            var style = State.style;

            Length xOffset;
            switch (Props.anchor)
            {
                case Contextual.Anchor.TopLeft or Contextual.Anchor.BottomLeft:
                    if (Layout.xMax <= parentSize.x)
                    {
                        xOffset = Length.None();
                    }
                    else
                    {
                        if (Props.anchorCanChange && Layout.xMin > Layout.width)
                        {
                            xOffset = Length.Percent(-100);
                        }
                        else
                        {
                            xOffset = -Mathf.Min(Layout.xMax - parentSize.x, Layout.xMin);
                        }
                    }

                    break;
                case Contextual.Anchor.TopRight or Contextual.Anchor.BottomRight:
                    if (Layout.xMin >= 0)
                    {
                        xOffset = Length.None();
                    }
                    else
                    {
                        if (Props.anchorCanChange && parentSize.x - Layout.xMax > Layout.width)
                        {
                            xOffset = Length.Percent(100);
                        }
                        else
                        {
                            xOffset = Mathf.Min(-Layout.xMin, parentSize.x - Layout.xMax);
                        }
                    }
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Length yOffset;
            switch (Props.anchor)
            {
                case Contextual.Anchor.TopLeft or Contextual.Anchor.TopRight:
                    if (Layout.yMax <= parentSize.y)
                    {
                        yOffset = Length.None();
                    }
                    else
                    {
                        if (Props.anchorCanChange && Layout.yMin > Layout.width)
                        {
                            yOffset = Length.Percent(-100);
                        }
                        else
                        {
                            yOffset = -Mathf.Min(Layout.yMax - parentSize.y, Layout.yMin);
                        }
                    }

                    break;
                case Contextual.Anchor.BottomLeft or Contextual.Anchor.BottomRight:
                    if (Layout.yMin >= 0)
                    {
                        yOffset = Length.None();
                    }
                    else
                    {
                        if (Props.anchorCanChange && parentSize.y - Layout.yMax > Layout.width)
                        {
                            yOffset = Length.Percent(100);
                        }
                        else
                        {
                            yOffset = Mathf.Min(-Layout.yMin, parentSize.y - Layout.yMax);
                        }
                    }
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            style.translate = new Translate(
                xOffset,
                yOffset,
                // 0,
                0
            );
            style.opacity = 1;
            
            SetStyle(style);
        }
    }

    [RishValueType]
    internal struct MenuProps
    {
        public Vector2 position;
        public Element element;
        public Contextual.Anchor anchor;
        public bool anchorCanChange;
    }

    [RishValueType]
    internal struct MenuState
    {
        public Style style;
    }
}