using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H1 : RishElement<H1Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor + "h1";
            
            return Label.Create(
                descriptor: descriptor,
                text: Props.text,
                enableRichText: Props.enableRichText,
                parseEscapeSequences: Props.parseEscapeSequences);
        }
    }

    [RishValueType]
    public struct H1Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static H1Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}