using RishUI;

namespace Roots.Rootstrap
{
    public partial class CardHeader : RishElement<CardHeaderProps>
    {
        protected override Element Render()
        {
            var descriptor = new VisualAttributes(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-header"
                }
            };

            return Div.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ children: Props.children);
        }
    }

    [RishValueType]
    public struct CardHeaderProps
    {
        [Expand]
        public VisualAttributes descriptor;
        // public Utilities utilities;
        public Children children;
    }
}
