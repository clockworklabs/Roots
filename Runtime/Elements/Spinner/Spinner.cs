using System;
using Motion;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Spinner : RishElement<SpinnerProps, SpinnerState>, IMountingListener
    {
        public enum Type { Border, Grow }
        public enum Size { Regular, Small }

        private VisualElement Parent { get; set; }

        void IMountingListener.ComponentDidMount()
        {
            Parent = GetFirstAncestorOfType<VisualElement>();
            Parent.generateVisualContent += OnParentDirty;
            Parent?.RegisterCallback<GeometryChangedEvent>(OnGeometryChanged);
        }

        void IMountingListener.ComponentWillUnmount()
        {
            Parent.generateVisualContent -= OnParentDirty;
            Parent?.UnregisterCallback<GeometryChangedEvent>(OnGeometryChanged);
        }
        
        protected override Element Render()
        {
            var descriptor = new DOMDescriptor(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    Props.type switch
                    {
                        Type.Border => "spinner-border",
                        Type.Grow => "spinner-grow",
                        _ => throw new ArgumentOutOfRangeException()
                    },
                    Props.size == Size.Small ? "spinner-sm" : string.Empty
                }
            };

            var border = Props.type == Type.Border;
            var grow = !border;
            
            return MotionDiv.Create(
                name: descriptor.name,
                className: descriptor.className,
                style: descriptor.style,
                initial: new Initial
                {
                    rotate = border ? 0 : default(InitialRotate),
                    scale = grow ? 0.1f : default(InitialScale),
                    opacity = grow ? 1 : default(InitialFloat),
                    borderColor = false,
                    backgroundColor = false
                },
                animate: new Target
                {
                    rotate = border ? 360 : null,
                    scale = grow ? Vector3.one : null,
                    opacity = grow ? 0 : null,
                    borderColor = Props.autoColor && border ? (null, State.parentColor, State.parentColor, State.parentColor) : null,
                    backgroundColor = Props.autoColor && grow ? State.parentColor : null,
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

        private void OnGeometryChanged(GeometryChangedEvent evt)
        {
            SetupParentColor();
        }

        private void OnParentDirty(MeshGenerationContext obj)
        {
            SetupParentColor();
        }

        private void SetupParentColor() => SetParentColor(Parent.resolvedStyle.color);
    }

    [RishValueType]
    public struct SpinnerProps
    {
        public Spinner.Type type;
        public Spinner.Size size;

        public bool autoColor;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public Children children;
    }

    [RishValueType]
    public struct SpinnerState
    {
        public Color parentColor;
    }
}
