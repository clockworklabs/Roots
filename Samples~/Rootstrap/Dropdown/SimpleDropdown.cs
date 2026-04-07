using System;
using System.Collections.Generic;
using RishUI;
using RishUI.MemoryManagement;
using Roots.Experimental.Rootstrap;
using Sappy;
using UnityEngine;

namespace Roots.Rootstrap
{
    public partial class SimpleDropdown : RishElement<SimpleDropdownProps, SimpleDropdownState>, IManualState
    {
        private Dictionary<int, float> Widths { get; } = new();
        
        void IManualState.Restart()
        {
            Widths.Clear();
        }
        
        protected override Element Render()
        {
            var n = Props.options.Count;
            var options = new Children();
            for(var i = 0; i < n; i++)
            {
                options.Add(Option.Create(index: i, active: Props.index == i, text: Props.options[i], action: Sappy.DoAction));
            }
            
            var menuClassName = "dropdown-menu".OverflowHidden().PointerDetection();
            
            return DropdownButton.Create(
                interactable: Props.interactable,
                normal: CreateContent(false),
                open: CreateContent(true),
                menu: n <= 6
                    ? Col.Create(
                        className: menuClassName,
                        children: options)
                    : Div.Create(
                        className: menuClassName + "with-scroll",
                        children: VScrollView.Create(interactableScrollBar: false, children: options)));
        }

        [RequiresManagedContext]
        private Element CreateContent(bool open)
        {
            var children = new Children();
            for(int i = -1, n = Props.options.Count; i < n; i++)
            {
                bool visible;
                RishString text;
                if (i < 0)
                {
                    visible = Props.index < 0 || Props.index >= Props.options.Count;
                    text = Props.placeholder;
                }
                else
                {
                    visible = Props.index == i;
                    text = Props.options[i];
                }
                
                if(text.IsEmpty) continue;

                var className = visible
                    ? Utilities.Visible().PositionRelative()
                    : Utilities.Invisible().PositionAbsolute();
                if (i < 0)
                {
                    className.Add(Utilities.Opacity25());
                }

                children.Add(Holder.Create(
                    index: i,
                    content: Body.Create(
                        className: className,
                        text: text)));
            }
            return Button.Create(
                attributes: Props.attributes + new Style
                {
                    width = State.width,
                },
                variant: Props.variant,
                size: Props.size,
                active: open,
                children: Row.Create(
                    className: Utilities.AlignItemsCenter().JustifyContentBetween(),
                    gap: 8,
                    children: new Children
                    {
                        children,
                        Holder.Create(content: Icon.Create(unicode: open ? FontAwesome.FA_ChevronUp : FontAwesome.FA_ChevronDown))
                    }));
        }

        private void OnSize(int? index, float width)
        {
            if (index.HasValue)
            {
                var indexValue = index.Value;
                if (Widths.TryGetValue(indexValue, out var currentWidth) && width < currentWidth && Mathf.Approximately(currentWidth, State.maxWidth))
                {
                    Widths[indexValue] = width;
                    var maxWidth = float.MinValue;
                    for (int i = -1, n = Props.options.Count; i < n; i++)
                    {
                        if (Widths.TryGetValue(i, out var w) && w > maxWidth)
                        {
                            maxWidth = w;
                        }
                    }
                    SetMaxWidth(width);
                }
                else
                {
                    Widths[indexValue] = width;
                    if (width > State.maxWidth)
                    {
                        SetMaxWidth(width);
                    }
                }
            }
            else
            {
                SetIconWidth(width);
            }
        }

        [SapTarget]
        private void DoAction(int index)
        {
            if (index == Props.index && !Props.placeholder.IsEmpty)
            {
                index = -1;
            }

            Action(index);
        }
    }

    [RishValueType]
    public struct SimpleDropdownProps
    {
        [Expand]
        public VisualAttributes attributes;

        [DefaultValue(true)]
        public bool interactable;
        
        [DefaultValue(Button.Variant.Primary)]
        public Button.Variant variant;
        public Button.Size size;
        
        public RishString placeholder;
        public int index;
        public RishList<RishString> options;

        public Action<int> action;
    }

    [RishValueType]
    public struct SimpleDropdownState
    {
        public float maxWidth;
        public float iconWidth;

        public float width => maxWidth + 34 + iconWidth;
    }
}
