using RishUI;

namespace Roots
{
    public partial class ProgressBar : RishElement<ProgressBarProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className)
            {
                "progress-bar"
            };
            
            return Div.Create(descriptor, utilities: Props.utilities, children: Props.children);

        }
    }

    [RishValueType]
    public struct ProgressBarProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        public Children children;
    }
}
