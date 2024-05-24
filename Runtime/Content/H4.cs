using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H4 : RishElement<H4Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "h4"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text);
        }
    }

    [RishValueType]
    public struct H4Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;
    }
}