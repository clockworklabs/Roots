using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class P : RishElement<PProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "p"
            };
            
            return Label.Create(descriptor: descriptor, /*utilities: Props.utilities,*/ text: Props.text);
        }
    }

    [RishValueType]
    public struct PProps
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