using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H2 : RishElement<H2Props>
    {
        protected override Element Render() => Div.Create(className: "h2", utilities: Props.utilities, children: Props.children);
        
        public static Element Create(string text) => Create(0, Utilities.None, text);
        public static Element Create(ulong key, string text) => Create(key, Utilities.None, text);
        public static Element Create(Utilities utilities, string text) => Create(0, utilities, text);
        public static Element Create(ulong key, Utilities utilities, string text) => Create(key, new H2Props
        {
            utilities = utilities,
            children = Label.Create(text: text)
        });
    }

    [RishValueType]
    public struct H2Props
    {
        public Utilities utilities;
        public Children children;
    }
}