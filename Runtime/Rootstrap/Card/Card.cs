using RishUI;

namespace Roots.Rootstrap
{
    public partial class Card : RishElement<CardProps, CardState>
    {
        protected override Element Render() => Div.Create(
            attributes: Props.attributes + "card",
            children: new Children
            {
                Header.Create(content: Props.header),
                TopImage.Create(content: Props.topImage),
                Image.Create(content: Props.image, onValid: SappyState.SetIsImageCard),
                Body.Create(content: Props.body, isImageOverlay: State.isImageCard),
                BottomImage.Create(content: Props.bottomImage),
                Footer.Create(content: Props.footer),
            });
    }

    [RishValueType]
    public struct CardProps
    {
        [Expand]
        public VisualAttributes attributes;

        public Element header;
        public Element topImage;
        public Element image;
        public Element body;
        public Element bottomImage;
        public Element footer;
    }

    [RishValueType]
    public struct CardState
    {
        public bool isImageCard;
    }
}
