using System;
using System.Collections.Generic;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;
using Translate = UnityEngine.UIElements.Translate;

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
                var delta = State.dragDelta;

                var style = (Style) State.layout;
                style.translate = new Translate(delta.x, delta.y, 0);
                style.pointerDetection = PointerDetectionMode.ForceIgnore;

                draggedElement = Div.Create(style, children: State.draggedElement);
            }
            else
            {
                draggedElement = Element.Null;
            }

            return Div.Create(Props.descriptor, children: new Children { Props.content, draggedElement });
        }

        internal void UnmountDraggable<T>(Draggable<T> element) where T : struct
        {
            if (Draggable != element)
            {
                return;
            }

            Draggable = null;
            ClearDropAreas<T>();
            
            Props.onDrag?.Invoke(false);
            
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

        internal bool DraggableDragStart<T>(Draggable<T> element, bool primary) where T : struct
        {
            if (element == null || Draggable != null)
            {
                return false;
            }
            
            ClearDropAreas<T>();

            Primary = primary;
            Draggable = element;
            SetDragDelta(Vector2.zero);

            foreach (var daElement in MountedDropAreas)
            {
                if (daElement is not DropArea<T> dropArea)
                {
                    continue;
                }
                
                dropArea.OnInfo(element.GetInfo(primary));
            }

            SetDraggedElement(element, false, false);
            
            Props.onDrag?.Invoke(true);
            
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
            
            Props.onDrag?.Invoke(false);
            
            SetDraggedElement<T>(null, false, false);
            
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
            
            SetDraggedElement(draggable, true, element.CanAccept());
            
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
        
            SetDraggedElement(draggable, hovering, acceptable);
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

            SetDraggedElement(element, hovering, acceptable);
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

            SetDraggedElement(draggable, true, element.CanAccept());
        }

        private void SetDragDelta(Vector2 delta)
        {
            var state = State;
            state.dragDelta = delta;
            State = state;
        }

        private void SetDraggedElement<T>(Draggable<T> draggable, bool hovering, bool acceptable) where T : struct
        {
            var draggedElement = Element.Null;
            LayoutStyle layout = default;
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
                    var localRect = WorldToLocal(draggable.WorldBoundingBox);

                    layout = new LayoutStyle
                    {
                        position = Position.Absolute,
                        left = localRect.x,
                        width = localRect.width,
                        top = localRect.y,
                        height = localRect.height
                    };

                    draggedElement = element;
                }
            }

            var state = State;
            state.layout = layout;
            state.draggedElement = draggedElement;
            State = state;
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
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children content;
        [IgnoreComparison]
        public Action<bool> onDrag;
    }

    [RishValueType]
    public struct DragAndDropContextState
    {
        public Vector2 dragDelta;
        public LayoutStyle layout;
        public Element draggedElement;
    }
}