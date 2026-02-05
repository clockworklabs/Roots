using System;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;

namespace Roots
{
    internal partial class Stack : RishElement<StackProps, StackState>, IManualState, IPropsListener<StackProps>, IVisualManipulator
    {
        public enum Direction { Vertical, Horizontal }

        private Dictionary<int, Vector2> PrevMargins { get; } = new();

        private VisualElement _visualChild;
        private VisualElement VisualChild => _visualChild ??= GetVisualChild();

        void IManualState.Restart()
        {
            _visualChild = null;
            PrevMargins.Clear();
        }

        void IPropsListener<StackProps>.PropsDidChange(StackProps? prev)
        {
            if (prev.HasValue && Mathf.Approximately(prev.Value.gap, Props.gap)) return;

            SetHalfGap(Props.gap * 0.5f);
        }
        void IPropsListener<StackProps>.PropsWillChange() { }

        bool IVisualManipulator.Evaluate(VisualElement descendant) => descendant == VisualChild || descendant.parent == VisualChild;
        
        void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
            var resolvedStyle = descendant.resolvedStyle;
            
            if (resolvedStyle.display == DisplayStyle.None || resolvedStyle.position == Position.Absolute) return;
            
            Vector2 targetMargins;
            if (phase == VisualManipulationPhase.BubbleUp)
            {
                targetMargins = Props.direction switch
                {
                    Direction.Vertical => new Vector2(resolvedStyle.marginTop, resolvedStyle.marginBottom),
                    Direction.Horizontal => new Vector2(resolvedStyle.marginLeft, resolvedStyle.marginRight),
                };

                PrevMargins[descendant.ID] = targetMargins;
            }
            else if(!PrevMargins.TryGetValue(descendant.ID, out targetMargins))
            {
                return;
            }

            if (Mathf.Approximately(State.halfGap, 0)) return;
            
            if (descendant.element == VisualChild)
            {
                targetMargins.x -= State.halfGap;
                targetMargins.y -= State.halfGap;
            }
            else
            {
                targetMargins.x += State.halfGap;
                targetMargins.y += State.halfGap;
            }
            
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
        }

        protected override Element Render() => Div.Create(
            descriptor: Props.descriptor + new Style
            {
                flexDirection = Props.direction switch
                {
                    Direction.Vertical => FlexDirection.Column,
                    Direction.Horizontal => FlexDirection.Row
                },
            },
            children: Props.children);
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
