using System;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Draggable<T> : RishElement<DraggableProps<T>, DraggableState>, IMountingListener, IPropsListener where T : struct
    {
        private DragAndDropContext Context { get; set; }
        private float Threshold { get; set; }

        private int PointerId { get; set; } = -1;
        private bool Valid { get; set; }
        private float Delta { get; set; }
        private int LastDragFrame { get; set; }

        public Draggable()
        {
            AddManipulator(new DragManipulator());
            
            RegisterCallback<DragStartEvent>(OnDragStart);
            RegisterCallback<DragEvent>(OnDrag);
            RegisterCallback<DragEndEvent>(OnDragEnd);
        }

        void IMountingListener.ElementDidMount()
        {
            Context = GetFirstAncestorOfType<DragAndDropContext>();

            var root = GetFirstAncestorOfType<VisualElement>();
            while (root.parent != null)
            {
                root = root.parent;
            }

            var screenSize = root.layout.size;
            var shortSideSize = Mathf.Min(screenSize.x, screenSize.y);
            Threshold = shortSideSize * 0.005f;
        }

        void IMountingListener.ElementWillUnmount()
        {
            Context?.UnmountDraggable(this);

            PointerId = -1;
        }

        void IPropsListener.PropsDidChange()
        {
            Context?.OnDraggableUpdate(this);
        }

        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => State.dragging
            ? State.primary
                ? Props.contentWhileDragging.IsValid
                    ? Props.contentWhileDragging
                    : Props.content
                : Props.secondaryContentWhileDragging.IsValid
                    ? Props.secondaryContentWhileDragging
                    : Props.contentWhileDragging.IsValid
                        ? Props.contentWhileDragging
                        : Props.content
            : Props.content;

        private void OnDragStart(DragStartEvent evt)
        {
            var pointerId = evt.pointerId;
            
            // TODO: Support touch screen
            if (PointerId >= 0 || pointerId != UnityEngine.UIElements.PointerId.mousePointerId)
            {
                return;
            }
            
            var pressedButtons = evt.pressedButtons;
            if(pressedButtons <= 0) 
            {
                return;
            }
            var primary = (pressedButtons & 1) > 0;
            if (!primary && !Props.secondaryInfo.HasValue)
            {
                return;
            }
            
            PointerId = pointerId;
            Delta = Threshold;
            Valid = true;
        }

        private void OnDrag(DragEvent evt)
        {
            var pointerId = evt.pointerId;
            if (!Valid || pointerId != PointerId)
            {
                return;
            }

            if (!State.dragging)
            {
                Delta -= evt.deltaPosition.magnitude;
                if (Delta > 0)
                {
                    return;
                }
                var pressedButtons = evt.pressedButtons;
                var primary = (pressedButtons & 1) > 0;
                var start = Context.DraggableDragStart(this, evt.localPosition, primary);
                if (!start)
                {
                    Valid = false;
                    return;
                }

                StartDragging(primary);
            
                OnDragAction();
            
                CaptureMouse();

                return;
            }
            
            var frame = Time.frameCount;
            if (LastDragFrame >= frame)
            {
                return;
            }

            LastDragFrame = frame;
            
            Context.DraggableDrag(this, evt.deltaPosition);
        }

        private void OnDragEnd(DragEndEvent evt)
        {
            var pointerId = evt.pointerId;
            if (!Valid || pointerId != PointerId)
            {
                return;
            }

            PointerId = -1;
            
            EndDragging();
            
            OnDropAction();
            
            Context.DraggableDragEnd(this, evt);
            
            ReleaseMouse();
        }

        internal T GetInfo(bool primary) => primary ? Props.info : Props.secondaryInfo.Value;

        internal void DropNowhere() => DropNowhereAction();

        private void StartDragging(bool primary)
        {
            SetDragging(true);
            SetPrimary(primary);
        }

        private void EndDragging()
        {
            SetDragging(false);
        }
    }

    [RishValueType]
    public struct DraggableProps<T> where T : struct
    {
        public Element content;
        public Element contentWhileDragging;
        public Element secondaryContentWhileDragging;

        public Element draggedElement;
        public Element draggedAcceptedElement;
        public Element draggedRejectedElement;

        public Element secondaryDraggedElement;
        public Element secondaryDraggedAcceptedElement;
        public Element secondaryDraggedRejectedElement;

        public T info;
        public T? secondaryInfo;

        public Action onDragAction;
        public Action onDropAction;
        public Action dropNowhereAction;
    }

    [RishValueType]
    public struct DraggableState
    {
        public bool dragging;
        public bool primary;
    }
}