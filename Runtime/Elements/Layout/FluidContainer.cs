using RishUI;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class FluidContainer : RishElement<FluidContainerProps>
    {
        protected override Element Render() => Div.Create(
            descriptor: Props.descriptor + new Style
            {
                maxWidth = Length.Percent(100),
                marginLeft = Length.Auto(),
                marginRight = Length.Auto(),
            },
            children: Props.children);
    }

    [RishValueType]
    public struct FluidContainerProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
    }
}
