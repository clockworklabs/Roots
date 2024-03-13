using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    [AutoKey]
    public partial class Window : RishElement<WindowProps>, IMountingListener, IPropsListener
    {
        private WindowsContext Context { get; set; }
        private VisualElement VisualElementParent { get; set; }
        internal ulong NodeHashCode { get; private set; }
        internal int Index { get; private set; }
        
        public Window()
        {
            RegisterRishCallback<WindowFocusEvent>(OnWindowsFocus, EventPhase.AtTargetOnly);
        }

        void IMountingListener.ComponentDidMount()
        {
            NodeHashCode = GetNodeHashCode();
            
            Context = GetFirstAncestorOfType<WindowsContext>();
            Index = Context?.RegisterWindow(this) ?? -1;

            VisualElementParent = GetFirstAncestorOfType<VisualElement>();
            VisualElementParent.RegisterCallback<GeometryChangedEvent>(ParentGeometryChanged);
        }

        void IMountingListener.ComponentWillUnmount()
        {
            Context?.UnregisterWindow(this);
            VisualElementParent.UnregisterCallback<GeometryChangedEvent>(ParentGeometryChanged);
        }

        void IPropsListener.PropsDidChange()
        {
            if (Props.open)
            {
                Open();
            }
            else
            {
                Close();
            }
        }

        void IPropsListener.PropsWillChange() { }

        protected override Element Render() => Element.Null;

        private void Open() => Context?.OpenWindow(Index);

        private void Close() => Context?.CloseWindow(Index);

        private void OnWindowsFocus(WindowFocusEvent evt)
        {
            if (Context != evt.Context)
            {
                return;
            }
            
            if (evt.WindowIndex != Index)
            {
                evt.StopPropagation();
            }
        }

        private void ParentGeometryChanged(GeometryChangedEvent evt)
        {
            if (evt.oldRect == evt.newRect)
            {
                return;
            }

            Context.WindowGeometryChanged();
        }
    }

    [RishValueType]
    public struct WindowProps
    {
        public bool open;
        public bool draggable;
        // public bool resizable;

        public Vector2? minSize;
        public Vector2? maxSize;
        
        public Element content;

        public bool alwaysOnTop;
    }
}