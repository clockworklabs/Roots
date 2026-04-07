using System;
using RishUI;
using Roots;
using Roots.Experimental.Rootstrap;
using Sappy;
using UnityEngine;

namespace RootsSamples
{
    public partial class SamplesApp
    {
        public partial class NavigationRail : RishElement<NavigationRailProps, NavigationRailState>
        {
            protected override Element Render()
            {
                var expanded = State.expanded && !Props.smallContext;
                var width = expanded ? 300 : 55;

                var children = new Children();
                for (int i = 0, n = SamplesList.Count; i < n; i++)
                {
                    var sample = SamplesList[i];
                    children.Add(NavigationButton.Create(
                        key: (ulong)i,
                        expanded: expanded,
                        icon: sample.Icon,
                        title: sample.Name,
                        action: SappyProps.OnIndex,
                        index: i,
                        selected: Props.index == i));
                }

                return MotionDiv.Create(
                    className: new ClassName
                    {
                        "navigation-rail",
                        "content-rect"
                    },
                    initial: new Initial
                    {
                        width = false,
                        minWidth = false,
                        maxWidth = false
                    },
                    animate: new Target
                    {
                        width = width,
                        minWidth = width,
                        maxWidth = width,
                    },
                    children: VScrollView.Create(
                        className: "flex-grow-1",
                        gap: 8,
                        children: children));
            }

            [SapTarget]
            private void ToggleExpanded() => SetExpanded(!State.expanded);
        }

        [RishValueType]
        public struct NavigationRailProps
        {
            public bool smallContext;
            public int index;
            public Action<int> onIndex;
        }

        [RishValueType]
        public struct NavigationRailState
        {
            [DefaultValue(true)]
            public bool expanded;
        }
    }
}