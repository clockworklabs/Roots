using System;
using UnityEngine.UIElements;

namespace Roots
{
    public enum GrowAndShrink { Grow0, Grow1, Shrink0, Shrink1 }
    [Flags]
    public enum Translate { Middle = 1, X = 2, Y = 4 }
    public struct ResponsiveUtility<T> where T : unmanaged
    {
        public T? xs;
        public T? sm;
        public T? md;
        public T? lg;
        public T? xl;
        public T? xxl;
    }
    public struct Utilities
    {
        public ResponsiveUtility<DisplayStyle> display;
        public ResponsiveUtility<FlexDirection> flexDirection;
        public ResponsiveUtility<Justify> justifyContent;
        public ResponsiveUtility<Align> alignItems;
        public ResponsiveUtility<Align> alignSelf;
        public ResponsiveUtility<bool> fill;
        public ResponsiveUtility<GrowAndShrink> growAndShrink;
        public ResponsiveUtility<Wrap> wrap;
        public ResponsiveUtility<Align> alignContent;
        // TODO: Margins
        // TODO: Paddings
        // TODO: Gaps
        public ResponsiveUtility<Visibility> visibility;
        public int? opacity;
        public Overflow? overflow;
        public Position? position;
        public int? top;
        public int? bottom;
        public int? start;
        public int? end;
        public Translate? translate;
        // TODO: Sizing
        
        public static Utilities None => default;
        
        // Display
        public Utilities DisplayNone(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetDisplay(DisplayStyle.None, xs, sm, md, lg, xl, xxl);
        public Utilities DisplayFlex(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetDisplay(DisplayStyle.Flex, xs, sm, md, lg, xl, xxl);
        private Utilities SetDisplay(DisplayStyle value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetDisplay(value);
            }

            return SetDisplay(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetDisplay(DisplayStyle? xs, DisplayStyle? sm = default, DisplayStyle? md = default, DisplayStyle? lg = default, DisplayStyle? xl = default, DisplayStyle? xxl = default)
        {
            if (xs.HasValue)
            {
                display.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                display.xs = sm.Value;
            }
            if (md.HasValue)
            {
                display.xs = md.Value;
            }
            if (lg.HasValue)
            {
                display.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                display.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                display.xs = xxl.Value;
            }
            return this;
        }
        
        // Flex Direction
        public Utilities FlexRow(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetFlexDirection(FlexDirection.Row, xs, sm, md, lg, xl, xxl);
        public Utilities FlexRowReverse(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetFlexDirection(FlexDirection.RowReverse, xs, sm, md, lg, xl, xxl);
        public Utilities FlexColumn(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetFlexDirection(FlexDirection.Column, xs, sm, md, lg, xl, xxl);
        public Utilities FlexColumnReverse(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetFlexDirection(FlexDirection.ColumnReverse, xs, sm, md, lg, xl, xxl);
        private Utilities SetFlexDirection(FlexDirection value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetFlexDirection(value);
            }

            return SetFlexDirection(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetFlexDirection(FlexDirection? xs, FlexDirection? sm = default, FlexDirection? md = default, FlexDirection? lg = default, FlexDirection? xl = default, FlexDirection? xxl = default)
        {
            if (xs.HasValue)
            {
                flexDirection.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                flexDirection.xs = sm.Value;
            }
            if (md.HasValue)
            {
                flexDirection.xs = md.Value;
            }
            if (lg.HasValue)
            {
                flexDirection.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                flexDirection.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                flexDirection.xs = xxl.Value;
            }
            return this;
        }
        
        // Justify Content
        public Utilities JustifyContentStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetJustifyContent(Justify.FlexStart, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetJustifyContent(Justify.Center, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetJustifyContent(Justify.FlexEnd, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentBetween(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetJustifyContent(Justify.SpaceBetween, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentAround(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetJustifyContent(Justify.SpaceAround, xs, sm, md, lg, xl, xxl);
        private Utilities SetJustifyContent(Justify value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetJustifyContent(value);
            }
        
            return SetJustifyContent(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetJustifyContent(Justify? xs, Justify? sm = default, Justify? md = default, Justify? lg = default, Justify? xl = default, Justify? xxl = default)
        {
            if (xs.HasValue)
            {
                justifyContent.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                justifyContent.xs = sm.Value;
            }
            if (md.HasValue)
            {
                justifyContent.xs = md.Value;
            }
            if (lg.HasValue)
            {
                justifyContent.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                justifyContent.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                justifyContent.xs = xxl.Value;
            }
            return this;
        }
        
        // Align Items
        public Utilities AlignItemsStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignItems(Align.FlexStart, xs, sm, md, lg, xl, xxl);
        public Utilities AlignItemsCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignItems(Align.Center, xs, sm, md, lg, xl, xxl);
        public Utilities AlignItemsEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignItems(Align.FlexEnd, xs, sm, md, lg, xl, xxl);
        public Utilities AlignItemsStretch(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignItems(Align.Stretch, xs, sm, md, lg, xl, xxl);
        private Utilities SetAlignItems(Align value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetAlignItems(value);
            }
        
            return SetAlignItems(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetAlignItems(Align? xs, Align? sm = default, Align? md = default, Align? lg = default, Align? xl = default, Align? xxl = default)
        {
            if (xs.HasValue)
            {
                alignItems.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                alignItems.xs = sm.Value;
            }
            if (md.HasValue)
            {
                alignItems.xs = md.Value;
            }
            if (lg.HasValue)
            {
                alignItems.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                alignItems.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                alignItems.xs = xxl.Value;
            }
            return this;
        }
        
        // Align Self
        public Utilities AlignSelfStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignSelf(Align.FlexStart, xs, sm, md, lg, xl, xxl);
        public Utilities AlignSelfCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignSelf(Align.Center, xs, sm, md, lg, xl, xxl);
        public Utilities AlignSelfEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignSelf(Align.FlexEnd, xs, sm, md, lg, xl, xxl);
        public Utilities AlignSelfStretch(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignSelf(Align.Stretch, xs, sm, md, lg, xl, xxl);
        private Utilities SetAlignSelf(Align value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetAlignSelf(value);
            }
        
            return SetAlignSelf(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetAlignSelf(Align? xs, Align? sm = default, Align? md = default, Align? lg = default, Align? xl = default, Align? xxl = default)
        {
            if (xs.HasValue)
            {
                alignSelf.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                alignSelf.xs = sm.Value;
            }
            if (md.HasValue)
            {
                alignSelf.xs = md.Value;
            }
            if (lg.HasValue)
            {
                alignSelf.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                alignSelf.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                alignSelf.xs = xxl.Value;
            }
            return this;
        }
        
        // Fill
        public Utilities Fill(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetFill(true, xs, sm, md, lg, xl, xxl);
        private Utilities SetFill(bool value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetFill(value);
            }
        
            return SetFill(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetFill(bool? xs, bool? sm = default, bool? md = default, bool? lg = default, bool? xl = default, bool? xxl = default)
        {
            if (xs.HasValue)
            {
                fill.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                fill.xs = sm.Value;
            }
            if (md.HasValue)
            {
                fill.xs = md.Value;
            }
            if (lg.HasValue)
            {
                fill.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                fill.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                fill.xs = xxl.Value;
            }
            return this;
        }
        
        // Grow & Shrink
        public Utilities FlexGrow0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetGrowAndShrink(GrowAndShrink.Grow0, xs, sm, md, lg, xl, xxl);
        public Utilities FlexGrow1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetGrowAndShrink(GrowAndShrink.Grow1, xs, sm, md, lg, xl, xxl);
        public Utilities FlexShrink0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetGrowAndShrink(GrowAndShrink.Shrink0, xs, sm, md, lg, xl, xxl);
        public Utilities FlexShrink1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetGrowAndShrink(GrowAndShrink.Shrink1, xs, sm, md, lg, xl, xxl);
        private Utilities SetGrowAndShrink(GrowAndShrink value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetGrowAndShrink(value);
            }
        
            return SetGrowAndShrink(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetGrowAndShrink(GrowAndShrink? xs, GrowAndShrink? sm = default, GrowAndShrink? md = default, GrowAndShrink? lg = default, GrowAndShrink? xl = default, GrowAndShrink? xxl = default)
        {
            if (xs.HasValue)
            {
                growAndShrink.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                growAndShrink.xs = sm.Value;
            }
            if (md.HasValue)
            {
                growAndShrink.xs = md.Value;
            }
            if (lg.HasValue)
            {
                growAndShrink.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                growAndShrink.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                growAndShrink.xs = xxl.Value;
            }
            return this;
        }

        // Wrap
        public Utilities FlexNoWrap(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetWrap(Wrap.NoWrap, xs, sm, md, lg, xl, xxl);
        public Utilities FlexWrap(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetWrap(Wrap.Wrap, xs, sm, md, lg, xl, xxl);
        public Utilities FlexWrapReverse(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetWrap(Wrap.WrapReverse, xs, sm, md, lg, xl, xxl);
        private Utilities SetWrap(Wrap value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetWrap(value);
            }
        
            return SetWrap(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetWrap(Wrap? xs, Wrap? sm = default, Wrap? md = default, Wrap? lg = default, Wrap? xl = default, Wrap? xxl = default)
        {
            if (xs.HasValue)
            {
                wrap.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                wrap.xs = sm.Value;
            }
            if (md.HasValue)
            {
                wrap.xs = md.Value;
            }
            if (lg.HasValue)
            {
                wrap.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                wrap.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                wrap.xs = xxl.Value;
            }
            return this;
        }
        
        // Align Content
        public Utilities AlignContentStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignContent(Align.FlexStart, xs, sm, md, lg, xl, xxl);
        public Utilities AlignContentCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignContent(Align.Center, xs, sm, md, lg, xl, xxl);
        public Utilities AlignContentEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignContent(Align.FlexEnd, xs, sm, md, lg, xl, xxl);
        public Utilities AlignContentStretch(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetAlignContent(Align.Stretch, xs, sm, md, lg, xl, xxl);
        private Utilities SetAlignContent(Align value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetAlignContent(value);
            }
        
            return SetAlignContent(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetAlignContent(Align? xs, Align? sm = default, Align? md = default, Align? lg = default, Align? xl = default, Align? xxl = default)
        {
            if (xs.HasValue)
            {
                alignContent.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                alignContent.xs = sm.Value;
            }
            if (md.HasValue)
            {
                alignContent.xs = md.Value;
            }
            if (lg.HasValue)
            {
                alignContent.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                alignContent.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                alignContent.xs = xxl.Value;
            }
            return this;
        }
        
        // TODO: Margins
        // TODO: Paddings
        // TODO: Gaps

        // Visibility
        public Utilities Visible(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetVisibility(Visibility.Visible, xs, sm, md, lg, xl, xxl);
        public Utilities Invisible(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => SetVisibility(Visibility.Hidden, xs, sm, md, lg, xl, xxl);
        private Utilities SetVisibility(Visibility value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return SetVisibility(value);
            }
        
            return SetVisibility(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities SetVisibility(Visibility? xs, Visibility? sm = default, Visibility? md = default, Visibility? lg = default, Visibility? xl = default, Visibility? xxl = default)
        {
            if (xs.HasValue)
            {
                visibility.xs = xs.Value;
            }
            if (sm.HasValue)
            {
                visibility.xs = sm.Value;
            }
            if (md.HasValue)
            {
                visibility.xs = md.Value;
            }
            if (lg.HasValue)
            {
                visibility.xs = lg.Value;
            }
            if (xl.HasValue)
            {
                visibility.xs = xl.Value;
            }
            if (xxl.HasValue)
            {
                visibility.xs = xxl.Value;
            }
            return this;
        }

        // Opacity
        public Utilities Opacity0() => SetOpacity(0);
        public Utilities Opacity25() => SetOpacity(25);
        public Utilities Opacity50() => SetOpacity(50);
        public Utilities Opacity75() => SetOpacity(75);
        public Utilities Opacity100() => SetOpacity(100);
        private Utilities SetOpacity(int value)
        {
            opacity = value;
            return this;
        }

        // Overflow
        public Utilities OverflowHidden() => SetOverflow(Overflow.Hidden);
        public Utilities OverflowVisible() => SetOverflow(Overflow.Visible);
        private Utilities SetOverflow(Overflow value)
        {
            overflow = value;
            return this;
        }

        // Position
        public Utilities PositionRelative() => SetPosition(Position.Relative);
        public Utilities PositionAbsolute() => SetPosition(Position.Absolute);
        private Utilities SetPosition(Position value)
        {
            position = value;
            return this;
        }

        // Arrange Elements
        public Utilities Top0() => SetTop(0);
        public Utilities Top50() => SetTop(25);
        public Utilities Top100() => SetTop(50);
        private Utilities SetTop(int value)
        {
            top = value;
            return this;
        }
        public Utilities Bottom0() => SetBottom(0);
        public Utilities Bottom50() => SetBottom(25);
        public Utilities Bottom100() => SetBottom(50);
        private Utilities SetBottom(int value)
        {
            bottom = value;
            return this;
        }
        public Utilities Start0() => SetStart(0);
        public Utilities Start50() => SetStart(25);
        public Utilities Start100() => SetStart(50);
        private Utilities SetStart(int value)
        {
            start = value;
            return this;
        }
        public Utilities End0() => SetEnd(0);
        public Utilities End50() => SetEnd(25);
        public Utilities End100() => SetEnd(50);
        private Utilities SetEnd(int value)
        {
            end = value;
            return this;
        }
        public Utilities TranslateMiddle() => OrTranslate(Translate.Middle);
        public Utilities TranslateX() => OrTranslate(Translate.X);
        public Utilities TranslateY() => OrTranslate(Translate.Y);
        private Utilities OrTranslate(Translate value)
        {
            if (translate.HasValue)
            {
                translate = translate.Value | value;
            }
            else
            {
                translate = value;
            }
            return this;
        }
        
        // TODO: Sizing
    }
}
