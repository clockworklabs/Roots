using System.Text;
using RishUI;
using RishUI.Events;
using Unity.Collections;
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

        private static readonly CustomStyleProperty<string> TextureAddressProp = new("--props-texture"); 
        private static readonly CustomStyleProperty<string> SpriteAddressProp = new("--props-sprite"); 
        private static readonly CustomStyleProperty<string> VectorAddressProp = new("--props-vector"); 
        private static readonly CustomStyleProperty<string> RenderTextureAddressProp = new("--props-render-texture"); 
        private static readonly CustomStyleProperty<Color> TintColorProp = new("--props-tint-color"); 
        private static readonly CustomStyleProperty<string> ScaleModeProp = new("--props-scale-mode"); 
        private static readonly CustomStyleProperty<string> ImageWidthProp = new("--props-image-width"); 
        private static readonly CustomStyleProperty<string> ImageHeightProp = new("--props-image-height"); 

        private AssetsLoader Loader { get; set; }
        
        private VisualElement Parent { get; set; }
        private ImageSize Width;
        private ImageSize Height;
        private FixedString128Bytes TextureAddress;
        private FixedString128Bytes SpriteAddress;
        private FixedString128Bytes VectorAddress;
        private FixedString128Bytes RenderTextureAddress;
        private StyleLength InlineWidth;
        private StyleLength InlineHeight;

        private StringBuilder StringBuilder { get; } = new();
        
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

            if (Loader != null)
            {
                var directSet = false;
                if (props.texture != null)
                {
                    directSet = true;
                    SetTexture(props.texture);
                } else if (props.sprite != null)
                {
                    directSet = true;
                    SetSprite(props.sprite);
                } else if (props.vector != null)
                {
                    directSet = true;
                    SetVector(props.vector);
                } else if (props.renderTexture != null)
                {
                    directSet = true;
                    SetRenderTexture(props.renderTexture);
                }

                if (directSet)
                {
                    TextureAddress = string.Empty;
                    SpriteAddress = string.Empty;
                    VectorAddress = string.Empty;
                    RenderTextureAddress = string.Empty;
                } else 
                {
                    var textureAddress = props.textureAddress.Value;
                    var textureSet = !string.IsNullOrWhiteSpace(textureAddress.Value);
                    if (!textureSet)
                    {
                        textureAddress = string.Empty;
                    }
                    if (textureAddress != TextureAddress)
                    {
                        TextureAddress = textureAddress;
                        Loader.Load<Texture2D>(textureAddress.Value, OnTextureLoaded);
                    }

                    var spriteAddress = props.spriteAddress.Value;
                    var spriteSet = !textureSet && !string.IsNullOrWhiteSpace(spriteAddress.Value);
                    if (!spriteSet)
                    {
                        spriteAddress = string.Empty;
                    }
                    if (spriteAddress != SpriteAddress)
                    {
                        SpriteAddress = spriteAddress;
                        Loader.Load<Sprite>(spriteAddress.Value, OnSpriteLoaded);
                    }

                    var vectorAddress = props.vectorAddress.Value;
                    var vectorSet = !spriteSet && !string.IsNullOrWhiteSpace(vectorAddress.Value);
                    if (!vectorSet)
                    {
                        vectorAddress = string.Empty;
                    }
                    if (vectorAddress != VectorAddress)
                    {
                        VectorAddress = vectorAddress;
                        Loader.Load<VectorImage>(vectorAddress.Value, OnVectorLoaded);
                    }

                    var renderTextureAddress = props.renderTextureAddress.Value;
                    var renderTextureSet = !vectorSet && !string.IsNullOrWhiteSpace(renderTextureAddress.Value);
                    if (!renderTextureSet)
                    {
                        renderTextureAddress = string.Empty;
                    }
                    if (renderTextureAddress != RenderTextureAddress)
                    {
                        RenderTextureAddress = renderTextureAddress;
                        Loader.Load<RenderTexture>(renderTextureAddress.Value, OnRenderTextureLoaded);
                    }
                }
            }
            else
            {
                Debug.LogError("App needs an Asset Loader");
            }

            tintColor = props.tintColor.Value;

            // this.uv = Rect.MinMaxRect(0, 0, 1, 1);
            scaleMode = props.scaleMode.Value;

            if (sprite != null)
            {
                var border = sprite.border;
                if (border != Vector4.zero)
                {
                    style.unitySliceTop = Mathf.RoundToInt(border.w);
                    style.unitySliceRight = Mathf.RoundToInt(border.z);
                    style.unitySliceBottom = Mathf.RoundToInt(border.y);
                    style.unitySliceLeft = Mathf.RoundToInt(border.x);
                    style.unitySliceScale = 100 / sprite.pixelsPerUnit;

                    style.backgroundImage = Background.FromSprite(sprite);

                    style.unityBackgroundImageTintColor = props.tintColor.Value;
                
                    sprite = null;
                }
            }
            
            // this.AddClassNames(props.utilities, StringBuilder);
        }

        void IStyledProps<Image, ImageProps>.OnCustomStyle(ref ImageProps props)
        {
            props.textureAddress ??= customStyle.TryGetValue(TextureAddressProp, out var customTextureAddress) 
                ? customTextureAddress
                : string.Empty;
            props.spriteAddress ??= customStyle.TryGetValue(SpriteAddressProp, out var customSpriteAddress) 
                ? customSpriteAddress
                : string.Empty;
            props.vectorAddress ??= customStyle.TryGetValue(VectorAddressProp, out var customVectorAddress) 
                ? customVectorAddress
                : string.Empty;
            props.renderTextureAddress ??= customStyle.TryGetValue(RenderTextureAddressProp, out var customRenderTextureAddress) 
                ? customRenderTextureAddress
                : string.Empty;
            
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

        private void OnTextureLoaded(Asset<Texture2D> asset)
        {
            if (asset.address != TextureAddress)
            {
                return;
            }

            SetTexture(asset.asset);
        }
        private void SetTexture(Texture2D texture)
        {
            image = texture;
            if (texture == null) return;
            sprite = null;
            vectorImage = null;
        }
        private void OnSpriteLoaded(Asset<Sprite> asset)
        {
            if (asset.address != SpriteAddress)
            {
                return;
            }

            SetSprite(asset.asset);
        }
        private void SetSprite(Sprite sprite)
        {
            this.sprite = sprite;
            if (sprite == null) return;
            image = null;
            vectorImage = null;
            
            var border = sprite.border;
            if (border != Vector4.zero)
            {
                style.unitySliceTop = Mathf.RoundToInt(border.w);
                style.unitySliceRight = Mathf.RoundToInt(border.z);
                style.unitySliceBottom = Mathf.RoundToInt(border.y);
                style.unitySliceLeft = Mathf.RoundToInt(border.x);
                style.unitySliceScale = 100 / sprite.pixelsPerUnit;

                style.backgroundImage = Background.FromSprite(sprite);

                style.unityBackgroundImageTintColor = tintColor;
                
                this.sprite = null;
            }
        }
        private void OnVectorLoaded(Asset<VectorImage> asset)
        {
            if (asset.address != VectorAddress)
            {
                return;
            }

            SetVector(asset.asset);
        }
        private void SetVector(VectorImage vectorImage)
        {
            this.vectorImage = vectorImage;
            if (vectorImage == null) return;
            image = null;
            sprite = null;
        }
        private void OnRenderTextureLoaded(Asset<RenderTexture> asset)
        {
            if (asset.address != RenderTextureAddress)
            {
                return;
            }

            SetRenderTexture(asset.asset);
        }
        private void SetRenderTexture(RenderTexture renderTexture)
        {
            image = renderTexture;
            if (renderTexture == null) return;
            sprite = null;
            vectorImage = null;
        }

        private void OnMounted(AttachToPanelEvent evt)
        {
            Loader = AssetsLoader.GetLoader(this);
            
            Parent = parent;
            Parent?.RegisterCallback<GeometryChangedEvent>(OnGeometryChanged);
        }
        
        private void OnUnmounted(DetachFromPanelEvent evt)
        {
            image = null;
            sprite = null;
            vectorImage = null;
            tintColor = Color.white;
            scaleMode = ScaleMode.StretchToFill;

            Loader = null;
            
            Parent?.UnregisterCallback<GeometryChangedEvent>(OnGeometryChanged);
            Parent = null;
            
            Width = default;
            Height = default;
            TextureAddress = default;
            SpriteAddress = default;
            VectorAddress = default;
            RenderTextureAddress = default;
            InlineWidth = default;
            InlineHeight = default;
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
    
    public struct ImageProps
    {
        public Texture2D texture;
        public Sprite sprite;
        public VectorImage vector;
        public RenderTexture renderTexture;
        
        /// <summary>
        /// Styled Prop as --props-texture
        /// </summary>
        public FixedString128Bytes? textureAddress;
        /// <summary>
        /// Styled Prop as --props-sprite
        /// </summary>
        public FixedString128Bytes? spriteAddress;
        /// <summary>
        /// Styled Prop as --props-vector
        /// </summary>
        public FixedString128Bytes? vectorAddress;
        /// <summary>
        /// Styled Prop as --props-render-texture
        /// </summary>
        public FixedString128Bytes? renderTextureAddress;
        
        /// <summary>
        /// Styled Prop as --props-scale-mode
        /// </summary>
        public ScaleMode? scaleMode;
        // TODO: public Rect? uv;
        
        /// <summary>
        /// Styled Prop as --props-tint-color
        /// </summary>
        public Color? tintColor;
        
        /// <summary>
        /// Styled Prop as --props-image-width
        /// </summary>
        public ImageSize? width;
        /// <summary>
        /// Styled Prop as --props-image-height
        /// </summary>
        public ImageSize? height;

        // public Utilities utilities;
    }
}