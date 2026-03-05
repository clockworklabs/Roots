using RishUI;

namespace Roots.Rootstrap
{
    public partial class CardFooter : RishElement<CardFooterProps>
    {
        protected override Element Render()
        {
            var descriptor = new VisualAttributes(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-footer"
                }
            };

            return Div.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ children: Props.children);
        }
    }

    [RishValueType]
    public struct CardFooterProps
    {
        [Expand]
        public VisualAttributes descriptor;
        // public Utilities utilities;
        public Children children;
    }
}
