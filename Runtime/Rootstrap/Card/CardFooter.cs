using RishUI;

namespace Roots.Rootstrap
{
    public partial class CardFooter : RishElement<CardFooterProps>
    {
        protected override Element Render()
        {
            var attributes = new VisualAttributes(Props.attributes)
            {
                className = new ClassName(Props.attributes.className)
                {
                    "card-footer"
                }
            };

            return Div.Create(attributes: attributes, /*utilities: Props.utilities,*/ children: Props.children);
        }
    }

    [RishValueType]
    public struct CardFooterProps
    {
        [Expand]
        public VisualAttributes attributes;
        // public Utilities utilities;
        public Children children;
    }
}
