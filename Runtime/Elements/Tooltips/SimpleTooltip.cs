using RishUI;
using Unity.Collections;

namespace Roots
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
        public FixedString4096Bytes tooltip;
        public Element content;
    }
}
