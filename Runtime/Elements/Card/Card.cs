using RishUI;

namespace Roots
{
    public partial class Card : RishElement<CardProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className)
            {
                "card"
            };
            
            return Div.Create(descriptor, utilities: Props.utilities, children: Props.children);

        }
    }

    [RishValueType]
    public struct CardProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        public Children children;
    }
}
