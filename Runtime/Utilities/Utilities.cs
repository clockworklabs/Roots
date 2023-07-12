using System;

namespace Roots
{
    [Flags]
    public enum PhoneService
    {
        None = 0,
        // --- Display -
        DisplayNone  = 1,
        DisplayFlex  = 2,
        // --- Flex Direction -
        FlexRow = 4,
        FlexRowReverse = 8,
        FlexColumn = 16,
        FlexColumnReverse = 32,
        // --- Justify Content -
        JustifyContentStart = 64,
        JustifyContentCenter = 128,
        JustifyContentEnd = 256,
        JustifyContentBetween = 512,
        JustifyContentAround = 1024,
        // --- Align Items -
        AlignItemsStart = 2048,
        AlignItemsCenter = 4096,
        AlignItemsEnd = 8192,
        AlignItemsStretch = 16384,
        // --- Align Self -
        AlignSelfStart = 32768,
        AlignSelfCenter = 65536,
        AlignSelfEnd = 131072,
        AlignSelfStretch = 262144,
        // --- Fill -
        FlexFill = 524288,
        // --- Grow & Shrink -
        FlexGrow0 = 1048576,
        FlexGrow1 = 2097152,
        FlexShrink0 = 4194304,
        FlexShrink1 = 8388608,
        // --- Auto Margins -
        MarginTopAuto = 16777216,
        MarginEndAuto = 33554432, // Right in LTR
        MarginBottomAuto = 67108864,
        MarginStartAuto = 134217728, // Left in LTR
        // --- Wrap -
        FlexNoWrap = 268435456,
        FlexWrap = 536870912,
        FlexWrapReverse = 1073741824,
        // OUT OF BOUNDS
        // --- Align Content -
        // AlignContentStart = 2147483648,
        // AlignContentCenter = 4294967296,
        // AlignContentEnd = 8589934592,
        // AlignContentStretch = 17179869184,
        // --- Opacity -
        // Opacity100,
        // Opacity75,
        // Opacity50,
        // Opacity25,
        // Opacity0,
        // --- Overflow -
        // OverflowVisible,
        // OverflowHidden,
        // --- Position -
        // PositionRelative,
        // PositionAbsolute,
        // Top0,
        // Top50,
        // Top100,
        // End0,
        // End50,
        // End100,
        // Bottom0,
        // Bottom50,
        // Bottom100,
        // Start0,
        // Start50,
        // Start100,
        // TranslateMiddle,
        // TranslateMiddleX,
        // TranslateMiddleY,
        // --- Width -
        // Width0,
        // Width25,
        // Width50,
        // Width75,
        // Width100,
        // WidthAuto,
        // --- Height -
        // Height0,
        // Height25,
        // Height50,
        // Height75,
        // Height100,
        // HeightAuto,
        // --- Max Width -
        // MaxWidth0,
        // MaxWidth25,
        // MaxWidth50,
        // MaxWidth75,
        // MaxWidth100,
        // MaxWidthAuto,
        // --- Max Height -
        // MaxHeight0,
        // MaxHeight25,
        // MaxHeight50,
        // MaxHeight75,
        // MaxHeight100,
        // MaxHeightAuto,
        
    }
}
