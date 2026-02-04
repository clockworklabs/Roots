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
        
        protected override Element Render() => Div.Create(
            descriptor: Props.descriptor + new Style
            {
                maxWidth = State.width ?? Length.Percent(100),
                marginLeft = Length.Auto(),
                marginRight = Length.Auto(),
                alignSelf = Align.Center,
            },
            children: Props.children);

        [SapTarget]
        private void OnContextLayout(ResponsiveContext.LayoutData data)
        {
            if (data.size >= Props.breakpoint)
            {
                SetWidth(Context.GetMinWidth(data.size));
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
        public ResponsiveContext.Size breakpoint;
        public Children children;
    }

    [RishValueType]
    public struct ContainerState
    {
        public float? width;
    }
}
