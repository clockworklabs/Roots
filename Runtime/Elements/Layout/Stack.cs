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
            SetHalfGap(Props.gap * 0.5f);
        }
        void IPropsListener<StackProps>.PropsWillChange() { }

        bool IVisualManipulator.Evaluate(VisualElement descendant) => descendant == VisualChild || descendant.parent == VisualChild;
        
        void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
            var style = descendant.style;
            
            Vector2 targetMargins;
            if (phase == VisualManipulationPhase.BubbleUp)
            {
                targetMargins = Props.direction switch
                {
                    Direction.Vertical => new Vector2(style.resolvedMarginTop, style.resolvedMarginBottom),
                    Direction.Horizontal => new Vector2(style.resolvedMarginLeft, style.resolvedMarginRight),
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
            
            switch (Props.direction)
            {
                case Direction.Vertical:
                    style.resolvedMarginTop = targetMargins.x;
                    style.resolvedMarginBottom = targetMargins.y;
                    break;
                case Direction.Horizontal:
                    style.resolvedMarginLeft = targetMargins.x;
                    style.resolvedMarginRight = targetMargins.y;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Props.direction), Props.direction, null);
            }
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
