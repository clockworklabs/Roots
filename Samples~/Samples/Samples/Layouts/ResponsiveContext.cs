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
        public partial class ResponsiveContext : RishElement<ResponsiveContextProps, ResponsiveContextState>, IPropsListener
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

            protected override Element Render() => Roots.Col.Create(
                gap: 4,
                children: new Children
                {
                    H6.Create(text: "ResponsiveContext"),
                    Roots.Col.Create(
                        className: Utilities.Padding1().Border().BorderDarkSubtle(),
                        gap: 4,
                        children: new Children
                        {
                            Roots.Row.Create(
                                className: Utilities.AlignItemsCenter(),
                                gap: 4,
                                children: new Children {
                                    Body.Create(text: "Width:"),
                                    Small.Create(className: Utilities.FontStyleBold(), text: $"{State.width}px"),
                                }),
                            Roots.Row.Create(
                                className: Utilities.AlignItemsCenter(),
                                gap: 4,
                                children: new Children {
                                    Body.Create(text: "Breakpoint:"),
                                    Small.Create(
                                        className: Utilities.FontStyleBold(),
                                        text: State.breakpoint switch
                                        {
                                            ResponsiveBreakpoint.ExtraSmall => "xs",
                                            ResponsiveBreakpoint.Small => "sm",
                                            ResponsiveBreakpoint.Medium => "md",
                                            ResponsiveBreakpoint.Large => "lg",
                                            ResponsiveBreakpoint.ExtraLarge => "xl",
                                            ResponsiveBreakpoint.ExtraExtraLarge => "xxl",
                                        }),
                                }),
                            Props.children
                        })
                });

            [SapTarget]
            private void OnContextLayout(Roots.ResponsiveContext.LayoutData data)
            {
                SetBreakpoint(data.breakpoint);
                SetWidth(Mathf.CeilToInt(data.width));
            }
        }

        [RishValueType]
        public struct ResponsiveContextProps
        {
            public Children children;
        }

        [RishValueType]
        public struct ResponsiveContextState
        {
            public ResponsiveBreakpoint breakpoint;
            public int width;
        }
    }
}