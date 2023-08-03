using System.Collections.Generic;
using RishUI;

namespace Roots
{
    public partial class Stack : RishElement<StackProps>
    {
        private List<Element> Children { get; } = new();
        
        protected override Element Render()
        {
            Children.Clear();
            foreach (var child in Props.children)
            {
                // Children.Add(Div.Create(className: Props.IsVertical ? "flex-column" : "flex-row", children: child));
                Children.Add(child);
            }
            
            return Div.Create(className: (Props.stackClassName, Props.xsGapClassName, Props.smGapClassName, Props.mdGapClassName, Props.lgGapClassName, Props.xlGapClassName, Props.xxlGapClassName), utilities: Props.utilities, children: Children);
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
        public Utilities utilities;
        public Children children;

        internal bool IsVertical => direction == StackDirection.Vertical;

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
