using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H4 : RishElement<H4Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor + "h4";
            
            return Label.Create(
                descriptor: descriptor,
                text: Props.text,
                enableRichText: Props.enableRichText,
                parseEscapeSequences: Props.parseEscapeSequences);
        }
    }

    [RishValueType]
    public struct H4Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static H4Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}