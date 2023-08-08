using System;
using RishUI;
using RishUI.Elements;
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
                1 => H1.Create(new H1Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                2 => H2.Create(new H2Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                3 => H3.Create(new H3Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                4 => H4.Create(new H4Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                5 => H5.Create(new H5Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                6 => H6.Create(new H6Props { descriptor = descriptor, utilities = Props.utilities, children = Props.children }),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
        
        // Text
        public static Element Create(string text) => Create(0, Utilities.None, text);
        public static Element Create(ulong key, string text) => Create(key, Utilities.None, text);
        // Utilities, Text
        public static Element Create(Utilities utilities, string text) => Create(0, utilities, text);
        public static Element Create(ulong key, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            utilities = utilities,
            children = Label.Create(text: text)
        });
        // Descriptor, Text
        public static Element Create(DOMDescriptor descriptor, string text) => Create(0, descriptor, text);
        public static Element Create(ulong key, DOMDescriptor descriptor, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = descriptor,
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, string text) => Create(0, (DOMDescriptor) name, text);
        public static Element Create(ulong key, Name name, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = name,
            children = Label.Create(text: text)
        });
        public static Element Create(ClassName className, string text) => Create(0, (DOMDescriptor) className, text);
        public static Element Create(ulong key, ClassName className, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = className,
            children = Label.Create(text: text)
        });
        public static Element Create(Style style, string text) => Create(0, (DOMDescriptor) style, text);
        public static Element Create(ulong key, Style style, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = style,
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, ClassName className, string text) => Create(0, new DOMDescriptor {
            name = name,
            className = className
        }, text);
        public static Element Create(ulong key, Name name, ClassName className, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = new DOMDescriptor {
                name = name,
                className = className
            },
            children = Label.Create(text: text)
        });
        public static Element Create(ClassName className, Style style, string text) => Create(0, new DOMDescriptor {
            className = className,
            style = style
        }, text);
        public static Element Create(ulong key, ClassName className, Style style, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = new DOMDescriptor {
                className = className,
                style = style
            },
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, ClassName className, Style style, string text) => Create(0, new DOMDescriptor {
            name = name,
            className = className,
            style = style
        }, text);
        public static Element Create(ulong key, Name name, ClassName className, Style style, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = new DOMDescriptor {
                name = name,
                className = className,
                style = style
            },
            children = Label.Create(text: text)
        });
        // Descriptor, Utilities, Text
        public static Element Create(DOMDescriptor descriptor, Utilities utilities, string text) => Create(0, descriptor, utilities, text);
        public static Element Create(ulong key, DOMDescriptor descriptor, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = descriptor,
            utilities = utilities,
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, Utilities utilities, string text) => Create(0, (DOMDescriptor) name, utilities, text);
        public static Element Create(ulong key, Name name, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = name,
            utilities = utilities,
            children = Label.Create(text: text)
        });
        public static Element Create(ClassName className, Utilities utilities, string text) => Create(0, (DOMDescriptor) className, utilities, text);
        public static Element Create(ulong key, ClassName className, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = className,
            utilities = utilities,
            children = Label.Create(text: text)
        });
        public static Element Create(Style style, Utilities utilities, string text) => Create(0, (DOMDescriptor) style, utilities, text);
        public static Element Create(ulong key, Style style, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = style,
            utilities = utilities,
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, ClassName className, Utilities utilities, string text) => Create(0, new DOMDescriptor {
            name = name,
            className = className
        }, utilities, text);
        public static Element Create(ulong key, Name name, ClassName className, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = new DOMDescriptor {
                name = name,
                className = className
            },
            utilities = utilities,
            children = Label.Create(text: text)
        });
        public static Element Create(ClassName className, Style style, Utilities utilities, string text) => Create(0, new DOMDescriptor {
            className = className,
            style = style
        }, utilities, text);
        public static Element Create(ulong key, ClassName className, Style style, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = new DOMDescriptor {
                className = className,
                style = style
            },
            utilities = utilities,
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, ClassName className, Style style, Utilities utilities, string text) => Create(0, new DOMDescriptor {
            name = name,
            className = className,
            style = style
        }, utilities, text);
        public static Element Create(ulong key, Name name, ClassName className, Style style, Utilities utilities, string text) => Create(key, new CardSubtitleProps
        {
            descriptor = new DOMDescriptor {
                name = name,
                className = className,
                style = style
            },
            utilities = utilities,
            children = Label.Create(text: text)
        });
    }

    [RishValueType]
    public struct CardSubtitleProps
    {
        public int importance;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Utilities utilities;
        public Children children;
    }
}
