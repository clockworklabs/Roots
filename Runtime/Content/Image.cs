using System.Numerics;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;
using StyleLength = UnityEngine.UIElements.StyleLength;
using Vector2 = UnityEngine.Vector2;
using VectorImage = UnityEngine.UIElements.VectorImage;

namespace Roots
{
    public partial class Image : UnityEngine.UIElements.Image, IVisualElement<ImageProps>, IStyledProps<Image, ImageProps>
    {
        VisualElement IElement.GetDOMChild() => this;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;
        
        private StyledPropsManager<Image, ImageProps> PropsManager { get; }
        StyledPropsManager<Image, ImageProps> IStyledProps<Image, ImageProps>.Manager => PropsManager;

        private VisualElement Parent { get; set; }
        private ImageSize Width;
        private ImageSize Height;
        private StyleLength InlineWidth;
        private StyleLength InlineHeight;

        public Image()
        {
            PickingManager = new RectPickingManager(this);
            PropsManager = new StyledPropsManager<Image, ImageProps>(this);
            
            RegisterCallback<AttachToPanelEvent>(OnMounted);
            RegisterCallback<DetachFromPanelEvent>(OnUnmounted);
            RegisterCallback<InlineStyleEvent>(OnInlineStyle);
            RegisterCallback<GeometryChangedEvent>(OnGeometryChanged);
        }
        
        void IVisualElement<ImageProps>.Setup(ImageProps props) => PropsManager.Setup(props);
        void IStyledProps<Image, ImageProps>.Setup(ImageProps props, bool dirty)
        {
            Width = props.width;
            Height = props.height;
            
            sprite = props.sprite;
            image = props.texture != null ? props.texture : props.renderTexture;
            vectorImage = props.vectorImage;
            tintColor = props.tintColor.Value;

            // this.uv = Rect.MinMaxRect(0, 0, 1, 1);
            scaleMode = props.scaleMode;
        }
        
        private void OnMounted(AttachToPanelEvent evt)
        {
            Parent = parent;
            Parent?.RegisterCallback<GeometryChangedEvent>(OnGeometryChanged);
        }
        
        private void OnUnmounted(DetachFromPanelEvent evt)
        {
            Parent?.UnregisterCallback<GeometryChangedEvent>(OnGeometryChanged);
            Parent = null;
        }

        private void OnInlineStyle(InlineStyleEvent evt)
        {
            InlineWidth = style.width;
            InlineHeight = style.height;
        }
        
        private void OnGeometryChanged(GeometryChangedEvent evt)
        {
            SetSize();
        }
        
        private void SetSize()
        {
            var aspectRatio = GetAspectRatio();
            if (aspectRatio < 0)
            {
                style.width = InlineWidth;
                style.height = InlineHeight;
                return;
            }

            if (Width.IsDefault())
            {
                style.width = InlineWidth;
            }
            else
            {
                if (Width.TryGetSize(out var width))
                {
                    style.width = width;
                } else if (!Height.IsAspectRatio())
                {
                    style.width = layout.size.y * aspectRatio;
                }
            }
            if (Height.IsDefault())
            {
                style.height = InlineHeight;
            }
            else
            {
                if (Height.TryGetSize(out var height))
                {
                    style.height = height;
                } else
                {
                    style.height = layout.size.x / aspectRatio;
                }
            }
        }

        public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);
        
        private float GetAspectRatio()
        {
            var size = image != null
                ? new Vector2(image.width, image.height)
                : sprite != null
                    ? sprite.bounds.size
                    : vectorImage != null
                        ? new Vector2(vectorImage.width, vectorImage.height)
                        : Vector2.negativeInfinity;
            
            if (size.x < 0 || size.y < 0)
            {
                return float.NegativeInfinity;
            }

            return size.x / size.y;
        }
    }

    public struct ImageSize
    {
        private bool aspectRatio;
        private Length? size;
        
        private ImageSize(bool aspectRatio)
        {
            this.aspectRatio = aspectRatio;
            this.size = default;
        }
        private ImageSize(Length size)
        {
            this.aspectRatio = false;
            this.size = size;
        }
    
        public bool IsDefault() => !aspectRatio && !size.HasValue;
        public bool IsAspectRatio() => aspectRatio;
        public bool TryGetSize(out Length size)
        {
            if (aspectRatio)
            {
                size = default;
                return false;
            }
            if (!this.size.HasValue)
            {
                size = default;
                return false;
            }
    
            size = this.size.Value;
            return true;
        }
    
        public static ImageSize Default => default;
        public static ImageSize AspectRatio => new ImageSize(true);
        public static ImageSize Pixel(float value) => new ImageSize(new Length(value));
        public static ImageSize Percent(float value) => new ImageSize(Length.Percent(value));
    
        public static implicit operator ImageSize(float value) => Pixel(value);
    }
    
    [RishValueType]
    public struct ImageProps
    {
        public Sprite sprite;
        public VectorImage vectorImage;
        public Texture2D texture;
        public RenderTexture renderTexture;

        public ScaleMode scaleMode;
        // public Rect? uv;
        public Color? tintColor;
        
        // // TODO: Styled ImageSize
        public ImageSize width;
        public ImageSize height;

        // TODO: Styled Rect props
        // [StyledProp("--props-uv", 0, 0, 1, 1)]
        // private Rect? UV
        // {
        //     get => uv;
        //     set => uv = value;
        // }
        [StyledProp("--props-tint-color", 1, 1, 1)]
        private Color? TintColor
        {
            get => tintColor;
            set => tintColor = value;
        }
    }
}