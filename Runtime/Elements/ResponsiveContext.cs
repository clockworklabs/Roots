using System;
using RishUI;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public delegate void OnResponsiveContextResize(ResponsiveContext body, float? oldWidth, float newWidth);

    public class ResponsiveContextResizeStem
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

        public void Send(ResponsiveContext body, float? oldWidth, float newWidth)
        {
            for (var i = Targets.Count - 1; i >= 0; i--)
            {
                Targets[i]?.Invoke(body, oldWidth, newWidth);
            }
        }
    }
    
    public partial class ResponsiveContext : VisualElement, IVisualElement
    {
        private Bridge Bridge { get; }
        Bridge IVisualElement.Bridge => Bridge;
        
        VisualElement IElement.GetDOMChild() => this;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;
        
        private static ResponsiveContextResizeStem OnStaticResizeStem { get; } = new();
        internal static SapTargets<OnResponsiveContextResize> OnStaticResize => OnStaticResizeStem.Targets;
        
        private SapStem<float> OnResizeStem { get; } = new();
        public SapTargets<Action<float>> OnResize => OnResizeStem.Targets;

        public float Width { get; private set; }
        
        public ResponsiveContext()
        {
            Bridge = new Bridge(this);
            PickingManager = new RectPickingManager(Bridge);
            
            RegisterCallback<AttachToPanelEvent>(OnAttachToPanel);
            RegisterCallback<GeometryChangedEvent>(OnGeometryChanged);
        }

        void IVisualElement.Setup() { }

        public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);

        private void OnAttachToPanel(AttachToPanelEvent evt)
        {
            Width = contentRect.width;
            
            OnStaticResizeStem.Send(this, null, Width);
            OnResizeStem.Send(Width);
        }

        private void OnGeometryChanged(GeometryChangedEvent evt)
        {
            var oldWidth = evt.oldRect.width;
            var newWidth = evt.newRect.width;

            if (Mathf.Approximately(oldWidth, newWidth)) return;
            
            Width = newWidth;
            
            OnStaticResizeStem.Send(this, oldWidth, newWidth);
            OnResizeStem.Send(newWidth);
        }
    }
}
