using RishUI;

namespace Roots
{
    public partial class Body : RishElement<BodyProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName {
                descriptor.className,
                "body"
            };
            
            return Div.Create(descriptor, utilities: Props.utilities, children: Props.children);
        }
    }

    [RishValueType]
    public struct BodyProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        
        public Children children;
    }
}
