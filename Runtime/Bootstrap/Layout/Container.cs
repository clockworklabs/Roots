using RishUI;

namespace Roots.Bootstrap
{
    public partial class Container : RishElement<ContainerProps>
    {
        protected override Element Render() => Div.Create(
            descriptor: Props.descriptor /*+ Props.fluid switch
            {
                Fluid.None => "container",
                Fluid.All => "container-fluid",
                Fluid.SM => "container-sm",
                Fluid.MD => "container-md",
                Fluid.LG => "container-lg",
                Fluid.XL => "container-xl",
                Fluid.XXL => "container-xxl"
            }*/,
            children: Props.children);
    }
    
    public enum Fluid { None, All, SM, MD, LG, XL, XXL }

    [RishValueType]
    public struct ContainerProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Fluid fluid;
        public Children children;
    }
}
