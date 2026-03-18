using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class LayoutsSample
    {
        public partial class Col : RishElement<ColProps>
        {
            protected override Element Render() => Roots.Col.Create(
                gap: 4,
                children: new Children
                {
                    H6.Create(text: "Col"),
                    Div.Create(
                        className: Utilities.Padding1().Border().BorderDarkSubtle(),
                        children: Roots.Col.Create(gap: Props.gap, separator: Props.separator, children: Props.children))
                });
        }

        [RishValueType]
        public struct ColProps
        {
            public float gap;
            public Element separator;
            public Children children;
        }
    }
}