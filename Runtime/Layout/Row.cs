using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class Row : RishElement<RowProps>
    {
        protected override Element Render() => Div.Create(className: ("row", Props.xsClassName, Props.smClassName, Props.mdClassName, Props.lgClassName, Props.xlClassName, Props.xxlClassName), children: Props.children);
    }

    // public struct Gutter
    // {
    //     public int? x;
    //     public int? y;
    //
    //     public Gutter(int value)
    //     {
    //         x = value;
    //         y = value;
    //     }
    //     public Gutter(int x, int y)
    //     {
    //         this.x = x;
    //         this.y = y;
    //     }
    //     
    //     public static implicit operator Gutter(int value) => new Gutter(value);
    //     public static implicit operator Gutter((int x, int y) value) => new Gutter(value.x, value.y);
    //
    //     public static Gutter X(int x) => new Gutter
    //     {
    //         x = x
    //     };
    //     public static Gutter Y(int y) => new Gutter
    //     {
    //         y = y
    //     };
    //
    //     internal string GetClassName(string breakpoint) => x == y ? GetClassName(breakpoint, "g", x) : string.Empty;
    //     internal string GetXClassName(string breakpoint) => x != y ? GetClassName(breakpoint, "gx", x) : string.Empty;
    //     internal string GetYClassName(string breakpoint) => x != y ? GetClassName(breakpoint, "gy", y) : string.Empty;
    //
    //     private string GetClassName(string breakpoint, string prefix, int? value)
    //     {
    //         if (!value.HasValue)
    //         {
    //             return string.Empty;
    //         }
    //         var v = value.Value;
    //         if (v is < 0 or > 5)
    //         {
    //             return string.Empty;
    //         }
    //
    //         var g = string.IsNullOrWhiteSpace(breakpoint) ? prefix : $"{prefix}-{breakpoint}";
    //
    //         return $"{g}-{v}";
    //     }
    // }

    [RishValueType]
    public struct RowProps
    {
        public int xs;
        public int sm;
        public int md;
        public int lg;
        public int xl;
        public int xxl;
        // public Gutter xsGutter;
        // public Gutter smGutter;
        // public Gutter mdGutter;
        // public Gutter lgGutter;
        // public Gutter xlGutter;
        // public Gutter xxlGutter;
        public Children children;

        internal string xsClassName => GetColsClassName(xs);
        internal string smClassName => GetColsClassName(sm, "sm");
        internal string mdClassName => GetColsClassName(md, "md");
        internal string lgClassName => GetColsClassName(lg, "lg");
        internal string xlClassName => GetColsClassName(xl, "xl");
        internal string xxlClassName => GetColsClassName(xxl, "xxl");

        private static string GetColsClassName(int value, string breakpoint = null)
        {
            if (value is < 0 or > 24 or > 12 and < 24)
            {
                return string.Empty;
            }

            var rowCols = string.IsNullOrWhiteSpace(breakpoint) ? "row-cols" : $"row-cols-{breakpoint}";

            return $"{rowCols}-{value}";
        }
    }
}
