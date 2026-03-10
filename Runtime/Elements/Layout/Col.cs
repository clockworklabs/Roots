using RishUI;

namespace Roots
{
    public partial class Col : RishElement<ColProps>
    {
        protected override Element Render() => Stack.Create(
            attributes: Props.attributes,
            direction: Stack.Direction.Vertical,
            reverse: Props.reverse,
            gap: Props.gap,
            children: Props.children,
            separator: Props.separator);
    }

    [RishValueType]
    public struct ColProps
    {
        public float gap;
        public bool reverse;
        [Expand]
        public VisualAttributes attributes;
        public Children children;
        public Element separator;
    }
}
