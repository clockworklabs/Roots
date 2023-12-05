using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    internal partial class DropdownHolder : RishElement<DropdownHolderProps, DropdownHolderState>, IMountingListener
    {
        private DropdownContext Context { get; set; }
        
        void IMountingListener.ComponentDidMount()
         {
             Context = GetFirstAncestorOfType<DropdownContext>();
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
                visibility = State.visible ? Visibility.Visible : Visibility.Hidden
            };
            
            return Div.Create(style, children: Props.element);
        }

        public void OnLayout(Rect tooltipWorldLayout)
        {
            var state = State;
            
            state.visible = true;
            
            if (Context.Props.forceFit)
            {
                var offset = Vector2.zero;
    
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
                
                state.offset = offset;
            }

            State = state;
        }
    }

    [RishValueType]
    public struct DropdownHolderProps
    {
        public Rect rect;
        public Element element;
    }

    [RishValueType]
    public struct DropdownHolderState
    {
        public Vector2 offset;
        public bool visible;
    }
}