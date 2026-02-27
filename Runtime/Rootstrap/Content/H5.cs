using System;
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
            parseEscapeSequences: Props.parseEscapeSequences,
            onElided: SappyProps.OnElided);
    }

    [RishValueType]
    public struct H5Props
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
        private static H5Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}