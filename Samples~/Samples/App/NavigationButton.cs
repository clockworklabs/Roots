using System;
using RishUI;
using Roots;
using Sappy;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class SamplesApp
    {
        public partial class NavigationButton : RishElement<NavigationButtonProps>
        {
            protected override Element Render() => AbstractButton.Create(
                action: Sappy.DoAction,
                normal: Row.Create(
                    name: $"navigation-{Props.title}-{Props.index}",
                    className: new ClassName
                    {
                        "flex-row",
                        "align-items-center",
                        "text-nowrap",
                        "overflow-hidden",
                        "p-2",
                        "text-white",
                        Props.expanded ? null : "justify-content-center",
                        Props.selected ? "bg-secondary" : null
                    },
                    gap: 8,
                    children: new Children
                    {
                        Icon.Create(unicode: Props.icon),
                        Props.expanded ? H5.Create(text: Props.title) : Element.Null
                    }));

            [SapTarget]
            private void DoAction() => Action(Props.index);
        }

        [RishValueType]
        public struct NavigationButtonProps
        {
            public int index;
            public bool selected;
            public bool expanded;
            public RishString icon;
            public RishString title;
            public Action<int> action;
        }
    }
}