using RishUI;

namespace Roots.Rootstrap
{
    public partial class CardHeader : RishElement<CardHeaderProps>
    {
        protected override Element Render()
        {
            var attributes = new VisualAttributes(Props.attributes)
            {
                className = new ClassName(Props.attributes.className)
                {
                    "card-header"
                }
            };

            return Div.Create(attributes: attributes, /*utilities: Props.utilities,*/ children: Props.children);
        }
    }

    [RishValueType]
    public struct CardHeaderProps
    {
        [Expand]
        public VisualAttributes attributes;
        // public Utilities utilities;
        public Children children;
    }
}
