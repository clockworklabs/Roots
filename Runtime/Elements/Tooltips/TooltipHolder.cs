using RishUI;
using UnityEngine;
using UnityEngine.UIElements;
using Translate = UnityEngine.UIElements.Translate;

namespace Roots
{
    internal partial class TooltipHolder : RishElement<TooltipHolderProps, TooltipHolderState>, IMountingListener
    {
        private TooltipsContext Context { get; set; }

        void IMountingListener.ComponentDidMount()
        {
            Context = GetFirstAncestorOfType<TooltipsContext>();
        }
        void IMountingListener.ComponentWillUnmount() { }
        
        protected override Element Render()
        {
            var rect = Props.rect;
            var style = new Style
            {
                position = Position.Absolute,
                left = rect.x,
                width = rect.width,
                top = rect.y,
                height = rect.height,
                translate = new Translate(State.offset.x, State.offset.y, 0),
                visibility = State.visible ? Visibility.Visible : Visibility.Hidden,
                
                // pointerDetection = PointerDetectionMode.ForceIgnore
            };
            
            return Div.Create(style: style, children: Props.element);
        }

        public void OnLayout(Rect tooltipWorldLayout)
        {
            SetVisible(true);
            
            var offset = Vector2.zero;
            if (Context.Props.forceFit && !Props.ignoreFit)
            {
                var contextSize = Context.ContentRect.size;
                var localContentRect = Context.WorldToLocal(tooltipWorldLayout);
                
                if (localContentRect.xMin < 0)
                {
                    offset.x = -localContentRect.xMin;
                } else if (localContentRect.xMax > contextSize.x)
                {
                    offset.x = contextSize.x - localContentRect.xMax;
                }
                if (localContentRect.yMin < 0)
                {
                    offset.y = -localContentRect.yMin;
                } else if (localContentRect.yMax > contextSize.y)
                {
                    offset.y = contextSize.y - localContentRect.yMax;
                }
            }
            SetOffset(offset);
        }
    }

    [RishValueType]
    public struct TooltipHolderProps
    {
        public Rect rect;
        public bool ignoreFit;
        public Element element;
    }

    [RishValueType]
    public struct TooltipHolderState
    {
        public Vector2 offset;
        public bool visible;
    }
}