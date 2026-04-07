using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Div : VisualElement, IVisualElement
    {
        private Bridge Bridge { get; }
        Bridge IVisualElement.Bridge => Bridge;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;
        
        public Div()
        {
            Bridge = new Bridge(this);
            PickingManager = new RectPickingManager(Bridge);
        }

        void IVisualElement.Setup() { }

        public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);
    }
}