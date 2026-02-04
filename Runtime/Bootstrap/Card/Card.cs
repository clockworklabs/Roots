using RishUI;

namespace Roots
{
    public partial class Card : RishElement<CardProps>
    {
        protected override Element Render() => Div.Create(descriptor: Props.descriptor + "card", children: Props.children);
    }

    [RishValueType]
    public struct CardProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
    }
}
