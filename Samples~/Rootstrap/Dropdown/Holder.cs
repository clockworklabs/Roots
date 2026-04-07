using RishUI;
using RishUI.Events;

namespace Roots.Rootstrap
{
    public partial class SimpleDropdown
    {
        private partial class Holder : RishElement<HolderProps>, IMountingListener
        {
            private SimpleDropdown Dropdown { get; set; }

            public Holder()
            {
                RegisterCallback<VisualChangeEvent>(OnVisualChange);
            }
            
            void IMountingListener.ElementDidMount()
            {
                Dropdown = GetFirstAncestorOfType<SimpleDropdown>();
            }
            void IMountingListener.ElementWillUnmount()
            {
                Dropdown.OnSize(Props.index, 0);
            }
            
            protected override Element Render() => Props.content;

            private void OnVisualChange(VisualChangeEvent evt) => Dropdown.OnSize(Props.index, ContentRect.width);
        }

        [RishValueType]
        public struct HolderProps
        {
            public int? index;
            public Element content;
        }
    }
}