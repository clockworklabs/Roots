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
                
                _context?.OnLayout.Remove(SappyOnContextLayout);
                
                _context = value;

                if (value != null)
                {
                    value.OnLayout.Add(SappyOnContextLayout);
                    OnContextLayout(value.GetLayoutData());
                }
            }
        }
        
        void IMountingListener.ComponentDidMount() { }
        void IMountingListener.ComponentWillUnmount()
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
            
            return Div.Create(descriptor: Props.descriptor + style, children: Props.content);
        }

        [SapTarget]
        private void OnContextLayout(ResponsiveContext.LayoutData data)
        {
            if (data.breakpoint >= Props.breakpoint)
            {
                SetWidth(Context.GetMinWidth(data.breakpoint));
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
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public ResponsiveBreakpoint breakpoint;
        public Element content;
    }

    [RishValueType]
    public struct ContainerState
    {
        public float? width;
    }
}
