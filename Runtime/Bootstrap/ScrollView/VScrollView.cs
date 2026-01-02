using RishUI;

namespace Roots.Bootstrap
{
    public partial class VScrollView : RishElement<VScrollViewProps>
    {
        protected override Element Render() => SimpleScrollView.Create(
            name: Props.descriptor.name,
            className: Props.descriptor.className,
            style: Props.descriptor.style,
            direction: SimpleScrollView.Direction.Vertical,
            inverted: Props.inverted,
            gap: Props.gap,
            mouseWheelSensitivity: Props.mouseWheelSensitivity,
            elementsSize: Props.elementsSize,
            alwaysMountedIndices: Props.alwaysMountedIndices,
            children: Props.children);
    }

    [RishValueType]
    public struct VScrollViewProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        
        public bool inverted;
        public int gap;
        
        public float mouseWheelSensitivity;
        public float? elementsSize;
        
        public RishList<int> alwaysMountedIndices;
        public Children children;
    }
}
