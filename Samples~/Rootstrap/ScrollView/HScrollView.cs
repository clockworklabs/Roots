using RishUI;

namespace Roots.Experimental.Rootstrap
{
    public partial class HScrollView : RishElement<HScrollViewProps>
    {
        protected override Element Render() => SimpleScrollView.Create(
            attributes: Props.attributes,
            direction: SimpleScrollView.Direction.Vertical,
            hideOverflow: Props.hideOverflow,
            inverted: Props.inverted,
            gap: Props.gap,
            interactableScrollBar: Props.interactableScrollBar,
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
        
        [DefaultValue(true)]
        public bool hideOverflow;
        public bool inverted;
        public int gap;
        [DefaultValue(true)]
        public bool interactableScrollBar;
        
        [DefaultValue(30)]
        public float mouseWheelMultiplier;
        public float? elementsSize;
        
        public RishList<int> alwaysMountedIndices;
        public Children children;
    }
}