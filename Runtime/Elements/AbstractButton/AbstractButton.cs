using System;
using RishUI;
using RishUI.Events;
using RishUI.MemoryManagement;
using Sappy;
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

        protected override Element Render()
        {
            var buttons = new RishList<int>();
            foreach (var a in Props.action.actions)
            {
                buttons.Add(a.button);
            }
            
            return InternalElement.Create(
                isInteractable: Props.isInteractable,
                buttons: buttons,
                normal: Props.normal,
                hovered: Props.hovered,
                pressed: Props.pressed,
                disabled: Props.disabled,
                action: SappyDoAction);
        }

        [SapTarget]
        private void DoAction(int button)
        {
            foreach (var buttonAction in Props.action.actions)
            {
                if (buttonAction.button == button)
                {
                    buttonAction.action?.Invoke();
                }
            }
        }

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
            
            DoAction(0);

            evt.StopPropagation();
        }

        bool IFormSubmit.OnFormSubmit()
        {
            if (Form == null || !Props.submitsForm)
            {
                return false;
            }
            
            DoAction(0);

            return true;
        }
    }
    
    [RishValueType]
    public struct ButtonAction
    {
        public int button;
        public Action action;
        
        public static implicit operator ButtonAction(Action action) => new() { action = action };
        public static implicit operator ButtonAction(SapTarget<Action> action) => new() { action = action };
    }
    
    [RishValueType]
    public struct ButtonActionsGroup
    {
        public RishList<ButtonAction> actions;
        
        public static implicit operator ButtonActionsGroup(RishList<ButtonAction> actions) => new() { actions = actions };
        
        [RequiresManagedContext]
        public static implicit operator ButtonActionsGroup(ButtonAction action) => new() { 
            actions = action
        };
        
        [RequiresManagedContext]
        public static implicit operator ButtonActionsGroup(Action action) => new() { 
            actions = new ButtonAction
            {
                action = action
            }
        };
        
        [RequiresManagedContext]
        public static implicit operator ButtonActionsGroup(SapTarget<Action> action) => new() { 
            actions = new ButtonAction
            {
                action = action
            }
        };
    }

    [RishValueType]
    public struct AbstractButtonProps
    {
        public bool? interactable;
        
        public ButtonActionsGroup action;
        
        public Element normal;
        public Element hovered;
        public Element pressed;
        public Element disabled;
        // TODO: Add focused

        public bool actionOnPointerDown;
        
        public bool focusable;
        public bool autoFocus;

        public bool submitsForm;

        internal bool isInteractable => !interactable.HasValue || interactable.Value;
    }
}
