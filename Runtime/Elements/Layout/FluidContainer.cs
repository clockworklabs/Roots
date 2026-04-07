using RishUI;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class FluidContainer : RishElement<FluidContainerProps>
    {
        protected override Element Render() => Div.Create(
            attributes: Props.attributes + new Style
            {
                width = Length.Percent(100),
                marginLeft = Length.Auto(),
                marginRight = Length.Auto(),
            },
            children: Props.content);
    }

    [RishValueType]
    public struct FluidContainerProps
    {
        [Expand]
        public VisualAttributes attributes;
        public Element content;
    }
}
