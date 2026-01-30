using RishUI;

namespace Roots.Bootstrap
{
    public partial class Row : RishElement<RowProps>
    {
        protected override Element Render() => Stack.Create(
            descriptor: Props.descriptor,
            direction: Stack.Direction.Horizontal,
            gap: Props.gap,
            children: Props.children);
    }

    [RishValueType]
    public struct RowProps
    {
        public float gap;
        public bool wrap; // TODO
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
    }
}