using RishUI.Events;

namespace RishWindows
{
    public class WindowFocusEvent : RishEventBase<WindowFocusEvent>
    {
        public int WindowIndex { get; private set; }
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
        
        public static WindowFocusEvent GetPooled(int windowIndex, WindowsContext context, IRishEventTarget target)
        {
            var pooled = RishEventBase<WindowFocusEvent>.GetPooled();
            pooled.WindowIndex = windowIndex;
            pooled.Context = context;
            
            pooled.target = target;

            return pooled;
        }
    }
}