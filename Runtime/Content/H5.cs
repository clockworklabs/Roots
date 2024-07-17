using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H5 : RishElement<H5Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor + "h5";
            
            return Label.Create(
                descriptor: descriptor,
                text: Props.text,
                enableRichText: Props.enableRichText,
                parseEscapeSequences: Props.parseEscapeSequences);
        }
    }

    [RishValueType]
    public struct H5Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public RishString text;

        public bool enableRichText;
        public bool parseEscapeSequences;

        [Default]
        private static H5Props Default => new()
        {
            enableRichText = true,
            parseEscapeSequences = true
        };
    }
}