using UnityEngine.UIElements;

namespace Roots
{
    public class HideDropdownEvent : EventBase<HideDropdownEvent>
    {
        public HideDropdownEvent() => LocalInit();

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
        
        public static HideDropdownEvent GetPooled(IEventHandler target)
        {
            var pooled = EventBase<HideDropdownEvent>.GetPooled();
            pooled.target = target;

            return pooled;
        }
    }
}