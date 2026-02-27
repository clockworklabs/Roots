using System;
using System.Collections.Generic;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class DragAndDropContext : RishElement<DragAndDropContextProps, DragAndDropContextState>, IManualState
    {
        private bool Primary { get; set; }
        private IElement Draggable { get; set; }
        private Queue<IElement> DropAreas { get; } = new();

        private List<IElement> MountedDropAreas { get; } = new();
        
        void IManualState.Restart()
        {
            Draggable = null;
            DropAreas.Clear();
            MountedDropAreas.Clear();
        }
        
        protected override Element Render()
        {
            Element draggedElement;
            if (State.draggedElement.Valid)
            {
                var rect = State.rect;
                var delta = State.dragDelta;

                draggedElement = Div.Create(
                    style: new Style
                    {
                        position = Position.Absolute,
                        left = rect.x + delta.x,
                        top = rect.y + delta.y,
                        pointerDetection = PointerDetectionMode.ForceIgnore,
                        translate = State.offset
                    },
                    children: State.draggedElement);
            }
            else
            {
                draggedElement = Element.Null;
            }

            return Div.Create(
                descriptor: Props.descriptor,
                children: new Children
                {
                    Props.children,
                    draggedElement
                });
        }

        internal void UnmountDraggable<T>(Draggable<T> element) where T : struct
        {
            if (Draggable != element)
            {
                return;
            }

            Draggable = null;
            SetupDraggedElement<T>(null, false, false);
            ClearDropAreas<T>();
            
            OnDrag(false);
            
            Dirty();
        }

        internal void RegisterDropArea<T>(DropArea<T> element) where T : struct
        {
            MountedDropAreas.Add(element);

            if (Draggable is not Draggable<T> draggable)
            {
                return;
            }
            
            element.OnInfo(draggable.GetInfo(Primary));
        }

        internal void UnregisterDropArea<T>(DropArea<T> element) where T : struct
        {
            MountedDropAreas.Remove(element);
        }

        internal bool DraggableDragStart<T>(Draggable<T> element, Vector2 offset, bool primary) where T : struct
        {
            if (element == null || Draggable != null)
            {
                return false;
            }
            
            ClearDropAreas<T>();

            Primary = primary;
            Draggable = element;
            SetDragDelta(Vector2.zero);
            var localRect = WorldToLocal(element.WorldBoundingBox);
            SetRect(new Rect
            {
                x = localRect.x + offset.x,
                width = localRect.width,
                y = localRect.y + offset.y,
                height = localRect.height
            });
            SetOffset(new Translate(Length.Percent(-offset.x / localRect.width * 100), Length.Percent(-offset.y / localRect.height * 100), 0));

            foreach (var daElement in MountedDropAreas)
            {
                if (daElement is not DropArea<T> dropArea)
                {
                    continue;
                }
                
                dropArea.OnInfo(element.GetInfo(primary));
            }

            SetupDraggedElement(element, false, false);
            
            OnDrag(true);
            
            Dirty();

            return true;
        }

        internal void DraggableDrag<T>(Draggable<T> element, Vector2 delta) where T : struct
        {
            if (element == null || Draggable != element)
            {
                return;
            }

            SetDragDelta(State.dragDelta + delta);
        }

        internal void DraggableDragEnd<T>(Draggable<T> element, IPointerEvent evt) where T : struct
        {
            if (element == null || Draggable != element)
            {
                return;
            }
            
            Draggable = null;

            var hoveredDropArea = DropAreas.Count > 0 ? DropAreas.Peek() : null;
            var dropped = false;
            foreach (var daElement in MountedDropAreas)
            {
                if (daElement is not DropArea<T> dropArea)
                {
                    continue;
                }
                
                if (dropArea == hoveredDropArea)
                {
                    dropped = true;
                    dropArea.Drop(element.GetInfo(Primary));
                }
                
                dropArea.OnInfo(null);
            }
            
            if (!dropped && Pick(evt.position) == null)
            {
                element.DropNowhere();
            }
            
            ClearDropAreas<T>();
            
            OnDrag(false);
            
            SetupDraggedElement<T>(null, false, false);
            
            Dirty();
        }

        internal void DropAreaHoverStart<T>(DropArea<T> element) where T : struct
        {
            if (element == null || Draggable is not Draggable<T> draggable)
            {
                return;
            }

            var currentArea = DropAreas.Count > 0 ? DropAreas.Peek() as DropArea<T> : null;

            if (currentArea == element)
            {
                return;
            }
            
            currentArea?.SetHovering(false);
            element.SetHovering(true);
            
            SetupDraggedElement(draggable, true, element.CanAccept());
            
            DropAreas.Enqueue(element);
        }

        internal void DropAreaHoverEnd<T>(DropArea<T> element) where T : struct
        {
            if (DropAreas.Count > 0 && DropAreas.Peek() != element)
            {
                ClearDropAreas<T>();
                return;
            }
            
            element.SetHovering(false);

            if (Draggable is not Draggable<T> draggable)
            {
                return;
            }

            bool hovering;
            bool acceptable;
            if (DropAreas.Count > 0)
            {
                DropAreas.Dequeue();

                if (DropAreas.Count > 0)
                {
                    if (DropAreas.Peek() is DropArea<T> newDropArea)
                    {
                        newDropArea.SetHovering(true);

                        hovering = true;
                        acceptable = newDropArea.CanAccept();
                    }
                    else
                    {
                        hovering = false;
                        acceptable = false;
                    }
                }
                else
                {
                    hovering = false;
                    acceptable = false;
                }
            }
            else
            {
                hovering = false;
                acceptable = false;
            }
        
            SetupDraggedElement(draggable, hovering, acceptable);
        }

        private void ClearDropAreas<T>() where T : struct
        {
            while (DropAreas.Count > 0)
            {
                var dropArea = DropAreas.Dequeue() as DropArea<T>;
                dropArea?.SetHovering(false);
            }
        }

        internal void OnDraggableUpdate<T>(Draggable<T> element) where T : struct
        {
            if (element == null || Draggable != element)
            {
                return;
            }

            var hoveredDropArea = DropAreas.Count > 0 ? DropAreas.Peek() : null;

            var hovering = false;
            var acceptable = false;
            foreach (var daElement in MountedDropAreas)
            {
                if (daElement is not DropArea<T> dropArea)
                {
                    continue;
                }
                
                dropArea.OnInfo(element.GetInfo(Primary));

                if (dropArea == hoveredDropArea)
                {
                    hovering = true;
                    acceptable = dropArea.CanAccept();
                }
            }

            SetupDraggedElement(element, hovering, acceptable);
        }

        internal void OnDropAreaUpdate<T>(DropArea<T> element) where T : struct
        {
            if (Draggable is not Draggable<T> draggable)
            {
                return;
            }

            element.OnInfo(draggable.GetInfo(Primary));

            if (DropAreas.Count == 0 || DropAreas.Peek() != element)
            {
                return;
            }

            SetupDraggedElement(draggable, true, element.CanAccept());
        }

        private void SetupDraggedElement<T>(Draggable<T> draggable, bool hovering, bool acceptable) where T : struct
        {
            var draggedElement = Element.Null;
            if (draggable != null)
            {
                var props = draggable.Props;

                var element = hovering
                    ? acceptable
                        ? Primary
                            ? props.draggedAcceptedElement.Valid 
                                ? props.draggedAcceptedElement 
                                : props.draggedElement
                            : props.secondaryDraggedAcceptedElement.Valid 
                                ? props.secondaryDraggedAcceptedElement 
                                : props.secondaryDraggedElement.Valid 
                                    ? props.secondaryDraggedElement 
                                    : props.draggedElement
                        : Primary
                            ? props.draggedRejectedElement.Valid 
                                ? props.draggedRejectedElement
                                : props.draggedElement
                            : props.secondaryDraggedRejectedElement.Valid 
                                ? props.secondaryDraggedRejectedElement
                                : props.secondaryDraggedElement.Valid 
                                    ? props.secondaryDraggedElement 
                                    : props.draggedElement
                    : Primary
                        ? props.draggedElement
                        : props.secondaryDraggedElement.Valid 
                            ? props.secondaryDraggedElement 
                            : props.draggedElement;

                if (element.Valid)
                {
                    // var descriptor = element.GetDescriptor();
                    // var elementStyle = descriptor.style;
                    // elementStyle.position = Position.Absolute;
                    // TODO: Support transformed elements


                    draggedElement = element;
                }
            }

            SetDraggedElement(draggedElement);
        }

        // private static Rect TransformRect(Matrix4x4 transform, Rect rect)
        // {
        //     var min = new Vector3(rect.xMin, rect.yMin, 0);
        //     var max = new Vector3(rect.xMax, rect.yMax, 0);
        //
        //     var newMin = transform.MultiplyPoint(min);
        //     var newMax = transform.MultiplyPoint(max);
        //
        //     return new Rect(newMin, newMax - newMin);
        // }
    }

    [RishValueType]
    public struct DragAndDropContextProps
    {
        [Expand]
        public VisualAttributes descriptor;
        public Children children;
        
        public Action<bool> onDrag;
    }

    [RishValueType]
    public struct DragAndDropContextState
    {
        public Rect rect;
        public Translate offset;
        public Vector2 dragDelta;
        public Element draggedElement;
    }
}