using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;
using Translate = UnityEngine.UIElements.Translate;

namespace Roots
{
    internal partial class DropdownMenu : RishElement<DropdownMenuProps, DropdownMenuState>, IMountingListener, IPropsListener
    {
        private DropdownContext Context { get; set; }

        public DropdownMenu()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }

        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<DropdownContext>();
            Context.RegisterDropdownMenu(this);
        }
        void IMountingListener.ComponentWillUnmount()
        {
            Context?.UnregisterDropdownMenu(this);
        }

        void IPropsListener.PropsDidChange()
        {
            var state = State;

            state.style = new Style
            {
                position = Position.Absolute,
                left = Props.rect.x,
                top = Props.rect.y + Props.rect.height,
                width = Props.rect.width,
                visibility = Visibility.Hidden
            };

            State = state;
        }
        void IPropsListener.PropsWillChange() { }

        protected override Element Render()
        {
            return Div.Create(State.style, children: Props.element);
        }

        private void OnVisualChange(VisualChangeEvent evt)
        {
            var parentSize = Context.ContentRect.size;

            var state = State;
            state.style.translate = new Translate(
                0,
                new Length(Layout.yMax < parentSize.y ? 0 : -Layout.height - Props.rect.height),
                0
            );
            state.style.visibility = Visibility.Visible;
            State = state;
        }
    }

    [RishValueType]
    public struct DropdownMenuProps
    {
        public Rect rect;
        public Element element;
    }

    [RishValueType]
    public struct DropdownMenuState
    {
        public Style style;
    }
}