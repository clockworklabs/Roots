using System.Linq;
using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class UtilitiesSample
    {
        public partial class Example : RishElement<ExampleProps>
        {
            protected override Element Render()
            {
                var className = Props.attributes.className + Utilities.PaddingLeft3().PaddingTop4().PaddingBottom4().PaddingRight2();
                if (!className.Any(cn => cn.StartsWith("bg-")))
                {
                    className.Add(Utilities.BackgroundBodyTertiary());
                }
                
                return Div.Create(name: Props.attributes.name, className: className, style: Props.attributes.style, children: Body.Create(text: Props.text));
            }
        }

        [RishValueType]
        public struct ExampleProps
        {
            [Expand]
            public VisualAttributes attributes;
            public RishString text;
        }
    }
}