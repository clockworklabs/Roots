using System;
using System.Collections.Generic;
using System.Linq;
using RishUI;
using RishUI.Events;
using RishUI.MemoryManagement;
using UnityEngine;

namespace Roots.Experimental
{
    public partial class ScrollView : RishElement<ScrollViewProps, ScrollViewState>, IMountingListener, IPropsListener<ScrollViewProps>
    {
        public enum Direction { Vertical, Horizontal }

        private Dictionary<int, float> Sizes { get; } = new();
        private float ComputedContentSize { get; set; }
        private float AverageElementSize => Props.elementsSize ?? (Sizes.Count == 0 ? 0 : ComputedContentSize / Sizes.Count);
        private float _projectedContentSize;
        private float ProjectedContentSize
        {
            get
            {
                var totalCount = Props.children.Count;
                float elementsSize;
                if (Props.elementsSize.HasValue)
                {
                    elementsSize = totalCount * Props.elementsSize.Value;
                }
                else
                {
                    var projectedCount = Mathf.Max(0, totalCount - Sizes.Count);
                    elementsSize = ComputedContentSize + projectedCount * AverageElementSize;
                }

                var value = elementsSize + (totalCount - 1) * Props.gap;

                if (!Mathf.Approximately(_projectedContentSize, value))
                {
                    Props.onContentSize?.Invoke(value);
                }

                return value;
            }
        }
        private float ActualContentSize
        {
            get
            {
                if (Props.elementsSize.HasValue)
                {
                    return ProjectedContentSize;
                }

                return ComputedContentSize + (Sizes.Count - 1) * Props.gap;
            }
        }

        public ScrollView()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange, EventPhase.AtTargetOnly);
        }

        void IMountingListener.ComponentDidMount() { }
        void IMountingListener.ComponentWillUnmount()
        {
            Sizes.Clear();
            ComputedContentSize = 0;
            _projectedContentSize = 0;
        }

        void IPropsListener<ScrollViewProps>.PropsDidChange(ScrollViewProps? prev)
        {
            SetupViewportSize();

            if (Props.elementsSize.HasValue)
            {
                ComputedContentSize = 0;
                Sizes.Clear();
                return;
            }

            if (!prev.HasValue) return;

            var prevCount = prev.Value.children.Count;
            var count = Props.children.Count;
            if (prevCount == count) return;
            if (Sizes.Count > count)
            {
                for (int i = count, n = Sizes.Count - 1; i < n; i++)
                {
                    Sizes.Remove(i);
                }
                ComputedContentSize = 0;
                for (var i = 0; i < count; i++)
                {
                    ComputedContentSize += Sizes[i];
                }
            }
        }
        void IPropsListener<ScrollViewProps>.PropsWillChange() { }

        internal void SetSize(int index, float size)
        {
            if (Props.elementsSize.HasValue)
            {
                return;
            }

            if (index < 0 || index >= Props.children.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            float delta;
            if (Sizes.TryGetValue(index, out var prevSize))
            {
                if (Mathf.Approximately(prevSize, size))
                {
                    return;
                }

                delta = size - prevSize;

                ComputedContentSize -= prevSize;
            }
            else
            {
                delta = size - AverageElementSize;
            }

            Sizes[index] = size;

            // Compensate element growing when inverted and scrolling
            if (Props.inverted && !Mathf.Approximately(Props.position, 0))
            {
                int lastEntryIndex;
                using (ManagedContext.New())
                {
                    var entries = GetEntries();
                    lastEntryIndex = entries.Count > 0 ? entries[^1].index : index;
                }
                if (index < lastEntryIndex)
                {
                    // SetPosition(Props.position + delta); // TODO
                }
            }

            ComputedContentSize += size;
            if (ProjectedContentSize <= State.viewportSize)
            {
                // SetPosition(0); // TODO
            }
            Dirty(true);
        }

        protected override Element Render()
        {
            var entries = GetEntries();
            var children = new Children();
            foreach (var entry in entries)
            {
                var index = entry.index;
                var position = entry.position;
                var child = Props.children[index];
                var key = child.TryGetKey(out var k) && k > 0 ? k : (ulong)index;
                children.Add(Holder.Create(
                    key: key,
                    index: index,
                    direction: Props.direction,
                    content: child,
                    position: position,
                    inverted: Props.inverted,
                    fixedSize: Props.elementsSize));
            }

            return Div.Create(descriptor: Props.descriptor, children: children);
        }

        private struct Entry
        {
            public int index;
            public ulong key;
            public float position;
        }

        [RequiresManagedContext]
        private RishList<Entry> GetEntries()
        {
            var alwaysMounted = Props.alwaysMountedIndices;

            var position = -Props.position;
            var gapSize = Props.gap;
            var entries = new RishList<Entry>();
            for (int i = 0, n = Props.children.Count; i < n; i++)
            {
                if (i > 0)
                {
                    position += gapSize;
                }

                var outsideOfViewport = false;

                var elementPosition = position;
                if (elementPosition / State.viewportSize >= 1.2f)
                {
                    outsideOfViewport = true;
                    if (alwaysMounted.Count <= 0)
                    {
                        break;
                    }
                }

                var size = Props.elementsSize ?? Sizes.GetValueOrDefault(i, -1);
                if (size >= 0)
                {
                    position += size;
                }

                if (position / State.viewportSize <= -0.2f)
                {
                    outsideOfViewport = true;
                }

                if (!outsideOfViewport || alwaysMounted.Contains(i))
                {
                    entries.Add(new Entry
                    {
                        index = i,
                        position = elementPosition
                    });
                }

                if (size < 0)
                {
                    break;
                }
            }

            return entries;
        }

        private void OnVisualChange(VisualChangeEvent evt) => SetupViewportSize();

        private void SetupViewportSize() => SetViewportSize(Props.direction == Direction.Vertical ? ContentRect.height : ContentRect.width);
        
        private void SetViewportSize(float v)
        {
            if (Mathf.Approximately(v, State.viewportSize)) return;
            
            RishSetViewportSize(v);
            OnViewportSize(v);
        }
    }

    [RishValueType]
    public struct ScrollViewProps
    {
        public float position;

        [DOMDescriptor]
        public DOMDescriptor descriptor;

        public ScrollView.Direction direction;
        
        public int gap;

        public Children children;
        public bool inverted;

        public RishList<int> alwaysMountedIndices;

        public float? elementsSize;

        public Action<float> onPosition;
        public Action<float> onViewportSize;
        public Action<float> onContentSize;
    }

    [RishValueType]
    public struct ScrollViewState
    {
        public float viewportSize;
    }
}