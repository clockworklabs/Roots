using RishUI;
using RishUI.MemoryManagement;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class CardSubtitle : RishElement<CardSubtitleProps>, IVisualManipulator
    {
        bool IVisualManipulator.Evaluate(VisualElement descendant) => descendant == GetVisualChild();

        void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
            if (phase == VisualManipulationPhase.TrickleDown) return;
            using (ManagedContext.New())
            {
                descendant.AddClassName("card-subtitle");
            }
        }

        protected override Element Render() => Props.content;
    }

    [RishValueType]
    public struct CardSubtitleProps
    {
        public Element content;
    }
}