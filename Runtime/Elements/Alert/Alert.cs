using RishUI;

namespace Roots
{
    public partial class Alert : RishElement<AlertProps>
    {
        public enum Context { Primary, Secondary, Success, Danger, Warning, Info, Light, Dark }
        
        protected override Element Render() => Div.Create(className:  ("alert", Props.context switch
        {
            Context.Primary => "alert-primary",
            Context.Secondary => "alert-secondary",
            Context.Success => "alert-success",
            Context.Danger => "alert-danger",
            Context.Warning => "alert-warning",
            Context.Info => "alert-info",
            Context.Light => "alert-light",
            Context.Dark => "alert-dark",
            _ => string.Empty
        }), utilities: Props.utilities, children: Props.children);
    }

    [RishValueType]
    public struct AlertProps
    {
        public Alert.Context context;
        public Utilities utilities;
        public Children children;
    }
}
