using System;
using RishUI;
using UnityEngine;

namespace Roots.Bootstrap
{
    public partial class CardTitle : RishElement<CardTitleProps>
    {
        protected override Element Render()
        {
            var importance = Mathf.Clamp(Props.importance, 1, 6);
            var descriptor = new VisualAttributes(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-title"
                }
            };

            return importance switch
            {
                1 => H1.Create(new H1Props { descriptor = descriptor, /*utilities = Props.utilities,*/ text = Props.text }),
                2 => H2.Create(new H2Props { descriptor = descriptor, /*utilities = Props.utilities,*/ text = Props.text }),
                3 => H3.Create(new H3Props { descriptor = descriptor, /*utilities = Props.utilities,*/ text = Props.text }),
                4 => H4.Create(new H4Props { descriptor = descriptor, /*utilities = Props.utilities,*/ text = Props.text }),
                5 => H5.Create(new H5Props { descriptor = descriptor, /*utilities = Props.utilities,*/ text = Props.text }),
                6 => H6.Create(new H6Props { descriptor = descriptor, /*utilities = Props.utilities,*/ text = Props.text }),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    [RishValueType]
    public struct CardTitleProps
    {
        public int importance;
        
        [Expand]
        public VisualAttributes descriptor;
        // public Utilities utilities;
        public RishString text;
    }
}
