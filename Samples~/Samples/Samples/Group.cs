using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class Group : RishElement<GroupProps>
    {
        protected override Element Render()
        {
            return Col.Create(
                gap: 4,
                children: new Children
                {
                    H6.Create(text: Props.title),
                    Col.Create(
                        className: Utilities.Padding1().Border().BorderDarkSubtle(),
                        gap: 4,
                        children: new Children
                        {
                            // Roots.Row.Create(
                            //     className: Utilities.AlignItemsCenter(),
                            //     gap: 8,
                            //     children: new Children {
                            //         Body.Create(text: "Size:"),
                            //         Roots.Row.Create(
                            //             className: Utilities.JustifyContentEnd().AlignItemsCenter(),
                            //             gap: 4,
                            //             reverse: true,
                            //             separator: Small.Create(text: "-"),
                            //             children: sizeChildren),
                            //     }),
                            // Roots.Row.Create(
                            //     className: Utilities.AlignItemsCenter(),
                            //     gap: 8,
                            //     children: new Children {
                            //         Body.Create(text: "Gutter:"),
                            //         Roots.Row.Create(
                            //             className: Utilities.JustifyContentEnd().AlignItemsCenter(),
                            //             gap: 4,
                            //             reverse: true,
                            //             separator: Small.Create(text: "-"),
                            //             children: gutterChildren),
                            //     }),
                            Props.children,
                        })
                });
        }
    }

    [RishValueType]
    public struct GroupProps
    {
        public RishString title;
        // public Children notes;
        public Children children;
    }
}