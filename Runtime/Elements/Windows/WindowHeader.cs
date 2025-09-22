using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class WindowHeader : RishElement<WindowHeaderProps>, IMountingListener
    {
        private WindowsContext Context { get; set; }
        private InternalWindow Window { get; set; }

        private int DraggingPointer { get; set; } = -1;
        private bool Dragging => DraggingPointer >= 0;
        
        public WindowHeader()
        {
            AddManipulator(new DragManipulator());
            
            RegisterCallback<DragStartEvent>(OnDragStart);
            RegisterCallback<DragEvent>(OnDrag);
            RegisterCallback<DragEndEvent>(OnDragEnd);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            RegisterCallback<VisualChangeEvent>(SappyOnVisualChange.Callback);
            Context = GetFirstAncestorOfType<WindowsContext>();
            Window = GetFirstAncestorOfType<InternalWindow>();

            DraggingPointer = -1;
        }
        void IMountingListener.ComponentWillUnmount() {
            UnregisterCallback<VisualChangeEvent>(SappyOnVisualChange.Callback);
        }
        
        protected override Element Render() => Props.content;

        private void OnDragStart(DragStartEvent evt)
        {
            if (Dragging || !Window.Props.draggable)
            {
                return;
            }
            
            DraggingPointer = evt.pointerId;
            
            // TODO: This can lead to issues maybe?
            CapturePointer(DraggingPointer);
        }

        private void OnDrag(DragEvent evt)
        {
            if (!Dragging || DraggingPointer != evt.pointerId)
            {
                return;
            }
            
            Drag(evt.deltaPosition, false);
            
            evt.StopPropagation();
        }

        private void OnDragEnd(DragEndEvent evt)
        {
            if (!Dragging || DraggingPointer != evt.pointerId)
            {
                return;
            }
            
            // TODO: This can lead to issues maybe?
            ReleasePointer(DraggingPointer);

            DraggingPointer = -1;
        }

        [SapTarget(typeof(EventCallback<VisualChangeEvent>))]
        private void OnVisualChange(VisualChangeEvent evt)
        {
            UnregisterCallback<VisualChangeEvent>(SappyOnVisualChange.Callback);
            Drag(Vector2.zero, true);
        }

        private void Drag(Vector2 delta, bool isInitialization)
        {
            var contextSize = Context.ContentRect.size;

            float minX, maxX, minY, maxY;
            Vector2 position;
            if (Context.Props.forceFit)
            {
                position = Context.WorldToLocal(Window.WorldLayout).position;
                var size = Window.WorldLayout.size;
                
                minX = 0;
                maxX = contextSize.x - size.x;
                minY = 0;
                maxY = contextSize.y - size.y;
            }
            else
            {
                position = Context.WorldToLocal(WorldLayout).position;
                var size = WorldLayout.size;
                
                var safeZone = Context.SafeZone;
                
                minX = -size.x + safeZone;
                maxX = contextSize.x - safeZone;
                minY = -size.y + safeZone;
                maxY = contextSize.y - safeZone;
            }

            if (position.x < minX)
            {
                delta.x = minX - position.x;
            } else if (position.x > maxX)
            {
                delta.x = maxX - position.x;
            }
            else
            {
                var minDeltaX = Mathf.Min(0, minX - position.x);
                var maxDeltaX = Mathf.Max(0, maxX - position.x);
                delta.x = Mathf.Clamp(delta.x, minDeltaX, maxDeltaX);
            }

            if (position.y < minY)
            {
                delta.y = minY - position.y;
            } else if (position.y > maxY)
            {
                delta.y = maxY - position.y;
            }
            else
            {
                var minDeltaY = Mathf.Min(0, minY - position.y);
                var maxDeltaY = Mathf.Max(0, maxY - position.y);
                delta.y = Mathf.Clamp(delta.y, minDeltaY, maxDeltaY);
            }
            
            Window?.Drag(delta, isInitialization);
        }
    }

    [RishValueType]
    public struct WindowHeaderProps
    {
        public Element content;
    }
}