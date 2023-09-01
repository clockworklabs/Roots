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
        private DropdownMenu DropdownMenu { get; set; }

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

                if (DropdownMenu == null || !DropdownMenu.ContainsInTree(value))
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
            DropdownMenu = null;
            FocusedElement = null;
        }

        protected override Element Render()
        {
            var menu = Element.Null;
            var descriptor = Props.descriptor;

            if (DropdownButton != null)
            {
                menu = Roots.DropdownMenu.Create(new DropdownMenuProps
                {
                    rect = DropdownButton.WorldLayout,
                    element = DropdownButton.Props.menu
                });
                descriptor.style.pointerDetection = PointerDetectionMode.Rect;
            }


            return Div.Create(descriptor, children: new Children { Props.content, menu });
        }

        internal void ShowDropdownMenu(DropdownButton owner)
        {
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

        internal void RegisterDropdownMenu(DropdownMenu menu)
        {
            if (DropdownMenu != null)
            {
                throw new UnityException("Context is already showing a dropdown menu");
            }

            DropdownMenu = menu;
        }
        internal void UnregisterDropdownMenu(DropdownMenu menu)
        {
            if (DropdownMenu != menu)
            {
                throw new UnityException("Context is showing a different menu");
            }

            DropdownMenu = null;
        }

        private void OnPointerDown(PointerDownEvent evt)
        {
            if (DropdownButton == null || DropdownMenu == null)
            {
                return;
            }

            // Ignore pointer events on dropdown button. These are handled by the button
            if (DropdownButton.WorldContentRect.Contains(evt.position))
            {
                return;
            }

            if (DropdownMenu.WorldContentRect.Contains(evt.position))
            {
                return;
            }

            HideDropdownMenu(DropdownButton);
        }

        private void OnPointerUp(PointerUpEvent evt)
        {
            if (DropdownButton == null || DropdownMenu == null)
            {
                return;
            }

            // Ignore pointer events on dropdown button. These are handled by the button
            if (DropdownButton.WorldContentRect.Contains(evt.position))
            {
                return;
            }

            if (!DropdownMenu.WorldContentRect.Contains(evt.position))
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
        public Element content;

        [IgnoreComparison]
        public Action<bool> onShow;
    }
}