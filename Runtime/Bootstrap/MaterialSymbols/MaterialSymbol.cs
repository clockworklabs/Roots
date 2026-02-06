using RishUI;
using RishUI.Elements;

namespace Roots.Bootstrap
{
    public partial class MaterialSymbol : RishElement<MaterialSymbolProps>
    {
        public enum Style { Outlined, Rounded, Sharp }
        public enum Weight { Thin, ExtraLight, Light, Regular, Medium, SemiBold, Bold }

        protected override Element Render() => Label.Create(descriptor: Props.descriptor + "material-symbol", text: Factory(Props.unicode, Props.symbolStyle, Props.weight, Props.opticalSize, Props.filled));

        public static string Outlined(char unicode, Weight? weight = null, int? opticalSize = null, bool filled = false) => Factory(unicode, Style.Outlined, weight, opticalSize, filled);
        public static string Rounded(char unicode, Weight? weight = null, int? opticalSize = null, bool filled = false) => Factory(unicode, Style.Rounded, weight, opticalSize, filled);
        public static string Sharp(char unicode, Weight? weight = null, int? opticalSize = null, bool filled = false) => Factory(unicode, Style.Sharp, weight, opticalSize, filled);

        private static string Factory(char unicode, Style style, Weight? weight = null, int? opticalSize = null, bool filled = false)
        {
            var fontFamily = style switch
            {
                Style.Outlined => "MaterialSymbols/Outlined",
                Style.Rounded => "MaterialSymbols/Rounded",
                Style.Sharp => "MaterialSymbols/Sharp"
            };
            var font = opticalSize is null or < 28
                ? $"{fontFamily}/Regular SDF"
                : opticalSize < 36
                    ? $"{fontFamily}/28pt-Regular SDF"
                    : opticalSize < 48
                        ? $"{fontFamily}/36pt-Regular SDF"
                        : $"{fontFamily}/48pt-Regular SDF";
            weight ??= Weight.Regular;
            var fontWeight = weight switch
            {
                Weight.Thin => 100,
                Weight.ExtraLight => 200,
                Weight.Light => 300,
                Weight.Regular => 400,
                Weight.Medium => 500,
                Weight.SemiBold => 600,
                Weight.Bold => 700
            };
            var openingTags = $"<font={font}><font-weight={fontWeight}>";
            var closingTags = "</font-weight></font>";
            if (filled)
            {
                openingTags = $"{openingTags}<i>";
                closingTags = $"</i>{closingTags}";
            }
            return $"{openingTags}{unicode}{closingTags}";
        }
    }

    [RishValueType]
    public struct MaterialSymbolProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public char unicode;
        public MaterialSymbol.Style symbolStyle;
        public MaterialSymbol.Weight? weight;
        public int? opticalSize;
        public bool filled;
    }
}