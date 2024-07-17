using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H3 : RishElement<H3Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor + "h3";
            
            return Label.Create(
                descriptor: descriptor,
                text: Props.text,
                enableRichText: Props.enableRichText,
                parseEscapeSequences: Props.parseEscapeSequences);
        }
    }

    [RishValueType]
    public struct H3Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static H3Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}