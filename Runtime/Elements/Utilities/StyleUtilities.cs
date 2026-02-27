using RishUI;
using UnityEngine;
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
        
        // Align Items
        public static Style AlignItemsStart() => AlignItemsStart(new Style());
        public static Style AlignItemsStart(this Style style) => AlignItems(style, Align.FlexStart);
        public static Style AlignItemsEnd() => AlignItemsEnd(new Style());
        public static Style AlignItemsEnd(this Style style) => AlignItems(style, Align.FlexEnd);
        public static Style AlignItemsCenter() => AlignItemsCenter(new Style());
        public static Style AlignItemsCenter(this Style style) => AlignItems(style, Align.Center);
        public static Style AlignItemsStretch() => AlignItemsStretch(new Style());
        public static Style AlignItemsStretch(this Style style) => AlignItems(style, Align.Stretch);
        public static Style AlignItems(Align value) => AlignItems(new Style(), value);
        public static Style AlignItems(this Style style, Align value)
        {
            style.alignItems = value;
            return style;
        }
        
        // Align Content
        public static Style AlignContentStart() => AlignContentStart(new Style());
        public static Style AlignContentStart(this Style style) => AlignContent(style, Align.FlexStart);
        public static Style AlignContentEnd() => AlignContentEnd(new Style());
        public static Style AlignContentEnd(this Style style) => AlignContent(style, Align.FlexEnd);
        public static Style AlignContentCenter() => AlignContentCenter(new Style());
        public static Style AlignContentCenter(this Style style) => AlignContent(style, Align.Center);
        public static Style AlignContentStretch() => AlignContentStretch(new Style());
        public static Style AlignContentStretch(this Style style) => AlignContent(style, Align.Stretch);
        public static Style AlignContent(Align value) => AlignContent(new Style(), value);
        public static Style AlignContent(this Style style, Align value)
        {
            style.alignContent = value;
            return style;
        }
        
        // Align Self
        public static Style AlignSelfStart() => AlignSelfStart(new Style());
        public static Style AlignSelfStart(this Style style) => AlignSelf(style, Align.FlexStart);
        public static Style AlignSelfEnd() => AlignSelfEnd(new Style());
        public static Style AlignSelfEnd(this Style style) => AlignSelf(style, Align.FlexEnd);
        public static Style AlignSelfCenter() => AlignSelfCenter(new Style());
        public static Style AlignSelfCenter(this Style style) => AlignSelf(style, Align.Center);
        public static Style AlignSelfStretch() => AlignSelfStretch(new Style());
        public static Style AlignSelfStretch(this Style style) => AlignSelf(style, Align.Stretch);
        public static Style AlignSelf(Align value) => AlignSelf(new Style(), value);
        public static Style AlignSelf(this Style style, Align value)
        {
            style.alignSelf = value;
            return style;
        }
        
        // Fill
        public static Style FlexFill() => FlexFill(new Style());
        public static Style FlexFill(this Style style)
        {
            style.flex = new StyleFlexShorthand(1, 1, RishStyleKeyword.Auto);
            return style;
        }
        
        public static Style AbsoluteFill() => AbsoluteFill(new Style());
        public static Style AbsoluteFill(this Style style)
        {
            style.position = UnityEngine.UIElements.Position.Absolute;
            style.top = 0;
            style.right = 0;
            style.bottom = 0;
            style.left = 0;
            return style;
        }
        
        // Grow & Shrink
        public static Style FlexGrow0() => FlexGrow0(new Style());
        public static Style FlexGrow0(this Style style) => FlexGrow(style, 0);
        public static Style FlexGrow1() => FlexGrow1(new Style());
        public static Style FlexGrow1(this Style style) => FlexGrow(style, 1);
        public static Style FlexGrow(float value) => FlexGrow(new Style(), value);
        public static Style FlexGrow(this Style style, float value)
        {
            style.flexGrow = value;
            return style;
        }
        
        public static Style FlexShrink0() => FlexShrink0(new Style());
        public static Style FlexShrink0(this Style style) => FlexShrink(style, 0);
        public static Style FlexShrink1() => FlexShrink1(new Style());
        public static Style FlexShrink1(this Style style) => FlexShrink(style, 1);
        public static Style FlexShrink(float value) => FlexShrink(new Style(), value);
        public static Style FlexShrink(this Style style, float value)
        {
            style.flexShrink = value;
            return style;
        }
        
        // Wrap
        public static Style FlexNoWrap() => FlexNoWrap(new Style());
        public static Style FlexNoWrap(this Style style) => FlexWrap(style, Wrap.NoWrap);
        public static Style FlexWrap() => FlexWrap(new Style());
        public static Style FlexWrap(this Style style) => FlexWrap(style, Wrap.Wrap);
        public static Style FlexWrapReverse() => FlexWrapReverse(new Style());
        public static Style FlexWrapReverse(this Style style) => FlexWrap(style, Wrap.WrapReverse);
        public static Style FlexWrap(Wrap value) => FlexWrap(new Style(), value);
        public static Style FlexWrap(this Style style, Wrap value)
        {
            style.flexWrap = value;
            return style;
        }
        
        // Margins
        public static Style MarginTopAuto() => MarginTopAuto(new Style());
        public static Style MarginTopAuto(this Style style)
        {
            style.marginTop = RishStyleKeyword.Auto;
            return style;
        }
        public static Style MarginTop(Length value) => MarginTop(new Style(), value);
        public static Style MarginTop(this Style style, Length value)
        {
            style.marginTop = value;
            return style;
        }
        
        public static Style MarginRightAuto() => MarginRightAuto(new Style());
        public static Style MarginRightAuto(this Style style)
        {
            style.marginRight = RishStyleKeyword.Auto;
            return style;
        }
        public static Style MarginRight(Length value) => MarginRight(new Style(), value);
        public static Style MarginRight(this Style style, Length value)
        {
            style.marginRight = value;
            return style;
        }
        
        public static Style MarginBottomAuto() => MarginBottomAuto(new Style());
        public static Style MarginBottomAuto(this Style style)
        {
            style.marginBottom = RishStyleKeyword.Auto;
            return style;
        }
        public static Style MarginBottom(Length value) => MarginBottom(new Style(), value);
        public static Style MarginBottom(this Style style, Length value)
        {
            style.marginBottom = value;
            return style;
        }
        
        public static Style MarginLeftAuto() => MarginLeftAuto(new Style());
        public static Style MarginLeftAuto(this Style style)
        {
            style.marginLeft = RishStyleKeyword.Auto;
            return style;
        }
        public static Style MarginLeft(Length value) => MarginLeft(new Style(), value);
        public static Style MarginLeft(this Style style, Length value)
        {
            style.marginLeft = value;
            return style;
        }
        
        public static Style MarginXAuto() => MarginXAuto(new Style());
        public static Style MarginXAuto(this Style style)
        {
            style.marginLeft = RishStyleKeyword.Auto;
            style.marginRight = RishStyleKeyword.Auto;
            return style;
        }
        public static Style MarginX(Length value) => MarginX(new Style(), value);
        public static Style MarginX(this Style style, Length value)
        {
            style.marginLeft = value;
            style.marginRight = value;
            return style;
        }
        
        public static Style MarginYAuto() => MarginYAuto(new Style());
        public static Style MarginYAuto(this Style style)
        {
            style.marginTop = RishStyleKeyword.Auto;
            style.marginBottom = RishStyleKeyword.Auto;
            return style;
        }
        public static Style MarginY(Length value) => MarginY(new Style(), value);
        public static Style MarginY(this Style style, Length value)
        {
            style.marginTop = value;
            style.marginBottom = value;
            return style;
        }
        
        public static Style MarginAuto() => MarginAuto(new Style());
        public static Style MarginAuto(this Style style)
        {
            style.marginTop = RishStyleKeyword.Auto;
            style.marginRight = RishStyleKeyword.Auto;
            style.marginBottom = RishStyleKeyword.Auto;
            style.marginLeft = RishStyleKeyword.Auto;
            return style;
        }
        public static Style Margin(Length value) => Margin(new Style(), value);
        public static Style Margin(this Style style, Length value)
        {
            style.marginTop = value;
            style.marginRight = value;
            style.marginBottom = value;
            style.marginLeft = value;
            return style;
        }
        
        // Paddings
        public static Style PaddingTopAuto() => PaddingTopAuto(new Style());
        public static Style PaddingTopAuto(this Style style)
        {
            style.paddingTop = RishStyleKeyword.Auto;
            return style;
        }
        public static Style PaddingTop(Length value) => PaddingTop(new Style(), value);
        public static Style PaddingTop(this Style style, Length value)
        {
            style.paddingTop = value;
            return style;
        }
        
        public static Style PaddingRightAuto() => PaddingRightAuto(new Style());
        public static Style PaddingRightAuto(this Style style)
        {
            style.paddingRight = RishStyleKeyword.Auto;
            return style;
        }
        public static Style PaddingRight(Length value) => PaddingRight(new Style(), value);
        public static Style PaddingRight(this Style style, Length value)
        {
            style.paddingRight = value;
            return style;
        }
        
        public static Style PaddingBottomAuto() => PaddingBottomAuto(new Style());
        public static Style PaddingBottomAuto(this Style style)
        {
            style.paddingBottom = RishStyleKeyword.Auto;
            return style;
        }
        public static Style PaddingBottom(Length value) => PaddingBottom(new Style(), value);
        public static Style PaddingBottom(this Style style, Length value)
        {
            style.paddingBottom = value;
            return style;
        }
        
        public static Style PaddingLeftAuto() => PaddingLeftAuto(new Style());
        public static Style PaddingLeftAuto(this Style style)
        {
            style.paddingLeft = RishStyleKeyword.Auto;
            return style;
        }
        public static Style PaddingLeft(Length value) => PaddingLeft(new Style(), value);
        public static Style PaddingLeft(this Style style, Length value)
        {
            style.paddingLeft = value;
            return style;
        }
        
        public static Style PaddingXAuto() => PaddingXAuto(new Style());
        public static Style PaddingXAuto(this Style style)
        {
            style.paddingLeft = RishStyleKeyword.Auto;
            style.paddingRight = RishStyleKeyword.Auto;
            return style;
        }
        public static Style PaddingX(Length value) => PaddingX(new Style(), value);
        public static Style PaddingX(this Style style, Length value)
        {
            style.paddingLeft = value;
            style.paddingRight = value;
            return style;
        }
        
        public static Style PaddingYAuto() => PaddingYAuto(new Style());
        public static Style PaddingYAuto(this Style style)
        {
            style.paddingTop = RishStyleKeyword.Auto;
            style.paddingBottom = RishStyleKeyword.Auto;
            return style;
        }
        public static Style PaddingY(Length value) => PaddingY(new Style(), value);
        public static Style PaddingY(this Style style, Length value)
        {
            style.paddingTop = value;
            style.paddingBottom = value;
            return style;
        }
        
        public static Style PaddingAuto() => PaddingAuto(new Style());
        public static Style PaddingAuto(this Style style)
        {
            style.paddingTop = RishStyleKeyword.Auto;
            style.paddingRight = RishStyleKeyword.Auto;
            style.paddingBottom = RishStyleKeyword.Auto;
            style.paddingLeft = RishStyleKeyword.Auto;
            return style;
        }
        public static Style Padding(Length value) => Padding(new Style(), value);
        public static Style Padding(this Style style, Length value)
        {
            style.paddingTop = value;
            style.paddingRight = value;
            style.paddingBottom = value;
            style.paddingLeft = value;
            return style;
        }
        public static Style Padding(Length xValue, Length yValue) => Padding(new Style(), xValue, yValue);
        public static Style Padding(this Style style, Length xValue, Length yValue)
        {
            style.paddingTop = yValue;
            style.paddingRight = xValue;
            style.paddingBottom = yValue;
            style.paddingLeft = xValue;
            return style;
        }
        public static Style Padding(Length top, Length right, Length bottom, Length left) => Padding(new Style(), top, right, bottom, left);
        public static Style Padding(this Style style, Length top, Length right, Length bottom, Length left)
        {
            style.paddingTop = top;
            style.paddingRight = right;
            style.paddingBottom = bottom;
            style.paddingLeft = left;
            return style;
        }
        
        // Text Alignment
        public static Style TextLeft() => TextUpperLeft();
        public static Style TextLeft(this Style style) => TextUpperLeft(style);
        public static Style TextRight() => TextUpperRight();
        public static Style TextRight(this Style style) => TextUpperRight(style);
        public static Style TextCenter() => TextUpperCenter();
        public static Style TextCenter(this Style style) => TextUpperCenter(style);
        public static Style TextUpperLeft() => TextUpperLeft(new Style());
        public static Style TextUpperLeft(this Style style) => TextAlign(style, TextAnchor.UpperLeft);
        public static Style TextUpperRight() => TextUpperRight(new Style());
        public static Style TextUpperRight(this Style style) => TextAlign(style, TextAnchor.UpperRight);
        public static Style TextUpperCenter() => TextUpperCenter(new Style());
        public static Style TextUpperCenter(this Style style) => TextAlign(style, TextAnchor.UpperCenter);
        public static Style TextMiddleLeft() => TextMiddleLeft(new Style());
        public static Style TextMiddleLeft(this Style style) => TextAlign(style, TextAnchor.MiddleLeft);
        public static Style TextMiddleRight() => TextMiddleRight(new Style());
        public static Style TextMiddleRight(this Style style) => TextAlign(style, TextAnchor.MiddleRight);
        public static Style TextMiddleCenter() => TextMiddleCenter(new Style());
        public static Style TextMiddleCenter(this Style style) => TextAlign(style, TextAnchor.MiddleCenter);
        public static Style TextLowerLeft() => TextLowerLeft(new Style());
        public static Style TextLowerLeft(this Style style) => TextAlign(style, TextAnchor.LowerLeft);
        public static Style TextLowerRight() => TextLowerRight(new Style());
        public static Style TextLowerRight(this Style style) => TextAlign(style, TextAnchor.LowerRight);
        public static Style TextLowerCenter() => TextLowerCenter(new Style());
        public static Style TextLowerCenter(this Style style) => TextAlign(style, TextAnchor.LowerCenter);
        public static Style TextAlign(TextAnchor value) => TextAlign(new Style(), value);
        public static Style TextAlign(this Style style, TextAnchor value)
        {
            style.unityTextAlign = value;
            return style;
        }
        
        // Visibility
        public static Style Visible() => Visible(new Style());
        public static Style Visible(this Style style) => Visibility(style, UnityEngine.UIElements.Visibility.Visible);
        public static Style Hidden() => Hidden(new Style());
        public static Style Hidden(this Style style) => Visibility(style, UnityEngine.UIElements.Visibility.Hidden);
        public static Style Visibility(Visibility value) => Visibility(new Style(), value);
        public static Style Visibility(this Style style, Visibility value)
        {
            style.visibility = value;
            return style;
        }
        
        // Opacity
        public static Style Opacity0() => Opacity0(new Style());
        public static Style Opacity0(this Style style) => Opacity(style, 0);
        public static Style Opacity5() => Opacity5(new Style());
        public static Style Opacity5(this Style style) => Opacity(style, 5);
        public static Style Opacity10() => Opacity10(new Style());
        public static Style Opacity10(this Style style) => Opacity(style, 10);
        public static Style Opacity15() => Opacity15(new Style());
        public static Style Opacity15(this Style style) => Opacity(style, 15);
        public static Style Opacity20() => Opacity20(new Style());
        public static Style Opacity20(this Style style) => Opacity(style, 20);
        public static Style Opacity25() => Opacity25(new Style());
        public static Style Opacity25(this Style style) => Opacity(style, 25);
        public static Style Opacity30() => Opacity30(new Style());
        public static Style Opacity30(this Style style) => Opacity(style, 30);
        public static Style Opacity35() => Opacity35(new Style());
        public static Style Opacity35(this Style style) => Opacity(style, 35);
        public static Style Opacity40() => Opacity40(new Style());
        public static Style Opacity40(this Style style) => Opacity(style, 40);
        public static Style Opacity45() => Opacity45(new Style());
        public static Style Opacity45(this Style style) => Opacity(style, 45);
        public static Style Opacity50() => Opacity50(new Style());
        public static Style Opacity50(this Style style) => Opacity(style, 50);
        public static Style Opacity55() => Opacity55(new Style());
        public static Style Opacity55(this Style style) => Opacity(style, 55);
        public static Style Opacity60() => Opacity60(new Style());
        public static Style Opacity60(this Style style) => Opacity(style, 60);
        public static Style Opacity65() => Opacity65(new Style());
        public static Style Opacity65(this Style style) => Opacity(style, 65);
        public static Style Opacity70() => Opacity70(new Style());
        public static Style Opacity70(this Style style) => Opacity(style, 70);
        public static Style Opacity75() => Opacity75(new Style());
        public static Style Opacity75(this Style style) => Opacity(style, 75);
        public static Style Opacity80() => Opacity80(new Style());
        public static Style Opacity80(this Style style) => Opacity(style, 80);
        public static Style Opacity85() => Opacity85(new Style());
        public static Style Opacity85(this Style style) => Opacity(style, 85);
        public static Style Opacity90() => Opacity90(new Style());
        public static Style Opacity90(this Style style) => Opacity(style, 90);
        public static Style Opacity95() => Opacity95(new Style());
        public static Style Opacity95(this Style style) => Opacity(style, 95);
        public static Style Opacity100() => Opacity100(new Style());
        public static Style Opacity100(this Style style) => Opacity(style, 100);
        public static Style Opacity(float value) => Opacity(new Style(), value);
        public static Style Opacity(this Style style, float value)
        {
            style.opacity = value;
            return style;
        }

        // Overflow
        public static Style OverflowHidden() => OverflowHidden(new Style());
        public static Style OverflowHidden(this Style style) => Overflow(style, UnityEngine.UIElements.Overflow.Hidden);
        public static Style OverflowVisible() => OverflowVisible(new Style());
        public static Style OverflowVisible(this Style style) => Overflow(style, UnityEngine.UIElements.Overflow.Visible);
        public static Style Overflow(Overflow value) => Overflow(new Style(), value);
        public static Style Overflow(this Style style, Overflow value)
        {
            style.overflow = value;
            return style;
        }
        
        // Position
        public static Style PositionRelative() => PositionRelative(new Style());
        public static Style PositionRelative(this Style style) => Position(style, UnityEngine.UIElements.Position.Relative);
        public static Style PositionAbsolute() => PositionAbsolute(new Style());
        public static Style PositionAbsolute(this Style style) => Position(style, UnityEngine.UIElements.Position.Absolute);
        public static Style Position(Position value) => Position(new Style(), value);
        public static Style Position(this Style style, Position value)
        {
            style.position = value;
            return style;
        }
        
        // Arrange Elements
        public static Style Top0() => Top0(new Style());
        public static Style Top0(this Style style) => Top(style, Length.Percent(0));
        public static Style Top5() => Top5(new Style());
        public static Style Top5(this Style style) => Top(style, Length.Percent(5));
        public static Style Top10() => Top10(new Style());
        public static Style Top10(this Style style) => Top(style, Length.Percent(10));
        public static Style Top15() => Top15(new Style());
        public static Style Top15(this Style style) => Top(style, Length.Percent(15));
        public static Style Top20() => Top20(new Style());
        public static Style Top20(this Style style) => Top(style, Length.Percent(20));
        public static Style Top25() => Top25(new Style());
        public static Style Top25(this Style style) => Top(style, Length.Percent(25));
        public static Style Top30() => Top30(new Style());
        public static Style Top30(this Style style) => Top(style, Length.Percent(30));
        public static Style Top35() => Top35(new Style());
        public static Style Top35(this Style style) => Top(style, Length.Percent(35));
        public static Style Top40() => Top40(new Style());
        public static Style Top40(this Style style) => Top(style, Length.Percent(40));
        public static Style Top45() => Top45(new Style());
        public static Style Top45(this Style style) => Top(style, Length.Percent(45));
        public static Style Top50() => Top50(new Style());
        public static Style Top50(this Style style) => Top(style, Length.Percent(50));
        public static Style Top55() => Top55(new Style());
        public static Style Top55(this Style style) => Top(style, Length.Percent(55));
        public static Style Top60() => Top60(new Style());
        public static Style Top60(this Style style) => Top(style, Length.Percent(60));
        public static Style Top65() => Top65(new Style());
        public static Style Top65(this Style style) => Top(style, Length.Percent(65));
        public static Style Top70() => Top70(new Style());
        public static Style Top70(this Style style) => Top(style, Length.Percent(70));
        public static Style Top75() => Top75(new Style());
        public static Style Top75(this Style style) => Top(style, Length.Percent(75));
        public static Style Top80() => Top80(new Style());
        public static Style Top80(this Style style) => Top(style, Length.Percent(80));
        public static Style Top85() => Top85(new Style());
        public static Style Top85(this Style style) => Top(style, Length.Percent(85));
        public static Style Top90() => Top90(new Style());
        public static Style Top90(this Style style) => Top(style, Length.Percent(90));
        public static Style Top95() => Top95(new Style());
        public static Style Top95(this Style style) => Top(style, Length.Percent(95));
        public static Style Top100() => Top100(new Style());
        public static Style Top100(this Style style) => Top(style, Length.Percent(100));
        public static Style Top(Length value) => Top(new Style(), value);
        public static Style Top(this Style style, Length value)
        {
            style.top = value;
            return style;
        }
        public static Style Right0() => Right0(new Style());
        public static Style Right0(this Style style) => Right(style, Length.Percent(0));
        public static Style Right5() => Right5(new Style());
        public static Style Right5(this Style style) => Right(style, Length.Percent(5));
        public static Style Right10() => Right10(new Style());
        public static Style Right10(this Style style) => Right(style, Length.Percent(10));
        public static Style Right15() => Right15(new Style());
        public static Style Right15(this Style style) => Right(style, Length.Percent(15));
        public static Style Right20() => Right20(new Style());
        public static Style Right20(this Style style) => Right(style, Length.Percent(20));
        public static Style Right25() => Right25(new Style());
        public static Style Right25(this Style style) => Right(style, Length.Percent(25));
        public static Style Right30() => Right30(new Style());
        public static Style Right30(this Style style) => Right(style, Length.Percent(30));
        public static Style Right35() => Right35(new Style());
        public static Style Right35(this Style style) => Right(style, Length.Percent(35));
        public static Style Right40() => Right40(new Style());
        public static Style Right40(this Style style) => Right(style, Length.Percent(40));
        public static Style Right45() => Right45(new Style());
        public static Style Right45(this Style style) => Right(style, Length.Percent(45));
        public static Style Right50() => Right50(new Style());
        public static Style Right50(this Style style) => Right(style, Length.Percent(50));
        public static Style Right55() => Right55(new Style());
        public static Style Right55(this Style style) => Right(style, Length.Percent(55));
        public static Style Right60() => Right60(new Style());
        public static Style Right60(this Style style) => Right(style, Length.Percent(60));
        public static Style Right65() => Right65(new Style());
        public static Style Right65(this Style style) => Right(style, Length.Percent(65));
        public static Style Right70() => Right70(new Style());
        public static Style Right70(this Style style) => Right(style, Length.Percent(70));
        public static Style Right75() => Right75(new Style());
        public static Style Right75(this Style style) => Right(style, Length.Percent(75));
        public static Style Right80() => Right80(new Style());
        public static Style Right80(this Style style) => Right(style, Length.Percent(80));
        public static Style Right85() => Right85(new Style());
        public static Style Right85(this Style style) => Right(style, Length.Percent(85));
        public static Style Right90() => Right90(new Style());
        public static Style Right90(this Style style) => Right(style, Length.Percent(90));
        public static Style Right95() => Right95(new Style());
        public static Style Right95(this Style style) => Right(style, Length.Percent(95));
        public static Style Right100() => Right100(new Style());
        public static Style Right100(this Style style) => Right(style, Length.Percent(100));
        public static Style Right(Length value) => Right(new Style(), value);
        public static Style Right(this Style style, Length value)
        {
            style.right = value;
            return style;
        }
        public static Style Bottom0() => Bottom0(new Style());
        public static Style Bottom0(this Style style) => Bottom(style, Length.Percent(0));
        public static Style Bottom5() => Bottom5(new Style());
        public static Style Bottom5(this Style style) => Bottom(style, Length.Percent(5));
        public static Style Bottom10() => Bottom10(new Style());
        public static Style Bottom10(this Style style) => Bottom(style, Length.Percent(10));
        public static Style Bottom15() => Bottom15(new Style());
        public static Style Bottom15(this Style style) => Bottom(style, Length.Percent(15));
        public static Style Bottom20() => Bottom20(new Style());
        public static Style Bottom20(this Style style) => Bottom(style, Length.Percent(20));
        public static Style Bottom25() => Bottom25(new Style());
        public static Style Bottom25(this Style style) => Bottom(style, Length.Percent(25));
        public static Style Bottom30() => Bottom30(new Style());
        public static Style Bottom30(this Style style) => Bottom(style, Length.Percent(30));
        public static Style Bottom35() => Bottom35(new Style());
        public static Style Bottom35(this Style style) => Bottom(style, Length.Percent(35));
        public static Style Bottom40() => Bottom40(new Style());
        public static Style Bottom40(this Style style) => Bottom(style, Length.Percent(40));
        public static Style Bottom45() => Bottom45(new Style());
        public static Style Bottom45(this Style style) => Bottom(style, Length.Percent(45));
        public static Style Bottom50() => Bottom50(new Style());
        public static Style Bottom50(this Style style) => Bottom(style, Length.Percent(50));
        public static Style Bottom55() => Bottom55(new Style());
        public static Style Bottom55(this Style style) => Bottom(style, Length.Percent(55));
        public static Style Bottom60() => Bottom60(new Style());
        public static Style Bottom60(this Style style) => Bottom(style, Length.Percent(60));
        public static Style Bottom65() => Bottom65(new Style());
        public static Style Bottom65(this Style style) => Bottom(style, Length.Percent(65));
        public static Style Bottom70() => Bottom70(new Style());
        public static Style Bottom70(this Style style) => Bottom(style, Length.Percent(70));
        public static Style Bottom75() => Bottom75(new Style());
        public static Style Bottom75(this Style style) => Bottom(style, Length.Percent(75));
        public static Style Bottom80() => Bottom80(new Style());
        public static Style Bottom80(this Style style) => Bottom(style, Length.Percent(80));
        public static Style Bottom85() => Bottom85(new Style());
        public static Style Bottom85(this Style style) => Bottom(style, Length.Percent(85));
        public static Style Bottom90() => Bottom90(new Style());
        public static Style Bottom90(this Style style) => Bottom(style, Length.Percent(90));
        public static Style Bottom95() => Bottom95(new Style());
        public static Style Bottom95(this Style style) => Bottom(style, Length.Percent(95));
        public static Style Bottom100() => Bottom100(new Style());
        public static Style Bottom100(this Style style) => Bottom(style, Length.Percent(100));
        public static Style Bottom(Length value) => Bottom(new Style(), value);
        public static Style Bottom(this Style style, Length value)
        {
            style.bottom = value;
            return style;
        }
        public static Style Left0() => Left0(new Style());
        public static Style Left0(this Style style) => Left(style, Length.Percent(0));
        public static Style Left5() => Left5(new Style());
        public static Style Left5(this Style style) => Left(style, Length.Percent(5));
        public static Style Left10() => Left10(new Style());
        public static Style Left10(this Style style) => Left(style, Length.Percent(10));
        public static Style Left15() => Left15(new Style());
        public static Style Left15(this Style style) => Left(style, Length.Percent(15));
        public static Style Left20() => Left20(new Style());
        public static Style Left20(this Style style) => Left(style, Length.Percent(20));
        public static Style Left25() => Left25(new Style());
        public static Style Left25(this Style style) => Left(style, Length.Percent(25));
        public static Style Left30() => Left30(new Style());
        public static Style Left30(this Style style) => Left(style, Length.Percent(30));
        public static Style Left35() => Left35(new Style());
        public static Style Left35(this Style style) => Left(style, Length.Percent(35));
        public static Style Left40() => Left40(new Style());
        public static Style Left40(this Style style) => Left(style, Length.Percent(40));
        public static Style Left45() => Left45(new Style());
        public static Style Left45(this Style style) => Left(style, Length.Percent(45));
        public static Style Left50() => Left50(new Style());
        public static Style Left50(this Style style) => Left(style, Length.Percent(50));
        public static Style Left55() => Left55(new Style());
        public static Style Left55(this Style style) => Left(style, Length.Percent(55));
        public static Style Left60() => Left60(new Style());
        public static Style Left60(this Style style) => Left(style, Length.Percent(60));
        public static Style Left65() => Left65(new Style());
        public static Style Left65(this Style style) => Left(style, Length.Percent(65));
        public static Style Left70() => Left70(new Style());
        public static Style Left70(this Style style) => Left(style, Length.Percent(70));
        public static Style Left75() => Left75(new Style());
        public static Style Left75(this Style style) => Left(style, Length.Percent(75));
        public static Style Left80() => Left80(new Style());
        public static Style Left80(this Style style) => Left(style, Length.Percent(80));
        public static Style Left85() => Left85(new Style());
        public static Style Left85(this Style style) => Left(style, Length.Percent(85));
        public static Style Left90() => Left90(new Style());
        public static Style Left90(this Style style) => Left(style, Length.Percent(90));
        public static Style Left95() => Left95(new Style());
        public static Style Left95(this Style style) => Left(style, Length.Percent(95));
        public static Style Left100() => Left100(new Style());
        public static Style Left100(this Style style) => Left(style, Length.Percent(100));
        public static Style Left(Length value) => Left(new Style(), value);
        public static Style Left(this Style style, Length value)
        {
            style.left = value;
            return style;
        }

        // Translate
        public static Style TranslateMiddle() => TranslateMiddle(new Style());
        public static Style TranslateMiddle(this Style style) => Translate(style, new Translate(Length.Percent(-50), Length.Percent(-50)));
        public static Style TranslateX() => TranslateX(new Style());
        public static Style TranslateX(this Style style) => Translate(style, new Translate(Length.Percent(-50), 0));
        public static Style TranslateY() => TranslateY(new Style());
        public static Style TranslateY(this Style style) => Translate(style, new Translate(0, Length.Percent(-50)));
        public static Style Translate(Translate value) => Translate(new Style(), value);
        public static Style Translate(this Style style, Translate value)
        {
            style.translate = value;
            return style;
        }
        
        // Sizing
        public static Style Width0() => Width0(new Style());
        public static Style Width0(this Style style) => Width(style, Length.Percent(0));
        public static Style Width5() => Width5(new Style());
        public static Style Width5(this Style style) => Width(style, Length.Percent(5));
        public static Style Width10() => Width10(new Style());
        public static Style Width10(this Style style) => Width(style, Length.Percent(10));
        public static Style Width15() => Width15(new Style());
        public static Style Width15(this Style style) => Width(style, Length.Percent(15));
        public static Style Width20() => Width20(new Style());
        public static Style Width20(this Style style) => Width(style, Length.Percent(20));
        public static Style Width25() => Width25(new Style());
        public static Style Width25(this Style style) => Width(style, Length.Percent(25));
        public static Style Width30() => Width30(new Style());
        public static Style Width30(this Style style) => Width(style, Length.Percent(30));
        public static Style Width35() => Width35(new Style());
        public static Style Width35(this Style style) => Width(style, Length.Percent(35));
        public static Style Width40() => Width40(new Style());
        public static Style Width40(this Style style) => Width(style, Length.Percent(40));
        public static Style Width45() => Width45(new Style());
        public static Style Width45(this Style style) => Width(style, Length.Percent(45));
        public static Style Width50() => Width50(new Style());
        public static Style Width50(this Style style) => Width(style, Length.Percent(50));
        public static Style Width55() => Width55(new Style());
        public static Style Width55(this Style style) => Width(style, Length.Percent(55));
        public static Style Width60() => Width60(new Style());
        public static Style Width60(this Style style) => Width(style, Length.Percent(60));
        public static Style Width65() => Width65(new Style());
        public static Style Width65(this Style style) => Width(style, Length.Percent(65));
        public static Style Width70() => Width70(new Style());
        public static Style Width70(this Style style) => Width(style, Length.Percent(70));
        public static Style Width75() => Width75(new Style());
        public static Style Width75(this Style style) => Width(style, Length.Percent(75));
        public static Style Width80() => Width80(new Style());
        public static Style Width80(this Style style) => Width(style, Length.Percent(80));
        public static Style Width85() => Width85(new Style());
        public static Style Width85(this Style style) => Width(style, Length.Percent(85));
        public static Style Width90() => Width90(new Style());
        public static Style Width90(this Style style) => Width(style, Length.Percent(90));
        public static Style Width95() => Width95(new Style());
        public static Style Width95(this Style style) => Width(style, Length.Percent(95));
        public static Style Width100() => Width100(new Style());
        public static Style Width100(this Style style) => Width(style, Length.Percent(100));
        public static Style Width(Length value) => Width(new Style(), value);
        public static Style Width(this Style style, Length value)
        {
            style.width = value;
            return style;
        }
        public static Style Height0() => Height0(new Style());
        public static Style Height0(this Style style) => Height(style, Length.Percent(0));
        public static Style Height5() => Height5(new Style());
        public static Style Height5(this Style style) => Height(style, Length.Percent(5));
        public static Style Height10() => Height10(new Style());
        public static Style Height10(this Style style) => Height(style, Length.Percent(10));
        public static Style Height15() => Height15(new Style());
        public static Style Height15(this Style style) => Height(style, Length.Percent(15));
        public static Style Height20() => Height20(new Style());
        public static Style Height20(this Style style) => Height(style, Length.Percent(20));
        public static Style Height25() => Height25(new Style());
        public static Style Height25(this Style style) => Height(style, Length.Percent(25));
        public static Style Height30() => Height30(new Style());
        public static Style Height30(this Style style) => Height(style, Length.Percent(30));
        public static Style Height35() => Height35(new Style());
        public static Style Height35(this Style style) => Height(style, Length.Percent(35));
        public static Style Height40() => Height40(new Style());
        public static Style Height40(this Style style) => Height(style, Length.Percent(40));
        public static Style Height45() => Height45(new Style());
        public static Style Height45(this Style style) => Height(style, Length.Percent(45));
        public static Style Height50() => Height50(new Style());
        public static Style Height50(this Style style) => Height(style, Length.Percent(50));
        public static Style Height55() => Height55(new Style());
        public static Style Height55(this Style style) => Height(style, Length.Percent(55));
        public static Style Height60() => Height60(new Style());
        public static Style Height60(this Style style) => Height(style, Length.Percent(60));
        public static Style Height65() => Height65(new Style());
        public static Style Height65(this Style style) => Height(style, Length.Percent(65));
        public static Style Height70() => Height70(new Style());
        public static Style Height70(this Style style) => Height(style, Length.Percent(70));
        public static Style Height75() => Height75(new Style());
        public static Style Height75(this Style style) => Height(style, Length.Percent(75));
        public static Style Height80() => Height80(new Style());
        public static Style Height80(this Style style) => Height(style, Length.Percent(80));
        public static Style Height85() => Height85(new Style());
        public static Style Height85(this Style style) => Height(style, Length.Percent(85));
        public static Style Height90() => Height90(new Style());
        public static Style Height90(this Style style) => Height(style, Length.Percent(90));
        public static Style Height95() => Height95(new Style());
        public static Style Height95(this Style style) => Height(style, Length.Percent(95));
        public static Style Height100() => Height100(new Style());
        public static Style Height100(this Style style) => Height(style, Length.Percent(100));
        public static Style Height(Length value) => Height(new Style(), value);
        public static Style Height(this Style style, Length value)
        {
            style.height = value;
            return style;
        }
        public static Style MinWidth0() => MinWidth0(new Style());
        public static Style MinWidth0(this Style style) => MinWidth(style, Length.Percent(0));
        public static Style MinWidth5() => MinWidth5(new Style());
        public static Style MinWidth5(this Style style) => MinWidth(style, Length.Percent(5));
        public static Style MinWidth10() => MinWidth10(new Style());
        public static Style MinWidth10(this Style style) => MinWidth(style, Length.Percent(10));
        public static Style MinWidth15() => MinWidth15(new Style());
        public static Style MinWidth15(this Style style) => MinWidth(style, Length.Percent(15));
        public static Style MinWidth20() => MinWidth20(new Style());
        public static Style MinWidth20(this Style style) => MinWidth(style, Length.Percent(20));
        public static Style MinWidth25() => MinWidth25(new Style());
        public static Style MinWidth25(this Style style) => MinWidth(style, Length.Percent(25));
        public static Style MinWidth30() => MinWidth30(new Style());
        public static Style MinWidth30(this Style style) => MinWidth(style, Length.Percent(30));
        public static Style MinWidth35() => MinWidth35(new Style());
        public static Style MinWidth35(this Style style) => MinWidth(style, Length.Percent(35));
        public static Style MinWidth40() => MinWidth40(new Style());
        public static Style MinWidth40(this Style style) => MinWidth(style, Length.Percent(40));
        public static Style MinWidth45() => MinWidth45(new Style());
        public static Style MinWidth45(this Style style) => MinWidth(style, Length.Percent(45));
        public static Style MinWidth50() => MinWidth50(new Style());
        public static Style MinWidth50(this Style style) => MinWidth(style, Length.Percent(50));
        public static Style MinWidth55() => MinWidth55(new Style());
        public static Style MinWidth55(this Style style) => MinWidth(style, Length.Percent(55));
        public static Style MinWidth60() => MinWidth60(new Style());
        public static Style MinWidth60(this Style style) => MinWidth(style, Length.Percent(60));
        public static Style MinWidth65() => MinWidth65(new Style());
        public static Style MinWidth65(this Style style) => MinWidth(style, Length.Percent(65));
        public static Style MinWidth70() => MinWidth70(new Style());
        public static Style MinWidth70(this Style style) => MinWidth(style, Length.Percent(70));
        public static Style MinWidth75() => MinWidth75(new Style());
        public static Style MinWidth75(this Style style) => MinWidth(style, Length.Percent(75));
        public static Style MinWidth80() => MinWidth80(new Style());
        public static Style MinWidth80(this Style style) => MinWidth(style, Length.Percent(80));
        public static Style MinWidth85() => MinWidth85(new Style());
        public static Style MinWidth85(this Style style) => MinWidth(style, Length.Percent(85));
        public static Style MinWidth90() => MinWidth90(new Style());
        public static Style MinWidth90(this Style style) => MinWidth(style, Length.Percent(90));
        public static Style MinWidth95() => MinWidth95(new Style());
        public static Style MinWidth95(this Style style) => MinWidth(style, Length.Percent(95));
        public static Style MinWidth100() => MinWidth100(new Style());
        public static Style MinWidth100(this Style style) => MinWidth(style, Length.Percent(100));
        public static Style MinWidth(Length value) => MinWidth(new Style(), value);
        public static Style MinWidth(this Style style, Length value)
        {
            style.minWidth = value;
            return style;
        }
        public static Style MinHeight0() => MinHeight0(new Style());
        public static Style MinHeight0(this Style style) => MinHeight(style, Length.Percent(0));
        public static Style MinHeight5() => MinHeight5(new Style());
        public static Style MinHeight5(this Style style) => MinHeight(style, Length.Percent(5));
        public static Style MinHeight10() => MinHeight10(new Style());
        public static Style MinHeight10(this Style style) => MinHeight(style, Length.Percent(10));
        public static Style MinHeight15() => MinHeight15(new Style());
        public static Style MinHeight15(this Style style) => MinHeight(style, Length.Percent(15));
        public static Style MinHeight20() => MinHeight20(new Style());
        public static Style MinHeight20(this Style style) => MinHeight(style, Length.Percent(20));
        public static Style MinHeight25() => MinHeight25(new Style());
        public static Style MinHeight25(this Style style) => MinHeight(style, Length.Percent(25));
        public static Style MinHeight30() => MinHeight30(new Style());
        public static Style MinHeight30(this Style style) => MinHeight(style, Length.Percent(30));
        public static Style MinHeight35() => MinHeight35(new Style());
        public static Style MinHeight35(this Style style) => MinHeight(style, Length.Percent(35));
        public static Style MinHeight40() => MinHeight40(new Style());
        public static Style MinHeight40(this Style style) => MinHeight(style, Length.Percent(40));
        public static Style MinHeight45() => MinHeight45(new Style());
        public static Style MinHeight45(this Style style) => MinHeight(style, Length.Percent(45));
        public static Style MinHeight50() => MinHeight50(new Style());
        public static Style MinHeight50(this Style style) => MinHeight(style, Length.Percent(50));
        public static Style MinHeight55() => MinHeight55(new Style());
        public static Style MinHeight55(this Style style) => MinHeight(style, Length.Percent(55));
        public static Style MinHeight60() => MinHeight60(new Style());
        public static Style MinHeight60(this Style style) => MinHeight(style, Length.Percent(60));
        public static Style MinHeight65() => MinHeight65(new Style());
        public static Style MinHeight65(this Style style) => MinHeight(style, Length.Percent(65));
        public static Style MinHeight70() => MinHeight70(new Style());
        public static Style MinHeight70(this Style style) => MinHeight(style, Length.Percent(70));
        public static Style MinHeight75() => MinHeight75(new Style());
        public static Style MinHeight75(this Style style) => MinHeight(style, Length.Percent(75));
        public static Style MinHeight80() => MinHeight80(new Style());
        public static Style MinHeight80(this Style style) => MinHeight(style, Length.Percent(80));
        public static Style MinHeight85() => MinHeight85(new Style());
        public static Style MinHeight85(this Style style) => MinHeight(style, Length.Percent(85));
        public static Style MinHeight90() => MinHeight90(new Style());
        public static Style MinHeight90(this Style style) => MinHeight(style, Length.Percent(90));
        public static Style MinHeight95() => MinHeight95(new Style());
        public static Style MinHeight95(this Style style) => MinHeight(style, Length.Percent(95));
        public static Style MinHeight100() => MinHeight100(new Style());
        public static Style MinHeight100(this Style style) => MinHeight(style, Length.Percent(100));
        public static Style MinHeight(Length value) => MinHeight(new Style(), value);
        public static Style MinHeight(this Style style, Length value)
        {
            style.minHeight = value;
            return style;
        }
        public static Style MaxWidth0() => MaxWidth0(new Style());
        public static Style MaxWidth0(this Style style) => MaxWidth(style, Length.Percent(0));
        public static Style MaxWidth5() => MaxWidth5(new Style());
        public static Style MaxWidth5(this Style style) => MaxWidth(style, Length.Percent(5));
        public static Style MaxWidth10() => MaxWidth10(new Style());
        public static Style MaxWidth10(this Style style) => MaxWidth(style, Length.Percent(10));
        public static Style MaxWidth15() => MaxWidth15(new Style());
        public static Style MaxWidth15(this Style style) => MaxWidth(style, Length.Percent(15));
        public static Style MaxWidth20() => MaxWidth20(new Style());
        public static Style MaxWidth20(this Style style) => MaxWidth(style, Length.Percent(20));
        public static Style MaxWidth25() => MaxWidth25(new Style());
        public static Style MaxWidth25(this Style style) => MaxWidth(style, Length.Percent(25));
        public static Style MaxWidth30() => MaxWidth30(new Style());
        public static Style MaxWidth30(this Style style) => MaxWidth(style, Length.Percent(30));
        public static Style MaxWidth35() => MaxWidth35(new Style());
        public static Style MaxWidth35(this Style style) => MaxWidth(style, Length.Percent(35));
        public static Style MaxWidth40() => MaxWidth40(new Style());
        public static Style MaxWidth40(this Style style) => MaxWidth(style, Length.Percent(40));
        public static Style MaxWidth45() => MaxWidth45(new Style());
        public static Style MaxWidth45(this Style style) => MaxWidth(style, Length.Percent(45));
        public static Style MaxWidth50() => MaxWidth50(new Style());
        public static Style MaxWidth50(this Style style) => MaxWidth(style, Length.Percent(50));
        public static Style MaxWidth55() => MaxWidth55(new Style());
        public static Style MaxWidth55(this Style style) => MaxWidth(style, Length.Percent(55));
        public static Style MaxWidth60() => MaxWidth60(new Style());
        public static Style MaxWidth60(this Style style) => MaxWidth(style, Length.Percent(60));
        public static Style MaxWidth65() => MaxWidth65(new Style());
        public static Style MaxWidth65(this Style style) => MaxWidth(style, Length.Percent(65));
        public static Style MaxWidth70() => MaxWidth70(new Style());
        public static Style MaxWidth70(this Style style) => MaxWidth(style, Length.Percent(70));
        public static Style MaxWidth75() => MaxWidth75(new Style());
        public static Style MaxWidth75(this Style style) => MaxWidth(style, Length.Percent(75));
        public static Style MaxWidth80() => MaxWidth80(new Style());
        public static Style MaxWidth80(this Style style) => MaxWidth(style, Length.Percent(80));
        public static Style MaxWidth85() => MaxWidth85(new Style());
        public static Style MaxWidth85(this Style style) => MaxWidth(style, Length.Percent(85));
        public static Style MaxWidth90() => MaxWidth90(new Style());
        public static Style MaxWidth90(this Style style) => MaxWidth(style, Length.Percent(90));
        public static Style MaxWidth95() => MaxWidth95(new Style());
        public static Style MaxWidth95(this Style style) => MaxWidth(style, Length.Percent(95));
        public static Style MaxWidth100() => MaxWidth100(new Style());
        public static Style MaxWidth100(this Style style) => MaxWidth(style, Length.Percent(100));
        public static Style MaxWidth(Length value) => MaxWidth(new Style(), value);
        public static Style MaxWidth(this Style style, Length value)
        {
            style.maxWidth = value;
            return style;
        }
        public static Style MaxHeight0() => MaxHeight0(new Style());
        public static Style MaxHeight0(this Style style) => MaxHeight(style, Length.Percent(0));
        public static Style MaxHeight5() => MaxHeight5(new Style());
        public static Style MaxHeight5(this Style style) => MaxHeight(style, Length.Percent(5));
        public static Style MaxHeight10() => MaxHeight10(new Style());
        public static Style MaxHeight10(this Style style) => MaxHeight(style, Length.Percent(10));
        public static Style MaxHeight15() => MaxHeight15(new Style());
        public static Style MaxHeight15(this Style style) => MaxHeight(style, Length.Percent(15));
        public static Style MaxHeight20() => MaxHeight20(new Style());
        public static Style MaxHeight20(this Style style) => MaxHeight(style, Length.Percent(20));
        public static Style MaxHeight25() => MaxHeight25(new Style());
        public static Style MaxHeight25(this Style style) => MaxHeight(style, Length.Percent(25));
        public static Style MaxHeight30() => MaxHeight30(new Style());
        public static Style MaxHeight30(this Style style) => MaxHeight(style, Length.Percent(30));
        public static Style MaxHeight35() => MaxHeight35(new Style());
        public static Style MaxHeight35(this Style style) => MaxHeight(style, Length.Percent(35));
        public static Style MaxHeight40() => MaxHeight40(new Style());
        public static Style MaxHeight40(this Style style) => MaxHeight(style, Length.Percent(40));
        public static Style MaxHeight45() => MaxHeight45(new Style());
        public static Style MaxHeight45(this Style style) => MaxHeight(style, Length.Percent(45));
        public static Style MaxHeight50() => MaxHeight50(new Style());
        public static Style MaxHeight50(this Style style) => MaxHeight(style, Length.Percent(50));
        public static Style MaxHeight55() => MaxHeight55(new Style());
        public static Style MaxHeight55(this Style style) => MaxHeight(style, Length.Percent(55));
        public static Style MaxHeight60() => MaxHeight60(new Style());
        public static Style MaxHeight60(this Style style) => MaxHeight(style, Length.Percent(60));
        public static Style MaxHeight65() => MaxHeight65(new Style());
        public static Style MaxHeight65(this Style style) => MaxHeight(style, Length.Percent(65));
        public static Style MaxHeight70() => MaxHeight70(new Style());
        public static Style MaxHeight70(this Style style) => MaxHeight(style, Length.Percent(70));
        public static Style MaxHeight75() => MaxHeight75(new Style());
        public static Style MaxHeight75(this Style style) => MaxHeight(style, Length.Percent(75));
        public static Style MaxHeight80() => MaxHeight80(new Style());
        public static Style MaxHeight80(this Style style) => MaxHeight(style, Length.Percent(80));
        public static Style MaxHeight85() => MaxHeight85(new Style());
        public static Style MaxHeight85(this Style style) => MaxHeight(style, Length.Percent(85));
        public static Style MaxHeight90() => MaxHeight90(new Style());
        public static Style MaxHeight90(this Style style) => MaxHeight(style, Length.Percent(90));
        public static Style MaxHeight95() => MaxHeight95(new Style());
        public static Style MaxHeight95(this Style style) => MaxHeight(style, Length.Percent(95));
        public static Style MaxHeight100() => MaxHeight100(new Style());
        public static Style MaxHeight100(this Style style) => MaxHeight(style, Length.Percent(100));
        public static Style MaxHeight(Length value) => MaxHeight(new Style(), value);
        public static Style MaxHeight(this Style style, Length value)
        {
            style.maxHeight = value;
            return style;
        }
        
        // Background Color
        public static Style BackgroundWhite() => BackgroundWhite(new Style());
        public static Style BackgroundWhite(this Style style) => Background(new Style(), Color.white);
        public static Style BackgroundBlack() => BackgroundBlack(new Style());
        public static Style BackgroundBlack(this Style style) => Background(new Style(), Color.black);
        public static Style BackgroundClear() => BackgroundClear(new Style());
        public static Style BackgroundClear(this Style style) => Background(new Style(), Color.clear);
        public static Style Background(Color value) => Background(new Style(), value);
        public static Style Background(this Style style, Color value)
        {
            style.backgroundColor = value;
            return style;
        }
        
        // Border
        public static Style BorderTop(float width, Color color) => BorderTop(new Style(), width, color);
        public static Style BorderTop(this Style style, float width, Color color) => style.BorderTopWidth(width).BorderTopColor(color);
        public static Style BorderTopWidth(float value) => BorderTopWidth(new Style(), value);
        public static Style BorderTopWidth(this Style style, float value)
        {
            style.borderTopWidth = value;
            return style;
        }
        public static Style BorderTopColor(Color value) => BorderTopColor(new Style(), value);
        public static Style BorderTopColor(this Style style, Color value)
        {
            style.borderTopColor = value;
            return style;
        }
        public static Style BorderRight(float width, Color color) => BorderRight(new Style(), width, color);
        public static Style BorderRight(this Style style, float width, Color color) => style.BorderRightWidth(width).BorderRightColor(color);
        public static Style BorderRightWidth(float value) => BorderRightWidth(new Style(), value);
        public static Style BorderRightWidth(this Style style, float value)
        {
            style.borderRightWidth = value;
            return style;
        }
        public static Style BorderRightColor(Color value) => BorderRightColor(new Style(), value);
        public static Style BorderRightColor(this Style style, Color value)
        {
            style.borderRightColor = value;
            return style;
        }
        public static Style BorderBottom(float width, Color color) => BorderBottom(new Style(), width, color);
        public static Style BorderBottom(this Style style, float width, Color color) => style.BorderBottomWidth(width).BorderBottomColor(color);
        public static Style BorderBottomWidth(float value) => BorderBottomWidth(new Style(), value);
        public static Style BorderBottomWidth(this Style style, float value)
        {
            style.borderBottomWidth = value;
            return style;
        }
        public static Style BorderBottomColor(Color value) => BorderBottomColor(new Style(), value);
        public static Style BorderBottomColor(this Style style, Color value)
        {
            style.borderBottomColor = value;
            return style;
        }
        public static Style BorderLeft(float width, Color color) => BorderLeft(new Style(), width, color);
        public static Style BorderLeft(this Style style, float width, Color color) => style.BorderLeftWidth(width).BorderLeftColor(color);
        public static Style BorderLeftWidth(float value) => BorderLeftWidth(new Style(), value);
        public static Style BorderLeftWidth(this Style style, float value)
        {
            style.borderLeftWidth = value;
            return style;
        }
        public static Style BorderLeftColor(Color value) => BorderLeftColor(new Style(), value);
        public static Style BorderLeftColor(this Style style, Color value)
        {
            style.borderLeftColor = value;
            return style;
        }
        public static Style Border(float width, Color color) => Border(new Style(), width, color);
        public static Style Border(this Style style, float width, Color color) => style.BorderWidth(width).BorderColor(color);
        public static Style BorderWidth(float value) => BorderWidth(new Style(), value);
        public static Style BorderWidth(this Style style, float value)
        {
            style.borderWidth = value;
            return style;
        }
        public static Style BorderColor(Color value) => BorderColor(new Style(), value);
        public static Style BorderColor(this Style style, Color value)
        {
            style.borderColor = value;
            return style;
        }
        
        public static Style BorderWhite() => BorderWhite(new Style());
        public static Style BorderWhite(this Style style) => BorderColor(style, Color.white);
        public static Style BorderBlack() => BorderBlack(new Style());
        public static Style BorderBlack(this Style style) => BorderColor(style, Color.black);
        public static Style BorderClear() => BorderClear(new Style());
        public static Style BorderClear(this Style style) => BorderColor(style, Color.clear);
        public static Style Border0() => Border0(new Style());
        public static Style Border0(this Style style) => BorderWidth(style, 0);
        public static Style BorderTop0() => BorderTop0(new Style());
        public static Style BorderTop0(this Style style) => BorderTopWidth(style, 0);
        public static Style BorderRight0() => BorderRight0(new Style());
        public static Style BorderRight0(this Style style) => BorderRightWidth(style, 0);
        public static Style BorderBottom0() => BorderBottom0(new Style());
        public static Style BorderBottom0(this Style style) => BorderBottomWidth(style, 0);
        public static Style BorderLeft0() => BorderLeft0(new Style());
        public static Style BorderLeft0(this Style style) => BorderLeftWidth(style, 0);
        
        // Text Color
        public static Style TextWhite() => TextWhite(new Style());
        public static Style TextWhite(this Style style) => Text(new Style(), Color.white);
        public static Style TextBlack() => TextBlack(new Style());
        public static Style TextBlack(this Style style) => Text(new Style(), Color.black);
        public static Style TextClear() => TextClear(new Style());
        public static Style TextClear(this Style style) => Text(new Style(), Color.clear);
        public static Style Text(Color value) => Text(new Style(), value);
        public static Style Text(this Style style, Color value)
        {
            style.color = value;
            return style;
        }
        
        // Corner Radius
        public static Style Circle() => Circle(new Style());
        public static Style Circle(this Style style) => Rounded(Length.Percent(50));
        public static Style RoundedTopLeft(Length value) => RoundedTopLeft(new Style(), value);
        public static Style RoundedTopLeft(this Style style, Length value)
        {
            style.borderTopLeftRadius = value;
            return style;
        }
        public static Style RoundedTopRight(Length value) => RoundedTopRight(new Style(), value);
        public static Style RoundedTopRight(this Style style, Length value)
        {
            style.borderTopRightRadius = value;
            return style;
        }
        public static Style RoundedBottomRight(Length value) => RoundedBottomRight(new Style(), value);
        public static Style RoundedBottomRight(this Style style, Length value)
        {
            style.borderBottomRightRadius = value;
            return style;
        }
        public static Style RoundedBottomLeft(Length value) => RoundedBottomLeft(new Style(), value);
        public static Style RoundedBottomLeft(this Style style, Length value)
        {
            style.borderBottomLeftRadius = value;
            return style;
        }
        public static Style Rounded(Length value) => Rounded(new Style(), value);
        public static Style Rounded(this Style style, Length value)
        {
            style.borderRadius = value;
            return style;
        }
        
        // Text Wrapping
        public static Style TextWrap() => TextWrap(new Style());
        public static Style TextWrap(this Style style) => WhiteSpace(UnityEngine.UIElements.WhiteSpace.Normal);
        public static Style TextNoWrap() => TextNoWrap(new Style());
        public static Style TextNoWrap(this Style style) => WhiteSpace(UnityEngine.UIElements.WhiteSpace.NoWrap);
        public static Style WhiteSpace(WhiteSpace value) => WhiteSpace(new Style(), value);
        public static Style WhiteSpace(this Style style, WhiteSpace value)
        {
            style.whiteSpace = value;
            return style;
        }
        
        // Font Size
        public static Style FontSize(Length value) => FontSize(new Style(), value);
        public static Style FontSize(this Style style, Length value)
        {
            style.fontSize = value;
            return style;
        }
        
        // Font Style
        public static Style FontStyleNormal() => FontStyleNormal(new Style());
        public static Style FontStyleNormal(this Style style) => FontStyle(style, UnityEngine.FontStyle.Normal);
        public static Style FontStyleBold() => FontStyleBold(new Style());
        public static Style FontStyleBold(this Style style) => FontStyle(style, UnityEngine.FontStyle.Bold);
        public static Style FontStyleItalic() => FontStyleItalic(new Style());
        public static Style FontStyleItalic(this Style style) => FontStyle(style, UnityEngine.FontStyle.Italic);
        public static Style FontStyleBoldAndItalic() => FontStyleBoldAndItalic(new Style());
        public static Style FontStyleBoldAndItalic(this Style style) => FontStyle(style, UnityEngine.FontStyle.BoldAndItalic);
        public static Style FontStyle(FontStyle value) => FontStyle(new Style(), value);
        public static Style FontStyle(this Style style, FontStyle value)
        {
            style.unityFontStyleAndWeight = value;
            return style;
        }
        
        // Pointer Detection
        public static Style PointerInherit() => PointerInherit(new Style());
        public static Style PointerInherit(this Style style) => PointerDetection(style, PointerDetectionMode.Inherit);
        public static Style PointerDetection() => PointerDetection(new Style());
        public static Style PointerDetection(this Style style) => PointerDetection(style, PointerDetectionMode.Rect);
        public static Style PointerIgnore() => PointerIgnore(new Style());
        public static Style PointerIgnore(this Style style) => PointerDetection(style, PointerDetectionMode.Ignore);
        public static Style PointerForceIgnore() => PointerForceIgnore(new Style());
        public static Style PointerForceIgnore(this Style style) => PointerDetection(style, PointerDetectionMode.ForceIgnore);
        public static Style PointerNone() => PointerNone(new Style());
        public static Style PointerNone(this Style style) => PointerForceIgnore(style);
        public static Style PointerDetection(this Style style, PointerDetectionMode value)
        {
            style.pointerDetection = value;
            return style;
        }
        
        // Scale
        public static Style Scale(float value) => Scale(new Style(), value);
        public static Style Scale(this Style style, float value) => Scale(style, value, value);
        public static Style Scale(float xValue, float yValue) => Scale(new Style(), xValue, yValue);
        public static Style Scale(this Style style, float xValue, float yValue) => Scale(style, new Vector3(xValue, yValue, 1));
        public static Style Scale(Vector2 value) => Scale(value.x, value.y);
        public static Style Scale(this Style style, Vector2 value) => Scale(style, value.x, value.y);
        public static Style Scale(Vector3 value) => Scale(new Style(), value);
        public static Style Scale(this Style style, Vector3 value)
        {
            style.scale = value;
            return style;
        }
        
        // Transform Origin
        public static Style TransformOriginTopLeft() => TransformOriginTopLeft(new Style());
        public static Style TransformOriginTopLeft(this Style style) => TransformOrigin(style, new TransformOrigin(0, 0, 0));
        public static Style TransformOriginTopCenter() => TransformOriginTopCenter(new Style());
        public static Style TransformOriginTopCenter(this Style style) => TransformOrigin(style, new TransformOrigin(Length.Percent(50), 0, 0));
        public static Style TransformOriginTopRight() => TransformOriginTopRight(new Style());
        public static Style TransformOriginTopRight(this Style style) => TransformOrigin(style, new TransformOrigin(Length.Percent(100), 0, 0));
        public static Style TransformOriginMiddleLeft() => TransformOriginMiddleLeft(new Style());
        public static Style TransformOriginMiddleLeft(this Style style) => TransformOrigin(style, new TransformOrigin(0, Length.Percent(50), 0));
        public static Style TransformOriginMiddleCenter() => TransformOriginMiddleCenter(new Style());
        public static Style TransformOriginMiddleCenter(this Style style) => TransformOrigin(style, new TransformOrigin(Length.Percent(50), Length.Percent(50), 0));
        public static Style TransformOriginMiddleRight() => TransformOriginMiddleRight(new Style());
        public static Style TransformOriginMiddleRight(this Style style) => TransformOrigin(style, new TransformOrigin(Length.Percent(100), Length.Percent(50), 0));
        public static Style TransformOriginBottomLeft() => TransformOriginBottomLeft(new Style());
        public static Style TransformOriginBottomLeft(this Style style) => TransformOrigin(style, new TransformOrigin(0, Length.Percent(100), 0));
        public static Style TransformOriginBottomCenter() => TransformOriginBottomCenter(new Style());
        public static Style TransformOriginBottomCenter(this Style style) => TransformOrigin(style, new TransformOrigin(Length.Percent(50), Length.Percent(100), 0));
        public static Style TransformOriginBottomRight() => TransformOriginBottomRight(new Style());
        public static Style TransformOriginBottomRight(this Style style) => TransformOrigin(style, new TransformOrigin(Length.Percent(100), Length.Percent(100), 0));
        public static Style TransformOrigin(TransformOrigin value) => TransformOrigin(new Style(), value);
        public static Style TransformOrigin(this Style style, TransformOrigin value)
        {
            style.transformOrigin = value;
            return style;
        }
    }
}
