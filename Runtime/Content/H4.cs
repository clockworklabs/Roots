using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class H4 : RishElement<H4Props>
    {
        protected override Element Render() => Label.Create(className: "h4", text: Props.text);
    }

    [RishValueType]
    public struct H4Props
    {
        public FixedString4096Bytes text;
    }
}