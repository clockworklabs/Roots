using System.Text;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    internal delegate void OnResponsiveContextResize(ResponsiveContext body, float oldWidth, float newWidth);
    
    public partial class ResponsiveContext : VisualElement, IVisualElement/*<ResponsiveContextProps>*/
    {
        private Bridge Bridge { get; }
        Bridge IVisualElement.Bridge => Bridge;
        
        internal static event OnResponsiveContextResize OnResize;
        
        VisualElement IElement.GetDOMChild() => this;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;

        private StringBuilder StringBuilder { get; } = new();
        
        public ResponsiveContext()
        {
            Bridge = new Bridge(this);
            PickingManager = new RectPickingManager(Bridge);
            
            RegisterCallback<GeometryChangedEvent>(GeometryChanged);
        }

        void IVisualElement/*<ResponsiveContextProps>*/.Setup(/*ResponsiveContextProps props*/)
        {
            // this.AddClassNames(props.utilities, StringBuilder);
        }

        public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);

        private void GeometryChanged(GeometryChangedEvent evt)
        {
            var oldWidth = evt.oldRect.width;
            var newWidth = evt.newRect.width;

            if (Mathf.Approximately(oldWidth, newWidth))
            {
                return;
            }
            
            OnResize?.Invoke(this, oldWidth, newWidth);
        }
    }

    // public struct ResponsiveContextProps
    // {
    //     public Utilities utilities;
    // }
}
