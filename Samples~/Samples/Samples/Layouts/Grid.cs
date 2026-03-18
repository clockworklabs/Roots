using System;
using RishUI;
using Roots;
using Roots.Rootstrap;
using Sappy;
using UnityEngine;

namespace RootsSamples
{
    public partial class LayoutsSample
    {
        public partial class Grid : RishElement<GridProps, GridState>, IPropsListener
        {
            private Roots.ResponsiveContext _context;
            private Roots.ResponsiveContext Context
            {
                set
                {
                    if (_context == value) return;
                
                    _context?.OnLayout.Remove(Sappy.OnContextLayout);
                
                    _context = value;

                    if (value != null)
                    {
                        value.OnLayout.Add(Sappy.OnContextLayout);
                        OnContextLayout(value.GetLayoutData());
                    }
                }
            }
            
            void IPropsListener.PropsDidChange()
            {
                Context = GetFirstAncestorOfType<Roots.ResponsiveContext>();
            }
            void IPropsListener.PropsWillChange()
            {
                Context = null;
            }

            protected override Element Render()
            {
                var sizeChildren = new Children();
                var resolvedSize = false;
                var gutterChildren = new Children();
                var resolvedGutter = false;
                for (var i = (int)(ResponsiveBreakpoint.Count - 1); i >= 0; i--)
                {
                    var breakpoint = (ResponsiveBreakpoint)i;
                    string label;
                    int? size = null;
                    float? gutter = null;
                    switch (breakpoint)
                    {
                        case ResponsiveBreakpoint.ExtraSmall:
                            label = "xs";
                            size = Props.xs ?? 1;
                            gutter = Props.xsGutter?.x ?? 0;
                            break;
                        case ResponsiveBreakpoint.Small:
                            label = "sm";
                            if (Props.sm.HasValue)
                            {
                                size = Props.sm.Value;
                            }
                            if (Props.smGutter.HasValue)
                            {
                                gutter = Props.smGutter.Value.x;
                            }
                            break;
                        case ResponsiveBreakpoint.Medium:
                            label = "md";
                            if (Props.md.HasValue)
                            {
                                size = Props.md.Value;
                            }
                            if (Props.mdGutter.HasValue)
                            {
                                gutter = Props.mdGutter.Value.x;
                            }
                            break;
                        case ResponsiveBreakpoint.Large:
                            label = "lg";
                            if (Props.lg.HasValue)
                            {
                                size = Props.lg.Value;
                            }
                            if (Props.lgGutter.HasValue)
                            {
                                gutter = Props.lgGutter.Value.x;
                            }
                            break;
                        case ResponsiveBreakpoint.ExtraLarge:
                            label = "xl";
                            if (Props.xl.HasValue)
                            {
                                size = Props.xl.Value;
                            }
                            if (Props.xlGutter.HasValue)
                            {
                                gutter = Props.xlGutter.Value.x;
                            }
                            break;
                        case ResponsiveBreakpoint.ExtraExtraLarge:
                            label = "xxl";
                            if (Props.xxl.HasValue)
                            {
                                size = Props.xxl.Value;
                            }
                            if (Props.xxlGutter.HasValue)
                            {
                                gutter = Props.xxlGutter.Value.x;
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    if (size.HasValue)
                    {
                        var className = Utilities.TextNowrap();
                        if (!resolvedSize && breakpoint <= State.breakpoint)
                        {
                            className = className.FontStyleBold();
                            resolvedSize = true;
                        }
                    
                        sizeChildren.Add(Small.Create(className: className, text: $"{label}: {size.Value}"));
                    }

                    if (gutter.HasValue)
                    {
                        var className = Utilities.TextNowrap();
                        if (!resolvedGutter && breakpoint <= State.breakpoint)
                        {
                            className = className.FontStyleBold();
                            resolvedGutter = true;
                        }
                    
                        gutterChildren.Add(Small.Create(className: className, text: $"{label}: {Mathf.RoundToInt(gutter.Value)}px"));
                    }
                }
                
                var cols = new RishList<ColData>();
                for(int i = 0, n = Props.cols.Count; i < n; i++)
                {
                    var data = Props.cols[i];
                    data.children = Cell.Create(
                        xs: data.xs,
                        sm: data.sm,
                        md: data.md,
                        lg: data.lg,
                        xl: data.xl,
                        xxl: data.xxl,
                        breakpoint: State.breakpoint);
                    
                    cols.Add(data);
                }

                return Roots.Col.Create(
                    gap: 4,
                    children: new Children
                    {
                        H6.Create(text: "Grid"),
                        Roots.Col.Create(
                            className: Utilities.Padding1().Border().BorderDarkSubtle(),
                            gap: 4,
                            children: new Children
                            {
                                Roots.Row.Create(
                                    className: Utilities.AlignItemsCenter(),
                                    gap: 8,
                                    children: new Children {
                                        Body.Create(text: "Size:"),
                                        Roots.Row.Create(
                                            className: Utilities.JustifyContentEnd().AlignItemsCenter(),
                                            gap: 4,
                                            reverse: true,
                                            separator: Small.Create(text: "-"),
                                            children: sizeChildren),
                                    }),
                                Roots.Row.Create(
                                    className: Utilities.AlignItemsCenter(),
                                    gap: 8,
                                    children: new Children {
                                        Body.Create(text: "Gutter:"),
                                        Roots.Row.Create(
                                            className: Utilities.JustifyContentEnd().AlignItemsCenter(),
                                            gap: 4,
                                            reverse: true,
                                            separator: Small.Create(text: "-"),
                                            children: gutterChildren),
                                    }),
                                Roots.Grid.Create(
                                    xs: Props.xs,
                                    sm: Props.sm,
                                    md: Props.md,
                                    lg: Props.lg,
                                    xl: Props.xl,
                                    xxl: Props.xxl,
                                    xsGutter: Props.xsGutter,
                                    smGutter: Props.smGutter,
                                    mdGutter: Props.mdGutter,
                                    lgGutter: Props.lgGutter,
                                    xlGutter: Props.xlGutter,
                                    xxlGutter: Props.xxlGutter,
                                    cols: cols)
                            })
                    });
            }

            [SapTarget]
            private void OnContextLayout(Roots.ResponsiveContext.LayoutData data) => SetBreakpoint(data.breakpoint);
        }

        [RishValueType]
        public struct GridProps
        {
            public int? xs;
            public int? sm;
            public int? md;
            public int? lg;
            public int? xl;
            public int? xxl;

            public Gutter? xsGutter;
            public Gutter? smGutter;
            public Gutter? mdGutter;
            public Gutter? lgGutter;
            public Gutter? xlGutter;
            public Gutter? xxlGutter;

            public RishList<ColData> cols;
        }

        [RishValueType]
        public struct GridState
        {
            public ResponsiveBreakpoint breakpoint;
        }
    }
}