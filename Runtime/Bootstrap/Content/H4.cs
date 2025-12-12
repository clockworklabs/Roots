using System;
using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H4 : RishElement<H4Props>
    {
        protected override Element Render() => Label.Create(
            descriptor: Props.descriptor + "h4",
            text: Props.text,
            widthRange: Props.widthRange,
            heightRange: Props.heightRange,
            enableRichText: Props.enableRichText,
            parseEscapeSequences: Props.parseEscapeSequences,
            onElided: SappyProps.OnElided);
    }

    [RishValueType]
    public struct H4Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public RishString text;
        
        public LengthRange? widthRange;
        public LengthRange? heightRange;

        public bool enableRichText;
        public bool parseEscapeSequences;

        public Action<bool> onElided;

        [Default]
        private static H4Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}