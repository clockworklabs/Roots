using RishUI;

namespace Roots
{
    public partial class Row : RishElement<RowProps>
    {
        protected override Element Render() => Stack.Create(
            descriptor: Props.descriptor,
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
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
        public Element separator;
    }
}