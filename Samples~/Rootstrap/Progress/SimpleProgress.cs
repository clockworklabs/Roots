using Motion;
using RishUI;

namespace Roots.Rootstrap
{
    public partial class SimpleProgress : RishElement<SimpleProgressProps>
    {
        protected override Element Render() => StackedProgress.Create(
            attributes: Props.attributes,
            animated: Props.animated,
            spring: Props.spring,
            tween: Props.tween,
            color: Props.color,
            size: Props.size,
            total: Props.total,
            values: new ProgressBar(value: Props.value, label: Props.label));
    }

    [RishValueType]
    public struct SimpleProgressProps
    {
        [Expand]
        public VisualAttributes attributes;

        [DefaultValue(true)]
        public bool animated;
        
        public Spring? spring;
        public Tween? tween;

        public ProgressColor color;
        public ProgressSize size;
        
        [DefaultValue(1)]
        public float total;

        public float value;
        public RishString label;
    }
}
