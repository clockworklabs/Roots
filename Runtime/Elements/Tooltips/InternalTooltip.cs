using RishUI;
using RishUI.Events;

namespace Roots
{
    internal partial class InternalTooltip : RishElement<InternalTooltipProps>, IMountingListener
    {
        private Holder Holder { get; set; }

        public InternalTooltip()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }

        void IMountingListener.ComponentDidMount()
        {
            Holder = GetFirstAncestorOfType<Holder>();
        }
        void IMountingListener.ComponentWillUnmount() { }

        protected override Element Render()
        {
            return Props.element;
        }

        private void OnVisualChange(VisualChangeEvent evt) => Holder.OnLayout(WorldLayout);
    }

    [RishValueType]
    public struct InternalTooltipProps
    {
        public Element element;
    }
}