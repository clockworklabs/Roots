using RishUI;
using RishUI.Events;

namespace Roots
{
    public partial class Tooltip : RishElement<TooltipProps>, IMountingListener, IPropsListener
    {
        private TooltipsContext Context { get; set; }
        
        private bool Hovering { get; set; }

        public Tooltip()
        {
            RegisterCallback<HoverStartEvent>(OnHoverStart);
            RegisterCallback<HoverEndEvent>(OnHoverEnd);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<TooltipsContext>();

            Hovering = false;
        }

        void IMountingListener.ComponentWillUnmount()
        {
            HideTooltip();
        }

        void IPropsListener.PropsDidChange()
        {
            if (!Hovering)
            {
                return;
            }
            
            ShowTooltip();
        }

        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => Props.content;

        private void OnHoverStart(HoverStartEvent evt)
        {
            Hovering = true;
            
            ShowTooltip();
        }
        private void OnHoverEnd(HoverEndEvent evt)
        {
            Hovering = false;
            
            HideTooltip();
        }

        private void ShowTooltip() => Context?.ShowTooltip(this);
        private void HideTooltip() => Context?.HideTooltip(this);
    }

    [RishValueType]
    public struct TooltipProps
    {
        public Element content;
        public Element tooltip;
        public bool ignoreFit;
    }
}