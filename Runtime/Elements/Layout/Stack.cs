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

        bool IVisualManipulator.Evaluate(VisualElement descendant)
        {
            return descendant?.parent == VisualChild;
            // if (descendant?.parent == VisualChild)
            // {
            //     if (VisualChild.name == "test")
            //     {
            //         Debug.Log($"Evaluate {descendant.GetID()}");
            //     }
            //     return VisualManipulationEvaluation.ScheduledBubbleUp | VisualManipulationEvaluation.TrickleDown;
            // }
            //
            // return VisualManipulationEvaluation.NotInterested;
        }
        
        void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
            var resolvedStyle = descendant.resolvedStyle;
            
            if (resolvedStyle.display == DisplayStyle.None || resolvedStyle.position == Position.Absolute) return;
            
            Vector2 prevMargins;
            if (phase == VisualManipulationPhase.BubbleUp)
            {
                prevMargins = Props.direction switch
                {
                    Direction.Vertical => new Vector2(resolvedStyle.marginTop, resolvedStyle.marginBottom),
                    Direction.Horizontal => new Vector2(resolvedStyle.marginLeft, resolvedStyle.marginRight),
                };

                PrevMargins[descendant.ID] = prevMargins;
            }
            else if(!PrevMargins.TryGetValue(descendant.ID, out prevMargins))
            {
                return;
            }
            
            var targetMargins = prevMargins + new Vector2
            {
                x = State.halfGap,
                y = State.halfGap
            };
            
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
