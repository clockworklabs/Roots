using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Div : VisualElement, IVisualElement<DivProps>
    {
        VisualElement IElement.GetDOMChild() => this;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;

        public Div()
        {
            PickingManager = new RectPickingManager(this);
        }

        void IVisualElement<DivProps>.Setup(DivProps props)
        {
            this.AddClassNames(props.utilities);
        }

        public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);
    }

    public struct DivProps
    {
        public Utilities utilities;
    }
}