using System;
using Motion;
using RishUI;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots.Experimental.Bootstrap
{
    public partial class SimpleScrollView : RishElement<SimpleScrollViewProps, SimpleScrollViewState>, IMountingListener
    {
        public enum Direction { Vertical, Horizontal }

        public const float DefaultMouseWheelDeltaMultiplier = 30;

        private SpringAnimationId<float> Animation { get; set; }

        public SimpleScrollView()
        {
            RegisterCallback<WheelEvent>(OnWheel);
            RegisterCallback<PointerEnterEvent>(Sappy.OnHoverStart); // TODO: We shouldn't add the manipulator to every element
            RegisterCallback<PointerLeaveEvent>(Sappy.OnHoverEnd); // TODO: We shouldn't add the manipulator to every element
        }
        
        void IMountingListener.ElementDidMount() { }
        void IMountingListener.ElementWillUnmount()
        {
            Animation.Stop();
        }

        protected override Element Render() => Div.Create(
            descriptor: Props.descriptor,
            children: new Children
            {
                ScrollView.Create(
                    style: StyleUtilities
                        .AbsoluteFill()
                        .PointerDetection()
                        .OverflowHidden(),
                    direction: Props.direction switch {
                        Direction.Vertical => ScrollView.Direction.Vertical,
                        Direction.Horizontal => ScrollView.Direction.Horizontal,
                    },
                    inverted: Props.inverted,
                    gap: Props.gap,
                    bufferSize: State.bufferSize,
                    elementsSize: Props.elementsSize,
                    position: GetPosition(),
                    alwaysMountedIndices: Props.alwaysMountedIndices,
                    children: Props.children,
                    onContentSize: Sappy.SetContentSize,
                    onViewportSize: Sappy.SetViewportSize,
                    onElementSize: SappyState.SetElementSize),
                State.contentSize > State.viewportSize
                    ? ScrollBar.Create(
                        direction: Props.direction,
                        visible: State.hovered || State.dragging,
                        position: State.position,
                        viewportSize: State.viewportSize,
                        contentSize:  State.contentSize,
                        onInstant: Sappy.OnInstant,
                        onDrag: Sappy.OnDrag)
                    : Element.Null
            });

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

            var delta = wheelDelta * (Props.mouseWheelMultiplier ?? DefaultMouseWheelDeltaMultiplier);
            
            if (Props.inverted)
            {
                delta = -delta;
            }

            if (Mathf.Approximately(delta, 0)) return;
            
            UpdatePosition(delta, true, true);
        }

        [SapTarget]
        private void OnInstant(float delta)
        {
            SetDragging(false);
            UpdatePosition(delta, false, true);
        }

        [SapTarget]
        private void OnDrag(float delta, bool dragging)
        {
            SetDragging(dragging);
            UpdatePosition(delta, false, false);
        }

        private void UpdatePosition(float delta, bool incremental, bool animate)
        {
            var currentPosition = GetPosition();
            var currentTargetPosition = GetTargetPosition();
            
            float startingPoint;
            if (animate && incremental && Animation.GetVelocity(out var initialVelocity) && (int)Mathf.Sign(delta) == (int)Mathf.Sign(currentTargetPosition - currentPosition))
            {
                startingPoint = currentTargetPosition;
            }
            else
            {
                startingPoint = currentPosition;
                initialVelocity = 0;
            }

            var target = Mathf.Clamp(startingPoint + delta, 0, State.contentSize - State.viewportSize);

            if (animate && incremental && Mathf.Approximately(target, currentTargetPosition)) return;

            SetTargetPosition(target);

            Animation.Stop();
            if (animate)
            {
                Animation = DoMotion.Spring(Sappy.GetPosition, Sappy.SetPosition, target).SetInitialVelocity(initialVelocity);
            }
            else
            {
                SetPosition(target);
            }
        }

        [SapTarget]
        private void SetPosition(float value)
        {
            const float maxBufferSize = 2f;
            var bufferSize = Mathf.Approximately(State.targetPosition, State.position) ? ScrollView.DefaultBufferSize : Mathf.Clamp(Mathf.Abs(State.targetPosition - State.position) / State.viewportSize, ScrollView.DefaultBufferSize, maxBufferSize);
            
            RishSetPosition(value);
            SetBufferSize(bufferSize);
        }
        
        [SapTarget]
        private float GetPosition() => State.contentSize > State.viewportSize ? Mathf.Clamp(State.position, 0, State.viewportSize > State.contentSize ? State.viewportSize - State.contentSize : State.contentSize - State.viewportSize) : 0;
        
        private float GetTargetPosition() => State.contentSize > State.viewportSize ? Mathf.Clamp(State.targetPosition, 0, State.viewportSize > State.contentSize ? State.viewportSize - State.contentSize : State.contentSize - State.viewportSize) : 0;
        // private float GetPosition() => State.contentSize > State.viewportSize ? State.position : 0;

        [SapTarget]
        private void SetViewportSize(float value)
        {
            RishSetViewportSize(value);
            // var target = Mathf.Clamp(State.position, 0, value > State.contentSize ? value - State.contentSize : State.contentSize - value);
            // if (Mathf.Abs(target - State.position) < 1) return;
            // Animation.Stop();
            // SetTargetPosition(value);
            // SetPosition(target);
            
            // Debug.LogError("STOP 1");
        }

        [SapTarget]
        private void SetContentSize(float value)
        {
            RishSetContentSize(value);
            // var target = Mathf.Clamp(State.position, 0, State.viewportSize > value ? State.viewportSize - value : value - State.viewportSize);
            // if (Mathf.Abs(target - State.position) < 1) return;
            // if (Animation.IsPlaying(out var playing) && playing)
            // {
            //     Animation.SetTarget(target);
            // }
            // else
            // {
            //     SetTargetPosition(value);
            //     SetPosition(target);
            // }
            //
            // Debug.LogError("STOP 2");
        }
    }

    [RishValueType]
    public struct SimpleScrollViewProps
    {
        [Expand]
        public VisualAttributes descriptor;

		public SimpleScrollView.Direction direction;
        
        public bool inverted;
        public int gap;
        
        public float? mouseWheelMultiplier;
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
        public float targetPosition;
        public float bufferSize;
        public float viewportSize;
        public float contentSize;
        public float elementSize;
    }
}
