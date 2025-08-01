using System.Text;
using RishUI;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    internal delegate void OnResponsiveContextResize(ResponsiveContext body, float oldWidth, float newWidth);

    internal class ResponsiveContextResizeStem
    {
        public SapTargets<OnResponsiveContextResize> Targets { get; }

        public ResponsiveContextResizeStem()
        {
            Targets = new SapTargets<OnResponsiveContextResize>();
        }
        public ResponsiveContextResizeStem(int initialSize)
        {
            Targets = new SapTargets<OnResponsiveContextResize>(initialSize);
        }

        public void Send(ResponsiveContext body, float oldWidth, float newWidth)
        {
            for (var i = Targets.Count - 1; i >= 0; i--)
            {
                Targets[i]?.Invoke(body, oldWidth, newWidth);
            }
        }
    }
    
    public partial class ResponsiveContext : VisualElement, IVisualElement/*<ResponsiveContextProps>*/
    {
        private Bridge Bridge { get; }
        Bridge IVisualElement.Bridge => Bridge;

        private static ResponsiveContextResizeStem OnResizeStem { get; } = new();
        internal static SapTargets<OnResponsiveContextResize> OnResize => OnResizeStem.Targets;
        
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
            
            OnResizeStem.Send(this, oldWidth, newWidth);
        }
    }

    // public struct ResponsiveContextProps
    // {
    //     public Utilities utilities;
    // }
}
