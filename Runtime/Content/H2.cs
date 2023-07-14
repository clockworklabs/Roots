using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class H2 : RishElement<H2Props>
    {
        protected override Element Render() => Label.Create(className: "h2", text: Props.text);
    }

    [RishValueType]
    public struct H2Props
    {
        public FixedString4096Bytes text;
    }
}