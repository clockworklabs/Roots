using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class P : RishElement<PProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "p"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text.Value);
        }
    }

    [RishValueType]
    public struct PProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public FixedString4096Bytes text;
    }
}