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

        void IMountingListener.ComponentDidMount()
        {
            RegisterCallback<HoverStartEvent>(OnHoverStart);
            RegisterCallback<HoverEndEvent>(OnHoverEnd);

            Set = false;

            Context = GetFirstAncestorOfType<DragAndDropContext>();
            Context.RegisterDropArea(this);
        }

        void IMountingListener.ComponentWillUnmount()
        {
            UnregisterCallback<HoverStartEvent>(OnHoverStart);
            UnregisterCallback<HoverEndEvent>(OnHoverEnd);

            Context.UnregisterDropArea(this);
        }

        void IPropsListener.PropsDidChange()
        {
            Set = true;
            Context?.OnDropAreaUpdate(this);
        }

        void IPropsListener.PropsWillChange() { }

        protected override Element Render()
        {
            var element = State.dragging
                ? State.hovering
                    ? State.acceptable
                        ? Props.hoveredAcceptedContent.Valid
                            ? Props.hoveredAcceptedContent
                            : State.acceptable && Props.highlightedContent.Valid
                                ? Props.highlightedContent
                                : Props.content
                        : Props.hoveredRejectedContent.Valid
                            ? Props.hoveredRejectedContent
                            : State.acceptable && Props.highlightedContent.Valid
                                ? Props.highlightedContent
                                : Props.content
                    : State.acceptable && Props.highlightedContent.Valid
                        ? Props.highlightedContent
                        : Props.content
                : Props.content;

            return element;
        }

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

            var state = State;
            state.hovering = hovering;
            SetState(state); // TODO
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

        private void HoverStarted(T info) => Props.hoverStarted?.Invoke(info);
        private void HoverEnded() => Props.hoverEnded?.Invoke();

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

            Props.dropAction?.Invoke(info);
        }
    }

    [RishValueType]
    public struct DropAreaProps<T> where T : struct
    {
        public Element content;
        public Element highlightedContent;
        public Element hoveredAcceptedContent;
        public Element hoveredRejectedContent;

        [IgnoreComparison]
        public Predicate<T> canDropAction;
        [IgnoreComparison]
        public Action<T> dropAction;
        [IgnoreComparison]
        public Action<T> hoverStarted;
        [IgnoreComparison]
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