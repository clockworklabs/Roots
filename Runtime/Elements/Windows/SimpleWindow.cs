using System;
using RishUI;
using Unity.Collections;

namespace Roots
{
    public partial class SimpleWindow : RishElement<SimpleWindowProps, SimpleWindowState>
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
                    // utilities: Props.utilities,
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
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public bool open;
        public bool fixedPosition;
        public bool alwaysOnTop;
        public FixedString128Bytes title;
        public Element content;

        [IgnoreComparison]
        public Action closeAction;
    }

    [RishValueType]
    public struct SimpleWindowState { }
}
