using RishUI;
using RishUI.MemoryManagement;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class Card
    {
        private partial class Header : RishElement<HeaderProps>, IVisualManipulator
        {
            bool IVisualManipulator.Evaluate(VisualElement descendant) => descendant == GetVisualChild();

            void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
            {
                if (phase == VisualManipulationPhase.TrickleDown) return;
                using (ManagedContext.New())
                {
                    descendant.AddClassName("card-header");
                }
            }

            protected override Element Render() => Props.content;
        }

        [RishValueType]
        internal struct HeaderProps
        {
            public Element content;
        }
    }
}
