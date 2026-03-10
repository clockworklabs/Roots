using RishUI;

namespace Roots.Rootstrap
{
    public partial class CardImageOverlay : RishElement<CardImageOverlayProps>
    {
        protected override Element Render()
        {
            var attributes = new VisualAttributes(Props.attributes)
            {
                className = new ClassName(Props.attributes.className)
                {
                    "card-img-overlay"
                }
            };
            
            return Div.Create(attributes: attributes, children: Props.children);

        }
    }

    [RishValueType]
    public struct CardImageOverlayProps
    {
        [Expand]
        public VisualAttributes attributes;
        public Children children;
    }
}
