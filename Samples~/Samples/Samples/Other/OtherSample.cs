using System.Linq;
using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class OtherSample : ISample
    {
        int ISample.Order => 9;
        string ISample.Name => "Other";
        string ISample.Icon => FontAwesome.FA_Icons.Unicode;

        Element ISample.Factory() => Content.Create();
    }
}