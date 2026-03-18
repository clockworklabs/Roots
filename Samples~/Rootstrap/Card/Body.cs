using RishUI;
using RishUI.MemoryManagement;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class Card
    {
        private partial class Body : RishElement<BodyProps>, IVisualManipulator
        {
            private const string BodyClassName = "card-body";
            private const string ImageOverlayClassName = "card-img-overlay";
            
            bool IVisualManipulator.Evaluate(VisualElement descendant) => descendant == GetVisualChild();
            void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
            {
                using(ManagedContext.New())
                {
                    if (phase == VisualManipulationPhase.TrickleDown)
                    {
                        descendant.RemoveClassName(Props.isImageOverlay ? BodyClassName : ImageOverlayClassName);
                    }
                    descendant.AddClassName(Props.isImageOverlay ? ImageOverlayClassName : BodyClassName);
                }
            }
        
            protected override Element Render() => Props.content;
        }

        [RishValueType]
        internal struct BodyProps
        {
            public bool isImageOverlay;
            public Element content;
        }
    }
}