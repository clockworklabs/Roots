using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class H6 : RishElement<H6Props>
    {
        protected override Element Render() => Label.Create(className: "h6", text: Props.text);
    }

    [RishValueType]
    public struct H6Props
    {
        public FixedString4096Bytes text;
    }
}