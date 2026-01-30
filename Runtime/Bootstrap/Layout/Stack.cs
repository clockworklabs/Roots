using System;
using System.Collections.Generic;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;
using StyleLength = UnityEngine.UIElements.StyleLength;

namespace Roots.Bootstrap
{
    internal partial class Stack : RishElement<StackProps, StackState>, IManualState, IPropsListener<StackProps>, IVisualManipulator
    {
        public enum Direction { Vertical, Horizontal }
        
        private VisualElement _visualParent;
        private VisualElement VisualParent => _visualParent ??= GetFirstAncestorOfType<VisualElement>();
        
        private Dictionary<VisualElement, Vector2> OriginalMargins { get; }= new();

        void IManualState.Restart()
        {
            _visualParent = null;
            OriginalMargins.Clear();
        }

        void IPropsListener<StackProps>.PropsDidChange(StackProps? prev)
        {
            if (prev.HasValue && Mathf.Approximately(prev.Value.gap, Props.gap)) return;

            SetHalfGap(Props.gap * 0.5f);
        }
        void IPropsListener<StackProps>.PropsWillChange() { }
        
        bool IVisualManipulator.Manipulate(VisualManipulationPhase phase, VisualElement descendant)
        {
            var parent = descendant?.parent;
            if(parent == null) return false;
            
            var style = descendant.style;
            Vector2 originalMargins;
            switch (phase)
            {
                case VisualManipulationPhase.BubbleUp:
                    if (parent.parent != VisualParent) return false;
                    
                    var m = parent.contentRect.width * 0.01f;
                    originalMargins = GetMargins(Props.direction, style, m);
                    OriginalMargins[descendant] = originalMargins;
                    
                    if(Mathf.Approximately(State.halfGap, 0)) return true;
                    
                    break;
                case VisualManipulationPhase.DirectManipulation:
                    if (!OriginalMargins.TryGetValue(descendant, out originalMargins)) return false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(phase), phase, null);
            }
            
            switch (Props.direction)
            {
                case Direction.Vertical:
                    style.marginTop = originalMargins.x + State.halfGap;
                    style.marginBottom = originalMargins.y + State.halfGap;
                    break;
                case Direction.Horizontal:
                    style.marginLeft = originalMargins.x + State.halfGap;
                    style.marginRight = originalMargins.y + State.halfGap;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Props.direction), Props.direction, null);
            }

            return true;
        }

        private static Vector2 GetMargins(Direction direction, IStyle style, float m)
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

            return new Vector2(GetMargin(a, m), GetMargin(b, m));
        }
        private static float GetMargin(StyleLength style, float m)
        {
            if (style.keyword == StyleKeyword.Undefined) return 0;
            if (style.value.unit is LengthUnit.Percent)
            {
                return m * style.value.value;
            }
            return style.value.value;
        }

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
