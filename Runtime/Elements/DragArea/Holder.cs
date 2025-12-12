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

            void IMountingListener.ComponentDidMount()
            {
                Area = GetFirstAncestorOfType<DragArea>();
            }
            void IMountingListener.ComponentWillUnmount()
            {
                Area = null;
            }

            protected override Element Render() => Div.Create(
                name: Props.descriptor.name,
                className: Props.descriptor.className + "position-absolute",
                style: Props.descriptor.style + new Style
                {
                    left = Props.offset.x,
                    top = Props.offset.y,
                    scale = new Vector3(Props.scale.x, Props.scale.y, 1),
                    transformOrigin = new TransformOrigin(0, 0, 0)
                },
                children: Props.content);

            private void OnVisualChange(VisualChangeEvent evt) => Area?.SetContentSize(ContentRect.size);
        }

        [RishValueType]
        public struct HolderProps
        {
            public DOMDescriptor descriptor;
            public Element content;
            public Vector2 offset;
            public Vector2 scale;
        }
    }
}