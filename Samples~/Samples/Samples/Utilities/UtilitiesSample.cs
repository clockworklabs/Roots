using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class UtilitiesSample : ISample
    {
        int ISample.Order => 10;
        string ISample.Name => "Utilities";
        string ISample.Icon => FontAwesome.FA_Toolbox.Unicode;

        Element ISample.Factory() => Col.Create(
            gap: 16,
            children: new Children
            {
                Group.Create(
                    title: "Background",
                    children: Grid.Create(
                        xs: 1,
                        sm: 2,
                        md: 3,
                        lg: 4,
                        xl: 5,
                        xxl: 6,
                        xsGutter: 4,
                        lgGutter: 8,
                        cols: new()
                        {
                            Example.Create(
                                className: Utilities
                                    .BackgroundPrimary()
                                    .TextWhite(),
                                text: ".bg-primary"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundPrimarySubtle()
                                    .TextPrimaryEmphasis(),
                                text: ".bg-primary-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundSecondary()
                                    .TextWhite(),
                                text: ".bg-secondary"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundSecondarySubtle()
                                    .TextSecondaryEmphasis(),
                                text: ".bg-secondary-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundSuccess()
                                    .TextWhite(),
                                text: ".bg-success"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundSuccessSubtle()
                                    .TextSuccessEmphasis(),
                                text: ".bg-success-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundDanger()
                                    .TextWhite(),
                                text: ".bg-danger"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundDangerSubtle()
                                    .TextDangerEmphasis(),
                                text: ".bg-danger-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundWarning()
                                    .TextDark(),
                                text: ".bg-warning"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundWarningSubtle()
                                    .TextWarningEmphasis(),
                                text: ".bg-warning-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundInfo()
                                    .TextDark(),
                                text: ".bg-info"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundInfoSubtle()
                                    .TextInfoEmphasis(),
                                text: ".bg-info-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundLight()
                                    .TextDark(),
                                text: ".bg-light"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundLightSubtle()
                                    .TextLightEmphasis(),
                                text: ".bg-light-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundDark()
                                    .TextWhite(),
                                text: ".bg-dark"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundDarkSubtle()
                                    .TextDangerEmphasis(),
                                text: ".bg-dark-subtle"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundBody()
                                    .TextBody(),
                                text: ".bg-body"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundBodySecondary()
                                    .TextBody(),
                                text: ".bg-body-secondary"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundBodyTertiary()
                                    .TextBody(),
                                text: ".bg-body-tertiary"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundBlack()
                                    .TextWhite(),
                                text: ".bg-black"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundWhite()
                                    .TextDark(),
                                text: ".bg-white"),
                            Example.Create(
                                className: Utilities
                                    .BackgroundTransparent()
                                    .TextBody(),
                                text: ".bg-transparent"),
                        })),
                Group.Create(
                    title: "Borders",
                    children: new Children
                    {
                        Grid.Create(
                        xs: 1,
                        sm: 2,
                        md: 3,
                        lg: 4,
                        xl: 5,
                        xxl: 6,
                        xsGutter: 4,
                        lgGutter: 8,
                        cols: new()
                        {
                            Group.Create(
                                title: "Additive",
                                children: new Children
                                {
                                    Example.Create(className: Utilities.Border(), text: ".border"),
                                    Example.Create(className: Utilities.BorderTop(), text: ".border-top"),
                                    Example.Create(className: Utilities.BorderRight(), text: ".border-right"),
                                    Example.Create(className: Utilities.BorderBottom(), text: ".border-bottom"),
                                    Example.Create(className: Utilities.BorderLeft(), text: ".border-left"),
                                }),
                            Group.Create(
                                title: "Subtractive",
                                children: new Children
                                {
                                    Example.Create(className: Utilities.Border().Border0(), text: ".border .border-0"),
                                    Example.Create(className: Utilities.Border().BorderTop0(), text: ".border .border-top-0"),
                                    Example.Create(className: Utilities.Border().BorderRight0(), text: ".border .border-right-0"),
                                    Example.Create(className: Utilities.Border().BorderBottom0(), text: ".border .border-bottom-0"),
                                    Example.Create(className: Utilities.Border().BorderLeft0(), text: ".border .border-left-0"),
                                }),
                            Group.Create(
                                title: "Width",
                                children: new Children
                                {
                                    Example.Create(className: Utilities.Border().Border1(), text: ".border .border-1"),
                                    Example.Create(className: Utilities.Border().Border2(), text: ".border .border-2"),
                                    Example.Create(className: Utilities.Border().Border3(), text: ".border .border-3"),
                                    Example.Create(className: Utilities.Border().Border4(), text: ".border .border-4"),
                                    Example.Create(className: Utilities.Border().Border5(), text: ".border .border-5"),
                                }),
                            Group.Create(
                                title: "Radius",
                                children: new Children
                                {
                                    Example.Create(className: Utilities.Rounded(), text: ".rounded"),
                                    Example.Create(className: Utilities.RoundedTop(), text: ".rounded-top"),
                                    Example.Create(className: Utilities.RoundedRight(), text: ".rounded-right"),
                                    Example.Create(className: Utilities.RoundedBottom(), text: ".rounded-bottom"),
                                    Example.Create(className: Utilities.RoundedLeft(), text: ".rounded-left"),
                                }),
                            Group.Create(
                                title: "Sizes",
                                children: new Children
                                {
                                    Example.Create(className: Utilities.Rounded1(), text: ".rounded-1"),
                                    Example.Create(className: Utilities.Rounded2(), text: ".rounded-2"),
                                    Example.Create(className: Utilities.Rounded3(), text: ".rounded-3"),
                                    Example.Create(className: Utilities.Rounded4(), text: ".rounded-4"),
                                    Example.Create(className: Utilities.Rounded5(), text: ".rounded-5"),
                                }),
                        }),
                        Group.Create(
                            title: "Color",
                            children: Grid.Create(
                                xs: 1,
                                sm: 2,
                                md: 3,
                                lg: 4,
                                xl: 5,
                                xxl: 6,
                                xsGutter: 4,
                                lgGutter: 8,
                                cols: new()
                                {
                                    Example.Create(className: Utilities.Border().BorderPrimary(), text: ".border .border-primary"),
                                    Example.Create(className: Utilities.Border().BorderPrimarySubtle(), text: ".border .border-primary-subtle"),
                                    Example.Create(className: Utilities.Border().BorderSecondary(), text: ".border .border-secondary"),
                                    Example.Create(className: Utilities.Border().BorderSecondarySubtle(), text: ".border .border-secondary-subtle"),
                                    Example.Create(className: Utilities.Border().BorderSuccess(), text: ".border .border-success"),
                                    Example.Create(className: Utilities.Border().BorderSuccessSubtle(), text: ".border .border-success-subtle"),
                                    Example.Create(className: Utilities.Border().BorderDanger(), text: ".border .border-danger"),
                                    Example.Create(className: Utilities.Border().BorderDangerSubtle(), text: ".border .border-danger-subtle"),
                                    Example.Create(className: Utilities.Border().BorderWarning(), text: ".border .border-warning"),
                                    Example.Create(className: Utilities.Border().BorderWarningSubtle(), text: ".border .border-warning-subtle"),
                                    Example.Create(className: Utilities.Border().BorderInfo(), text: ".border .border-info"),
                                    Example.Create(className: Utilities.Border().BorderInfoSubtle(), text: ".border .border-info-subtle"),
                                    Example.Create(className: Utilities.Border().BorderLight(), text: ".border .border-light"),
                                    Example.Create(className: Utilities.Border().BorderLightSubtle(), text: ".border .border-light-subtle"),
                                    Example.Create(className: Utilities.Border().BorderDark(), text: ".border .border-dark"),
                                    Example.Create(className: Utilities.Border().BorderDarkSubtle(), text: ".border .border-dark-subtle"),
                                    Example.Create(className: Utilities.Border().BorderBlack(), text: ".border .border-black"),
                                    Example.Create(className: Utilities.Border().BorderWhite(), text: ".border .border-white")
                                }))
                    }),
                Group.Create(
                    title: "Text Color",
                    children: Grid.Create(
                        xs: 1,
                        sm: 2,
                        md: 3,
                        lg: 4,
                        xl: 5,
                        xxl: 6,
                        xsGutter: 4,
                        lgGutter: 8,
                        cols: new()
                        {
                            Example.Create(className: Utilities.TextPrimary(), text: ".text-primary"),
                            Example.Create(className: Utilities.TextPrimaryEmphasis(), text: ".text-primary-emphasis"),
                            Example.Create(className: Utilities.TextSecondary(), text: ".text-secondary"),
                            Example.Create(className: Utilities.TextSecondaryEmphasis(), text: ".text-secondary-emphasis"),
                            Example.Create(className: Utilities.TextSuccess(), text: ".text-success"),
                            Example.Create(className: Utilities.TextSuccessEmphasis(), text: ".text-success-emphasis"),
                            Example.Create(className: Utilities.TextDanger(), text: ".text-danger"),
                            Example.Create(className: Utilities.TextDangerEmphasis(), text: ".text-danger-emphasis"),
                            Example.Create(className: Utilities.TextWarning(), text: ".text-warning"),
                            Example.Create(className: Utilities.TextWarningEmphasis(), text: ".text-warning-emphasis"),
                            Example.Create(className: Utilities.TextInfo(), text: ".text-info"),
                            Example.Create(className: Utilities.TextInfoEmphasis(), text: ".text-info-emphasis"),
                            Example.Create(className: Utilities.TextLight(), text: ".text-light"),
                            Example.Create(className: Utilities.TextLightEmphasis(), text: ".text-light-emphasis"),
                            Example.Create(className: Utilities.TextDark(), text: ".text-dark"),
                            Example.Create(className: Utilities.TextDarkEmphasis(), text: ".text-dark-emphasis"),
                            Example.Create(className: Utilities.TextBody(), text: ".text-body"),
                            Example.Create(className: Utilities.TextBodyEmphasis(), text: ".text-body-emphasis"),
                            Example.Create(className: Utilities.TextBodySecondary(), text: ".text-body-secondary"),
                            Example.Create(className: Utilities.TextBodyTertiary(), text: ".text-body-tertiary"),
                            Example.Create(className: Utilities.TextBlack(), text: ".text-black"),
                            Example.Create(className: Utilities.TextWhite(), text: ".text-white"),
                            Example.Create(className: Utilities.TextBlack50(), text: ".text-black-50"),
                            Example.Create(className: Utilities.TextWhite50(), text: ".text-white-50"),
                        }))
            });
    }
}