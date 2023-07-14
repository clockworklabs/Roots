using RishUI;
using RishUI.Elements;
using Unity.Collections;

namespace Roots
{
    public partial class P : RishElement<PProps>
    {
        protected override Element Render() => Label.Create(className: "p", text: Props.text);
    }

    [RishValueType]
    public struct PProps
    {
        public FixedString4096Bytes text;
    }
}