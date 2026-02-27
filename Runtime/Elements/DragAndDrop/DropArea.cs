using System;
using RishUI;
using RishUI.Events;

namespace Roots
{
    public partial class DropArea<T> : RishElement<DropAreaProps<T>, DropAreaState>, IMountingListener, IPropsListener where T : struct
    {
        private DragAndDropContext Context { get; set; }
        private bool Set { get; set; }

        private T? Info { get; set; }

        public DropArea()
        {
            RegisterCallback<HoverStartEvent>(OnHoverStart);
            RegisterCallback<HoverEndEvent>(OnHoverEnd);
        }

        void IMountingListener.ElementDidMount()
        {
            Set = false;

            Context = GetFirstAncestorOfType<DragAndDropContext>();
            Context.RegisterDropArea(this);
        }

        void IMountingListener.ElementWillUnmount()
        {
            Context.UnregisterDropArea(this);
        }

        void IPropsListener.PropsDidChange()
        {
            Set = true;
            Context?.OnDropAreaUpdate(this);
        }

        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => State.dragging
            ? State.hovering
                ? State.acceptable
                    ? Props.hoveredAcceptedContent.Valid
                        ? Props.hoveredAcceptedContent
                        : Props.highlightedContent.Valid
                            ? Props.highlightedContent
                            : Props.content
                    : Props.hoveredRejectedContent.Valid
                        ? Props.hoveredRejectedContent
                        : Props.content
                : State.acceptable && Props.highlightedContent.Valid
                    ? Props.highlightedContent
                    : Props.content
            : Props.content;

        private void OnHoverStart(HoverStartEvent evt)
        {
            Context.DropAreaHoverStart(this);
        }

        private void OnHoverEnd(HoverEndEvent evt)
        {
            Context.DropAreaHoverEnd(this);
        }

        internal void SetHovering(bool hovering)
        {
            if (hovering && Info.HasValue)
            {
                HoverStarted(Info.Value);
            }
            if (State.hovering && !hovering)
            {
                HoverEnded();
            }

            RishSetHovering(hovering);
        }

        internal void OnInfo(T? info)
        {
            Info = info;
            if (info.HasValue)
            {
                SetDragging(true);
                SetAcceptable(CanDrop(info.Value));
            }
            else
            {
                SetDragging(false);
                SetAcceptable(false);
                SetHovering(false);
            }
        }

        internal bool CanAccept() => State.acceptable;

        private bool CanDrop(T info)
        {
            if (!Set)
            {
                return false;
            }
            
            return Props.canDropAction?.Invoke(info) ?? true;
        }
        internal void Drop(T info)
        {
            if (!CanDrop(info))
            {
                return;
            }

            DropAction(info);
        }
    }

    [RishValueType]
    public struct DropAreaProps<T> where T : struct
    {
        public Element content;
        public Element highlightedContent;
        public Element hoveredAcceptedContent;
        public Element hoveredRejectedContent;

        public Predicate<T> canDropAction;
        public Action<T> dropAction;
        public Action<T> hoverStarted;
        public Action hoverEnded;
    }

    [RishValueType]
    public struct DropAreaState
    {
        public bool dragging;
        public bool hovering;
        public bool acceptable;
    }
}