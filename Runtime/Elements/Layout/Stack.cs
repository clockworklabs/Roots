using System;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;

namespace Roots
{
    public partial class Stack : RishElement<StackProps, StackState>, IManualState, IPropsListener<StackProps>, IVisualManipulator
    {
        public enum Direction { Vertical, Horizontal }

        private Dictionary<int, Vector2> PrevMargins { get; } = new();

        private VisualElement _visualChild;
        private VisualElement VisualChild => _visualChild ??= GetVisualChild();
        
        private HashSet<int> Indices { get; } = new();

        void IManualState.Restart()
        {
            _visualChild = null;
            PrevMargins.Clear();
            Indices.Clear();
        }

        void IPropsListener<StackProps>.PropsDidChange(StackProps? prev)
        {
            SetHasSeparator(Props.separator.Valid);
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
                var shouldSkip = style.display == DisplayStyle.None;

                if (State.hasSeparator)
                {
                    var userData = descendant.element.userData;
                    if (userData is Holder holder)
                    {
                        var index = holder.Props.index;
                        if (shouldSkip || style.position == Position.Absolute)
                        {
                            if (Indices.Remove(index))
                            {
                                Dirty();
                            }
                        }
                        else
                        {
                            if (Indices.Add(index))
                            {
                                Dirty();
                            }
                        }
                    } else
                    {
                        shouldSkip = true;
                    }
                }

                if (shouldSkip)
                {
                    PrevMargins.Remove(descendant.ID);
                    return;
                }
                
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

        protected override Element Render()
        {
            Children children;
            if (State.hasSeparator)
            {
                children = new Children();
                var lastIndex = -1;
                for(int i = 0, n = Props.children.Count; i < n; i++)
                {
                    if (Indices.Contains(i))
                    {
                        if (lastIndex >= 0)
                        {
                            children.Add(Props.separator);
                        }
                        lastIndex = i;
                    }
                    children.Add(Holder.Create(key: (ulong)i, index: i, content: Props.children[i]));
                }
            }
            else
            {
                children = Props.children;
            }
            
            return Div.Create(
                descriptor: Props.descriptor + new Style
                {
                    flexDirection = Props.direction switch
                    {
                        Direction.Vertical => Props.reverse ? FlexDirection.ColumnReverse : FlexDirection.Column,
                        Direction.Horizontal => Props.reverse ? FlexDirection.RowReverse : FlexDirection.Row
                    },
                },
                children: children);
        }
    }

    [RishValueType]
    public struct StackProps
    {
        public Stack.Direction direction;
        public bool reverse;
        public float gap;
        public DOMDescriptor descriptor;
        public Children children;
        public Element separator;
    }

    [RishValueType]
    public struct StackState
    {
        public bool hasSeparator;
        public float halfGap;
    }
}
