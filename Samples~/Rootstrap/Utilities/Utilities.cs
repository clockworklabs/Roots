using RishUI;
using RishUI.MemoryManagement;

namespace Roots.Rootstrap
{
    public static class Utilities
    {
        [RequiresManagedContext]
        public static ClassName DisplayNone(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => DisplayNoneString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName DisplayNone(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).DisplayNone(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName DisplayNone(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(DisplayNoneString(responsiveBreakpoint));
            return className;
        }
        private static string DisplayNoneString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "display-none"
            : $"display-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-none";
        
        [RequiresManagedContext]
        public static ClassName DisplayFlex(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => DisplayFlexString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName DisplayFlex(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).DisplayFlex(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName DisplayFlex(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(DisplayFlexString(responsiveBreakpoint));
            return className;
        }
        private static string DisplayFlexString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "display-flex"
            : $"display-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-flex";
        
        [RequiresManagedContext]
        public static ClassName FlexColumn(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexColumnString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexColumn(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexColumn(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexColumn(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexColumnString(responsiveBreakpoint));
            return className;
        }
        private static string FlexColumnString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-column"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-column";
        
        [RequiresManagedContext]
        public static ClassName FlexColumnReverse(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexColumnReverseString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexColumnReverse(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexColumnReverse(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexColumnReverse(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexColumnReverseString(responsiveBreakpoint));
            return className;
        }
        private static string FlexColumnReverseString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-column-reverse"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-column-reverse";
        
        [RequiresManagedContext]
        public static ClassName FlexRow(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexRowString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexRow(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexRow(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexRow(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexRowString(responsiveBreakpoint));
            return className;
        }
        private static string FlexRowString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-row"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-row";
        
        [RequiresManagedContext]
        public static ClassName FlexRowReverse(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexRowReverseString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexRowReverse(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexRowReverse(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexRowReverse(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexRowReverseString(responsiveBreakpoint));
            return className;
        }
        private static string FlexRowReverseString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-row-reverse"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-row-reverse";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentStart(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => JustifyContentStartString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentStart(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).JustifyContentStart(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentStart(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(JustifyContentStartString(responsiveBreakpoint));
            return className;
        }
        private static string JustifyContentStartString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "justify-content-start"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-start";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentEnd(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => JustifyContentEndString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentEnd(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).JustifyContentEnd(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentEnd(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(JustifyContentEndString(responsiveBreakpoint));
            return className;
        }
        private static string JustifyContentEndString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "justify-content-end"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-end";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => JustifyContentCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).JustifyContentCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(JustifyContentCenterString(responsiveBreakpoint));
            return className;
        }
        private static string JustifyContentCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "justify-content-center"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-center";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentBetween(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => JustifyContentBetweenString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentBetween(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).JustifyContentBetween(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentBetween(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(JustifyContentBetweenString(responsiveBreakpoint));
            return className;
        }
        private static string JustifyContentBetweenString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "justify-content-between"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-between";
        
        [RequiresManagedContext]
        public static ClassName JustifyContentAround(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => JustifyContentAroundString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentAround(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).JustifyContentAround(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName JustifyContentAround(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(JustifyContentAroundString(responsiveBreakpoint));
            return className;
        }
        private static string JustifyContentAroundString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "justify-content-around"
            : $"justify-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-around";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsStart(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignItemsStartString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsStart(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignItemsStart(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsStart(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignItemsStartString(responsiveBreakpoint));
            return className;
        }
        private static string AlignItemsStartString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-items-start"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-start";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsEnd(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignItemsEndString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsEnd(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignItemsEnd(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsEnd(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignItemsEndString(responsiveBreakpoint));
            return className;
        }
        private static string AlignItemsEndString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-items-end"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-end";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignItemsCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignItemsCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignItemsCenterString(responsiveBreakpoint));
            return className;
        }
        private static string AlignItemsCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-items-center"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-center";
        
        [RequiresManagedContext]
        public static ClassName AlignItemsStretch(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignItemsStretchString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsStretch(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignItemsStretch(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignItemsStretch(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignItemsStretchString(responsiveBreakpoint));
            return className;
        }
        private static string AlignItemsStretchString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-items-stretch"
            : $"align-items-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-stretch";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfStart(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignSelfStartString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfStart(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignSelfStart(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfStart(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignSelfStartString(responsiveBreakpoint));
            return className;
        }
        private static string AlignSelfStartString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-self-start"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-start";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfEnd(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignSelfEndString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfEnd(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignSelfEnd(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfEnd(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignSelfEndString(responsiveBreakpoint));
            return className;
        }
        private static string AlignSelfEndString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-self-end"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-end";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignSelfCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignSelfCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignSelfCenterString(responsiveBreakpoint));
            return className;
        }
        private static string AlignSelfCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-self-center"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-center";
        
        [RequiresManagedContext]
        public static ClassName AlignSelfStretch(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignSelfStretchString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfStretch(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignSelfStretch(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignSelfStretch(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignSelfStretchString(responsiveBreakpoint));
            return className;
        }
        private static string AlignSelfStretchString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-self-stretch"
            : $"align-self-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-stretch";
        
        [RequiresManagedContext]
        public static ClassName FlexFill(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexFillString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexFill(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexFill(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexFill(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexFillString(responsiveBreakpoint));
            return className;
        }
        private static string FlexFillString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-fill"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-fill";
        
        [RequiresManagedContext]
        public static ClassName FlexGrow0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexGrow0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexGrow0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexGrow0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexGrow0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexGrow0String(responsiveBreakpoint));
            return className;
        }
        private static string FlexGrow0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-grow-0"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-grow-0";
        
        [RequiresManagedContext]
        public static ClassName FlexGrow1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexGrow1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexGrow1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexGrow1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexGrow1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexGrow1String(responsiveBreakpoint));
            return className;
        }
        private static string FlexGrow1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-grow-1"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-grow-1";
        
        [RequiresManagedContext]
        public static ClassName FlexShrink0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexShrink0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexShrink0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexShrink0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexShrink0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexShrink0String(responsiveBreakpoint));
            return className;
        }
        private static string FlexShrink0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-shrink-0"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-shrink-0";
        
        [RequiresManagedContext]
        public static ClassName FlexShrink1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexShrink1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexShrink1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexShrink1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexShrink1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexShrink1String(responsiveBreakpoint));
            return className;
        }
        private static string FlexShrink1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-shrink-1"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-shrink-1";
        
        [RequiresManagedContext]
        public static ClassName FlexNoWrap(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexNoWrapString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexNoWrap(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexNoWrap(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexNoWrap(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexNoWrapString(responsiveBreakpoint));
            return className;
        }
        private static string FlexNoWrapString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-nowrap"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nowrap";
        
        [RequiresManagedContext]
        public static ClassName FlexWrap(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexWrapString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexWrap(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexWrap(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexWrap(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexWrapString(responsiveBreakpoint));
            return className;
        }
        private static string FlexWrapString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-wrap"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-wrap";
        
        [RequiresManagedContext]
        public static ClassName FlexWrapReverse(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => FlexWrapReverseString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexWrapReverse(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).FlexWrapReverse(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName FlexWrapReverse(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(FlexWrapReverseString(responsiveBreakpoint));
            return className;
        }
        private static string FlexWrapReverseString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "flex-wrap-reverse"
            : $"flex-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-wrap-reverse";
        
        [RequiresManagedContext]
        public static ClassName AlignContentStart(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignContentStartString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentStart(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignContentStart(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentStart(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignContentStartString(responsiveBreakpoint));
            return className;
        }
        private static string AlignContentStartString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-content-start"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-start";
        
        [RequiresManagedContext]
        public static ClassName AlignContentEnd(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignContentEndString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentEnd(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignContentEnd(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentEnd(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignContentEndString(responsiveBreakpoint));
            return className;
        }
        private static string AlignContentEndString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-content-end"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-end";
        
        [RequiresManagedContext]
        public static ClassName AlignContentCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignContentCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignContentCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignContentCenterString(responsiveBreakpoint));
            return className;
        }
        private static string AlignContentCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-content-center"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-center";
        
        [RequiresManagedContext]
        public static ClassName AlignContentStretch(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => AlignContentStretchString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentStretch(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).AlignContentStretch(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName AlignContentStretch(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(AlignContentStretchString(responsiveBreakpoint));
            return className;
        }
        private static string AlignContentStretchString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "align-content-stretch"
            : $"align-content-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-stretch";
        
        [RequiresManagedContext]
        public static ClassName Margin0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Margin0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Margin0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Margin0String(responsiveBreakpoint));
            return className;
        }
        private static string Margin0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-0"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName Margin1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Margin1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Margin1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Margin1String(responsiveBreakpoint));
            return className;
        }
        private static string Margin1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-1"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName Margin2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Margin2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Margin2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Margin2String(responsiveBreakpoint));
            return className;
        }
        private static string Margin2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-2"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName Margin3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Margin3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Margin3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Margin3String(responsiveBreakpoint));
            return className;
        }
        private static string Margin3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-3"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName Margin4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Margin4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Margin4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Margin4String(responsiveBreakpoint));
            return className;
        }
        private static string Margin4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-4"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName Margin5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Margin5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Margin5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Margin5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Margin5String(responsiveBreakpoint));
            return className;
        }
        private static string Margin5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-5"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginAuto(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginAutoString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginAuto(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginAuto(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginAuto(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginAutoString(responsiveBreakpoint));
            return className;
        }
        private static string MarginAutoString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-auto"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-h1"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-h2"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-h3"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-h4"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-h5"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginNegative1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegative1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegative1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegative1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegative1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-n1"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginNegative2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegative2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegative2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegative2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegative2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-n2"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginNegative3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegative3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegative3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegative3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegative3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-n3"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginNegative4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegative4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegative4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegative4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegative4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-n4"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginNegative5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegative5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegative5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegative5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegative5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegative5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-n5"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegativeHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegativeHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegativeHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegativeHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-nh1"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegativeHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegativeHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegativeHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegativeHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-nh2"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegativeHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegativeHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegativeHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegativeHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-nh3"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegativeHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegativeHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegativeHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegativeHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-nh4"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginNegativeHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginNegativeHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginNegativeHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginNegativeHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginNegativeHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "m-nh5"
            : $"m-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginTop0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTop0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTop0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTop0String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTop0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-0"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginTop1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTop1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTop1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTop1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTop1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginTop2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTop2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTop2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTop2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTop2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginTop3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTop3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTop3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTop3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTop3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginTop4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTop4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTop4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTop4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTop4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginTop5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTop5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTop5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTop5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTop5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTop5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginTopAuto(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopAutoString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopAuto(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopAuto(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopAuto(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopAutoString(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopAutoString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-auto"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-h1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-h2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-h3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-h4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginTopHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-h5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegative1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegative1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegative1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegative1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-n1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegative2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegative2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegative2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegative2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-n2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegative3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegative3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegative3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegative3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-n3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegative4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegative4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegative4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegative4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-n4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegative5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegative5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegative5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegative5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegative5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegative5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-n5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegativeHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegativeHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegativeHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegativeHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-nh1"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegativeHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegativeHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegativeHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegativeHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-nh2"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegativeHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegativeHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegativeHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegativeHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-nh3"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegativeHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegativeHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegativeHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegativeHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-nh4"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginTopNegativeHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginTopNegativeHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginTopNegativeHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginTopNegativeHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginTopNegativeHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mt-nh5"
            : $"mt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottom0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottom0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottom0String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottom0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-0"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottom1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottom1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottom1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottom1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottom2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottom2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottom2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottom2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottom3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottom3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottom3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottom3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottom4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottom4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottom4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottom4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottom5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottom5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottom5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottom5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottom5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottom5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomAuto(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomAutoString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomAuto(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomAuto(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomAuto(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomAutoString(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomAutoString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-auto"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-h1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-h2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-h3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-h4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-h5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegative1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegative1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegative1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegative1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-n1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegative2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegative2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegative2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegative2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-n2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegative3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegative3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegative3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegative3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-n3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegative4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegative4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegative4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegative4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-n4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegative5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegative5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegative5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegative5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegative5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-n5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegativeHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegativeHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegativeHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegativeHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-nh1"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegativeHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegativeHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegativeHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegativeHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-nh2"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegativeHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegativeHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegativeHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegativeHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-nh3"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegativeHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegativeHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegativeHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegativeHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-nh4"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginBottomNegativeHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginBottomNegativeHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginBottomNegativeHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginBottomNegativeHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginBottomNegativeHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mb-nh5"
            : $"mb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeft0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeft0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeft0String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeft0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-0"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeft1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeft1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeft1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeft1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeft2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeft2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeft2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeft2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeft3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeft3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeft3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeft3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeft4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeft4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeft4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeft4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeft5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeft5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeft5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeft5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeft5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeft5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftAuto(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftAutoString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftAuto(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftAuto(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftAuto(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftAutoString(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftAutoString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-auto"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-h1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-h2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-h3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-h4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-h5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegative1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegative1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegative1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegative1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-n1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegative2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegative2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegative2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegative2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-n2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegative3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegative3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegative3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegative3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-n3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegative4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegative4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegative4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegative4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-n4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegative5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegative5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegative5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegative5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegative5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-n5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegativeHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegativeHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegativeHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegativeHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-nh1"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegativeHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegativeHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegativeHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegativeHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-nh2"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegativeHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegativeHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegativeHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegativeHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-nh3"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegativeHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegativeHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegativeHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegativeHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-nh4"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginLeftNegativeHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginLeftNegativeHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginLeftNegativeHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginLeftNegativeHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginLeftNegativeHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "ml-nh5"
            : $"ml-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginRight0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRight0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRight0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRight0String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRight0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-0"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginRight1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRight1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRight1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRight1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRight1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginRight2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRight2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRight2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRight2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRight2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginRight3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRight3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRight3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRight3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRight3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginRight4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRight4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRight4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRight4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRight4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginRight5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRight5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRight5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRight5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRight5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRight5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginRightAuto(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightAutoString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightAuto(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightAuto(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightAuto(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightAutoString(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightAutoString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-auto"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-h1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-h2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-h3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-h4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginRightHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-h5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegative1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegative1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegative1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegative1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-n1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegative2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegative2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegative2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegative2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-n2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegative3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegative3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegative3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegative3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-n3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegative4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegative4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegative4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegative4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-n4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegative5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegative5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegative5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegative5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegative5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegative5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-n5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegativeHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegativeHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegativeHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegativeHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-nh1"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegativeHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegativeHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegativeHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegativeHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-nh2"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegativeHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegativeHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegativeHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegativeHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-nh3"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegativeHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegativeHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegativeHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegativeHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-nh4"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginRightNegativeHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginRightNegativeHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginRightNegativeHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginRightNegativeHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginRightNegativeHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mr-nh5"
            : $"mr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginX0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginX0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginX0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginX0String(responsiveBreakpoint));
            return className;
        }
        private static string MarginX0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-0"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginX1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginX1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginX1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginX1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginX1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-1"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginX2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginX2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginX2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginX2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginX2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-2"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginX3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginX3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginX3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginX3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginX3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-3"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginX4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginX4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginX4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginX4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginX4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-4"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginX5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginX5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginX5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginX5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginX5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginX5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-5"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginXAuto(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXAutoString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXAuto(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXAuto(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXAuto(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXAutoString(responsiveBreakpoint));
            return className;
        }
        private static string MarginXAutoString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-auto"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginXHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-h1"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginXHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-h2"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginXHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-h3"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginXHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-h4"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginXHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-h5"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegative1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegative1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegative1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegative1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegative1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-n1"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegative2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegative2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegative2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegative2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegative2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-n2"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegative3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegative3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegative3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegative3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegative3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-n3"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegative4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegative4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegative4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegative4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegative4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-n4"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegative5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegative5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegative5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegative5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegative5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegative5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-n5"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegativeHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegativeHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegativeHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegativeHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-nh1"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegativeHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegativeHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegativeHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegativeHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-nh2"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegativeHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegativeHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegativeHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegativeHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-nh3"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegativeHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegativeHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegativeHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegativeHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-nh4"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginXNegativeHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginXNegativeHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginXNegativeHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginXNegativeHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginXNegativeHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "mx-nh5"
            : $"mx-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName MarginY0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginY0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginY0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginY0String(responsiveBreakpoint));
            return className;
        }
        private static string MarginY0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-0"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName MarginY1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginY1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginY1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginY1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginY1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-1"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName MarginY2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginY2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginY2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginY2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginY2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-2"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName MarginY3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginY3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginY3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginY3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginY3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-3"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName MarginY4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginY4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginY4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginY4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginY4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-4"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName MarginY5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginY5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginY5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginY5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginY5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginY5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-5"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName MarginYAuto(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYAutoString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYAuto(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYAuto(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYAuto(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYAutoString(responsiveBreakpoint));
            return className;
        }
        private static string MarginYAutoString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-auto"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-auto";
        
        [RequiresManagedContext]
        public static ClassName MarginYHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-h1"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName MarginYHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-h2"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName MarginYHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-h3"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName MarginYHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-h4"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName MarginYHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-h5"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegative1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegative1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegative1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegative1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegative1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-n1"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n1";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegative2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegative2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegative2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegative2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegative2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-n2"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n2";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegative3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegative3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegative3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegative3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegative3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-n3"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n3";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegative4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegative4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegative4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegative4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegative4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-n4"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n4";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegative5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegative5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegative5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegative5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegative5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegative5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-n5"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-n5";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegativeHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegativeHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegativeHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegativeHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-nh1"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh1";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegativeHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegativeHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegativeHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegativeHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-nh2"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh2";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegativeHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegativeHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegativeHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegativeHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-nh3"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh3";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegativeHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegativeHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegativeHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegativeHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-nh4"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh4";
        
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => MarginYNegativeHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).MarginYNegativeHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName MarginYNegativeHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(MarginYNegativeHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string MarginYNegativeHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "my-nh5"
            : $"my-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-nh5";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTop0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTop0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTop0String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTop0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-0"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTop1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTop1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTop1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTop1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-1"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTop2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTop2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTop2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTop2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-2"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTop3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTop3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTop3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTop3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-3"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTop4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTop4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTop4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTop4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-4"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingTop5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTop5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTop5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTop5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTop5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTop5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-5"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTopHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTopHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTopHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTopHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-h1"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTopHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTopHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTopHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTopHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-h2"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTopHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTopHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTopHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTopHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-h3"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTopHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTopHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTopHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTopHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-h4"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingTopHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingTopHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingTopHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingTopHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingTopHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pt-h5"
            : $"pt-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottom0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottom0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottom0String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottom0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-0"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottom1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottom1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottom1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottom1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-1"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottom2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottom2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottom2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottom2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-2"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottom3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottom3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottom3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottom3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-3"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottom4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottom4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottom4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottom4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-4"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottom5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottom5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottom5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottom5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottom5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottom5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-5"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottomHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottomHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottomHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottomHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-h1"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottomHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottomHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottomHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottomHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-h2"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottomHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottomHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottomHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottomHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-h3"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottomHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottomHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottomHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottomHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-h4"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingBottomHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingBottomHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingBottomHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingBottomHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingBottomHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pb-h5"
            : $"pb-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeft0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeft0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeft0String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeft0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-0"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeft1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeft1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeft1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeft1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-1"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeft2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeft2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeft2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeft2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-2"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeft3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeft3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeft3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeft3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-3"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeft4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeft4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeft4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeft4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-4"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeft5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeft5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeft5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeft5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeft5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeft5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-5"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeftHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeftHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeftHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeftHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-h1"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeftHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeftHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeftHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeftHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-h2"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeftHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeftHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeftHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeftHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-h3"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeftHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeftHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeftHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeftHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-h4"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingLeftHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingLeftHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingLeftHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingLeftHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingLeftHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pl-h5"
            : $"pl-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRight0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRight0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRight0String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRight0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-0"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRight1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRight1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRight1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRight1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-1"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRight2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRight2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRight2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRight2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-2"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRight3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRight3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRight3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRight3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-3"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRight4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRight4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRight4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRight4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-4"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName PaddingRight5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRight5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRight5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRight5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRight5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRight5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-5"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRightHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRightHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRightHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRightHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-h1"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRightHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRightHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRightHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRightHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-h2"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRightHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRightHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRightHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRightHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-h3"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRightHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRightHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRightHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRightHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-h4"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingRightHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingRightHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingRightHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingRightHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingRightHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "pr-h5"
            : $"pr-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";
        
        [RequiresManagedContext]
        public static ClassName Padding0(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Padding0String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding0(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Padding0(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding0(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Padding0String(responsiveBreakpoint));
            return className;
        }
        private static string Padding0String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-0"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-0";
        
        [RequiresManagedContext]
        public static ClassName Padding1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Padding1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Padding1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Padding1String(responsiveBreakpoint));
            return className;
        }
        private static string Padding1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-1"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-1";
        
        [RequiresManagedContext]
        public static ClassName Padding2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Padding2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Padding2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Padding2String(responsiveBreakpoint));
            return className;
        }
        private static string Padding2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-2"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-2";
        
        [RequiresManagedContext]
        public static ClassName Padding3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Padding3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Padding3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Padding3String(responsiveBreakpoint));
            return className;
        }
        private static string Padding3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-3"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-3";
        
        [RequiresManagedContext]
        public static ClassName Padding4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Padding4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Padding4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Padding4String(responsiveBreakpoint));
            return className;
        }
        private static string Padding4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-4"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-4";
        
        [RequiresManagedContext]
        public static ClassName Padding5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => Padding5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Padding5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Padding5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(Padding5String(responsiveBreakpoint));
            return className;
        }
        private static string Padding5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-5"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-5";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf1(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingHalf1String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf1(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingHalf1(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf1(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingHalf1String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingHalf1String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-h1"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h1";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf2(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingHalf2String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf2(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingHalf2(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf2(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingHalf2String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingHalf2String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-h2"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h2";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf3(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingHalf3String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf3(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingHalf3(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf3(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingHalf3String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingHalf3String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-h3"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h3";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf4(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingHalf4String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf4(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingHalf4(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf4(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingHalf4String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingHalf4String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-h4"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h4";
        
        [RequiresManagedContext]
        public static ClassName PaddingHalf5(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => PaddingHalf5String(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf5(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).PaddingHalf5(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName PaddingHalf5(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(PaddingHalf5String(responsiveBreakpoint));
            return className;
        }
        private static string PaddingHalf5String(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "p-h5"
            : $"p-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-h5";

        [RequiresManagedContext]
        public static ClassName TextLeft(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextLeftString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLeft(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextLeft(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLeft(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextLeftString(responsiveBreakpoint));
            return className;
        }
        private static string TextLeftString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-left";
        
        [RequiresManagedContext]
        public static ClassName TextRight(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextRightString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextRight(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextRight(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextRight(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextRightString(responsiveBreakpoint));
            return className;
        }
        private static string TextRightString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-right";
        
        [RequiresManagedContext]
        public static ClassName TextCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextCenterString(responsiveBreakpoint));
            return className;
        }
        private static string TextCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-center";
        
        [RequiresManagedContext]
        public static ClassName TextUpperLeft(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextUpperLeftString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextUpperLeft(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextUpperLeft(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextUpperLeft(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextUpperLeftString(responsiveBreakpoint));
            return className;
        }
        private static string TextUpperLeftString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-upper-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-upper-left";
        
        [RequiresManagedContext]
        public static ClassName TextUpperRight(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextUpperRightString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextUpperRight(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextUpperRight(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextUpperRight(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextUpperRightString(responsiveBreakpoint));
            return className;
        }
        private static string TextUpperRightString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-upper-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-upper-right";
        
        [RequiresManagedContext]
        public static ClassName TextUpperCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextUpperCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextUpperCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextUpperCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextUpperCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextUpperCenterString(responsiveBreakpoint));
            return className;
        }
        private static string TextUpperCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-upper-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-upper-center";
        
        [RequiresManagedContext]
        public static ClassName TextMiddleLeft(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextMiddleLeftString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextMiddleLeft(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextMiddleLeft(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextMiddleLeft(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextMiddleLeftString(responsiveBreakpoint));
            return className;
        }
        private static string TextMiddleLeftString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-middle-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-middle-left";
        
        [RequiresManagedContext]
        public static ClassName TextMiddleRight(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextMiddleRightString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextMiddleRight(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextMiddleRight(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextMiddleRight(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextMiddleRightString(responsiveBreakpoint));
            return className;
        }
        private static string TextMiddleRightString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-middle-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-middle-right";
        
        [RequiresManagedContext]
        public static ClassName TextMiddleCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextMiddleCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextMiddleCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextMiddleCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextMiddleCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextMiddleCenterString(responsiveBreakpoint));
            return className;
        }
        private static string TextMiddleCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-middle-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-middle-center";
        
        [RequiresManagedContext]
        public static ClassName TextLowerLeft(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextLowerLeftString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLowerLeft(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextLowerLeft(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLowerLeft(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextLowerLeftString(responsiveBreakpoint));
            return className;
        }
        private static string TextLowerLeftString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-lower-left"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-lower-left";
        
        [RequiresManagedContext]
        public static ClassName TextLowerRight(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextLowerRightString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLowerRight(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextLowerRight(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLowerRight(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextLowerRightString(responsiveBreakpoint));
            return className;
        }
        private static string TextLowerRightString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-lower-right"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-lower-right";
        
        [RequiresManagedContext]
        public static ClassName TextLowerCenter(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => TextLowerCenterString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLowerCenter(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).TextLowerCenter(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName TextLowerCenter(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(TextLowerCenterString(responsiveBreakpoint));
            return className;
        }
        private static string TextLowerCenterString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "text-lower-center"
            : $"text-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}-lower-center";
        
        [RequiresManagedContext]
        public static ClassName Visible(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => VisibleString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Visible(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Visible(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Visible(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(VisibleString(responsiveBreakpoint));
            return className;
        }
        private static string VisibleString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "visible"
            : $"visible-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}";
        
        [RequiresManagedContext]
        public static ClassName Invisible(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => InvisibleString(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Invisible(this string className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => ((ClassName)className).Invisible(responsiveBreakpoint);
        [RequiresManagedContext]
        public static ClassName Invisible(this ClassName className, ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall)
        {
            className.Add(InvisibleString(responsiveBreakpoint));
            return className;
        }
        private static string InvisibleString(ResponsiveBreakpoint responsiveBreakpoint = ResponsiveBreakpoint.ExtraSmall) => responsiveBreakpoint is ResponsiveBreakpoint.ExtraSmall
            ? "invisible"
            : $"invisible-{GetResponsiveSizeUSSCode(responsiveBreakpoint)}";
        
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
        public static ClassName Overflow(UnityEngine.UIElements.Overflow value) => (new ClassName()).Overflow(value);
        [RequiresManagedContext]
        public static ClassName Overflow(this string className, UnityEngine.UIElements.Overflow value) => ((ClassName)className).Overflow(value);
        [RequiresManagedContext]
        public static ClassName Overflow(this ClassName className, UnityEngine.UIElements.Overflow value) => value switch
        {
            UnityEngine.UIElements.Overflow.Visible => OverflowVisible(className),
            UnityEngine.UIElements.Overflow.Hidden => OverflowHidden(className),
        };

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
        public static ClassName Border0() => Border0String;
        [RequiresManagedContext]
        public static ClassName Border0(this string className) => ((ClassName)className).Border0();
        [RequiresManagedContext]
        public static ClassName Border0(this ClassName className)
        {
            className.Add(Border0String);
            return className;
        }
        private const string Border0String = "border-0";
        
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
        public static ClassName TextBodyEmphasis() => TextBodyEmphasisString;
        [RequiresManagedContext]
        public static ClassName TextBodyEmphasis(this string className) => ((ClassName)className).TextBodyEmphasis();
        [RequiresManagedContext]
        public static ClassName TextBodyEmphasis(this ClassName className)
        {
            className.Add(TextBodyEmphasisString);
            return className;
        }
        private const string TextBodyEmphasisString = "text-body-emphasis";
        
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
        public static ClassName RoundedTop0(this string className) => ((ClassName)className).RoundedTop0();
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
        public static ClassName RoundedTop1(this string className) => ((ClassName)className).RoundedTop1();
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
        public static ClassName RoundedTop2(this string className) => ((ClassName)className).RoundedTop2();
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
        public static ClassName RoundedTop3(this string className) => ((ClassName)className).RoundedTop3();
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
        public static ClassName RoundedTop4(this string className) => ((ClassName)className).RoundedTop4();
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
        public static ClassName RoundedTop5(this string className) => ((ClassName)className).RoundedTop5();
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
        public static ClassName RoundedTopCircle(this string className) => ((ClassName)className).RoundedTopCircle();
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
        public static ClassName RoundedBottom0(this string className) => ((ClassName)className).RoundedBottom0();
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
        public static ClassName RoundedBottom1(this string className) => ((ClassName)className).RoundedBottom1();
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
        public static ClassName RoundedBottom2(this string className) => ((ClassName)className).RoundedBottom2();
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
        public static ClassName RoundedBottom3(this string className) => ((ClassName)className).RoundedBottom3();
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
        public static ClassName RoundedBottom4(this string className) => ((ClassName)className).RoundedBottom4();
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
        public static ClassName RoundedBottom5(this string className) => ((ClassName)className).RoundedBottom5();
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
        public static ClassName RoundedBottomCircle(this string className) => ((ClassName)className).RoundedBottomCircle();
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
        public static ClassName RoundedLeft0(this string className) => ((ClassName)className).RoundedLeft0();
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
        public static ClassName RoundedLeft1(this string className) => ((ClassName)className).RoundedLeft1();
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
        public static ClassName RoundedLeft2(this string className) => ((ClassName)className).RoundedLeft2();
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
        public static ClassName RoundedLeft3(this string className) => ((ClassName)className).RoundedLeft3();
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
        public static ClassName RoundedLeft4(this string className) => ((ClassName)className).RoundedLeft4();
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
        public static ClassName RoundedLeft5(this string className) => ((ClassName)className).RoundedLeft5();
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
        public static ClassName RoundedLeftCircle(this string className) => ((ClassName)className).RoundedLeftCircle();
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
        public static ClassName RoundedRight0(this string className) => ((ClassName)className).RoundedRight0();
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
        public static ClassName RoundedRight1(this string className) => ((ClassName)className).RoundedRight1();
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
        public static ClassName RoundedRight2(this string className) => ((ClassName)className).RoundedRight2();
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
        public static ClassName RoundedRight3(this string className) => ((ClassName)className).RoundedRight3();
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
        public static ClassName RoundedRight4(this string className) => ((ClassName)className).RoundedRight4();
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
        public static ClassName RoundedRight5(this string className) => ((ClassName)className).RoundedRight5();
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
        public static ClassName RoundedRightCircle(this string className) => ((ClassName)className).RoundedRightCircle();
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
        public static ClassName TextWrap(this string className) => ((ClassName)className).TextWrap();
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
        public static ClassName TextNowrap(this string className) => ((ClassName)className).TextNowrap();
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
        public static ClassName FontSize1(this string className) => ((ClassName)className).FontSize1();
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
        public static ClassName FontSize2(this string className) => ((ClassName)className).FontSize2();
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
        public static ClassName FontSize3(this string className) => ((ClassName)className).FontSize3();
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
        public static ClassName FontSize4(this string className) => ((ClassName)className).FontSize4();
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
        public static ClassName FontSize5(this string className) => ((ClassName)className).FontSize5();
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
        public static ClassName FontSize6(this string className) => ((ClassName)className).FontSize6();
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
        public static ClassName FontStyleBold(this string className) => ((ClassName)className).FontStyleBold();
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
        public static ClassName FontStyleItalic(this string className) => ((ClassName)className).FontStyleItalic();
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
        public static ClassName FontStyleNormal(this string className) => ((ClassName)className).FontStyleNormal();
        [RequiresManagedContext]
        public static ClassName FontStyleNormal(this ClassName className)
        {
            className.Add(FontStyleNormalString);
            return className;
        }
        private const string FontStyleNormalString = "fst-normal";
        
        [RequiresManagedContext]
        public static ClassName PointerDetection() => PointerDetectionString;
        [RequiresManagedContext]
        public static ClassName PointerDetection(this string className) => ((ClassName)className).PointerDetection();
        [RequiresManagedContext]
        public static ClassName PointerDetection(this ClassName className)
        {
            className.Add(PointerDetectionString);
            return className;
        }
        private const string PointerDetectionString = "pointer-detection";
        
        [RequiresManagedContext]
        public static ClassName PointerIgnore() => PointerIgnoreString;
        [RequiresManagedContext]
        public static ClassName PointerIgnore(this string className) => ((ClassName)className).PointerIgnore();
        [RequiresManagedContext]
        public static ClassName PointerIgnore(this ClassName className)
        {
            className.Add(PointerIgnoreString);
            return className;
        }
        private const string PointerIgnoreString = "pointer-ignore";
        
        [RequiresManagedContext]
        public static ClassName PointerNone() => PointerNoneString;
        [RequiresManagedContext]
        public static ClassName PointerNone(this string className) => ((ClassName)className).PointerNone();
        [RequiresManagedContext]
        public static ClassName PointerNone(this ClassName className)
        {
            className.Add(PointerNoneString);
            return className;
        }
        private const string PointerNoneString = "pointer-none";
        
        [RequiresManagedContext]
        public static ClassName Pointer(PointerDetectionMode value) => (new ClassName()).Pointer(value);
        [RequiresManagedContext]
        public static ClassName Pointer(this string className, PointerDetectionMode value) => ((ClassName)className).Pointer(value);
        [RequiresManagedContext]
        public static ClassName Pointer(this ClassName className, PointerDetectionMode value) => value switch
        {
            PointerDetectionMode.Ignore => PointerIgnore(className),
            PointerDetectionMode.Rect => PointerDetection(className),
            PointerDetectionMode.ForceIgnore => PointerNone(className),
            _ => default
        };
        
        
        
        
        
        
        
        private static string GetResponsiveSizeUSSCode(ResponsiveBreakpoint responsiveBreakpoint) =>
            responsiveBreakpoint switch
            {
                ResponsiveBreakpoint.Small => "sm",
                ResponsiveBreakpoint.Medium => "md",
                ResponsiveBreakpoint.Large => "lg",
                ResponsiveBreakpoint.ExtraLarge => "xl",
                ResponsiveBreakpoint.ExtraExtraLarge => "xxl"
            };
    }
}