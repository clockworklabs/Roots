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

        public DropdownContext()
        {
            RegisterCallback<PointerDownEvent>(OnPointerDown, EventPhase.TrickleDown);
            RegisterCallback<PointerUpEvent>(OnPointerUp, EventPhase.TrickleDown);
            RegisterCallback<PointerCaptureEvent>(OnPointerCapture);
            RegisterCallback<PointerCaptureOutEvent>(OnPointerRelease);
        }

        void IMountingListener.ComponentDidMount() { }
        void IMountingListener.ComponentWillUnmount()
        {
            DropdownButton = null;
            Dropdown = null;
            FocusedElement = null;
        }

        protected override Element Render()
        {
            var menu = Element.Null;
            var descriptor = Props.descriptor;

            if (DropdownButton != null)
            {
                // TODO: Support transformed elements
                var localRect = WorldToLocal(DropdownButton.WorldBoundingBox);

                menu = DropdownHolder.Create(
                    rect: localRect,
                    element: InternalDropdown.Create(
                        element: DropdownButton.Props.menu));
                
                descriptor.style.pointerDetection = PointerDetectionMode.Rect;
            }
            
            return Div.Create(descriptor, children: new Children { Props.content, menu });
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
            
            DropdownButton = owner;
            Dirty();
            
            DropdownButton.OnOpen();
            
            Props.onShow?.Invoke(true);
        }

        internal void HideDropdownMenu(DropdownButton owner)
        {
            if (owner != DropdownButton)
            {
                return;
            }

            DropdownButton.OnClose();

            DropdownButton = null;
            Dirty();
            
            Props.onShow?.Invoke(false);
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

        private void OnPointerDown(PointerDownEvent evt)
        {
            if (DropdownButton == null || Dropdown == null)
            {
                return;
            }

            var worldPosition = evt.position;
            
            // Ignore pointer events on dropdown button. These are handled by the button
            if (DropdownButton.ContainsPoint(DropdownButton.WorldToLocal(worldPosition)))
            {
                return;
            }

            if (Dropdown.ContainsPoint(Dropdown.WorldToLocal(worldPosition)))
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
            if (DropdownButton.ContainsPoint(DropdownButton.WorldToLocal(worldPosition)))
            {
                return;
            }
        
            if (!Dropdown.ContainsPoint(Dropdown.WorldToLocal(worldPosition)))
            {
                return;
            }
            
            HideDropdownMenu(DropdownButton);
        }

        private void OnPointerCapture(PointerCaptureEvent evt) => FocusedElement = evt.target as VisualElement;
        private void OnPointerRelease(PointerCaptureOutEvent evt) => FocusedElement = null;
    }

    [RishValueType]
    public struct DropdownContextProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public bool forceFit;
        public Element content;

        [IgnoreComparison]
        public Action<bool> onShow;
    }
}