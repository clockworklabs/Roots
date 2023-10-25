using RishUI;
using RishUI.Events;

namespace Roots
{
    internal partial class InternalTooltip : RishElement<InternalTooltipProps>, IMountingListener
    {
        private TooltipHolder TooltipHolder { get; set; }

        public InternalTooltip()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }

        void IMountingListener.ComponentDidMount()
        {
            TooltipHolder = GetFirstAncestorOfType<TooltipHolder>();
        }
        void IMountingListener.ComponentWillUnmount() { }

        protected override Element Render()
        {
            return Props.element;
        }

        private void OnVisualChange(VisualChangeEvent evt) => TooltipHolder.OnLayout(WorldLayout);
    }

    [RishValueType]
    public struct InternalTooltipProps
    {
        public Element element;
    }
}