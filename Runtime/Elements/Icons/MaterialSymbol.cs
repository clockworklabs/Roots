using RishUI;

namespace Roots
{
    public partial class MaterialSymbol : RishElement<MaterialSymbolsProps>
    {
        public enum Style { Outlined, Rounded, Sharp }
        public enum Size { Pt20, Pt24, Pt40, Pt48 }

        protected override Element Render() => $"<style=ms>{Props.symbol}</style>";
    }

    [RishValueType]
    public struct MaterialSymbolsProps
    {
        public MaterialSymbol.Style style;
        public MaterialSymbol.Size size;
        public bool fill;
        public int? points;

        public string symbol;
    }
}
