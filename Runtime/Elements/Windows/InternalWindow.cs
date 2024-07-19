using RishUI;
using UnityEngine.UIElements;

namespace Roots
{
    internal partial class InternalWindow : RishElement<InternalWindowProps>, IMountingListener
    {
        private WindowsContext Context { get; set; }

        public InternalWindow()
        {
            RegisterCallback<PointerDownEvent>(OnPointerDown);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<WindowsContext>();
        }
        
        void IMountingListener.ComponentWillUnmount() { }
        
        protected override Element Render()
        {
            return Props.content;
        }

        private void OnPointerDown(PointerDownEvent evt)
        {
            Context.MoveToFront(Props.guid);
            
            evt.StopPropagation();
        }
    }

    [RishValueType]
    internal struct InternalWindowProps
    {
        public ulong guid;
        public Element content;
        public bool draggable;
        // public bool resizable;
    }
}