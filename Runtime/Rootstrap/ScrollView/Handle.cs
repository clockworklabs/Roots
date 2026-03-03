using System;
using RishUI;
using RishUI.Events;
using RishUI.MemoryManagement;
using Sappy;
using UnityEngine.UIElements;

namespace Roots.Experimental.Bootstrap
{
    public partial class SimpleScrollView
    {
        public partial class Handle : RishElement<HandleProps, HandleState>
        {
            private enum VisualStyle { Normal, Hovered, Pressed }
            public Handle()
            {
                AddManipulator(new DragManipulator());
                RegisterCallback<DragStartEvent>(Sappy.OnDragStart);
                RegisterCallback<DragEndEvent>(Sappy.OnDragEnd);
                RegisterCallback<DragEvent>(Sappy.OnDrag);
                RegisterCallback<PointerDownEvent>(OnPointerDown);
            }

            protected override Element Render() => Stateful.Create(
                normal: Content(State.dragging ? VisualStyle.Pressed : VisualStyle.Normal),
                hovered: Content(State.dragging ? VisualStyle.Pressed : VisualStyle.Hovered),
                pressed: Content(VisualStyle.Pressed));

            [RequiresManagedContext]
            private Element Content(VisualStyle style)
            {
                var size = Length.Percent(Props.viewportSize / Props.contentSize * 100);
                var position = Length.Percent(Props.position / Props.contentSize * 100);
                Length width, height, top, left;
                switch (Props.direction)
                {
                    case Direction.Vertical:
                        width = Length.Percent(100);
                        height = size;
                        top = position;
                        left = 0;
                        break;
                    case Direction.Horizontal:
                        width = size;
                        height = Length.Percent(100);
                        top = 0;
                        left = position;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return Div.Create(
                    className: new ClassName
                    {
                        // "m-n1",
                        // "p-1",
                        "position-absolute",
                        "overflow-hidden"
                    },
                    // initial: new Initial
                    // {
                    //     width = false,
                    //     minWidth = false,
                    //     maxWidth = false,
                    //     height = false,
                    //     minHeight = false,
                    //     maxHeight = false,
                    //     opacity = false,
                    //     borderTopLeftRadius = false,
                    //     borderTopRightRadius = false,
                    //     borderBottomLeftRadius = false,
                    //     borderBottomRightRadius = false,
                    //     top = false,
                    //     left = false,
                    // },
                    style: new Style
                    {
                        width = width,
                        minWidth = width,
                        maxWidth = width,
                        height = height,
                        minHeight = height,
                        maxHeight = height,
                        opacity = style switch
                        {
                            VisualStyle.Normal => 0.4f,
                            VisualStyle.Hovered => 0.7f,
                            VisualStyle.Pressed => 1
                        },
                        borderRadius = Props.borderRadius,
                        top = top,
                        left = left,
                    },
                    children: Div.Create(
                        className: new ClassName
                        {
                            "absolute-fill",
                            "bg-body-secondary"
                        }));
            }

            [SapTarget(typeof(EventCallback<DragStartEvent>))]
            public void OnDragStart(DragStartEvent evt)
            {
                SetDragging(true);
                CapturePointer(evt.pointerId);
            }
            [SapTarget (typeof(EventCallback<DragEndEvent>))]
            public void OnDragEnd(DragEndEvent evt)
            {
                SetDragging(false);
                ReleasePointer(evt.pointerId);
                OnDrag(0, false);
            }

            [SapTarget(typeof(EventCallback<DragEvent>))]
            public void OnDrag(DragEvent evt)
            {
                var contentRect = (evt.target as VisualElement).parent.contentRect;
                OnDrag(Props.direction switch
                {
                    Direction.Vertical => evt.deltaPosition.y / contentRect.height * Props.contentSize,
                    Direction.Horizontal => evt.deltaPosition.x / contentRect.width * Props.contentSize,
                }, true);
            }
            
            private void OnPointerDown(PointerDownEvent evt)
            {
                evt.StopPropagation();
            }
        }

        [RishValueType]
        public struct HandleProps
        {
            public Direction direction;
            public float borderRadius;
            public float position;
            public float viewportSize;
            public float contentSize;

            public Action<float, bool> onDrag;
        }

        [RishValueType]
        public struct HandleState
        {
            public bool dragging;
        }
    }
}