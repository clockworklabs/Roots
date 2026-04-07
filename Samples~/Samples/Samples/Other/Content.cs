using System.Linq;
using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class OtherSample
    {
        public partial class Content : RishElement<NoProps, ContentState>
        {
            protected override Element Render() => Col.Create(
                gap: 16,
                children: new Children
                {
                    Group.Create(
                        title: "Rules",
                        children: Col.Create(
                            separator: Rule.Create(),
                            children: new Children
                            {
                                Unit.Create(),
                                Unit.Create(),
                                Alert.Create(
                                    context: Alert.Context.Success,
                                    children: Col.Create(
                                        gap: 4,
                                        children: new Children
                                        {
                                            Body.Create(text: "Rules inherit the text color of the parent container."),
                                            Row.Create(
                                                separator: Rule.Create(),
                                                children: new Children
                                                {
                                                    Unit.Create(),
                                                    Unit.Create(),
                                                    Unit.Create()
                                                })
                                        }))
                            })),
                    Group.Create(
                        title: "Spinners",
                        children: new Children
                        {
                            Row.Create(
                                className: Utilities.AlignItemsCenter(),
                                gap: 8,
                                children: new Children
                                {
                                    Spinner.Create(size: Spinner.Size.Small),
                                    Spinner.Create(type: Spinner.Type.Grow),
                                }),
                            Alert.Create(
                                context: Alert.Context.Primary,
                                children: Col.Create(
                                    gap: 4,
                                    children: new Children
                                    {
                                        Body.Create(text: "Spinners can inherit the text color of the parent container."),
                                        Row.Create(
                                            className: Utilities.AlignItemsCenter(),
                                            gap: 8,
                                            children: new Children
                                            {
                                                Spinner.Create(autoColor: true),
                                                Spinner.Create(type: Spinner.Type.Grow, autoColor: true),
                                                Spinner.Create(className: Utilities.BackgroundDanger(), type: Spinner.Type.Grow),
                                            })
                                    }))
                            }),
                    Group.Create(
                        title: "Tooltips",
                        children: SimpleTooltip.Create(
                            tooltip: "This is an image",
                            content: Image.Create(
                                className: "img-thumbnail",
                                style: new Style
                                {
                                    maxWidth = 200,
                                    pointerDetection = PointerDetectionMode.Rect
                                },
                                spriteAddress: "placeholder-200x200"))),
                    Group.Create(
                        title: "Dropdown",
                        children: Row.Create(
                            className: Utilities.FlexWrap(),
                            gap: 8,
                            children: new Children
                            {
                                SimpleDropdown.Create(
                                    index: State.dropdownAIndex,
                                    action: SappyState.SetDropdownAIndex,
                                    options: new RishList<RishString>
                                    {
                                        "Option A",
                                        "Option B",
                                        "Option C",
                                        "Option D",
                                        "Option E",
                                        "Option F",
                                        "Option G",
                                        "Option H",
                                        "Option I",
                                        "Option J",
                                        "Option K",
                                        "Option L",
                                        "Option M",
                                        "Option N",
                                        "Option O",
                                        "Option P",
                                        "Option Q",
                                        "Option R",
                                        "Option S",
                                        "Option T",
                                        "Option U",
                                        "Option V",
                                        "Option W",
                                        "Option X",
                                        "Option Y",
                                        "Option Z",
                                    }),
                                SimpleDropdown.Create(
                                    index: State.dropdownBIndex,
                                    action: SappyState.SetDropdownBIndex,
                                    placeholder: "Placeholder Value",
                                    options: new RishList<RishString>
                                    {
                                        "An Option",
                                        "A Considerably Longer Option",
                                        "Another Option",
                                    })
                            })),
                    Group.Create(
                        title: "Icons",
                        children: new Children
                        {
                            Body.Create(text: $"We can have inline icon like this one: {Icon.Solid(FontAwesome.FA_Award)}. Or this one: {Icon.Regular(FontAwesome.FA_Crown)}."),
                            Row.Create(className: Utilities.FlexWrap(), gap: 8, children: FontAwesome.All.Select(icon => Icon.Create(unicode: icon.Unicode)).ToArray()),
                        })
                });
        }

        [RishValueType]
        public struct ContentState
        {
            public int dropdownAIndex;
            [DefaultValue(-1)]
            public int dropdownBIndex;
        }
    }
}