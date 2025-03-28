using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class P : RishElement<PProps>
    {
        protected override Element Render() => Label.Create(
            descriptor: Props.descriptor + "p",
            text: Props.text,
            widthRange: Props.widthRange,
            heightRange: Props.heightRange,
            enableRichText: Props.enableRichText,
            parseEscapeSequences: Props.parseEscapeSequences);
    }

    [RishValueType]
    public struct PProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public RishString text;
        
        public LengthRange? widthRange;
        public LengthRange? heightRange;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static PProps Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}