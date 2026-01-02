using RishUI;
using RishUI.Events;
using UnityEngine.UIElements;
using StyleLength = RishUI.StyleLength;

namespace Roots
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
                var isVertical = Props.direction == Direction.Vertical;

                return Div.Create(
                    className: new ClassName
                    {
                        "position-absolute",
                        isVertical
                            ? new ClassName
                            {
                                "w-100",
                                "align-items-stretch",
                                "flex-column"
                            }
                            : new ClassName
                            {
                                "h-100",
                                "align-items-center",
                                "flex-row"
                            }
                    },
                    style: new Style
                    {
                        visibility = State.visible ? Visibility.Visible : Visibility.Hidden
                    } + (isVertical
                        ? new Style
                        {
                            top = Props.inverted ? default(StyleLength) : Props.position,
                            bottom = Props.inverted ? Props.position : default(StyleLength),
                            height = Props.fixedSize ?? default(StyleLength)
                        }
                        : new Style
                        {
                            left = Props.inverted ? default(StyleLength) : Props.position,
                            right = Props.inverted ? Props.position : default(StyleLength),
                            width = Props.fixedSize ?? default(StyleLength)
                        }),
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