using RishUI;

namespace Roots
{
    public partial class CardBody : RishElement<CardBodyProps>
    {
        protected override Element Render()
        {
            var descriptor = new DOMDescriptor(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-body"
                }
            };
            
            return Div.Create(descriptor, /*utilities: Props.utilities,*/ children: Props.children);

        }
    }

    [RishValueType]
    public struct CardBodyProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public Children children;
    }
}
