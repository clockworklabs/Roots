using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public class CardsSample : ISample
    {
        int ISample.Order => 5;
        string ISample.Name => "Cards";
        string ISample.Icon => FontAwesome.FA_IdCard.Unicode;
        
        Element ISample.Factory() => Grid.Create(
            xs: 1,
            md: 2,
            xl: 3,
            xsGutter: 8,
            lgGutter: 16,
            cols: new()
            {
                Card.Create(key: 1, body: "This is some text within a card body."),
                Card.Create(
                    key: 2,
                    body: Col.Create(
                        gap: 8,
                        children: new Children
                        {
                            CardTitle.Create(content: H5.Create(text: "Card title")),
                            CardSubtitle.Create(content: H6.Create(text: "Card subtitle")),
                            Body.Create(text: "Some quick example text to build on the card title and make up the bulk of the card's content.")
                        })),
                Card.Create(key: 3, header: "Featured", body: Body.Create(text: "Some quick example text to build on the card title and make up the bulk of the card's content.")),
                Card.Create(key: 4, body: Body.Create(text: "Some quick example text to build on the card title and make up the bulk of the card's content."), footer: "Card footer"),
                Card.Create(
                    key: 5,
                    header: H5.Create(text: "Featured"),
                    body: Col.Create(
                        gap: 8,
                        children: new Children
                        {
                            CardTitle.Create(content: H5.Create(text: "Special title treatment")),
                            Body.Create(text: "With supporting text below as a natural lead-in to additional content.")
                        })),
                Card.Create(
                    key: 6,
                    className: "text-center",
                    header: "Featured",
                    body: Col.Create(
                        gap: 8,
                        children: new Children
                        {
                            CardTitle.Create(content: H5.Create(text: "Special title treatment")),
                            Body.Create(text: "With supporting text below as a natural lead-in to additional content.")
                        }),
                    footer: "2 days ago"),
                Card.Create(
                    key: 7,
                    topImage: Image.Create(spriteAddress: "placeholder-1320x440"),
                    body: Col.Create(
                        gap: 8,
                        children: new Children
                        {
                            CardTitle.Create(content: H5.Create(text: "Card title")),
                            Body.Create(text: "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."),
                            Small.Create(className: "text-body-secondary", text: "Last updated 3 mins ago")
                        })),
                Card.Create(
                    key: 8,
                    body: Col.Create(
                        gap: 8,
                        children: new Children
                        {
                            CardTitle.Create(content: H5.Create(text: "Card title")),
                            Body.Create(text: "Some quick example text to build on the card title and make up the bulk of the card's content.")
                        }),
                    bottomImage: Image.Create(spriteAddress: "placeholder-1320x440")),
                Card.Create(
                    key: 9,
                    image: Image.Create(spriteAddress: "placeholder-200x200"),
                    body: Col.Create(
                        gap: 8,
                        children: new Children
                        {
                            CardTitle.Create(content: H5.Create(text: "Card title")),
                            Body.Create(text: "Some quick example text to build on the card title and make up the bulk of the card's content.")
                        })),
            });
        
        [RishValueType]
        public struct CardSubtitleProps
        {
            public RishString text;
        }
    }
}