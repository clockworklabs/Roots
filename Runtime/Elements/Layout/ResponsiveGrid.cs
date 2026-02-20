using RishUI;
using RishUI.Events;
using RishUI.MemoryManagement;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class ResponsiveGrid : RishElement<ResponsiveGridProps, ResponsiveGridState>, IMountingListener, IPropsListener<ResponsiveGridProps>
    {
        private ResponsiveContext _context;
        private ResponsiveContext Context
        {
            set
            {
                if (_context == value) return;
                
                _context?.OnLayout.Remove(SappyOnContextLayout);
                
                _context = value;

                if (value != null)
                {
                    value.OnLayout.Add(SappyOnContextLayout);
                    OnContextLayout(value.GetLayoutData());
                }
            }
        }

        public ResponsiveGrid()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange, EventPhase.AtTargetOnly);
        }
        
        void IMountingListener.ComponentDidMount() { }
        void IMountingListener.ComponentWillUnmount()
        {
            Context = null;
        }

        void IPropsListener<ResponsiveGridProps>.PropsDidChange(ResponsiveGridProps? prev)
        {
            if(prev.HasValue)
            {
                Update();
            }
            else
            {
                Context = GetFirstAncestorOfType<ResponsiveContext>();
            }
        }
        void IPropsListener<ResponsiveGridProps>.PropsWillChange() { }
        
        protected override Element Render()
        {
            SetSingleRow(false);
            
            var colSizes = new RishList<int>();
            int size;
            if (State.size.HasValue)
            {
                size = State.size.Value;
            }
            else
            {
                size = 0;
                if (State.size is null or > 0)
                {
                    foreach (var col in Props.cols)
                    {
                        var colSize = col.GetSize(State.breakpoint);
                        size += colSize;
                        colSizes.Add(colSize);
                    }
                }
            }

            if (size <= 0)
            {
                return Div.Create(descriptor: Props.descriptor);
            }
            
            var rowWidth = State.width + State.gutter.x;
            var colsCount = Props.cols.Count;
            
            var colWidth = rowWidth / size;
            
            var rows = new Children();
            var i = 0;
            do
            {
                var children = new Children();
                var rowUsedSize = 0;
                for (; i < colsCount; i++)
                {
                    var col = Props.cols[i];
                    var colSize = colSizes.Count > 0 ? colSizes[i] : col.GetSize(State.breakpoint);
                    if (colSize <= 0 || colSize > size) continue;

                    if (rowUsedSize + colSize > size) break;
                    
                    rowUsedSize += colSize;
                    
                    var width = colWidth * colSize - State.gutter.x;
                    
                    children.Add(Col.Create(
                        key: (ulong)(children.Count + 1),
                        style: new Style
                        {
                            width = width,
                            minWidth = width,
                            maxWidth = width,
                        },
                        gap: State.gutter.y,
                        children: col.children));
                }
                
                if(children.Count > 0)
                {
                    if (i < colsCount || rows.Count > 0)
                    {
                        rows.Add(Row.Create(key: (ulong)(rows.Count + 1), gap: State.gutter.x, children: children));
                    }
                    else
                    {
                        SetSingleRow(true);
                        return Row.Create(
                            name: Props.descriptor.name,
                            className: Props.descriptor.className,
                            style: Props.descriptor.style,
                            gap: State.gutter.x,
                            children: children);
                    }
                }
            } while (i < colsCount);

            if (rows.Count <= 0)
            {
                return Div.Create(descriptor: Props.descriptor);
            }

            return Col.Create(
                name: Props.descriptor.name,
                className: Props.descriptor.className,
                style: Props.descriptor.style,
                gap: State.gutter.y,
                children: rows);
        }
        
        private void OnVisualChange(VisualChangeEvent evt)
        {
            if(evt.target is not VisualElement visualElement) return;
            var width = Mathf.FloorToInt(visualElement.contentRect.width);
            if (State.singleRow)
            {
                width -= Mathf.CeilToInt(State.gutter.x);
            }
            SetWidth(width);
        }

        [SapTarget]
        private void OnContextLayout(ResponsiveContext.LayoutData data)
        {
            SetBreakpoint(data.breakpoint);
            Update();
        }

        private void Update()
        {
            var size = State.breakpoint;
            
            SetSize(GetSize(size));
            SetGutter(GetGutter(size));
        }
        
        private Gutter GetGutter(ResponsiveBreakpoint breakpoint)
        {
            var propsGutter = GetPropsGutter(breakpoint);
            if(propsGutter.HasValue) return propsGutter.Value;
            
            if(breakpoint is ResponsiveBreakpoint.ExtraSmall) return new Gutter();
            
            var prevSize = breakpoint - 1;
            return GetGutter(prevSize);
        }

        private Gutter? GetPropsGutter(ResponsiveBreakpoint breakpoint) => breakpoint switch
        {
            ResponsiveBreakpoint.ExtraSmall => Props.xsGutter,
            ResponsiveBreakpoint.Small => Props.smGutter,
            ResponsiveBreakpoint.Medium => Props.mdGutter,
            ResponsiveBreakpoint.Large => Props.lgGutter,
            ResponsiveBreakpoint.ExtraLarge => Props.xlGutter,
            ResponsiveBreakpoint.ExtraExtraLarge => Props.xxlGutter
        };
        
        private int? GetSize(ResponsiveBreakpoint breakpoint)
        {
            var propsCols = GetPropsSize(breakpoint);
            if(propsCols.HasValue) return propsCols.Value;
            
            if(breakpoint is ResponsiveBreakpoint.ExtraSmall) return null;
            
            var prevSize = breakpoint - 1;
            return GetSize(prevSize);
        }

        private int? GetPropsSize(ResponsiveBreakpoint breakpoint) => breakpoint switch
        {
            ResponsiveBreakpoint.ExtraSmall => Props.xs,
            ResponsiveBreakpoint.Small => Props.sm,
            ResponsiveBreakpoint.Medium => Props.md,
            ResponsiveBreakpoint.Large => Props.lg,
            ResponsiveBreakpoint.ExtraLarge => Props.xl,
            ResponsiveBreakpoint.ExtraExtraLarge => Props.xxl
        };

        [RishValueType]
        internal struct FinalColData
        {
            public int index;
            public int size;
        }
    }

    public struct Gutter
    {
        public float x;
        public float y;
    
        public Gutter(float value)
        {
            x = value;
            y = value;
        }
        public Gutter(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        public static implicit operator Gutter(float value) => new (value);
        public static implicit operator Gutter((float x, float y) value) => new (value.x, value.y);
        public static implicit operator Gutter(Vector2 value) => new (value.x, value.y);
    
        public static Gutter X(float x) => new()
        {
            x = x
        };
        public static Gutter Y(float y) => new()
        {
            y = y
        };
        
        public static Gutter operator -(Gutter a) => new(-a.x, -a.y);
        public static Gutter operator *(Gutter left, float right) => new(left.x * right, left.y * right);
        public static Gutter operator /(Gutter left, float right) => new(left.x / right, left.y / right);

        public override string ToString() => $"x: {x}, y: {y}";
    }

    [RishValueType]
    public struct ColData
    {
        public int? xs;
        public int? sm;
        public int? md;
        public int? lg;
        public int? xl;
        public int? xxl;

        public Children children;

        public ColData(Children children)
        {
            xs = null;
            sm = null;
            md = null;
            lg = null;
            xl = null;
            xxl = null;
            this.children = children;
        }
        public ColData(int size, Children children)
        {
            xs = size;
            sm = null;
            md = null;
            lg = null;
            xl = null;
            xxl = null;
            this.children = children;
        }

        public static ColData XS(Children children) => XS(1, children);
        public static ColData XS(int size, Children children) => new()
        {
            xs = size,
            children = children
        };
        [RequiresManagedContext]
        public static ColData XS(Element child) => XS((Children)child);
        [RequiresManagedContext]
        public static ColData XS(int size, Element child) => XS(size, (Children)child);
        public static ColData SM(Children children) => SM(1, children);
        public static ColData SM(int size, Children children) => new()
        {
            sm = size,
            children = children
        };
        [RequiresManagedContext]
        public static ColData SM(Element child) => SM((Children)child);
        [RequiresManagedContext]
        public static ColData SM(int size, Element child) => SM(size, (Children)child);
        public static ColData MD(Children children) => MD(1, children);
        public static ColData MD(int size, Children children) => new()
        {
            sm = 0,
            md = size,
            children = children
        };
        [RequiresManagedContext]
        public static ColData MD(Element child) => MD((Children)child);
        [RequiresManagedContext]
        public static ColData MD(int size, Element child) => MD(size, (Children)child);
        public static ColData LG(Children children) => LG(1, children);
        public static ColData LG(int size, Children children) => new()
        {
            sm = 0,
            md = 0,
            lg = size,
            children = children
        };
        [RequiresManagedContext]
        public static ColData LG(Element child) => LG((Children)child);
        [RequiresManagedContext]
        public static ColData LG(int size, Element child) => LG(size, (Children)child);
        public static ColData XL(Children children) => XL(1, children);
        public static ColData XL(int size, Children children) => new()
        {
            sm = 0,
            md = 0,
            lg = 0,
            xl = size,
            children = children
        };
        [RequiresManagedContext]
        public static ColData XL(Element child) => XL((Children)child);
        [RequiresManagedContext]
        public static ColData XL(int size, Element child) => XL(size, (Children)child);
        public static ColData XXL(Children children) => XXL(1, children);
        public static ColData XXL(int size, Children children) => new()
        {
            sm = 0,
            md = 0,
            lg = 0,
            xl = 0,
            xxl = size,
            children = children
        };
        [RequiresManagedContext]
        public static ColData XXL(Element child) => XXL((Children)child);
        [RequiresManagedContext]
        public static ColData XXL(int size, Element child) => XXL(size, (Children)child);
        
        public static implicit operator ColData(Children value) => new()
        {
            children = value
        };
        [RequiresManagedContext]
        public static implicit operator ColData(Element value) => new()
        {
            children = value
        };
        
        public int GetSize(ResponsiveBreakpoint breakpoint)
        {
            var propsSize = GetPropsSize(breakpoint);
            if(propsSize.HasValue) return propsSize.Value;
            
            if(breakpoint is ResponsiveBreakpoint.ExtraSmall) return 1;
            
            var prevSize = breakpoint - 1;
            return GetSize(prevSize);
        }

        private int? GetPropsSize(ResponsiveBreakpoint breakpoint) => breakpoint switch
        {
            ResponsiveBreakpoint.ExtraSmall => xs,
            ResponsiveBreakpoint.Small => sm,
            ResponsiveBreakpoint.Medium => md,
            ResponsiveBreakpoint.Large => lg,
            ResponsiveBreakpoint.ExtraLarge => xl,
            ResponsiveBreakpoint.ExtraExtraLarge => xxl
        };
    }

    [RishValueType]
    public struct ResponsiveGridProps
    {
        public int? xs;
        public int? sm;
        public int? md;
        public int? lg;
        public int? xl;
        public int? xxl;

        public Gutter? xsGutter;
        public Gutter? smGutter;
        public Gutter? mdGutter;
        public Gutter? lgGutter;
        public Gutter? xlGutter;
        public Gutter? xxlGutter;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;

        public RishList<ColData> cols;
    }

    [RishValueType]
    public struct ResponsiveGridState
    {
        public ResponsiveBreakpoint breakpoint;
        public int? size;
        public Gutter gutter;
        public int width;
        [IgnoreComparison]
        public bool singleRow;
    }
}
