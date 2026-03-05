using System;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;

namespace Roots
{
    public partial class ResponsiveContext : RishElement<ResponsiveContextProps, ResponsiveContextState>, IPropsListener<ResponsiveContextProps>
    {
        public struct LayoutData
        {
            public float width;
            public ResponsiveBreakpoint breakpoint;
        }
        
        private SapStem<LayoutData> OnLayoutStem { get; } = new();
        public SapTargets<LayoutData> OnLayout => OnLayoutStem.Targets;
        
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
        
        protected override Element Render() => Div.Create(descriptor: Props.descriptor, children: Props.children);


        private void OnVisualChange(VisualChangeEvent evt) => SetWidth(ContentRect.width);

        private void SetWidth(float value)
        {
            RishSetWidth(value);
            Update();
        }

        private void Update()
        {
            var width = State.width;
            
            var breakpoint = GetBreakpointFor(width);
            SetBreakpoint(breakpoint);
            
            OnResize(width, breakpoint);
            OnLayoutStem.Send(GetLayoutData());
        }
        
        private const int ExtraSmallMinWidth = 0;
        private const int DefaultSmallMinWidth = 576;
        private const float DefaultRatio = 4 / 3f;

        private ResponsiveBreakpoint GetBreakpointFor(float width)
        {
            if (width <= ExtraSmallMinWidth) return ResponsiveBreakpoint.ExtraSmall;
            
            // TODO: Doing this is not the best performant thing in the world. We can revisit if it becomes a problem.
            for (var i = (int)ResponsiveBreakpoint.Count - 1; i >= 0; i--)
            {
                var size = (ResponsiveBreakpoint)i;
                if(GetMinWidth(size) <= width) return size;
            }
            
            return ResponsiveBreakpoint.ExtraSmall;
        }

        public int GetMinWidth(ResponsiveBreakpoint breakpoint)
        {
            if(breakpoint is ResponsiveBreakpoint.ExtraSmall) return ExtraSmallMinWidth;
            var prevSize = breakpoint - 1;
            var prevMinWidth = GetMinWidth(prevSize);
            var propsMinWidth = GetPropsMinWidth(breakpoint);
            if(propsMinWidth > prevMinWidth) return propsMinWidth;
            return prevSize is ResponsiveBreakpoint.ExtraSmall ? DefaultSmallMinWidth : Mathf.FloorToInt(prevMinWidth * DefaultRatio);
        }

        private int GetPropsMinWidth(ResponsiveBreakpoint breakpoint) => breakpoint switch
        {
            ResponsiveBreakpoint.Small => Props.sm,
            ResponsiveBreakpoint.Medium => Props.md,
            ResponsiveBreakpoint.Large => Props.lg,
            ResponsiveBreakpoint.ExtraLarge => Props.xl,
            ResponsiveBreakpoint.ExtraExtraLarge => Props.xxl
        };

        public LayoutData GetLayoutData() => new()
        {
            width = State.width,
            breakpoint = State.breakpoint,
        };
    }

    [RishValueType]
    public struct ResponsiveContextProps
    {
        public int sm;
        public int md;
        public int lg;
        public int xl;
        public int xxl;
        
        [Expand]
        public VisualAttributes descriptor;
        public Children children;

        public Action<float, ResponsiveBreakpoint> onResize;
    }

    [RishValueType]
    public struct ResponsiveContextState
    {
        public float width;
        public ResponsiveBreakpoint breakpoint;
    }
}