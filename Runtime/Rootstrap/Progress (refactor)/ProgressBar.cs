using RishUI;

namespace Roots.Rootstrap
{
    public partial class ProgressBar : RishElement<ProgressBarProps>
    {
        protected override Element Render() => Div.Create(attributes: Props.attributes + "progress-bar", children: Props.children);
    }

    [RishValueType]
    public struct ProgressBarProps
    {
        [Expand]
        public VisualAttributes attributes;
        public Children children;
    }
}
