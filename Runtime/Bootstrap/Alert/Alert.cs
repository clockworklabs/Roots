using RishUI;

namespace Roots.Bootstrap
{
    public partial class Alert : RishElement<AlertProps>
    {
        public enum Context { Primary, Secondary, Success, Danger, Warning, Info, Light, Dark }
        
        protected override Element Render() => Div.Create(
            descriptor: Props.descriptor + new ClassName
            {
                "alert",
                Props.context switch
                {
                    Context.Primary => "alert-primary",
                    Context.Secondary => "alert-secondary",
                    Context.Success => "alert-success",
                    Context.Danger => "alert-danger",
                    Context.Warning => "alert-warning",
                    Context.Info => "alert-info",
                    Context.Light => "alert-light",
                    Context.Dark => "alert-dark"
                }
            },
            children: Props.children);
    }

    [RishValueType]
    public struct AlertProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Alert.Context context;
        public Children children;
    }
}
