using System;
using RishUI;
using UnityEngine;

namespace Roots
{
    public partial class CardTitle : RishElement<CardTitleProps>
    {
        protected override Element Render()
        {
            var importance = Mathf.Clamp(Props.importance, 1, 6);
            var descriptor = new DOMDescriptor(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-title"
                }
            };

            return importance switch
            {
                1 => H1.Create(new H1Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                2 => H2.Create(new H2Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                3 => H3.Create(new H3Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                4 => H4.Create(new H4Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                5 => H5.Create(new H5Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                6 => H6.Create(new H6Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    [RishValueType]
    public struct CardTitleProps
    {
        public int importance;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        public Children children;
    }
}
