using RishUI;

namespace Roots.Bootstrap
{
    public partial class CardImageOverlay : RishElement<CardImageOverlayProps>
    {
        protected override Element Render()
        {
            var descriptor = new VisualAttributes(Props.descriptor)
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
        [Expand]
        public VisualAttributes descriptor;
        // public Utilities utilities;
        public Children children;
    }
}
