using RishUI;

namespace Roots.Bootstrap
{
    public partial class Progress : RishElement<ProgressProps>
    {
        protected override Element Render() => Div.Create(
            descriptor: Props.descriptor + new ClassName
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
        public VisualAttributes descriptor;

        public bool animated;

        public Children children;
    }
}
