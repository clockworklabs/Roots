using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class Stack : RishElement<StackProps>
    {
        protected override Element Render()
        {
            return Div.Create(className: (Props.stackClassName, Props.xsGapClassName, Props.smGapClassName, Props.mdGapClassName, Props.lgGapClassName, Props.xlGapClassName, Props.xxlGapClassName), children: Props.children);
        }
    }
    
    public enum StackDirection { Vertical, Horizontal }

    [RishValueType]
    public struct StackProps
    {
        public StackDirection direction;
        public int? gap;
        public int? smGap;
        public int? mdGap;
        public int? lgGap;
        public int? xlGap;
        public int? xxlGap;
        public Children children;

        private bool IsVertical => direction == StackDirection.Vertical;

        internal string stackClassName => IsVertical ? "vstack" : "hstack";
        internal string xsGapClassName => gap.HasValue ? GetGapClassName(gap.Value) : string.Empty;
        internal string smGapClassName => smGap.HasValue ? GetGapClassName(smGap.Value, "sm") : string.Empty;
        internal string mdGapClassName => mdGap.HasValue ? GetGapClassName(mdGap.Value, "md") : string.Empty;
        internal string lgGapClassName => lgGap.HasValue ? GetGapClassName(lgGap.Value, "lg") : string.Empty;
        internal string xlGapClassName => xlGap.HasValue ? GetGapClassName(xlGap.Value, "xl") : string.Empty;
        internal string xxlGapClassName => xxlGap.HasValue ? GetGapClassName(xxlGap.Value, "xxl") : string.Empty;

        private string GetGapClassName(int value, string breakpoint = null)
        {
            if (value is < 0 or > 5)
            {
                return string.Empty;
            }

            var gap = string.IsNullOrWhiteSpace(breakpoint) ? "gap" : $"gap-{breakpoint}";

            return $"{(IsVertical ? "column-" : "row-")}{gap}-{value}";
        }
    }
}
