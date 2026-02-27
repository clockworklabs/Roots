using System;
using Motion;
using RishUI;
using RishUI.Events;
using Roots.Utils;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class DragArea : RishElement<DragAreaProps, DragAreaState>, IMountingListener, IPropsListener<DragAreaProps>
    {
        private const float DefaultMouseWheelDeltaMultiplier = 100;
        
        public enum VisualBehavior { Default, Stretchy, Clamped }

        [Flags]
        public enum AxisOfFreedom
        {
            None = 0,
            Vertical = 1,
            Horizontal = 2,
            VerticalAndHorizontal = Vertical | Horizontal
        }

        private const int FramesCacheSize = 5;

        // private static readonly Spring BouncySpring = new() { inverseMass = 5, damping = 5, stiffness = 200, sqrRestDelta = 1, sqrRestSpeed = 1 };
        private static readonly Spring FastSpring = new(Spring.Fast) { sqrRestDelta = 1, sqrRestSpeed = 1 };
        private static readonly Inertia Inertia = new(Inertia.Default) { power = 0.65f, restDelta = 1, restSpeed = 1, bounceDamping = FastSpring.damping, bounceStiffness = FastSpring.stiffness, bounceInverseMass = FastSpring.inverseMass };

        private DragFrame[] Frames { get; } = new DragFrame[FramesCacheSize];
        private int PrevFrameIndex { get; set; } = -1;
        private int FrameIndex { get; set; }

        private AnimationId HorizontalAnimation { get; set; }
        private AnimationId VerticalAnimation { get; set; }

        private Vector2? ContentSize { get; set; }
        private Vector2? Limits { get; set; }

        private Vector2? NextContentSize { get; set; }
        private Vector2? NextLimits { get; set; }

        private int _pointerId = -1;
        private int PointerId
        {
            get => _pointerId;
            set
            {
                if (_pointerId == value) return;

                if (_pointerId >= 0)
                {
                    ReleasePointer(_pointerId);
                }
                _pointerId = value;
                if (value >= 0)
                {
                    CapturePointer(value);
                }
            }
        }
        private bool Dragging => PointerId >= 0;

        public DragArea()
        {
            AddManipulator(new DragManipulator());
            RegisterCallback<PointerDownEvent>(OnPointerDown);
            RegisterCallback<DragStartEvent>(OnDragStart);
            RegisterCallback<DragEvent>(OnDrag);
            RegisterCallback<DragEndEvent>(OnDragEnd);
            RegisterCallback<WheelEvent>(OnWheel);
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
            RegisterCallback<GeometryChangedEvent>(OnGeometryChange);
        }

        void IMountingListener.ElementDidMount()
        {
            RishSetOffset(Vector2.zero);
        }
        void IMountingListener.ElementWillUnmount()
        {
            HorizontalAnimation.Stop();
            VerticalAnimation.Stop();

            ContentSize = null;
            Limits = null;
            NextContentSize = null;
            NextLimits = null;
            PointerId = -1;
        }

        void IPropsListener<DragAreaProps>.PropsDidChange(DragAreaProps? prev)
        {
            if (prev.HasValue && RishUtils.MemCmp(prev.Value.offset, Props.offset)) return;

            if (Props.offset.HasValue)
            {
                SetOffset(Props.offset.Value);
            }
        }
        void IPropsListener<DragAreaProps>.PropsWillChange() { }

        protected override Element Render()
        {
            var offset = State.offset;
            var scale = Vector2.one;
            if (Props.behavior != VisualBehavior.Default && ContentSize.HasValue && Limits.HasValue)
            {
                var min = GetMinLimit();
                var max = GetMaxLimit();

                if (Props.behavior == VisualBehavior.Stretchy)
                {
                    var contentSize = ContentSize.Value;
                    var contentRectSize = ContentRect.size;

                    offset = State.offset;
                    scale = Vector2.one;

                    if (contentSize.x < contentRectSize.x)
                    {
                        if (State.offset.x < min.x)
                        {
                            var d = min.x - State.offset.x;
                            offset.x = min.x;
                            scale.x = 1 - d / contentSize.x;
                        }
                        else if (State.offset.x > max.x)
                        {
                            var d = State.offset.x - max.x;
                            var t = d / contentSize.x;
                            scale.x = 1 - t;
                        }
                    }
                    else
                    {
                        if (State.offset.x < min.x)
                        {
                            var d = min.x - State.offset.x;
                            scale.x = 1 + d / contentSize.x;
                        }
                        else if (State.offset.x > max.x)
                        {
                            var d = State.offset.x - max.x;
                            offset.x = max.x;
                            scale.x = 1 + d / contentSize.x;
                        }
                    }

                    if (contentSize.y < contentRectSize.y)
                    {
                        if (State.offset.y < min.y)
                        {
                            var d = min.y - State.offset.y;
                            offset.y = min.y;
                            scale.y = 1 - d / contentSize.y;
                        }
                        else if (State.offset.y > max.y)
                        {
                            var d = State.offset.y - max.y;
                            scale.y = 1 - d / contentSize.y;
                        }
                    }
                    else
                    {
                        if (State.offset.y < min.y)
                        {
                            var d = min.y - State.offset.y;
                            scale.y = 1 + d / contentSize.y;
                        }
                        else if (State.offset.y > max.y)
                        {
                            var d = State.offset.y - max.y;
                            offset.y = max.y;
                            scale.y = 1 + d / contentSize.y;
                        }
                    }
                }
                else
                {
                    offset.x = Mathf.Clamp(State.offset.x, min.x, max.x);
                    offset.y = Mathf.Clamp(State.offset.y, min.y, max.y);
                }
            }

            return Div.Create(
                descriptor: Props.descriptor + StyleUtilities.PointerDetection(), 
                children: Holder.Create(
                    descriptor: Props.holderDescriptor,
                    offset: offset,
                    scale: scale,
                    content: Props.content));
        }

        private Vector2 GetMinLimit()
        {
            if (!Limits.HasValue) return Vector2.zero;
            var limits = Limits.Value;
            return new Vector2(Mathf.Min(limits.x, 0), Mathf.Min(limits.y, 0));
        }
        private Vector2 GetMaxLimit()
        {
            if (!Limits.HasValue) return Vector2.positiveInfinity;
            var limits = Limits.Value;
            return new Vector2(Mathf.Max(limits.x, 0), Mathf.Max(limits.y, 0));
        }

        private void OnPointerDown(PointerDownEvent evt)
        {
            HorizontalAnimation.Stop();
            VerticalAnimation.Stop();
        }
        private void OnDragStart(DragStartEvent evt)
        {
            if (Dragging) return;

            PointerId = evt.pointerId;

            RestartRecording();
        }
        private void OnDrag(DragEvent evt)
        {
            if (evt.pointerId != PointerId) return;

            var deltaPosition = ClampDeltaPosition(evt.deltaPosition.sXY());

            SetOffset(State.offset + deltaPosition, true);
        }
        private void OnDragEnd(DragEndEvent evt)
        {
            if (evt.pointerId != PointerId) return;

            SetOffset(State.offset, true);

            PointerId = -1;

            ContentSize = NextContentSize ?? ContentSize;
            NextContentSize = null;
            Limits = NextLimits ?? Limits;
            NextLimits = null;

            AnimateRelease();

            RestartRecording();
        }

        private void OnWheel(WheelEvent evt)
        {
            var wheelDelta = evt.delta.sXY();
            var shiftPressed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
            if (shiftPressed)
            {
                (wheelDelta.x, wheelDelta.y) = (wheelDelta.y, wheelDelta.x);
            }

            if (Mathf.Approximately(wheelDelta.x, 0) && Mathf.Approximately(wheelDelta.y, 0)) return;

            var multiplier = Props.mouseWheelMultiplier ?? DefaultMouseWheelDeltaMultiplier;
            
            var delta = ClampDeltaPosition(-wheelDelta * multiplier);

            if (!SpringAnimationId<float>.From(HorizontalAnimation, out var horizontalSpringAnimation) || !horizontalSpringAnimation.GetVelocity(out var horizontalVelocity))
            {
                if (!InertiaAnimationId.From(HorizontalAnimation, out var horizontalInertiaAnimation) || !horizontalInertiaAnimation.GetVelocity(out horizontalVelocity))
                {
                    horizontalVelocity = 0;
                }
            }
            if (!SpringAnimationId<float>.From(VerticalAnimation, out var verticalSpringAnimation) || !verticalSpringAnimation.GetVelocity(out var verticalVelocity))
            {
                if (!InertiaAnimationId.From(VerticalAnimation, out var verticalInertiaAnimation) || !verticalInertiaAnimation.GetVelocity(out verticalVelocity))
                {
                    verticalVelocity = 0;
                }
            }

            var target = State.offset + delta;

            if (!Mathf.Approximately(delta.x, 0))
            {
                HorizontalAnimation.Stop();
                HorizontalAnimation = DoMotion.Spring(SappyGetOffsetX, SappySetOffsetX, target.x, FastSpring)
                    .SetInitialVelocity(horizontalVelocity)
                    .OnComplete(SappyAnimateReleaseHorizontalSimple);
            }
            if (!Mathf.Approximately(delta.y, 0))
            {
                VerticalAnimation.Stop();
                VerticalAnimation = DoMotion.Spring(SappyGetOffsetY, SappySetOffsetY, target.y, FastSpring)
                    .SetInitialVelocity(verticalVelocity)
                    .OnComplete(SappyAnimateReleaseVerticalSimple);
            }
        }

        private void AnimateRelease()
        {
            var limits = Limits ?? Vector2.positiveInfinity;
            var velocity = GetVelocity();
            AnimateReleaseHorizontal(limits.x, velocity.x);
            AnimateReleaseVertical(limits.y, velocity.y);
        }
        private void AnimateReleaseHorizontal(float limit, float dragVelocity)
        {
            if (!Props.axisOfFreedom.HasFlag(AxisOfFreedom.Horizontal)) return;
            float min, max;
            if (limit > 0)
            {
                min = 0;
                max = limit;
            }
            else
            {
                min = limit;
                max = 0;
            }
            HorizontalAnimation.Stop();
            if (Mathf.Approximately(dragVelocity, 0))
            {
                var offset = State.offset.x;
                var target = offset < min ? min : offset > max ? max : offset;
                HorizontalAnimation = DoMotion.Spring(SappyGetOffsetX, SappySetOffsetX, target, FastSpring);
            }
            else
            {
                HorizontalAnimation = DoMotion.Inertia(SappyGetOffsetX, SappySetOffsetX, dragVelocity, Inertia, min, max);
            }
        }
        private void AnimateReleaseVertical(float limit, float dragVelocity)
        {
            if (!Props.axisOfFreedom.HasFlag(AxisOfFreedom.Vertical)) return;
            float min, max;
            if (limit > 0)
            {
                min = 0;
                max = limit;
            }
            else
            {
                min = limit;
                max = 0;
            }
            VerticalAnimation.Stop();
            if (Mathf.Approximately(dragVelocity, 0))
            {
                var offset = State.offset.y;
                var target = offset < min ? min : offset > max ? max : offset;
                VerticalAnimation = DoMotion.Spring(SappyGetOffsetY, SappySetOffsetY, target, FastSpring);
            }
            else
            {
                VerticalAnimation = DoMotion.Inertia(SappyGetOffsetY, SappySetOffsetY, dragVelocity, Inertia, min, max);
            }
        }
        [SapTarget]
        private void AnimateReleaseHorizontalSimple()
        {
            var limits = Limits ?? Vector2.positiveInfinity;
            AnimateReleaseHorizontal(limits.x, 0);
        }
        [SapTarget]
        private void AnimateReleaseVerticalSimple()
        {
            var limits = Limits ?? Vector2.positiveInfinity;
            AnimateReleaseVertical(limits.y, 0);
        }

        private Vector2 ClampDeltaPosition(Vector2 unclamped)
        {
            if (!ContentSize.HasValue) return unclamped;

            var limits = Limits ?? Vector2.positiveInfinity;
            var contentRectSize = ContentRect.size;
            var contentSize = ContentSize.Value;
            var extraMarginLength = Props.extraMargin ?? Length.Percent(5);
            float extraMargin;
            if (extraMarginLength.unit == LengthUnit.Percent)
            {
                var minSize = Mathf.Min(contentRectSize.x, contentSize.x, contentRectSize.y, contentSize.y);
                extraMargin = minSize * (extraMarginLength.value * 0.01f);
            }
            else
            {
                extraMargin = extraMarginLength.value;
            }
            var invExtraMargin = 1 / extraMargin;
            float tX, tY;

            if (!Props.axisOfFreedom.HasFlag(AxisOfFreedom.Horizontal))
            {
                tX = 1;
            }
            else if (unclamped.x > 0)
            {
                var limit = limits.x > 0 ? limits.x : 0;
                tX = State.offset.x > limit ? Mathf.Clamp01(Mathf.Abs(State.offset.x - limit) * invExtraMargin) : 0;
            }
            else
            {
                var limit = limits.x > 0 ? 0 : limits.x;
                tX = State.offset.x < limit ? Mathf.Clamp01(Mathf.Abs(State.offset.x - limit) * invExtraMargin) : 0;
            }
            if (!Props.axisOfFreedom.HasFlag(AxisOfFreedom.Vertical))
            {
                tY = 1;
            }
            else if (unclamped.y > 0)
            {
                var limit = limits.y > 0 ? limits.y : 0;
                tY = State.offset.y > limit ? Mathf.Clamp01(Mathf.Abs(State.offset.y - limit) * invExtraMargin) : 0;
            }
            else
            {
                var limit = limits.y > 0 ? 0 : limits.y;
                tY = State.offset.y < limit ? Mathf.Clamp01(Mathf.Abs(State.offset.y - limit) * invExtraMargin) : 0;
            }

            const float halfPi = Mathf.PI * 0.5f;

            var multiplier = new Vector2(Mathf.Cos(tX * halfPi), Mathf.Cos(tY * halfPi));

            var result = unclamped * multiplier;

            var min = new Vector2(Mathf.Min(limits.x, 0) - extraMargin, Mathf.Min(limits.y, 0) - extraMargin);
            var max = new Vector2(Mathf.Max(limits.x, 0) + extraMargin, Mathf.Max(limits.y, 0) + extraMargin);
            var toMin = min - State.offset;
            var toMax = max - State.offset;
            result.x = Mathf.Clamp(result.x, toMin.x, toMax.x);
            result.y = Mathf.Clamp(result.y, toMin.y, toMax.y);

            return result;
        }

        private void OnVisualChange(VisualChangeEvent evt)
        {
            if (Limits.HasValue) return;

            ComputeLimits();
        }
        private void OnGeometryChange(GeometryChangedEvent evt)
        {
            if (!Limits.HasValue) return;

            if (!Dragging)
            {
                var limits = Limits.Value;
                var deltaSize = evt.newRect.size - evt.oldRect.size;
                var offset = State.offset;
                if (!Mathf.Approximately(offset.x, 0) && !Mathf.Approximately(deltaSize.x, 0) && !Mathf.Approximately(limits.x, 0))
                {
                    offset.x += deltaSize.x * (offset.x / limits.x);
                }
                if (!Mathf.Approximately(offset.y, 0) && !Mathf.Approximately(deltaSize.y, 0) && !Mathf.Approximately(limits.y, 0))
                {
                    offset.y += deltaSize.y * (offset.y / limits.y);
                }

                SetOffset(offset);
            }

            ComputeLimits();
        }

        [SapTarget(typeof(Func<float>))]
        private float GetOffsetX() => State.offset.x;
        [SapTarget(typeof(Func<float>))]
        private float GetOffsetY() => State.offset.y;

        [SapTarget]
        private void SetOffsetX(float v) => SetOffset(new Vector2(v, State.offset.y));
        [SapTarget]
        private void SetOffsetY(float v) => SetOffset(new Vector2(State.offset.x, v));

        private void SetOffset(Vector2 v, bool record)
        {
            if (record)
            {
                var time = Time.time;
                var frame = new DragFrame
                {
                    offset = v,
                    time = time
                };
                var lastTime = Frames[FrameIndex].time;
                if (lastTime > 0 && time > Frames[FrameIndex].time)
                {
                    PrevFrameIndex = FrameIndex;
                    FrameIndex = (FrameIndex + 1) % FramesCacheSize;
                }
                if (PrevFrameIndex >= 0)
                {
                    var prevFrame = Frames[PrevFrameIndex];
                    var dt = time - prevFrame.time;
                    if (dt >= 0.1f)
                    {
                        RestartRecording();
                    }
                    else
                    {
                        frame.deltaPosition = v - prevFrame.offset;
                        frame.deltaTime = time - prevFrame.time;
                    }
                }

                Frames[FrameIndex] = frame;
            }

            if (Props.behavior == VisualBehavior.Clamped)
            {
                var min = GetMinLimit();
                var max = GetMaxLimit();
                v.x = Mathf.Clamp(v.x, min.x, max.x);
                v.y = Mathf.Clamp(v.y, min.y, max.y);
            }

            SetOffset(v);
        }

        private void SetOffset(Vector2 v)
        {
            RishSetOffset(v);

            OnOffset(v);
        }

        private void SetContentSize(Vector2 v)
        {
            if (RishUtils.MemCmp(ContentSize, v)) return;

            var initial = !ContentSize.HasValue;
            if (initial && !Props.offset.HasValue)
            {
                var contentRectSize = ContentRect.size;
                var initialOffset = Props.initialOffset;

                float offsetX, offsetY;
                if (initialOffset.x.unit == LengthUnit.Pixel)
                {
                    offsetX = initialOffset.x.value;
                }
                else
                {
                    var t = initialOffset.x.value * 0.01f;
                    offsetX = (contentRectSize.x - v.x) * t;
                }
                if (initialOffset.y.unit == LengthUnit.Pixel)
                {
                    offsetY = initialOffset.y.value;
                }
                else
                {
                    var t = initialOffset.y.value * 0.01f;
                    offsetY = (contentRectSize.y - v.y) * t;
                }

                SetOffset(new Vector2(offsetX, offsetY));
            }

            if (Dragging)
            {
                NextContentSize = v;
            }
            else
            {
                ContentSize = v;
                ComputeLimits();
            }

            if (initial)
            {
                AnimateRelease();
            }
        }

        private void ComputeLimits()
        {
            if (!ContentSize.HasValue) return;

            var contentSize = NextContentSize ?? ContentSize.Value;
            var contentRectSize = ContentRect.size;
            var limits = new Vector2(contentRectSize.x - contentSize.x, contentRectSize.y - contentSize.y);
            if (NextContentSize.HasValue)
            {
                NextLimits = limits;
            }
            else
            {
                Limits = limits;
            }
        }

        private void RestartRecording()
        {
            if (PrevFrameIndex < 0) return;
            for (var i = 0; i < FramesCacheSize; i++)
            {
                Frames[i] = default;
            }
            PrevFrameIndex = -1;
            FrameIndex = 0;
        }

        private Vector2 GetVelocity()
        {
            var totalTime = 0f;
            foreach (var frame in Frames)
            {
                if (frame.time <= 0) return Vector2.zero;

                totalTime += frame.deltaTime;
            }
            var invTotalTime = 1 / totalTime;
            var result = Vector2.zero;
            foreach (var frame in Frames)
            {
                result += frame.velocity * (frame.deltaTime * invTotalTime);
            }

            return result;
        }

        private struct DragFrame
        {
            public Vector2 offset;
            public float time;

            public Vector2 deltaPosition;
            public float deltaTime;

            public Vector2 velocity => deltaTime > 0 ? deltaPosition / deltaTime : Vector2.zero;
        }
    }

    [RishValueType]
    public struct DragAreaProps
    {
        [Expand]
        public VisualAttributes descriptor;
        [Expand]
        public VisualAttributes holderDescriptor;
        public DragArea.VisualBehavior behavior;
        public DragArea.AxisOfFreedom axisOfFreedom;
        public Translate initialOffset;
        public Element content;
        public Length? extraMargin;
        public float? mouseWheelMultiplier;

        public Vector2? offset;

        public Action<Vector2> onOffset;

        [Default]
        private static DragAreaProps Default => new() { axisOfFreedom = DragArea.AxisOfFreedom.VerticalAndHorizontal };
    }

    [RishValueType]
    public struct DragAreaState
    {
        public Vector2 offset;
    }
}