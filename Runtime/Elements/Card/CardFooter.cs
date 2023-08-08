using RishUI;

namespace Roots
{
    public partial class CardFooter : RishElement<CardFooterProps>
    {
        protected override Element Render()
        {
            var descriptor = new DOMDescriptor(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-footer"
                }
            };

            return Div.Create(descriptor: descriptor, utilities: Props.utilities, children: Props.children);
        }
    }

    [RishValueType]
    public struct CardFooterProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        public Children children;
    }
}
