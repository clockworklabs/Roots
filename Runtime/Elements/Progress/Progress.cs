using RishUI;

namespace Roots
{
    public partial class Progress : RishElement<ProgressProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className)
            {
                "progress",
                Props.animated ? "animated" : string.Empty
            };
            
            return Div.Create(descriptor, utilities: Props.utilities, children: Props.children);

        }
    }

    [RishValueType]
    public struct ProgressProps
    {
        public bool animated;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        public Children children;
    }
}
