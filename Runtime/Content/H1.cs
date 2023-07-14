using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class H1 : RishElement<H1Props>
    {
        protected override Element Render() => Label.Create(className: "h1", text: Props.text);
    }

    [RishValueType]
    public struct H1Props
    {
        public FixedString4096Bytes text;
    }
}