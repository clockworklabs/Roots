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

        public const float DefaultBufferSize = 0.45f;

        private Dictionary<int, float> Sizes { get; } = new();
        private float _computedContentSize;
        private float ComputedContentSize
        {
            get => _computedContentSize;
            set
            {
                if (Mathf.Approximately(_computedContentSize, value)) return;
                _computedContentSize = value;
                UpdateAverageElementSize();
            }
        }
        private float _averageElementSize;
        private float AverageElementSize
        {
            get => _averageElementSize;
            set
            {
                if (Mathf.Approximately(_averageElementSize, value)) return;
                _averageElementSize = value;
                OnElementSize(value);
            }
        }
        private float _projectedContentSize;
        private float ProjectedContentSize
        {
            get => _projectedContentSize;
            set
            {
                if (Mathf.Approximately(_projectedContentSize, value)) return;
                _projectedContentSize = value;
                OnContentSize(value);
            }
        }

        public ScrollView()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange, EventPhase.AtTargetOnly);
        }

        void IMountingListener.ElementDidMount() { }
        void IMountingListener.ElementWillUnmount()
        {
            Sizes.Clear();
            _computedContentSize = 0;
            _projectedContentSize = 0;
            _averageElementSize = 0;
        }

        void IPropsListener<ScrollViewProps>.PropsDidChange(ScrollViewProps? prev)
        {
            SetupViewportSize();

            if (Props.elementsSize.HasValue)
            {
                ComputedContentSize = 0;
                Sizes.Clear();

                UpdateAverageElementSize();
            }
            else if(prev.HasValue)
            {
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
            
            UpdateProjectedContentSize();
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

            if (Sizes.TryGetValue(index, out var prevSize))
            {
                if (Mathf.Approximately(prevSize, size))
                {
                    return;
                }
                
                ComputedContentSize -= prevSize;
            }

            Sizes[index] = size;

            ComputedContentSize += size;
            
            UpdateProjectedContentSize();

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

            return Div.Create(attributes: Props.attributes, children: children);
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
            if (State.viewportSize <= 0) return RishList<Entry>.Null;

            var bufferSize = Props.bufferSize > 0 ? Props.bufferSize : DefaultBufferSize;
            var bottomBuffer = 1 + bufferSize;
            var topBuffer = -bufferSize;
            
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
                if (elementPosition / State.viewportSize >= bottomBuffer)
                {
                    outsideOfViewport = true;
                    if (alwaysMounted.Count <= 0)
                    {
                        break;
                    }
                }

                var size = Props.elementsSize ?? Sizes.GetValueOrDefault(i, AverageElementSize > 0 ? AverageElementSize : -1);
                if (size >= 0)
                {
                    position += size;
                }

                if (position / State.viewportSize <= topBuffer)
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

        private void UpdateAverageElementSize() => AverageElementSize = Props.elementsSize ?? (Sizes.Count == 0 ? 0 : ComputedContentSize / Sizes.Count);

        private void UpdateProjectedContentSize()
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

            ProjectedContentSize = elementsSize + (totalCount - 1) * Props.gap;
        }
    }

    [RishValueType]
    public struct ScrollViewProps
    {
        public float position;

        [Expand]
        public VisualAttributes attributes;

        public ScrollView.Direction direction;
        
        public int gap;
        public float bufferSize;

        public Children children;
        public bool inverted;

        public RishList<int> alwaysMountedIndices;

        public float? elementsSize;

        public Action<float> onElementSize;
        public Action<float> onViewportSize;
        public Action<float> onContentSize;
    }

    [RishValueType]
    public struct ScrollViewState
    {
        public float viewportSize;
    }
}