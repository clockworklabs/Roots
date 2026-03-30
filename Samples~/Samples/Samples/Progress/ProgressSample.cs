using RishUI;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class ProgressSample : ISample
    {
        int ISample.Order => 7;
        string ISample.Name => "Progress";
        string ISample.Icon => FontAwesome.FA_BarsProgress.Unicode;

        Element ISample.Factory() => Content.Create();
    }
}