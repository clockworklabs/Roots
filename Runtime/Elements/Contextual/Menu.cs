using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;
using Translate = UnityEngine.UIElements.Translate;

namespace Roots
{
    internal partial class Menu : RishElement<MenuProps, MenuState>, IMountingListener, IPropsListener
    {
        private ContextualContext Context { get; set; }
        
        public Menu()
        {
            RegisterCallback<KeyDownEvent>(OnKeyDown);
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<ContextualContext>();
            Context.RegisterMenu(this);
            
            Focusable();
            Focus();
        }
        void IMountingListener.ComponentWillUnmount() { 
            Context?.UnregisterMenu(this);
            
            if (HasFocus)
            {
                Blur();
            }
        }

        void IPropsListener.PropsDidChange()
        {
            var state = State;
            
            var local = Context.WorldToLocal(Props.position);
            state.style = new Style
            {
                position = Position.Absolute,
                left = local.x,
                top = local.y,
                // visibility = Visibility.Hidden, // Changing visibility blurs the element
                opacity = 0
            };
            
            State = state;
            
        }
        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => Div.Create(State.style, children: Props.element);

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (!HasFocus || evt.keyCode != KeyCode.Escape)
            {
                return;
            }

            Context.HideContextMenu(this);
        }

        private void OnVisualChange(VisualChangeEvent evt)
        {
            var parentSize = Context.ContentRect.size;

            var state = State;
            state.style.translate = new Translate(
                new Length(Layout.xMax < parentSize.x ? 0 : -100, LengthUnit.Percent),
                new Length(Layout.yMax < parentSize.y ? 0 : -100, LengthUnit.Percent),
                0
            );
            // state.style.visibility = Visibility.Visible;
            state.style.opacity = 1;
            State = state;
        }
    }

    [RishValueType]
    internal struct MenuProps
    {
        public Vector2 position;
        public Element element;
    }

    [RishValueType]
    internal struct MenuState
    {
        public Style style;
    }
}