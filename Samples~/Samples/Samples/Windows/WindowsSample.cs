using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public class WindowsSample : ISample
    {
        int ISample.Order => 8;
        string ISample.Name => "Windows";
        string ISample.Icon => FontAwesome.FA_WindowRestore.Unicode;

        bool ISample.AutoScrollView => false;

        Element ISample.Factory() => WindowsContext.Create(
            className: new ClassName
            {
                "absolute-fill",
                "overflow-hidden"
            },
            children: new Children
            {
                SimpleWindow.Create(1,
                    open: true,
                    className: new ClassName { "absolute-fill", "m-5" },
                    title: "Window 1",
                    content: Image.Create(className: "img-fluid", spriteAddress: "placeholder-1320x440")),
                SimpleWindow.Create(2,
                    open: true,
                    style: new Style
                    {
                        width = 200
                    },
                    title: "Window 2",
                    content: Image.Create(className: "img-fluid", spriteAddress: "placeholder-200x200"))
            });
    }
}