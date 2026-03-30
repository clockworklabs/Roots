using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class ImagesSample : ISample
    {
        int ISample.Order => 2;
        string ISample.Name => "Images";
        string ISample.Icon => FontAwesome.FA_Image.Unicode;
        
        Element ISample.Factory() => Col.Create(
            gap: 16,
            children: new Children
            {
                Col.Create(
                    gap: 8,
                    children: new Children
                    {
                        H4.Create(text: "Responsive"),
                        Image.Create(className: "img-fluid", spriteAddress: "placeholder-1320x440"),
                    }),
                Col.Create(
                    gap: 8,
                    children: new Children
                    {
                        H4.Create(text: "Thumbnail"),
                        Image.Create(
                            className: "img-thumbnail",
                            style: new Style
                            {
                                maxWidth = 200
                            },
                            spriteAddress: "placeholder-200x200"),
                    }),
                Col.Create(
                    gap: 8,
                    children: new Children
                    {
                        H4.Create(text: "Via Props"),
                        Image.Create(
                            className: new ClassName
                            {
                                "img-thumbnail",
                                "image-from-props"
                            },
                            width: 200),
                    }),
            });
    }
}