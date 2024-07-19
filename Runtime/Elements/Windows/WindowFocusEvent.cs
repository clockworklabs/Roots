using RishUI.Events;

namespace Roots
{
    public class WindowFocusEvent : RishEventBase<WindowFocusEvent>
    {
        public ulong WindowGUID { get; private set; }
        internal WindowsContext Context { get; private set; }
        public WindowFocusEvent() => LocalInit();

        protected override void Init()
        {
            base.Init();
            LocalInit();
        }

        private void LocalInit()
        {
            tricklesDown = true;
            bubbles = true;
        }
        
        public static WindowFocusEvent GetPooled(ulong guid, WindowsContext context, IRishEventTarget target)
        {
            var pooled = RishEventBase<WindowFocusEvent>.GetPooled();
            pooled.WindowGUID = guid;
            pooled.Context = context;
            
            pooled.target = target;

            return pooled;
        }
    }
}