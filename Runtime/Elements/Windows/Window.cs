using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Window : RishElement<WindowProps>, IMountingListener, IPropsListener
    {
        private WindowsContext Context { get; set; }
        private VisualElement VisualElementParent { get; set; }
        private ulong NodeHashCode { get; set; }
        private ulong GUID => Props.guid ?? NodeHashCode;
        private ulong? PrevGUID { get; set; }
        
        public Window()
        {
            RegisterRishCallback<WindowFocusEvent>(OnWindowsFocus, EventPhase.AtTargetOnly);
        }

        void IMountingListener.ComponentDidMount()
        {
            NodeHashCode = GetNodeHashCode();
            PrevGUID = null;
            
            Context = GetFirstAncestorOfType<WindowsContext>();

            VisualElementParent = GetFirstAncestorOfType<VisualElement>();
            VisualElementParent.RegisterCallback<GeometryChangedEvent>(ParentGeometryChanged);
        }

        void IMountingListener.ComponentWillUnmount()
        {
            Context?.UnregisterWindow(GUID);
            VisualElementParent.UnregisterCallback<GeometryChangedEvent>(ParentGeometryChanged);
        }

        void IPropsListener.PropsDidChange()
        {
            if (!PrevGUID.HasValue || PrevGUID.Value != GUID)
            {
                if (PrevGUID.HasValue)
                {
                    Context?.UnregisterWindow(PrevGUID.Value);
                }
                Context?.RegisterWindow(this, GUID);
                PrevGUID = GUID;
            }
            
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

        private void Open() => Context?.OpenWindow(GUID);

        private void Close() => Context?.CloseWindow(GUID);

        private void OnWindowsFocus(WindowFocusEvent evt)
        {
            if (Context != evt.Context)
            {
                return;
            }
            
            if (evt.WindowGUID != GUID)
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
        public ulong? guid;
        
        public bool open;
        public bool draggable;
        // public bool resizable;

        public Vector2? minSize;
        public Vector2? maxSize;
        
        public Element content;

        public bool alwaysOnTop;
    }
}