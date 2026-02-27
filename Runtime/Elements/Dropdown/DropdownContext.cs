using System;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class DropdownContext : RishElement<DropdownContextProps>, IMountingListener
    {
        private DropdownButton DropdownButton { get; set; }
        private InternalDropdown Dropdown { get; set; }

        private VisualElement _focusedElement;
        private VisualElement FocusedElement
        {
            set
            {
                if (_focusedElement == value)
                {
                    return;
                }

                _focusedElement?.UnregisterCallback<PointerUpEvent>(OnPointerUp);

                if (Dropdown == null || !Dropdown.ContainsInTree(value))
                {
                    _focusedElement = null;
                    return;
                }

                _focusedElement = value;
                _focusedElement?.RegisterCallback<PointerUpEvent>(OnPointerUp);
            }
        }
        
        private VisualElement Root { get; set; }

        public DropdownContext()
        {
            RegisterCallback<PointerDownEvent>(OnPointerDown, EventPhase.TrickleDown);
            RegisterCallback<PointerUpEvent>(OnPointerUp, EventPhase.TrickleDown);
            RegisterCallback<PointerCaptureEvent>(OnPointerCapture);
            RegisterCallback<PointerCaptureOutEvent>(OnPointerRelease);
            RegisterCallback<HideDropdownEvent>(OnDropdownClose);
        }

        void IMountingListener.ElementDidMount() { }
        void IMountingListener.ElementWillUnmount()
        {
            DropdownButton = null;
            Dropdown = null;
            FocusedElement = null;
            
            Root?.UnregisterCallback<KeyDownEvent>(OnKeyDown);
            Root = null;
        }

        protected override Element Render()
        {
            Children children;
            
            if (DropdownButton != null)
            {
                // TODO: Support transformed elements
                var localRect = WorldToLocal(DropdownButton.WorldBoundingBox);

                children = new Children
                {
                    Props.children,
                    PointerCapturer.Create(),
                    DropdownHolder.Create(rect: localRect, element: InternalDropdown.Create(element: DropdownButton.Props.menu))
                };
            }
            else
            {
                children = Props.children;
            }
            
            return Div.Create(descriptor: Props.descriptor, children: children);
        }

        internal void ShowDropdownMenu(DropdownButton owner)
        {
            if (DropdownButton != null)
            {
                if (DropdownButton == owner)
                {
                    Dirty();
                }
                
                return;
            }

            if (Root == null)
            {
                Root = GetFirstAncestorOfType<VisualElement>();
                while (Root?.parent != null)
                {
                    Root = Root.parent;
                }
            }
            Root?.RegisterCallback<KeyDownEvent>(OnKeyDown);
            
            DropdownButton = owner;
            DropdownButton.OnOpen();
            Dirty();
            
            OnShow(true);
        }

        internal void HideDropdownMenu(DropdownButton owner)
        {
            if (owner != DropdownButton)
            {
                return;
            }
            
            Root?.UnregisterCallback<KeyDownEvent>(OnKeyDown);

            DropdownButton.OnClose();
            DropdownButton = null;
            Dirty();
            
            OnShow(false);
        }

        internal void RegisterDropdown(InternalDropdown menu)
        {
            if (Dropdown != null)
            {
                throw new UnityException("Context is already showing a dropdown menu");
            }

            Dropdown = menu;
        }
        internal void UnregisterDropdown(InternalDropdown menu)
        {
            if (Dropdown != menu)
            {
                throw new UnityException("Context is showing a different menu");
            }

            Dropdown = null;
        }

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (evt.keyCode != KeyCode.Escape)
            {
                return;
            }
            
            HideDropdownMenu(DropdownButton);
        }

        private void OnPointerDown(PointerDownEvent evt)
        {
            if (DropdownButton == null || Dropdown == null)
            {
                return;
            }

            var worldPosition = evt.position;
            
            // Ignore pointer events on dropdown button. These are handled by the button
            if (DropdownButton.ContainsPoint(DropdownButton.WorldToLocal(worldPosition)) || DropdownButton.WorldContentRect.Contains(worldPosition))
            {
                return;
            }

            if (Dropdown.ContainsPoint(Dropdown.WorldToLocal(worldPosition)) || Dropdown.WorldContentRect.Contains(worldPosition))
            {
                return;
            }

            HideDropdownMenu(DropdownButton);
        }

        private void OnPointerUp(PointerUpEvent evt)
        {
            if (DropdownButton == null || Dropdown == null)
            {
                return;
            }

            var worldPosition = evt.position;
        
            // Ignore pointer events on dropdown button. These are handled by the button
            if (DropdownButton.ContainsPoint(DropdownButton.WorldToLocal(worldPosition)) || DropdownButton.WorldContentRect.Contains(worldPosition))
            {
                return;
            }
        
            if (!Dropdown.ContainsPoint(Dropdown.WorldToLocal(worldPosition)) && !Dropdown.WorldContentRect.Contains(worldPosition))
            {
                return;
            }

            var target = evt.target;
            
            using var closeEvt = HideDropdownEvent.GetPooled(target);
            target.SendEvent(closeEvt);
        }

        private void OnDropdownClose(HideDropdownEvent evt) => HideDropdownMenu(DropdownButton);

        private void OnPointerCapture(PointerCaptureEvent evt) => FocusedElement = evt.target as VisualElement;
        private void OnPointerRelease(PointerCaptureOutEvent evt) => FocusedElement = null;

        private partial class PointerCapturer : RishElement
        {
            protected override Element Render() => Div.Create(
                style: new Style
                {
                    position = Position.Absolute,
                    pointerDetection = PointerDetectionMode.Rect,
                    top = 0,
                    right = 0,
                    bottom = 0,
                    left = 0
                });
        }
    }

    [RishValueType]
    public struct DropdownContextProps
    {
        [Expand]
        public VisualAttributes descriptor;
        public bool forceFit;
        public Children children;

        public Action<bool> onShow;
    }
}