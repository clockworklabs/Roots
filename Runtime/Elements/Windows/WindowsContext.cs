using System.Collections.Generic;
using RishUI;
using Roots;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class WindowsContext : RishElement<WindowsContextProps>, ICustomComponent
    {
        private const int _SafeZone = 10;
        internal int SafeZone => Props.safeZoneSize > 0 ? Props.safeZoneSize : _SafeZone;

        private HashSet<ulong> RegisteredWindowsSet { get; } = new();
        private List<Window> RegisteredWindows { get; } = new();
        
        private List<int> WindowsOrder { get; } = new();
        private Dictionary<ulong, Rect> WindowsPosition { get; } = new();
        
        private bool Rendered { get; set; }

        public WindowsContext()
        {
            RegisterCallback<GeometryChangedEvent>(OnGeometry);
        }

        void ICustomComponent.Restart()
        {
            Rendered = false;
            
            RegisteredWindows.Clear();
            WindowsOrder.Clear();
            WindowsPosition.Clear();
        }
        
        protected override Element Render()
        {
            var children = new Children
            {
                Props.content
            };
            
            if (!Props.hideAllWindows)
            {
                foreach (var index in WindowsOrder)
                {
                    if (index < 0 || index >= RegisteredWindows.Count)
                    {
                        continue;
                    }

                    var window = RegisteredWindows[index];
                    var nodeHashCode = window.NodeHashCode;
                    if (!WindowsPosition.TryGetValue(nodeHashCode, out var localRect))
                    {
                        // TODO: Support transformed elements
                        // localRect = window.ChangeCoordinatesTo(this, window.contentRect);
                        localRect = WorldToLocal(window.ParentWorldContentRect);
                    }

                    var props = window.Props;

                    WindowsPosition[nodeHashCode] = localRect;

                    var element = InternalWindow.Create(new InternalWindowProps
                    {
                        index = index,
                        nodeHashCode = nodeHashCode,
                        content = props.content,
                        draggable = props.draggable
                    });

                    var holder = Div.Create((uint)index, new Style
                    {
                        position = Position.Absolute,
                        left = localRect.x,
                        width = localRect.width,
                        top = localRect.y,
                        height = localRect.height,
                        pointerDetection = PointerDetectionMode.Ignore
                    }, children: element);

                    children.Add(holder);
                }
            }

            return Div.Create(Props.descriptor, children: children);
        }

        internal int RegisterWindow(Window window)
        {
            if (window == null)
            {
                return -1;
            }

            var nodeHashCode = window.NodeHashCode;
            if (RegisteredWindowsSet.Contains(nodeHashCode))
            {
                Debug.LogError("Window already registered. Make sure the window has a unique branch in the tree.");
                return -1;
            }

            var index = RegisteredWindows.Count;
            
            RegisteredWindowsSet.Add(nodeHashCode);
            RegisteredWindows.Add(window);

            return index;
        }

        internal bool UnregisterWindow(Window window)
        {
            if (window == null)
            {
                return false;
            }
            var index = window.Index;
            if (index < 0)
            {
                return false;
            }

            var nodeHashCode = window.NodeHashCode;
            if (!RegisteredWindowsSet.Contains(nodeHashCode))
            {
                return false;
            }
            
            if (RegisteredWindows[index] != window)
            {
                return false;
            }

            RegisteredWindowsSet.Remove(nodeHashCode);
            
            if (index == RegisteredWindows.Count - 1)
            {
                RegisteredWindows.RemoveAt(index);
                while (RegisteredWindows.Count > 0)
                {
                    var lastIndex = RegisteredWindows.Count - 1;
                    if (RegisteredWindows[lastIndex] != null)
                    {
                        break;
                    }
                    
                    RegisteredWindows.RemoveAt(lastIndex);
                }
            }
            else
            {
                RegisteredWindows[index] = null;
            }

            var order = WindowsOrder.IndexOf(index);
            if (order >= 0)
            {
                WindowsOrder.RemoveAt(order);
                if (order == 0)
                {
                    BroadcastFocusEvent();
                }
            }
            
            Dirty(Rendered);

            return true;
        }

        internal void OpenWindow(int index)
        {
            if (index < 0 || index >= RegisteredWindows.Count)
            {
                return;
            }
            
            if (WindowsOrder.Contains(index))
            {
                Dirty(true);
                return;
            }
            
            MoveWindowToFront(index);
        }

        internal void CloseWindow(int index)
        {
            var dirty = WindowsOrder.Remove(index);

            if (dirty)
            {
                BroadcastFocusEvent();
                Dirty(Rendered);
            }
        }

        internal void Drag(ulong nodeHashCode, Vector2 delta)
        {
            if (!WindowsPosition.TryGetValue(nodeHashCode, out var rect))
            {
                return;
            }

            rect.x += delta.x;
            rect.y += delta.y;

            WindowsPosition[nodeHashCode] = rect;
            
            Dirty(Rendered);
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

        internal void MoveWindowToFront(int index)
        {
            var totalCount = WindowsOrder.Count;
            if (totalCount == 0)
            {
                WindowsOrder.Add(index);
            }
            else
            {
                var lastPosition = totalCount - 1;
                if (WindowsOrder[lastPosition] == index)
                {
                    return;
                }

                var alwaysOnTop = RegisteredWindows[index].Props.alwaysOnTop;
                if (alwaysOnTop)
                {
                    if (WindowsOrder.Contains(index))
                    {
                        return;
                    }
                    
                    WindowsOrder.Add(index);
                }
                else
                {
                    var targetPosition = totalCount;
                    while (targetPosition > 0 && RegisteredWindows[WindowsOrder[targetPosition - 1]].Props.alwaysOnTop)
                    {
                        targetPosition--;
                    }
                
                    if (WindowsOrder.Count > targetPosition && WindowsOrder[targetPosition] == index)
                    {
                        return;
                    }

                    var removed = WindowsOrder.Remove(index);
                    WindowsOrder.Insert(removed ? targetPosition - 1 : targetPosition, index);
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

        private void OnGeometry(GeometryChangedEvent evt)
        {
            if (Rendered)
            {
                return;
            }

            Rendered = true;
            Dirty();
        }

        private void BroadcastFocusEvent()
        {
            if (WindowsOrder.Count <= 0)
            {
                return;
            }

            var focusedWindow = WindowsOrder[^1];
            
            for (int i = 0, n = WindowsOrder.Count; i < n; i++)
            {
                var index = WindowsOrder[i];
                if (index < 0 || index >= RegisteredWindows.Count)
                {
                    continue;
                }

                var window = RegisteredWindows[index];
                using var pooledEvent = WindowFocusEvent.GetPooled(focusedWindow, this, window);
                window.SendEvent(pooledEvent);
            }
        }
    }

    [RishValueType]
    public struct WindowsContextProps
    {
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public bool forceFit;
        public int safeZoneSize;
        public bool hideAllWindows;
        public Children content;
    }
}