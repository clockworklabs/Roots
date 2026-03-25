using RishUI;
using Sappy;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Container : RishElement<ContainerProps, ContainerState>, IMountingListener, IPropsListener<ContainerProps>
    {
        private ResponsiveContext _context;
        private ResponsiveContext Context
        {
            get => _context;
            set
            {
                if (_context == value) return;
                
                _context?.OnLayout.Remove(Sappy.OnContextLayout);
                
                _context = value;

                value?.OnLayout.Add(Sappy.OnContextLayout);

                OnContextLayout(value?.GetLayoutData());
            }
        }
        
        void IMountingListener.ElementDidMount() { }
        void IMountingListener.ElementWillUnmount()
        {
            Context = null;
        }

        void IPropsListener<ContainerProps>.PropsDidChange(ContainerProps? prev)
        {
            if (prev.HasValue) return;
            Context = GetFirstAncestorOfType<ResponsiveContext>();
        }
        void IPropsListener<ContainerProps>.PropsWillChange() { }

        protected override Element Render()
        {
            var style = new Style
            {
                width = Length.Percent(100),
                marginLeft = Length.Auto(),
                marginRight = Length.Auto(),
                alignSelf = Align.Center
            };
            if (State.width.HasValue)
            {
                style.maxWidth = State.width.Value;
            }
            
            return Div.Create(attributes: Props.attributes + style, children: Props.content);
        }

        [SapTarget]
        private void OnContextLayout(ResponsiveContext.LayoutData data) => SetBreakpoint(data.breakpoint);
        private void OnContextLayout(ResponsiveContext.LayoutData? data) => SetBreakpoint(data?.breakpoint);

        [SapTarget]
        private void SetBreakpoint(ResponsiveBreakpoint? value)
        {
            if (value.HasValue && value.Value >= Props.breakpoint)
            {
                SetWidth(Context.GetMinWidth(value.Value));
            }
            else
            {
                SetWidth(null);
            }
        }
    }

    [RishValueType]
    public struct ContainerProps
    {
        [Expand]
        public VisualAttributes attributes;
        public ResponsiveBreakpoint breakpoint;
        public Element content;
    }

    [RishValueType]
    public struct ContainerState
    {
        public float? width;
    }
}
