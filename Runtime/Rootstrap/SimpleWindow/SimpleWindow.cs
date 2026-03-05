using RishUI;

namespace Roots.Rootstrap
{
    public partial class SimpleWindow : RishElement<SimpleWindowProps>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.style.pointerDetection = PointerDetectionMode.Rect;
            
            return Window.Create(
                open: Props.open,
                draggable: !Props.fixedPosition,
                alwaysOnTop: Props.alwaysOnTop,
                content: Card.Create(
                    name: descriptor.name,
                    className: descriptor.className,
                    style: descriptor.style,
                    children: new Children
                    {
                        WindowHeader.Create(content: CardHeader.Create(children: Props.title)),
                        CardBody.Create(children: Props.content)
                    }));
        }
    }

    [RishValueType]
    public struct SimpleWindowProps
    {
        [Expand]
        public VisualAttributes descriptor;
        public bool open;
        public bool fixedPosition;
        public bool alwaysOnTop;
        public RishString title;
        public Element content;
    }
}
