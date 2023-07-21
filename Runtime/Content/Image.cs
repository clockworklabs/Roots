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

        private static readonly CustomStyleProperty<Color> TintColorProp = new("--props-tint-color"); 
        private static readonly CustomStyleProperty<string> ScaleModeProp = new("--props-scale-mode"); 
        private static readonly CustomStyleProperty<string> ImageWidthProp = new("--props-image-width"); 
        private static readonly CustomStyleProperty<string> ImageHeightProp = new("--props-image-height"); 

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
            Width = props.width.Value;
            Height = props.height.Value;

            image = null;
            sprite = null;
            vectorImage = null;
            
            image = props.texture != null ? props.texture : props.renderTexture;
            if (image == null)
            {
                sprite = props.sprite;
            }
            if (image == null && sprite == null)
            {
                vectorImage = props.vectorImage;
            }

            tintColor = props.tintColor.Value;

            // this.uv = Rect.MinMaxRect(0, 0, 1, 1);
            scaleMode = props.scaleMode.Value;

            if (sprite != null)
            {
                style.unitySliceTop = Mathf.RoundToInt(sprite.border.w);
                style.unitySliceRight = Mathf.RoundToInt(sprite.border.z);
                style.unitySliceBottom = Mathf.RoundToInt(sprite.border.y);
                style.unitySliceLeft = Mathf.RoundToInt(sprite.border.x);
                style.unitySliceScale = 100 / sprite.pixelsPerUnit;

                style.backgroundImage = Background.FromSprite(sprite);

                style.unityBackgroundImageTintColor = props.tintColor.Value;
                
                sprite = null;
            }
        }

        void IStyledProps<Image, ImageProps>.OnCustomStyle(ref ImageProps props)
        {
            props.tintColor ??= customStyle.TryGetValue(TintColorProp, out var customTintColor) ? customTintColor : Color.white;
            props.scaleMode ??= customStyle.TryGetValue(ScaleModeProp, out var customScaleMode) ? customScaleMode switch
            {
                "scale-and-crop" => ScaleMode.ScaleAndCrop,
                "scale-to-fit" => ScaleMode.ScaleToFit,
                _ => ScaleMode.StretchToFill
            } : default;
            props.width ??= customStyle.TryGetValue(ImageWidthProp, out var customImageWidth) ? ImageSize.Parse(customImageWidth) : default;
            props.height ??= customStyle.TryGetValue(ImageHeightProp, out var customImageHeight) ? ImageSize.Parse(customImageHeight) : default;
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
                    var paddingAndBorder = layout.width - contentRect.width;
                    style.width = contentRect.height * aspectRatio + paddingAndBorder;
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
                    var paddingAndBorder = layout.height - contentRect.height;
                    style.height = contentRect.width / aspectRatio + paddingAndBorder;
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

        internal static ImageSize Parse(string customValue)
        {
            switch (customValue)
            {
                case "auto":
                    return AspectRatio;
                case "0":
                    return Pixel(0);
            }

            if (customValue.EndsWith("px"))
            {
                if (int.TryParse(customValue.Substring(0, customValue.Length - 2), out var pixels))
                {
                    return Pixel(pixels);
                }
            } else if (customValue.EndsWith("%"))
            {
                if (int.TryParse(customValue.Substring(0, customValue.Length - 1), out var percent))
                {
                    return Percent(percent);
                }
            }

            return default;
        }
    }
    
    [RishValueType]
    public struct ImageProps
    {
        public Sprite sprite;
        public VectorImage vectorImage;
        public Texture2D texture;
        public RenderTexture renderTexture;
        /// <summary>
        /// Styled Prop as --prop-scale-mode
        /// </summary>
        public ScaleMode? scaleMode;
        // TODO: public Rect? uv;
        
        /// <summary>
        /// Styled Prop as --prop-tint-color
        /// </summary>
        public Color? tintColor;
        
        /// <summary>
        /// Styled Prop as --prop-image-width
        /// </summary>
        public ImageSize? width;
        /// <summary>
        /// Styled Prop as --prop-image-height
        /// </summary>
        public ImageSize? height;
    }
}