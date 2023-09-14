using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class H2 : RishElement<H2Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "h2"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text.Value);
        }
    }

    [RishValueType]
    public struct H2Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public FixedString4096Bytes text;
    }
}