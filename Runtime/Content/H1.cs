using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H1 : RishElement<H1Props>
    {
        protected override Element Render() => Div.Create(className: "h1", utilities: Props.utilities, children: Props.children);
        
        public static Element Create(string text) => Create(0, Utilities.None, text);
        public static Element Create(ulong key, string text) => Create(key, Utilities.None, text);
        public static Element Create(Utilities utilities, string text) => Create(0, utilities, text);
        public static Element Create(ulong key, Utilities utilities, string text) => Create(key, new H1Props
        {
            utilities = utilities,
            children = Label.Create(text: text)
        });
    }

    [RishValueType]
    public struct H1Props
    {
        public Utilities utilities;
        public Children children;
    }
}