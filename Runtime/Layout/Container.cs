using System;
using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class Container : RishElement<ContainerProps>
    {
        protected override Element Render()
        {
            var containerClass = Props.fluid switch
            {
                Fluid.None => "container",
                Fluid.All => "container-fluid",
                Fluid.SM => "container-sm",
                Fluid.MD => "container-md",
                Fluid.LG => "container-lg",
                Fluid.XL => "container-xl",
                Fluid.XXL => "container-xxl",
                _ => throw new ArgumentOutOfRangeException()
            };

            return Div.Create(className: containerClass, children: Props.children);
        }
    }
    
    public enum Fluid { None, All, SM, MD, LG, XL, XXL }

    [RishValueType]
    public struct ContainerProps
    {
        public Fluid fluid;
        public Utilities utilities;
        public Children children;
    }
}
