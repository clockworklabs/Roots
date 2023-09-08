using System;
using RishUI;
using RishUI.Events;
using UnityEngine.UIElements;

namespace Roots
{
    [AutoKey]
    public partial class MotionDiv : RishElement<MotionDivProps>, IAnimatedElement, IMountingListener, ICustomUnmountListener, IPropsListener/*, IManualStyling*/
    {
        private event Action OnMounted;
        event Action IAnimatedElement.OnMounted
        {
            add => OnMounted += value;
            remove => OnMounted -= value;
        }
        private event Action OnUnmounted;
        event Action IAnimatedElement.OnUnmounted
        {
            add => OnUnmounted += value;
            remove => OnUnmounted -= value;
        }
        private event OnAnimatedProps OnProps;
        event OnAnimatedProps IAnimatedElement.OnProps
        {
            add => OnProps += value;
            remove => OnProps -= value;
        }
        private event Action<VisualElement> OnChange;
        event Action<VisualElement> IAnimatedElement.OnChange
        {
            add => OnChange += value;
            remove => OnChange -= value;
        }
        private event Action OnRender;
        event Action IAnimatedElement.OnRender
        {
            add => OnRender += value;
            remove => OnRender -= value;
        }
        private event Action OnUnmountRequested;
        event Action IAnimatedElement.OnUnmountRequested
        {
            add => OnUnmountRequested += value;
            remove => OnUnmountRequested -= value;
        }

        void IAnimatedElement.OnAnimateComplete()
        {
            Props.OnAnimateComplete?.Invoke();
        }

        void IAnimatedElement.OnExitComplete()
        {
            Props.OnExitComplete?.Invoke();
        }

        private StyleAnimation Animation { get; }
        StyleAnimation IAnimatedElement.StyleAnimation => Animation;

        private IAnimatedElement _parent;
        IAnimatedElement IAnimatedElement.Parent => _parent;

        private DOMDescriptor? CustomDescriptor { get; set; }

        public MotionDiv()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);

            Animation = new StyleAnimation(this);
        }

        void IMountingListener.ComponentDidMount()
        {
            _parent = GetFirstAncestorOfType<IAnimatedElement>();

            CustomDescriptor = null;
            OnMounted?.Invoke();
        }

        void IMountingListener.ComponentWillUnmount() { }

        void ICustomUnmountListener.UnmountRequested() => OnUnmountRequested?.Invoke();
        void ICustomUnmountListener.Unmounted() => OnUnmounted?.Invoke();

        void IPropsListener.PropsDidChange() => OnProps?.Invoke(Props.descriptor, Props.initial, Props.animate, Props.exit);
        void IPropsListener.PropsWillChange() { }

        void IAnimatedElement.Unmount() => CanUnmount();
        void IAnimatedElement.OnStyle(Style style)
        {
            var descriptor = CustomDescriptor ?? Props.descriptor;
            descriptor.style = style;
            CustomDescriptor = descriptor;
        }

        protected override Element Render()
        {
            OnRender?.Invoke();

            return Div.Create(descriptor: CustomDescriptor ?? Props.descriptor, /*utilities: Props.utilities,*/ children: Props.children);
        }

        private void OnVisualChange(VisualChangeEvent evt) => OnChange?.Invoke(evt.target as VisualElement);
    }

    [RishValueType]
    public struct MotionDivProps
    {
        public Initial initial;
        public Target animate;
        public Target exit;
        
        [IgnoreComparison]
        public Action OnAnimateComplete;
        [IgnoreComparison]
        public Action OnExitComplete;

        // TODO
        public bool drag;

        // TODO: Create parent element with multiple children based on hover and press
        // public Target whileHover;
        // public Target whilePress;

        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public Children children;
    }
}