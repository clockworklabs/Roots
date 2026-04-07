using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public class TextSample : ISample
    {
        int ISample.Order => 1;
        string ISample.Name => "Text";
        string ISample.Icon => FontAwesome.FA_Font.Unicode;

        Element ISample.Factory() => Col.Create(
            gap: 8,
            children: new Children
            {
                H1.Create(text: "H1. Heading 1"),
                H2.Create(text: "H2. Heading 2"),
                H3.Create(text: "H3. Heading 3"),
                H4.Create(text: "H4. Heading 4"),
                H5.Create(text: "H5. Heading 5"),
                H6.Create(text: "H6. Heading 6"),
                Body.Create(text: "Body. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.")
            });
    }
}