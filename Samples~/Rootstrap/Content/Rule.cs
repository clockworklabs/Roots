using RishUI;
using RishUI.MemoryManagement;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class Rule : RishElement<RuleProps>, IVisualManipulator
    {
        public enum Direction { Horizontal, Vertical }

        private const string VerticalClassName = "vr";
        private const string HorizontalClassName = "hr";
        
        bool IVisualManipulator.Evaluate(VisualElement descendant) => true;
        void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
        {
            var parent = descendant.parent;
            var parentResolvedStyle = parent.resolvedStyle;
            var descendantStyle = descendant.style;
            descendantStyle.backgroundColor = parent.resolvedStyle.color;
            
            var direction = Props.direction ?? parentResolvedStyle.flexDirection switch 
            {
                FlexDirection.Column or FlexDirection.ColumnReverse => Direction.Horizontal,
                FlexDirection.Row or FlexDirection.RowReverse => Direction.Vertical,
            };
            
            using(ManagedContext.New())
            {
                if (phase == VisualManipulationPhase.TrickleDown)
                {
                    descendant.RemoveClassName(direction switch
                    {
                        Direction.Horizontal => VerticalClassName,
                        Direction.Vertical => HorizontalClassName
                    });
                }
                descendant.AddClassName(direction switch
                {
                    Direction.Horizontal => HorizontalClassName,
                    Direction.Vertical => VerticalClassName
                });
            }
        }

        protected override Element Render() => Div.Create();
    }

    [RishValueType]
    public struct RuleProps
    {
        public Rule.Direction? direction;
    }
}
