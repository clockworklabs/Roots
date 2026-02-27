using System;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    internal partial class InternalWindow : RishElement<InternalWindowProps, InternalWindowState>, IMountingListener
    {
        private WindowsContext Context { get; set; }

        public InternalWindow()
        {
            RegisterCallback<PointerDownEvent>(OnPointerDown);
        }
        void IMountingListener.ElementDidMount()
        {
            Context = GetFirstAncestorOfType<WindowsContext>();
        }
        void IMountingListener.ElementWillUnmount() { }
        
        protected override Element Render()
        {
            var offset = Props.offset ?? State.dragOffset;
            return Div.Create(
                style: new Style
                {
                    position = Position.Absolute,
                    left = Props.rect.x + offset.x,
                    width = Props.rect.width,
                    top = Props.rect.y + offset.y,
                    height = Props.rect.height,
                    pointerDetection = PointerDetectionMode.Ignore
                },
                children: Props.content);
        }

        internal void Drag(Vector2 delta, bool isInitialization)
        {
            SetDragOffset(State.dragOffset + delta);
            
            OnDrag(Props.guid, new WindowDragData { delta = delta, isInitialization = isInitialization });
        }

        private void OnPointerDown(PointerDownEvent evt)
        {
            Context.MoveToFront(Props.guid);
            
            evt.StopPropagation();
        }
    }

    [RishValueType]
    internal struct InternalWindowProps
    {
        public ulong guid;
        public Element content;
        public bool draggable;
        public Vector2? offset;
        public Rect rect;
        // public bool resizable;

        public Action<ulong, WindowDragData> onDrag;
    }

    [RishValueType]
    internal struct InternalWindowState
    {
        public Vector2 dragOffset;
    }
}