using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class Col : RishElement<ColProps>
    {
        protected override Element Render()
        {
            var xsSet = Props.xs.IsSet;
            var smSet = Props.sm.IsSet;
            var mdSet = Props.md.IsSet;
            var lgSet = Props.lg.IsSet;
            var xlSet = Props.xl.IsSet;
            var xxlSet = Props.xxl.IsSet;
            
            if (!xsSet && !smSet && !mdSet && !lgSet && !xlSet && !xxlSet)
            {
                return Div.Create(className: "col", children: Props.children);
            }

            return Div.Create(className: (Props.xs.GetClassName(null), Props.sm.GetClassName("sm"), Props.md.GetClassName("md"), Props.lg.GetClassName("lg"), Props.xl.GetClassName("xl"), Props.xxl.GetClassName("xxl")), children: Props.children);
        }
    }

    public struct ColSize
    {
        public int count;
        public int grid;

        public static implicit operator ColSize(int count) => new ColSize
        {
            count = count,
            grid = 12
        };
        public static implicit operator ColSize((int count, int grid) size) => new ColSize
        {
            count = size.count,
            grid = size.grid
        };
        public static implicit operator ColSize(bool set) => new ColSize
        {
            count = set ? -1 : 0
        };

        public static ColSize Row => new ColSize
        {
            count = 1,
            grid = 1
        };

        public static ColSize Grid2(int count) => (count, 2);
        public static ColSize Grid3(int count) => (count, 3);
        public static ColSize Grid4(int count) => (count, 4);
        public static ColSize Grid5(int count) => (count, 5);
        public static ColSize Grid6(int count) => (count, 6);
        public static ColSize Grid7(int count) => (count, 7);
        public static ColSize Grid8(int count) => (count, 8);
        public static ColSize Grid9(int count) => (count, 9);
        public static ColSize Grid10(int count) => (count, 10);
        public static ColSize Grid11(int count) => (count, 11);
        public static ColSize Grid12(int count) => (count, 12);
        public static ColSize Grid24(int count) => (count, 24);

        internal bool IsSet => grid is >= 0 and <= 12 or 24 && count < 0 && grid == 0 || count > 0 && grid >= count;

        internal string GetClassName(string breakpoint)
        {
            if (!IsSet)
            {
                return string.Empty;
            }

            var col = string.IsNullOrWhiteSpace(breakpoint) ? "col" : $"col-{breakpoint}";

            return count > 0 ? $"{col}-{count}-{grid}" : col;
        }
    }

    [RishValueType]
    public struct ColProps
    {
        public ColSize xs;
        public ColSize sm;
        public ColSize md;
        public ColSize lg;
        public ColSize xl;
        public ColSize xxl;

        public Utilities utilities;
        public Children children;
    }
}
