using System;
using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H2 : RishElement<H2Props>
    {
        protected override Element Render() => Label.Create(
            descriptor: Props.descriptor + "h2",
            text: Props.text,
            widthRange: Props.widthRange,
            heightRange: Props.heightRange,
            enableRichText: Props.enableRichText,
            parseEscapeSequences: Props.parseEscapeSequences,
            onElided: SappyProps.OnElided);
    }

    [RishValueType]
    public struct H2Props
    {
        [Expand]
        public VisualAttributes descriptor;
        public RishString text;
        
        public LengthRange? widthRange;
        public LengthRange? heightRange;

        public bool enableRichText;
        public bool parseEscapeSequences;

        public Action<bool> onElided;

        [Default]
        private static H2Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}