using System;
using Motion;
using RishUI;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class Spinner : RishElement<SpinnerProps>, IVisualManipulator
    {
        public enum Type { Border, Grow }
        public enum Size { Regular, Small }
        
        bool IVisualManipulator.Evaluate(VisualElement descendant) => true;
        void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
            if (!Props.autoColor) return;

            var color = descendant.parent.resolvedStyle.color;
            var descendantStyle = descendant.style;
            switch (Props.type)
            {
                case Type.Border:
                    descendantStyle.borderColor = color;
                    descendantStyle.borderTopColor = Color.clear;
                    break;
                case Type.Grow:
                    descendantStyle.backgroundColor = color;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        protected override Element Render()
        {
            var border = Props.type == Type.Border;
            var grow = !border;
            
            return MotionDiv.Create(
                name: Props.attributes.name,
                className: Props.attributes.className + new ClassName
                {
                    Props.type switch
                    {
                        Type.Border => "spinner-border",
                        Type.Grow => "spinner-grow"
                    },
                    Props.size is Size.Small ? "spinner-sm" : string.Empty
                },
                style: Props.attributes.style,
                initial: new Initial
                {
                    rotate = border ? 0 : default(InitialRotate),
                    scale = grow ? 0.1f : default(InitialScale),
                    opacity = grow ? 1 : default(InitialFloat),
                },
                animate: new Target
                {
                    rotate = border ? 360 : null,
                    scale = grow ? Vector3.one : null,
                    opacity = grow ? 0 : null,
                    transition = new Transition
                    {
                        all = new TransitionDetails(new Tween
                        {
                            duration = 0.75f,
                            ease = Ease.Linear
                        })
                        {
                            repeat = -1
                        },
                        borderColor = false,
                        backgroundColor = false
                    }
                });
        }
    }

    [RishValueType]
    public struct SpinnerProps
    {
        public Spinner.Type type;
        public Spinner.Size size;

        public bool autoColor;
        
        [Expand]
        public VisualAttributes attributes;
        public Children children;
    }
}
