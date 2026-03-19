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
    public struct VScrollViewProps
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