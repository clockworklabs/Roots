using RishUI;
using RishUI.Events;
using Roots;
using Roots.Rootstrap;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace RootsSamples
{
    public partial class ResizableContainer : RishElement<ResizableContainerProps, ResizableContainerState>
    {
        protected override Element Render()
        {
            var width = Length.Percent(State.size.x * 100);
            var height = Length.Percent(State.size.y * 100);
            
            return Div.Create(
                className: "thin-border-top".FlexFill().AlignItemsCenter().Padding2().PaddingTop0(),
                children: ResponsiveContext.Create(
                    className: "resizable-container",
                    style: new Style
                    {
                        width = width,
                        minWidth = width,
                        maxWidth = width,
                        height = height,
                        minHeight = height,
                        maxHeight = height
                    },
                    children: new Children
                    {
                        Props.content,
                        ResizeHandle.Create(key: 1, side: ResizeHandle.Side.Right, resizing: State.resizing, onResize: Sappy.OnResize),
                        ResizeHandle.Create(key: 2, side: ResizeHandle.Side.Bottom, resizing: State.resizing, onResize: Sappy.OnResize),
                        ResizeHandle.Create(key: 3, side: ResizeHandle.Side.Corner, resizing: State.resizing, onResize: Sappy.OnResize)
                    }));
        }

        [SapTarget]
        private void OnResize(bool resizing, Vector2 delta)
        {
            SetResizing(resizing);
            var contentRectSize = ContentRect.size;
            var x = delta.x / contentRectSize.x;
            var y = delta.y / contentRectSize.y;
            SetSize(State.size + new Vector2(x * 2, y));
        }

        private void SetSize(Vector2 value) => RishSetSize(new Vector2(Mathf.Clamp(value.x, 0.1f, 1), Mathf.Clamp(value.y, 0.1f, 1)));

        [SapTarget(typeof(EventCallback<HoverStartEvent>))]
        private void OnHoverStart(HoverStartEvent evt) => SetHovered(true);
        [SapTarget(typeof(EventCallback<HoverEndEvent>))]
        private void OnHoverEnd(HoverEndEvent evt) => SetHovered(false);
    }

    [RishValueType]
    public struct ResizableContainerProps
    {
        public Element content;
    }

    [RishValueType]
    public struct ResizableContainerState
    {
        public bool hovered;
        public bool resizing;
        [DefaultCode("UnityEngine.Vector2.one")]
        public Vector2 size;
    }
}