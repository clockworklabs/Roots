using Motion;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class StackedProgress : RishElement<StackedProgressProps>
    {
        protected override Element Render()
        {
            var children = new Children();
            var total = Props.total;
            var remaining = total;
            var t = 100 / total;
            foreach (var data in Props.values)
            {
                var label = Props.size is ProgressSize.Thin || data.label.IsEmpty ? Element.Null : Small.Create(text: data.label);
                
                var color = data.color ?? Props.color;
                var className = new ClassName
                {
                    "progress-bar",
                    color switch
                    {
                        ProgressColor.Success => "bg-success",
                        ProgressColor.Info => new ClassName
                        {
                            "bg-info",
                            "text-dark"
                        },
                        ProgressColor.Warning => new ClassName
                        {
                            "bg-warning",
                            "text-dark"
                        },
                        ProgressColor.Danger => "bg-danger",
                        _ => ClassName.Null
                    }
                };
                
                var value = Mathf.Clamp(data.value, 0f, remaining);
                remaining -= value;
                var width = Length.Percent(value * t);

                Element progressBar;
                if (!Props.animated || (!Props.spring.HasValue && !Props.tween.HasValue))
                {
                    progressBar = Div.Create(
                        className: className,
                        style: new Style
                        {
                            width = width,
                        },
                        children: label);
                }
                else
                {
                    progressBar = MotionDiv.Create(
                        className: className,
                        initial: new Initial
                        {
                            width = false
                        },
                        animate: new Target
                        {
                            width = width,
                            transition = new Transition
                            {
                                width = Props.spring.HasValue
                                    ? Props.spring.Value
                                    : Props.tween.Value
                            }
                        },
                        children: label);
                }
                
                children.Add(progressBar);
            }
            
            return Div.Create(
                attributes: Props.attributes + new ClassName
                {
                    "progress",
                    Props.size is ProgressSize.Thin ? "progress-thin" : null,
                    Props.animated && !Props.spring.HasValue && !Props.tween.HasValue ? "animated" : null
                },
                children: children);
        }
    }

    [RishValueType]
    public struct StackedProgressProps
    {
        [Expand]
        public VisualAttributes attributes;

        [DefaultValue(true)]
        public bool animated;
        
        public Spring? spring;
        public Tween? tween;

        public ProgressColor color;
        public ProgressSize size;
        
        [DefaultValue(1)]
        public float total;

        public RishList<ProgressBar> values;
    }
}
