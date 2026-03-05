using System;
using RishUI;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class Rule : RishElement<RuleProps>, IMountingListener
    {
        public enum Direction { Auto, Horizontal, Vertical }
        
        void IMountingListener.ElementDidMount()
        {
            var parent = GetFirstAncestorOfType<VisualElement>();
            while (parent != null)
            {
                parent.RegisterCallback<GeometryChangedEvent>(OnGeometryChange);
                parent = parent.parent;
            }
        }
        void IMountingListener.ElementWillUnmount()
        {
            var parent = GetFirstAncestorOfType<VisualElement>();
            while (parent != null)
            {
                parent.UnregisterCallback<GeometryChangedEvent>(OnGeometryChange);
                parent = parent.parent;
            }
        }
        
        protected override Element Render()
        {
            var parent = GetFirstAncestorOfType<VisualElement>();
            while (parent.childCount <= 1)
            {
                var p = parent.parent;
                if (p == null)
                {
                    break;
                }
                        
                parent = p;
            }
            var color = parent.resolvedStyle.color;
            
            string className;
            switch (Props.direction)
            {
                case Direction.Horizontal:
                    className = "hr";
                    break;
                case Direction.Vertical:
                    className = "vr";
                    break;
                case Direction.Auto:
                default:
                    var direction = parent.resolvedStyle.flexDirection;
                    className = direction switch
                    {
                        FlexDirection.Row => "vr",
                        FlexDirection.RowReverse => "vr",
                        FlexDirection.Column => "hr",
                        FlexDirection.ColumnReverse => "hr",
                        _ => throw new ArgumentException()
                    };
                    break;
            }

            return Div.Create(style: StyleUtilities.AlignSelfStretch(), children: Div.Create(className: className, style: new Style { backgroundColor = color }));
        }

        private void OnGeometryChange(GeometryChangedEvent evt) => Dirty();
    }

    [RishValueType]
    public struct RuleProps
    {
        public Rule.Direction direction;
    }
}
