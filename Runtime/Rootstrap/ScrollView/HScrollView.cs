using RishUI;

namespace Roots.Experimental.Rootstrap
{
    public partial class HScrollView : RishElement<HScrollViewProps>
    {
        protected override Element Render() => SimpleScrollView.Create(
            attributes: Props.attributes,
            direction: SimpleScrollView.Direction.Vertical,
            inverted: Props.inverted,
            gap: Props.gap,
            mouseWheelMultiplier: Props.mouseWheelMultiplier,
            elementsSize: Props.elementsSize,
            alwaysMountedIndices: Props.alwaysMountedIndices,
            children: Props.children);
    }

    [RishValueType]
    public struct HScrollViewProps
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
