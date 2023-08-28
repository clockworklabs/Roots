using RishUI;
using UnityEngine.UIElements;

namespace RishWindows
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
            Context.MoveWindowToFront(Props.index);
            
            evt.StopPropagation();
        }
    }

    [RishValueType]
    internal struct InternalWindowProps
    {
        public int index;
        public ulong nodeHashCode;
        public Element content;
        public bool draggable;
        // public bool resizable;
    }
}