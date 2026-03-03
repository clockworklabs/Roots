using System;
using System.Collections.Generic;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;

namespace Roots
{
    public partial class WindowsContext : RishElement<WindowsContextProps>, IManualState
    {
        private SapStem<ulong> OnFocusStem { get; } = new();
        public SapTargets<Action<ulong>> OnFocus => OnFocusStem.Targets;
        
        private const int _SafeZone = 10;
        internal int SafeZone => Props.safeZoneSize > 0 ? Props.safeZoneSize : _SafeZone;

        private Dictionary<ulong, Window> RegisteredWindows { get; } = new();
        
        private List<ulong> WindowsOrder { get; } = new();
        
        private bool Rendered { get; set; }

        public WindowsContext()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
        }

        void IManualState.Restart()
        {
            Rendered = false;
            
            RegisteredWindows.Clear();
            WindowsOrder.Clear();
        }
        
        protected override Element Render()
        {
            var children = new Children
            {
                Props.children
            };
            
            if (Rendered && !Props.hideAllWindows)
            {
                foreach (var guid in WindowsOrder)
                {
                    var window = RegisteredWindows[guid];

                    var props = window.Props;

                    children.Add(InternalWindow.Create(
                        key: (uint)guid,
                        guid: guid,
                        content: props.content,
                        draggable: props.draggable,
                        offset: props.offset,
                        rect: WorldToLocal(window.ParentWorldContentRect),
                        onDrag: Sappy.Drag));
                }
            }

            return Div.Create(descriptor: Props.descriptor, children: children);
        }

        internal void RegisterWindow(Window window, ulong guid)
        {
            if (window == null) return;

            if (!RegisteredWindows.TryAdd(guid, window))
            {
                Debug.LogError($"Another window with guid {guid} is already registered. Make sure the window has a unique guid.");
            }
        }

        internal void UnregisterWindow(ulong guid)
        {
            if (!RegisteredWindows.Remove(guid)) return;

            var position = WindowsOrder.IndexOf(guid);
            if (position >= 0)
            {
                WindowsOrder.RemoveAt(position);
                if (position >= WindowsOrder.Count)
                {
                    BroadcastFocusEvent();
                }
            }
            
            Dirty(Rendered);
        }

        internal void OpenWindow(ulong guid)
        {
            if (!RegisteredWindows.ContainsKey(guid)) return;
            
            if (WindowsOrder.Contains(guid))
            {
                Dirty(true);
                return;
            }
            
            MoveToFront(guid, true);
        }

        internal void CloseWindow(ulong guid)
        {
            if (!RegisteredWindows.ContainsKey(guid)) return;
            
            var position = WindowsOrder.IndexOf(guid);
            if (position < 0) return;
            
            WindowsOrder.RemoveAt(position);
            
            if (position >= WindowsOrder.Count)
            {
                BroadcastFocusEvent();
            }

            Dirty(Rendered);
        }

        [SapTarget]
        internal void Drag(ulong guid, WindowDragData data)
        {
            if (!RegisteredWindows.TryGetValue(guid, out var window)) return;
            
            window.Props.onDrag?.Invoke(data);
        }

        internal void ResizeTop(int index, float delta)
        {
            
        }
        internal void ResizeRight(int index, float delta)
        {
            
        }
        internal void ResizeBottom(int index, float delta)
        {
            
        }
        internal void ResizeLeft(int index, float delta)
        {
            
        }

        internal void WindowGeometryChanged() => Dirty();

        // internal void ResizeWindow(int index, int side, float delta)
        // {
        //     if (!Windows.TryGetValue(index, out var info))
        //     {
        //         return;
        //     }
        //
        //     var element = info.element;
        //     var transform = element.transform;
        //
        //     switch (side)
        //     {
        //         case 0:
        //         {
        //             var currentSize = transform.GetSize(Size).y;
        //             var minSize = Mathf.Min(currentSize, Mathf.Max(info.minSize?.y ?? float.MinValue, info.headerHeight + SafeZone * 2));
        //             var maxSize = Mathf.Max(currentSize, info.maxSize?.y ?? float.MaxValue);
        //             delta = Mathf.Clamp(delta, minSize - currentSize, maxSize - currentSize);
        //             transform.top -= delta;
        //             break;
        //         }
        //         case 1:
        //         {
        //             var currentSize = transform.GetSize(Size).x;
        //             var minSize = Mathf.Min(currentSize, Mathf.Max(info.minSize?.x ?? float.MinValue, SafeZone * 2));
        //             var maxSize = Mathf.Max(currentSize, info.maxSize?.x ?? float.MaxValue);
        //             delta = Mathf.Clamp(delta, minSize - currentSize, maxSize - currentSize);
        //             transform.right -= delta;
        //             break;
        //         }
        //         case 2:
        //         {
        //             var currentSize = transform.GetSize(Size).y;
        //             var minSize = Mathf.Min(currentSize, Mathf.Max(info.minSize?.y ?? float.MinValue, info.headerHeight + SafeZone * 2));
        //             var maxSize = Mathf.Max(currentSize, info.maxSize?.y ?? float.MaxValue);
        //             delta = Mathf.Clamp(delta, -maxSize + currentSize, -minSize + currentSize);
        //             transform.bottom += delta;
        //             break;
        //         }
        //         case 3:
        //         {
        //             var currentSize = transform.GetSize(Size).x;
        //             var minSize = Mathf.Min(currentSize, Mathf.Max(info.minSize?.x ?? float.MinValue, SafeZone * 2));
        //             var maxSize = Mathf.Max(currentSize, info.maxSize?.x ?? float.MaxValue);
        //             delta = Mathf.Clamp(delta, -maxSize + currentSize, -minSize + currentSize);
        //             transform.left += delta;
        //             break;
        //         }
        //     }
        //
        //     if (Fit(transform, info.headerHeight, out _))
        //     {
        //         return;
        //     }
        //     
        //     info.element = new RishElement(element, transform);
        //
        //     Windows[index] = info;
        //
        //     Dirty();
        // }

        public void MoveToFront(ulong guid) => MoveToFront(guid, false);
        
        private void MoveToFront(ulong guid, bool open)
        {
            if (!RegisteredWindows.ContainsKey(guid))
            {
                return;
            }
            
            if (!open)
            {
                var position = WindowsOrder.IndexOf(guid);
                if (position < 0)
                {
                    return;
                }
            }
            
            var totalCount = WindowsOrder.Count;
            if (totalCount <= 0)
            {
                WindowsOrder.Add(guid);
            }
            else
            {
                var lastPosition = totalCount - 1;
                if (WindowsOrder[lastPosition] == guid)
                {
                    return;
                }

                var alwaysOnTop = RegisteredWindows[guid].Props.alwaysOnTop;
                if (alwaysOnTop)
                {
                    if (WindowsOrder.Contains(guid))
                    {
                        return;
                    }
                    
                    WindowsOrder.Add(guid);
                }
                else
                {
                    var targetPosition = totalCount;
                    while (targetPosition > 0 && RegisteredWindows[WindowsOrder[targetPosition - 1]].Props.alwaysOnTop)
                    {
                        targetPosition--;
                    }
                
                    if (WindowsOrder.Count > targetPosition && WindowsOrder[targetPosition] == guid)
                    {
                        return;
                    }

                    var removed = WindowsOrder.Remove(guid);
                    WindowsOrder.Insert(removed ? targetPosition - 1 : targetPosition, guid);
                }
            }

            BroadcastFocusEvent();
            
            Dirty(Rendered);
        }

        private Rect Fit(Rect window, float headerHeight)
        {
            var windowSize = window.size;
            var layoutSize = Layout.size;

            var limits = new Margins();
            if (!Props.forceFit)
            {
                limits.top -= headerHeight - SafeZone;
                limits.right -= windowSize.x - SafeZone;
                limits.bottom -= windowSize.y - SafeZone;
                limits.left -= windowSize.x - SafeZone;
            }
            limits.right = layoutSize.x - limits.right;
            limits.bottom = layoutSize.y - limits.bottom;

            var result = window;
            
            if (result.yMin < limits.top)
            {
                result.y = limits.top;
            }
            if (result.xMax > limits.right)
            {
                result.x = limits.right - windowSize.x;
            }
            if (result.yMax > limits.bottom)
            {
                result.y = limits.bottom - windowSize.y;
            }
            if (result.xMin < limits.left)
            {
                result.x = limits.left;
            }
        
            return result;
        }

        private void OnVisualChange(VisualChangeEvent evt)
        {
            if (Rendered) return;

            Rendered = true;
            Dirty();
        }

        private void BroadcastFocusEvent()
        {
            if (WindowsOrder.Count <= 0) return;

            var focusedWindow = WindowsOrder[^1];
            
            OnFocusStem.Send(focusedWindow);
        }
    }

    [RishValueType]
    public struct WindowsContextProps
    {
        [Expand]
        public VisualAttributes descriptor;
        public bool forceFit;
        public int safeZoneSize;
        public bool hideAllWindows;
        public Children children;
    }

    public struct WindowDragData
    {
        public Vector2 delta;
        public bool isInitialization;
    }
}