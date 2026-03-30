using System;
using RishUI;
using RishUI.Elements;

namespace Roots.Rootstrap
{
    public partial class Body : RishElement<PProps>
    {
        protected override Element Render() => Label.Create(
            attributes: Props.attributes + "body",
            text: Props.text,
            widthRange: Props.widthRange,
            heightRange: Props.heightRange,
            enableRichText: Props.enableRichText,
            parseEscapeSequences: Props.parseEscapeSequences,
            onElided: SappyProps.OnElided);
    }

    [RishValueType]
    public struct PProps
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