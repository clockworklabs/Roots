using System;
using RishUI;
using Sappy;

namespace Roots
{
    public partial class DropdownButton : RishElement<DropdownButtonProps, DropdownButtonState>, IMountingListener, IPropsListener
    {
        private DropdownContext Context { get; set; }

        void IMountingListener.ElementDidMount()
        {
            Context = GetFirstAncestorOfType<DropdownContext>();
        }
        void IMountingListener.ElementWillUnmount()
        {
            Context?.HideDropdownMenu(this);
        }

        void IPropsListener.PropsDidChange()
        {
            if (State.open)
            {
                Context.ShowDropdownMenu(this);
            }
        }
        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => AbstractButton.Create(
            action: Sappy.DoAction,
            normal: State.open && Props.open.Valid ? Props.open : Props.normal,
            hovered: State.open && Props.open.Valid ? Props.open : Props.hovered,
            pressed: State.open && Props.open.Valid ? Props.open : Props.pressed,
            disabled: State.open && Props.open.Valid ? Props.open : Props.disabled,
            interactable: Props.interactable);

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
        
        public Action<bool> onOpen;

        [Default]
        private static DropdownButtonProps Default => new()
        {
            interactable = true
        };
    }

    [RishValueType]
    public struct DropdownButtonState
    {
        public bool open;
    }
}