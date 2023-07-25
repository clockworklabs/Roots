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
        private Utilities MarginTop0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTop1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTop2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTop3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTop4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTop5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTopAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTopNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTopNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTopNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTopNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginTopNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginTop(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEnd0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEnd1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEnd2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEnd3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEnd4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEnd5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEndAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEndNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEndNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEndNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEndNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginEndNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginEnd(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottom0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottom1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottom2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottom3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottom4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottom5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottomAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottomNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottomNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottomNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottomNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginBottomNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginBottom(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStart0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStart1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStart2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStart3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStart4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStart5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStartAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStartNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStartNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStartNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStartNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginStartNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginStart(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginX0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities MarginX1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginX2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginX3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginX4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginX5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginXAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities MarginXNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginXNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginXNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginXNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginXNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginX(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginY0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities MarginY1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginY2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginY3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginY4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginY5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginYAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities MarginYNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginYNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginYNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginYNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginYNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMarginY(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
        private Utilities Margin0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities Margin1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities Margin2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities Margin3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities Margin4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities Margin5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities MarginAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities MarginNeg1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer1, xs, sm, md, lg, xl, xxl);
        private Utilities MarginNeg2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer2, xs, sm, md, lg, xl, xxl);
        private Utilities MarginNeg3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer3, xs, sm, md, lg, xl, xxl);
        private Utilities MarginNeg4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer4, xs, sm, md, lg, xl, xxl);
        private Utilities MarginNeg5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrMargin(MarginsFlags.NegSpacer5, xs, sm, md, lg, xl, xxl);
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
        private Utilities PaddingTop0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingTop1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingTop2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingTop3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingTop4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingTop5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingTopAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingTop(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingEnd0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingEnd1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingEnd2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingEnd3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingEnd4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingEnd5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingEndAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingEnd(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingBottom0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingBottom1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingBottom2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingBottom3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingBottom4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingBottom5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingBottomAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingBottom(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingStart0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingStart1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingStart2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingStart3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingStart4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingStart5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingStartAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingStart(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingX0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingX1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingX2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingX3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingX4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingX5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingXAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingX(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingY0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingY1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingY2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingY3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingY4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingY5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingYAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPaddingY(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
        private Utilities Padding0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities Padding1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities Padding2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities Padding3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities Padding4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities Padding5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities PaddingAuto(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrPadding(PaddingsFlags.Auto, xs, sm, md, lg, xl, xxl);
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
        private Utilities RowGap0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities RowGap1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities RowGap2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities RowGap3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities RowGap4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities RowGap5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrRowGap(GapsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities ColumnGap0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities ColumnGap1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities ColumnGap2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities ColumnGap3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities ColumnGap4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities ColumnGap5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrColumnGap(GapsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
        private Utilities Gap0(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Zero, xs, sm, md, lg, xl, xxl);
        private Utilities Gap1(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer1, xs, sm, md, lg, xl, xxl);
        private Utilities Gap2(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer2, xs, sm, md, lg, xl, xxl);
        private Utilities Gap3(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer3, xs, sm, md, lg, xl, xxl);
        private Utilities Gap4(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer4, xs, sm, md, lg, xl, xxl);
        private Utilities Gap5(bool xs = false, bool sm = false, bool md = false, bool lg = false, bool xl = false, bool xxl = false) => OrGap(GapsFlags.Spacer5, xs, sm, md, lg, xl, xxl);
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
        

        public ClassName GetClassName(VisualElement visualElement)
        {
            var direction = LanguageDirection.Inherit;
            while(direction == LanguageDirection.Inherit && visualElement != null)
            {
                direction = visualElement.languageDirection;
                visualElement = visualElement.parent;
            }
            if (direction == LanguageDirection.Inherit)
            {
                direction = LanguageDirection.LTR;
            }
            
            var className = new ClassName();
            display.AddClassNames(ref className, AddClassNames);
            flexDirection.AddClassNames(ref className, AddClassNames);
            justifyContent.AddClassNames(ref className, AddClassNames);
            alignItems.AddClassNames(ref className, AddAlignItemsClassNames);
            alignSelf.AddClassNames(ref className, AddAlignSelfClassNames);
            fill.AddClassNames(ref className, AddClassNames);
            growAndShrink.AddClassNames(ref className, AddClassNames);
            wrap.AddClassNames(ref className, AddClassNames);
            alignContent.AddClassNames(ref className, AddAlignContentClassNames);
            margins.AddClassNames(ref className, direction, AddClassNames);
            paddings.AddClassNames(ref className, direction, AddClassNames);
            gaps.AddClassNames(ref className, AddClassNames);
            visibility.AddClassNames(ref className, AddClassNames);

            AddClassNames(absoluteFill, ref className);
            AddClassNames(opacity, ref className);
            AddClassNames(overflow, ref className);
            AddClassNames(position, ref className);
            AddClassNames(arrangeElements, direction, ref className);
            AddClassNames(sizing, ref className);
            AddClassNames(background, ref className);
            AddClassNames(borders, ref className);
            AddClassNames(colors, ref className);
            AddClassNames(roundedCorners, ref className);

            return className;
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

        private static void AddClassNames(DisplayFlags flags, ref ClassName className, Breakpoint breakpoint)
        {
            var prefix = $"display{GetBreakpoint(breakpoint)}";
            if ((flags & DisplayFlags.None) > 0)
            {
                className.Add($"{prefix}-none");
            }
            if ((flags & DisplayFlags.Flex) > 0)
            {
                className.Add($"{prefix}-flex");
            }
        }
        private static void AddClassNames(FlexDirectionFlags flags, ref ClassName className, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & FlexDirectionFlags.Column) > 0)
            {
                className.Add($"{prefix}-column");
            }
            if ((flags & FlexDirectionFlags.ColumnReverse) > 0)
            {
                className.Add($"{prefix}-column-reverse");
            }
            if ((flags & FlexDirectionFlags.Row) > 0)
            {
                className.Add($"{prefix}-row");
            }
            if ((flags & FlexDirectionFlags.RowReverse) > 0)
            {
                className.Add($"{prefix}-row-reverse");
            }
        }
        private static void AddClassNames(JustifyContentFlags flags, ref ClassName className, Breakpoint breakpoint)
        {
            var prefix = $"justify-content{GetBreakpoint(breakpoint)}";
            if ((flags & JustifyContentFlags.Start) > 0)
            {
                className.Add($"{prefix}-start");
            }
            if ((flags & JustifyContentFlags.End) > 0)
            {
                className.Add($"{prefix}-end");
            }
            if ((flags & JustifyContentFlags.Center) > 0)
            {
                className.Add($"{prefix}-center");
            }
            if ((flags & JustifyContentFlags.Between) > 0)
            {
                className.Add($"{prefix}-between");
            }
            if ((flags & JustifyContentFlags.Around) > 0)
            {
                className.Add($"{prefix}-around");
            }
        }

        private static void AddAlignItemsClassNames(AlignFlags flags, ref ClassName className, Breakpoint breakpoint) =>
            AddClassNames(flags, ref className, "align-items", breakpoint);
        private static void AddAlignSelfClassNames(AlignFlags flags, ref ClassName className, Breakpoint breakpoint) =>
            AddClassNames(flags, ref className, "align-items", breakpoint);
        private static void AddAlignContentClassNames(AlignFlags flags, ref ClassName className, Breakpoint breakpoint) =>
            AddClassNames(flags, ref className, "align-content", breakpoint);
        private static void AddClassNames(AlignFlags flags, ref ClassName className, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & AlignFlags.Start) > 0)
            {
                className.Add($"{prefix}-start");
            }
            if ((flags & AlignFlags.End) > 0)
            {
                className.Add($"{prefix}-end");
            }
            if ((flags & AlignFlags.Center) > 0)
            {
                className.Add($"{prefix}-center");
            }
            if ((flags & AlignFlags.Stretch) > 0)
            {
                className.Add($"{prefix}-between");
            }
        }
        
        private static void AddClassNames(FillFlags flags, ref ClassName className, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & FillFlags.Set) > 0)
            {
                className.Add($"{prefix}-fill");
            }
        }
        
        private static void AddClassNames(GrowAndShrinkFlags flags, ref ClassName className, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & GrowAndShrinkFlags.Grow0) > 0)
            {
                className.Add($"{prefix}-grow-0");
            }
            if ((flags & GrowAndShrinkFlags.Grow1) > 0)
            {
                className.Add($"{prefix}-grow-1");
            }
            if ((flags & GrowAndShrinkFlags.Shrink0) > 0)
            {
                className.Add($"{prefix}-shrink-0");
            }
            if ((flags & GrowAndShrinkFlags.Shrink1) > 0)
            {
                className.Add($"{prefix}-shrink-1");
            }
        }
        
        private static void AddClassNames(WrapFlags flags, ref ClassName className, Breakpoint breakpoint)
        {
            var prefix = $"flex{GetBreakpoint(breakpoint)}";
            if ((flags & WrapFlags.NoWrap) > 0)
            {
                className.Add($"{prefix}-nowrap");
            }
            if ((flags & WrapFlags.Wrap) > 0)
            {
                className.Add($"{prefix}-wrap");
            }
            if ((flags & WrapFlags.WrapReverse) > 0)
            {
                className.Add($"{prefix}-wrap-reverse");
            }
        }
        
        private static void AddClassNames(Margins margins, ref ClassName className, LanguageDirection languageDirection, Breakpoint breakpoint)
        {
            AddClassNames(margins.top, ref className, "mt", breakpoint);
            AddClassNames(margins.bottom, ref className, "mb", breakpoint);
            AddClassNames(margins.start, ref className, languageDirection == LanguageDirection.RTL ? "mr" : "ml", breakpoint);
            AddClassNames(margins.end, ref className, languageDirection == LanguageDirection.RTL ? "ml" : "mr", breakpoint);
            AddClassNames(margins.x, ref className, "mx", breakpoint);
            AddClassNames(margins.y, ref className, "my", breakpoint);
            AddClassNames(margins.general, ref className, "m", breakpoint);
        }
        private static void AddClassNames(MarginsFlags flags, ref ClassName className, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & MarginsFlags.Zero) > 0)
            {
                className.Add($"{prefix}-0");
            }
            if ((flags & MarginsFlags.Spacer1) > 0)
            {
                className.Add($"{prefix}-1");
            }
            if ((flags & MarginsFlags.Spacer2) > 0)
            {
                className.Add($"{prefix}-2");
            }
            if ((flags & MarginsFlags.Spacer3) > 0)
            {
                className.Add($"{prefix}-3");
            }
            if ((flags & MarginsFlags.Spacer4) > 0)
            {
                className.Add($"{prefix}-4");
            }
            if ((flags & MarginsFlags.Spacer5) > 0)
            {
                className.Add($"{prefix}-5");
            }
            if ((flags & MarginsFlags.Auto) > 0)
            {
                className.Add($"{prefix}-auto");
            }
            if ((flags & MarginsFlags.NegSpacer1) > 0)
            {
                className.Add($"{prefix}-n1");
            }
            if ((flags & MarginsFlags.NegSpacer2) > 0)
            {
                className.Add($"{prefix}-n2");
            }
            if ((flags & MarginsFlags.NegSpacer3) > 0)
            {
                className.Add($"{prefix}-n3");
            }
            if ((flags & MarginsFlags.NegSpacer4) > 0)
            {
                className.Add($"{prefix}-n4");
            }
            if ((flags & MarginsFlags.NegSpacer5) > 0)
            {
                className.Add($"{prefix}-n5");
            }
        }
        
        private static void AddClassNames(Paddings paddings, ref ClassName className, LanguageDirection languageDirection, Breakpoint breakpoint)
        {
            AddClassNames(paddings.top, ref className, "pt", breakpoint);
            AddClassNames(paddings.bottom, ref className, "pb", breakpoint);
            AddClassNames(paddings.start, ref className, languageDirection == LanguageDirection.RTL ? "pr" : "pl", breakpoint);
            AddClassNames(paddings.end, ref className, languageDirection == LanguageDirection.RTL ? "pl" : "pr", breakpoint);
            AddClassNames(paddings.x, ref className, "px", breakpoint);
            AddClassNames(paddings.y, ref className, "py", breakpoint);
            AddClassNames(paddings.general, ref className, "p", breakpoint);
        }
        private static void AddClassNames(PaddingsFlags flags, ref ClassName className, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & PaddingsFlags.Zero) > 0)
            {
                className.Add($"{prefix}-0");
            }
            if ((flags & PaddingsFlags.Spacer1) > 0)
            {
                className.Add($"{prefix}-1");
            }
            if ((flags & PaddingsFlags.Spacer2) > 0)
            {
                className.Add($"{prefix}-2");
            }
            if ((flags & PaddingsFlags.Spacer3) > 0)
            {
                className.Add($"{prefix}-3");
            }
            if ((flags & PaddingsFlags.Spacer4) > 0)
            {
                className.Add($"{prefix}-4");
            }
            if ((flags & PaddingsFlags.Spacer5) > 0)
            {
                className.Add($"{prefix}-5");
            }
            if ((flags & PaddingsFlags.Auto) > 0)
            {
                className.Add($"{prefix}-auto");
            }
        }
        
        private static void AddClassNames(Gaps gaps, ref ClassName className, Breakpoint breakpoint)
        {
            AddClassNames(gaps.row, ref className, "row-gap", breakpoint);
            AddClassNames(gaps.column, ref className, "column-gap", breakpoint);
            AddClassNames(gaps.general, ref className, "gap", breakpoint);
        }
        private static void AddClassNames(GapsFlags flags, ref ClassName className, string prefix, Breakpoint breakpoint)
        {
            prefix = $"{prefix}{GetBreakpoint(breakpoint)}";
            if ((flags & GapsFlags.Zero) > 0)
            {
                className.Add($"{prefix}-0");
            }
            if ((flags & GapsFlags.Spacer1) > 0)
            {
                className.Add($"{prefix}-1");
            }
            if ((flags & GapsFlags.Spacer2) > 0)
            {
                className.Add($"{prefix}-2");
            }
            if ((flags & GapsFlags.Spacer3) > 0)
            {
                className.Add($"{prefix}-3");
            }
            if ((flags & GapsFlags.Spacer4) > 0)
            {
                className.Add($"{prefix}-4");
            }
            if ((flags & GapsFlags.Spacer5) > 0)
            {
                className.Add($"{prefix}-5");
            }
        }
        
        private static void AddClassNames(VisibilityFlags flags, ref ClassName className, Breakpoint breakpoint)
        {
            var postfix = GetBreakpoint(breakpoint);
            if ((flags & VisibilityFlags.Visible) > 0)
            {
                className.Add($"visible{postfix}");
            }
            if ((flags & VisibilityFlags.Invisible) > 0)
            {
                className.Add($"invisible{postfix}");
            }
        }
        
        private static void AddClassNames(AbsoluteFillFlags flags, ref ClassName className)
        {
            if ((flags & AbsoluteFillFlags.Set) > 0)
            {
                className.Add("absolute-fill");
            }
        }
        
        private static void AddClassNames(OpacityFlags flags, ref ClassName className)
        {
            if ((flags & OpacityFlags.V0) > 0)
            {
                className.Add("opacity-0");
            }
            if ((flags & OpacityFlags.V25) > 0)
            {
                className.Add("opacity-25");
            }
            if ((flags & OpacityFlags.V50) > 0)
            {
                className.Add("opacity-50");
            }
            if ((flags & OpacityFlags.V75) > 0)
            {
                className.Add("opacity-75");
            }
            if ((flags & OpacityFlags.V100) > 0)
            {
                className.Add("opacity-100");
            }
        }
        
        private static void AddClassNames(OverflowFlags flags, ref ClassName className)
        {
            if ((flags & OverflowFlags.Hidden) > 0)
            {
                className.Add("overflow-hidden");
            }
            if ((flags & OverflowFlags.Visible) > 0)
            {
                className.Add("overflow-visible");
            }
        }
        
        private static void AddClassNames(PositionFlags flags, ref ClassName className)
        {
            if ((flags & PositionFlags.Relative) > 0)
            {
                className.Add("position-relative");
            }
            if ((flags & PositionFlags.Absolute) > 0)
            {
                className.Add("position-absolute");
            }
        }
        
        private static void AddClassNames(ArrangeElementsFlags flags, LanguageDirection direction, ref ClassName className)
        {
            if ((flags & ArrangeElementsFlags.Top0) > 0)
            {
                className.Add("top-0");
            }
            if ((flags & ArrangeElementsFlags.Top50) > 0)
            {
                className.Add("top-50");
            }
            if ((flags & ArrangeElementsFlags.Top100) > 0)
            {
                className.Add("top-100");
            }
            if ((flags & ArrangeElementsFlags.Bottom0) > 0)
            {
                className.Add("bottom-0");
            }
            if ((flags & ArrangeElementsFlags.Bottom50) > 0)
            {
                className.Add("bottom-50");
            }
            if ((flags & ArrangeElementsFlags.Bottom100) > 0)
            {
                className.Add("bottom-100");
            }
            var startPrefix = direction == LanguageDirection.RTL ? "right" : "left";
            if ((flags & ArrangeElementsFlags.Start0) > 0)
            {
                className.Add($"{startPrefix}-0");
            }
            if ((flags & ArrangeElementsFlags.Start50) > 0)
            {
                className.Add($"{startPrefix}-50");
            }
            if ((flags & ArrangeElementsFlags.Start100) > 0)
            {
                className.Add($"{startPrefix}-100");
            }
            var endPrefix = direction == LanguageDirection.RTL ? "left" : "right";
            if ((flags & ArrangeElementsFlags.End0) > 0)
            {
                className.Add($"{endPrefix}-0");
            }
            if ((flags & ArrangeElementsFlags.End50) > 0)
            {
                className.Add($"{endPrefix}-50");
            }
            if ((flags & ArrangeElementsFlags.End100) > 0)
            {
                className.Add($"{endPrefix}-100");
            }
            if ((flags & ArrangeElementsFlags.TranslateMiddle) > 0)
            {
                className.Add("translate-middle");
            }
            if ((flags & ArrangeElementsFlags.TranslateX) > 0)
            {
                className.Add("translate-x");
            }
            if ((flags & ArrangeElementsFlags.TranslateY) > 0)
            {
                className.Add("translate-y");
            }
        }
        
        private static void AddClassNames(SizingFlags flags, ref ClassName className)
        {
            if ((flags & SizingFlags.Width0) > 0)
            {
                className.Add("w-0");
            }
            if ((flags & SizingFlags.Width25) > 0)
            {
                className.Add("w-25");
            }
            if ((flags & SizingFlags.Width50) > 0)
            {
                className.Add("w-50");
            }
            if ((flags & SizingFlags.Width100) > 0)
            {
                className.Add("w-100");
            }
            if ((flags & SizingFlags.WidthAuto) > 0)
            {
                className.Add("w-auto");
            }
            if ((flags & SizingFlags.MaxWidth100) > 0)
            {
                className.Add("mw-100");
            }
            if ((flags & SizingFlags.Height0) > 0)
            {
                className.Add("h-0");
            }
            if ((flags & SizingFlags.Height25) > 0)
            {
                className.Add("h-25");
            }
            if ((flags & SizingFlags.Height50) > 0)
            {
                className.Add("h-50");
            }
            if ((flags & SizingFlags.Height100) > 0)
            {
                className.Add("h-100");
            }
            if ((flags & SizingFlags.HeightAuto) > 0)
            {
                className.Add("h-auto");
            }
            if ((flags & SizingFlags.MaxHeight100) > 0)
            {
                className.Add("mh-100");
            }
        }
        
        private static void AddClassNames(BackgroundFlags flags, ref ClassName className)
        {
            if ((flags & BackgroundFlags.Primary) > 0)
            {
                className.Add("bg-primary");
            }
            if ((flags & BackgroundFlags.PrimarySubtle) > 0)
            {
                className.Add("bg-primary-subtle");
            }
            if ((flags & BackgroundFlags.Secondary) > 0)
            {
                className.Add("bg-secondary");
            }
            if ((flags & BackgroundFlags.SecondarySubtle) > 0)
            {
                className.Add("bg-secondary-subtle");
            }
            if ((flags & BackgroundFlags.Success) > 0)
            {
                className.Add("bg-success");
            }
            if ((flags & BackgroundFlags.SuccessSubtle) > 0)
            {
                className.Add("bg-success-subtle");
            }
            if ((flags & BackgroundFlags.Danger) > 0)
            {
                className.Add("bg-danger");
            }
            if ((flags & BackgroundFlags.DangerSubtle) > 0)
            {
                className.Add("bg-danger-subtle");
            }
            if ((flags & BackgroundFlags.Warning) > 0)
            {
                className.Add("bg-warning");
            }
            if ((flags & BackgroundFlags.WarningSubtle) > 0)
            {
                className.Add("bg-warning-subtle");
            }
            if ((flags & BackgroundFlags.Info) > 0)
            {
                className.Add("bg-info");
            }
            if ((flags & BackgroundFlags.InfoSubtle) > 0)
            {
                className.Add("bg-info-subtle");
            }
            if ((flags & BackgroundFlags.Light) > 0)
            {
                className.Add("bg-light");
            }
            if ((flags & BackgroundFlags.LightSubtle) > 0)
            {
                className.Add("bg-light-subtle");
            }
            if ((flags & BackgroundFlags.Dark) > 0)
            {
                className.Add("bg-dark");
            }
            if ((flags & BackgroundFlags.DarkSubtle) > 0)
            {
                className.Add("bg-dark-subtle");
            }
            if ((flags & BackgroundFlags.Body) > 0)
            {
                className.Add("bg-body");
            }
            if ((flags & BackgroundFlags.BodySecondary) > 0)
            {
                className.Add("bg-body-tertiary");
            }
            if ((flags & BackgroundFlags.BodyTertiary) > 0)
            {
                className.Add("bg-body-tertiary");
            }
            if ((flags & BackgroundFlags.Black) > 0)
            {
                className.Add("bg-black");
            }
            if ((flags & BackgroundFlags.White) > 0)
            {
                className.Add("bg-white");
            }
            if ((flags & BackgroundFlags.Transparent) > 0)
            {
                className.Add("bg-transparent");
            }
        }

        private static void AddClassNames(Borders borders, ref ClassName className)
        {
            AddClassNames(borders.width, ref className);
            AddClassNames(borders.color, ref className);
        }
        private static void AddClassNames(BordersWidthFlags flags, ref ClassName className)
        {
            if ((flags & BordersWidthFlags.Set) > 0)
            {
                className.Add("border");
            }
            if ((flags & BordersWidthFlags.Top) > 0)
            {
                className.Add("border-top");
            }
            if ((flags & BordersWidthFlags.Right) > 0)
            {
                className.Add("border-right");
            }
            if ((flags & BordersWidthFlags.Left) > 0)
            {
                className.Add("border-left");
            }
            if ((flags & BordersWidthFlags.Top0) > 0)
            {
                className.Add("border-top-0");
            }
            if ((flags & BordersWidthFlags.Right0) > 0)
            {
                className.Add("border-right-0");
            }
            if ((flags & BordersWidthFlags.Left0) > 0)
            {
                className.Add("border-left-0");
            }
            if ((flags & BordersWidthFlags.V1) > 0)
            {
                className.Add("border-1");
            }
            if ((flags & BordersWidthFlags.V2) > 0)
            {
                className.Add("border-2");
            }
            if ((flags & BordersWidthFlags.V3) > 0)
            {
                className.Add("border-3");
            }
            if ((flags & BordersWidthFlags.V4) > 0)
            {
                className.Add("border-4");
            }
            if ((flags & BordersWidthFlags.V5) > 0)
            {
                className.Add("border-5");
            }
        }
        private static void AddClassNames(BordersColorFlags flags, ref ClassName className)
        {
            if ((flags & BordersColorFlags.Primary) > 0)
            {
                className.Add("border-primary");
            }
            if ((flags & BordersColorFlags.PrimarySubtle) > 0)
            {
                className.Add("border-primary-subtle");
            }
            if ((flags & BordersColorFlags.Secondary) > 0)
            {
                className.Add("border-secondary");
            }
            if ((flags & BordersColorFlags.SecondarySubtle) > 0)
            {
                className.Add("border-secondary-subtle");
            }
            if ((flags & BordersColorFlags.Success) > 0)
            {
                className.Add("border-success");
            }
            if ((flags & BordersColorFlags.SuccessSubtle) > 0)
            {
                className.Add("border-success-subtle");
            }
            if ((flags & BordersColorFlags.Danger) > 0)
            {
                className.Add("border-danger");
            }
            if ((flags & BordersColorFlags.DangerSubtle) > 0)
            {
                className.Add("border-danger-subtle");
            }
            if ((flags & BordersColorFlags.Warning) > 0)
            {
                className.Add("border-warning");
            }
            if ((flags & BordersColorFlags.WarningSubtle) > 0)
            {
                className.Add("border-warning-subtle");
            }
            if ((flags & BordersColorFlags.Info) > 0)
            {
                className.Add("border-info");
            }
            if ((flags & BordersColorFlags.InfoSubtle) > 0)
            {
                className.Add("border-info-subtle");
            }
            if ((flags & BordersColorFlags.Light) > 0)
            {
                className.Add("border-light");
            }
            if ((flags & BordersColorFlags.LightSubtle) > 0)
            {
                className.Add("border-light-subtle");
            }
            if ((flags & BordersColorFlags.Dark) > 0)
            {
                className.Add("border-dark");
            }
            if ((flags & BordersColorFlags.DarkSubtle) > 0)
            {
                className.Add("border-dark-subtle");
            }
            if ((flags & BordersColorFlags.Black) > 0)
            {
                className.Add("border-black");
            }
            if ((flags & BordersColorFlags.White) > 0)
            {
                className.Add("border-white");
            }
        }
        
        private static void AddClassNames(ColorsFlags flags, ref ClassName className)
        {
            if ((flags & ColorsFlags.Primary) > 0)
            {
                className.Add("text-primary");
            }
            if ((flags & ColorsFlags.PrimaryEmphasis) > 0)
            {
                className.Add("text-primary-emphasis");
            }
            if ((flags & ColorsFlags.Secondary) > 0)
            {
                className.Add("text-secondary");
            }
            if ((flags & ColorsFlags.SecondaryEmphasis) > 0)
            {
                className.Add("text-secondary-emphasis");
            }
            if ((flags & ColorsFlags.Success) > 0)
            {
                className.Add("text-success");
            }
            if ((flags & ColorsFlags.SuccessEmphasis) > 0)
            {
                className.Add("text-success-emphasis");
            }
            if ((flags & ColorsFlags.Danger) > 0)
            {
                className.Add("text-danger");
            }
            if ((flags & ColorsFlags.DangerEmphasis) > 0)
            {
                className.Add("text-danger-emphasis");
            }
            if ((flags & ColorsFlags.Warning) > 0)
            {
                className.Add("text-warning");
            }
            if ((flags & ColorsFlags.WarningEmphasis) > 0)
            {
                className.Add("text-warning-emphasis");
            }
            if ((flags & ColorsFlags.Info) > 0)
            {
                className.Add("text-info");
            }
            if ((flags & ColorsFlags.InfoEmphasis) > 0)
            {
                className.Add("text-info-emphasis");
            }
            if ((flags & ColorsFlags.Light) > 0)
            {
                className.Add("text-light");
            }
            if ((flags & ColorsFlags.LightEmphasis) > 0)
            {
                className.Add("text-light-emphasis");
            }
            if ((flags & ColorsFlags.Dark) > 0)
            {
                className.Add("text-dark");
            }
            if ((flags & ColorsFlags.DarkEmphasis) > 0)
            {
                className.Add("text-dark-emphasis");
            }
            if ((flags & ColorsFlags.Body) > 0)
            {
                className.Add("text-body");
            }
            if ((flags & ColorsFlags.BodyEmphasis) > 0)
            {
                className.Add("text-body-emphasis");
            }
            if ((flags & ColorsFlags.BodySecondary) > 0)
            {
                className.Add("text-body-secondary");
            }
            if ((flags & ColorsFlags.BodyTertiary) > 0)
            {
                className.Add("text-body-tertiary");
            }
            if ((flags & ColorsFlags.Black) > 0)
            {
                className.Add("text-black");
            }
            if ((flags & ColorsFlags.White) > 0)
            {
                className.Add("text-white");
            }
            if ((flags & ColorsFlags.Black50) > 0)
            {
                className.Add("text-black-50");
            }
            if ((flags & ColorsFlags.White50) > 0)
            {
                className.Add("text-white-50");
            }
        }

        private static void AddClassNames(RoundedCorners roundedCorners, ref ClassName className)
        {
            AddClassNames(roundedCorners.general, string.Empty, ref className);
            AddClassNames(roundedCorners.top, "-top", ref className);
            AddClassNames(roundedCorners.right, "-right", ref className);
            AddClassNames(roundedCorners.bottom, "-bottom", ref className);
            AddClassNames(roundedCorners.left, "-left", ref className);
        }
        private static void AddClassNames(CornerRadiusFlags flags, string side, ref ClassName className)
        {
            var prefix = $"rounded{side}";
            if ((flags & CornerRadiusFlags.Set) > 0)
            {
                className.Add(prefix);
            }
            if ((flags & CornerRadiusFlags.Radius0) > 0)
            {
                className.Add($"{prefix}-0");
            }
            if ((flags & CornerRadiusFlags.Radius1) > 0)
            {
                className.Add($"{prefix}-1");
            }
            if ((flags & CornerRadiusFlags.Radius2) > 0)
            {
                className.Add($"{prefix}-2");
            }
            if ((flags & CornerRadiusFlags.Radius3) > 0)
            {
                className.Add($"{prefix}-3");
            }
            if ((flags & CornerRadiusFlags.Radius4) > 0)
            {
                className.Add($"{prefix}-4");
            }
            if ((flags & CornerRadiusFlags.Radius5) > 0)
            {
                className.Add($"{prefix}-5");
            }
            if ((flags & CornerRadiusFlags.Circle) > 0)
            {
                className.Add($"{prefix}-circle");
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
        
        private delegate void ResponsiveClassNameAction<in T>(T value, ref ClassName className, Breakpoint breakpoint) where T : unmanaged;
        private delegate void ResponsiveDirectionClassNameAction<in T>(T value, ref ClassName className, LanguageDirection direction, Breakpoint breakpoint) where T : unmanaged;

        private struct ResponsiveUtility<T> where T : unmanaged
        {
            public T xs;
            public T sm;
            public T md;
            public T lg;
            public T xl;
            public T xxl;

            public void AddClassNames(ref ClassName className, ResponsiveClassNameAction<T> action)
            {
                if (action == null)
                {
                    return;
                }
                
                action.Invoke(xs, ref className, Breakpoint.XS);
                action.Invoke(sm, ref className, Breakpoint.SM);
                action.Invoke(md, ref className, Breakpoint.MD);
                action.Invoke(lg, ref className, Breakpoint.LG);
                action.Invoke(xl, ref className, Breakpoint.XL);
                action.Invoke(xxl, ref className, Breakpoint.XXL);
            }

            public void AddClassNames(ref ClassName className, LanguageDirection direction, ResponsiveDirectionClassNameAction<T> action)
            {
                if (action == null)
                {
                    return;
                }
                
                action.Invoke(xs, ref className, direction, Breakpoint.XS);
                action.Invoke(sm, ref className, direction, Breakpoint.SM);
                action.Invoke(md, ref className, direction, Breakpoint.MD);
                action.Invoke(lg, ref className, direction, Breakpoint.LG);
                action.Invoke(xl, ref className, direction, Breakpoint.XL);
                action.Invoke(xxl, ref className, direction, Breakpoint.XXL);
            }
        }
    }
}
