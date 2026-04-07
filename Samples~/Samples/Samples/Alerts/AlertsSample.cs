using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public class AlertsSample : ISample
    {
        int ISample.Order => 4;
        string ISample.Name => "Alerts";
        string ISample.Icon => FontAwesome.FA_TriangleExclamation.Unicode;

        Element ISample.Factory() => Col.Create(
            gap: 16,
            children: new Children
            {
                Grid.Create(
                    xs: 1,
                    md: 2,
                    xsGutter: 16,
                    cols: new()
                    {
                        new Children
                        {
                            Alert.Create(context: Alert.Context.Primary, children: "A simple primary alert—check it out!"),
                            Alert.Create(context: Alert.Context.Secondary, children: "A simple secondary alert—check it out!"),
                            Alert.Create(context: Alert.Context.Success, children: "A simple success alert—check it out!"),
                            Alert.Create(context: Alert.Context.Danger, children: "A simple danger alert—check it out!"),
                        },
                        new Children
                        {
                            Alert.Create(context: Alert.Context.Warning, children: "A simple warning alert—check it out!"),
                            Alert.Create(context: Alert.Context.Info, children: "A simple info alert—check it out!"),
                            Alert.Create(context: Alert.Context.Light, children: "A simple light alert—check it out!"),
                            Alert.Create(context: Alert.Context.Dark, children: "A simple dark alert—check it out!")
                        },
                    }),
                Alert.Create(
                    context: Alert.Context.Success,
                    children: new Children
                    {
                        H1.Create(text: "Well done!"),
                        Body.Create(text: "Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content."),
                        Rule.Create(),
                        Body.Create(text: "Whenever you need to, be sure to use margin utilities to keep things nice and tidy.")
                    })
            });
    }
}