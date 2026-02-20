using System;
using RishUI;

namespace Roots.Bootstrap
{
    public partial class Button : RishElement<ButtonProps>
    {
        public enum Variant { None, Primary, PrimaryOutline, Secondary, SecondaryOutline, Success, SuccessOutline, Danger, DangerOutline, Warning, WarningOutline, Info, InfoOutline, Light, LightOutline, Dark, DarkOutline, Link }
        public enum Size { Regular, Small, Large }
        
        protected override Element Render()
        {
            var className = new ClassName {
                "btn", 
                Props.variant switch
                {
                    Variant.Primary => "btn-primary",
                    Variant.PrimaryOutline => "btn-outline-primary",
                    Variant.Secondary => "btn-secondary",
                    Variant.SecondaryOutline => "btn-outline-secondary",
                    Variant.Success => "btn-success",
                    Variant.SuccessOutline => "btn-outline-success",
                    Variant.Danger => "btn-danger",
                    Variant.DangerOutline => "btn-outline-danger",
                    Variant.Warning => "btn-warning",
                    Variant.WarningOutline => "btn-outline-warning",
                    Variant.Info => "btn-info",
                    Variant.InfoOutline => "btn-outline-info",
                    Variant.Light => "btn-light",
                    Variant.LightOutline => "btn-outline-light",
                    Variant.Dark => "btn-dark",
                    Variant.DarkOutline => "btn-outline-dark",
                    Variant.Link => "btn-link",
                    _ => string.Empty
                },
                Props.size switch
                {
                    Size.Small => "btn-sm",
                    Size.Large => "btn-lg",
                    _ => string.Empty
                }
            };

            var pressedClassName = className + "active";
            var normalClassName = Props.active ? pressedClassName : className;
            var disabledClassName = normalClassName + "disabled";
            
            var normal = Content.Create(className: normalClassName, children: Props.children);
            var pressed = Content.Create(className: pressedClassName, children: Props.children);
            var disabled = Content.Create(className: disabledClassName, children: Props.children);

            return AbstractButton.Create(
                interactable: !Props.disabled,
                normal: normal,
                pressed: pressed,
                disabled: disabled,
                action: SappyProps.Action);
        }

        private partial class Content : RishElement<ContentProps>
        {
            protected override Element Render() => Div.Create(className: Props.className, children: Props.children);
        }
        
        [RishValueType]
        public struct ContentProps
        {
            public ClassName className;
            public Children children;
        }
    }

    [RishValueType]
    public struct ButtonProps
    {
        public Button.Variant variant;
        public Button.Size size;

        public bool disabled;
        public bool active;

        public Children children;

        public Action action;
    }
}
