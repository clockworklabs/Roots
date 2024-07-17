using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H2 : RishElement<H2Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor + "h2";
            
            return Label.Create(
                descriptor: descriptor,
                text: Props.text,
                enableRichText: Props.enableRichText,
                parseEscapeSequences: Props.parseEscapeSequences);
        }
    }

    [RishValueType]
    public struct H2Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static H2Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}