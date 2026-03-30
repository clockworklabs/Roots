using System;
using RishUI;
using RishUI.Events;
using Roots;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;
using Roots.Rootstrap;

namespace RootsSamples
{
    public partial class ResizeHandle : RishElement<ResizeHandleProps, ResizeHandleState>
    {
        public enum Side { Right, Bottom, Corner }
        
        public ResizeHandle()
        {
            RegisterCallback<HoverStartEvent>(Sappy.OnHoverStart);
            RegisterCallback<HoverEndEvent>(Sappy.OnHoverEnd);
            AddManipulator(new DragManipulator());
            RegisterCallback<DragStartEvent>(Sappy.OnDragStart);
            RegisterCallback<DragEndEvent>(Sappy.OnDragEnd);
            RegisterCallback<DragEvent>(Sappy.OnDrag);
        }

        protected override Element Render() => FadeDiv.Create(
            className: new ClassName
            {
                Props.side switch
                {
                    Side.Right => new ClassName
                    {
                        "resize-handle-right",
                        "right-0",
                        "top-50",
                        "translate-y"
                    },
                    Side.Bottom => new ClassName
                    {
                        "resize-handle-bottom",
                        "bottom-0",
                        "left-50",
                        "translate-x"
                    },
                    Side.Corner => new ClassName
                    {
                        "resize-handle-corner",
                        "bottom-0",
                        "right-0"
                    },
                },
                "pointer-detection"
            }.PositionAbsolute(),
            visible: true,
            maxOpacity: State.dragging ? 0.85f : State.hovered ? 0.6f : Props.resizing ? 0.05f : 0.2f,
            preset: FadeDiv.Preset.Fast,
            children: Icon.Create(
                // weight: State.dragging || State.hovered ? MaterialSymbol.Weight.Bold : Props.resizing ? MaterialSymbol.Weight.Thin : MaterialSymbol.Weight.Regular,
                unicode: Props.side switch
                {
                    Side.Right => FontAwesome.FA_GripLinesVertical.Unicode,
                    Side.Bottom => FontAwesome.FA_GripLines.Unicode,
                    Side.Corner => FontAwesome.FA_UpRightAndDownLeftFromCenter.Unicode
                }));

        [SapTarget(typeof(EventCallback<HoverStartEvent>))]
        private void OnHoverStart(HoverStartEvent evt) => SetHovered(true);
        [SapTarget(typeof(EventCallback<HoverEndEvent>))]
        private void OnHoverEnd(HoverEndEvent evt) => SetHovered(false);

        [SapTarget(typeof(EventCallback<DragStartEvent>))]
        private void OnDragStart(DragStartEvent evt)
        {
            SetDragging(true);
            CapturePointer(evt.pointerId);
            OnResize(true, Vector2.zero);
        }

        [SapTarget(typeof(EventCallback<DragEndEvent>))]
        private void OnDragEnd(DragEndEvent evt)
        {
            SetDragging(false);
            ReleasePointer(evt.pointerId);
            OnResize(false, Vector2.zero);
        }

        [SapTarget(typeof(EventCallback<DragEvent>))]
        private void OnDrag(DragEvent evt)
        {
            var delta = evt.deltaPosition;
            switch (Props.side)
            {
                case Side.Right:
                    delta.y = 0;
                    break;
                case Side.Bottom:
                    delta.x = 0;
                    break;
            }
            
            OnResize(true, delta);
        }
    }

    [RishValueType]
    public struct ResizeHandleProps
    {
        public ResizeHandle.Side side;
        public bool resizing;
        public Action<bool, Vector2> onResize;
    }

    [RishValueType]
    public struct ResizeHandleState
    {
        public bool hovered;
        public bool dragging;
    }
}