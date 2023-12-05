using System;
using System.Collections.Generic;
using RishUI;
using Roots;

namespace Roots
{
    public partial class TooltipsContext : RishElement<TooltipsContextProps>, IManualState
    {
        private HashSet<Tooltip> Tooltips { get; } = new();
        private Stack<Tooltip> Stack { get; } = new();
        
        private uint Count { get; set; }
        
        void IManualState.Restart()
        {
            Tooltips.Clear();
            Stack.Clear();

            Count = 0;
        }
        
        protected override Element Render()
        {
            var content = Props.content;
            
            var tooltip = Children.Null;
            if (!Props.hideTooltips && Stack.Count > 0)
            {
                var owner = Stack.Peek();
                // TODO: Support transformed elements
                var localRect = WorldToLocal(owner.WorldBoundingBox);

                tooltip = TooltipHolder.Create(Count, 
                    rect: localRect,
                    ignoreFit: owner.Props.ignoreFit,
                    element: InternalTooltip.Create(new InternalTooltipProps
                    {
                        element = owner.Props.tooltip
                    }));
            }

            return Div.Create(descriptor: Props.descriptor, children: new Children { content, tooltip });
        }
        
        internal void ShowTooltip(Tooltip owner)
        {
            var forceRender = false;
            if (Tooltips.Contains(owner))
            {
                if (Stack.Peek() == owner)
                {
                    forceRender = true;
                }
            }
            else
            {
                Count++;
                
                Tooltips.Add(owner);
                Stack.Push(owner);
                forceRender = true;
            }

            if (Count == 1)
            {
                Props.onShow?.Invoke(true);
            }

            if (forceRender)
            {
                Dirty();
            }
        }

        internal void HideTooltip(Tooltip owner)
        {
            if (!Tooltips.Remove(owner))
            {
                return;
            }

            var forceRender = false;
            while(Stack.Count > 0 && !Tooltips.Contains(Stack.Peek()))
            {
                Stack.Pop();
                if(Stack.Count > 0) {
                    Count++;
                }
                forceRender = true;
            }

            if (Count == 0)
            {
                Props.onShow?.Invoke(false);
            }

            if (forceRender)
            {
                Dirty();
            }
        }
    }

    [RishValueType]
    public struct TooltipsContextProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children content;
        public bool forceFit;
        public bool hideTooltips;

        [IgnoreComparison]
        public Action<bool> onShow;
    }
}