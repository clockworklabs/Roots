using System;
using RishUI;
using RishUI.Elements;

namespace Roots.Rootstrap
{
    public partial class H4 : RishElement<H4Props>
    {
        protected override Element Render() => Label.Create(
            attributes: Props.attributes + "h4",
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
        [Expand]
        public VisualAttributes attributes;
        public RishString text;
        
        public LengthRange? widthRange;
        public LengthRange? heightRange;

        [DefaultValue(true)]
        public bool enableRichText;
        [DefaultValue(true)]
        public bool parseEscapeSequences;

        public Action<bool> onElided;
    }
}