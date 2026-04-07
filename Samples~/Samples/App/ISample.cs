using RishUI;
using RishUI.MemoryManagement;

namespace RootsSamples
{
    public interface ISample
    {
        int Order { get; }
        string Name { get; }
        string Icon { get; }

        bool AutoScrollView => true;

        [RequiresManagedContext]
        Element Factory();
    }
}