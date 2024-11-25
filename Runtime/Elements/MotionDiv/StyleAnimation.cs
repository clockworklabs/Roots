using System;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public delegate void OnAnimatedProps(DOMDescriptor descriptor, Initial initial, Target animate, Target exit);

    public interface IAnimatedElement
    {
        event Action OnMounted;
        event Action OnUnmounted;
        event OnAnimatedProps OnProps;
        event Action<VisualElement> OnChange;
        event Action OnRender;
        event Action OnUnmountRequested;
        void OnAnimateComplete();
        void OnExitComplete();

        IAnimatedElement Parent { get; }
        StyleAnimation StyleAnimation { get; }

        void Unmount();
        void OnStyle(Style style);
    }

    public class StyleAnimation
    {
        private event Action OnMounted
        {
            add => Element.OnMounted += value;
            remove => Element.OnMounted -= value;
        }
        private event Action OnUnmounted
        {
            add => Element.OnUnmounted += value;
            remove => Element.OnUnmounted -= value;
        }
        private event Action<VisualElement> OnChange
        {
            add => Element.OnChange += value;
            remove => Element.OnChange -= value;
        }
        private event Action OnRender
        {
            add => Element.OnRender += value;
            remove => Element.OnRender -= value;
        }
        private event Action OnUnmountRequested
        {
            add => Element.OnUnmountRequested += value;
            remove => Element.OnUnmountRequested -= value;
        }

        private IAnimatedElement Element { get; }
        private Motion Motion { get; }
        private StateMachine Machine { get; }

        // private VisualElement VisualElement { get; }
        // protected StyleAnimation Parent { get; private set; }

        private DOMDescriptor Descriptor { get; set; }
        private Initial Initial { get; set; }
        private Target Animate { get; set; }
        private Target Exit { get; set; }

        public StyleAnimation(IAnimatedElement element)
        {
            Element = element;
            Motion = new Motion();
            Machine = new StateMachine(this);
            Motion.Completed += OnMotionComplete;
            Element.OnProps += SetProps;
        }

        private void OnMotionComplete()
        {
            if (Machine.IsIn<ActiveState>())
            {
                Element.OnAnimateComplete();
            }
            else
            {
                Element.OnExitComplete();
            }
        }

        private void Reset()
        {
            Motion.OnStyle -= OnStyle;
            Motion.Reset();

            Descriptor = default;
            Initial = default;
            Animate = default;
            Exit = default;
        }

        private StyleAnimation GetParent() => Element.Parent?.StyleAnimation;

        private void SetupDescriptor()
        {
            var descriptorStyle = Descriptor.style;

            if (Initial.backgroundColor is IInitialValue<Color> backgroundColor)
            {
                if (backgroundColor.skip && Animate.backgroundColor.HasValue)
                {
                    descriptorStyle.backgroundColor = Animate.backgroundColor.Value;
                }
                else if (backgroundColor.value.HasValue)
                {
                    descriptorStyle.backgroundColor = backgroundColor.value.Value;
                }
            }
            if (Initial.borderBottomColor is IInitialValue<Color> borderBottomColor)
            {
                if (borderBottomColor.skip && Animate.borderBottomColor.HasValue)
                {
                    descriptorStyle.borderBottomColor = Animate.borderBottomColor.Value;
                }
                else if (borderBottomColor.value.HasValue)
                {
                    descriptorStyle.borderBottomColor = borderBottomColor.value.Value;
                }
            }
            if (Initial.borderBottomLeftRadius is IInitialValue<Length> borderBottomLeftRadius)
            {
                if (borderBottomLeftRadius.skip && Animate.borderBottomLeftRadius.HasValue)
                {
                    descriptorStyle.borderBottomLeftRadius = Animate.borderBottomLeftRadius.Value;
                }
                else if (borderBottomLeftRadius.value.HasValue)
                {
                    descriptorStyle.borderBottomLeftRadius = borderBottomLeftRadius.value.Value;
                }
            }
            if (Initial.borderBottomRightRadius is IInitialValue<Length> borderBottomRightRadius)
            {
                if (borderBottomRightRadius.skip && Animate.borderBottomRightRadius.HasValue)
                {
                    descriptorStyle.borderBottomRightRadius = Animate.borderBottomRightRadius.Value;
                }
                else if (borderBottomRightRadius.value.HasValue)
                {
                    descriptorStyle.borderBottomRightRadius = borderBottomRightRadius.value.Value;
                }
            }
            if (Initial.borderBottomWidth is IInitialValue<float> borderBottomWidth)
            {
                if (borderBottomWidth.skip && Animate.borderBottomWidth.HasValue)
                {
                    descriptorStyle.borderBottomWidth = Animate.borderBottomWidth.Value;
                }
                else if (borderBottomWidth.value.HasValue)
                {
                    descriptorStyle.borderBottomWidth = borderBottomWidth.value.Value;
                }
            }
            if (Initial.borderLeftColor is IInitialValue<Color> borderLeftColor)
            {
                if (borderLeftColor.skip && Animate.borderLeftColor.HasValue)
                {
                    descriptorStyle.borderLeftColor = Animate.borderLeftColor.Value;
                }
                else if (borderLeftColor.value.HasValue)
                {
                    descriptorStyle.borderLeftColor = borderLeftColor.value.Value;
                }
            }
            if (Initial.borderLeftWidth is IInitialValue<float> borderLeftWidth)
            {
                if (borderLeftWidth.skip && Animate.borderLeftWidth.HasValue)
                {
                    descriptorStyle.borderLeftWidth = Animate.borderLeftWidth.Value;
                }
                else if (borderLeftWidth.value.HasValue)
                {
                    descriptorStyle.borderLeftWidth = borderLeftWidth.value.Value;
                }
            }
            if (Initial.borderRightColor is IInitialValue<Color> borderRightColor)
            {
                if (borderRightColor.skip && Animate.borderRightColor.HasValue)
                {
                    descriptorStyle.borderRightColor = Animate.borderRightColor.Value;
                }
                else if (borderRightColor.value.HasValue)
                {
                    descriptorStyle.borderRightColor = borderRightColor.value.Value;
                }
            }
            if (Initial.borderRightWidth is IInitialValue<float> borderRightWidth)
            {
                if (borderRightWidth.skip && Animate.borderRightWidth.HasValue)
                {
                    descriptorStyle.borderRightWidth = Animate.borderRightWidth.Value;
                }
                else if (borderRightWidth.value.HasValue)
                {
                    descriptorStyle.borderRightWidth = borderRightWidth.value.Value;
                }
            }
            if (Initial.borderTopColor is IInitialValue<Color> borderTopColor)
            {
                if (borderTopColor.skip && Animate.borderTopColor.HasValue)
                {
                    descriptorStyle.borderTopColor = Animate.borderTopColor.Value;
                }
                else if (borderTopColor.value.HasValue)
                {
                    descriptorStyle.borderTopColor = borderTopColor.value.Value;
                }
            }
            if (Initial.borderTopLeftRadius is IInitialValue<Length> borderTopLeftRadius)
            {
                if (borderTopLeftRadius.skip && Animate.borderTopLeftRadius.HasValue)
                {
                    descriptorStyle.borderTopLeftRadius = Animate.borderTopLeftRadius.Value;
                }
                else if (borderTopLeftRadius.value.HasValue)
                {
                    descriptorStyle.borderTopLeftRadius = borderTopLeftRadius.value.Value;
                }
            }
            if (Initial.borderTopRightRadius is IInitialValue<Length> borderTopRightRadius)
            {
                if (borderTopRightRadius.skip && Animate.borderTopRightRadius.HasValue)
                {
                    descriptorStyle.borderTopRightRadius = Animate.borderTopRightRadius.Value;
                }
                else if (borderTopRightRadius.value.HasValue)
                {
                    descriptorStyle.borderTopRightRadius = borderTopRightRadius.value.Value;
                }
            }
            if (Initial.borderTopWidth is IInitialValue<float> borderTopWidth)
            {
                if (borderTopWidth.skip && Animate.borderTopWidth.HasValue)
                {
                    descriptorStyle.borderTopWidth = Animate.borderTopWidth.Value;
                }
                else if (borderTopWidth.value.HasValue)
                {
                    descriptorStyle.borderTopWidth = borderTopWidth.value.Value;
                }
            }
            if (Initial.bottom is IInitialValue<Length> bottom)
            {
                if (bottom.skip && Animate.bottom.HasValue)
                {
                    descriptorStyle.bottom = Animate.bottom.Value;
                }
                else if (bottom.value.HasValue)
                {
                    descriptorStyle.bottom = bottom.value.Value;
                }
            }
            if (Initial.color is IInitialValue<Color> color)
            {
                if (color.skip && Animate.color.HasValue)
                {
                    descriptorStyle.color = Animate.color.Value;
                }
                else if (color.value.HasValue)
                {
                    descriptorStyle.color = color.value.Value;
                }
            }
            if (Initial.flexBasis is IInitialValue<Length> flexBasis)
            {
                if (flexBasis.skip && Animate.flexBasis.HasValue)
                {
                    descriptorStyle.flexBasis = Animate.flexBasis.Value;
                }
                else if (flexBasis.value.HasValue)
                {
                    descriptorStyle.flexBasis = flexBasis.value.Value;
                }
            }
            if (Initial.flexGrow is IInitialValue<float> flexGrow)
            {
                if (flexGrow.skip && Animate.flexGrow.HasValue)
                {
                    descriptorStyle.flexGrow = Animate.flexGrow.Value;
                }
                else if (flexGrow.value.HasValue)
                {
                    descriptorStyle.flexGrow = flexGrow.value.Value;
                }
            }
            if (Initial.flexShrink is IInitialValue<float> flexShrink)
            {
                if (flexShrink.skip && Animate.flexShrink.HasValue)
                {
                    descriptorStyle.flexShrink = Animate.flexShrink.Value;
                }
                else if (flexShrink.value.HasValue)
                {
                    descriptorStyle.flexShrink = flexShrink.value.Value;
                }
            }
            if (Initial.fontSize is IInitialValue<Length> fontSize)
            {
                if (fontSize.skip && Animate.fontSize.HasValue)
                {
                    descriptorStyle.fontSize = Animate.fontSize.Value;
                }
                else if (fontSize.value.HasValue)
                {
                    descriptorStyle.fontSize = fontSize.value.Value;
                }
            }
            if (Initial.height is IInitialValue<Length> height)
            {
                if (height.skip && Animate.height.HasValue)
                {
                    descriptorStyle.height = Animate.height.Value;
                }
                else if (height.value.HasValue)
                {
                    descriptorStyle.height = height.value.Value;
                }
            }
            if (Initial.left is IInitialValue<Length> left)
            {
                if (left.skip && Animate.left.HasValue)
                {
                    descriptorStyle.left = Animate.left.Value;
                }
                else if (left.value.HasValue)
                {
                    descriptorStyle.left = left.value.Value;
                }
            }
            if (Initial.letterSpacing is IInitialValue<Length> letterSpacing)
            {
                if (letterSpacing.skip && Animate.letterSpacing.HasValue)
                {
                    descriptorStyle.letterSpacing = Animate.letterSpacing.Value;
                }
                else if (letterSpacing.value.HasValue)
                {
                    descriptorStyle.letterSpacing = letterSpacing.value.Value;
                }
            }
            if (Initial.marginBottom is IInitialValue<Length> marginBottom)
            {
                if (marginBottom.skip && Animate.marginBottom.HasValue)
                {
                    descriptorStyle.marginBottom = Animate.marginBottom.Value;
                }
                else if (marginBottom.value.HasValue)
                {
                    descriptorStyle.marginBottom = marginBottom.value.Value;
                }
            }
            if (Initial.marginLeft is IInitialValue<Length> marginLeft)
            {
                if (marginLeft.skip && Animate.marginLeft.HasValue)
                {
                    descriptorStyle.marginLeft = Animate.marginLeft.Value;
                }
                else if (marginLeft.value.HasValue)
                {
                    descriptorStyle.marginLeft = marginLeft.value.Value;
                }
            }
            if (Initial.marginRight is IInitialValue<Length> marginRight)
            {
                if (marginRight.skip && Animate.marginRight.HasValue)
                {
                    descriptorStyle.marginRight = Animate.marginRight.Value;
                }
                else if (marginRight.value.HasValue)
                {
                    descriptorStyle.marginRight = marginRight.value.Value;
                }
            }
            if (Initial.marginTop is IInitialValue<Length> marginTop)
            {
                if (marginTop.skip && Animate.marginTop.HasValue)
                {
                    descriptorStyle.marginTop = Animate.marginTop.Value;
                }
                else if (marginTop.value.HasValue)
                {
                    descriptorStyle.marginTop = marginTop.value.Value;
                }
            }
            if (Initial.maxHeight is IInitialValue<Length> maxHeight)
            {
                if (maxHeight.skip && Animate.maxHeight.HasValue)
                {
                    descriptorStyle.maxHeight = Animate.maxHeight.Value;
                }
                else if (maxHeight.value.HasValue)
                {
                    descriptorStyle.maxHeight = maxHeight.value.Value;
                }
            }
            if (Initial.maxWidth is IInitialValue<Length> maxWidth)
            {
                if (maxWidth.skip && Animate.maxWidth.HasValue)
                {
                    descriptorStyle.maxWidth = Animate.maxWidth.Value;
                }
                else if (maxWidth.value.HasValue)
                {
                    descriptorStyle.maxWidth = maxWidth.value.Value;
                }
            }
            if (Initial.minHeight is IInitialValue<Length> minHeight)
            {
                if (minHeight.skip && Animate.minHeight.HasValue)
                {
                    descriptorStyle.minHeight = Animate.minHeight.Value;
                }
                else if (minHeight.value.HasValue)
                {
                    descriptorStyle.minHeight = minHeight.value.Value;
                }
            }
            if (Initial.minWidth is IInitialValue<Length> minWidth)
            {
                if (minWidth.skip && Animate.minWidth.HasValue)
                {
                    descriptorStyle.minWidth = Animate.minWidth.Value;
                }
                else if (minWidth.value.HasValue)
                {
                    descriptorStyle.minWidth = minWidth.value.Value;
                }
            }
            if (Initial.opacity is IInitialValue<float> opacity)
            {
                if (opacity.skip && Animate.opacity.HasValue)
                {
                    descriptorStyle.opacity = Animate.opacity.Value;
                }
                else if (opacity.value.HasValue)
                {
                    descriptorStyle.opacity = opacity.value.Value;
                }
            }
            if (Initial.paddingBottom is IInitialValue<Length> paddingBottom)
            {
                if (paddingBottom.skip && Animate.paddingBottom.HasValue)
                {
                    descriptorStyle.paddingBottom = Animate.paddingBottom.Value;
                }
                else if (paddingBottom.value.HasValue)
                {
                    descriptorStyle.paddingBottom = paddingBottom.value.Value;
                }
            }
            if (Initial.paddingLeft is IInitialValue<Length> paddingLeft)
            {
                if (paddingLeft.skip && Animate.paddingLeft.HasValue)
                {
                    descriptorStyle.paddingLeft = Animate.paddingLeft.Value;
                }
                else if (paddingLeft.value.HasValue)
                {
                    descriptorStyle.paddingLeft = paddingLeft.value.Value;
                }
            }
            if (Initial.paddingRight is IInitialValue<Length> paddingRight)
            {
                if (paddingRight.skip && Animate.paddingRight.HasValue)
                {
                    descriptorStyle.paddingRight = Animate.paddingRight.Value;
                }
                else if (paddingRight.value.HasValue)
                {
                    descriptorStyle.paddingRight = paddingRight.value.Value;
                }
            }
            if (Initial.paddingTop is IInitialValue<Length> paddingTop)
            {
                if (paddingTop.skip && Animate.paddingTop.HasValue)
                {
                    descriptorStyle.paddingTop = Animate.paddingTop.Value;
                }
                else if (paddingTop.value.HasValue)
                {
                    descriptorStyle.paddingTop = paddingTop.value.Value;
                }
            }
            if (Initial.right is IInitialValue<Length> right)
            {
                if (right.skip && Animate.right.HasValue)
                {
                    descriptorStyle.right = Animate.right.Value;
                }
                else if (right.value.HasValue)
                {
                    descriptorStyle.right = right.value.Value;
                }
            }
            if (Initial.rotate is IInitialValue<Angle> rotate)
            {
                if (rotate.skip && Animate.rotate.HasValue)
                {
                    descriptorStyle.rotate = Animate.rotate.Value;
                }
                else if (rotate.value.HasValue)
                {
                    descriptorStyle.rotate = rotate.value.Value;
                }
            }
            if (Initial.scale is IInitialValue<Vector3> scale)
            {
                if (scale.skip && Animate.scale.HasValue)
                {
                    descriptorStyle.scale = Animate.scale.Value;
                }
                else if (scale.value.HasValue)
                {
                    descriptorStyle.scale = scale.value.Value;
                }
            }
            if (Initial.top is IInitialValue<Length> top)
            {
                if (top.skip && Animate.top.HasValue)
                {
                    descriptorStyle.top = Animate.top.Value;
                }
                else if (top.value.HasValue)
                {
                    descriptorStyle.top = top.value.Value;
                }
            }
            if (Initial.transformOrigin is IInitialValue<TransformOrigin> transformOrigin)
            {
                if (transformOrigin.skip && Animate.transformOrigin.HasValue)
                {
                    descriptorStyle.transformOrigin = Animate.transformOrigin.Value;
                }
                else if (transformOrigin.value.HasValue)
                {
                    descriptorStyle.transformOrigin = transformOrigin.value.Value;
                }
            }
            if (Initial.translate is IInitialValue<Translate> translate)
            {
                if (translate.skip && Animate.translate.HasValue)
                {
                    descriptorStyle.translate = Animate.translate.Value;
                }
                else if (translate.value.HasValue)
                {
                    descriptorStyle.translate = translate.value.Value;
                }
            }
            if (Initial.unityBackgroundImageTintColor is IInitialValue<Color> unityBackgroundImageTintColor)
            {
                if (unityBackgroundImageTintColor.skip && Animate.unityBackgroundImageTintColor.HasValue)
                {
                    descriptorStyle.unityBackgroundImageTintColor = Animate.unityBackgroundImageTintColor.Value;
                }
                else if (unityBackgroundImageTintColor.value.HasValue)
                {
                    descriptorStyle.unityBackgroundImageTintColor = unityBackgroundImageTintColor.value.Value;
                }
            }
            if (Initial.unityParagraphSpacing is IInitialValue<Length> unityParagraphSpacing)
            {
                if (unityParagraphSpacing.skip && Animate.unityParagraphSpacing.HasValue)
                {
                    descriptorStyle.unityParagraphSpacing = Animate.unityParagraphSpacing.Value;
                }
                else if (unityParagraphSpacing.value.HasValue)
                {
                    descriptorStyle.unityParagraphSpacing = unityParagraphSpacing.value.Value;
                }
            }
            if (Initial.unitySliceBottom is IInitialValue<int> unitySliceBottom)
            {
                if (unitySliceBottom.skip && Animate.unitySliceBottom.HasValue)
                {
                    descriptorStyle.unitySliceBottom = Animate.unitySliceBottom.Value;
                }
                else if (unitySliceBottom.value.HasValue)
                {
                    descriptorStyle.unitySliceBottom = unitySliceBottom.value.Value;
                }
            }
            if (Initial.unitySliceLeft is IInitialValue<int> unitySliceLeft)
            {
                if (unitySliceLeft.skip && Animate.unitySliceLeft.HasValue)
                {
                    descriptorStyle.unitySliceLeft = Animate.unitySliceLeft.Value;
                }
                else if (unitySliceLeft.value.HasValue)
                {
                    descriptorStyle.unitySliceLeft = unitySliceLeft.value.Value;
                }
            }
            if (Initial.unitySliceRight is IInitialValue<int> unitySliceRight)
            {
                if (unitySliceRight.skip && Animate.unitySliceRight.HasValue)
                {
                    descriptorStyle.unitySliceRight = Animate.unitySliceRight.Value;
                }
                else if (unitySliceRight.value.HasValue)
                {
                    descriptorStyle.unitySliceRight = unitySliceRight.value.Value;
                }
            }
            if (Initial.unitySliceTop is IInitialValue<int> unitySliceTop)
            {
                if (unitySliceTop.skip && Animate.unitySliceTop.HasValue)
                {
                    descriptorStyle.unitySliceTop = Animate.unitySliceTop.Value;
                }
                else if (unitySliceTop.value.HasValue)
                {
                    descriptorStyle.unitySliceTop = unitySliceTop.value.Value;
                }
            }
            if (Initial.unityTextOutlineColor is IInitialValue<Color> unityTextOutlineColor)
            {
                if (unityTextOutlineColor.skip && Animate.unityTextOutlineColor.HasValue)
                {
                    descriptorStyle.unityTextOutlineColor = Animate.unityTextOutlineColor.Value;
                }
                else if (unityTextOutlineColor.value.HasValue)
                {
                    descriptorStyle.unityTextOutlineColor = unityTextOutlineColor.value.Value;
                }
            }
            if (Initial.unityTextOutlineWidth is IInitialValue<float> unityTextOutlineWidth)
            {
                if (unityTextOutlineWidth.skip && Animate.unityTextOutlineWidth.HasValue)
                {
                    descriptorStyle.unityTextOutlineWidth = Animate.unityTextOutlineWidth.Value;
                }
                else if (unityTextOutlineWidth.value.HasValue)
                {
                    descriptorStyle.unityTextOutlineWidth = unityTextOutlineWidth.value.Value;
                }
            }
            if (Initial.width is IInitialValue<Length> width)
            {
                if (width.skip && Animate.width.HasValue)
                {
                    descriptorStyle.width = Animate.width.Value;
                }
                else if (width.value.HasValue)
                {
                    descriptorStyle.width = width.value.Value;
                }
            }
            if (Initial.wordSpacing is IInitialValue<Length> wordSpacing)
            {
                if (wordSpacing.skip && Animate.wordSpacing.HasValue)
                {
                    descriptorStyle.wordSpacing = Animate.wordSpacing.Value;
                }
                else if (wordSpacing.value.HasValue)
                {
                    descriptorStyle.wordSpacing = wordSpacing.value.Value;
                }
            }

            OnStyle(descriptorStyle);
        }

        private void Initialize(VisualElement element, StyleAnimation parent)
        {
            Motion.OnStyle += OnStyle;
            Motion.SetInitial(element, parent?.Motion);
        }
        private void OnStyle(Style style) => Element.OnStyle(style);
        private void Unmount() => Element.Unmount();

        private void SetProps(DOMDescriptor descriptor, Initial initial, Target animate, Target exit)
        {
            Descriptor = descriptor;
            Initial = initial;
            Animate = animate;
            Exit = exit;
        }

        private void To(Target target) => Motion.To(target);

        private class StateMachine
        {
            public event Action OnStateChange;

            private UnmountedState UnmountedState { get; }
            private SettingUpState SettingUpState { get; }
            private ActiveState ActiveState { get; }
            private UnmountingState UnmountingState { get; }

            private State Current { get; set; }

            public StateMachine(StyleAnimation element)
            {
                UnmountedState = new UnmountedState(this, element);
                SettingUpState = new SettingUpState(this, element);
                ActiveState = new ActiveState(this, element);
                UnmountingState = new UnmountingState(this, element);

                GoTo<UnmountedState>();
            }

            public void GoTo<TS>() where TS : State
            {
                var next = Get<TS>();
                if (next == null)
                {
                    throw new ArgumentException("Invalid state");
                }

                Current?.Exit();
                Current = next;
                Current.Enter();

                OnStateChange?.Invoke();
            }

            private State Get<TS>() where TS : State
            {
                if (UnmountedState is TS)
                {
                    return UnmountedState;
                }
                if (SettingUpState is TS)
                {
                    return SettingUpState;
                }
                if (ActiveState is TS)
                {
                    return ActiveState;
                }
                if (UnmountingState is TS)
                {
                    return UnmountingState;
                }

                return null;
            }

            public bool IsIn<TS>() where TS : State => Current is TS;
        }

        private abstract class State
        {
            private StateMachine Machine { get; }
            protected StyleAnimation Element { get; }

            protected State(StateMachine machine, StyleAnimation element)
            {
                Machine = machine;
                Element = element;
            }

            public abstract void Enter();
            public abstract void Exit();

            protected void GoTo<TS>() where TS : State => Machine.GoTo<TS>();
        }

        private class UnmountedState : State
        {
            public UnmountedState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Element.Reset();
                Element.OnMounted += OnMounted;
            }

            public override void Exit()
            {
                Element.OnMounted -= OnMounted;
            }

            private void OnMounted() => GoTo<SettingUpState>();
        }

        private class SettingUpState : State
        {
            private bool Rendered { get; set; }
            private bool LayoutComputed { get; set; }
            private bool ParentReady { get; set; }

            private StyleAnimation Parent { get; set; }
            private VisualElement VisualElement { get; set; }

            public SettingUpState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Rendered = false;
                LayoutComputed = false;

                Parent = Element.GetParent();
                if (Parent != null)
                {
                    Parent.Machine.OnStateChange += ParentStateChanged;
                    ParentReady = false;
                    ParentStateChanged();
                }
                else
                {
                    ParentReady = true;
                }

                Element.OnRender += OnRender;
                Element.OnChange += OnChange;

                Element.OnUnmountRequested += Unmount;
                Element.OnUnmounted += Unmount;
            }

            public override void Exit()
            {
                if (Parent != null)
                {
                    Parent.Machine.OnStateChange -= ParentStateChanged;
                }

                Element.OnRender -= OnRender;
                Element.OnChange -= OnChange;

                Element.OnUnmountRequested -= Unmount;
                Element.OnUnmounted -= Unmount;
            }

            private void OnRender()
            {
                if (Rendered)
                {
                    return;
                }

                Rendered = true;

                Element.SetupDescriptor();

                TryTransition();
            }

            private void OnChange(VisualElement element)
            {
                if (LayoutComputed)
                {
                    return;
                }

                VisualElement = element;

                LayoutComputed = true;

                TryTransition();
            }

            private void ParentStateChanged()
            {
                ParentReady = Parent.Machine.IsIn<ActiveState>();

                TryTransition();
            }

            private void TryTransition()
            {
                if (!Rendered || !LayoutComputed || !ParentReady)
                {
                    return;
                }

                Element.Initialize(VisualElement, Parent);

                StartAnimating();
            }

            private void StartAnimating() => GoTo<ActiveState>();

            private void Unmount()
            {
                Element.Unmount();
                GoTo<UnmountedState>();
            }
        }

        private class ActiveState : State
        {
            public ActiveState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Element.OnRender += Animate;
                Element.OnUnmountRequested += StartUnmounting;
                Element.OnUnmounted += OnUnmounted;

                Animate();
            }

            public override void Exit()
            {
                Element.OnRender -= Animate;
                Element.OnUnmountRequested -= StartUnmounting;
                Element.OnUnmounted -= OnUnmounted;
            }

            private void Animate() => Element.To(Element.Animate);

            private void StartUnmounting() => GoTo<UnmountingState>();
            private void OnUnmounted() => GoTo<UnmountedState>();
        }

        private class UnmountingState : State
        {
            public UnmountingState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Element.OnUnmounted += OnUnmounted;

                Element.Motion.Completed += Unmount;
                if (Element.Exit.IsValid())
                {
                    // TODO: Maybe position absolute and fix layout?
                    Element.To(Element.Exit);
                }
                else
                {
                    Unmount();
                }
            }

            public override void Exit()
            {
                Element.OnUnmounted -= OnUnmounted;

                Element.Motion.Completed -= Unmount;
            }

            private void OnUnmounted() => GoTo<UnmountedState>();

            private void Unmount()
            {
                Element.Unmount();
            }
        }
    }
}