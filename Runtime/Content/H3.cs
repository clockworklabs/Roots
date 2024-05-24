using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H3 : RishElement<H3Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "h3"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text);
        }
    }

    [RishValueType]
    public struct H3Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;
    }
}