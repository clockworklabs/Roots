using System;
using RishUI;
using RishUI.Events;
using UnityEngine.UIElements;
using StyleLength = RishUI.StyleLength;

namespace Roots.Experimental
{
    public partial class ScrollView
    {
        public partial class Holder : RishElement<HolderProps, HolderState>, IMountingListener
        {
            private ScrollView ScrollView { get; set; }

            public Holder()
            {
                RegisterCallback<VisualChangeEvent>(OnVisualChange, EventPhase.AtTargetOnly);
            }

            void IMountingListener.ComponentDidMount()
            {
                ScrollView = GetFirstAncestorOfType<ScrollView>();
            }

            void IMountingListener.ComponentWillUnmount() { }

            protected override Element Render()
            {
                Style directionalStyle;
                switch (Props.direction)
                {
                    case Direction.Vertical:
                        directionalStyle = new Style
                        {
                            width = Length.Percent(100),
                            alignItems = Align.Stretch,
                            flexDirection = FlexDirection.Column,
                            top = Props.inverted ? default(StyleLength) : Props.position,
                            bottom = Props.inverted ? Props.position : default(StyleLength),
                            height = Props.fixedSize ?? default(StyleLength)
                        };
                        break;
                    case Direction.Horizontal:
                        directionalStyle = new Style
                        {
                            height = Length.Percent(100),
                            alignItems = Align.Center,
                            flexDirection = FlexDirection.Row,
                            left = Props.inverted ? default(StyleLength) : Props.position,
                            right = Props.inverted ? Props.position : default(StyleLength),
                            width = Props.fixedSize ?? default(StyleLength)
                        };
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return Div.Create(
                    style: new Style
                    {
                        position = Position.Absolute,
                        visibility = State.visible ? Visibility.Visible : Visibility.Hidden
                    } + directionalStyle,
                    children: Props.content);
            }

            private void OnVisualChange(VisualChangeEvent evt)
            {
                if (ScrollView == null)
                {
                    return;
                }

                SetVisible(true);

                var isVertical = Props.direction == Direction.Vertical;

                ScrollView.SetSize(Props.index, isVertical ? ContentRect.height : ContentRect.width);
            }
        }

        [RishValueType]
        public struct HolderProps
        {
            public int index;

            public Direction direction;
            public bool inverted;
            public float position;
            public Element content;

            public float? fixedSize;
        }

        [RishValueType]
        public struct HolderState
        {
            public bool visible;
        }
    }
}