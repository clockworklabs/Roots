using RishUI;
using RishUI.MemoryManagement;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class CardTitle : RishElement<CardTitleProps>, IVisualManipulator
    {
        bool IVisualManipulator.Evaluate(VisualElement descendant) => descendant == GetVisualChild();

        void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
            if (phase == VisualManipulationPhase.TrickleDown) return;
            using (ManagedContext.New())
            {
                descendant.AddClassName("card-title");
            }
        }

        protected override Element Render() => Props.content;
    }

    [RishValueType]
    public struct CardTitleProps
    {
        public Element content;
    }
}