using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class Body : RishElement<BodyProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = ((ClassName)"body").Add(descriptor.className);
            
            return Div.Create(descriptor, Props.children);
        }
    }

    [RishValueType]
    public struct BodyProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        
        public Children children;
    }
}
