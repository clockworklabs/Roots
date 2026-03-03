using System.Linq;
using RishUI;
using Sappy;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Stateful : RishElement<StatefulProps, StatefulState>, IMountingListener
    {
        private int _pointerId = -1;
        private int PointerId
        {
            get => _pointerId;
            set
            {
                if (_pointerId == value) return;

                if (_pointerId >= 0)
                {
                    ReleasePointer(_pointerId);
                }
                _pointerId = value;
                if (value >= 0)
                {
                    CapturePointer(value);
                }
            }
        }

        public Stateful()
        {
            RegisterCallback<PointerEnterEvent>(Sappy.OnHoverStart);
            RegisterCallback<PointerLeaveEvent>(Sappy.OnHoverEnd);
            RegisterCallback<PointerDownEvent>(Sappy.OnPointerDown);
            RegisterCallback<PointerUpEvent>(Sappy.OnPointerUp);
        }

        void IMountingListener.ElementDidMount() { }
        void IMountingListener.ElementWillUnmount()
        {
            PointerId = -1;
        }
        
        protected override Element Render()
        {
            Element element;
            if (Props.isDisabled)
            {
                element = Props.disabled.Valid 
                    ? Props.disabled 
                    : Props.normal;
            } else if(State.pressed && State.hovered && Props.pressed.Valid)
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

        [SapTarget(typeof(EventCallback<PointerEnterEvent>))]
        private void OnHoverStart(PointerEnterEvent evt) => SetHovered(true);
        [SapTarget(typeof(EventCallback<PointerLeaveEvent>))]
        private void OnHoverEnd(PointerLeaveEvent evt) => SetHovered(false);
        
        [SapTarget(typeof(EventCallback<PointerDownEvent>))]
        private void OnPointerDown(PointerDownEvent evt)
        {
            if (PointerId >= 0 || Props.isDisabled || !Props.buttons.Contains(evt.button)) return;

            PointerId = evt.pointerId;

            SetPressed(true);
        }
        [SapTarget(typeof(EventCallback<PointerUpEvent>))]
        private void OnPointerUp(PointerUpEvent evt)
        {
            if (PointerId != evt.pointerId) return;
            
            PointerId = -1;

            SetPressed(false);
        }
    }

    [RishValueType]
    public struct StatefulProps
    {
        public bool isDisabled;
        public RishList<int> buttons;
        public Element normal;
        public Element hovered;
        public Element pressed;
        public Element disabled;
    }

    [RishValueType]
    public struct StatefulState
    {
        public bool hovered;
        public bool pressed;
    }
}