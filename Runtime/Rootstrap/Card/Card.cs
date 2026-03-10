using RishUI;

namespace Roots.Rootstrap
{
    public partial class Card : RishElement<CardProps>
    {
        protected override Element Render() => Div.Create(attributes: Props.attributes + "card", children: Props.children);
    }

    [RishValueType]
    public struct CardProps
    {
        [Expand]
        public VisualAttributes attributes;
        public Children children;
    }
}
