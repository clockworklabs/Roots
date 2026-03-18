using RishUI;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class ButtonsSample : ISample
    {
        int ISample.Order => 3;
        string ISample.Name => "Buttons";
        string ISample.Icon => FontAwesome.FA_HandPointer.Unicode;

        Element ISample.Factory() => Content.Create();
    }
}