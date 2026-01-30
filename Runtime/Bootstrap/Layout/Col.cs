using RishUI;

namespace Roots.Bootstrap
{
    public partial class Col : RishElement<ColProps>
    {
        protected override Element Render() => Stack.Create(
            descriptor: Props.descriptor,
            direction: Stack.Direction.Vertical,
            gap: Props.gap,
            children: Props.children);
    }

    [RishValueType]
    public struct ColProps
    {
        public float gap;
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
    }
}
