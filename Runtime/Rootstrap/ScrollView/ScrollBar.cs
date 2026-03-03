using System;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine.UIElements;

namespace Roots.Experimental.Bootstrap
{
    public partial class SimpleScrollView
    {
        public partial class ScrollBar : RishElement<ScrollBarProps, ScrollBarState>
        {
            private const float DefaultMinimalSize = 3;
            private const float DefaultHoveredSize = 9;

            public ScrollBar()
            {
                RegisterCallback<PointerEnterEvent>(Sappy.OnHoverStart); // TODO: We shouldn't add the manipulator to every element
                RegisterCallback<PointerLeaveEvent>(Sappy.OnHoverEnd); // TODO: We shouldn't add the manipulator to every element

                RegisterCallback<PointerDownEvent>(OnPointerDown);
                RegisterCallback<HideDropdownEvent>(OnHideDropdownEvent, EventPhase.AtTargetOnly);
            }
            
            protected override Element Render()
            {
                var hovered = State.hovered || State.dragging;
                var size = hovered
                    ? Props.hoveredSize ?? DefaultHoveredSize
                    : Props.minimalSize ?? DefaultMinimalSize;
                var borderRadius = size * 0.5f;
                
                return FadeDiv.Create(
                    className: new ClassName
                    {
                        "position-absolute",
                        "pointer-detection",
                        "p-1",
                        Props.direction switch
                        {
                            Direction.Vertical => new ClassName
                            {
                                "top-0",
                                "bottom-0",
                                "right-0",
                            },
                            Direction.Horizontal => new ClassName
                            {
                                "left-0",
                                "right-0",
                                "bottom-0"
                            },
                        }
                    },
                    visible: Props.visible,
                    preset: FadeDiv.Preset.Fast,
                    children: MotionDiv.Create(
                        className: new ClassName
                        {
                            "flex-grow-1",
                            "overflow-hidden"
                        },
                        initial: new Initial
                        {
                            width = false,
                            minWidth = false,
                            maxWidth = false,
                            height = false,
                            minHeight = false,
                            maxHeight = false,
                            borderTopLeftRadius = false,
                            borderTopRightRadius = false,
                            borderBottomLeftRadius = false,
                            borderBottomRightRadius = false,
                        },
                        animate: Props.direction switch
                        {
                            Direction.Vertical => new Target
                            {
                                width = size,
                                minWidth = size,
                                maxWidth = size,
                                borderRadius = borderRadius,
                            },
                            Direction.Horizontal => new Target
                            {
                                height = size,
                                minHeight = size,
                                maxHeight = size,
                                borderRadius = borderRadius,
                            },
                        },
                        children: new Children
                        {
                            FadeDiv.Create(
                                className: new ClassName
                                {
                                    "absolute-fill",
                                    "bg-body-tertiary",
                                },
                                preset: FadeDiv.Preset.Fast,
                                maxOpacity: 0.25f,
                                visible: hovered),
                            Handle.Create(
                                direction: Props.direction,
                                borderRadius: borderRadius * 0.5f,
                                position: Props.position,
                                viewportSize: Props.viewportSize,
                                contentSize: Props.contentSize,
                                onDrag: Sappy.OnDrag)
                        }));
            }

            [SapTarget(typeof(EventCallback<PointerEnterEvent>))]
            private void OnHoverStart(PointerEnterEvent evt) => SetHovered(true);
            [SapTarget(typeof(EventCallback<PointerLeaveEvent>))]
            private void OnHoverEnd(PointerLeaveEvent evt) => SetHovered(false);

            [SapTarget]
            private void OnDrag(float delta, bool dragging)
            {
                SetDragging(dragging);
                RishOnDrag(delta, dragging);
            }

            private void OnPointerDown(PointerDownEvent evt)
            {
                if (evt.button != 0)
                {
                    return;
                }

                var p = Props.direction == Direction.Vertical ? evt.localPosition.y / ContentRect.height : evt.localPosition.x / ContentRect.width;
                var target = (Props.contentSize - Props.viewportSize) * p;

                evt.StopPropagation();

                OnInstant(target - Props.position);
            }

            private void OnHideDropdownEvent(HideDropdownEvent evt) => evt.StopPropagation();
        }

        [RishValueType]
        public struct ScrollBarProps
        {
            public Direction direction;
            public float? minimalSize;
            public float? hoveredSize;
            public bool visible;
            public float position;
            public float viewportSize;
            public float contentSize;

            public Action<float> onInstant;
            public Action<float, bool> onDrag;
        }

        [RishValueType]
        public struct ScrollBarState
        {
            public bool hovered;
            public bool dragging;
        }
    }
}