using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    internal delegate void OnResponsiveContextResize(ResponsiveContext body, float oldWidth, float newWidth);
    
    public partial class ResponsiveContext : VisualElement, IVisualElement
    {
        internal static event OnResponsiveContextResize OnResize;
        
        VisualElement IElement.GetDOMChild() => this;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;

        public ResponsiveContext()
        {
            PickingManager = new DefaultPickingManager(this);
            
            RegisterCallback<GeometryChangedEvent>(GeometryChanged);
        }

        void IVisualElement.Setup() { }

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
}
