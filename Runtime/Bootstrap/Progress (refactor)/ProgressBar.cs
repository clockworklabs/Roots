using RishUI;

namespace Roots.Bootstrap
{
    public partial class ProgressBar : RishElement<ProgressBarProps>
    {
        protected override Element Render() => Div.Create(Props.descriptor + "progress-bar", children: Props.children);
    }

    [RishValueType]
    public struct ProgressBarProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
    }
}
