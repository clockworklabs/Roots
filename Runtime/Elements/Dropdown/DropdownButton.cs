using RishUI;
using RishUI.Events;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class DropdownButton : RishElement<DropdownButtonProps, DropdownButtonState>, IMountingListener
    {
        private DropdownContext Context { get; set; }

        private bool Listening { get; set; }
        private int PointerId { get; set; }
        public DropdownButton()
        {
            RegisterCallback<HoverStartEvent>(OnHoverStart);
            RegisterCallback<HoverEndEvent>(OnHoverEnd);

            RegisterCallback<PointerDownEvent>(OnPointerDown);
            RegisterCallback<PointerUpEvent>(OnPointerUp);
            RegisterCallback<PointerCancelEvent>(OnPointerCancel);
        }

        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<DropdownContext>();

            Listening = false;
            PointerId = 0;
        }

        void IMountingListener.ComponentWillUnmount()
        {
            Context?.HideDropdownMenu(this);
        }

        protected override Element Render()
        {
            Element element;
            if (!Props.interactable)
            {
                return Props.disabled.Valid ? Props.disabled : Props.normal;
            }
            
            if (State.open && Props.open.Valid)
            {
                element = Props.open;
            } else if (State.pressed && Props.pressed.Valid)
            {
                element = Props.pressed;
            }
            else if (State.hovered && Props.hovered.Valid)
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
            if (!Props.interactable || Listening || evt.button != 0)
            {
                return;
            }

            if (State.open)
            {
                OnAction();
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

            if (evt.button == 0)
            {
                OnAction();
            }

            var state = State;
            state.pressed = false;
            State = state;

            evt.StopPropagation();
        }

        private void OnPointerCancel(PointerCancelEvent evt)
        {
            if (!Listening || PointerId != evt.pointerId)
            {
                return;
            }

            ReleasePointer(PointerId);

            Listening = false;
            PointerId = 0;

            var state = State;
            state.pressed = false;
            State = state;

            evt.StopPropagation();
        }

        internal void OnOpen()
        {
            var state = State;
            state.open = true;
            State = state;
        }

        internal void OnClose()
        {
            var state = State;
            state.open = false;
            State = state;
        }

        private void OnAction()
        {
            if (!State.open)
            {
                Context?.ShowDropdownMenu(this);
            }
            else
            {
                Context?.HideDropdownMenu(this);
            }
        }
    }

    [RishValueType]
    public struct DropdownButtonProps
    {
        public bool interactable;
        
        public Element normal;
        public Element hovered;
        public Element pressed;
        public Element disabled;
        public Element open;

        public Element menu;

        [Default]
        private static DropdownButtonProps Default => new()
        {
            interactable = true
        };
    }

    [RishValueType]
    public struct DropdownButtonState
    {
        public bool hovered;
        public bool pressed;
        public bool open;
    }
}