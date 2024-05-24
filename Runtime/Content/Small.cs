using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class Small : RishElement<SmallProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "small"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text);
        }
    }

    [RishValueType]
    public struct SmallProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;
    }
}