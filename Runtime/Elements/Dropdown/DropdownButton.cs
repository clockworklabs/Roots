using System;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class DropdownButton : RishElement<DropdownButtonProps, DropdownButtonState>, IMountingListener, IPropsListener
    {
        private DropdownContext Context { get; set; }

        private Form Form { get; set; }
        private uint FocusIndex { get; set; }

        private bool JustMounted { get; set; }

        public DropdownButton()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
            RegisterCallback<KeyDownEvent>(OnKeyDown);
        }

        void IMountingListener.ElementDidMount()
        {
            Context = GetFirstAncestorOfType<DropdownContext>();

            Form = GetFirstAncestorOfType<Form>();
            FocusIndex = Form?.RegisterElement(this) ?? 0;

            JustMounted = true;
        }
        void IMountingListener.ElementWillUnmount()
        {
            Context?.HideDropdownMenu(this);

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

            if (State.open)
            {
                Context.ShowDropdownMenu(this);
            }
        }

        void IPropsListener.PropsWillChange()
        {
            var action = SappyState.SetOpen;
        }

        protected override Element Render() => AbstractButton.Create(
            action: Sappy.DoAction,
            normal: State.open && Props.open.IsValid ? Props.open : Props.normal,
            hovered: State.open && Props.open.IsValid ? Props.open : Props.hovered,
            pressed: State.open && Props.open.IsValid ? Props.open : Props.pressed,
            disabled: State.open && Props.open.IsValid ? Props.open : Props.disabled,
            interactable: Props.interactable);

        [SapTarget(groupName: "Test")]
        internal void OnOpen()
        {
            SetOpen(true);
            OnOpen(true);
        }

        internal void OnClose()
        {
            SetOpen(false);
            OnOpen(false);
        }

        [SapTarget]
        private void DoAction()
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

        private void OnVisualChange(VisualChangeEvent evt)
        {
            if (!JustMounted) return;
            
            JustMounted = false;

            if (Props.focusable && Props.autoFocus)
            {
                Focus();
            }
        }

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (!HasFocus || evt.keyCode != KeyCode.Space) return;
            
            DoAction();

            evt.StopPropagation();
        }
    }

    [RishValueType]
    public struct DropdownButtonProps
    {
        [DefaultValue(true)]
        public bool interactable;
        
        public Element normal;
        public Element hovered;
        public Element pressed;
        public Element disabled;
        public Element open;

        public Element menu;

        public bool focusable;
        public bool autoFocus;

        public Action<bool> onOpen;
    }

    [RishValueType]
    public struct DropdownButtonState
    {
        public bool open;
    }
}