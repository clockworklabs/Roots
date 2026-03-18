using System;
using Motion;
using RishUI;
using Roots;
using Roots.Experimental.Rootstrap;
using Roots.Rootstrap;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace RootsSamples
{
    public partial class SamplesContainer : RishElement<SamplesContainerProps, SamplesContainerState>, IMountingListener
    {
        private TweenAnimationId<float> SizeAnimation { get; set; }
        
        public SamplesContainer()
        {
            RegisterCallback<GeometryChangedEvent>(OnGeometryChanged);
        }
        
        void IMountingListener.ElementDidMount() { }
        void IMountingListener.ElementWillUnmount()
        {
            SizeAnimation.Stop();
        }

        protected override Element Render()
        {
            var className = new ClassName
            {
                "m-3",
                "absolute-fill"
            };
            var content = Container.Create(
                className: new ClassName
                {
                    "flex-grow-1",
                    "w-100"
                },
                breakpoint: ResponsiveBreakpoint.ExtraExtraLarge,
                content: Props.content);
            
            return DropdownContext.Create(
                name: "samples-container",
                className: "flex-grow-1",
                children: new Children
                {
                    Props.scrollView
                        ? VScrollView.Create(className: className, children: content)
                        : Div.Create(className: className, children: content),
                    Body.Create(
                        className: new ClassName
                        {
                            "position-absolute",
                            "left-0",
                            "bottom-0",
                            "m-2"
                        },
                        style: new Style { opacity = State.resolvedSizeOpacity },
                        text: $"{State.resolvedSize}")
                });
        }

        private void OnGeometryChanged(GeometryChangedEvent evt)
        {
            SetResolvedSize(new Vector2Int(Mathf.RoundToInt(evt.newRect.width), Mathf.RoundToInt(evt.newRect.height)));
            SetResolvedSizeOpacity(1);
            SizeAnimation.Stop();
            SizeAnimation = DoMotion.Tween(Sappy.GetResolvedSizeOpacity, SappyState.SetResolvedSizeOpacity, 0).SetDelay(3);
        }

        [SapTarget]
        private float GetResolvedSizeOpacity() => State.resolvedSizeOpacity;
    }

    [RishValueType]
    public struct SamplesContainerProps
    {
        public bool scrollView;
        public Element content;
    }

    [RishValueType]
    public struct SamplesContainerState
    {
        public Vector2Int resolvedSize;
        public float resolvedSizeOpacity;
    }
}