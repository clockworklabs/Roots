using RishUI;

namespace Roots
{
    public partial class Col : RishElement<ColProps>
    {
        protected override Element Render() => Stack.Create(
            descriptor: Props.descriptor,
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
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
        public Element separator;
    }
}
