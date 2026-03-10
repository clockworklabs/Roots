using RishUI;

namespace Roots
{
    public partial class Row : RishElement<RowProps>
    {
        protected override Element Render() => Stack.Create(
            attributes: Props.attributes,
            direction: Stack.Direction.Horizontal,
            reverse: Props.reverse,
            gap: Props.gap,
            children: Props.children,
            separator: Props.separator);
    }

    [RishValueType]
    public struct RowProps
    {
        public float gap;
        public bool reverse;
        [Expand]
        public VisualAttributes attributes;
        public Children children;
        public Element separator;
    }
}