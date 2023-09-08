using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class H3 : RishElement<H3Props>
    {
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className) {
                "h3"
            };
            
            return Div.Create(descriptor, /*utilities: Props.utilities,*/ children: Props.children);
        }
        
        // Text
        public static Element Create(string text) => Create(0, /*Utilities.None,*/ text);
        public static Element Create(ulong key, string text) => Create(key, new H3Props
        {
            children = Label.Create(text: text)
        });
        // // Utilities, Text
        // public static Element Create(Utilities utilities, string text) => Create(0, utilities, text);
        // public static Element Create(ulong key, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
        // Descriptor, Text
        public static Element Create(DOMDescriptor descriptor, string text) => Create(0, descriptor, text);
        public static Element Create(ulong key, DOMDescriptor descriptor, string text) => Create(key, new H3Props
        {
            descriptor = descriptor,
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, string text) => Create(0, (DOMDescriptor) name, text);
        public static Element Create(ulong key, Name name, string text) => Create(key, new H3Props
        {
            descriptor = name,
            children = Label.Create(text: text)
        });
        public static Element Create(ClassName className, string text) => Create(0, (DOMDescriptor) className, text);
        public static Element Create(ulong key, ClassName className, string text) => Create(key, new H3Props
        {
            descriptor = className,
            children = Label.Create(text: text)
        });
        public static Element Create(Style style, string text) => Create(0, (DOMDescriptor) style, text);
        public static Element Create(ulong key, Style style, string text) => Create(key, new H3Props
        {
            descriptor = style,
            children = Label.Create(text: text)
        });
        public static Element Create(Name name, ClassName className, string text) => Create(0, new DOMDescriptor {
            name = name,
            className = className
        }, text);
        public static Element Create(ulong key, Name name, ClassName className, string text) => Create(key, new H3Props
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
        public static Element Create(ulong key, ClassName className, Style style, string text) => Create(key, new H3Props
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
        public static Element Create(ulong key, Name name, ClassName className, Style style, string text) => Create(key, new H3Props
        {
            descriptor = new DOMDescriptor {
                name = name,
                className = className,
                style = style
            },
            children = Label.Create(text: text)
        });
        // // Descriptor, Utilities, Text
        // public static Element Create(DOMDescriptor descriptor, Utilities utilities, string text) => Create(0, descriptor, utilities, text);
        // public static Element Create(ulong key, DOMDescriptor descriptor, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     descriptor = descriptor,
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
        // public static Element Create(Name name, Utilities utilities, string text) => Create(0, (DOMDescriptor) name, utilities, text);
        // public static Element Create(ulong key, Name name, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     descriptor = name,
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
        // public static Element Create(ClassName className, Utilities utilities, string text) => Create(0, (DOMDescriptor) className, utilities, text);
        // public static Element Create(ulong key, ClassName className, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     descriptor = className,
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
        // public static Element Create(Style style, Utilities utilities, string text) => Create(0, (DOMDescriptor) style, utilities, text);
        // public static Element Create(ulong key, Style style, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     descriptor = style,
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
        // public static Element Create(Name name, ClassName className, Utilities utilities, string text) => Create(0, new DOMDescriptor {
        //     name = name,
        //     className = className
        // }, utilities, text);
        // public static Element Create(ulong key, Name name, ClassName className, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     descriptor = new DOMDescriptor {
        //         name = name,
        //         className = className
        //     },
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
        // public static Element Create(ClassName className, Style style, Utilities utilities, string text) => Create(0, new DOMDescriptor {
        //     className = className,
        //     style = style
        // }, utilities, text);
        // public static Element Create(ulong key, ClassName className, Style style, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     descriptor = new DOMDescriptor {
        //         className = className,
        //         style = style
        //     },
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
        // public static Element Create(Name name, ClassName className, Style style, Utilities utilities, string text) => Create(0, new DOMDescriptor {
        //     name = name,
        //     className = className,
        //     style = style
        // }, utilities, text);
        // public static Element Create(ulong key, Name name, ClassName className, Style style, Utilities utilities, string text) => Create(key, new H3Props
        // {
        //     descriptor = new DOMDescriptor {
        //         name = name,
        //         className = className,
        //         style = style
        //     },
        //     utilities = utilities,
        //     children = Label.Create(text: text)
        // });
    }

    [RishValueType]
    public struct H3Props
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public Children children;
    }
}