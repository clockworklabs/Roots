using RishUI;

namespace Roots.Experimental.Rootstrap
{
    public partial class VScrollView : RishElement<VScrollViewProps>
    {
        protected override Element Render() => SimpleScrollView.Create(
            name: Props.attributes.name,
            className: Props.attributes.className,
            style: Props.attributes.style,
            direction: SimpleScrollView.Direction.Vertical,
            inverted: Props.inverted,
            gap: Props.gap,
            mouseWheelMultiplier: Props.mouseWheelMultiplier,
            elementsSize: Props.elementsSize,
            alwaysMountedIndices: Props.alwaysMountedIndices,
            children: Props.children);
    }

    [RishValueType]
    public struct VScrollViewProps
    {
        [Expand]
        public VisualAttributes attributes;
        
        public bool inverted;
        public int gap;
        
        public float? mouseWheelMultiplier;
        public float? elementsSize;
        
        public RishList<int> alwaysMountedIndices;
        public Children children;
    }
}
