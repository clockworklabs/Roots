using System;
using RishUI;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Window : RishElement<WindowProps>, IMountingListener, IPropsListener<WindowProps>
    {
        private WindowsContext Context { get; set; }
        private VisualElement VisualElementParent { get; set; }
        private ulong NodeHashCode { get; set; }
        private ulong GUID => Props.guid ?? NodeHashCode;
        
        void IMountingListener.ComponentDidMount()
        {
            NodeHashCode = GetNodeHashCode();
            
            Context = GetFirstAncestorOfType<WindowsContext>();

            VisualElementParent = GetFirstAncestorOfType<VisualElement>();
            VisualElementParent.RegisterCallback<GeometryChangedEvent>(SappyParentGeometryChanged.Callback);
        }
        void IMountingListener.ComponentWillUnmount()
        {
            Context?.UnregisterWindow(GUID);
            VisualElementParent.UnregisterCallback<GeometryChangedEvent>(SappyParentGeometryChanged.Callback);
        }

        void IPropsListener<WindowProps>.PropsDidChange(WindowProps? prev)
        {
            bool mustRegister;
            bool dirtyOpen;
            if (prev.HasValue)
            {
                var prevValue = prev.Value;
                
                mustRegister = Props.guid != prevValue.guid;
                if (mustRegister)
                {
                    var prevGuid = prevValue.guid ?? NodeHashCode;
                    Context?.UnregisterWindow(prevGuid);
                }
                
                dirtyOpen = Props.open != prevValue.open || !RishUtils.MemCmp(Props.offset, prevValue.offset) || !RishUtils.Compare(Props.content, prevValue.content);
            }
            else
            {
                mustRegister = true;
                dirtyOpen = true;
            }

            if (mustRegister)
            {
                Context?.RegisterWindow(this, GUID);
            }
            
            if(dirtyOpen)
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
        }
        void IPropsListener<WindowProps>.PropsWillChange() { }

        protected override Element Render() => Element.Null;

        private void Open() => Context?.OpenWindow(GUID);

        private void Close() => Context?.CloseWindow(GUID);

        [SapTarget(typeof(EventCallback<GeometryChangedEvent>))]
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
        
        public Element content;

        public bool alwaysOnTop;

        public Vector2? offset;

        public Action<WindowDragData> onDrag;

        // public bool resizable;
        // public Vector2? minSize;
        // public Vector2? maxSize;
    }
}