using RishUI;

namespace Roots.Rootstrap
{
    public partial class Alert : RishElement<AlertProps>
    {
        public enum Context { Primary, Secondary, Success, Danger, Warning, Info, Light, Dark }
        
        protected override Element Render() => Div.Create(
            attributes: Props.attributes + new ClassName
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
        [Expand]
        public VisualAttributes attributes;
        public Alert.Context context;
        public Children children;
    }
}
