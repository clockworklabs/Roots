// #define TRY_KEEP_DESCENDANTS_MARGINS

using System;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;
#if TRY_KEEP_DESCENDANTS_MARGINS
using System.Collections.Generic;
using StyleLength = UnityEngine.UIElements.StyleLength;
#endif

namespace Roots.Bootstrap
{
    // This element will override some margin properties of descendants.
    internal partial class Stack : RishElement<StackProps, StackState>, IManualState, IPropsListener<StackProps>, IVisualManipulator
    {
        public enum Direction { Vertical, Horizontal }
        
        private VisualElement _visualParent;
        private VisualElement VisualParent => _visualParent ??= GetFirstAncestorOfType<VisualElement>();

#if TRY_KEEP_DESCENDANTS_MARGINS
        private Dictionary<IManipulable, Margins> PrevMargins { get; } = new();
#endif

        void IManualState.Restart()
        {
            _visualParent = null;
#if TRY_KEEP_DESCENDANTS_MARGINS
            PrevMargins.Clear();
#endif
        }

        void IPropsListener<StackProps>.PropsDidChange(StackProps? prev)
        {
            if (prev.HasValue && Mathf.Approximately(prev.Value.gap, Props.gap)) return;

            SetHalfGap(Props.gap * 0.5f);
        }
        void IPropsListener<StackProps>.PropsWillChange() { }
        
        bool IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
#if !TRY_KEEP_DESCENDANTS_MARGINS
            if (phase == VisualManipulationPhase.GeometryChanged) return true;
#endif
            var parent = descendant?.parent;
            if (parent == null) return false;
            if (phase == VisualManipulationPhase.BubbleUp)
            {
                if (parent.parent != VisualParent) return false;

#if TRY_KEEP_DESCENDANTS_MARGINS
                var style = descendant.style;
                if (TryGetMargins(Props.direction, style, out var margins))
                {
                    PrevMargins[descendant] = margins;
                }
                else
                {
                    PrevMargins.Remove(descendant);
                }
                
                return true;
#endif
            }
            
            if (descendant.display == DisplayStyle.None || descendant.position == Position.Absolute) return true;

            var targetMargins = new Vector2
            {
                x = State.halfGap,
                y = State.halfGap
            };

#if TRY_KEEP_DESCENDANTS_MARGINS
            if (PrevMargins.TryGetValue(descendant, out var prevMargins))
            {
                var m = parent.contentRect.width * 0.01f;

                targetMargins.x += GetMargin(prevMargins.a, m);
                targetMargins.y += GetMargin(prevMargins.b, m);
            }
#endif
            
            var clonedStyle = descendant.CloneStyle();
            switch (Props.direction)
            {
                case Direction.Vertical:
                    clonedStyle.marginTop = targetMargins.x;
                    clonedStyle.marginBottom = targetMargins.y;
                    break;
                case Direction.Horizontal:
                    clonedStyle.marginLeft = targetMargins.x;
                    clonedStyle.marginRight = targetMargins.y;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Props.direction), Props.direction, null);
            }
            descendant.SetStyle(clonedStyle);
            
            // switch (Props.direction)
            // {
            //     case Direction.Vertical:
            //         descendant.style.marginTop = targetMargins.x;
            //         descendant.style.marginBottom = targetMargins.y;
            //         break;
            //     case Direction.Horizontal:
            //         descendant.style.marginLeft = targetMargins.x;
            //         descendant.style.marginRight = targetMargins.y;
            //         break;
            //     default:
            //         throw new ArgumentOutOfRangeException(nameof(Props.direction), Props.direction, null);
            // }

            return true;
        }
        
#if TRY_KEEP_DESCENDANTS_MARGINS
        private static bool TryGetMargins(Direction direction, IStyle style, out Margins margins)
        {
            StyleLength a, b;
            switch (direction)
            {
                case Direction.Vertical:
                    a = style.marginTop;
                    b = style.marginBottom;
                    break;
                case Direction.Horizontal:
                    a = style.marginLeft;
                    b = style.marginRight;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            margins = new Margins { a = a, b = b };
            return a.keyword == StyleKeyword.Undefined || b.keyword == StyleKeyword.Undefined;
        }
        private static float GetMargin(StyleLength style, float m)
        {
            if (style.keyword != StyleKeyword.Undefined) return 0;
            if (style.value.unit is LengthUnit.Percent)
            {
                return m * style.value.value;
            }
            return style.value.value;
        }
#endif

        protected override Element Render()
        {
            var style = Props.direction switch
            {
                Direction.Vertical => new Style
                {
                    flexDirection = FlexDirection.Column,
                    marginTop = -State.halfGap,
                    marginBottom = -State.halfGap,
                },
                Direction.Horizontal => new Style
                {
                    flexDirection = FlexDirection.Row,
                    marginLeft = -State.halfGap,
                    marginRight = -State.halfGap,
                }
            };
            
            return Div.Create(descriptor: Props.descriptor + style, children: Props.children);
        }

#if TRY_KEEP_DESCENDANTS_MARGINS
        private struct Margins
        {
            public StyleLength a;
            public StyleLength b;

            public override string ToString() => $"({a}, {b})";
        }
#endif
    }

    [RishValueType]
    internal struct StackProps
    {
        public Stack.Direction direction;
        public float gap;
        public DOMDescriptor descriptor;
        public Children children;
    }

    [RishValueType]
    internal struct StackState
    {
        public float halfGap;
    }
}
