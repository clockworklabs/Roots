using Codice.Client.BaseCommands;
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
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<ContextualContext>();
            Context?.RegisterMenu(this);
        }
        void IMountingListener.ComponentWillUnmount() { 
            Context?.UnregisterMenu(this);
        }

        void IPropsListener.PropsDidChange()
        {
            var local = Context.WorldToLocal(Props.position);
            SetStyle(new Style
            {
                position = Position.Absolute,
                left = local.x,
                top = local.y,
                // visibility = Visibility.Hidden, // Changing visibility blurs the element
                opacity = 0
            });
            
        }
        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => Div.Create(State.style, children: Props.element);
        
        private void OnVisualChange(VisualChangeEvent evt)
        {
            var parentSize = Context.ContentRect.size;
            
            var style = State.style;
            style.translate = new Translate(
                new Length(Layout.xMax < parentSize.x ? 0 : -100, LengthUnit.Percent),
                new Length(Layout.yMax < parentSize.y ? 0 : -100, LengthUnit.Percent),
                0
            );
            style.opacity = 1;
            
            SetStyle(style);
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