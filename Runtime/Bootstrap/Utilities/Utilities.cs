using RishUI;
using RishUI.MemoryManagement;

namespace Roots.Bootstrap
{
    public static class Utilities
    {
        [RequiresManagedContext]
        public static ClassName DisplayNone(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => DisplayNoneString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName DisplayNone(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).DisplayNone(responsiveSize);
        [RequiresManagedContext]
        public static ClassName DisplayNone(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(DisplayNoneString(responsiveSize));
            return className;
        }
        private static string DisplayNoneString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "display-none"
            : $"display-{GetResponsiveSizeUSSCode(responsiveSize)}-none";
        
        [RequiresManagedContext]
        public static ClassName DisplayFlex(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => DisplayFlexString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName DisplayFlex(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).DisplayFlex(responsiveSize);
        [RequiresManagedContext]
        public static ClassName DisplayFlex(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(DisplayFlexString(responsiveSize));
            return className;
        }
        private static string DisplayFlexString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "display-flex"
            : $"display-{GetResponsiveSizeUSSCode(responsiveSize)}-flex";
        
        [RequiresManagedContext]
        public static ClassName FlexColumn(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexColumnString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexColumn(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexColumn(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexColumn(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexColumnString(responsiveSize));
            return className;
        }
        private static string FlexColumnString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-column"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-column";
        
        [RequiresManagedContext]
        public static ClassName FlexColumnReverse(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexColumnReverseString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexColumnReverse(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexColumnReverse(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexColumnReverse(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexColumnReverseString(responsiveSize));
            return className;
        }
        private static string FlexColumnReverseString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-column-reverse"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-column-reverse";
        
        [RequiresManagedContext]
        public static ClassName FlexRow(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexRowString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexRow(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexRow(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexRow(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexRowString(responsiveSize));
            return className;
        }
        private static string FlexRowString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-row"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-row";
        
        [RequiresManagedContext]
        public static ClassName FlexRowReverse(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexRowReverseString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexRowReverse(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexRowReverse(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexRowReverse(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexRowReverseString(responsiveSize));
            return className;
        }
        private static string FlexRowReverseString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-row-reverse"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-row-reverse";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentStart(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => JustifyContentStartString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentStart(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).JustifyContentStart(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentStart(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(JustifyContentStartString(responsiveSize));
            return className;
        }
        private static string JustifyContentStartString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "justify-content-start"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveSize)}-start";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentEnd(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => JustifyContentEndString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentEnd(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).JustifyContentEnd(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentEnd(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(JustifyContentEndString(responsiveSize));
            return className;
        }
        private static string JustifyContentEndString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "justify-content-end"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveSize)}-end";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => JustifyContentCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).JustifyContentCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(JustifyContentCenterString(responsiveSize));
            return className;
        }
        private static string JustifyContentCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "justify-content-center"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveSize)}-center";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentBetween(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => JustifyContentBetweenString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentBetween(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).JustifyContentBetween(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentBetween(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(JustifyContentBetweenString(responsiveSize));
            return className;
        }
        private static string JustifyContentBetweenString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "justify-content-between"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveSize)}-between";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentAround(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => JustifyContentAroundString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentAround(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).JustifyContentAround(responsiveSize);
        [RequiresManagedContext]
        public static ClassName JustifyContentAround(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(JustifyContentAroundString(responsiveSize));
            return className;
        }
        private static string JustifyContentAroundString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "justify-content-around"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveSize)}-around";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsStart(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignItemsStartString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsStart(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignItemsStart(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsStart(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignItemsStartString(responsiveSize));
            return className;
        }
        private static string AlignItemsStartString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-items-start"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveSize)}-start";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsEnd(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignItemsEndString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsEnd(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignItemsEnd(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsEnd(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignItemsEndString(responsiveSize));
            return className;
        }
        private static string AlignItemsEndString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-items-end"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveSize)}-end";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignItemsCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignItemsCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignItemsCenterString(responsiveSize));
            return className;
        }
        private static string AlignItemsCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-items-center"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveSize)}-center";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsStretch(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignItemsStretchString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsStretch(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignItemsStretch(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignItemsStretch(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignItemsStretchString(responsiveSize));
            return className;
        }
        private static string AlignItemsStretchString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-items-stretch"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveSize)}-stretch";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfStart(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignSelfStartString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfStart(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignSelfStart(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfStart(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignSelfStartString(responsiveSize));
            return className;
        }
        private static string AlignSelfStartString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-self-start"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveSize)}-start";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfEnd(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignSelfEndString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfEnd(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignSelfEnd(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfEnd(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignSelfEndString(responsiveSize));
            return className;
        }
        private static string AlignSelfEndString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-self-end"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveSize)}-end";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignSelfCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignSelfCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignSelfCenterString(responsiveSize));
            return className;
        }
        private static string AlignSelfCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-self-center"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveSize)}-center";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfStretch(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignSelfStretchString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfStretch(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignSelfStretch(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignSelfStretch(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignSelfStretchString(responsiveSize));
            return className;
        }
        private static string AlignSelfStretchString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-self-stretch"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveSize)}-stretch";
        
        [RequiresManagedContext]
        public static ClassName FlexFill(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexFillString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexFill(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexFill(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexFill(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexFillString(responsiveSize));
            return className;
        }
        private static string FlexFillString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-fill"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-fill";
        
        [RequiresManagedContext]
        public static ClassName FlexGrow0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexGrow0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexGrow0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexGrow0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexGrow0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexGrow0String(responsiveSize));
            return className;
        }
        private static string FlexGrow0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-grow-0"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-grow-0";
        
        [RequiresManagedContext]
        public static ClassName FlexGrow1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexGrow1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexGrow1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexGrow1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexGrow1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexGrow1String(responsiveSize));
            return className;
        }
        private static string FlexGrow1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-grow-1"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-grow-1";
        
        [RequiresManagedContext]
        public static ClassName FlexShrink0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexShrink0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexShrink0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexShrink0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexShrink0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexShrink0String(responsiveSize));
            return className;
        }
        private static string FlexShrink0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-shrink-0"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-shrink-0";
        
        [RequiresManagedContext]
        public static ClassName FlexShrink1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexShrink1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexShrink1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexShrink1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexShrink1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexShrink1String(responsiveSize));
            return className;
        }
        private static string FlexShrink1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-shrink-1"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-shrink-1";
        
        [RequiresManagedContext]
        public static ClassName FlexNoWrap(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexNoWrapString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexNoWrap(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexNoWrap(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexNoWrap(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexNoWrapString(responsiveSize));
            return className;
        }
        private static string FlexNoWrapString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-nowrap"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-nowrap";
        
        [RequiresManagedContext]
        public static ClassName FlexWrap(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexWrapString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexWrap(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexWrap(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexWrap(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexWrapString(responsiveSize));
            return className;
        }
        private static string FlexWrapString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-wrap"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-wrap";
        
        [RequiresManagedContext]
        public static ClassName FlexWrapReverse(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => FlexWrapReverseString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexWrapReverse(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).FlexWrapReverse(responsiveSize);
        [RequiresManagedContext]
        public static ClassName FlexWrapReverse(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(FlexWrapReverseString(responsiveSize));
            return className;
        }
        private static string FlexWrapReverseString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "flex-wrap-reverse"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveSize)}-wrap-reverse";
        
        [RequiresManagedContext]
        public static ClassName AlignContentStart(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignContentStartString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentStart(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignContentStart(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentStart(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignContentStartString(responsiveSize));
            return className;
        }
        private static string AlignContentStartString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-content-start"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveSize)}-start";
        
        [RequiresManagedContext]
        public static ClassName AlignContentEnd(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignContentEndString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentEnd(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignContentEnd(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentEnd(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignContentEndString(responsiveSize));
            return className;
        }
        private static string AlignContentEndString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-content-end"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveSize)}-end";
        
        [RequiresManagedContext]
        public static ClassName AlignContentCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignContentCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignContentCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignContentCenterString(responsiveSize));
            return className;
        }
        private static string AlignContentCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-content-center"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveSize)}-center";
        
        [RequiresManagedContext]
        public static ClassName AlignContentStretch(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => AlignContentStretchString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentStretch(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).AlignContentStretch(responsiveSize);
        [RequiresManagedContext]
        public static ClassName AlignContentStretch(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(AlignContentStretchString(responsiveSize));
            return className;
        }
        private static string AlignContentStretchString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "align-content-stretch"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveSize)}-stretch";
        
        [RequiresManagedContext]
        public static ClassName MarginTop0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTop0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTop0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTop0String(responsiveSize));
            return className;
        }
        private static string MarginTop0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-0"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginTop1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTop1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTop1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTop1String(responsiveSize));
            return className;
        }
        private static string MarginTop1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginTop2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTop2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTop2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTop2String(responsiveSize));
            return className;
        }
        private static string MarginTop2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginTop3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTop3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTop3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTop3String(responsiveSize));
            return className;
        }
        private static string MarginTop3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginTop4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTop4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTop4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTop4String(responsiveSize));
            return className;
        }
        private static string MarginTop4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginTop5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTop5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTop5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTop5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTop5String(responsiveSize));
            return className;
        }
        private static string MarginTop5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginTopAuto(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopAutoString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopAuto(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopAuto(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopAuto(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopAutoString(responsiveSize));
            return className;
        }
        private static string MarginTopAutoString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-auto"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopHalf1String(responsiveSize));
            return className;
        }
        private static string MarginTopHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-h1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopHalf2String(responsiveSize));
            return className;
        }
        private static string MarginTopHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-h2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopHalf3String(responsiveSize));
            return className;
        }
        private static string MarginTopHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-h3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopHalf4String(responsiveSize));
            return className;
        }
        private static string MarginTopHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-h4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopHalf5String(responsiveSize));
            return className;
        }
        private static string MarginTopHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-h5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegative1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegative1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegative1String(responsiveSize));
            return className;
        }
        private static string MarginTopNegative1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-n1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegative2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegative2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegative2String(responsiveSize));
            return className;
        }
        private static string MarginTopNegative2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-n2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegative3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegative3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegative3String(responsiveSize));
            return className;
        }
        private static string MarginTopNegative3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-n3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegative4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegative4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegative4String(responsiveSize));
            return className;
        }
        private static string MarginTopNegative4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-n4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegative5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegative5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegative5String(responsiveSize));
            return className;
        }
        private static string MarginTopNegative5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-n5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegativeHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegativeHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegativeHalf1String(responsiveSize));
            return className;
        }
        private static string MarginTopNegativeHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-nh1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegativeHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegativeHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegativeHalf2String(responsiveSize));
            return className;
        }
        private static string MarginTopNegativeHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-nh2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegativeHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegativeHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegativeHalf3String(responsiveSize));
            return className;
        }
        private static string MarginTopNegativeHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-nh3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegativeHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegativeHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegativeHalf4String(responsiveSize));
            return className;
        }
        private static string MarginTopNegativeHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-nh4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginTopNegativeHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginTopNegativeHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginTopNegativeHalf5String(responsiveSize));
            return className;
        }
        private static string MarginTopNegativeHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mt-nh5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveSize)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottom0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottom0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottom0String(responsiveSize));
            return className;
        }
        private static string MarginBottom0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-0"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottom1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottom1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottom1String(responsiveSize));
            return className;
        }
        private static string MarginBottom1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottom2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottom2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottom2String(responsiveSize));
            return className;
        }
        private static string MarginBottom2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottom3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottom3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottom3String(responsiveSize));
            return className;
        }
        private static string MarginBottom3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottom4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottom4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottom4String(responsiveSize));
            return className;
        }
        private static string MarginBottom4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottom5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottom5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottom5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottom5String(responsiveSize));
            return className;
        }
        private static string MarginBottom5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomAuto(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomAutoString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomAuto(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomAuto(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomAuto(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomAutoString(responsiveSize));
            return className;
        }
        private static string MarginBottomAutoString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-auto"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomHalf1String(responsiveSize));
            return className;
        }
        private static string MarginBottomHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-h1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomHalf2String(responsiveSize));
            return className;
        }
        private static string MarginBottomHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-h2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomHalf3String(responsiveSize));
            return className;
        }
        private static string MarginBottomHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-h3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomHalf4String(responsiveSize));
            return className;
        }
        private static string MarginBottomHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-h4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomHalf5String(responsiveSize));
            return className;
        }
        private static string MarginBottomHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-h5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegative1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegative1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegative1String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegative1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-n1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegative2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegative2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegative2String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegative2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-n2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegative3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegative3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegative3String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegative3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-n3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegative4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegative4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegative4String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegative4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-n4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegative5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegative5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegative5String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegative5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-n5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegativeHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegativeHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegativeHalf1String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegativeHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-nh1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegativeHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegativeHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegativeHalf2String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegativeHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-nh2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegativeHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegativeHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegativeHalf3String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegativeHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-nh3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegativeHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegativeHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegativeHalf4String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegativeHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-nh4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginBottomNegativeHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginBottomNegativeHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginBottomNegativeHalf5String(responsiveSize));
            return className;
        }
        private static string MarginBottomNegativeHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mb-nh5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveSize)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeft0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeft0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeft0String(responsiveSize));
            return className;
        }
        private static string MarginLeft0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-0"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeft1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeft1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeft1String(responsiveSize));
            return className;
        }
        private static string MarginLeft1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeft2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeft2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeft2String(responsiveSize));
            return className;
        }
        private static string MarginLeft2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeft3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeft3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeft3String(responsiveSize));
            return className;
        }
        private static string MarginLeft3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeft4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeft4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeft4String(responsiveSize));
            return className;
        }
        private static string MarginLeft4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeft5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeft5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeft5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeft5String(responsiveSize));
            return className;
        }
        private static string MarginLeft5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftAuto(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftAutoString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftAuto(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftAuto(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftAuto(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftAutoString(responsiveSize));
            return className;
        }
        private static string MarginLeftAutoString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-auto"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftHalf1String(responsiveSize));
            return className;
        }
        private static string MarginLeftHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-h1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftHalf2String(responsiveSize));
            return className;
        }
        private static string MarginLeftHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-h2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftHalf3String(responsiveSize));
            return className;
        }
        private static string MarginLeftHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-h3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftHalf4String(responsiveSize));
            return className;
        }
        private static string MarginLeftHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-h4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftHalf5String(responsiveSize));
            return className;
        }
        private static string MarginLeftHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-h5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegative1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegative1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegative1String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegative1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-n1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegative2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegative2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegative2String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegative2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-n2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegative3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegative3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegative3String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegative3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-n3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegative4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegative4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegative4String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegative4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-n4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegative5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegative5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegative5String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegative5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-n5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegativeHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegativeHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegativeHalf1String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegativeHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-nh1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegativeHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegativeHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegativeHalf2String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegativeHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-nh2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegativeHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegativeHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegativeHalf3String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegativeHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-nh3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegativeHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegativeHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegativeHalf4String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegativeHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-nh4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginLeftNegativeHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginLeftNegativeHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginLeftNegativeHalf5String(responsiveSize));
            return className;
        }
        private static string MarginLeftNegativeHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "ml-nh5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveSize)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginRight0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRight0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRight0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRight0String(responsiveSize));
            return className;
        }
        private static string MarginRight0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-0"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginRight1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRight1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRight1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRight1String(responsiveSize));
            return className;
        }
        private static string MarginRight1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginRight2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRight2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRight2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRight2String(responsiveSize));
            return className;
        }
        private static string MarginRight2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginRight3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRight3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRight3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRight3String(responsiveSize));
            return className;
        }
        private static string MarginRight3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginRight4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRight4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRight4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRight4String(responsiveSize));
            return className;
        }
        private static string MarginRight4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginRight5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRight5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRight5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRight5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRight5String(responsiveSize));
            return className;
        }
        private static string MarginRight5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginRightAuto(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightAutoString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightAuto(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightAuto(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightAuto(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightAutoString(responsiveSize));
            return className;
        }
        private static string MarginRightAutoString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-auto"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightHalf1String(responsiveSize));
            return className;
        }
        private static string MarginRightHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-h1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightHalf2String(responsiveSize));
            return className;
        }
        private static string MarginRightHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-h2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightHalf3String(responsiveSize));
            return className;
        }
        private static string MarginRightHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-h3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightHalf4String(responsiveSize));
            return className;
        }
        private static string MarginRightHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-h4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightHalf5String(responsiveSize));
            return className;
        }
        private static string MarginRightHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-h5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegative1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegative1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegative1String(responsiveSize));
            return className;
        }
        private static string MarginRightNegative1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-n1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegative2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegative2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegative2String(responsiveSize));
            return className;
        }
        private static string MarginRightNegative2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-n2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegative3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegative3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegative3String(responsiveSize));
            return className;
        }
        private static string MarginRightNegative3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-n3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegative4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegative4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegative4String(responsiveSize));
            return className;
        }
        private static string MarginRightNegative4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-n4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegative5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegative5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegative5String(responsiveSize));
            return className;
        }
        private static string MarginRightNegative5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-n5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegativeHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegativeHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegativeHalf1String(responsiveSize));
            return className;
        }
        private static string MarginRightNegativeHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-nh1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegativeHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegativeHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegativeHalf2String(responsiveSize));
            return className;
        }
        private static string MarginRightNegativeHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-nh2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegativeHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegativeHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegativeHalf3String(responsiveSize));
            return className;
        }
        private static string MarginRightNegativeHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-nh3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegativeHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegativeHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegativeHalf4String(responsiveSize));
            return className;
        }
        private static string MarginRightNegativeHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-nh4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => MarginRightNegativeHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).MarginRightNegativeHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(MarginRightNegativeHalf5String(responsiveSize));
            return className;
        }
        private static string MarginRightNegativeHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "mr-nh5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveSize)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTop0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTop0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTop0String(responsiveSize));
            return className;
        }
        private static string PaddingTop0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-0"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTop1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTop1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTop1String(responsiveSize));
            return className;
        }
        private static string PaddingTop1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-1"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTop2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTop2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTop2String(responsiveSize));
            return className;
        }
        private static string PaddingTop2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-2"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTop3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTop3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTop3String(responsiveSize));
            return className;
        }
        private static string PaddingTop3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-3"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTop4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTop4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTop4String(responsiveSize));
            return className;
        }
        private static string PaddingTop4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-4"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTop5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTop5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTop5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTop5String(responsiveSize));
            return className;
        }
        private static string PaddingTop5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-5"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTopHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTopHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTopHalf1String(responsiveSize));
            return className;
        }
        private static string PaddingTopHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-h1"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTopHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTopHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTopHalf2String(responsiveSize));
            return className;
        }
        private static string PaddingTopHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-h2"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTopHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTopHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTopHalf3String(responsiveSize));
            return className;
        }
        private static string PaddingTopHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-h3"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTopHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTopHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTopHalf4String(responsiveSize));
            return className;
        }
        private static string PaddingTopHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-h4"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingTopHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingTopHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingTopHalf5String(responsiveSize));
            return className;
        }
        private static string PaddingTopHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pt-h5"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottom0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottom0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottom0String(responsiveSize));
            return className;
        }
        private static string PaddingBottom0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-0"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottom1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottom1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottom1String(responsiveSize));
            return className;
        }
        private static string PaddingBottom1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-1"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottom2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottom2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottom2String(responsiveSize));
            return className;
        }
        private static string PaddingBottom2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-2"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottom3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottom3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottom3String(responsiveSize));
            return className;
        }
        private static string PaddingBottom3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-3"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottom4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottom4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottom4String(responsiveSize));
            return className;
        }
        private static string PaddingBottom4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-4"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottom5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottom5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottom5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottom5String(responsiveSize));
            return className;
        }
        private static string PaddingBottom5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-5"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottomHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottomHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottomHalf1String(responsiveSize));
            return className;
        }
        private static string PaddingBottomHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-h1"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottomHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottomHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottomHalf2String(responsiveSize));
            return className;
        }
        private static string PaddingBottomHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-h2"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottomHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottomHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottomHalf3String(responsiveSize));
            return className;
        }
        private static string PaddingBottomHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-h3"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottomHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottomHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottomHalf4String(responsiveSize));
            return className;
        }
        private static string PaddingBottomHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-h4"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingBottomHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingBottomHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingBottomHalf5String(responsiveSize));
            return className;
        }
        private static string PaddingBottomHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pb-h5"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeft0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeft0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeft0String(responsiveSize));
            return className;
        }
        private static string PaddingLeft0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-0"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeft1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeft1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeft1String(responsiveSize));
            return className;
        }
        private static string PaddingLeft1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-1"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeft2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeft2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeft2String(responsiveSize));
            return className;
        }
        private static string PaddingLeft2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-2"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeft3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeft3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeft3String(responsiveSize));
            return className;
        }
        private static string PaddingLeft3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-3"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeft4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeft4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeft4String(responsiveSize));
            return className;
        }
        private static string PaddingLeft4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-4"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeft5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeft5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeft5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeft5String(responsiveSize));
            return className;
        }
        private static string PaddingLeft5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-5"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeftHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeftHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeftHalf1String(responsiveSize));
            return className;
        }
        private static string PaddingLeftHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-h1"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeftHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeftHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeftHalf2String(responsiveSize));
            return className;
        }
        private static string PaddingLeftHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-h2"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeftHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeftHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeftHalf3String(responsiveSize));
            return className;
        }
        private static string PaddingLeftHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-h3"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeftHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeftHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeftHalf4String(responsiveSize));
            return className;
        }
        private static string PaddingLeftHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-h4"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingLeftHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingLeftHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingLeftHalf5String(responsiveSize));
            return className;
        }
        private static string PaddingLeftHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pl-h5"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRight0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRight0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRight0String(responsiveSize));
            return className;
        }
        private static string PaddingRight0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-0"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRight1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRight1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRight1String(responsiveSize));
            return className;
        }
        private static string PaddingRight1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-1"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRight2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRight2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRight2String(responsiveSize));
            return className;
        }
        private static string PaddingRight2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-2"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRight3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRight3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRight3String(responsiveSize));
            return className;
        }
        private static string PaddingRight3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-3"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRight4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRight4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRight4String(responsiveSize));
            return className;
        }
        private static string PaddingRight4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-4"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRight5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRight5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRight5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRight5String(responsiveSize));
            return className;
        }
        private static string PaddingRight5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-5"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRightHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRightHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRightHalf1String(responsiveSize));
            return className;
        }
        private static string PaddingRightHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-h1"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRightHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRightHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRightHalf2String(responsiveSize));
            return className;
        }
        private static string PaddingRightHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-h2"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRightHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRightHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRightHalf3String(responsiveSize));
            return className;
        }
        private static string PaddingRightHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-h3"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRightHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRightHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRightHalf4String(responsiveSize));
            return className;
        }
        private static string PaddingRightHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-h4"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingRightHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingRightHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingRightHalf5String(responsiveSize));
            return className;
        }
        private static string PaddingRightHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "pr-h5"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";
        
        [RequiresManagedContext]
        public static ClassName Padding0(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => Padding0String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding0(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Padding0(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding0(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(Padding0String(responsiveSize));
            return className;
        }
        private static string Padding0String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-0"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-0";
        
        [RequiresManagedContext]
        public static ClassName Padding1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => Padding1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Padding1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(Padding1String(responsiveSize));
            return className;
        }
        private static string Padding1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-1"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-1";
        
        [RequiresManagedContext]
        public static ClassName Padding2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => Padding2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Padding2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(Padding2String(responsiveSize));
            return className;
        }
        private static string Padding2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-2"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-2";
        
        [RequiresManagedContext]
        public static ClassName Padding3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => Padding3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Padding3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(Padding3String(responsiveSize));
            return className;
        }
        private static string Padding3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-3"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-3";
        
        [RequiresManagedContext]
        public static ClassName Padding4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => Padding4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Padding4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(Padding4String(responsiveSize));
            return className;
        }
        private static string Padding4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-4"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-4";
        
        [RequiresManagedContext]
        public static ClassName Padding5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => Padding5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Padding5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Padding5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(Padding5String(responsiveSize));
            return className;
        }
        private static string Padding5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-5"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf1(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingHalf1String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf1(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingHalf1(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf1(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingHalf1String(responsiveSize));
            return className;
        }
        private static string PaddingHalf1String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-h1"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf2(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingHalf2String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf2(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingHalf2(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf2(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingHalf2String(responsiveSize));
            return className;
        }
        private static string PaddingHalf2String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-h2"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf3(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingHalf3String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf3(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingHalf3(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf3(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingHalf3String(responsiveSize));
            return className;
        }
        private static string PaddingHalf3String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-h3"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf4(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingHalf4String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf4(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingHalf4(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf4(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingHalf4String(responsiveSize));
            return className;
        }
        private static string PaddingHalf4String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-h4"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf5(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => PaddingHalf5String(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf5(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).PaddingHalf5(responsiveSize);
        [RequiresManagedContext]
        public static ClassName PaddingHalf5(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(PaddingHalf5String(responsiveSize));
            return className;
        }
        private static string PaddingHalf5String(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "p-h5"
            : $"p-{GetResponsiveSizeUSSCode(responsiveSize)}-h5";

        [RequiresManagedContext]
        public static ClassName TextLeft(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextLeftString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLeft(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextLeft(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLeft(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextLeftString(responsiveSize));
            return className;
        }
        private static string TextLeftString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-left";
        
        [RequiresManagedContext]
        public static ClassName TextRight(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextRightString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextRight(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextRight(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextRight(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextRightString(responsiveSize));
            return className;
        }
        private static string TextRightString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-right";
        
        [RequiresManagedContext]
        public static ClassName TextCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextCenterString(responsiveSize));
            return className;
        }
        private static string TextCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-center";
        
        [RequiresManagedContext]
        public static ClassName TextUpperLeft(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextUpperLeftString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextUpperLeft(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextUpperLeft(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextUpperLeft(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextUpperLeftString(responsiveSize));
            return className;
        }
        private static string TextUpperLeftString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-upper-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-upper-left";
        
        [RequiresManagedContext]
        public static ClassName TextUpperRight(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextUpperRightString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextUpperRight(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextUpperRight(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextUpperRight(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextUpperRightString(responsiveSize));
            return className;
        }
        private static string TextUpperRightString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-upper-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-upper-right";
        
        [RequiresManagedContext]
        public static ClassName TextUpperCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextUpperCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextUpperCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextUpperCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextUpperCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextUpperCenterString(responsiveSize));
            return className;
        }
        private static string TextUpperCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-upper-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-upper-center";
        
        [RequiresManagedContext]
        public static ClassName TextMiddleLeft(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextMiddleLeftString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextMiddleLeft(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextMiddleLeft(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextMiddleLeft(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextMiddleLeftString(responsiveSize));
            return className;
        }
        private static string TextMiddleLeftString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-middle-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-middle-left";
        
        [RequiresManagedContext]
        public static ClassName TextMiddleRight(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextMiddleRightString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextMiddleRight(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextMiddleRight(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextMiddleRight(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextMiddleRightString(responsiveSize));
            return className;
        }
        private static string TextMiddleRightString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-middle-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-middle-right";
        
        [RequiresManagedContext]
        public static ClassName TextMiddleCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextMiddleCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextMiddleCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextMiddleCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextMiddleCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextMiddleCenterString(responsiveSize));
            return className;
        }
        private static string TextMiddleCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-middle-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-middle-center";
        
        [RequiresManagedContext]
        public static ClassName TextLowerLeft(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextLowerLeftString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLowerLeft(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextLowerLeft(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLowerLeft(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextLowerLeftString(responsiveSize));
            return className;
        }
        private static string TextLowerLeftString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-lower-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-lower-left";
        
        [RequiresManagedContext]
        public static ClassName TextLowerRight(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextLowerRightString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLowerRight(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextLowerRight(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLowerRight(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextLowerRightString(responsiveSize));
            return className;
        }
        private static string TextLowerRightString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-lower-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-lower-right";
        
        [RequiresManagedContext]
        public static ClassName TextLowerCenter(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => TextLowerCenterString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLowerCenter(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).TextLowerCenter(responsiveSize);
        [RequiresManagedContext]
        public static ClassName TextLowerCenter(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(TextLowerCenterString(responsiveSize));
            return className;
        }
        private static string TextLowerCenterString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "text-lower-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveSize)}-lower-center";
        
        [RequiresManagedContext]
        public static ClassName Visible(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => VisibleString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Visible(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Visible(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Visible(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(VisibleString(responsiveSize));
            return className;
        }
        private static string VisibleString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "visible"
            : $"visible-{GetResponsiveSizeUSSCode(responsiveSize)}";
        
        [RequiresManagedContext]
        public static ClassName Invisible(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => InvisibleString(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Invisible(this string className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => ((ClassName)className).Invisible(responsiveSize);
        [RequiresManagedContext]
        public static ClassName Invisible(this ClassName className, ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall)
        {
            className.Add(InvisibleString(responsiveSize));
            return className;
        }
        private static string InvisibleString(ResponsiveContext.Size responsiveSize = ResponsiveContext.Size.XSmall) => responsiveSize is ResponsiveContext.Size.XSmall
            ? "invisible"
            : $"invisible-{GetResponsiveSizeUSSCode(responsiveSize)}";
        
        [RequiresManagedContext]
        public static ClassName AbsoluteFill() => AbsoluteFillString;
        [RequiresManagedContext]
        public static ClassName AbsoluteFill(this string className) => ((ClassName)className).AbsoluteFill();
        [RequiresManagedContext]
        public static ClassName AbsoluteFill(this ClassName className)
        {
            className.Add(AbsoluteFillString);
            return className;
        }
        private const string AbsoluteFillString = "absolute-fill";
        
        [RequiresManagedContext]
        public static ClassName Opacity0() => Opacity0String;
        [RequiresManagedContext]
        public static ClassName Opacity0(this string className) => ((ClassName)className).Opacity0();
        [RequiresManagedContext]
        public static ClassName Opacity0(this ClassName className)
        {
            className.Add(Opacity0String);
            return className;
        }
        private const string Opacity0String = "opacity-0";
        
        [RequiresManagedContext]
        public static ClassName Opacity25() => Opacity25String;
        [RequiresManagedContext]
        public static ClassName Opacity25(this string className) => ((ClassName)className).Opacity25();
        [RequiresManagedContext]
        public static ClassName Opacity25(this ClassName className)
        {
            className.Add(Opacity25String);
            return className;
        }
        private const string Opacity25String = "opacity-25";
        
        [RequiresManagedContext]
        public static ClassName Opacity50() => Opacity50String;
        [RequiresManagedContext]
        public static ClassName Opacity50(this string className) => ((ClassName)className).Opacity50();
        [RequiresManagedContext]
        public static ClassName Opacity50(this ClassName className)
        {
            className.Add(Opacity50String);
            return className;
        }
        private const string Opacity50String = "opacity-50";
        
        [RequiresManagedContext]
        public static ClassName Opacity75() => Opacity75String;
        [RequiresManagedContext]
        public static ClassName Opacity75(this string className) => ((ClassName)className).Opacity75();
        [RequiresManagedContext]
        public static ClassName Opacity75(this ClassName className)
        {
            className.Add(Opacity75String);
            return className;
        }
        private const string Opacity75String = "opacity-75";
        
        [RequiresManagedContext]
        public static ClassName Opacity100() => Opacity100String;
        [RequiresManagedContext]
        public static ClassName Opacity100(this string className) => ((ClassName)className).Opacity100();
        [RequiresManagedContext]
        public static ClassName Opacity100(this ClassName className)
        {
            className.Add(Opacity100String);
            return className;
        }
        private const string Opacity100String = "opacity-100";
        
        [RequiresManagedContext]
        public static ClassName OverflowHidden() => OverflowHiddenString;
        [RequiresManagedContext]
        public static ClassName OverflowHidden(this string className) => ((ClassName)className).OverflowHidden();
        [RequiresManagedContext]
        public static ClassName OverflowHidden(this ClassName className)
        {
            className.Add(OverflowHiddenString);
            return className;
        }
        private const string OverflowHiddenString = "overflow-hidden";
        
        [RequiresManagedContext]
        public static ClassName OverflowVisible() => OverflowVisibleString;
        [RequiresManagedContext]
        public static ClassName OverflowVisible(this string className) => ((ClassName)className).OverflowVisible();
        [RequiresManagedContext]
        public static ClassName OverflowVisible(this ClassName className)
        {
            className.Add(OverflowVisibleString);
            return className;
        }
        private const string OverflowVisibleString = "overflow-visible";
        
        [RequiresManagedContext]
        public static ClassName PositionRelative() => PositionRelativeString;
        [RequiresManagedContext]
        public static ClassName PositionRelative(this string className) => ((ClassName)className).PositionRelative();
        [RequiresManagedContext]
        public static ClassName PositionRelative(this ClassName className)
        {
            className.Add(PositionRelativeString);
            return className;
        }
        private const string PositionRelativeString = "position-relative";
        
        [RequiresManagedContext]
        public static ClassName PositionAbsolute() => PositionAbsoluteString;
        [RequiresManagedContext]
        public static ClassName PositionAbsolute(this string className) => ((ClassName)className).PositionAbsolute();
        [RequiresManagedContext]
        public static ClassName PositionAbsolute(this ClassName className)
        {
            className.Add(PositionAbsoluteString);
            return className;
        }
        private const string PositionAbsoluteString = "position-absolute";
        
        [RequiresManagedContext]
        public static ClassName Top0() => Top0String;
        [RequiresManagedContext]
        public static ClassName Top0(this string className) => ((ClassName)className).Top0();
        [RequiresManagedContext]
        public static ClassName Top0(this ClassName className)
        {
            className.Add(Top0String);
            return className;
        }
        private const string Top0String = "top-0";
        
        [RequiresManagedContext]
        public static ClassName Top50() => Top50String;
        [RequiresManagedContext]
        public static ClassName Top50(this string className) => ((ClassName)className).Top50();
        [RequiresManagedContext]
        public static ClassName Top50(this ClassName className)
        {
            className.Add(Top50String);
            return className;
        }
        private const string Top50String = "top-50";
        
        [RequiresManagedContext]
        public static ClassName Top100() => Top100String;
        [RequiresManagedContext]
        public static ClassName Top100(this string className) => ((ClassName)className).Top100();
        [RequiresManagedContext]
        public static ClassName Top100(this ClassName className)
        {
            className.Add(Top100String);
            return className;
        }
        private const string Top100String = "top-100";
        
        [RequiresManagedContext]
        public static ClassName Bottom0() => Bottom0String;
        [RequiresManagedContext]
        public static ClassName Bottom0(this string className) => ((ClassName)className).Bottom0();
        [RequiresManagedContext]
        public static ClassName Bottom0(this ClassName className)
        {
            className.Add(Bottom0String);
            return className;
        }
        private const string Bottom0String = "bottom-0";
        
        [RequiresManagedContext]
        public static ClassName Bottom50() => Bottom50String;
        [RequiresManagedContext]
        public static ClassName Bottom50(this string className) => ((ClassName)className).Bottom50();
        [RequiresManagedContext]
        public static ClassName Bottom50(this ClassName className)
        {
            className.Add(Bottom50String);
            return className;
        }
        private const string Bottom50String = "bottom-50";
        
        [RequiresManagedContext]
        public static ClassName Bottom100() => Bottom100String;
        [RequiresManagedContext]
        public static ClassName Bottom100(this string className) => ((ClassName)className).Bottom100();
        [RequiresManagedContext]
        public static ClassName Bottom100(this ClassName className)
        {
            className.Add(Bottom100String);
            return className;
        }
        private const string Bottom100String = "bottom-100";
        
        [RequiresManagedContext]
        public static ClassName Left0() => Left0String;
        [RequiresManagedContext]
        public static ClassName Left0(this string className) => ((ClassName)className).Left0();
        [RequiresManagedContext]
        public static ClassName Left0(this ClassName className)
        {
            className.Add(Left0String);
            return className;
        }
        private const string Left0String = "left-0";
        
        [RequiresManagedContext]
        public static ClassName Left50() => Left50String;
        [RequiresManagedContext]
        public static ClassName Left50(this string className) => ((ClassName)className).Left50();
        [RequiresManagedContext]
        public static ClassName Left50(this ClassName className)
        {
            className.Add(Left50String);
            return className;
        }
        private const string Left50String = "left-50";
        
        [RequiresManagedContext]
        public static ClassName Left100() => Left100String;
        [RequiresManagedContext]
        public static ClassName Left100(this string className) => ((ClassName)className).Left100();
        [RequiresManagedContext]
        public static ClassName Left100(this ClassName className)
        {
            className.Add(Left100String);
            return className;
        }
        private const string Left100String = "left-100";
        
        [RequiresManagedContext]
        public static ClassName Right0() => Right0String;
        [RequiresManagedContext]
        public static ClassName Right0(this string className) => ((ClassName)className).Right0();
        [RequiresManagedContext]
        public static ClassName Right0(this ClassName className)
        {
            className.Add(Right0String);
            return className;
        }
        private const string Right0String = "right-0";
        
        [RequiresManagedContext]
        public static ClassName Right50() => Right50String;
        [RequiresManagedContext]
        public static ClassName Right50(this string className) => ((ClassName)className).Right50();
        [RequiresManagedContext]
        public static ClassName Right50(this ClassName className)
        {
            className.Add(Right50String);
            return className;
        }
        private const string Right50String = "right-50";
        
        [RequiresManagedContext]
        public static ClassName Right100() => Right100String;
        [RequiresManagedContext]
        public static ClassName Right100(this string className) => ((ClassName)className).Right100();
        [RequiresManagedContext]
        public static ClassName Right100(this ClassName className)
        {
            className.Add(Right100String);
            return className;
        }
        private const string Right100String = "right-100";
        
        [RequiresManagedContext]
        public static ClassName TranslateMiddle() => TranslateMiddleString;
        [RequiresManagedContext]
        public static ClassName TranslateMiddle(this string className) => ((ClassName)className).TranslateMiddle();
        [RequiresManagedContext]
        public static ClassName TranslateMiddle(this ClassName className)
        {
            className.Add(TranslateMiddleString);
            return className;
        }
        private const string TranslateMiddleString = "translate-middle";
        
        [RequiresManagedContext]
        public static ClassName TranslateX() => TranslateXString;
        [RequiresManagedContext]
        public static ClassName TranslateX(this string className) => ((ClassName)className).TranslateX();
        [RequiresManagedContext]
        public static ClassName TranslateX(this ClassName className)
        {
            className.Add(TranslateXString);
            return className;
        }
        private const string TranslateXString = "translate-x";
        
        [RequiresManagedContext]
        public static ClassName TranslateY() => TranslateYString;
        [RequiresManagedContext]
        public static ClassName TranslateY(this string className) => ((ClassName)className).TranslateY();
        [RequiresManagedContext]
        public static ClassName TranslateY(this ClassName className)
        {
            className.Add(TranslateYString);
            return className;
        }
        private const string TranslateYString = "translate-y";
        
        [RequiresManagedContext]
        public static ClassName Width0() => Width0String;
        [RequiresManagedContext]
        public static ClassName Width0(this string className) => ((ClassName)className).Width0();
        [RequiresManagedContext]
        public static ClassName Width0(this ClassName className)
        {
            className.Add(Width0String);
            return className;
        }
        private const string Width0String = "w-0";
        
        [RequiresManagedContext]
        public static ClassName Width25() => Width25String;
        [RequiresManagedContext]
        public static ClassName Width25(this string className) => ((ClassName)className).Width25();
        [RequiresManagedContext]
        public static ClassName Width25(this ClassName className)
        {
            className.Add(Width25String);
            return className;
        }
        private const string Width25String = "w-25";
        
        [RequiresManagedContext]
        public static ClassName Width50() => Width50String;
        [RequiresManagedContext]
        public static ClassName Width50(this string className) => ((ClassName)className).Width50();
        [RequiresManagedContext]
        public static ClassName Width50(this ClassName className)
        {
            className.Add(Width50String);
            return className;
        }
        private const string Width50String = "w-50";
        
        [RequiresManagedContext]
        public static ClassName Width75() => Width75String;
        [RequiresManagedContext]
        public static ClassName Width75(this string className) => ((ClassName)className).Width75();
        [RequiresManagedContext]
        public static ClassName Width75(this ClassName className)
        {
            className.Add(Width75String);
            return className;
        }
        private const string Width75String = "w-75";
        
        [RequiresManagedContext]
        public static ClassName Width100() => Width100String;
        [RequiresManagedContext]
        public static ClassName Width100(this string className) => ((ClassName)className).Width100();
        [RequiresManagedContext]
        public static ClassName Width100(this ClassName className)
        {
            className.Add(Width100String);
            return className;
        }
        private const string Width100String = "w-100";
        
        [RequiresManagedContext]
        public static ClassName WidthAuto() => WidthAutoString;
        [RequiresManagedContext]
        public static ClassName WidthAuto(this string className) => ((ClassName)className).WidthAuto();
        [RequiresManagedContext]
        public static ClassName WidthAuto(this ClassName className)
        {
            className.Add(WidthAutoString);
            return className;
        }
        private const string WidthAutoString = "w-auto";
        
        [RequiresManagedContext]
        public static ClassName MaxWidth100() => MaxWidth100String;
        [RequiresManagedContext]
        public static ClassName MaxWidth100(this string className) => ((ClassName)className).MaxWidth100();
        [RequiresManagedContext]
        public static ClassName MaxWidth100(this ClassName className)
        {
            className.Add(MaxWidth100String);
            return className;
        }
        private const string MaxWidth100String = "mw-100";
        
        [RequiresManagedContext]
        public static ClassName Height0() => Height0String;
        [RequiresManagedContext]
        public static ClassName Height0(this string className) => ((ClassName)className).Height0();
        [RequiresManagedContext]
        public static ClassName Height0(this ClassName className)
        {
            className.Add(Height0String);
            return className;
        }
        private const string Height0String = "w-0";
        
        [RequiresManagedContext]
        public static ClassName Height25() => Height25String;
        [RequiresManagedContext]
        public static ClassName Height25(this string className) => ((ClassName)className).Height25();
        [RequiresManagedContext]
        public static ClassName Height25(this ClassName className)
        {
            className.Add(Height25String);
            return className;
        }
        private const string Height25String = "w-25";
        
        [RequiresManagedContext]
        public static ClassName Height50() => Height50String;
        [RequiresManagedContext]
        public static ClassName Height50(this string className) => ((ClassName)className).Height50();
        [RequiresManagedContext]
        public static ClassName Height50(this ClassName className)
        {
            className.Add(Height50String);
            return className;
        }
        private const string Height50String = "w-50";
        
        [RequiresManagedContext]
        public static ClassName Height75() => Height75String;
        [RequiresManagedContext]
        public static ClassName Height75(this string className) => ((ClassName)className).Height75();
        [RequiresManagedContext]
        public static ClassName Height75(this ClassName className)
        {
            className.Add(Height75String);
            return className;
        }
        private const string Height75String = "w-75";
        
        [RequiresManagedContext]
        public static ClassName Height100() => Height100String;
        [RequiresManagedContext]
        public static ClassName Height100(this string className) => ((ClassName)className).Height100();
        [RequiresManagedContext]
        public static ClassName Height100(this ClassName className)
        {
            className.Add(Height100String);
            return className;
        }
        private const string Height100String = "w-100";
        
        [RequiresManagedContext]
        public static ClassName HeightAuto() => HeightAutoString;
        [RequiresManagedContext]
        public static ClassName HeightAuto(this string className) => ((ClassName)className).HeightAuto();
        [RequiresManagedContext]
        public static ClassName HeightAuto(this ClassName className)
        {
            className.Add(HeightAutoString);
            return className;
        }
        private const string HeightAutoString = "w-auto";
        
        [RequiresManagedContext]
        public static ClassName MaxHeight100() => MaxHeight100String;
        [RequiresManagedContext]
        public static ClassName MaxHeight100(this string className) => ((ClassName)className).MaxHeight100();
        [RequiresManagedContext]
        public static ClassName MaxHeight100(this ClassName className)
        {
            className.Add(MaxHeight100String);
            return className;
        }
        private const string MaxHeight100String = "mw-100";
        
        [RequiresManagedContext]
        public static ClassName BackgroundPrimary() => BackgroundPrimaryString;
        [RequiresManagedContext]
        public static ClassName BackgroundPrimary(this string className) => ((ClassName)className).BackgroundPrimary();
        [RequiresManagedContext]
        public static ClassName BackgroundPrimary(this ClassName className)
        {
            className.Add(BackgroundPrimaryString);
            return className;
        }
        private const string BackgroundPrimaryString = "bg-primary";
        
        [RequiresManagedContext]
        public static ClassName BackgroundPrimarySubtle() => BackgroundPrimarySubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundPrimarySubtle(this string className) => ((ClassName)className).BackgroundPrimarySubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundPrimarySubtle(this ClassName className)
        {
            className.Add(BackgroundPrimarySubtleString);
            return className;
        }
        private const string BackgroundPrimarySubtleString = "bg-primary-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundSecondary() => BackgroundSecondaryString;
        [RequiresManagedContext]
        public static ClassName BackgroundSecondary(this string className) => ((ClassName)className).BackgroundSecondary();
        [RequiresManagedContext]
        public static ClassName BackgroundSecondary(this ClassName className)
        {
            className.Add(BackgroundSecondaryString);
            return className;
        }
        private const string BackgroundSecondaryString = "bg-secondary";
        
        [RequiresManagedContext]
        public static ClassName BackgroundSecondarySubtle() => BackgroundSecondarySubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundSecondarySubtle(this string className) => ((ClassName)className).BackgroundSecondarySubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundSecondarySubtle(this ClassName className)
        {
            className.Add(BackgroundSecondarySubtleString);
            return className;
        }
        private const string BackgroundSecondarySubtleString = "bg-secondary-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundSuccess() => BackgroundSuccessString;
        [RequiresManagedContext]
        public static ClassName BackgroundSuccess(this string className) => ((ClassName)className).BackgroundSuccess();
        [RequiresManagedContext]
        public static ClassName BackgroundSuccess(this ClassName className)
        {
            className.Add(BackgroundSuccessString);
            return className;
        }
        private const string BackgroundSuccessString = "bg-success";
        
        [RequiresManagedContext]
        public static ClassName BackgroundSuccessSubtle() => BackgroundSuccessSubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundSuccessSubtle(this string className) => ((ClassName)className).BackgroundSuccessSubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundSuccessSubtle(this ClassName className)
        {
            className.Add(BackgroundSuccessSubtleString);
            return className;
        }
        private const string BackgroundSuccessSubtleString = "bg-success-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundDanger() => BackgroundDangerString;
        [RequiresManagedContext]
        public static ClassName BackgroundDanger(this string className) => ((ClassName)className).BackgroundDanger();
        [RequiresManagedContext]
        public static ClassName BackgroundDanger(this ClassName className)
        {
            className.Add(BackgroundDangerString);
            return className;
        }
        private const string BackgroundDangerString = "bg-danger";
        
        [RequiresManagedContext]
        public static ClassName BackgroundDangerSubtle() => BackgroundDangerSubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundDangerSubtle(this string className) => ((ClassName)className).BackgroundDangerSubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundDangerSubtle(this ClassName className)
        {
            className.Add(BackgroundDangerSubtleString);
            return className;
        }
        private const string BackgroundDangerSubtleString = "bg-danger-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundWarning() => BackgroundWarningString;
        [RequiresManagedContext]
        public static ClassName BackgroundWarning(this string className) => ((ClassName)className).BackgroundWarning();
        [RequiresManagedContext]
        public static ClassName BackgroundWarning(this ClassName className)
        {
            className.Add(BackgroundWarningString);
            return className;
        }
        private const string BackgroundWarningString = "bg-warning";
        
        [RequiresManagedContext]
        public static ClassName BackgroundWarningSubtle() => BackgroundWarningSubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundWarningSubtle(this string className) => ((ClassName)className).BackgroundWarningSubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundWarningSubtle(this ClassName className)
        {
            className.Add(BackgroundWarningSubtleString);
            return className;
        }
        private const string BackgroundWarningSubtleString = "bg-warning-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundInfo() => BackgroundInfoString;
        [RequiresManagedContext]
        public static ClassName BackgroundInfo(this string className) => ((ClassName)className).BackgroundInfo();
        [RequiresManagedContext]
        public static ClassName BackgroundInfo(this ClassName className)
        {
            className.Add(BackgroundInfoString);
            return className;
        }
        private const string BackgroundInfoString = "bg-info";
        
        [RequiresManagedContext]
        public static ClassName BackgroundInfoSubtle() => BackgroundInfoSubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundInfoSubtle(this string className) => ((ClassName)className).BackgroundInfoSubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundInfoSubtle(this ClassName className)
        {
            className.Add(BackgroundInfoSubtleString);
            return className;
        }
        private const string BackgroundInfoSubtleString = "bg-info-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundLight() => BackgroundLightString;
        [RequiresManagedContext]
        public static ClassName BackgroundLight(this string className) => ((ClassName)className).BackgroundLight();
        [RequiresManagedContext]
        public static ClassName BackgroundLight(this ClassName className)
        {
            className.Add(BackgroundLightString);
            return className;
        }
        private const string BackgroundLightString = "bg-light";
        
        [RequiresManagedContext]
        public static ClassName BackgroundLightSubtle() => BackgroundLightSubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundLightSubtle(this string className) => ((ClassName)className).BackgroundLightSubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundLightSubtle(this ClassName className)
        {
            className.Add(BackgroundLightSubtleString);
            return className;
        }
        private const string BackgroundLightSubtleString = "bg-light-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundDark() => BackgroundDarkString;
        [RequiresManagedContext]
        public static ClassName BackgroundDark(this string className) => ((ClassName)className).BackgroundDark();
        [RequiresManagedContext]
        public static ClassName BackgroundDark(this ClassName className)
        {
            className.Add(BackgroundDarkString);
            return className;
        }
        private const string BackgroundDarkString = "bg-dark";
        
        [RequiresManagedContext]
        public static ClassName BackgroundDarkSubtle() => BackgroundDarkSubtleString;
        [RequiresManagedContext]
        public static ClassName BackgroundDarkSubtle(this string className) => ((ClassName)className).BackgroundDarkSubtle();
        [RequiresManagedContext]
        public static ClassName BackgroundDarkSubtle(this ClassName className)
        {
            className.Add(BackgroundDarkSubtleString);
            return className;
        }
        private const string BackgroundDarkSubtleString = "bg-dark-subtle";
        
        [RequiresManagedContext]
        public static ClassName BackgroundBody() => BackgroundBodyString;
        [RequiresManagedContext]
        public static ClassName BackgroundBody(this string className) => ((ClassName)className).BackgroundBody();
        [RequiresManagedContext]
        public static ClassName BackgroundBody(this ClassName className)
        {
            className.Add(BackgroundBodyString);
            return className;
        }
        private const string BackgroundBodyString = "bg-body";
        
        [RequiresManagedContext]
        public static ClassName BackgroundBodySecondary() => BackgroundBodySecondaryString;
        [RequiresManagedContext]
        public static ClassName BackgroundBodySecondary(this string className) => ((ClassName)className).BackgroundBodySecondary();
        [RequiresManagedContext]
        public static ClassName BackgroundBodySecondary(this ClassName className)
        {
            className.Add(BackgroundBodySecondaryString);
            return className;
        }
        private const string BackgroundBodySecondaryString = "bg-body-secondary";
        
        [RequiresManagedContext]
        public static ClassName BackgroundBodyTertiary() => BackgroundBodyTertiaryString;
        [RequiresManagedContext]
        public static ClassName BackgroundBodyTertiary(this string className) => ((ClassName)className).BackgroundBodyTertiary();
        [RequiresManagedContext]
        public static ClassName BackgroundBodyTertiary(this ClassName className)
        {
            className.Add(BackgroundBodyTertiaryString);
            return className;
        }
        private const string BackgroundBodyTertiaryString = "bg-body-tertiary";
        
        [RequiresManagedContext]
        public static ClassName BackgroundBlack() => BackgroundBlackString;
        [RequiresManagedContext]
        public static ClassName BackgroundBlack(this string className) => ((ClassName)className).BackgroundBlack();
        [RequiresManagedContext]
        public static ClassName BackgroundBlack(this ClassName className)
        {
            className.Add(BackgroundBlackString);
            return className;
        }
        private const string BackgroundBlackString = "bg-black";
        
        [RequiresManagedContext]
        public static ClassName BackgroundWhite() => BackgroundWhiteString;
        [RequiresManagedContext]
        public static ClassName BackgroundWhite(this string className) => ((ClassName)className).BackgroundWhite();
        [RequiresManagedContext]
        public static ClassName BackgroundWhite(this ClassName className)
        {
            className.Add(BackgroundWhiteString);
            return className;
        }
        private const string BackgroundWhiteString = "bg-white";
        
        [RequiresManagedContext]
        public static ClassName BackgroundTransparent() => BackgroundTransparentString;
        [RequiresManagedContext]
        public static ClassName BackgroundTransparent(this string className) => ((ClassName)className).BackgroundTransparent();
        [RequiresManagedContext]
        public static ClassName BackgroundTransparent(this ClassName className)
        {
            className.Add(BackgroundTransparentString);
            return className;
        }
        private const string BackgroundTransparentString = "bg-transparent";
        
        [RequiresManagedContext]
        public static ClassName Border() => BorderString;
        [RequiresManagedContext]
        public static ClassName Border(this string className) => ((ClassName)className).Border();
        [RequiresManagedContext]
        public static ClassName Border(this ClassName className)
        {
            className.Add(BorderString);
            return className;
        }
        private const string BorderString = "border";
        
        [RequiresManagedContext]
        public static ClassName BorderTop() => BorderTopString;
        [RequiresManagedContext]
        public static ClassName BorderTop(this string className) => ((ClassName)className).BorderTop();
        [RequiresManagedContext]
        public static ClassName BorderTop(this ClassName className)
        {
            className.Add(BorderTopString);
            return className;
        }
        private const string BorderTopString = "border-top";
        
        [RequiresManagedContext]
        public static ClassName BorderBottom() => BorderBottomString;
        [RequiresManagedContext]
        public static ClassName BorderBottom(this string className) => ((ClassName)className).BorderBottom();
        [RequiresManagedContext]
        public static ClassName BorderBottom(this ClassName className)
        {
            className.Add(BorderBottomString);
            return className;
        }
        private const string BorderBottomString = "border-bottom";
        
        [RequiresManagedContext]
        public static ClassName BorderLeft() => BorderLeftString;
        [RequiresManagedContext]
        public static ClassName BorderLeft(this string className) => ((ClassName)className).BorderLeft();
        [RequiresManagedContext]
        public static ClassName BorderLeft(this ClassName className)
        {
            className.Add(BorderLeftString);
            return className;
        }
        private const string BorderLeftString = "border-left";
        
        [RequiresManagedContext]
        public static ClassName BorderRight() => BorderRightString;
        [RequiresManagedContext]
        public static ClassName BorderRight(this string className) => ((ClassName)className).BorderRight();
        [RequiresManagedContext]
        public static ClassName BorderRight(this ClassName className)
        {
            className.Add(BorderRightString);
            return className;
        }
        private const string BorderRightString = "border-right";
        
        [RequiresManagedContext]
        public static ClassName BorderTop0() => BorderTop0String;
        [RequiresManagedContext]
        public static ClassName BorderTop0(this string className) => ((ClassName)className).BorderTop0();
        [RequiresManagedContext]
        public static ClassName BorderTop0(this ClassName className)
        {
            className.Add(BorderTop0String);
            return className;
        }
        private const string BorderTop0String = "border-top-0";
        
        [RequiresManagedContext]
        public static ClassName BorderBottom0() => BorderBottom0String;
        [RequiresManagedContext]
        public static ClassName BorderBottom0(this string className) => ((ClassName)className).BorderBottom0();
        [RequiresManagedContext]
        public static ClassName BorderBottom0(this ClassName className)
        {
            className.Add(BorderBottom0String);
            return className;
        }
        private const string BorderBottom0String = "border-bottom-0";
        
        [RequiresManagedContext]
        public static ClassName BorderLeft0() => BorderLeft0String;
        [RequiresManagedContext]
        public static ClassName BorderLeft0(this string className) => ((ClassName)className).BorderLeft0();
        [RequiresManagedContext]
        public static ClassName BorderLeft0(this ClassName className)
        {
            className.Add(BorderLeft0String);
            return className;
        }
        private const string BorderLeft0String = "border-left-0";
        
        [RequiresManagedContext]
        public static ClassName BorderRight0() => BorderRight0String;
        [RequiresManagedContext]
        public static ClassName BorderRight0(this string className) => ((ClassName)className).BorderRight0();
        [RequiresManagedContext]
        public static ClassName BorderRight0(this ClassName className)
        {
            className.Add(BorderRight0String);
            return className;
        }
        private const string BorderRight0String = "border-right-0";
        
        [RequiresManagedContext]
        public static ClassName BorderPrimary() => BorderPrimaryString;
        [RequiresManagedContext]
        public static ClassName BorderPrimary(this string className) => ((ClassName)className).BorderPrimary();
        [RequiresManagedContext]
        public static ClassName BorderPrimary(this ClassName className)
        {
            className.Add(BorderPrimaryString);
            return className;
        }
        private const string BorderPrimaryString = "border-primary";
        
        [RequiresManagedContext]
        public static ClassName BorderPrimarySubtle() => BorderPrimarySubtleString;
        [RequiresManagedContext]
        public static ClassName BorderPrimarySubtle(this string className) => ((ClassName)className).BorderPrimarySubtle();
        [RequiresManagedContext]
        public static ClassName BorderPrimarySubtle(this ClassName className)
        {
            className.Add(BorderPrimarySubtleString);
            return className;
        }
        private const string BorderPrimarySubtleString = "border-primary-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderSecondary() => BorderSecondaryString;
        [RequiresManagedContext]
        public static ClassName BorderSecondary(this string className) => ((ClassName)className).BorderSecondary();
        [RequiresManagedContext]
        public static ClassName BorderSecondary(this ClassName className)
        {
            className.Add(BorderSecondaryString);
            return className;
        }
        private const string BorderSecondaryString = "border-secondary";
        
        [RequiresManagedContext]
        public static ClassName BorderSecondarySubtle() => BorderSecondarySubtleString;
        [RequiresManagedContext]
        public static ClassName BorderSecondarySubtle(this string className) => ((ClassName)className).BorderSecondarySubtle();
        [RequiresManagedContext]
        public static ClassName BorderSecondarySubtle(this ClassName className)
        {
            className.Add(BorderSecondarySubtleString);
            return className;
        }
        private const string BorderSecondarySubtleString = "border-secondary-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderSuccess() => BorderSuccessString;
        [RequiresManagedContext]
        public static ClassName BorderSuccess(this string className) => ((ClassName)className).BorderSuccess();
        [RequiresManagedContext]
        public static ClassName BorderSuccess(this ClassName className)
        {
            className.Add(BorderSuccessString);
            return className;
        }
        private const string BorderSuccessString = "border-success";
        
        [RequiresManagedContext]
        public static ClassName BorderSuccessSubtle() => BorderSuccessSubtleString;
        [RequiresManagedContext]
        public static ClassName BorderSuccessSubtle(this string className) => ((ClassName)className).BorderSuccessSubtle();
        [RequiresManagedContext]
        public static ClassName BorderSuccessSubtle(this ClassName className)
        {
            className.Add(BorderSuccessSubtleString);
            return className;
        }
        private const string BorderSuccessSubtleString = "border-success-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderDanger() => BorderDangerString;
        [RequiresManagedContext]
        public static ClassName BorderDanger(this string className) => ((ClassName)className).BorderDanger();
        [RequiresManagedContext]
        public static ClassName BorderDanger(this ClassName className)
        {
            className.Add(BorderDangerString);
            return className;
        }
        private const string BorderDangerString = "border-danger";
        
        [RequiresManagedContext]
        public static ClassName BorderDangerSubtle() => BorderDangerSubtleString;
        [RequiresManagedContext]
        public static ClassName BorderDangerSubtle(this string className) => ((ClassName)className).BorderDangerSubtle();
        [RequiresManagedContext]
        public static ClassName BorderDangerSubtle(this ClassName className)
        {
            className.Add(BorderDangerSubtleString);
            return className;
        }
        private const string BorderDangerSubtleString = "border-danger-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderWarning() => BorderWarningString;
        [RequiresManagedContext]
        public static ClassName BorderWarning(this string className) => ((ClassName)className).BorderWarning();
        [RequiresManagedContext]
        public static ClassName BorderWarning(this ClassName className)
        {
            className.Add(BorderWarningString);
            return className;
        }
        private const string BorderWarningString = "border-warning";
        
        [RequiresManagedContext]
        public static ClassName BorderWarningSubtle() => BorderWarningSubtleString;
        [RequiresManagedContext]
        public static ClassName BorderWarningSubtle(this string className) => ((ClassName)className).BorderWarningSubtle();
        [RequiresManagedContext]
        public static ClassName BorderWarningSubtle(this ClassName className)
        {
            className.Add(BorderWarningSubtleString);
            return className;
        }
        private const string BorderWarningSubtleString = "border-warning-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderInfo() => BorderInfoString;
        [RequiresManagedContext]
        public static ClassName BorderInfo(this string className) => ((ClassName)className).BorderInfo();
        [RequiresManagedContext]
        public static ClassName BorderInfo(this ClassName className)
        {
            className.Add(BorderInfoString);
            return className;
        }
        private const string BorderInfoString = "border-info";
        
        [RequiresManagedContext]
        public static ClassName BorderInfoSubtle() => BorderInfoSubtleString;
        [RequiresManagedContext]
        public static ClassName BorderInfoSubtle(this string className) => ((ClassName)className).BorderInfoSubtle();
        [RequiresManagedContext]
        public static ClassName BorderInfoSubtle(this ClassName className)
        {
            className.Add(BorderInfoSubtleString);
            return className;
        }
        private const string BorderInfoSubtleString = "border-info-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderLight() => BorderLightString;
        [RequiresManagedContext]
        public static ClassName BorderLight(this string className) => ((ClassName)className).BorderLight();
        [RequiresManagedContext]
        public static ClassName BorderLight(this ClassName className)
        {
            className.Add(BorderLightString);
            return className;
        }
        private const string BorderLightString = "border-light";
        
        [RequiresManagedContext]
        public static ClassName BorderLightSubtle() => BorderLightSubtleString;
        [RequiresManagedContext]
        public static ClassName BorderLightSubtle(this string className) => ((ClassName)className).BorderLightSubtle();
        [RequiresManagedContext]
        public static ClassName BorderLightSubtle(this ClassName className)
        {
            className.Add(BorderLightSubtleString);
            return className;
        }
        private const string BorderLightSubtleString = "border-light-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderDark() => BorderDarkString;
        [RequiresManagedContext]
        public static ClassName BorderDark(this string className) => ((ClassName)className).BorderDark();
        [RequiresManagedContext]
        public static ClassName BorderDark(this ClassName className)
        {
            className.Add(BorderDarkString);
            return className;
        }
        private const string BorderDarkString = "border-dark";
        
        [RequiresManagedContext]
        public static ClassName BorderDarkSubtle() => BorderDarkSubtleString;
        [RequiresManagedContext]
        public static ClassName BorderDarkSubtle(this string className) => ((ClassName)className).BorderDarkSubtle();
        [RequiresManagedContext]
        public static ClassName BorderDarkSubtle(this ClassName className)
        {
            className.Add(BorderDarkSubtleString);
            return className;
        }
        private const string BorderDarkSubtleString = "border-dark-subtle";
        
        [RequiresManagedContext]
        public static ClassName BorderBlack() => BorderBlackString;
        [RequiresManagedContext]
        public static ClassName BorderBlack(this string className) => ((ClassName)className).BorderBlack();
        [RequiresManagedContext]
        public static ClassName BorderBlack(this ClassName className)
        {
            className.Add(BorderBlackString);
            return className;
        }
        private const string BorderBlackString = "border-black";
        
        [RequiresManagedContext]
        public static ClassName BorderWhite() => BorderWhiteString;
        [RequiresManagedContext]
        public static ClassName BorderWhite(this string className) => ((ClassName)className).BorderWhite();
        [RequiresManagedContext]
        public static ClassName BorderWhite(this ClassName className)
        {
            className.Add(BorderWhiteString);
            return className;
        }
        private const string BorderWhiteString = "border-white";
        
        [RequiresManagedContext]
        public static ClassName Border1() => Border1String;
        [RequiresManagedContext]
        public static ClassName Border1(this string className) => ((ClassName)className).Border1();
        [RequiresManagedContext]
        public static ClassName Border1(this ClassName className)
        {
            className.Add(Border1String);
            return className;
        }
        private const string Border1String = "border-1";
        
        [RequiresManagedContext]
        public static ClassName Border2() => Border2String;
        [RequiresManagedContext]
        public static ClassName Border2(this string className) => ((ClassName)className).Border2();
        [RequiresManagedContext]
        public static ClassName Border2(this ClassName className)
        {
            className.Add(Border2String);
            return className;
        }
        private const string Border2String = "border-2";
        
        [RequiresManagedContext]
        public static ClassName Border3() => Border3String;
        [RequiresManagedContext]
        public static ClassName Border3(this string className) => ((ClassName)className).Border3();
        [RequiresManagedContext]
        public static ClassName Border3(this ClassName className)
        {
            className.Add(Border3String);
            return className;
        }
        private const string Border3String = "border-3";
        
        [RequiresManagedContext]
        public static ClassName Border4() => Border4String;
        [RequiresManagedContext]
        public static ClassName Border4(this string className) => ((ClassName)className).Border4();
        [RequiresManagedContext]
        public static ClassName Border4(this ClassName className)
        {
            className.Add(Border4String);
            return className;
        }
        private const string Border4String = "border-4";
        
        [RequiresManagedContext]
        public static ClassName Border5() => Border5String;
        [RequiresManagedContext]
        public static ClassName Border5(this string className) => ((ClassName)className).Border5();
        [RequiresManagedContext]
        public static ClassName Border5(this ClassName className)
        {
            className.Add(Border5String);
            return className;
        }
        private const string Border5String = "border-5";
        
        [RequiresManagedContext]
        public static ClassName TextPrimary() => TextPrimaryString;
        [RequiresManagedContext]
        public static ClassName TextPrimary(this string className) => ((ClassName)className).TextPrimary();
        [RequiresManagedContext]
        public static ClassName TextPrimary(this ClassName className)
        {
            className.Add(TextPrimaryString);
            return className;
        }
        private const string TextPrimaryString = "text-primary";
        
        [RequiresManagedContext]
        public static ClassName TextPrimaryEmphasis() => TextPrimaryEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextPrimaryEmphasis(this string className) => ((ClassName)className).TextPrimaryEmphasis();
        [RequiresManagedContext]
        public static ClassName TextPrimaryEmphasis(this ClassName className)
        {
            className.Add(TextPrimaryEmphasisString);
            return className;
        }
        private const string TextPrimaryEmphasisString = "text-primary-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextSecondary() => TextSecondaryString;
        [RequiresManagedContext]
        public static ClassName TextSecondary(this string className) => ((ClassName)className).TextSecondary();
        [RequiresManagedContext]
        public static ClassName TextSecondary(this ClassName className)
        {
            className.Add(TextSecondaryString);
            return className;
        }
        private const string TextSecondaryString = "text-secondary";
        
        [RequiresManagedContext]
        public static ClassName TextSecondaryEmphasis() => TextSecondaryEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextSecondaryEmphasis(this string className) => ((ClassName)className).TextSecondaryEmphasis();
        [RequiresManagedContext]
        public static ClassName TextSecondaryEmphasis(this ClassName className)
        {
            className.Add(TextSecondaryEmphasisString);
            return className;
        }
        private const string TextSecondaryEmphasisString = "text-secondary-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextSuccess() => TextSuccessString;
        [RequiresManagedContext]
        public static ClassName TextSuccess(this string className) => ((ClassName)className).TextSuccess();
        [RequiresManagedContext]
        public static ClassName TextSuccess(this ClassName className)
        {
            className.Add(TextSuccessString);
            return className;
        }
        private const string TextSuccessString = "text-success";
        
        [RequiresManagedContext]
        public static ClassName TextSuccessEmphasis() => TextSuccessEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextSuccessEmphasis(this string className) => ((ClassName)className).TextSuccessEmphasis();
        [RequiresManagedContext]
        public static ClassName TextSuccessEmphasis(this ClassName className)
        {
            className.Add(TextSuccessEmphasisString);
            return className;
        }
        private const string TextSuccessEmphasisString = "text-success-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextDanger() => TextDangerString;
        [RequiresManagedContext]
        public static ClassName TextDanger(this string className) => ((ClassName)className).TextDanger();
        [RequiresManagedContext]
        public static ClassName TextDanger(this ClassName className)
        {
            className.Add(TextDangerString);
            return className;
        }
        private const string TextDangerString = "text-danger";
        
        [RequiresManagedContext]
        public static ClassName TextDangerEmphasis() => TextDangerEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextDangerEmphasis(this string className) => ((ClassName)className).TextDangerEmphasis();
        [RequiresManagedContext]
        public static ClassName TextDangerEmphasis(this ClassName className)
        {
            className.Add(TextDangerEmphasisString);
            return className;
        }
        private const string TextDangerEmphasisString = "text-danger-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextWarning() => TextWarningString;
        [RequiresManagedContext]
        public static ClassName TextWarning(this string className) => ((ClassName)className).TextWarning();
        [RequiresManagedContext]
        public static ClassName TextWarning(this ClassName className)
        {
            className.Add(TextWarningString);
            return className;
        }
        private const string TextWarningString = "text-warning";
        
        [RequiresManagedContext]
        public static ClassName TextWarningEmphasis() => TextWarningEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextWarningEmphasis(this string className) => ((ClassName)className).TextWarningEmphasis();
        [RequiresManagedContext]
        public static ClassName TextWarningEmphasis(this ClassName className)
        {
            className.Add(TextWarningEmphasisString);
            return className;
        }
        private const string TextWarningEmphasisString = "text-warning-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextInfo() => TextInfoString;
        [RequiresManagedContext]
        public static ClassName TextInfo(this string className) => ((ClassName)className).TextInfo();
        [RequiresManagedContext]
        public static ClassName TextInfo(this ClassName className)
        {
            className.Add(TextInfoString);
            return className;
        }
        private const string TextInfoString = "text-info";
        
        [RequiresManagedContext]
        public static ClassName TextInfoEmphasis() => TextInfoEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextInfoEmphasis(this string className) => ((ClassName)className).TextInfoEmphasis();
        [RequiresManagedContext]
        public static ClassName TextInfoEmphasis(this ClassName className)
        {
            className.Add(TextInfoEmphasisString);
            return className;
        }
        private const string TextInfoEmphasisString = "text-info-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextLight() => TextLightString;
        [RequiresManagedContext]
        public static ClassName TextLight(this string className) => ((ClassName)className).TextLight();
        [RequiresManagedContext]
        public static ClassName TextLight(this ClassName className)
        {
            className.Add(TextLightString);
            return className;
        }
        private const string TextLightString = "text-light";
        
        [RequiresManagedContext]
        public static ClassName TextLightEmphasis() => TextLightEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextLightEmphasis(this string className) => ((ClassName)className).TextLightEmphasis();
        [RequiresManagedContext]
        public static ClassName TextLightEmphasis(this ClassName className)
        {
            className.Add(TextLightEmphasisString);
            return className;
        }
        private const string TextLightEmphasisString = "text-light-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextDark() => TextDarkString;
        [RequiresManagedContext]
        public static ClassName TextDark(this string className) => ((ClassName)className).TextDark();
        [RequiresManagedContext]
        public static ClassName TextDark(this ClassName className)
        {
            className.Add(TextDarkString);
            return className;
        }
        private const string TextDarkString = "text-dark";
        
        [RequiresManagedContext]
        public static ClassName TextDarkEmphasis() => TextDarkEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextDarkEmphasis(this string className) => ((ClassName)className).TextDarkEmphasis();
        [RequiresManagedContext]
        public static ClassName TextDarkEmphasis(this ClassName className)
        {
            className.Add(TextDarkEmphasisString);
            return className;
        }
        private const string TextDarkEmphasisString = "text-dark-emphasis";
        
        [RequiresManagedContext]
        public static ClassName TextBody() => TextBodyString;
        [RequiresManagedContext]
        public static ClassName TextBody(this string className) => ((ClassName)className).TextBody();
        [RequiresManagedContext]
        public static ClassName TextBody(this ClassName className)
        {
            className.Add(TextBodyString);
            return className;
        }
        private const string TextBodyString = "text-body";
        
        [RequiresManagedContext]
        public static ClassName TextBodySecondary() => TextBodySecondaryString;
        [RequiresManagedContext]
        public static ClassName TextBodySecondary(this string className) => ((ClassName)className).TextBodySecondary();
        [RequiresManagedContext]
        public static ClassName TextBodySecondary(this ClassName className)
        {
            className.Add(TextBodySecondaryString);
            return className;
        }
        private const string TextBodySecondaryString = "text-body-secondary";
        
        [RequiresManagedContext]
        public static ClassName TextBodyTertiary() => TextBodyTertiaryString;
        [RequiresManagedContext]
        public static ClassName TextBodyTertiary(this string className) => ((ClassName)className).TextBodyTertiary();
        [RequiresManagedContext]
        public static ClassName TextBodyTertiary(this ClassName className)
        {
            className.Add(TextBodyTertiaryString);
            return className;
        }
        private const string TextBodyTertiaryString = "text-body-tertiary";
        
        [RequiresManagedContext]
        public static ClassName TextBlack() => TextBlackString;
        [RequiresManagedContext]
        public static ClassName TextBlack(this string className) => ((ClassName)className).TextBlack();
        [RequiresManagedContext]
        public static ClassName TextBlack(this ClassName className)
        {
            className.Add(TextBlackString);
            return className;
        }
        private const string TextBlackString = "text-black";
        
        [RequiresManagedContext]
        public static ClassName TextBlack50() => TextBlack50String;
        [RequiresManagedContext]
        public static ClassName TextBlack50(this string className) => ((ClassName)className).TextBlack50();
        [RequiresManagedContext]
        public static ClassName TextBlack50(this ClassName className)
        {
            className.Add(TextBlack50String);
            return className;
        }
        private const string TextBlack50String = "text-black-50";
        
        [RequiresManagedContext]
        public static ClassName TextWhite() => TextWhiteString;
        [RequiresManagedContext]
        public static ClassName TextWhite(this string className) => ((ClassName)className).TextWhite();
        [RequiresManagedContext]
        public static ClassName TextWhite(this ClassName className)
        {
            className.Add(TextWhiteString);
            return className;
        }
        private const string TextWhiteString = "text-white";
        
        [RequiresManagedContext]
        public static ClassName TextWhite50() => TextWhite50String;
        [RequiresManagedContext]
        public static ClassName TextWhite50(this string className) => ((ClassName)className).TextWhite50();
        [RequiresManagedContext]
        public static ClassName TextWhite50(this ClassName className)
        {
            className.Add(TextWhite50String);
            return className;
        }
        private const string TextWhite50String = "text-white-50";
        
        [RequiresManagedContext]
        public static ClassName Rounded() => RoundedString;
        [RequiresManagedContext]
        public static ClassName Rounded(this string className) => ((ClassName)className).Rounded();
        [RequiresManagedContext]
        public static ClassName Rounded(this ClassName className)
        {
            className.Add(RoundedString);
            return className;
        }
        private const string RoundedString = "rounded";
        
        [RequiresManagedContext]
        public static ClassName RoundedTop() => RoundedTopString;
        [RequiresManagedContext]
        public static ClassName RoundedTop(this string className) => ((ClassName)className).RoundedTop();
        [RequiresManagedContext]
        public static ClassName RoundedTop(this ClassName className)
        {
            className.Add(RoundedTopString);
            return className;
        }
        private const string RoundedTopString = "rounded-top";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottom() => RoundedBottomString;
        [RequiresManagedContext]
        public static ClassName RoundedBottom(this string className) => ((ClassName)className).RoundedBottom();
        [RequiresManagedContext]
        public static ClassName RoundedBottom(this ClassName className)
        {
            className.Add(RoundedBottomString);
            return className;
        }
        private const string RoundedBottomString = "rounded-bottom";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeft() => RoundedLeftString;
        [RequiresManagedContext]
        public static ClassName RoundedLeft(this string className) => ((ClassName)className).RoundedLeft();
        [RequiresManagedContext]
        public static ClassName RoundedLeft(this ClassName className)
        {
            className.Add(RoundedLeftString);
            return className;
        }
        private const string RoundedLeftString = "rounded-left";
        
        [RequiresManagedContext]
        public static ClassName RoundedRight() => RoundedRightString;
        [RequiresManagedContext]
        public static ClassName RoundedRight(this string className) => ((ClassName)className).RoundedRight();
        [RequiresManagedContext]
        public static ClassName RoundedRight(this ClassName className)
        {
            className.Add(RoundedRightString);
            return className;
        }
        private const string RoundedRightString = "rounded-right";
        
        [RequiresManagedContext]
        public static ClassName Rounded0() => Rounded0String;
        [RequiresManagedContext]
        public static ClassName Rounded0(this string className) => ((ClassName)className).Rounded0();
        [RequiresManagedContext]
        public static ClassName Rounded0(this ClassName className)
        {
            className.Add(Rounded0String);
            return className;
        }
        private const string Rounded0String = "rounded-0";
        
        [RequiresManagedContext]
        public static ClassName Rounded1() => Rounded1String;
        [RequiresManagedContext]
        public static ClassName Rounded1(this string className) => ((ClassName)className).Rounded1();
        [RequiresManagedContext]
        public static ClassName Rounded1(this ClassName className)
        {
            className.Add(Rounded1String);
            return className;
        }
        private const string Rounded1String = "rounded-1";
        
        [RequiresManagedContext]
        public static ClassName Rounded2() => Rounded2String;
        [RequiresManagedContext]
        public static ClassName Rounded2(this string className) => ((ClassName)className).Rounded2();
        [RequiresManagedContext]
        public static ClassName Rounded2(this ClassName className)
        {
            className.Add(Rounded2String);
            return className;
        }
        private const string Rounded2String = "rounded-2";
        
        [RequiresManagedContext]
        public static ClassName Rounded3() => Rounded3String;
        [RequiresManagedContext]
        public static ClassName Rounded3(this string className) => ((ClassName)className).Rounded3();
        [RequiresManagedContext]
        public static ClassName Rounded3(this ClassName className)
        {
            className.Add(Rounded3String);
            return className;
        }
        private const string Rounded3String = "rounded-3";
        
        [RequiresManagedContext]
        public static ClassName Rounded4() => Rounded4String;
        [RequiresManagedContext]
        public static ClassName Rounded4(this string className) => ((ClassName)className).Rounded4();
        [RequiresManagedContext]
        public static ClassName Rounded4(this ClassName className)
        {
            className.Add(Rounded4String);
            return className;
        }
        private const string Rounded4String = "rounded-4";
        
        [RequiresManagedContext]
        public static ClassName Rounded5() => Rounded5String;
        [RequiresManagedContext]
        public static ClassName Rounded5(this string className) => ((ClassName)className).Rounded5();
        [RequiresManagedContext]
        public static ClassName Rounded5(this ClassName className)
        {
            className.Add(Rounded5String);
            return className;
        }
        private const string Rounded5String = "rounded-5";
        
        [RequiresManagedContext]
        public static ClassName RoundedCircle() => RoundedCircleString;
        [RequiresManagedContext]
        public static ClassName RoundedCircle(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName RoundedCircle(this ClassName className)
        {
            className.Add(RoundedCircleString);
            return className;
        }
        private const string RoundedCircleString = "rounded-circle";
        
        [RequiresManagedContext]
        public static ClassName RoundedTop0() => RoundedTop0String;
        [RequiresManagedContext]
        public static ClassName RoundedTop0(this string className) => ((ClassName)className).Rounded0();
        [RequiresManagedContext]
        public static ClassName RoundedTop0(this ClassName className)
        {
            className.Add(RoundedTop0String);
            return className;
        }
        private const string RoundedTop0String = "rounded-top-0";
        
        [RequiresManagedContext]
        public static ClassName RoundedTop1() => RoundedTop1String;
        [RequiresManagedContext]
        public static ClassName RoundedTop1(this string className) => ((ClassName)className).Rounded1();
        [RequiresManagedContext]
        public static ClassName RoundedTop1(this ClassName className)
        {
            className.Add(RoundedTop1String);
            return className;
        }
        private const string RoundedTop1String = "rounded-top-1";
        
        [RequiresManagedContext]
        public static ClassName RoundedTop2() => RoundedTop2String;
        [RequiresManagedContext]
        public static ClassName RoundedTop2(this string className) => ((ClassName)className).Rounded2();
        [RequiresManagedContext]
        public static ClassName RoundedTop2(this ClassName className)
        {
            className.Add(RoundedTop2String);
            return className;
        }
        private const string RoundedTop2String = "rounded-top-2";
        
        [RequiresManagedContext]
        public static ClassName RoundedTop3() => RoundedTop3String;
        [RequiresManagedContext]
        public static ClassName RoundedTop3(this string className) => ((ClassName)className).Rounded3();
        [RequiresManagedContext]
        public static ClassName RoundedTop3(this ClassName className)
        {
            className.Add(RoundedTop3String);
            return className;
        }
        private const string RoundedTop3String = "rounded-top-3";
        
        [RequiresManagedContext]
        public static ClassName RoundedTop4() => RoundedTop4String;
        [RequiresManagedContext]
        public static ClassName RoundedTop4(this string className) => ((ClassName)className).Rounded4();
        [RequiresManagedContext]
        public static ClassName RoundedTop4(this ClassName className)
        {
            className.Add(RoundedTop4String);
            return className;
        }
        private const string RoundedTop4String = "rounded-top-4";
        
        [RequiresManagedContext]
        public static ClassName RoundedTop5() => RoundedTop5String;
        [RequiresManagedContext]
        public static ClassName RoundedTop5(this string className) => ((ClassName)className).Rounded5();
        [RequiresManagedContext]
        public static ClassName RoundedTop5(this ClassName className)
        {
            className.Add(RoundedTop5String);
            return className;
        }
        private const string RoundedTop5String = "rounded-top-5";
        
        [RequiresManagedContext]
        public static ClassName RoundedTopCircle() => RoundedTopCircleString;
        [RequiresManagedContext]
        public static ClassName RoundedTopCircle(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName RoundedTopCircle(this ClassName className)
        {
            className.Add(RoundedTopCircleString);
            return className;
        }
        private const string RoundedTopCircleString = "rounded-top-circle";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottom0() => RoundedBottom0String;
        [RequiresManagedContext]
        public static ClassName RoundedBottom0(this string className) => ((ClassName)className).Rounded0();
        [RequiresManagedContext]
        public static ClassName RoundedBottom0(this ClassName className)
        {
            className.Add(RoundedBottom0String);
            return className;
        }
        private const string RoundedBottom0String = "rounded-bottom-0";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottom1() => RoundedBottom1String;
        [RequiresManagedContext]
        public static ClassName RoundedBottom1(this string className) => ((ClassName)className).Rounded1();
        [RequiresManagedContext]
        public static ClassName RoundedBottom1(this ClassName className)
        {
            className.Add(RoundedBottom1String);
            return className;
        }
        private const string RoundedBottom1String = "rounded-bottom-1";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottom2() => RoundedBottom2String;
        [RequiresManagedContext]
        public static ClassName RoundedBottom2(this string className) => ((ClassName)className).Rounded2();
        [RequiresManagedContext]
        public static ClassName RoundedBottom2(this ClassName className)
        {
            className.Add(RoundedBottom2String);
            return className;
        }
        private const string RoundedBottom2String = "rounded-bottom-2";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottom3() => RoundedBottom3String;
        [RequiresManagedContext]
        public static ClassName RoundedBottom3(this string className) => ((ClassName)className).Rounded3();
        [RequiresManagedContext]
        public static ClassName RoundedBottom3(this ClassName className)
        {
            className.Add(RoundedBottom3String);
            return className;
        }
        private const string RoundedBottom3String = "rounded-bottom-3";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottom4() => RoundedBottom4String;
        [RequiresManagedContext]
        public static ClassName RoundedBottom4(this string className) => ((ClassName)className).Rounded4();
        [RequiresManagedContext]
        public static ClassName RoundedBottom4(this ClassName className)
        {
            className.Add(RoundedBottom4String);
            return className;
        }
        private const string RoundedBottom4String = "rounded-bottom-4";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottom5() => RoundedBottom5String;
        [RequiresManagedContext]
        public static ClassName RoundedBottom5(this string className) => ((ClassName)className).Rounded5();
        [RequiresManagedContext]
        public static ClassName RoundedBottom5(this ClassName className)
        {
            className.Add(RoundedBottom5String);
            return className;
        }
        private const string RoundedBottom5String = "rounded-bottom-5";
        
        [RequiresManagedContext]
        public static ClassName RoundedBottomCircle() => RoundedBottomCircleString;
        [RequiresManagedContext]
        public static ClassName RoundedBottomCircle(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName RoundedBottomCircle(this ClassName className)
        {
            className.Add(RoundedBottomCircleString);
            return className;
        }
        private const string RoundedBottomCircleString = "rounded-bottom-circle";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeft0() => RoundedLeft0String;
        [RequiresManagedContext]
        public static ClassName RoundedLeft0(this string className) => ((ClassName)className).Rounded0();
        [RequiresManagedContext]
        public static ClassName RoundedLeft0(this ClassName className)
        {
            className.Add(RoundedLeft0String);
            return className;
        }
        private const string RoundedLeft0String = "rounded-left-0";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeft1() => RoundedLeft1String;
        [RequiresManagedContext]
        public static ClassName RoundedLeft1(this string className) => ((ClassName)className).Rounded1();
        [RequiresManagedContext]
        public static ClassName RoundedLeft1(this ClassName className)
        {
            className.Add(RoundedLeft1String);
            return className;
        }
        private const string RoundedLeft1String = "rounded-left-1";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeft2() => RoundedLeft2String;
        [RequiresManagedContext]
        public static ClassName RoundedLeft2(this string className) => ((ClassName)className).Rounded2();
        [RequiresManagedContext]
        public static ClassName RoundedLeft2(this ClassName className)
        {
            className.Add(RoundedLeft2String);
            return className;
        }
        private const string RoundedLeft2String = "rounded-left-2";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeft3() => RoundedLeft3String;
        [RequiresManagedContext]
        public static ClassName RoundedLeft3(this string className) => ((ClassName)className).Rounded3();
        [RequiresManagedContext]
        public static ClassName RoundedLeft3(this ClassName className)
        {
            className.Add(RoundedLeft3String);
            return className;
        }
        private const string RoundedLeft3String = "rounded-left-3";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeft4() => RoundedLeft4String;
        [RequiresManagedContext]
        public static ClassName RoundedLeft4(this string className) => ((ClassName)className).Rounded4();
        [RequiresManagedContext]
        public static ClassName RoundedLeft4(this ClassName className)
        {
            className.Add(RoundedLeft4String);
            return className;
        }
        private const string RoundedLeft4String = "rounded-left-4";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeft5() => RoundedLeft5String;
        [RequiresManagedContext]
        public static ClassName RoundedLeft5(this string className) => ((ClassName)className).Rounded5();
        [RequiresManagedContext]
        public static ClassName RoundedLeft5(this ClassName className)
        {
            className.Add(RoundedLeft5String);
            return className;
        }
        private const string RoundedLeft5String = "rounded-left-5";
        
        [RequiresManagedContext]
        public static ClassName RoundedLeftCircle() => RoundedLeftCircleString;
        [RequiresManagedContext]
        public static ClassName RoundedLeftCircle(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName RoundedLeftCircle(this ClassName className)
        {
            className.Add(RoundedLeftCircleString);
            return className;
        }
        private const string RoundedLeftCircleString = "rounded-left-circle";
        
        [RequiresManagedContext]
        public static ClassName RoundedRight0() => RoundedRight0String;
        [RequiresManagedContext]
        public static ClassName RoundedRight0(this string className) => ((ClassName)className).Rounded0();
        [RequiresManagedContext]
        public static ClassName RoundedRight0(this ClassName className)
        {
            className.Add(RoundedRight0String);
            return className;
        }
        private const string RoundedRight0String = "rounded-right-0";
        
        [RequiresManagedContext]
        public static ClassName RoundedRight1() => RoundedRight1String;
        [RequiresManagedContext]
        public static ClassName RoundedRight1(this string className) => ((ClassName)className).Rounded1();
        [RequiresManagedContext]
        public static ClassName RoundedRight1(this ClassName className)
        {
            className.Add(RoundedRight1String);
            return className;
        }
        private const string RoundedRight1String = "rounded-right-1";
        
        [RequiresManagedContext]
        public static ClassName RoundedRight2() => RoundedRight2String;
        [RequiresManagedContext]
        public static ClassName RoundedRight2(this string className) => ((ClassName)className).Rounded2();
        [RequiresManagedContext]
        public static ClassName RoundedRight2(this ClassName className)
        {
            className.Add(RoundedRight2String);
            return className;
        }
        private const string RoundedRight2String = "rounded-right-2";
        
        [RequiresManagedContext]
        public static ClassName RoundedRight3() => RoundedRight3String;
        [RequiresManagedContext]
        public static ClassName RoundedRight3(this string className) => ((ClassName)className).Rounded3();
        [RequiresManagedContext]
        public static ClassName RoundedRight3(this ClassName className)
        {
            className.Add(RoundedRight3String);
            return className;
        }
        private const string RoundedRight3String = "rounded-right-3";
        
        [RequiresManagedContext]
        public static ClassName RoundedRight4() => RoundedRight4String;
        [RequiresManagedContext]
        public static ClassName RoundedRight4(this string className) => ((ClassName)className).Rounded4();
        [RequiresManagedContext]
        public static ClassName RoundedRight4(this ClassName className)
        {
            className.Add(RoundedRight4String);
            return className;
        }
        private const string RoundedRight4String = "rounded-right-4";
        
        [RequiresManagedContext]
        public static ClassName RoundedRight5() => RoundedRight5String;
        [RequiresManagedContext]
        public static ClassName RoundedRight5(this string className) => ((ClassName)className).Rounded5();
        [RequiresManagedContext]
        public static ClassName RoundedRight5(this ClassName className)
        {
            className.Add(RoundedRight5String);
            return className;
        }
        private const string RoundedRight5String = "rounded-right-5";
        
        [RequiresManagedContext]
        public static ClassName RoundedRightCircle() => RoundedRightCircleString;
        [RequiresManagedContext]
        public static ClassName RoundedRightCircle(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName RoundedRightCircle(this ClassName className)
        {
            className.Add(RoundedRightCircleString);
            return className;
        }
        private const string RoundedRightCircleString = "rounded-right-circle";
        
        [RequiresManagedContext]
        public static ClassName TextWrap() => TextWrapString;
        [RequiresManagedContext]
        public static ClassName TextWrap(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName TextWrap(this ClassName className)
        {
            className.Add(TextWrapString);
            return className;
        }
        private const string TextWrapString = "text-wrap";
        
        [RequiresManagedContext]
        public static ClassName TextNowrap() => TextNowrapString;
        [RequiresManagedContext]
        public static ClassName TextNowrap(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName TextNowrap(this ClassName className)
        {
            className.Add(TextNowrapString);
            return className;
        }
        private const string TextNowrapString = "text-nowrap";
        
        [RequiresManagedContext]
        public static ClassName FontSize1() => FontSize1String;
        [RequiresManagedContext]
        public static ClassName FontSize1(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontSize1(this ClassName className)
        {
            className.Add(FontSize1String);
            return className;
        }
        private const string FontSize1String = "fs-1";
        
        [RequiresManagedContext]
        public static ClassName FontSize2() => FontSize2String;
        [RequiresManagedContext]
        public static ClassName FontSize2(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontSize2(this ClassName className)
        {
            className.Add(FontSize2String);
            return className;
        }
        private const string FontSize2String = "fs-2";
        
        [RequiresManagedContext]
        public static ClassName FontSize3() => FontSize3String;
        [RequiresManagedContext]
        public static ClassName FontSize3(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontSize3(this ClassName className)
        {
            className.Add(FontSize3String);
            return className;
        }
        private const string FontSize3String = "fs-3";
        
        [RequiresManagedContext]
        public static ClassName FontSize4() => FontSize4String;
        [RequiresManagedContext]
        public static ClassName FontSize4(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontSize4(this ClassName className)
        {
            className.Add(FontSize4String);
            return className;
        }
        private const string FontSize4String = "fs-4";
        
        [RequiresManagedContext]
        public static ClassName FontSize5() => FontSize5String;
        [RequiresManagedContext]
        public static ClassName FontSize5(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontSize5(this ClassName className)
        {
            className.Add(FontSize5String);
            return className;
        }
        private const string FontSize5String = "fs-5";
        
        [RequiresManagedContext]
        public static ClassName FontSize6() => FontSize6String;
        [RequiresManagedContext]
        public static ClassName FontSize6(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontSize6(this ClassName className)
        {
            className.Add(FontSize6String);
            return className;
        }
        private const string FontSize6String = "fs-6";
        
        [RequiresManagedContext]
        public static ClassName FontStyleBold() => FontStyleBoldString;
        [RequiresManagedContext]
        public static ClassName FontStyleBold(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontStyleBold(this ClassName className)
        {
            className.Add(FontStyleBoldString);
            return className;
        }
        private const string FontStyleBoldString = "fst-bold";
        
        [RequiresManagedContext]
        public static ClassName FontStyleItalic() => FontStyleItalicString;
        [RequiresManagedContext]
        public static ClassName FontStyleItalic(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontStyleItalic(this ClassName className)
        {
            className.Add(FontStyleItalicString);
            return className;
        }
        private const string FontStyleItalicString = "fst-italic";
        
        [RequiresManagedContext]
        public static ClassName FontStyleNormal() => FontStyleNormalString;
        [RequiresManagedContext]
        public static ClassName FontStyleNormal(this string className) => ((ClassName)className).RoundedCircle();
        [RequiresManagedContext]
        public static ClassName FontStyleNormal(this ClassName className)
        {
            className.Add(FontStyleNormalString);
            return className;
        }
        private const string FontStyleNormalString = "fst-normal";
        
        
        
        
        
        
        
        private static string GetResponsiveSizeUSSCode(ResponsiveContext.Size responsiveSize) =>
            responsiveSize switch
            {
                ResponsiveContext.Size.Small => "sm",
                ResponsiveContext.Size.Medium => "md",
                ResponsiveContext.Size.Large => "lg",
                ResponsiveContext.Size.XLarge => "xl",
                ResponsiveContext.Size.XXLarge => "xxl"
            };
    }
}