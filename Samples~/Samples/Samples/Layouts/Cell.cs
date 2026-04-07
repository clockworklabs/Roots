using System;
using RishUI;
using Roots;
using Roots.Rootstrap;
using Sappy;

namespace RootsSamples
{
    public partial class LayoutsSample
    {
        public partial class Cell : RishElement<CellProps>
        {
            protected override Element Render()
            {
                var children = new Children();
                var resolved = false;
                for (var i = (int)(ResponsiveBreakpoint.Count - 1); i >= 0; i--)
                {
                    var breakpoint = (ResponsiveBreakpoint)i;
                    string label;
                    int size;
                    switch (breakpoint)
                    {
                        case ResponsiveBreakpoint.ExtraSmall:
                            label = "xs";
                            size = Props.xs ?? 1;
                            break;
                        case ResponsiveBreakpoint.Small:
                            if (!Props.sm.HasValue) continue;
                            label = "sm";
                            size = Props.sm.Value;
                            break;
                        case ResponsiveBreakpoint.Medium:
                            if (!Props.md.HasValue) continue;
                            label = "md";
                            size = Props.md.Value;
                            break;
                        case ResponsiveBreakpoint.Large:
                            if (!Props.lg.HasValue) continue;
                            label = "lg";
                            size = Props.lg.Value;
                            break;
                        case ResponsiveBreakpoint.ExtraLarge:
                            if (!Props.xl.HasValue) continue;
                            label = "xl";
                            size = Props.xl.Value;
                            break;
                        case ResponsiveBreakpoint.ExtraExtraLarge:
                            if (!Props.xxl.HasValue) continue;
                            label = "xxl";
                            size = Props.xxl.Value;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    var className = Utilities.TextNowrap();
                    if (!resolved && breakpoint <= Props.breakpoint)
                    {
                        className = className.FontStyleBold();
                        resolved = true;
                    }
                    
                    children.Add(Small.Create(className: className, text: $"{label}: {size}"));
                }

                return Unit.Create(children: children);
            }
        }

        [RishValueType]
        public struct CellProps
        {
            public int? xs;
            public int? sm;
            public int? md;
            public int? lg;
            public int? xl;
            public int? xxl;
            public ResponsiveBreakpoint breakpoint;
        }
    }
}