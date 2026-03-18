using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class Unit : RishElement<UnitProps>
    {
        protected override Element Render() => Div.Create(
            name: Props.attributes.name,
            className: new ClassName(Props.attributes.className)
                .FlexGrow1()
                .BackgroundDark()
                .Border()
                .BorderDarkSubtle()
                .Rounded()
                .Padding2()
                .JustifyContentCenter(),
            style: Props.attributes.style.MinHeight(40),
            children: Row.Create(
                className: Utilities
                    .FlexWrap()
                    .AlignItemsCenter()
                    .JustifyContentEnd(),
                gap: 6,
                reverse: true,
                children: Props.children));
    }

    [RishValueType]
    public struct UnitProps
    {
        [Expand]
        public VisualAttributes attributes;
        public Children children;
    }
}