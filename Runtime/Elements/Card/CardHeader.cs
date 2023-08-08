using RishUI;

namespace Roots
{
    public partial class CardHeader : RishElement<CardHeaderProps>
    {
        protected override Element Render()
        {
            var descriptor = new DOMDescriptor(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-header"
                }
            };

            return Div.Create(descriptor: descriptor, utilities: Props.utilities, children: Props.children);
        }
    }

    [RishValueType]
    public struct CardHeaderProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        public Children children;
    }
}
