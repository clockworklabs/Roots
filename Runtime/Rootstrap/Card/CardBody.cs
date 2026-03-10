using RishUI;

namespace Roots.Rootstrap
{
    public partial class CardBody : RishElement<CardBodyProps>
    {
        protected override Element Render()
        {
            var attributes = new VisualAttributes(Props.attributes)
            {
                className = new ClassName(Props.attributes.className)
                {
                    "card-body"
                }
            };
            
            return Div.Create(attributes: attributes, children: Props.children);

        }
    }

    [RishValueType]
    public struct CardBodyProps
    {
        [Expand]
        public VisualAttributes attributes;
        public Children children;
    }
}
