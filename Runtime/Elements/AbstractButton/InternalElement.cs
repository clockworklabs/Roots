using System;
using RishUI;
using RishUI.Events;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class AbstractButton {
        private partial class InternalElement : RishElement<InternalElementProps, InternalElementState>, IManualState
        {
            private bool Listening { get; set; }
            private int PointerId { get; set; }

            public InternalElement()
            {
                RegisterCallback<HoverStartEvent>(OnHoverStart);
                RegisterCallback<HoverEndEvent>(OnHoverEnd);
                
                RegisterCallback<PointerDownEvent>(OnPointerDown);
                RegisterCallback<PointerUpEvent>(OnPointerUp);
                // RegisterCallback<PointerStationaryEvent>(OnPointerStationary);
                RegisterCallback<PointerCancelEvent>(OnPointerCancel);
                
                // TODO: Add longPress
            }

            void IManualState.Restart()
            {
                Listening = false;
                PointerId = 0;
            }
            
            protected override Element Render()
            {
                Element element;
                if (!Props.isInteractable)
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

            private void OnHoverStart(HoverStartEvent evt) => SetHovered(true);

            private void OnHoverEnd(HoverEndEvent evt) => SetHovered(false);

            private void OnPointerDown(PointerDownEvent evt)
            {
                if (Listening || !Props.isInteractable || (evt.button & Props.buttons) == 0) return;

                Listening = true;
                PointerId = evt.pointerId;
                
                CapturePointer(PointerId);

                SetPressed(true);
                
                // evt.StopPropagation();
            }

            private void OnPointerUp(PointerUpEvent evt)
            {
                if (!Listening || PointerId != evt.pointerId) return;
                
                ReleasePointer(PointerId);

                Listening = false;
                PointerId = 0;
                
                if (Props.isInteractable && State.hovered)
                {
                    Action(evt.button);
                }

                SetPressed(false);
                
                evt.StopPropagation();
            }

            // TODO: Does this work?
            // private void OnPointerStationary(PointerStationaryEvent evt)
            // {
            //     if (!Listening || PointerId != evt.pointerId)
            //     {
            //         return;
            //     }
            //     
            //     this.ReleasePointer(PointerId);
            //
            //     Listening = false;
            //     PointerId = 0;
            //     
            //     
            //     if (ContainsPoint(this.WorldToLocal(evt.position)) && Props.interactable)
            //     {
            //         Props.secondaryAction?.Invoke();
            //     }
            //
            //     var state = State;
            //     state.pressed = false;
            //     State = state;
            //     
            //     evt.StopPropagation();
            // }

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
                // if(ContainsPoint(WorldToLocal(evt.position)) && Props.interactable)
                // {
                //     if (evt.button == 1)
                //     {
                //         Props.secondaryAction?.Invoke();
                //     }
                //     else
                //     {
                //         Props.action?.Invoke();
                //     }
                // }

                SetPressed(false);
                
                evt.StopPropagation();
            }
        }

        [RishValueType]
        internal struct InternalElementProps
        {
            public bool isInteractable;
            public int buttons;
            public Element normal;
            public Element hovered;
            public Element pressed;
            public Element disabled;
            
            public Action<int> action;
        }

        [RishValueType]
        internal struct InternalElementState
        {
            public bool hovered;
            public bool pressed;
        }
    }
}