using System;
using RishUI;
using Unity.Collections;
using UnityEngine;

namespace Roots
{
    public partial class CardSubtitle : RishElement<CardSubtitleProps>
    {
        protected override Element Render()
        {
            var importance = Mathf.Clamp(Props.importance, 1, 6);
            var descriptor = new DOMDescriptor(Props.descriptor)
            {
                className = new ClassName(Props.descriptor.className)
                {
                    "card-subtitle"
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
    public struct CardSubtitleProps
    {
        public int importance;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public FixedString4096Bytes text;
    }
}
