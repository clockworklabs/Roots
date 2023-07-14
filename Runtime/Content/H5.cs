using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class H5 : RishElement<H5Props>
    {
        protected override Element Render() => Label.Create(className: "h5", text: Props.text);
    }

    [RishValueType]
    public struct H5Props
    {
        public FixedString4096Bytes text;
    }
}