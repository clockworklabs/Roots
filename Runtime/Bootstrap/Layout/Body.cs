using RishUI;

namespace Roots.Bootstrap
{
    public partial class Body : RishElement<BodyProps>
    {
        protected override Element Render() => Div.Create(descriptor: Props.descriptor + "body", children: Props.children);
    }

    [RishValueType]
    public struct BodyProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        
        public Children children;
    }
}
