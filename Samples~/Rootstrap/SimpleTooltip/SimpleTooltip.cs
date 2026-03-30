using RishUI;

namespace Roots.Rootstrap
{
    public partial class SimpleTooltip : RishElement<SimpleTooltipProps>
    {
        protected override Element Render() => Tooltip.Create(
            tooltip: Div.Create(
                className: "simple-tooltip",
                children: Body.Create(text: Props.tooltip)),
            enterDelay: 0.3f,
            exitDelay: 0.15f,
            content: Props.content);
    }

    [RishValueType]
    public struct SimpleTooltipProps
    {
        public RishString tooltip;
        public Element content;
    }
}
