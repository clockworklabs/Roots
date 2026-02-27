using Motion;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Tooltip : RishElement<TooltipProps>, IMountingListener, IPropsListener
    {
        private TooltipsContext Context { get; set; }
        
        private bool Showing { get; set; }

        private InternalTooltip _internal;
        private InternalTooltip Internal
        {
            get => _internal;
            set
            {
                if (_internal == value) return;

                if (_internal != null)
                {
                    HoveringInternal = false;
                    _internal.UnregisterCallback<HoverStartEvent>(SappyOnInternalHoverStart);
                    _internal.UnregisterCallback<HoverEndEvent>(SappyOnInternalHoverEnd);
                }
                
                _internal = value;

                if (value != null)
                {
                    value.RegisterCallback<HoverStartEvent>(SappyOnInternalHoverStart);
                    value.RegisterCallback<HoverEndEvent>(SappyOnInternalHoverEnd);
                }
            }
        }
        
        private bool _hoveringContent;
        private bool HoveringContent
        {
            get => _hoveringContent;
            set
            {
                if (_hoveringContent == value) return;
                
                _hoveringContent = value;

                UpdateHovering();
            }
        }
        private bool _hoveringInternal;
        private bool HoveringInternal
        {
            get => _hoveringInternal;
            set
            {
                if (_hoveringInternal == value) return;
                
                _hoveringInternal = value;

                UpdateHovering();
            }
        }
        
        private bool _hovering;
        private bool Hovering
        {
            get => _hovering;
            set
            {
                if (_hovering == value) return;
                
                _hovering = value;

                if (value)
                {
                    StartEnter();
                }
                else
                {
                    StartExit();
                }
            }
        }
        
        private CountdownId Countdown { get; set; }

        public Tooltip()
        {
            RegisterCallback<HoverStartEvent>(OnHoverStart);
            RegisterCallback<HoverEndEvent>(OnHoverEnd);
        }
        
        void IMountingListener.ElementDidMount()
        {
            Context = GetFirstAncestorOfType<TooltipsContext>();

        }
        void IMountingListener.ElementWillUnmount()
        {
            HideTooltip();
            
            Showing = false;
            _hoveringContent = false;
            _hoveringInternal = false;
            _hovering = false;

            Internal = null;
            
            Countdown.Stop();
        }

        void IPropsListener.PropsDidChange()
        {
            if (!Showing) return;
            
            ShowTooltip();
        }
        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => Props.content;

        private void OnHoverStart(HoverStartEvent evt) => HoveringContent = true;
        private void OnHoverEnd(HoverEndEvent evt) => HoveringContent = false;

        [SapTarget(typeof(EventCallback<HoverStartEvent>))]
        private void OnInternalHoverStart(HoverStartEvent evt) => HoveringInternal = true;
        [SapTarget(typeof(EventCallback<HoverEndEvent>))]
        private void OnInternalHoverEnd(HoverEndEvent evt) => HoveringInternal = false;
        
        internal void SetInternal(InternalTooltip value) => Internal = value;

        private void StartEnter()
        {
            Countdown.Stop();
            
            if(Showing) return;
            
            if(Props.enterDelay > 0)
            {
                Countdown = DoMotion.Countdown(Props.enterDelay, SappyShowTooltip);
            }
            else
            {
                ShowTooltip();
            }
        }
        private void StartExit()
        {
            Countdown.Stop();
            
            if(!Showing) return;
            
            if(Props.exitDelay > 0)
            {
                Countdown = DoMotion.Countdown(Props.exitDelay, SappyHideTooltip);
            }
            else
            {
                HideTooltip();
            }
        }

        [SapTarget]
        private void ShowTooltip()
        {
            Showing = true;
            Context?.ShowTooltip(this);
        }

        [SapTarget]
        private void HideTooltip()
        {
            Showing = false;
            Context?.HideTooltip(this);
        }
        
        private void UpdateHovering() => Hovering = HoveringContent || HoveringInternal;
    }

    [RishValueType]
    public struct TooltipProps
    {
        public Element content;
        public Element tooltip;
        public bool ignoreFit;
        public float enterDelay;
        public float exitDelay;
    }
}