using System;
using RishUI;
using UnityEngine.UIElements;

namespace Roots
{
    public struct Utilities
    {   
        // Responsive
        private ResponsiveUtility<DisplayFlags> display;
        private ResponsiveUtility<FlexDirectionFlags> flexDirection;
        private ResponsiveUtility<JustifyContentFlags> justifyContent;
        private ResponsiveUtility<AlignFlags> alignItems;
        private ResponsiveUtility<AlignFlags> alignSelf;
        private ResponsiveUtility<FillFlags> fill;
        private ResponsiveUtility<GrowAndShrinkFlags> growAndShrink;
        private ResponsiveUtility<WrapFlags> wrap;
        private ResponsiveUtility<AlignFlags> alignContent;
        private ResponsiveUtility<Margins> margins;
        private ResponsiveUtility<Paddings> paddings;
        private ResponsiveUtility<Gaps> gaps;
        private ResponsiveUtility<TextAlignmentFlags> textAlignment;
        private ResponsiveUtility<VisibilityFlags> visibility;
        // Not Responsive
        private AbsoluteFillFlags absoluteFill;
        private OpacityFlags opacity;
        private OverflowFlags overflow;
        private PositionFlags position;
        private ArrangeElementsFlags arrangeElements;
        private SizingFlags sizing;
        private BackgroundFlags background;
        private Borders borders;
        private ColorsFlags colors;
        private RoundedCorners roundedCorners;
        private TextWrappingFlags textWrapping;
        private FontSizeFlags fontSize;
        private FontStyleFlags fontStyle;
        
        public static Utilities None => default;
        
        // Display
        public Utilities DisplayNone(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrDisplay(DisplayFlags.None, xs, sm, md, lg, xl, xxl);
        public Utilities DisplayFlex(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrDisplay(DisplayFlags.Flex, xs, sm, md, lg, xl, xxl);
        private Utilities OrDisplay(DisplayFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrDisplay(value);
            }

            return OrDisplay(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrDisplay(DisplayFlags? xs, DisplayFlags? sm = default, DisplayFlags? md = default, DisplayFlags? lg = default, DisplayFlags? xl = default, DisplayFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                display.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                display.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                display.md |= md.Value;
            }
            if (lg.HasValue)
            {
                display.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                display.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                display.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Flex Direction
        public Utilities FlexRow(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrFlexDirection(FlexDirectionFlags.Row, xs, sm, md, lg, xl, xxl);
        public Utilities FlexRowReverse(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrFlexDirection(FlexDirectionFlags.RowReverse, xs, sm, md, lg, xl, xxl);
        public Utilities FlexColumn(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrFlexDirection(FlexDirectionFlags.Column, xs, sm, md, lg, xl, xxl);
        public Utilities FlexColumnReverse(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrFlexDirection(FlexDirectionFlags.ColumnReverse, xs, sm, md, lg, xl, xxl);
        private Utilities OrFlexDirection(FlexDirectionFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrFlexDirection(value);
            }

            return OrFlexDirection(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrFlexDirection(FlexDirectionFlags? xs, FlexDirectionFlags? sm = default, FlexDirectionFlags? md = default, FlexDirectionFlags? lg = default, FlexDirectionFlags? xl = default, FlexDirectionFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                flexDirection.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                flexDirection.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                flexDirection.md |= md.Value;
            }
            if (lg.HasValue)
            {
                flexDirection.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                flexDirection.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                flexDirection.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Justify Content
        public Utilities JustifyContentStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrJustifyContent(JustifyContentFlags.Start, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrJustifyContent(JustifyContentFlags.Center, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrJustifyContent(JustifyContentFlags.End, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentBetween(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrJustifyContent(JustifyContentFlags.Between, xs, sm, md, lg, xl, xxl);
        public Utilities JustifyContentAround(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrJustifyContent(JustifyContentFlags.Around, xs, sm, md, lg, xl, xxl);
        private Utilities OrJustifyContent(JustifyContentFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrJustifyContent(value);
            }
        
            return OrJustifyContent(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrJustifyContent(JustifyContentFlags? xs, JustifyContentFlags? sm = default, JustifyContentFlags? md = default, JustifyContentFlags? lg = default, JustifyContentFlags? xl = default, JustifyContentFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                justifyContent.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                justifyContent.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                justifyContent.md |= md.Value;
            }
            if (lg.HasValue)
            {
                justifyContent.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                justifyContent.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                justifyContent.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Align Items
        public Utilities AlignItemsStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignItems(AlignFlags.Start, xs, sm, md, lg, xl, xxl);
        public Utilities AlignItemsCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignItems(AlignFlags.Center, xs, sm, md, lg, xl, xxl);
        public Utilities AlignItemsEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignItems(AlignFlags.End, xs, sm, md, lg, xl, xxl);
        public Utilities AlignItemsStretch(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignItems(AlignFlags.Stretch, xs, sm, md, lg, xl, xxl);
        private Utilities OrAlignItems(AlignFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrAlignItems(value);
            }
        
            return OrAlignItems(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrAlignItems(AlignFlags? xs, AlignFlags? sm = default, AlignFlags? md = default, AlignFlags? lg = default, AlignFlags? xl = default, AlignFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                alignItems.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                alignItems.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                alignItems.md |= md.Value;
            }
            if (lg.HasValue)
            {
                alignItems.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                alignItems.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                alignItems.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Align Self
        public Utilities AlignSelfStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignSelf(AlignFlags.Start, xs, sm, md, lg, xl, xxl);
        public Utilities AlignSelfCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignSelf(AlignFlags.Center, xs, sm, md, lg, xl, xxl);
        public Utilities AlignSelfEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignSelf(AlignFlags.End, xs, sm, md, lg, xl, xxl);
        public Utilities AlignSelfStretch(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignSelf(AlignFlags.Stretch, xs, sm, md, lg, xl, xxl);
        private Utilities OrAlignSelf(AlignFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrAlignSelf(value);
            }
        
            return OrAlignSelf(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrAlignSelf(AlignFlags? xs, AlignFlags? sm = default, AlignFlags? md = default, AlignFlags? lg = default, AlignFlags? xl = default, AlignFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                alignSelf.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                alignSelf.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                alignSelf.md |= md.Value;
            }
            if (lg.HasValue)
            {
                alignSelf.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                alignSelf.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                alignSelf.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Fill
        public Utilities Fill(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrFill(FillFlags.Set, xs, sm, md, lg, xl, xxl);
        private Utilities OrFill(FillFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrFill(value);
            }
        
            return OrFill(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrFill(FillFlags? xs, FillFlags? sm = default, FillFlags? md = default, FillFlags? lg = default, FillFlags? xl = default, FillFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                fill.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                fill.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                fill.md |= md.Value;
            }
            if (lg.HasValue)
            {
                fill.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                fill.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                fill.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Grow & Shrink
        public Utilities FlexGrow0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGrowAndShrink(GrowAndShrinkFlags.Grow0, xs, sm, md, lg, xl, xxl);
        public Utilities FlexGrow1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGrowAndShrink(GrowAndShrinkFlags.Grow1, xs, sm, md, lg, xl, xxl);
        public Utilities FlexShrink0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGrowAndShrink(GrowAndShrinkFlags.Shrink0, xs, sm, md, lg, xl, xxl);
        public Utilities FlexShrink1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGrowAndShrink(GrowAndShrinkFlags.Shrink1, xs, sm, md, lg, xl, xxl);
        private Utilities OrGrowAndShrink(GrowAndShrinkFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrGrowAndShrink(value);
            }
        
            return OrGrowAndShrink(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrGrowAndShrink(GrowAndShrinkFlags? xs, GrowAndShrinkFlags? sm = default, GrowAndShrinkFlags? md = default, GrowAndShrinkFlags? lg = default, GrowAndShrinkFlags? xl = default, GrowAndShrinkFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                growAndShrink.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                growAndShrink.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                growAndShrink.md |= md.Value;
            }
            if (lg.HasValue)
            {
                growAndShrink.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                growAndShrink.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                growAndShrink.xxl |= xxl.Value;
            }
            return this;
        }

        // Wrap
        public Utilities FlexNoWrap(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrWrap(WrapFlags.NoWrap, xs, sm, md, lg, xl, xxl);
        public Utilities FlexWrap(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrWrap(WrapFlags.Wrap, xs, sm, md, lg, xl, xxl);
        public Utilities FlexWrapReverse(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrWrap(WrapFlags.WrapReverse, xs, sm, md, lg, xl, xxl);
        private Utilities OrWrap(WrapFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrWrap(value);
            }
        
            return OrWrap(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrWrap(WrapFlags? xs, WrapFlags? sm = default, WrapFlags? md = default, WrapFlags? lg = default, WrapFlags? xl = default, WrapFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                wrap.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                wrap.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                wrap.md |= md.Value;
            }
            if (lg.HasValue)
            {
                wrap.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                wrap.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                wrap.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Align Content
        public Utilities AlignContentStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignContent(AlignFlags.Start, xs, sm, md, lg, xl, xxl);
        public Utilities AlignContentCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignContent(AlignFlags.Center, xs, sm, md, lg, xl, xxl);
        public Utilities AlignContentEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignContent(AlignFlags.End, xs, sm, md, lg, xl, xxl);
        public Utilities AlignContentStretch(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrAlignContent(AlignFlags.Stretch, xs, sm, md, lg, xl, xxl);
        private Utilities OrAlignContent(AlignFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrAlignContent(value);
            }
        
            return OrAlignContent(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrAlignContent(AlignFlags? xs, AlignFlags? sm = default, AlignFlags? md = default, AlignFlags? lg = default, AlignFlags? xl = default, AlignFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                alignContent.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                alignContent.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                alignContent.md |= md.Value;
            }
            if (lg.HasValue)
            {
                alignContent.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                alignContent.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                alignContent.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Margins
        public Utilities MarginTop0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTop1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTop2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTop3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTop4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTop5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTopAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTopNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTopNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTopNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTopNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginTopNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEnd0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEnd1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEnd2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEnd3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEnd4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEnd5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEndAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEndNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEndNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEndNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEndNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginEndNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        // TODO: Versions like this for every int value utility
        // public Utilities MarginBottom(int? xs = default, int? sm = default, int? md = default, int? lg = default, int? xl = default, int? xxl = default)
        // {
        //     var utilities = this;
        //     if (xs.HasValue)
        //     {
        //         var value = UnityEngine.Mathf.Clamp(xs.Value, 0, 5) switch
        //         {
        //             1 => MarginsFlags.Spacer1,
        //             2 => MarginsFlags.Spacer2,
        //             3 => MarginsFlags.Spacer3,
        //             4 => MarginsFlags.Spacer4,
        //             5 => MarginsFlags.Spacer5,
        //             _ => MarginsFlags.Zero,
        //         };
        //         utilities = utilities.OrMarginBottom(value, true, false, false, false, false, false);
        //     }
        //     if (sm.HasValue)
        //     {
        //         var value = UnityEngine.Mathf.Clamp(sm.Value, 0, 5) switch
        //         {
        //             1 => MarginsFlags.Spacer1,
        //             2 => MarginsFlags.Spacer2,
        //             3 => MarginsFlags.Spacer3,
        //             4 => MarginsFlags.Spacer4,
        //             5 => MarginsFlags.Spacer5,
        //             _ => MarginsFlags.Zero,
        //         };
        //         utilities = utilities.OrMarginBottom(value, false, true, false, false, false, false);
        //     }
        //     if (md.HasValue)
        //     {
        //         var value = UnityEngine.Mathf.Clamp(md.Value, 0, 5) switch
        //         {
        //             1 => MarginsFlags.Spacer1,
        //             2 => MarginsFlags.Spacer2,
        //             3 => MarginsFlags.Spacer3,
        //             4 => MarginsFlags.Spacer4,
        //             5 => MarginsFlags.Spacer5,
        //             _ => MarginsFlags.Zero,
        //         };
        //         utilities = utilities.OrMarginBottom(value, false, false, true, false, false, false);
        //     }
        //     if (lg.HasValue)
        //     {
        //         var value = UnityEngine.Mathf.Clamp(lg.Value, 0, 5) switch
        //         {
        //             1 => MarginsFlags.Spacer1,
        //             2 => MarginsFlags.Spacer2,
        //             3 => MarginsFlags.Spacer3,
        //             4 => MarginsFlags.Spacer4,
        //             5 => MarginsFlags.Spacer5,
        //             _ => MarginsFlags.Zero,
        //         };
        //         utilities = utilities.OrMarginBottom(value, false, false, false, true, false, false);
        //     }
        //     if (xl.HasValue)
        //     {
        //         var value = UnityEngine.Mathf.Clamp(xl.Value, 0, 5) switch
        //         {
        //             1 => MarginsFlags.Spacer1,
        //             2 => MarginsFlags.Spacer2,
        //             3 => MarginsFlags.Spacer3,
        //             4 => MarginsFlags.Spacer4,
        //             5 => MarginsFlags.Spacer5,
        //             _ => MarginsFlags.Zero,
        //         };
        //         utilities = utilities.OrMarginBottom(value, false, false, false, false, true, false);
        //     }
        //     if (xxl.HasValue)
        //     {
        //         var value = UnityEngine.Mathf.Clamp(xxl.Value, 0, 5) switch
        //         {
        //             1 => MarginsFlags.Spacer1,
        //             2 => MarginsFlags.Spacer2,
        //             3 => MarginsFlags.Spacer3,
        //             4 => MarginsFlags.Spacer4,
        //             5 => MarginsFlags.Spacer5,
        //             _ => MarginsFlags.Zero,
        //         };
        //         utilities = utilities.OrMarginBottom(value, false, false, false, false, false, true);
        //     }
        //
        //     return utilities;
        // }
        public Utilities MarginBottom0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottom1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottom2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottom3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottom4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottom5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottomAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottomNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottomNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottomNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottomNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginBottomNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStart0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStart1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStart2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStart3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStart4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStart5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStartAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStartNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStartNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStartNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStartNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginStartNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginX0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities MarginX1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginX2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginX3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginX4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginX5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginXAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities MarginXNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginXNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginXNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginXNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginXNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginY0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities MarginY1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginY2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginY3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginY4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginY5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginYAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities MarginYNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginYNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginYNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginYNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginYNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        public Utilities Margin0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities Margin1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities Margin2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities Margin3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities Margin4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities Margin5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities MarginAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities MarginNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        public Utilities MarginNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        public Utilities MarginNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        public Utilities MarginNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        public Utilities MarginNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        private Utilities OrMarginTop(MarginsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrMarginTop(value);
            }
        
            return OrMarginTop(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrMarginTop(MarginsFlags? xs, MarginsFlags? sm = default, MarginsFlags? md = default, MarginsFlags? lg = default, MarginsFlags? xl = default, MarginsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                margins.xs.top |= xs.Value;
            }
            if (sm.HasValue)
            {
                margins.sm.top |= sm.Value;
            }
            if (md.HasValue)
            {
                margins.md.top |= md.Value;
            }
            if (lg.HasValue)
            {
                margins.lg.top |= lg.Value;
            }
            if (xl.HasValue)
            {
                margins.xl.top |= xl.Value;
            }
            if (xxl.HasValue)
            {
                margins.xxl.top |= xxl.Value;
            }
            return this;
        }
        private Utilities OrMarginEnd(MarginsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrMarginEnd(value);
            }
        
            return OrMarginEnd(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrMarginEnd(MarginsFlags? xs, MarginsFlags? sm = default, MarginsFlags? md = default, MarginsFlags? lg = default, MarginsFlags? xl = default, MarginsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                margins.xs.end |= xs.Value;
            }
            if (sm.HasValue)
            {
                margins.sm.end |= sm.Value;
            }
            if (md.HasValue)
            {
                margins.md.end |= md.Value;
            }
            if (lg.HasValue)
            {
                margins.lg.end |= lg.Value;
            }
            if (xl.HasValue)
            {
                margins.xl.end |= xl.Value;
            }
            if (xxl.HasValue)
            {
                margins.xxl.end |= xxl.Value;
            }
            return this;
        }
        private Utilities OrMarginBottom(MarginsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrMarginBottom(value);
            }
        
            return OrMarginBottom(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrMarginBottom(MarginsFlags? xs, MarginsFlags? sm = default, MarginsFlags? md = default, MarginsFlags? lg = default, MarginsFlags? xl = default, MarginsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                margins.xs.bottom |= xs.Value;
            }
            if (sm.HasValue)
            {
                margins.sm.bottom |= sm.Value;
            }
            if (md.HasValue)
            {
                margins.md.bottom |= md.Value;
            }
            if (lg.HasValue)
            {
                margins.lg.bottom |= lg.Value;
            }
            if (xl.HasValue)
            {
                margins.xl.bottom |= xl.Value;
            }
            if (xxl.HasValue)
            {
                margins.xxl.bottom |= xxl.Value;
            }
            return this;
        }
        private Utilities OrMarginStart(MarginsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrMarginStart(value);
            }
        
            return OrMarginStart(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrMarginStart(MarginsFlags? xs, MarginsFlags? sm = default, MarginsFlags? md = default, MarginsFlags? lg = default, MarginsFlags? xl = default, MarginsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                margins.xs.start = xs.Value;
            }
            if (sm.HasValue)
            {
                margins.sm.start = sm.Value;
            }
            if (md.HasValue)
            {
                margins.md.start = md.Value;
            }
            if (lg.HasValue)
            {
                margins.lg.start = lg.Value;
            }
            if (xl.HasValue)
            {
                margins.xl.start = xl.Value;
            }
            if (xxl.HasValue)
            {
                margins.xxl.start = xxl.Value;
            }
            return this;
        }
        private Utilities OrMarginX(MarginsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrMarginX(value);
            }
        
            return OrMarginX(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrMarginX(MarginsFlags? xs, MarginsFlags? sm = default, MarginsFlags? md = default, MarginsFlags? lg = default, MarginsFlags? xl = default, MarginsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                margins.xs.x = xs.Value;
            }
            if (sm.HasValue)
            {
                margins.sm.x = sm.Value;
            }
            if (md.HasValue)
            {
                margins.md.x = md.Value;
            }
            if (lg.HasValue)
            {
                margins.lg.x = lg.Value;
            }
            if (xl.HasValue)
            {
                margins.xl.x = xl.Value;
            }
            if (xxl.HasValue)
            {
                margins.xxl.x = xxl.Value;
            }
            return this;
        }
        private Utilities OrMarginY(MarginsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrMarginY(value);
            }
        
            return OrMarginY(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrMarginY(MarginsFlags? xs, MarginsFlags? sm = default, MarginsFlags? md = default, MarginsFlags? lg = default, MarginsFlags? xl = default, MarginsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                margins.xs.y = xs.Value;
            }
            if (sm.HasValue)
            {
                margins.sm.y = sm.Value;
            }
            if (md.HasValue)
            {
                margins.md.y = md.Value;
            }
            if (lg.HasValue)
            {
                margins.lg.y = lg.Value;
            }
            if (xl.HasValue)
            {
                margins.xl.y = xl.Value;
            }
            if (xxl.HasValue)
            {
                margins.xxl.y = xxl.Value;
            }
            return this;
        }
        private Utilities OrMargin(MarginsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrMargin(value);
            }
        
            return OrMargin(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrMargin(MarginsFlags? xs, MarginsFlags? sm = default, MarginsFlags? md = default, MarginsFlags? lg = default, MarginsFlags? xl = default, MarginsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                margins.xs.general = xs.Value;
            }
            if (sm.HasValue)
            {
                margins.sm.general = sm.Value;
            }
            if (md.HasValue)
            {
                margins.md.general = md.Value;
            }
            if (lg.HasValue)
            {
                margins.lg.general = lg.Value;
            }
            if (xl.HasValue)
            {
                margins.xl.general = xl.Value;
            }
            if (xxl.HasValue)
            {
                margins.xxl.general = xxl.Value;
            }
            return this;
        }

        // Paddings
        public Utilities PaddingTop0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingTop1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingTop2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingTop3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingTop4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingTop5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingTopAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingEnd0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingEnd1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingEnd2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingEnd3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingEnd4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingEnd5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingEndAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingBottom0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingBottom1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingBottom2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingBottom3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingBottom4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingBottom5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingBottomAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingStart0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingStart1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingStart2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingStart3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingStart4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingStart5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingStartAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingX0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingX1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingX2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingX3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingX4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingX5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingXAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingY0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingY1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingY2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingY3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingY4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingY5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingYAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        public Utilities Padding0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities Padding1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities Padding2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities Padding3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities Padding4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities Padding5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities PaddingAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities OrPaddingTop(PaddingsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrPaddingTop(value);
            }
        
            return OrPaddingTop(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrPaddingTop(PaddingsFlags? xs, PaddingsFlags? sm = default, PaddingsFlags? md = default, PaddingsFlags? lg = default, PaddingsFlags? xl = default, PaddingsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                paddings.xs.top |= xs.Value;
            }
            if (sm.HasValue)
            {
                paddings.sm.top |= sm.Value;
            }
            if (md.HasValue)
            {
                paddings.md.top |= md.Value;
            }
            if (lg.HasValue)
            {
                paddings.lg.top |= lg.Value;
            }
            if (xl.HasValue)
            {
                paddings.xl.top |= xl.Value;
            }
            if (xxl.HasValue)
            {
                paddings.xxl.top |= xxl.Value;
            }
            return this;
        }
        private Utilities OrPaddingEnd(PaddingsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrPaddingEnd(value);
            }
        
            return OrPaddingEnd(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrPaddingEnd(PaddingsFlags? xs, PaddingsFlags? sm = default, PaddingsFlags? md = default, PaddingsFlags? lg = default, PaddingsFlags? xl = default, PaddingsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                paddings.xs.end |= xs.Value;
            }
            if (sm.HasValue)
            {
                paddings.sm.end |= sm.Value;
            }
            if (md.HasValue)
            {
                paddings.md.end |= md.Value;
            }
            if (lg.HasValue)
            {
                paddings.lg.end |= lg.Value;
            }
            if (xl.HasValue)
            {
                paddings.xl.end |= xl.Value;
            }
            if (xxl.HasValue)
            {
                paddings.xxl.end |= xxl.Value;
            }
            return this;
        }
        private Utilities OrPaddingBottom(PaddingsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrPaddingBottom(value);
            }
        
            return OrPaddingBottom(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrPaddingBottom(PaddingsFlags? xs, PaddingsFlags? sm = default, PaddingsFlags? md = default, PaddingsFlags? lg = default, PaddingsFlags? xl = default, PaddingsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                paddings.xs.bottom |= xs.Value;
            }
            if (sm.HasValue)
            {
                paddings.sm.bottom |= sm.Value;
            }
            if (md.HasValue)
            {
                paddings.md.bottom |= md.Value;
            }
            if (lg.HasValue)
            {
                paddings.lg.bottom |= lg.Value;
            }
            if (xl.HasValue)
            {
                paddings.xl.bottom |= xl.Value;
            }
            if (xxl.HasValue)
            {
                paddings.xxl.bottom |= xxl.Value;
            }
            return this;
        }
        private Utilities OrPaddingStart(PaddingsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrPaddingStart(value);
            }
        
            return OrPaddingStart(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrPaddingStart(PaddingsFlags? xs, PaddingsFlags? sm = default, PaddingsFlags? md = default, PaddingsFlags? lg = default, PaddingsFlags? xl = default, PaddingsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                paddings.xs.start |= xs.Value;
            }
            if (sm.HasValue)
            {
                paddings.sm.start |= sm.Value;
            }
            if (md.HasValue)
            {
                paddings.md.start |= md.Value;
            }
            if (lg.HasValue)
            {
                paddings.lg.start |= lg.Value;
            }
            if (xl.HasValue)
            {
                paddings.xl.start |= xl.Value;
            }
            if (xxl.HasValue)
            {
                paddings.xxl.start |= xxl.Value;
            }
            return this;
        }
        private Utilities OrPaddingX(PaddingsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrPaddingX(value);
            }
        
            return OrPaddingX(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrPaddingX(PaddingsFlags? xs, PaddingsFlags? sm = default, PaddingsFlags? md = default, PaddingsFlags? lg = default, PaddingsFlags? xl = default, PaddingsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                paddings.xs.x |= xs.Value;
            }
            if (sm.HasValue)
            {
                paddings.sm.x |= sm.Value;
            }
            if (md.HasValue)
            {
                paddings.md.x |= md.Value;
            }
            if (lg.HasValue)
            {
                paddings.lg.x |= lg.Value;
            }
            if (xl.HasValue)
            {
                paddings.xl.x |= xl.Value;
            }
            if (xxl.HasValue)
            {
                paddings.xxl.x |= xxl.Value;
            }
            return this;
        }
        private Utilities OrPaddingY(PaddingsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrPaddingY(value);
            }
        
            return OrPaddingY(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrPaddingY(PaddingsFlags? xs, PaddingsFlags? sm = default, PaddingsFlags? md = default, PaddingsFlags? lg = default, PaddingsFlags? xl = default, PaddingsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                paddings.xs.y |= xs.Value;
            }
            if (sm.HasValue)
            {
                paddings.sm.y |= sm.Value;
            }
            if (md.HasValue)
            {
                paddings.md.y |= md.Value;
            }
            if (lg.HasValue)
            {
                paddings.lg.y |= lg.Value;
            }
            if (xl.HasValue)
            {
                paddings.xl.y |= xl.Value;
            }
            if (xxl.HasValue)
            {
                paddings.xxl.y |= xxl.Value;
            }
            return this;
        }
        private Utilities OrPadding(PaddingsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrPadding(value);
            }
        
            return OrPadding(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrPadding(PaddingsFlags? xs, PaddingsFlags? sm = default, PaddingsFlags? md = default, PaddingsFlags? lg = default, PaddingsFlags? xl = default, PaddingsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                paddings.xs.general |= xs.Value;
            }
            if (sm.HasValue)
            {
                paddings.sm.general |= sm.Value;
            }
            if (md.HasValue)
            {
                paddings.md.general |= md.Value;
            }
            if (lg.HasValue)
            {
                paddings.lg.general |= lg.Value;
            }
            if (xl.HasValue)
            {
                paddings.xl.general |= xl.Value;
            }
            if (xxl.HasValue)
            {
                paddings.xxl.general |= xxl.Value;
            }
            return this;
        }
        
        // Gaps
        public Utilities RowGap0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities RowGap1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities RowGap2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities RowGap3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities RowGap4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities RowGap5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities ColumnGap0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities ColumnGap1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities ColumnGap2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities ColumnGap3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities ColumnGap4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities ColumnGap5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        public Utilities Gap0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Zero, xs, sm, md, lg, xl, xxl);
        public Utilities Gap1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        public Utilities Gap2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        public Utilities Gap3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        public Utilities Gap4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        public Utilities Gap5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities OrRowGap(GapsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrRowGap(value);
            }
        
            return OrRowGap(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrRowGap(GapsFlags? xs, GapsFlags? sm = default, GapsFlags? md = default, GapsFlags? lg = default, GapsFlags? xl = default, GapsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                gaps.xs.row |= xs.Value;
            }
            if (sm.HasValue)
            {
                gaps.sm.row |= sm.Value;
            }
            if (md.HasValue)
            {
                gaps.md.row |= md.Value;
            }
            if (lg.HasValue)
            {
                gaps.lg.row |= lg.Value;
            }
            if (xl.HasValue)
            {
                gaps.xl.row |= xl.Value;
            }
            if (xxl.HasValue)
            {
                gaps.xxl.row |= xxl.Value;
            }
            return this;
        }
        private Utilities OrColumnGap(GapsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrColumnGap(value);
            }
        
            return OrColumnGap(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrColumnGap(GapsFlags? xs, GapsFlags? sm = default, GapsFlags? md = default, GapsFlags? lg = default, GapsFlags? xl = default, GapsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                gaps.xs.column |= xs.Value;
            }
            if (sm.HasValue)
            {
                gaps.sm.column |= sm.Value;
            }
            if (md.HasValue)
            {
                gaps.md.column |= md.Value;
            }
            if (lg.HasValue)
            {
                gaps.lg.column |= lg.Value;
            }
            if (xl.HasValue)
            {
                gaps.xl.column |= xl.Value;
            }
            if (xxl.HasValue)
            {
                gaps.xxl.column |= xxl.Value;
            }
            return this;
        }
        private Utilities OrGap(GapsFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrGap(value);
            }
        
            return OrGap(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrGap(GapsFlags? xs, GapsFlags? sm = default, GapsFlags? md = default, GapsFlags? lg = default, GapsFlags? xl = default, GapsFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                gaps.xs.general |= xs.Value;
            }
            if (sm.HasValue)
            {
                gaps.sm.general |= sm.Value;
            }
            if (md.HasValue)
            {
                gaps.md.general |= md.Value;
            }
            if (lg.HasValue)
            {
                gaps.lg.general |= lg.Value;
            }
            if (xl.HasValue)
            {
                gaps.xl.general |= xl.Value;
            }
            if (xxl.HasValue)
            {
                gaps.xxl.general |= xxl.Value;
            }
            return this;
        }

        // Text Alignment
        public Utilities TextStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.Start, xs, sm, md, lg, xl, xxl);
        public Utilities TextEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.End, xs, sm, md, lg, xl, xxl);
        public Utilities TextCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.Center, xs, sm, md, lg, xl, xxl);
        public Utilities TextUpperStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.UpperStart, xs, sm, md, lg, xl, xxl);
        public Utilities TextUpperEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.UpperEnd, xs, sm, md, lg, xl, xxl);
        public Utilities TextUpperCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.UpperCenter, xs, sm, md, lg, xl, xxl);
        public Utilities TextMiddleStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.MiddleStart, xs, sm, md, lg, xl, xxl);
        public Utilities TextMiddleEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.MiddleEnd, xs, sm, md, lg, xl, xxl);
        public Utilities TextMiddleCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.MiddleCenter, xs, sm, md, lg, xl, xxl);
        public Utilities TextLowerStart(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.LowerStart, xs, sm, md, lg, xl, xxl);
        public Utilities TextLowerEnd(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.LowerEnd, xs, sm, md, lg, xl, xxl);
        public Utilities TextLowerCenter(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrTextAlignment(TextAlignmentFlags.LowerCenter, xs, sm, md, lg, xl, xxl);
        private Utilities OrTextAlignment(TextAlignmentFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrTextAlignment(value);
            }
        
            return OrTextAlignment(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrTextAlignment(TextAlignmentFlags? xs, TextAlignmentFlags? sm = default, TextAlignmentFlags? md = default, TextAlignmentFlags? lg = default, TextAlignmentFlags? xl = default, TextAlignmentFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                textAlignment.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                textAlignment.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                textAlignment.md |= md.Value;
            }
            if (lg.HasValue)
            {
                textAlignment.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                textAlignment.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                textAlignment.xxl |= xxl.Value;
            }
            return this;
        }

        // Visibility
        public Utilities Visible(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrVisibility(VisibilityFlags.Visible, xs, sm, md, lg, xl, xxl);
        public Utilities Invisible(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrVisibility(VisibilityFlags.Invisible, xs, sm, md, lg, xl, xxl);
        private Utilities OrVisibility(VisibilityFlags value, bool xs, bool sm, bool md, bool lg, bool xl, bool xxl)
        {
            if (!xs && !sm && !md && !lg && !xl && !xxl)
            {
                return OrVisibility(value);
            }
        
            return OrVisibility(xs ? value : null, sm ? value : null, md ? value : null, lg ? value : null, xl ? value : null, xxl ? value : null);
        }
        private Utilities OrVisibility(VisibilityFlags? xs, VisibilityFlags? sm = default, VisibilityFlags? md = default, VisibilityFlags? lg = default, VisibilityFlags? xl = default, VisibilityFlags? xxl = default)
        {
            if (xs.HasValue)
            {
                visibility.xs |= xs.Value;
            }
            if (sm.HasValue)
            {
                visibility.sm |= sm.Value;
            }
            if (md.HasValue)
            {
                visibility.md |= md.Value;
            }
            if (lg.HasValue)
            {
                visibility.lg |= lg.Value;
            }
            if (xl.HasValue)
            {
                visibility.xl |= xl.Value;
            }
            if (xxl.HasValue)
            {
                visibility.xxl |= xxl.Value;
            }
            return this;
        }
        
        // Absolute Fill
        public Utilities AbsoluteFill()
        {
            absoluteFill |= AbsoluteFillFlags.Set;
            return this;
        }

        // Opacity
        public Utilities Opacity0() => OrOpacity(OpacityFlags.V0);
        public Utilities Opacity25() => OrOpacity(OpacityFlags.V25);
        public Utilities Opacity50() => OrOpacity(OpacityFlags.V50);
        public Utilities Opacity75() => OrOpacity(OpacityFlags.V75);
        public Utilities Opacity100() => OrOpacity(OpacityFlags.V100);
        private Utilities OrOpacity(OpacityFlags value)
        {
            opacity |= value;
            return this;
        }

        // Overflow
        public Utilities OverflowHidden() => OrOverflow(OverflowFlags.Hidden);
        public Utilities OverflowVisible() => OrOverflow(OverflowFlags.Visible);
        private Utilities OrOverflow(OverflowFlags value)
        {
            overflow |= value;
            return this;
        }

        // Position
        public Utilities PositionRelative() => OrPosition(PositionFlags.Relative);
        public Utilities PositionAbsolute() => OrPosition(PositionFlags.Absolute);
        private Utilities OrPosition(PositionFlags value)
        {
            position |= value;
            return this;
        }

        // Arrange Elements
        public Utilities Top0() => OrArrangeElements(ArrangeElementsFlags.Top0);
        public Utilities Top50() => OrArrangeElements(ArrangeElementsFlags.Top50);
        public Utilities Top100() => OrArrangeElements(ArrangeElementsFlags.Top100);
        public Utilities Bottom0() => OrArrangeElements(ArrangeElementsFlags.Bottom0);
        public Utilities Bottom50() => OrArrangeElements(ArrangeElementsFlags.Bottom50);
        public Utilities Bottom100() => OrArrangeElements(ArrangeElementsFlags.Bottom100);
        public Utilities Start0() => OrArrangeElements(ArrangeElementsFlags.Start0);
        public Utilities Start50() => OrArrangeElements(ArrangeElementsFlags.Start50);
        public Utilities Start100() => OrArrangeElements(ArrangeElementsFlags.Start100);
        public Utilities End0() => OrArrangeElements(ArrangeElementsFlags.End0);
        public Utilities End50() => OrArrangeElements(ArrangeElementsFlags.End50);
        public Utilities End100() => OrArrangeElements(ArrangeElementsFlags.End100);
        public Utilities TranslateMiddle() => OrArrangeElements(ArrangeElementsFlags.TranslateMiddle);
        public Utilities TranslateX() => OrArrangeElements(ArrangeElementsFlags.TranslateX);
        public Utilities TranslateY() => OrArrangeElements(ArrangeElementsFlags.TranslateY);
        private Utilities OrArrangeElements(ArrangeElementsFlags value)
        {
            arrangeElements |= value;
            return this;
        }
        
        // Sizing
        public Utilities Width0() => OrSizing(SizingFlags.Width0);
        public Utilities Width25() => OrSizing(SizingFlags.Width25);
        public Utilities Width50() => OrSizing(SizingFlags.Width50);
        public Utilities Width75() => OrSizing(SizingFlags.Width75);
        public Utilities Width100() => OrSizing(SizingFlags.Width100);
        public Utilities WidthAuto() => OrSizing(SizingFlags.WidthAuto);
        public Utilities MaxWidth100() => OrSizing(SizingFlags.MaxWidth100);
        public Utilities Height0() => OrSizing(SizingFlags.Height0);
        public Utilities Height25() => OrSizing(SizingFlags.Height25);
        public Utilities Height50() => OrSizing(SizingFlags.Height50);
        public Utilities Height75() => OrSizing(SizingFlags.Height75);
        public Utilities Height100() => OrSizing(SizingFlags.Height100);
        public Utilities HeightAuto() => OrSizing(SizingFlags.HeightAuto);
        public Utilities MaxHeight100() => OrSizing(SizingFlags.MaxHeight100);
        private Utilities OrSizing(SizingFlags value)
        {
            sizing |= value;
            return this;
        }
        
        // Background
        public Utilities BackgroundPrimary() => OrBackground(BackgroundFlags.Primary);
        public Utilities BackgroundPrimarySubtle() => OrBackground(BackgroundFlags.PrimarySubtle);
        public Utilities BackgroundSecondary() => OrBackground(BackgroundFlags.Secondary);
        public Utilities BackgroundSecondarySubtle() => OrBackground(BackgroundFlags.SecondarySubtle);
        public Utilities BackgroundSuccess() => OrBackground(BackgroundFlags.Success);
        public Utilities BackgroundSuccessSubtle() => OrBackground(BackgroundFlags.SuccessSubtle);
        public Utilities BackgroundDanger() => OrBackground(BackgroundFlags.Danger);
        public Utilities BackgroundDangerSubtle() => OrBackground(BackgroundFlags.DangerSubtle);
        public Utilities BackgroundWarning() => OrBackground(BackgroundFlags.Warning);
        public Utilities BackgroundWarningSubtle() => OrBackground(BackgroundFlags.WarningSubtle);
        public Utilities BackgroundInfo() => OrBackground(BackgroundFlags.Info);
        public Utilities BackgroundInfoSubtle() => OrBackground(BackgroundFlags.InfoSubtle);
        public Utilities BackgroundLight() => OrBackground(BackgroundFlags.Light);
        public Utilities BackgroundLightSubtle() => OrBackground(BackgroundFlags.LightSubtle);
        public Utilities BackgroundDark() => OrBackground(BackgroundFlags.Dark);
        public Utilities BackgroundDarkSubtle() => OrBackground(BackgroundFlags.DarkSubtle);
        public Utilities BackgroundBody() => OrBackground(BackgroundFlags.Body);
        public Utilities BackgroundBodySecondary() => OrBackground(BackgroundFlags.BodySecondary);
        public Utilities BackgroundBodyTertiary() => OrBackground(BackgroundFlags.BodyTertiary);
        public Utilities BackgroundBlack() => OrBackground(BackgroundFlags.Black);
        public Utilities BackgroundWhite() => OrBackground(BackgroundFlags.White);
        public Utilities BackgroundTransparent() => OrBackground(BackgroundFlags.Transparent);
        private Utilities OrBackground(BackgroundFlags value)
        {
            background |= value;
            return this;
        }
        
        // Borders
        public Utilities Border() => OrBorderWidth(BordersWidthFlags.Set);
        public Utilities BorderTop() => OrBorderWidth(BordersWidthFlags.Top);
        public Utilities BorderRight() => OrBorderWidth(BordersWidthFlags.Right);
        public Utilities BorderBottom() => OrBorderWidth(BordersWidthFlags.Bottom);
        public Utilities BorderLeft() => OrBorderWidth(BordersWidthFlags.Left);
        public Utilities BorderTop0() => OrBorderWidth(BordersWidthFlags.Top0);
        public Utilities BorderRight0() => OrBorderWidth(BordersWidthFlags.Right0);
        public Utilities BorderBottom0() => OrBorderWidth(BordersWidthFlags.Bottom0);
        public Utilities BorderLeft0() => OrBorderWidth(BordersWidthFlags.Left0);
        public Utilities BorderPrimary() => OrBorderColor(BordersColorFlags.Primary);
        public Utilities BorderPrimarySubtle() => OrBorderColor(BordersColorFlags.PrimarySubtle);
        public Utilities BorderSecondary() => OrBorderColor(BordersColorFlags.Secondary);
        public Utilities BorderSecondarySubtle() => OrBorderColor(BordersColorFlags.SecondarySubtle);
        public Utilities BorderSuccess() => OrBorderColor(BordersColorFlags.Success);
        public Utilities BorderSuccessSubtle() => OrBorderColor(BordersColorFlags.SuccessSubtle);
        public Utilities BorderDanger() => OrBorderColor(BordersColorFlags.Danger);
        public Utilities BorderDangerSubtle() => OrBorderColor(BordersColorFlags.DangerSubtle);
        public Utilities BorderWarning() => OrBorderColor(BordersColorFlags.Warning);
        public Utilities BorderWarningSubtle() => OrBorderColor(BordersColorFlags.WarningSubtle);
        public Utilities BorderInfo() => OrBorderColor(BordersColorFlags.Info);
        public Utilities BorderInfoSubtle() => OrBorderColor(BordersColorFlags.InfoSubtle);
        public Utilities BorderLight() => OrBorderColor(BordersColorFlags.Light);
        public Utilities BorderLightSubtle() => OrBorderColor(BordersColorFlags.LightSubtle);
        public Utilities BorderDark() => OrBorderColor(BordersColorFlags.Dark);
        public Utilities BorderDarkSubtle() => OrBorderColor(BordersColorFlags.DarkSubtle);
        public Utilities BorderBlack() => OrBorderColor(BordersColorFlags.Black);
        public Utilities BorderWhite() => OrBorderColor(BordersColorFlags.White);
        public Utilities Border1() => OrBorderWidth(BordersWidthFlags.V1);
        public Utilities Border2() => OrBorderWidth(BordersWidthFlags.V2);
        public Utilities Border3() => OrBorderWidth(BordersWidthFlags.V3);
        public Utilities Border4() => OrBorderWidth(BordersWidthFlags.V4);
        public Utilities Border5() => OrBorderWidth(BordersWidthFlags.V5);
        private Utilities OrBorderWidth(BordersWidthFlags value)
        {
            borders.width |= value;
            return this;
        }
        private Utilities OrBorderColor(BordersColorFlags value)
        {
            borders.color |= value;
            return this;
        }
        
        // Colors
        public Utilities TextPrimary() => OrColor(ColorsFlags.Primary);
        public Utilities TextPrimaryEmphasis() => OrColor(ColorsFlags.PrimaryEmphasis);
        public Utilities TextSecondary() => OrColor(ColorsFlags.Secondary);
        public Utilities TextSecondaryEmphasis() => OrColor(ColorsFlags.SecondaryEmphasis);
        public Utilities TextSuccess() => OrColor(ColorsFlags.Success);
        public Utilities TextSuccessEmphasis() => OrColor(ColorsFlags.SuccessEmphasis);
        public Utilities TextDanger() => OrColor(ColorsFlags.Danger);
        public Utilities TextDangerEmphasis() => OrColor(ColorsFlags.DangerEmphasis);
        public Utilities TextWarning() => OrColor(ColorsFlags.Warning);
        public Utilities TextWarningEmphasis() => OrColor(ColorsFlags.WarningEmphasis);
        public Utilities TextInfo() => OrColor(ColorsFlags.Info);
        public Utilities TextInfoEmphasis() => OrColor(ColorsFlags.InfoEmphasis);
        public Utilities TextLight() => OrColor(ColorsFlags.Light);
        public Utilities TextLightEmphasis() => OrColor(ColorsFlags.LightEmphasis);
        public Utilities TextDark() => OrColor(ColorsFlags.Dark);
        public Utilities TextDarkEmphasis() => OrColor(ColorsFlags.DarkEmphasis);
        public Utilities TextBody() => OrColor(ColorsFlags.Body);
        public Utilities TextBodyEmphasis() => OrColor(ColorsFlags.BodyEmphasis);
        public Utilities TextBodySecondary() => OrColor(ColorsFlags.BodySecondary);
        public Utilities TextBodyTertiary() => OrColor(ColorsFlags.BodyTertiary);
        public Utilities TextBlack() => OrColor(ColorsFlags.Black);
        public Utilities TextWhite() => OrColor(ColorsFlags.White);
        public Utilities TextBlack50() => OrColor(ColorsFlags.Black50);
        public Utilities TextWhite50() => OrColor(ColorsFlags.White50);
        private Utilities OrColor(ColorsFlags value)
        {
            colors |= value;
            return this;
        }
        
        // Rounded Corners
        public Utilities Rounded() => OrRounded(CornerRadiusFlags.Set);
        public Utilities RoundedTop() => OrRoundedTop(CornerRadiusFlags.Set);
        public Utilities RoundedRight() => OrRoundedRight(CornerRadiusFlags.Set);
        public Utilities RoundedBottom() => OrRoundedBottom(CornerRadiusFlags.Set);
        public Utilities RoundedLeft() => OrRoundedLeft(CornerRadiusFlags.Set);
        public Utilities Rounded0() => OrRounded(CornerRadiusFlags.Radius0);
        public Utilities Rounded1() => OrRounded(CornerRadiusFlags.Radius1);
        public Utilities Rounded2() => OrRounded(CornerRadiusFlags.Radius2);
        public Utilities Rounded3() => OrRounded(CornerRadiusFlags.Radius3);
        public Utilities Rounded4() => OrRounded(CornerRadiusFlags.Radius4);
        public Utilities Rounded5() => OrRounded(CornerRadiusFlags.Radius5);
        public Utilities RoundedCircle() => OrRounded(CornerRadiusFlags.Circle);
        public Utilities RoundedTop0() => OrRoundedTop(CornerRadiusFlags.Radius0);
        public Utilities RoundedTop1() => OrRoundedTop(CornerRadiusFlags.Radius1);
        public Utilities RoundedTop2() => OrRoundedTop(CornerRadiusFlags.Radius2);
        public Utilities RoundedTop3() => OrRoundedTop(CornerRadiusFlags.Radius3);
        public Utilities RoundedTop4() => OrRoundedTop(CornerRadiusFlags.Radius4);
        public Utilities RoundedTop5() => OrRoundedTop(CornerRadiusFlags.Radius5);
        public Utilities RoundedTopCircle() => OrRoundedTop(CornerRadiusFlags.Circle);
        public Utilities RoundedRight0() => OrRoundedRight(CornerRadiusFlags.Radius0);
        public Utilities RoundedRight1() => OrRoundedRight(CornerRadiusFlags.Radius1);
        public Utilities RoundedRight2() => OrRoundedRight(CornerRadiusFlags.Radius2);
        public Utilities RoundedRight3() => OrRoundedRight(CornerRadiusFlags.Radius3);
        public Utilities RoundedRight4() => OrRoundedRight(CornerRadiusFlags.Radius4);
        public Utilities RoundedRight5() => OrRoundedRight(CornerRadiusFlags.Radius5);
        public Utilities RoundedRightCircle() => OrRoundedRight(CornerRadiusFlags.Circle);
        public Utilities RoundedBottom0() => OrRoundedBottom(CornerRadiusFlags.Radius0);
        public Utilities RoundedBottom1() => OrRoundedBottom(CornerRadiusFlags.Radius1);
        public Utilities RoundedBottom2() => OrRoundedBottom(CornerRadiusFlags.Radius2);
        public Utilities RoundedBottom3() => OrRoundedBottom(CornerRadiusFlags.Radius3);
        public Utilities RoundedBottom4() => OrRoundedBottom(CornerRadiusFlags.Radius4);
        public Utilities RoundedBottom5() => OrRoundedBottom(CornerRadiusFlags.Radius5);
        public Utilities RoundedBottomCircle() => OrRoundedBottom(CornerRadiusFlags.Circle);
        public Utilities RoundedLeft0() => OrRoundedLeft(CornerRadiusFlags.Radius0);
        public Utilities RoundedLeft1() => OrRoundedLeft(CornerRadiusFlags.Radius1);
        public Utilities RoundedLeft2() => OrRoundedLeft(CornerRadiusFlags.Radius2);
        public Utilities RoundedLeft3() => OrRoundedLeft(CornerRadiusFlags.Radius3);
        public Utilities RoundedLeft4() => OrRoundedLeft(CornerRadiusFlags.Radius4);
        public Utilities RoundedLeft5() => OrRoundedLeft(CornerRadiusFlags.Radius5);
        public Utilities RoundedLeftCircle() => OrRoundedLeft(CornerRadiusFlags.Circle);
        private Utilities OrRoundedTop(CornerRadiusFlags value)
        {
            roundedCorners.top |= value;
            return this;
        }
        private Utilities OrRoundedRight(CornerRadiusFlags value)
        {
            roundedCorners.right |= value;
            return this;
        }
        private Utilities OrRoundedBottom(CornerRadiusFlags value)
        {
            roundedCorners.bottom |= value;
            return this;
        }
        private Utilities OrRoundedLeft(CornerRadiusFlags value)
        {
            roundedCorners.left |= value;
            return this;
        }
        private Utilities OrRounded(CornerRadiusFlags value)
        {
            roundedCorners.general |= value;
            return this;
        }

        // Text Wrapping
        public Utilities TextWrap() => OrTextWrapping(TextWrappingFlags.Wrap);
        public Utilities TextNoWrap() => OrTextWrapping(TextWrappingFlags.NoWrap);
        private Utilities OrTextWrapping(TextWrappingFlags value)
        {
            textWrapping |= value;
            return this;
        }

        // Font Size
        public Utilities FontSize1() => OrFontSize(FontSizeFlags.Size1);
        public Utilities FontSize2() => OrFontSize(FontSizeFlags.Size2);
        public Utilities FontSize3() => OrFontSize(FontSizeFlags.Size3);
        public Utilities FontSize4() => OrFontSize(FontSizeFlags.Size4);
        public Utilities FontSize5() => OrFontSize(FontSizeFlags.Size5);
        public Utilities FontSize6() => OrFontSize(FontSizeFlags.Size6);
        private Utilities OrFontSize(FontSizeFlags value)
        {
            fontSize |= value;
            return this;
        }

        // Font Style
        public Utilities FontStyleBold() => OrFontStyle(FontStyleFlags.Bold);
        public Utilities FontStyleItalic() => OrFontStyle(FontStyleFlags.Italic);
        public Utilities FontStyleNormal() => OrFontStyle(FontStyleFlags.Normal);
        private Utilities OrFontStyle(FontStyleFlags value)
        {
            fontStyle |= value;
            return this;
        }
        

        public void AddClassNamesTo(VisualElement visualElement)
        {
            if (RishUtils.MemCmp(this, None))
            {
                return;
            }
            
            display.AddClassNamesTo(visualElement, AddClassNamesTo);
            flexDirection.AddClassNamesTo(visualElement, AddClassNamesTo);
            justifyContent.AddClassNamesTo(visualElement, AddClassNamesTo);
            alignItems.AddClassNamesTo(visualElement, AddAlignItemsClassNames);
            alignSelf.AddClassNamesTo(visualElement, AddAlignSelfClassNames);
            fill.AddClassNamesTo(visualElement, AddClassNamesTo);
            growAndShrink.AddClassNamesTo(visualElement, AddClassNamesTo);
            wrap.AddClassNamesTo(visualElement, AddClassNamesTo);
            alignContent.AddClassNamesTo(visualElement, AddAlignContentClassNames);
            margins.AddClassNamesTo(visualElement, AddClassNamesTo);
            paddings.AddClassNamesTo(visualElement, AddClassNamesTo);
            gaps.AddClassNamesTo(visualElement, AddClassNamesTo);
            textAlignment.AddClassNamesTo(visualElement, AddClassNamesTo);
            visibility.AddClassNamesTo(visualElement, AddClassNamesTo);

            AddClassNamesTo(visualElement, absoluteFill);
            AddClassNamesTo(visualElement, opacity);
            AddClassNamesTo(visualElement, overflow);
            AddClassNamesTo(visualElement, position);
            AddClassNamesTo(visualElement, arrangeElements);
            AddClassNamesTo(visualElement, sizing);
            AddClassNamesTo(visualElement, background);
            AddClassNamesTo(visualElement, borders);
            AddClassNamesTo(visualElement, colors);
            AddClassNamesTo(visualElement, roundedCorners);
            AddClassNamesTo(visualElement, textWrapping);
            AddClassNamesTo(visualElement, fontSize);
            AddClassNamesTo(visualElement, fontStyle);
        }
        
        private enum Breakpoint { XS, SM, MD, LG, XL, XXL }
        private static string GetBreakpoint(Breakpoint breakpoint) => breakpoint switch
        {
            Breakpoint.SM => "-sm",
            Breakpoint.MD => "-md",
            Breakpoint.LG => "-lg",
            Breakpoint.XL => "-xl",
            Breakpoint.XXL => "-xxl",
            _ => string.Empty,
        };

        private static void AddClassNamesTo(VisualElement visualElement, DisplayFlags flags, Breakpoint breakpoint)
        {
            var prefix = $"display{GetBreakpoint(breakpoint)}";
            if ((flags & DisplayFlags.None) > 0)
            {
                visualElement.AddToClassList($"{prefix}-none");
            }
            if ((flags & DisplayFlags.Flex) > 0)
            {
                visualElement.AddToClassList($"{prefix}-flex");
            }
        }
        private static void AddClassNamesTo(VisualElement visualElement, FlexDirectionFlags flags, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & FlexDirectionFlags.Column) > 0)
            {
                visualElement.AddToClassList($"{prefix}-column");
            }
            if ((flags & FlexDirectionFlags.ColumnReverse) > 0)
            {
                visualElement.AddToClassList($"{prefix}-column-reverse");
            }
            if ((flags & FlexDirectionFlags.Row) > 0)
            {
                visualElement.AddToClassList($"{prefix}-row");
            }
            if ((flags & FlexDirectionFlags.RowReverse) > 0)
            {
                visualElement.AddToClassList($"{prefix}-row-reverse");
            }
        }
        private static void AddClassNamesTo(VisualElement visualElement, JustifyContentFlags flags, Breakpoint breakpoint)
        {
            var prefix = $"justify-content{GetBreakpoint(breakpoint)}";
            if ((flags & JustifyContentFlags.Start) > 0)
            {
                visualElement.AddToClassList($"{prefix}-start");
            }
            if ((flags & JustifyContentFlags.End) > 0)
            {
                visualElement.AddToClassList($"{prefix}-end");
            }
            if ((flags & JustifyContentFlags.Center) > 0)
            {
                visualElement.AddToClassList($"{prefix}-center");
            }
            if ((flags & JustifyContentFlags.Between) > 0)
            {
                visualElement.AddToClassList($"{prefix}-between");
            }
            if ((flags & JustifyContentFlags.Around) > 0)
            {
                visualElement.AddToClassList($"{prefix}-around");
            }
        }

        private static void AddAlignItemsClassNames(VisualElement visualElement, AlignFlags flags, Breakpoint breakpoint) =>
            AddClassNamesTo(visualElement, flags, "align-items", breakpoint);
        private static void AddAlignSelfClassNames(VisualElement visualElement, AlignFlags flags, Breakpoint breakpoint) =>
            AddClassNamesTo(visualElement, flags, "align-self", breakpoint);
        private static void AddAlignContentClassNames(VisualElement visualElement, AlignFlags flags, Breakpoint breakpoint) =>
            AddClassNamesTo(visualElement, flags, "align-content", breakpoint);
        private static void AddClassNamesTo(VisualElement visualElement, AlignFlags flags, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & AlignFlags.Start) > 0)
            {
                visualElement.AddToClassList($"{prefix}-start");
            }
            if ((flags & AlignFlags.End) > 0)
            {
                visualElement.AddToClassList($"{prefix}-end");
            }
            if ((flags & AlignFlags.Center) > 0)
            {
                visualElement.AddToClassList($"{prefix}-center");
            }
            if ((flags & AlignFlags.Stretch) > 0)
            {
                visualElement.AddToClassList($"{prefix}-between");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, FillFlags flags, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & FillFlags.Set) > 0)
            {
                visualElement.AddToClassList($"{prefix}-fill");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, GrowAndShrinkFlags flags, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & GrowAndShrinkFlags.Grow0) > 0)
            {
                visualElement.AddToClassList($"{prefix}-grow-0");
            }
            if ((flags & GrowAndShrinkFlags.Grow1) > 0)
            {
                visualElement.AddToClassList($"{prefix}-grow-1");
            }
            if ((flags & GrowAndShrinkFlags.Shrink0) > 0)
            {
                visualElement.AddToClassList($"{prefix}-shrink-0");
            }
            if ((flags & GrowAndShrinkFlags.Shrink1) > 0)
            {
                visualElement.AddToClassList($"{prefix}-shrink-1");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, WrapFlags flags, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & WrapFlags.NoWrap) > 0)
            {
                visualElement.AddToClassList($"{prefix}-nowrap");
            }
            if ((flags & WrapFlags.Wrap) > 0)
            {
                visualElement.AddToClassList($"{prefix}-wrap");
            }
            if ((flags & WrapFlags.WrapReverse) > 0)
            {
                visualElement.AddToClassList($"{prefix}-wrap-reverse");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, Margins margins, Breakpoint breakpoint)
        {
            var languageDirection = visualElement.GetComputedLanguageDirection();
            AddClassNamesTo(visualElement, margins.top, "mt", breakpoint);
            AddClassNamesTo(visualElement, margins.bottom, "mb", breakpoint);
            AddClassNamesTo(visualElement, margins.start, languageDirection == LanguageDirection.RTL ? "mr" : "ml", breakpoint);
            AddClassNamesTo(visualElement, margins.end, languageDirection == LanguageDirection.RTL ? "ml" : "mr", breakpoint);
            AddClassNamesTo(visualElement, margins.x, "mx", breakpoint);
            AddClassNamesTo(visualElement, margins.y, "my", breakpoint);
            AddClassNamesTo(visualElement, margins.general, "m", breakpoint);
        }
        private static void AddClassNamesTo(VisualElement visualElement, MarginsFlags flags, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & MarginsFlags.Zero) > 0)
            {
                visualElement.AddToClassList($"{prefix}-0");
            }
            if ((flags & MarginsFlags.Spacer1) > 0)
            {
                visualElement.AddToClassList($"{prefix}-1");
            }
            if ((flags & MarginsFlags.Spacer2) > 0)
            {
                visualElement.AddToClassList($"{prefix}-2");
            }
            if ((flags & MarginsFlags.Spacer3) > 0)
            {
                visualElement.AddToClassList($"{prefix}-3");
            }
            if ((flags & MarginsFlags.Spacer4) > 0)
            {
                visualElement.AddToClassList($"{prefix}-4");
            }
            if ((flags & MarginsFlags.Spacer5) > 0)
            {
                visualElement.AddToClassList($"{prefix}-5");
            }
            if ((flags & MarginsFlags.Auto) > 0)
            {
                visualElement.AddToClassList($"{prefix}-auto");
            }
            if ((flags & MarginsFlags.NegSpacer1) > 0)
            {
                visualElement.AddToClassList($"{prefix}-n1");
            }
            if ((flags & MarginsFlags.NegSpacer2) > 0)
            {
                visualElement.AddToClassList($"{prefix}-n2");
            }
            if ((flags & MarginsFlags.NegSpacer3) > 0)
            {
                visualElement.AddToClassList($"{prefix}-n3");
            }
            if ((flags & MarginsFlags.NegSpacer4) > 0)
            {
                visualElement.AddToClassList($"{prefix}-n4");
            }
            if ((flags & MarginsFlags.NegSpacer5) > 0)
            {
                visualElement.AddToClassList($"{prefix}-n5");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, Paddings paddings, Breakpoint breakpoint)
        {
            var languageDirection = visualElement.GetComputedLanguageDirection();
            AddClassNamesTo(visualElement, paddings.top, "pt", breakpoint);
            AddClassNamesTo(visualElement, paddings.bottom, "pb", breakpoint);
            AddClassNamesTo(visualElement, paddings.start, languageDirection == LanguageDirection.RTL ? "pr" : "pl", breakpoint);
            AddClassNamesTo(visualElement, paddings.end, languageDirection == LanguageDirection.RTL ? "pl" : "pr", breakpoint);
            AddClassNamesTo(visualElement, paddings.x, "px", breakpoint);
            AddClassNamesTo(visualElement, paddings.y, "py", breakpoint);
            AddClassNamesTo(visualElement, paddings.general, "p", breakpoint);
        }
        private static void AddClassNamesTo(VisualElement visualElement, PaddingsFlags flags, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & PaddingsFlags.Zero) > 0)
            {
                visualElement.AddToClassList($"{prefix}-0");
            }
            if ((flags & PaddingsFlags.Spacer1) > 0)
            {
                visualElement.AddToClassList($"{prefix}-1");
            }
            if ((flags & PaddingsFlags.Spacer2) > 0)
            {
                visualElement.AddToClassList($"{prefix}-2");
            }
            if ((flags & PaddingsFlags.Spacer3) > 0)
            {
                visualElement.AddToClassList($"{prefix}-3");
            }
            if ((flags & PaddingsFlags.Spacer4) > 0)
            {
                visualElement.AddToClassList($"{prefix}-4");
            }
            if ((flags & PaddingsFlags.Spacer5) > 0)
            {
                visualElement.AddToClassList($"{prefix}-5");
            }
            if ((flags & PaddingsFlags.Auto) > 0)
            {
                visualElement.AddToClassList($"{prefix}-auto");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, Gaps gaps, Breakpoint breakpoint)
        {
            AddClassNamesTo(visualElement, gaps.row, "row-gap", breakpoint);
            AddClassNamesTo(visualElement, gaps.column, "column-gap", breakpoint);
            AddClassNamesTo(visualElement, gaps.general, "gap", breakpoint);
        }
        private static void AddClassNamesTo(VisualElement visualElement, GapsFlags flags, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & GapsFlags.Zero) > 0)
            {
                visualElement.AddToClassList($"{prefix}-0");
            }
            if ((flags & GapsFlags.Spacer1) > 0)
            {
                visualElement.AddToClassList($"{prefix}-1");
            }
            if ((flags & GapsFlags.Spacer2) > 0)
            {
                visualElement.AddToClassList($"{prefix}-2");
            }
            if ((flags & GapsFlags.Spacer3) > 0)
            {
                visualElement.AddToClassList($"{prefix}-3");
            }
            if ((flags & GapsFlags.Spacer4) > 0)
            {
                visualElement.AddToClassList($"{prefix}-4");
            }
            if ((flags & GapsFlags.Spacer5) > 0)
            {
                visualElement.AddToClassList($"{prefix}-5");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, VisibilityFlags flags, Breakpoint breakpoint)
        {
            var postfix = GetBreakpoint(breakpoint);
            if ((flags & VisibilityFlags.Visible) > 0)
            {
                visualElement.AddToClassList($"visible{postfix}");
            }
            if ((flags & VisibilityFlags.Invisible) > 0)
            {
                visualElement.AddToClassList($"invisible{postfix}");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, TextAlignmentFlags flags, Breakpoint breakpoint)
        {
            var languageDirection = visualElement.GetComputedLanguageDirection();
            var start = languageDirection == LanguageDirection.RTL ? "-right" : "-left";
            var end = languageDirection == LanguageDirection.RTL ? "-left" : "-right";
            const string center = "-center";
            const string upper = "-upper";
            const string middle = "-middle";
            const string lower = "-lower";
            
            var prefix = $"text{GetBreakpoint(breakpoint)}";
            if ((flags & TextAlignmentFlags.Start) > 0)
            {
                visualElement.AddToClassList($"{prefix}{start}");
            }
            if ((flags & TextAlignmentFlags.End) > 0)
            {
                visualElement.AddToClassList($"{prefix}{end}");
            }
            if ((flags & TextAlignmentFlags.Center) > 0)
            {
                visualElement.AddToClassList($"{prefix}{center}");
            }
            if ((flags & TextAlignmentFlags.UpperStart) > 0)
            {
                visualElement.AddToClassList($"{prefix}{upper}{start}");
            }
            if ((flags & TextAlignmentFlags.UpperEnd) > 0)
            {
                visualElement.AddToClassList($"{prefix}{upper}{end}");
            }
            if ((flags & TextAlignmentFlags.UpperCenter) > 0)
            {
                visualElement.AddToClassList($"{prefix}{upper}{center}");
            }
            if ((flags & TextAlignmentFlags.MiddleStart) > 0)
            {
                visualElement.AddToClassList($"{prefix}{middle}{start}");
            }
            if ((flags & TextAlignmentFlags.MiddleEnd) > 0)
            {
                visualElement.AddToClassList($"{prefix}{middle}{end}");
            }
            if ((flags & TextAlignmentFlags.MiddleCenter) > 0)
            {
                visualElement.AddToClassList($"{prefix}{middle}{center}");
            }
            if ((flags & TextAlignmentFlags.LowerStart) > 0)
            {
                visualElement.AddToClassList($"{prefix}{lower}{start}");
            }
            if ((flags & TextAlignmentFlags.LowerEnd) > 0)
            {
                visualElement.AddToClassList($"{prefix}{lower}{end}");
            }
            if ((flags & TextAlignmentFlags.LowerCenter) > 0)
            {
                visualElement.AddToClassList($"{prefix}{lower}{center}");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, AbsoluteFillFlags flags)
        {
            if ((flags & AbsoluteFillFlags.Set) > 0)
            {
                visualElement.AddToClassList("absolute-fill");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, OpacityFlags flags)
        {
            if ((flags & OpacityFlags.V0) > 0)
            {
                visualElement.AddToClassList("opacity-0");
            }
            if ((flags & OpacityFlags.V25) > 0)
            {
                visualElement.AddToClassList("opacity-25");
            }
            if ((flags & OpacityFlags.V50) > 0)
            {
                visualElement.AddToClassList("opacity-50");
            }
            if ((flags & OpacityFlags.V75) > 0)
            {
                visualElement.AddToClassList("opacity-75");
            }
            if ((flags & OpacityFlags.V100) > 0)
            {
                visualElement.AddToClassList("opacity-100");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, OverflowFlags flags)
        {
            if ((flags & OverflowFlags.Hidden) > 0)
            {
                visualElement.AddToClassList("overflow-hidden");
            }
            if ((flags & OverflowFlags.Visible) > 0)
            {
                visualElement.AddToClassList("overflow-visible");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, PositionFlags flags)
        {
            if ((flags & PositionFlags.Relative) > 0)
            {
                visualElement.AddToClassList("position-relative");
            }
            if ((flags & PositionFlags.Absolute) > 0)
            {
                visualElement.AddToClassList("position-absolute");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, ArrangeElementsFlags flags)
        {
            var languageDirection = visualElement.GetComputedLanguageDirection();
            
            if ((flags & ArrangeElementsFlags.Top0) > 0)
            {
                visualElement.AddToClassList("top-0");
            }
            if ((flags & ArrangeElementsFlags.Top50) > 0)
            {
                visualElement.AddToClassList("top-50");
            }
            if ((flags & ArrangeElementsFlags.Top100) > 0)
            {
                visualElement.AddToClassList("top-100");
            }
            if ((flags & ArrangeElementsFlags.Bottom0) > 0)
            {
                visualElement.AddToClassList("bottom-0");
            }
            if ((flags & ArrangeElementsFlags.Bottom50) > 0)
            {
                visualElement.AddToClassList("bottom-50");
            }
            if ((flags & ArrangeElementsFlags.Bottom100) > 0)
            {
                visualElement.AddToClassList("bottom-100");
            }
            var startPrefix = languageDirection == LanguageDirection.RTL ? "right" : "left";
            if ((flags & ArrangeElementsFlags.Start0) > 0)
            {
                visualElement.AddToClassList($"{startPrefix}-0");
            }
            if ((flags & ArrangeElementsFlags.Start50) > 0)
            {
                visualElement.AddToClassList($"{startPrefix}-50");
            }
            if ((flags & ArrangeElementsFlags.Start100) > 0)
            {
                visualElement.AddToClassList($"{startPrefix}-100");
            }
            var endPrefix = languageDirection == LanguageDirection.RTL ? "left" : "right";
            if ((flags & ArrangeElementsFlags.End0) > 0)
            {
                visualElement.AddToClassList($"{endPrefix}-0");
            }
            if ((flags & ArrangeElementsFlags.End50) > 0)
            {
                visualElement.AddToClassList($"{endPrefix}-50");
            }
            if ((flags & ArrangeElementsFlags.End100) > 0)
            {
                visualElement.AddToClassList($"{endPrefix}-100");
            }
            if ((flags & ArrangeElementsFlags.TranslateMiddle) > 0)
            {
                visualElement.AddToClassList("translate-middle");
            }
            if ((flags & ArrangeElementsFlags.TranslateX) > 0)
            {
                visualElement.AddToClassList("translate-x");
            }
            if ((flags & ArrangeElementsFlags.TranslateY) > 0)
            {
                visualElement.AddToClassList("translate-y");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, SizingFlags flags)
        {
            if ((flags & SizingFlags.Width0) > 0)
            {
                visualElement.AddToClassList("w-0");
            }
            if ((flags & SizingFlags.Width25) > 0)
            {
                visualElement.AddToClassList("w-25");
            }
            if ((flags & SizingFlags.Width50) > 0)
            {
                visualElement.AddToClassList("w-50");
            }
            if ((flags & SizingFlags.Width100) > 0)
            {
                visualElement.AddToClassList("w-100");
            }
            if ((flags & SizingFlags.WidthAuto) > 0)
            {
                visualElement.AddToClassList("w-auto");
            }
            if ((flags & SizingFlags.MaxWidth100) > 0)
            {
                visualElement.AddToClassList("mw-100");
            }
            if ((flags & SizingFlags.Height0) > 0)
            {
                visualElement.AddToClassList("h-0");
            }
            if ((flags & SizingFlags.Height25) > 0)
            {
                visualElement.AddToClassList("h-25");
            }
            if ((flags & SizingFlags.Height50) > 0)
            {
                visualElement.AddToClassList("h-50");
            }
            if ((flags & SizingFlags.Height100) > 0)
            {
                visualElement.AddToClassList("h-100");
            }
            if ((flags & SizingFlags.HeightAuto) > 0)
            {
                visualElement.AddToClassList("h-auto");
            }
            if ((flags & SizingFlags.MaxHeight100) > 0)
            {
                visualElement.AddToClassList("mh-100");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, BackgroundFlags flags)
        {
            if ((flags & BackgroundFlags.Primary) > 0)
            {
                visualElement.AddToClassList("bg-primary");
            }
            if ((flags & BackgroundFlags.PrimarySubtle) > 0)
            {
                visualElement.AddToClassList("bg-primary-subtle");
            }
            if ((flags & BackgroundFlags.Secondary) > 0)
            {
                visualElement.AddToClassList("bg-secondary");
            }
            if ((flags & BackgroundFlags.SecondarySubtle) > 0)
            {
                visualElement.AddToClassList("bg-secondary-subtle");
            }
            if ((flags & BackgroundFlags.Success) > 0)
            {
                visualElement.AddToClassList("bg-success");
            }
            if ((flags & BackgroundFlags.SuccessSubtle) > 0)
            {
                visualElement.AddToClassList("bg-success-subtle");
            }
            if ((flags & BackgroundFlags.Danger) > 0)
            {
                visualElement.AddToClassList("bg-danger");
            }
            if ((flags & BackgroundFlags.DangerSubtle) > 0)
            {
                visualElement.AddToClassList("bg-danger-subtle");
            }
            if ((flags & BackgroundFlags.Warning) > 0)
            {
                visualElement.AddToClassList("bg-warning");
            }
            if ((flags & BackgroundFlags.WarningSubtle) > 0)
            {
                visualElement.AddToClassList("bg-warning-subtle");
            }
            if ((flags & BackgroundFlags.Info) > 0)
            {
                visualElement.AddToClassList("bg-info");
            }
            if ((flags & BackgroundFlags.InfoSubtle) > 0)
            {
                visualElement.AddToClassList("bg-info-subtle");
            }
            if ((flags & BackgroundFlags.Light) > 0)
            {
                visualElement.AddToClassList("bg-light");
            }
            if ((flags & BackgroundFlags.LightSubtle) > 0)
            {
                visualElement.AddToClassList("bg-light-subtle");
            }
            if ((flags & BackgroundFlags.Dark) > 0)
            {
                visualElement.AddToClassList("bg-dark");
            }
            if ((flags & BackgroundFlags.DarkSubtle) > 0)
            {
                visualElement.AddToClassList("bg-dark-subtle");
            }
            if ((flags & BackgroundFlags.Body) > 0)
            {
                visualElement.AddToClassList("bg-body");
            }
            if ((flags & BackgroundFlags.BodySecondary) > 0)
            {
                visualElement.AddToClassList("bg-body-tertiary");
            }
            if ((flags & BackgroundFlags.BodyTertiary) > 0)
            {
                visualElement.AddToClassList("bg-body-tertiary");
            }
            if ((flags & BackgroundFlags.Black) > 0)
            {
                visualElement.AddToClassList("bg-black");
            }
            if ((flags & BackgroundFlags.White) > 0)
            {
                visualElement.AddToClassList("bg-white");
            }
            if ((flags & BackgroundFlags.Transparent) > 0)
            {
                visualElement.AddToClassList("bg-transparent");
            }
        }

        private static void AddClassNamesTo(VisualElement visualElement, Borders borders)
        {
            AddClassNamesTo(visualElement, borders.width);
            AddClassNamesTo(visualElement, borders.color);
        }
        private static void AddClassNamesTo(VisualElement visualElement, BordersWidthFlags flags)
        {
            if ((flags & BordersWidthFlags.Set) > 0)
            {
                visualElement.AddToClassList("border");
            }
            if ((flags & BordersWidthFlags.Top) > 0)
            {
                visualElement.AddToClassList("border-top");
            }
            if ((flags & BordersWidthFlags.Right) > 0)
            {
                visualElement.AddToClassList("border-right");
            }
            if ((flags & BordersWidthFlags.Left) > 0)
            {
                visualElement.AddToClassList("border-left");
            }
            if ((flags & BordersWidthFlags.Top0) > 0)
            {
                visualElement.AddToClassList("border-top-0");
            }
            if ((flags & BordersWidthFlags.Right0) > 0)
            {
                visualElement.AddToClassList("border-right-0");
            }
            if ((flags & BordersWidthFlags.Left0) > 0)
            {
                visualElement.AddToClassList("border-left-0");
            }
            if ((flags & BordersWidthFlags.V1) > 0)
            {
                visualElement.AddToClassList("border-1");
            }
            if ((flags & BordersWidthFlags.V2) > 0)
            {
                visualElement.AddToClassList("border-2");
            }
            if ((flags & BordersWidthFlags.V3) > 0)
            {
                visualElement.AddToClassList("border-3");
            }
            if ((flags & BordersWidthFlags.V4) > 0)
            {
                visualElement.AddToClassList("border-4");
            }
            if ((flags & BordersWidthFlags.V5) > 0)
            {
                visualElement.AddToClassList("border-5");
            }
        }
        private static void AddClassNamesTo(VisualElement visualElement, BordersColorFlags flags)
        {
            if ((flags & BordersColorFlags.Primary) > 0)
            {
                visualElement.AddToClassList("border-primary");
            }
            if ((flags & BordersColorFlags.PrimarySubtle) > 0)
            {
                visualElement.AddToClassList("border-primary-subtle");
            }
            if ((flags & BordersColorFlags.Secondary) > 0)
            {
                visualElement.AddToClassList("border-secondary");
            }
            if ((flags & BordersColorFlags.SecondarySubtle) > 0)
            {
                visualElement.AddToClassList("border-secondary-subtle");
            }
            if ((flags & BordersColorFlags.Success) > 0)
            {
                visualElement.AddToClassList("border-success");
            }
            if ((flags & BordersColorFlags.SuccessSubtle) > 0)
            {
                visualElement.AddToClassList("border-success-subtle");
            }
            if ((flags & BordersColorFlags.Danger) > 0)
            {
                visualElement.AddToClassList("border-danger");
            }
            if ((flags & BordersColorFlags.DangerSubtle) > 0)
            {
                visualElement.AddToClassList("border-danger-subtle");
            }
            if ((flags & BordersColorFlags.Warning) > 0)
            {
                visualElement.AddToClassList("border-warning");
            }
            if ((flags & BordersColorFlags.WarningSubtle) > 0)
            {
                visualElement.AddToClassList("border-warning-subtle");
            }
            if ((flags & BordersColorFlags.Info) > 0)
            {
                visualElement.AddToClassList("border-info");
            }
            if ((flags & BordersColorFlags.InfoSubtle) > 0)
            {
                visualElement.AddToClassList("border-info-subtle");
            }
            if ((flags & BordersColorFlags.Light) > 0)
            {
                visualElement.AddToClassList("border-light");
            }
            if ((flags & BordersColorFlags.LightSubtle) > 0)
            {
                visualElement.AddToClassList("border-light-subtle");
            }
            if ((flags & BordersColorFlags.Dark) > 0)
            {
                visualElement.AddToClassList("border-dark");
            }
            if ((flags & BordersColorFlags.DarkSubtle) > 0)
            {
                visualElement.AddToClassList("border-dark-subtle");
            }
            if ((flags & BordersColorFlags.Black) > 0)
            {
                visualElement.AddToClassList("border-black");
            }
            if ((flags & BordersColorFlags.White) > 0)
            {
                visualElement.AddToClassList("border-white");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, ColorsFlags flags)
        {
            if ((flags & ColorsFlags.Primary) > 0)
            {
                visualElement.AddToClassList("text-primary");
            }
            if ((flags & ColorsFlags.PrimaryEmphasis) > 0)
            {
                visualElement.AddToClassList("text-primary-emphasis");
            }
            if ((flags & ColorsFlags.Secondary) > 0)
            {
                visualElement.AddToClassList("text-secondary");
            }
            if ((flags & ColorsFlags.SecondaryEmphasis) > 0)
            {
                visualElement.AddToClassList("text-secondary-emphasis");
            }
            if ((flags & ColorsFlags.Success) > 0)
            {
                visualElement.AddToClassList("text-success");
            }
            if ((flags & ColorsFlags.SuccessEmphasis) > 0)
            {
                visualElement.AddToClassList("text-success-emphasis");
            }
            if ((flags & ColorsFlags.Danger) > 0)
            {
                visualElement.AddToClassList("text-danger");
            }
            if ((flags & ColorsFlags.DangerEmphasis) > 0)
            {
                visualElement.AddToClassList("text-danger-emphasis");
            }
            if ((flags & ColorsFlags.Warning) > 0)
            {
                visualElement.AddToClassList("text-warning");
            }
            if ((flags & ColorsFlags.WarningEmphasis) > 0)
            {
                visualElement.AddToClassList("text-warning-emphasis");
            }
            if ((flags & ColorsFlags.Info) > 0)
            {
                visualElement.AddToClassList("text-info");
            }
            if ((flags & ColorsFlags.InfoEmphasis) > 0)
            {
                visualElement.AddToClassList("text-info-emphasis");
            }
            if ((flags & ColorsFlags.Light) > 0)
            {
                visualElement.AddToClassList("text-light");
            }
            if ((flags & ColorsFlags.LightEmphasis) > 0)
            {
                visualElement.AddToClassList("text-light-emphasis");
            }
            if ((flags & ColorsFlags.Dark) > 0)
            {
                visualElement.AddToClassList("text-dark");
            }
            if ((flags & ColorsFlags.DarkEmphasis) > 0)
            {
                visualElement.AddToClassList("text-dark-emphasis");
            }
            if ((flags & ColorsFlags.Body) > 0)
            {
                visualElement.AddToClassList("text-body");
            }
            if ((flags & ColorsFlags.BodyEmphasis) > 0)
            {
                visualElement.AddToClassList("text-body-emphasis");
            }
            if ((flags & ColorsFlags.BodySecondary) > 0)
            {
                visualElement.AddToClassList("text-body-secondary");
            }
            if ((flags & ColorsFlags.BodyTertiary) > 0)
            {
                visualElement.AddToClassList("text-body-tertiary");
            }
            if ((flags & ColorsFlags.Black) > 0)
            {
                visualElement.AddToClassList("text-black");
            }
            if ((flags & ColorsFlags.White) > 0)
            {
                visualElement.AddToClassList("text-white");
            }
            if ((flags & ColorsFlags.Black50) > 0)
            {
                visualElement.AddToClassList("text-black-50");
            }
            if ((flags & ColorsFlags.White50) > 0)
            {
                visualElement.AddToClassList("text-white-50");
            }
        }

        private static void AddClassNamesTo(VisualElement visualElement, RoundedCorners roundedCorners)
        {
            AddClassNamesTo(visualElement, roundedCorners.general, string.Empty);
            AddClassNamesTo(visualElement, roundedCorners.top, "-top");
            AddClassNamesTo(visualElement, roundedCorners.right, "-right");
            AddClassNamesTo(visualElement, roundedCorners.bottom, "-bottom");
            AddClassNamesTo(visualElement, roundedCorners.left, "-left");
        }
        private static void AddClassNamesTo(VisualElement visualElement, CornerRadiusFlags flags, string side)
        {
            var prefix = $"rounded{side}";
            if ((flags & CornerRadiusFlags.Set) > 0)
            {
                visualElement.AddToClassList(prefix);
            }
            if ((flags & CornerRadiusFlags.Radius0) > 0)
            {
                visualElement.AddToClassList($"{prefix}-0");
            }
            if ((flags & CornerRadiusFlags.Radius1) > 0)
            {
                visualElement.AddToClassList($"{prefix}-1");
            }
            if ((flags & CornerRadiusFlags.Radius2) > 0)
            {
                visualElement.AddToClassList($"{prefix}-2");
            }
            if ((flags & CornerRadiusFlags.Radius3) > 0)
            {
                visualElement.AddToClassList($"{prefix}-3");
            }
            if ((flags & CornerRadiusFlags.Radius4) > 0)
            {
                visualElement.AddToClassList($"{prefix}-4");
            }
            if ((flags & CornerRadiusFlags.Radius5) > 0)
            {
                visualElement.AddToClassList($"{prefix}-5");
            }
            if ((flags & CornerRadiusFlags.Circle) > 0)
            {
                visualElement.AddToClassList($"{prefix}-circle");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, TextWrappingFlags flags)
        {
            if ((flags & TextWrappingFlags.Wrap) > 0)
            {
                visualElement.AddToClassList("text-wrap");
            }
            if ((flags & TextWrappingFlags.NoWrap) > 0)
            {
                visualElement.AddToClassList("text-nowrap");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, FontSizeFlags flags)
        {
            if ((flags & FontSizeFlags.Size1) > 0)
            {
                visualElement.AddToClassList("fs-1");
            }
            if ((flags & FontSizeFlags.Size2) > 0)
            {
                visualElement.AddToClassList("fs-2");
            }
            if ((flags & FontSizeFlags.Size3) > 0)
            {
                visualElement.AddToClassList("fs-3");
            }
            if ((flags & FontSizeFlags.Size4) > 0)
            {
                visualElement.AddToClassList("fs-4");
            }
            if ((flags & FontSizeFlags.Size5) > 0)
            {
                visualElement.AddToClassList("fs-5");
            }
            if ((flags & FontSizeFlags.Size6) > 0)
            {
                visualElement.AddToClassList("fs-6");
            }
        }
        
        private static void AddClassNamesTo(VisualElement visualElement, FontStyleFlags flags)
        {
            if ((flags & FontStyleFlags.Bold) > 0)
            {
                visualElement.AddToClassList("fst-bold");
            }
            if ((flags & FontStyleFlags.Italic) > 0)
            {
                visualElement.AddToClassList("fst-italic");
            }
            if ((flags & FontStyleFlags.Normal) > 0)
            {
                visualElement.AddToClassList("fst-normal");
            }
        }
        
        [Flags]
        private enum DisplayFlags
        {
            Unset = 0,
            None = 1,
            Flex = 1<<2
        }
        [Flags]
        private enum FlexDirectionFlags
        {
            Unset = 0,
            Column = 1,
            ColumnReverse = 1<<2,
            Row = 1<<3,
            RowReverse = 1<<4,
        }
        [Flags]
        private enum JustifyContentFlags
        {
            Unset = 0,
            Start = 1,
            End = 1<<2,
            Center = 1<<3,
            Between = 1<<4,
            Around = 1<<5,
        }
        [Flags]
        private enum AlignFlags
        {
            Unset = 0,
            Start = 1,
            End = 1<<2,
            Center = 1<<3,
            Stretch = 1<<4,
        }
        [Flags]
        private enum FillFlags
        {
            Unset = 0,
            Set = 1,
        }
        [Flags]
        private enum GrowAndShrinkFlags
        {
            Unset = 0,
            Grow0 = 1,
            Grow1 = 1<<2,
            Shrink0 = 1<<3,
            Shrink1 = 1<<4
        }
        [Flags]
        private enum WrapFlags
        {
            Unset = 0,
            NoWrap = 1,
            Wrap = 1<<2,
            WrapReverse = 1<<3
        }
        [Flags]
        private enum MarginsFlags
        {
            Unset = 0,
            Zero = 1,
            Spacer1 = 1<<2,
            Spacer2 = 1<<3,
            Spacer3 = 1<<4,
            Spacer4 = 1<<5,
            Spacer5 = 1<<6,
            Auto = 1<<7,
            NegSpacer1 = 1<<8,
            NegSpacer2 = 1<<9,
            NegSpacer3 = 1<<10,
            NegSpacer4 = 1<<11,
            NegSpacer5 = 1<<12,
        }
        private struct Margins
        {
            public MarginsFlags general;
            public MarginsFlags top;
            public MarginsFlags bottom;
            public MarginsFlags start;
            public MarginsFlags end;
            public MarginsFlags x;
            public MarginsFlags y;
        }
        [Flags]
        private enum PaddingsFlags
        {
            Unset = 0,
            Zero = 1,
            Spacer1 = 1<<2,
            Spacer2 = 1<<3,
            Spacer3 = 1<<4,
            Spacer4 = 1<<5,
            Spacer5 = 1<<6,
            Auto = 1<<7,
        }
        private struct Paddings
        {
            public PaddingsFlags general;
            public PaddingsFlags top;
            public PaddingsFlags bottom;
            public PaddingsFlags start;
            public PaddingsFlags end;
            public PaddingsFlags x;
            public PaddingsFlags y;
        }
        [Flags]
        private enum GapsFlags
        {
            Unset = 0,
            Zero = 1,
            Spacer1 = 1<<2,
            Spacer2 = 1<<3,
            Spacer3 = 1<<4,
            Spacer4 = 1<<5,
            Spacer5 = 1<<6,
        }
        private struct Gaps
        {
            public GapsFlags general;
            public GapsFlags row;
            public GapsFlags column;
        }
        [Flags]
        private enum TextAlignmentFlags
        {
            Unset = 0,
            Start = 1,
            End = 1<<2,
            Center = 1<<3,
            UpperStart = 1<<4,
            UpperEnd = 1<<5,
            UpperCenter = 1<<6,
            MiddleStart = 1<<7,
            MiddleEnd = 1<<8,
            MiddleCenter = 1<<9,
            LowerStart = 1<<10,
            LowerEnd = 1<<11,
            LowerCenter = 1<<12,
        }
        [Flags]
        private enum VisibilityFlags
        {
            Unset = 0,
            Visible = 1,
            Invisible = 1<<2,
        }
        [Flags]
        private enum AbsoluteFillFlags
        {
            Unset = 0,
            Set = 1,
        }
        [Flags]
        private enum OpacityFlags
        {
            Unset = 0,
            V0 = 1,
            V25 = 1<<2,
            V50 = 1<<3,
            V75 = 1<<4,
            V100 = 1<<5,
        }
        [Flags]
        private enum OverflowFlags
        {
            Unset = 0,
            Hidden = 1,
            Visible = 1<<2,
        }
        [Flags]
        private enum PositionFlags
        {
            Unset = 0,
            Relative = 1,
            Absolute = 1<<2,
        }
        [Flags]
        private enum ArrangeElementsFlags
        {
            Unset = 0,
            Top0 = 1,
            Top50 = 1<<2,
            Top100 = 1<<3,
            Bottom0 = 1<<7,
            Bottom50 = 1<<8,
            Bottom100 = 1<<9,
            Start0 = 1<<10,
            Start50 = 1<<11,
            Start100 = 1<<12,
            End0 = 1<<4,
            End50 = 1<<5,
            End100 = 1<<6,
            TranslateMiddle = 1<<13,
            TranslateX = 1<<14,
            TranslateY = 1<<15,
        }
        [Flags]
        private enum SizingFlags
        {
            Unset = 0,
            Width0 = 1,
            Width25 = 1<<2,
            Width50 = 1<<3,
            Width75 = 1<<4,
            Width100 = 1<<5,
            WidthAuto = 1<<6,
            MaxWidth100 = 1<<7,
            Height0 = 1<<8,
            Height25 = 1<<9,
            Height50 = 1<<10,
            Height75 = 1<<11,
            Height100 = 1<<12,
            HeightAuto = 1<<13,
            MaxHeight100 = 1<<14
        }
        [Flags]
        private enum BackgroundFlags
        {
            Unset = 0,
            Primary = 1,
            PrimarySubtle = 1<<2,
            Secondary = 1<<3,
            SecondarySubtle = 1<<4,
            Success = 1<<5,
            SuccessSubtle = 1<<6,
            Danger = 1<<7,
            DangerSubtle = 1<<8,
            Warning = 1<<9,
            WarningSubtle = 1<<10,
            Info = 1<<11,
            InfoSubtle = 1<<12,
            Light = 1<<13,
            LightSubtle = 1<<14,
            Dark = 1<<15,
            DarkSubtle = 1<<16,
            Body = 1<<17,
            BodySecondary = 1<<18,
            BodyTertiary = 1<<19,
            Black = 1<<20,
            White = 1<<21,
            Transparent = 1<<22
        }
        [Flags]
        private enum BordersWidthFlags
        {
            Unset = 0,
            Set = 1,
            Top = 1<<2,
            Right = 1<<3,
            Bottom = 1<<4,
            Left = 1<<5,
            Top0 = 1<<6,
            Right0 = 1<<7,
            Bottom0 = 1<<8,
            Left0 = 1<<9,
            V1 = 1<<10,
            V2 = 1<<11,
            V3 = 1<<12,
            V4 = 1<<13,
            V5 = 1<<14,
        }
        [Flags]
        private enum BordersColorFlags
        {
            Unset = 0,
            Primary = 1,
            PrimarySubtle = 1<<2,
            Secondary = 1<<3,
            SecondarySubtle = 1<<4,
            Success = 1<<5,
            SuccessSubtle = 1<<6,
            Danger = 1<<7,
            DangerSubtle = 1<<8,
            Warning = 1<<9,
            WarningSubtle = 1<<10,
            Info = 1<<11,
            InfoSubtle = 1<<12,
            Light = 1<<13,
            LightSubtle = 1<<14,
            Dark = 1<<15,
            DarkSubtle = 1<<16,
            Black = 1<<17,
            White = 1<<18,
        }
        private struct Borders
        {
            public BordersWidthFlags width;
            public BordersColorFlags color;
        }
        [Flags]
        private enum ColorsFlags
        {
            Unset = 0,
            Primary = 1,
            PrimaryEmphasis = 1<<2,
            Secondary = 1<<3,
            SecondaryEmphasis = 1<<4,
            Success = 1<<5,
            SuccessEmphasis = 1<<6,
            Danger = 1<<7,
            DangerEmphasis = 1<<8,
            Warning = 1<<9,
            WarningEmphasis = 1<<10,
            Info = 1<<11,
            InfoEmphasis = 1<<12,
            Light = 1<<13,
            LightEmphasis = 1<<14,
            Dark = 1<<15,
            DarkEmphasis = 1<<16,
            Body = 1<<17,
            BodyEmphasis = 1<<18,
            BodySecondary = 1<<19,
            BodyTertiary = 1<<20,
            Black = 1<<21,
            White = 1<<22,
            Black50 = 1<<23,
            White50 = 1<<24
        }
        [Flags]
        private enum CornerRadiusFlags
        {
            Unset = 0,
            Set = 1,
            Radius0 = 1<<2,
            Radius1 = 1<<3,
            Radius2 = 1<<4,
            Radius3 = 1<<5,
            Radius4 = 1<<6,
            Radius5 = 1<<7,
            Circle = 1<<8,
        }
        private struct RoundedCorners
        {
            public CornerRadiusFlags general;
            public CornerRadiusFlags top;
            public CornerRadiusFlags right;
            public CornerRadiusFlags bottom;
            public CornerRadiusFlags left;
        }
        [Flags]
        private enum TextWrappingFlags
        {
            Unset = 0,
            Wrap = 1,
            NoWrap = 1<<2,
        }
        [Flags]
        private enum FontSizeFlags
        {
            Unset = 0,
            Size1 = 1,
            Size2 = 1<<2,
            Size3 = 1<<3,
            Size4 = 1<<4,
            Size5 = 1<<5,
            Size6 = 1<<6,
        }
        [Flags]
        private enum FontStyleFlags
        {
            Unset = 0,
            Bold = 1,
            Italic = 1<<2,
            Normal = 1<<3,
        }
        
        private delegate void ResponsiveClassNameAction<in T>(VisualElement visualElement, T value, Breakpoint breakpoint) where T : unmanaged;

        private struct ResponsiveUtility<T> where T : unmanaged
        {
            public T xs;
            public T sm;
            public T md;
            public T lg;
            public T xl;
            public T xxl;

            public void AddClassNamesTo(VisualElement visualElement, ResponsiveClassNameAction<T> action)
            {
                if (action == null)
                {
                    return;
                }
                
                action.Invoke(visualElement, xs, Breakpoint.XS);
                action.Invoke(visualElement, sm, Breakpoint.SM);
                action.Invoke(visualElement, md, Breakpoint.MD);
                action.Invoke(visualElement, lg, Breakpoint.LG);
                action.Invoke(visualElement, xl, Breakpoint.XL);
                action.Invoke(visualElement, xxl, Breakpoint.XXL);
            }
        }
    }
}
