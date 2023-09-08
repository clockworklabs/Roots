using RishUI;

namespace Roots
{
    public partial class Alert : RishElement<AlertProps>
    {
        public enum Context { Primary, Secondary, Success, Danger, Warning, Info, Light, Dark }
        
        protected override Element Render()
        {
            var descriptor = Props.descriptor;
            descriptor.className = new ClassName(descriptor.className)
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
                    Context.Dark => "alert-dark",
                    _ => string.Empty
                }
            };
            
            return Div.Create(descriptor, /*utilities: Props.utilities,*/ children: Props.children);
        }
    }

    [RishValueType]
    public struct AlertProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        // public Utilities utilities;
        public Alert.Context context;
        public Children children;
    }
}
