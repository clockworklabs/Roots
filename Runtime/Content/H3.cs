using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class H3 : RishElement<H3Props>
    {
        protected override Element Render() => Label.Create(className: "h3", text: Props.text);
    }

    [RishValueType]
    public struct H3Props
    {
        public FixedString4096Bytes text;
    }
}