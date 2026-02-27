using RishUI;

namespace Roots.Bootstrap
{
    public partial class Card : RishElement<CardProps>
    {
        protected override Element Render() => Div.Create(descriptor: Props.descriptor + "card", children: Props.children);
    }

    [RishValueType]
    public struct CardProps
    {
        [Expand]
        public VisualAttributes descriptor;
        public Children children;
    }
}
