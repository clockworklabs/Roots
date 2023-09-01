using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Contextual : RishElement<ContextualProps, ContextualState>, IContextual, IMountingListener
    {
        private ContextualContext Context { get; set; }

        private bool Listening { get; set; }
        private int PointerId { get; set; }

        Element IContextual.Menu => Props.menu;
        
        public Contextual()
        {
            RegisterCallback<HoverStartEvent>(OnHoverStart);
            RegisterCallback<HoverEndEvent>(OnHoverEnd);
            
            RegisterCallback<PointerDownEvent>(OnPointerDown);
            RegisterCallback<PointerUpEvent>(OnPointerUp);
            RegisterCallback<PointerCancelEvent>(OnPointerCancel);
        }

        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<ContextualContext>();
            
            Listening = false;
            PointerId = 0;
        }
        
        void IMountingListener.ComponentWillUnmount()
        {
            Context?.HideContextMenu(this);
        }
        
        protected override Element Render()
        {
            Element element;
            if(State.pressed && Props.pressed.Valid)
            {
                element = Props.pressed;
            } else if(State.hovered && Props.hovered.Valid)
            {
                element = Props.hovered;
            }
            else
            {
                element = Props.normal;
            }

            return element;
        }
        
        private void OnHoverStart(HoverStartEvent evt)
        {
            var state = State;
            state.hovered = true;
            State = state;
        }

        private void OnHoverEnd(HoverEndEvent evt)
        {
            var state = State;
            state.hovered = false;
            State = state;
        }

        private void OnPointerDown(PointerDownEvent evt)
        {
            if (Listening || evt.button != 1)
            {
                return;
            }

            Listening = true;
            PointerId = evt.pointerId;
            
            CapturePointer(PointerId);

            var state = State;
            state.pressed = true;
            State = state;
            
            evt.StopPropagation();
        }

        private void OnPointerUp(PointerUpEvent evt)
        {
            if (!Listening || PointerId != evt.pointerId)
            {
                return;
            }
            
            ReleasePointer(PointerId);

            Listening = false;
            PointerId = 0;
            
            // TODO: Is it necessary?
            if (ContainsPoint(WorldToLocal(evt.position)))
            {
                if (evt.button == 1)
                {
                    OnAction(evt.position);
                }
            }

            var state = State;
            state.pressed = false;
            State = state;
            
            evt.StopPropagation();
        }

        // TODO: Is this necessary?
        private void OnPointerCancel(PointerCancelEvent evt)
        {
            if (!Listening || PointerId != evt.pointerId)
            {
                return;
            }

            ReleasePointer(PointerId);

            Listening = false;
            PointerId = 0;
            
            // TODO: Is it necessary?
            if (ContainsPoint(WorldToLocal(evt.position)))
            {
                if (evt.button == 1)
                {
                    OnAction(evt.position);
                }
            }

            var state = State;
            state.pressed = false;
            State = state;
            
            evt.StopPropagation();
        }

        private void OnAction(Vector3 position)
        {
            Context?.ShowContextMenu(this, position);
        }
    }

    [RishValueType]
    public struct ContextualProps
    {
        public Element normal;
        public Element hovered;
        public Element pressed;

        public Element menu;
    }

    [RishValueType]
    public struct ContextualState
    {
        public bool hovered;
        public bool pressed;
    }
}