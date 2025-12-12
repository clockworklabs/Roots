using System;
using Motion;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots.Bootstrap
{
    public partial class SimpleScrollView : RishElement<SimpleScrollViewProps, SimpleScrollViewState>, IMountingListener
    {
        public enum Direction { Vertical, Horizontal }

        public const float ScrollMultiplier = 75;
        public const float HackThreshold = 0.5f;
        public const float HackValue = 60;

        private SpringAnimationId<float> ScrollAnimation { get; set; }

        public SimpleScrollView()
        {
            RegisterCallback<WheelEvent>(OnWheel);
            RegisterCallback<PointerEnterEvent>(SappyOnHoverStart); // TODO: We shouldn't add the manipulator to every element
            RegisterCallback<PointerLeaveEvent>(SappyOnHoverEnd); // TODO: We shouldn't add the manipulator to every element
        }
        
        void IMountingListener.ComponentDidMount() { }

        void IMountingListener.ComponentWillUnmount()
        {
            ScrollAnimation.Stop();
        }

        protected override Element Render()
        {
            return Div.Create(
                descriptor: Props.descriptor,
                children: new Children
                {
                    ScrollView.Create(
                        className: new ClassName
                        {
                            "absolute-fill",
                            "pointer-detection",
                            "overflow-hidden"
                        },
                        direction: Props.direction switch {
                            Direction.Vertical => ScrollView.Direction.Vertical,
                            Direction.Horizontal => ScrollView.Direction.Horizontal,
                        },
                        inverted: Props.inverted,
                        gap: Props.gap,
                        elementsSize: Props.elementsSize,
                        position: State.position,
                        onPosition: SappyState.SetPosition,
                        alwaysMountedIndices: Props.alwaysMountedIndices,
                        children: Props.children,
                        onContentSize: SappyState.SetContentSize,
                        onViewportSize: SappyState.SetViewportSize),
                    State.contentSize > State.viewportSize
                        ? ScrollBar.Create(
                            direction: Props.direction,
                            visible: State.hovered || State.dragging,
                            position: State.position,
                            viewportSize: State.viewportSize,
                            contentSize:  State.contentSize,
                            onDrag: SappyOnDrag)
                        : Element.Null
                });
        }

        [SapTarget(typeof(EventCallback<PointerEnterEvent>))]
        private void OnHoverStart(PointerEnterEvent evt) => SetHovered(true);
        [SapTarget(typeof(EventCallback<PointerLeaveEvent>))]
        private void OnHoverEnd(PointerLeaveEvent evt) => SetHovered(false);
        
        private void OnWheel(WheelEvent evt)
        {
            if (State.contentSize < State.viewportSize) return;
            
            float wheelDelta;
            if (Props.direction == Direction.Vertical)
            {
                wheelDelta = evt.delta.y;
            }
            else
            {
                var shiftPressed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
                wheelDelta = shiftPressed || Mathf.Abs(evt.delta.y) > Mathf.Abs(evt.delta.x)
                    ? evt.delta.y
                    : evt.delta.x;
            }
            
            if (Mathf.Approximately(wheelDelta, 0))
            {
                return;
            }

            // This is a TERRIBLE workaround for an issue we can't figure out. For some reason in the Playground scene
            // the value reported by WheelEvent.delta.x/y is 3/-3 while in the Main game scene it's 0.05/-0.05.
            if (Mathf.Abs(wheelDelta) < HackThreshold)
            {
                wheelDelta *= HackValue;
            }

            // Pref value is between 0 and 1
            var sensitivity = Props.mouseWheelSensitivity;
            var multiplier = sensitivity switch
            {
                <= 0.5f => Mathf.Lerp(0.1f, 1f, sensitivity * 2),
                > 0.5f => Mathf.Lerp(1f, 10f, (sensitivity - 0.5f) * 2),
                _ => 1f
            };

            var delta = wheelDelta * ScrollMultiplier * multiplier;
            
            if (Props.inverted)
            {
                delta = -delta;
            }

            var target = Mathf.Clamp(State.position + delta, 0, State.contentSize - State.viewportSize);

            ScrollAnimation.Stop();
            ScrollAnimation = DoMotion.Spring(SappyGetPosition, SappyState.SetPosition, target);
        }

        [SapTarget]
        private void OnDrag(float delta, bool dragging)
        {
            SetPosition(State.position + delta);
            SetDragging(dragging);
        }
        
        [SapTarget(typeof(Func<float>))]
        private float GetPosition() => State.position;
    }

    [RishValueType]
    public struct SimpleScrollViewProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;

		public SimpleScrollView.Direction direction;
        
        public bool inverted;
        public int gap;
        
        public float mouseWheelSensitivity;
        public float? elementsSize;
        
        public RishList<int> alwaysMountedIndices;
        public Children children;
    }

    [RishValueType]
    public struct SimpleScrollViewState
    {
        public bool hovered;
        public bool dragging;
        public float position;
        public float viewportSize;
        public float contentSize;
    }
}
