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

        public bool pointerUpIsSufficient;
        
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
            pointerUpIsSufficient = other.pointerUpIsSufficient;
            submitsForm = other.submitsForm;
            focusable = other.focusable;
            autoFocus = other.autoFocus;
        }
    }
}
