using System;
using RishUI;
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

        protected override Element Render() => InternalElement.Create(props: new AbstractButtonProps(Props)
        {
            action = SappyProps.Action
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
            
            Action();

            evt.StopPropagation();
        }

        bool IFormSubmit.OnFormSubmit()
        {
            if (Form == null || !Props.submitsForm)
            {
                return false;
            }
            
            Action();

            return true;
        }
    }

    [RishValueType]
    public struct AbstractButtonProps
    {
        public bool? interactable;
        
        public Action action;
        public Action secondaryAction;
        
        public Element normal;
        public Element hovered;
        public Element pressed;
        public Element disabled;
        // TODO: Add focused

        public bool pointerUpIsSufficient;
        
        public bool focusable;
        public bool autoFocus;

        public bool submitsForm;

        public AbstractButtonProps(AbstractButtonProps other)
        {
            interactable = other.interactable;
            action = other.action;
            secondaryAction = other.secondaryAction;
            normal = other.normal;
            hovered = other.hovered;
            pressed = other.pressed;
            disabled = other.disabled;
            pointerUpIsSufficient = other.pointerUpIsSufficient;
            submitsForm = other.submitsForm;
            focusable = other.focusable;
            autoFocus = other.autoFocus;
        }

        internal bool isInteractable => !interactable.HasValue || interactable.Value;
    }
}
