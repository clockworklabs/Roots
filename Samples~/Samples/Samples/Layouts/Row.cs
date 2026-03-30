using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class LayoutsSample
    {
        public partial class Row : RishElement<RowProps>
        {
            protected override Element Render() => Roots.Col.Create(
                gap: 4,
                children: new Children
                {
                    H6.Create(text: "Row"),
                    Div.Create(
                        className: Utilities.Padding1().Border().BorderDarkSubtle(),
                        children: Roots.Row.Create(gap: Props.gap, children: Props.children))
                });
        }

        [RishValueType]
        public struct RowProps
        {
            public float gap;
            public Children children;
        }
    }
}