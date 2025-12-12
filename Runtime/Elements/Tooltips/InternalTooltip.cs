using RishUI;
using RishUI.Events;

namespace Roots
{
    internal partial class InternalTooltip : RishElement<InternalTooltipProps>, IMountingListener
    {
        private TooltipHolder Holder { get; set; }
        
        private Tooltip _tooltip;
        private Tooltip Tooltip
        {
            set
            {
                if (_tooltip == value) return;
                
                _tooltip?.SetInternal(null);
                _tooltip = value;
                value?.SetInternal(this);
            }
        }

        public InternalTooltip()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }

        void IMountingListener.ComponentDidMount()
        {
            Holder = GetFirstAncestorOfType<TooltipHolder>();
            var context = GetFirstAncestorOfType<TooltipsContext>();
            Tooltip = context.Peek();
        }
        void IMountingListener.ComponentWillUnmount()
        {
            Holder = null;
            Tooltip = null;
        }

        protected override Element Render() => Props.element;

        private void OnVisualChange(VisualChangeEvent evt) => Holder.OnLayout(WorldLayout);
    }

    [RishValueType]
    public struct InternalTooltipProps
    {
        public Element element;
    }
}