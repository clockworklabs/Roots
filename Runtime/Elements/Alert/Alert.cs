using RishUI;
using RishUI.Elements;

namespace Roots
{
    public partial class Alert : RishElement<AlertProps>
    {
        protected override Element Render() => Div.Create(className:  ("alert", Props.context switch
        {
            AlertProps.Context.Primary => "alert-primary",
            AlertProps.Context.Secondary => "alert-secondary",
            AlertProps.Context.Success => "alert-success",
            AlertProps.Context.Danger => "alert-danger",
            AlertProps.Context.Warning => "alert-warning",
            AlertProps.Context.Info => "alert-info",
            AlertProps.Context.Light => "alert-light",
            AlertProps.Context.Dark => "alert-dark",
            _ => string.Empty
        }), children: Props.children);
    }

    [RishValueType]
    public struct AlertProps
    {
        public enum Context { Primary, Secondary, Success, Danger, Warning, Info, Light, Dark }

        public Context context;
        public Children children;
    }
}
