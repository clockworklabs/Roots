using RishUI;
using RishUI.Events;

namespace Roots
{
    internal partial class InternalDropdown : RishElement<InternalDropdownProps>, IMountingListener
    {
        private DropdownContext Context { get; set; }
        private DropdownHolder Holder { get; set; }

        public InternalDropdown()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }

        void IMountingListener.ElementDidMount()
        {
            Holder = GetFirstAncestorOfType<DropdownHolder>();
            Context = GetFirstAncestorOfType<DropdownContext>();
            Context.RegisterDropdown(this);
        }

        void IMountingListener.ElementWillUnmount()
        {
            Context.UnregisterDropdown(this);
        }

        protected override Element Render() => Props.element;

        private void OnVisualChange(VisualChangeEvent evt) => Holder.OnLayout(WorldLayout);
    }

    [RishValueType]
    public struct InternalDropdownProps
    {
        public Element element;
    }
}