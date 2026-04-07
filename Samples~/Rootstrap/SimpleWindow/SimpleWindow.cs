using RishUI;

namespace Roots.Rootstrap
{
    public partial class SimpleWindow : RishElement<SimpleWindowProps>
    {
        protected override Element Render()
        {
            var attributes = Props.attributes;
            attributes.style.pointerDetection = PointerDetectionMode.Rect;
            
            return Window.Create(
                open: Props.open,
                draggable: !Props.fixedPosition,
                alwaysOnTop: Props.alwaysOnTop,
                content: Card.Create(
                    name: attributes.name,
                    className: attributes.className,
                    style: attributes.style,
                    header: WindowHeader.Create(content: Props.title),
                    body: Props.content));
        }
    }

    [RishValueType]
    public struct SimpleWindowProps
    {
        [Expand]
        public VisualAttributes attributes;
        public bool open;
        public bool fixedPosition;
        public bool alwaysOnTop;
        public RishString title;
        public Element content;
    }
}
