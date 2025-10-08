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
        private static ulong Key { get; set; }
        
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
        
        private VisualElement Root { get; set; }

        public ContextualContext()
        {
            RegisterCallback<PointerDownEvent>(OnPointerDown, EventPhase.TrickleDown);
            
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
            
            Root?.UnregisterCallback<KeyDownEvent>(OnKeyDown);
            Root = null;
        }
        
        protected override Element Render()
        {
            Children children;
            if (Contextual != null)
            {
                children = new Children
                {
                    Props.children,
                    PointerCapturer.Create(),
                    Menu.Create(
                        key: Key,
                        position: Position,
                        element: Contextual.Menu)
                };
            }
            else
            {
                children = Props.children;
            }
            
            return Div.Create(descriptor: Props.descriptor, children: children);
        }

        public void ShowContextMenu(IContextual owner, Vector3 position)
        {
            Key += 1;
            Contextual = owner;
            Position = position;
            Dirty();

            if (Root == null)
            {
                Root = GetFirstAncestorOfType<VisualElement>();
                while (Root?.parent != null)
                {
                    Root = Root.parent;
                }
            }
            Root?.RegisterCallback<KeyDownEvent>(OnKeyDown);
            
            OnShow(true);
        }

        public void HideContextMenu(IContextual owner)
        {
            if (owner != Contextual)
            {
                return;
            }

            Contextual = null;
            Dirty();
            
            Root?.UnregisterCallback<KeyDownEvent>(OnKeyDown);
            
            OnShow(false);
        }
        
        internal void RegisterMenu(Menu menu) {
            if (menu == null)
            {
                return;
            }

            Menu = menu;
        }
        internal void UnregisterMenu(Menu menu) {
            if (Menu != menu)
            {
                return;
            }

            Menu = null;
        }

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (evt.keyCode != KeyCode.Escape)
            {
                return;
            }
            
            HideContextMenu(Contextual);
        }
        
        private void OnPointerDown(PointerDownEvent evt)
        {
            if (Contextual == null || Menu == null || Position == evt.position || Menu.WorldContentRect.Contains(evt.position))
            {
                return;
            }
            
            HideContextMenu(Contextual);
        }

        private void OnPointerUp(PointerUpEvent evt)
        {
            if (Contextual == null || Menu == null)
            {
                return;
            }
            
            HideContextMenu(Contextual);
        }

        private void OnPointerCapture(PointerCaptureEvent evt) => FocussedElement = evt.target as VisualElement;
        private void OnPointerRelease(PointerCaptureOutEvent evt) => FocussedElement = null;

        private partial class PointerCapturer : RishElement
        {
            protected override Element Render() => Div.Create(
                style: new Style
                {
                    position = UnityEngine.UIElements.Position.Absolute,
                    pointerDetection = PointerDetectionMode.Rect,
                    top = 0,
                    right = 0,
                    bottom = 0,
                    left = 0
                });
        }
    }

    [RishValueType]
    public struct ContextualContextProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
        
        public Action<bool> onShow;
    }
}