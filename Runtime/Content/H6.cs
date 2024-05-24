using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H6 : RishElement<H6Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "h6"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text);
        }
    }

    [RishValueType]
    public struct H6Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;
    }
}