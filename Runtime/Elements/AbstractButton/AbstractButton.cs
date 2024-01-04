using System;
using RishUI;
using RishUI.Elements;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class AbstractButton : RishElement<AbstractButtonProps>, IMountingListener, IPropsListener, IFormSubmit
    {
        private Form Form { get; set; }
        private bool JustMounted { get; set; }
        
        private uint FocusIndex { get; set; }

        public AbstractButton()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
            RegisterCallback<KeyDownEvent>(OnKeyDown);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            Form = GetFirstAncestorOfType<Form>();
            FocusIndex = Form?.RegisterElement(this) ?? 0;

            JustMounted = true;
        }
        void IMountingListener.ComponentWillUnmount()
        {
            Form?.UnregisterElement(this);
            NotFocusable();
        }

        void IPropsListener.PropsDidChange()
        {
            if (Props.focusable)
            {
                Focusable(FocusIndex);
            }
            else
            {
                NotFocusable();
            }
        }
        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => InternalElement.Create(new AbstractButtonProps(Props)
        {
            action = OnAction
        });

        private void OnVisualChange(VisualChangeEvent evt)
        {
            if (!JustMounted)
            {
                return;
            }
            
            JustMounted = false;

            if (Props.focusable && Props.autoFocus)
            {
                Focus();
            }
        }

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (!HasFocus)
            {
                return;
            }

            var keyCode = evt.keyCode;
            if (keyCode != KeyCode.Space)
            {
                return;
            }
            
            Props.action?.Invoke();

            evt.StopPropagation();
        }

        private void OnAction() => Props.action?.Invoke();

        bool IFormSubmit.OnFormSubmit()
        {
            if (Form == null || !Props.submitsForm)
            {
                return false;
            }
            
            OnAction();

            return true;
        }
        
        private partial class InternalElement : RishElement<AbstractButtonProps, InternalElementState>, IManualState
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
                if (!Props.interactable)
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
                if (Listening || !Props.interactable)
                {
                    return;
                }

                Listening = true;
                PointerId = evt.pointerId;
                
                CapturePointer(PointerId);

                var state = State;
                state.pressed = true;
                State = state;
                
                // evt.StopPropagation();
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
                
                if (Props.interactable && State.hovered)
                {
                    if (evt.button == 1)
                    {
                        Props.secondaryAction?.Invoke();
                    }
                    else
                    {
                        Props.action?.Invoke();
                    }
                }

                var state = State;
                state.pressed = false;
                State = state;
                
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

                var state = State;
                state.pressed = false;
                State = state;
                
                evt.StopPropagation();
            }
        }

        [RishValueType]
        internal struct InternalElementState
        {
            public bool hovered;
            public bool pressed;
        }
    }

    [RishValueType]
    public struct AbstractButtonProps
    {
        public bool interactable;
        
        [IgnoreComparison]
        public Action action;
        [IgnoreComparison]
        public Action secondaryAction;
        
        public Element normal;
        public Element hovered;
        public Element pressed;
        public Element disabled;
        // TODO: Add focused

        public bool focusable;
        public bool autoFocus;

        public bool submitsForm;

        [Default]
        public static AbstractButtonProps Default => new AbstractButtonProps
        {
            interactable = true
        };

        public AbstractButtonProps(AbstractButtonProps other)
        {
            interactable = other.interactable;
            action = other.action;
            secondaryAction = other.secondaryAction;
            normal = other.normal;
            hovered = other.hovered;
            pressed = other.pressed;
            disabled = other.disabled;
            submitsForm = other.submitsForm;
            focusable = other.focusable;
            autoFocus = other.autoFocus;
        }
    }
}
