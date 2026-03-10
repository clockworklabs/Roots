using RishUI;

namespace Roots.Rootstrap
{
    public partial class Progress : RishElement<ProgressProps>
    {
        protected override Element Render() => Div.Create(
            attributes: Props.attributes + new ClassName
            {
                "progress",
                Props.animated ? "animated" : string.Empty
            },
            children: Props.children);
    }

    [RishValueType]
    public struct ProgressProps
    {
        [Expand]
        public VisualAttributes attributes;

        public bool animated;

        public Children children;
    }
}
