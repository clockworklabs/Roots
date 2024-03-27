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

        void IMountingListener.ComponentDidMount()
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

        void IMountingListener.ComponentWillUnmount()
        {
            Context?.UnmountDraggable(this);

            PointerId = -1;
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
                var start = Context.DraggableDragStart(this, primary);
                if (!start)
                {
                    Valid = false;
                    return;
                }

                StartDragging(primary);
            
                Props.onDragAction?.Invoke();
            
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