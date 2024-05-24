using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H1 : RishElement<H1Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "h1"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text);
        }
    }

    [RishValueType]
    public struct H1Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;
    }
}