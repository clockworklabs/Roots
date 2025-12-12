using RishUI;
using UnityEngine.UIElements;

namespace Roots
{
    public static class StyleUtilities
    {
        // Display
        public static Style DisplayNone() => DisplayNone(new Style());
        public static Style DisplayNone(this Style style) => Display(style, DisplayStyle.None);
        public static Style DisplayFlex() => DisplayFlex(new Style());
        public static Style DisplayFlex(this Style style) => Display(style, DisplayStyle.Flex);
        public static Style Display(DisplayStyle value) => Display(new Style(), value);
        public static Style Display(this Style style, DisplayStyle value)
        {
            style.display = value;
            return style;
        }
        
        // Flex Direction
        public static Style FlexColumn() => FlexColumn(new Style());
        public static Style FlexColumn(this Style style) => FlexDirection(style, UnityEngine.UIElements.FlexDirection.Column);
        public static Style FlexColumnReverse() => FlexColumnReverse(new Style());
        public static Style FlexColumnReverse(this Style style) => FlexDirection(style, UnityEngine.UIElements.FlexDirection.ColumnReverse);
        public static Style FlexRow() => FlexRow(new Style());
        public static Style FlexRow(this Style style) => FlexDirection(style, UnityEngine.UIElements.FlexDirection.Row);
        public static Style FlexRowReverse() => FlexRowReverse(new Style());
        public static Style FlexRowReverse(this Style style) => FlexDirection(style, UnityEngine.UIElements.FlexDirection.RowReverse);
        public static Style FlexDirection(FlexDirection value) => FlexDirection(new Style(), value);
        public static Style FlexDirection(this Style style, FlexDirection value)
        {
            style.flexDirection = value;
            return style;
        }

        // Justify Content
        public static Style JustifyContentStart() => JustifyContentStart(new Style());
        public static Style JustifyContentStart(this Style style) => JustifyContent(style, Justify.FlexStart);
        public static Style JustifyContentEnd() => JustifyContentEnd(new Style());
        public static Style JustifyContentEnd(this Style style) => JustifyContent(style, Justify.FlexEnd);
        public static Style JustifyContentCenter() => JustifyContentCenter(new Style());
        public static Style JustifyContentCenter(this Style style) => JustifyContent(style, Justify.Center);
        public static Style JustifyContentBetween() => JustifyContentBetween(new Style());
        public static Style JustifyContentBetween(this Style style) => JustifyContent(style, Justify.SpaceBetween);
        public static Style JustifyContentAround() => JustifyContentAround(new Style());
        public static Style JustifyContentAround(this Style style) => JustifyContent(style, Justify.SpaceAround);
        public static Style JustifyContent(Justify value) => JustifyContent(new Style(), value);
        public static Style JustifyContent(this Style style, Justify value)
        {
            style.justifyContent = value;
            return style;
        }
    }
}
