using System;
using Motion;
using RishUI;

namespace Roots
{
    public partial class FadeDiv : RishElement<FadeProps, FadeState>, IPropsListener<FadeProps>
    {
        public enum Preset { Slow, Fast, Immediate }

        void IPropsListener<FadeProps>.PropsDidChange(FadeProps? prev)
        {
            if (prev.HasValue)
            {
                var prevValue = prev.Value;
                if (prevValue.visible != Props.visible)
                {
                    SetVisible(prevValue.visible);
                }
            }
        }
        void IPropsListener<FadeProps>.PropsWillChange() { }

        protected override Element Render()
        {
            var tween = new Tween
            {
                ease = Ease.Back,
                duration = Props.duration ?? Props.preset switch
                {
                    Preset.Slow => 1,
                    Preset.Fast => 0.3f,
                    Preset.Immediate => 0
                }
            };
            var transition = new Transition(tween);

            var minOpacity = Props.minOpacity ?? 0;
            var maxOpacity = Props.maxOpacity ?? 1;

            return MotionDiv.Create(
                name: Props.descriptor.name,
                className: Props.descriptor.className,
                style: Props.descriptor.style,
                initial: new Initial { opacity = minOpacity },
                animate: new Target { opacity = Props.visible ? maxOpacity : minOpacity, transition = transition },
                exit: new Target { opacity = Props.fadeOnUnmount ? minOpacity : null, transition = transition },
                onAnimateComplete: OnAnimateComplete,
                onExitComplete: OnExitComplete,
                children: Props.keepChildrenWhenInvisible || Props.visible || State.visible
                    ? Props.children
                    : Element.Null);
        }

        private void OnAnimateComplete()
        {
            SetVisible(Props.visible);
            Props.onAnimateComplete?.Invoke();
        }

        private void OnExitComplete() => Props.onAnimateComplete?.Invoke();
    }

    [RishValueType]
    public struct FadeProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;

        public bool visible;
        public bool fadeOnUnmount;
        public bool keepChildrenWhenInvisible;
        public FadeDiv.Preset preset;
        public float? duration;
        public Children children;
        public float? minOpacity;
        public float? maxOpacity;

        public Action onAnimateComplete;
    }

    [RishValueType]
    public struct FadeState
    {
        public bool visible;
    }
}