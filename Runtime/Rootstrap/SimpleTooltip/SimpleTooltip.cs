using RishUI;

namespace Roots.Rootstrap
{
    public partial class SimpleTooltip : RishElement<SimpleTooltipProps>
    {
        protected override Element Render() => Tooltip.Create(
            tooltip: Div.Create(
                className: "simple-tooltip",
                children: Div.Create(children: Props.tooltip)),
            content: Props.content);
    }

    [RishValueType]
    public struct SimpleTooltipProps
    {
        public RishString tooltip;
        public Element content;
    }
}
