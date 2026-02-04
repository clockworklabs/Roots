using System;
using RishUI;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class ResponsiveContext
    {
        public delegate void OnUSSResize(Visual body, float? oldWidth, float newWidth);

        public class ResponsiveContextResizeStem
        {
            public SapTargets<OnUSSResize> Targets { get; }

            public ResponsiveContextResizeStem()
            {
                Targets = new SapTargets<OnUSSResize>();
            }
            public ResponsiveContextResizeStem(int initialSize)
            {
                Targets = new SapTargets<OnUSSResize>(initialSize);
            }

            public void Send(Visual body, float? oldWidth, float newWidth)
            {
                for (var i = Targets.Count - 1; i >= 0; i--)
                {
                    Targets[i]?.Invoke(body, oldWidth, newWidth);
                }
            }
        }
        
        public partial class Visual : VisualElement, IVisualElement
        {
            private Bridge Bridge { get; }
            Bridge IVisualElement.Bridge => Bridge;
            
            VisualElement IElement.GetVisualChild() => this;
            
            private PickingManager PickingManager { get; }
            PickingManager ICustomPicking.Manager => PickingManager;
            
            private static ResponsiveContextResizeStem OnStaticResizeStem { get; } = new();
            internal static SapTargets<OnUSSResize> OnStaticResize => OnStaticResizeStem.Targets;

            public Visual()
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
                OnStaticResizeStem.Send(this, null, contentRect.width);
            }

            private void OnGeometryChanged(GeometryChangedEvent evt)
            {
                var oldWidth = evt.oldRect.width;
                var newWidth = evt.newRect.width;

                if (Mathf.Approximately(oldWidth, newWidth)) return;
                
                
                OnStaticResizeStem.Send(this, oldWidth, newWidth);
            }
        }
    }
}
