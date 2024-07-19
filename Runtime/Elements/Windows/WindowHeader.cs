using RishUI;
using RishUI.Events;
using UnityEngine;

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
            Context = GetFirstAncestorOfType<WindowsContext>();
            Window = GetFirstAncestorOfType<InternalWindow>();

            DraggingPointer = -1;
        }
        
        void IMountingListener.ComponentWillUnmount() { }
        
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
            
            Drag(evt.deltaPosition);
            
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

        private void Drag(Vector2 delta)
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
            
            var minDeltaX = Mathf.Min(0, minX - position.x);
            var maxDeltaX = Mathf.Max(0, maxX - position.x);
            var minDeltaY = Mathf.Min(0, minY - position.y);
            var maxDeltaY = Mathf.Max(0, maxY - position.y);

            delta.x = Mathf.Clamp(delta.x, minDeltaX, maxDeltaX);
            delta.y = Mathf.Clamp(delta.y, minDeltaY, maxDeltaY);
                    
            Context?.Drag(Window.Props.guid, delta);
        }
    }

    [RishValueType]
    public struct WindowHeaderProps
    {
        public Element content;
    }
}