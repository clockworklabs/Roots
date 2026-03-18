using RishUI;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{
	public partial class ButtonsSample
	{
        private partial class Group : RishElement<GroupProps>
        {
            protected override Element Render() => Col.Create(
                gap: 8,
                children: new Children
                {
                    H4.Create(text: Props.title),
                    Row.Create(className: "align-items-center", gap: 4, children: Props.children),
                });
        }

        [RishValueType]
        public struct GroupProps
        {
            public RishString title;
            public Children children;
        }
	}
}