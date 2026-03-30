using RishUI;
using Roots;
using Sappy;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class SamplesApp : IApp
    {
        Element IApp.GetRoot(bool recovered) => ResponsiveContext.Create(
            name: "root",
            className: Utilities.AbsoluteFill(),
            children: Root.Create());

        private partial class Root : RishElement<NoProps, RootState>, IMountingListener
        {
            private ResponsiveContext _context;
            private ResponsiveContext Context
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
            
            void IMountingListener.ElementDidMount()
            {
                Context = GetFirstAncestorOfType<ResponsiveContext>();
            }
            void IMountingListener.ElementWillUnmount()
            {
                Context = null;
            }
            
            protected override Element Render()
            {
                var sample = SamplesList[State.index];

                return TooltipsContext.Create(
                    className: Utilities.FlexFill(),
                    children: Row.Create(
                        className: Utilities.FlexFill(),
                        gap: 16,
                        children: new Children
                        {
                            NavigationRail.Create(
                                smallContext: State.smallContext,
                                index: State.index,
                                onIndex: SappyState.SetIndex),
                            Col.Create(
                                className: Utilities.FlexFill(),
                                gap: 16,
                                children: new Children
                                {
                                    Div.Create(
                                        className: Utilities.FlexFill(),
                                        children: new Children
                                        {
                                            Div.Create(
                                                className: new ClassName
                                                {
                                                    "content-rect",
                                                    "thin-border"
                                                }.AbsoluteFill().FlexFill()),
                                            Col.Create(
                                                className: Utilities.FlexFill(),
                                                gap: 8,
                                                children: new Children
                                                {
                                                    Row.Create(
                                                        className: Utilities
                                                            .MarginTop2()
                                                            .MarginX3()
                                                            .MarginBottom1()
                                                            .JustifyContentBetween()
                                                            .AlignItemsCenter(),
                                                        children: new Children
                                                        {
                                                            H1.Create(text: sample.Name),
#if UNITY_EDITOR
                                                            Button.Create(
                                                                action: Sappy.ToggleCode,
                                                                variant: Button.Variant.Dark,
                                                                active: State.showingCode,
                                                                children: Row.Create(
                                                                    className: Utilities.AlignItemsCenter(),
                                                                    gap: 4,
                                                                    children: new Children
                                                                    {
                                                                        Icon.Create(unicode: FontAwesome.FA_Code.Unicode),
                                                                        "Code"
                                                                    }))
#endif
                                                        }),
                                                    ResizableContainer.Create(content: SamplesContainer.Create(scrollView: sample.AutoScrollView, content: sample.Factory()))
                                                })
                                        }),
#if UNITY_EDITOR
                                    SampleCode.Create(index: State.index, open: State.showingCode)
#endif
                                })
                        }));
            }

            [SapTarget]
            private void OnContextLayout(ResponsiveContext.LayoutData data) => SetSmallContext(data.breakpoint <= ResponsiveBreakpoint.Small);
            
#if UNITY_EDITOR
            [SapTarget]
            private void ToggleCode() => SetShowingCode(!State.showingCode);
#endif
        }
        
        [RishValueType]
        public struct RootState
        {
            public bool smallContext;
            public int index;
#if UNITY_EDITOR
            public bool showingCode;
#endif
        }
    }
}