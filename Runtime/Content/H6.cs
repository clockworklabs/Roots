using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H6 : RishElement<H6Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor + "h6";
            
            return Label.Create(
                descriptor: descriptor,
                text: Props.text,
                enableRichText: Props.enableRichText,
                parseEscapeSequences: Props.parseEscapeSequences);
        }
    }

    [RishValueType]
    public struct H6Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static PProps Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}