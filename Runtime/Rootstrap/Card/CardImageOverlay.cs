using RishUI;

namespace Roots.Bootstrap
{
    public partial class CardImageOverlay : RishElement<CardImageOverlayProps>
    {
        protected override Element Render()
        {
            var descriptor = new DOMDescriptor(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-img-overlay"
                }
            };
            
            return Div.Create(descriptor, /*utilities: Props.utilities,*/ children: Props.children);

        }
    }

    [RishValueType]
    public struct CardImageOverlayProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public Children children;
    }
}
