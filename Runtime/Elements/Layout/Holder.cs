using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine.UIElements;

namespace Roots
{
    internal partial class Holder : RishElement<HolderProps>, IMountingListener
    {
        private VisualElement _visualChild;
        private VisualElement VisualChild
        {
            set
            {
                if (_visualChild == value) return;
                if (_visualChild != null)
                {
                    _visualChild.userData = null;
                }
                _visualChild = value;
                if (value != null)
                {
                    value.userData = this;
                }
            }
        }

        public Holder()
        {
            RegisterCallback(SappyOnVisualChange.Callback, EventPhase.AtTargetOnly);
        }
        
        void IMountingListener.ComponentDidMount() { }
        void IMountingListener.ComponentWillUnmount()
        {
            VisualChild = null;
        }

        protected override Element Render() => Props.content;
        
        [SapTarget(typeof(EventCallback<VisualChangeEvent>))]
        private void OnVisualChange(VisualChangeEvent evt) => VisualChild = evt.currentTarget as VisualElement;
    }

    [RishValueType]
    internal struct HolderProps
    {
        public int index;
        public Element content;
    }
}