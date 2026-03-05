using RishUI;

namespace Roots.Rootstrap
{
    public partial class ProgressBar : RishElement<ProgressBarProps>
    {
        protected override Element Render() => Div.Create(Props.descriptor + "progress-bar", children: Props.children);
    }

    [RishValueType]
    public struct ProgressBarProps
    {
        [Expand]
        public VisualAttributes descriptor;
        public Children children;
    }
}
