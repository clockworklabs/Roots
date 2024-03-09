using System;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public interface IContextual
    {
        public Element Menu { get; }
    }
    
    public partial class ContextualContext : RishElement<ContextualContextProps>, IMountingListener
    {
        private IContextual Contextual { get; set; }
        private Menu Menu { get; set; }
        private Vector3 Position { get; set; }

        private VisualElement _focussedElement;
        private VisualElement FocussedElement
        {
            set
            {
                if (_focussedElement == value)
                {
                    return;
                }
                
                _focussedElement?.UnregisterCallback<PointerUpEvent>(OnPointerUp);

                if (Menu == null || !Menu.ContainsInTree(value))
                {
                    _focussedElement = null;
                    return;
                }

                _focussedElement = value;
                _focussedElement?.RegisterCallback<PointerUpEvent>(OnPointerUp);
            }
        }

        public ContextualContext()
        {
            RegisterCallback<PointerDownEvent>(OnPointerDown, EventPhase.TrickleDown);
            RegisterCallback<PointerUpEvent>(OnPointerUp, EventPhase.TrickleDown);
            
            RegisterCallback<PointerCaptureEvent>(OnPointerCapture);
            RegisterCallback<PointerCaptureOutEvent>(OnPointerRelease);
        }

        void IMountingListener.ComponentDidMount() { }
        void IMountingListener.ComponentWillUnmount()
        {
            Contextual = null;
            Menu = null;
            Position = Vector3.negativeInfinity;
            FocussedElement = null;
        }
        
        protected override Element Render()
        {
            var menu = Element.Null;
            var descriptor = Props.descriptor;
            if (Contextual != null)
            {
                menu = Menu.Create(new MenuProps
                {
                    position = Position,
                    element = Contextual.Menu
                });
                descriptor.style.pointerDetection = PointerDetectionMode.Rect;
            }
            
            return Div.Create(descriptor, children: new Children { Props.content, menu });
        }

        internal void ShowContextMenu(IContextual owner, Vector3 position)
        {
            Contextual = owner;
            Position = position;
            Dirty();
            
            Props.onShow?.Invoke(true);
        }

        internal void HideContextMenu(IContextual owner)
        {
            if (owner != Contextual)
            {
                return;
            }

            HideContextMenu();
        }
        
        internal void RegisterMenu(Menu menu) {
            if (Menu != null)
            {
                throw new UnityException("Context is already showing a menu");
            }

            Menu = menu;
        }
        internal void UnregisterMenu(Menu menu) {
            if (Menu != menu)
            {
                throw new UnityException("Context is showing a different menu");
            }

            Menu = null;
        }

        internal void HideContextMenu(Menu menu)
        {
            if (Menu != menu)
            {
                throw new UnityException("Context is showing a different menu");
            }

            HideContextMenu();
        }
        
        private void HideContextMenu()
        {
            Contextual = null;
            Dirty();
            
            Props.onShow?.Invoke(false);
        }

        private void OnPointerDown(PointerDownEvent evt)
        {
            if (Contextual == null || Menu == null || Position == evt.position)
            {
                return;
            }

            if (Menu.WorldContentRect.Contains(evt.position))
            {
                return;
            }
            
            HideContextMenu(Contextual);
        }

        private void OnPointerUp(PointerUpEvent evt)
        {
            if (Contextual == null || Menu == null || Position == evt.position)
            {
                return;
            }

            if (!Menu.WorldContentRect.Contains(evt.position))
            {
                return;
            }
            
            HideContextMenu(Contextual);
        }

        private void OnPointerCapture(PointerCaptureEvent evt) => FocussedElement = evt.target as VisualElement;
        private void OnPointerRelease(PointerCaptureOutEvent evt) => FocussedElement = null;
    }

    [RishValueType]
    public struct ContextualContextProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Element content;
        
        [IgnoreComparison]
        public Action<bool> onShow;
    }
}