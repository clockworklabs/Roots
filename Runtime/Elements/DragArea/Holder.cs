using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    partial class DragArea
    {
        public partial class Holder : RishElement<HolderProps>, IMountingListener
        {
            private DragArea Area { get; set; }

            public Holder()
            {
                RegisterCallback<VisualChangeEvent>(OnVisualChange);
            }

            void IMountingListener.ElementDidMount()
            {
                Area = GetFirstAncestorOfType<DragArea>();
            }
            void IMountingListener.ElementWillUnmount()
            {
                Area = null;
            }

            protected override Element Render() => Div.Create(
                name: Props.descriptor.name,
                className: Props.descriptor.className,
                style: Props.descriptor.style
                    .PositionAbsolute()
                    .Left(Props.offset.x)
                    .Top(Props.offset.y)
                    .Scale(Props.scale)
                    .TransformOriginTopLeft(),
                children: Props.content);

            private void OnVisualChange(VisualChangeEvent evt) => Area?.SetContentSize(ContentRect.size);
        }

        [RishValueType]
        public struct HolderProps
        {
            public VisualAttributes descriptor;
            public Element content;
            public Vector2 offset;
            public Vector2 scale;
        }
    }
}