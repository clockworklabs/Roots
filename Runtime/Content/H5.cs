using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H5 : RishElement<H5Props>
    {
        protected override Element Render() => Label.Create(
            descriptor: Props.descriptor + "h5",
            text: Props.text,
            widthRange: Props.widthRange,
            heightRange: Props.heightRange,
            enableRichText: Props.enableRichText,
            parseEscapeSequences: Props.parseEscapeSequences);
    }

    [RishValueType]
    public struct H5Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public RishString text;
        
        public LengthRange? widthRange;
        public LengthRange? heightRange;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static H5Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}