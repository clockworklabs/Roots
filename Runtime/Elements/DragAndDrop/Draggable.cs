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

        private int LastDragFrame { get; set; }

        public Draggable()
        {
            AddManipulator(new DragManipulator());
            
            RegisterCallback<DragStartEvent>(OnDragStart);
            RegisterCallback<DragEvent>(OnDrag);
            RegisterCallback<DragEndEvent>(OnDragEnd);
        }

        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<DragAndDropContext>();
        }

        void IMountingListener.ComponentWillUnmount()
        {
            
            Context?.UnmountDraggable(this);
        }

        void IPropsListener.PropsDidChange()
        {
            Context?.OnDraggableUpdate(this);
        }

        void IPropsListener.PropsWillChange() { }

        protected override Element Render()
        {
            var element = !State.dragging
                ? Props.content
                : State.primary
                    ? Props.contentWhileDragging.Valid
                        ? Props.contentWhileDragging
                        : Props.content
                    : Props.secondaryContentWhileDragging.Valid
                        ? Props.secondaryContentWhileDragging
                        : Props.contentWhileDragging.Valid
                            ? Props.contentWhileDragging
                            : Props.content;

            return element;
        }

        private void OnDragStart(DragStartEvent evt)
        {
            var pointerId = evt.pointerId;
            
            // TODO: Support touch screen
            if (pointerId != PointerId.mousePointerId)
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
            var start = Context.DraggableDragStart(this, primary);
            if (!start)
            {
                return;
            }

            StartDragging(primary);
            
            Props.onDragAction?.Invoke();
            
            CaptureMouse();
        }

        private void OnDrag(DragEvent evt)
        {
            var pointerId = evt.pointerId;
            // TODO: Support touch screen
            if (pointerId != PointerId.mousePointerId)
            {
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
            // TODO: Support touch screen
            if (pointerId != PointerId.mousePointerId)
            {
                return;
            }
            
            EndDragging();
            
            Props.onDropAction?.Invoke();
            
            Context.DraggableDragEnd(this, evt);
            
            ReleaseMouse();
        }

        internal T GetInfo(bool primary) => primary ? Props.info : Props.secondaryInfo.Value;

        internal void DropNowhere() => Props.dropNowhereAction?.Invoke();

        private void StartDragging(bool primary)
        {
            var state = State;
            state.dragging = true;
            state.primary = primary;
            State = state;
        }

        private void EndDragging()
        {
            var state = State;
            state.dragging = false;
            State = state;
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

        [IgnoreComparison]
        public Action onDragAction;
        [IgnoreComparison]
        public Action onDropAction;
        [IgnoreComparison]
        public Action dropNowhereAction;
    }

    [RishValueType]
    public struct DraggableState
    {
        public bool dragging;
        public bool primary;
    }
}