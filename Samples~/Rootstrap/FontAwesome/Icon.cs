using RishUI;
using RishUI.Elements;

namespace Roots.Rootstrap
{
    public enum FontAwesomeStyle { Regular, Solid, Brands }

    public partial class Icon : RishElement<IconProps>
    {
        protected override Element Render()
        {
            var iconData = FontAwesome.GetByUnicode(Props.unicode);
            var style = GetStyle(iconData, Props.fontAwesomeStyle);
            
            return Label.Create(attributes: Props.attributes + "font-awesome-icon", enableRichText: true, text: Factory(Props.unicode, style));
        }

        public static string Regular(FontAwesome.IconData iconData) => Factory(iconData.Unicode, GetStyle(iconData, FontAwesomeStyle.Regular));
        public static string Regular(string unicode) => Factory(unicode, FontAwesomeStyle.Regular);
        public static string Solid(FontAwesome.IconData iconData) => Factory(iconData.Unicode, GetStyle(iconData, FontAwesomeStyle.Solid));
        public static string Solid(string unicode) => Factory(unicode, FontAwesomeStyle.Solid);
        public static string Brands(FontAwesome.IconData iconData) => Factory(iconData.Unicode, GetStyle(iconData, FontAwesomeStyle.Brands));
        public static string Brands(string unicode) => Factory(unicode, FontAwesomeStyle.Brands);

        private static string Factory(string unicode, FontAwesomeStyle style)
        {
            var font = style switch
            {
                FontAwesomeStyle.Regular => "Font Awesome 7 Free-Regular-400 SDF",
                FontAwesomeStyle.Solid => "Font Awesome 7 Free-Solid-900 SDF",
                FontAwesomeStyle.Brands => "Font Awesome 7 Brands-Regular-400 SDF"
            };
            return $"<font={font}>{unicode}</font>";
        }

        private static FontAwesomeStyle GetStyle(FontAwesome.IconData iconData, FontAwesomeStyle? style) =>
            style.HasValue && IsCompatible(iconData, style.Value)
                ? style.Value
                : IsCompatible(iconData, FontAwesomeStyle.Regular)
                    ? FontAwesomeStyle.Regular
                    : IsCompatible(iconData, FontAwesomeStyle.Solid)
                        ? FontAwesomeStyle.Solid
                        : FontAwesomeStyle.Brands;

        private static bool IsCompatible(FontAwesome.IconData iconData, FontAwesomeStyle fontAwesomeStyle) => fontAwesomeStyle switch
        {
            FontAwesomeStyle.Regular => (iconData.Styles & FontAwesome.Styles.Regular) > 0,
            FontAwesomeStyle.Solid => (iconData.Styles & FontAwesome.Styles.Solid) > 0,
            FontAwesomeStyle.Brands => (iconData.Styles & FontAwesome.Styles.Brands) > 0,
        };
    }

    [RishValueType]
    public struct IconProps
    {
        [Expand]
        public VisualAttributes attributes;
        public RishString unicode;
        public FontAwesomeStyle? fontAwesomeStyle;
    }
}