using System;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;

namespace Roots
{
    public partial class ResponsiveContext : RishElement<ResponsiveContextProps, ResponsiveContextState>, IPropsListener<ResponsiveContextProps>
    {
        public enum Size { XSmall, Small, Medium, Large, XLarge, XXLarge, Count }
        
        public struct LayoutData
        {
            public Size size;
            public bool uss;
            public float width;
        }
        
        private SapStem<LayoutData> OnLayoutStem { get; } = new();
        public SapTargets<Action<LayoutData>> OnLayout => OnLayoutStem.Targets;
        
        public ResponsiveContext()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange, EventPhase.AtTargetOnly);
        }

        void IPropsListener<ResponsiveContextProps>.PropsDidChange(ResponsiveContextProps? prev)
        {
            if (prev.HasValue)
            {
                Update();
            }
        }
        void IPropsListener<ResponsiveContextProps>.PropsWillChange() { }
        
        protected override Element Render() => Props.uss
            ? Visual.Create(descriptor: Props.descriptor, children: Props.children)
            : Div.Create(descriptor: Props.descriptor, children: Props.children);


        private void OnVisualChange(VisualChangeEvent evt) => SetWidth(ContentRect.width);

        private void SetWidth(float value)
        {
            RishSetWidth(value);
            Update();
        }

        private void Update()
        {
            var width = State.width;
            
            var size = GetSizeFor(width);
            SetSize(size);
            
            OnResize(width, size);
            OnLayoutStem.Send(GetLayoutData());
        }
        
        private const int XSmallMinWidth = 0;
        private const int DefaultSmallMinWidth = 576;
        private const float DefaultRatio = 4 / 3f;

        private Size GetSizeFor(float width)
        {
            if (width <= XSmallMinWidth) return Size.XSmall;
            
            // TODO: Doing this is not the best performant thing in the world. We can revisit if it becomes a problem.
            for (var i = (int)Size.Count - 1; i >= 0; i--)
            {
                var size = (Size)i;
                if(GetMinWidth(size) <= width) return size;
            }
            
            return Size.XSmall;
        }

        private int GetMinWidth(Size size)
        {
            if(size is Size.XSmall) return XSmallMinWidth;
            var prevSize = size - 1;
            var prevMinWidth = GetMinWidth(prevSize);
            var propsMinWidth = GetPropsMinWidth(size);
            if(propsMinWidth > prevMinWidth) return propsMinWidth;
            return prevSize is Size.XSmall ? DefaultSmallMinWidth : Mathf.FloorToInt(prevMinWidth * DefaultRatio);
        }

        private int GetPropsMinWidth(Size size) => size switch
        {
            Size.Small => Props.smMinWidth,
            Size.Medium => Props.mdMinWidth,
            Size.Large => Props.lgMinWidth,
            Size.XLarge => Props.xlMinWidth,
            Size.XXLarge => Props.xxlMinWidth
        };

        public LayoutData GetLayoutData() => new()
        {
            uss = Props.uss,
            width = State.width,
            size = State.size,
        };
    }

    [RishValueType]
    public struct ResponsiveContextProps
    {
        public int smMinWidth;
        public int mdMinWidth;
        public int lgMinWidth;
        public int xlMinWidth;
        public int xxlMinWidth;

        public bool uss;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;

        public Action<float, ResponsiveContext.Size> onResize;
    }

    [RishValueType]
    public struct ResponsiveContextState
    {
        public float width;
        public ResponsiveContext.Size size;
    }
}