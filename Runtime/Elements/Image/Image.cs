using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;
using StyleLength = RishUI.StyleLength;
using Vector2 = UnityEngine.Vector2;
using VectorImage = UnityEngine.UIElements.VectorImage;

namespace Roots
{
    // If you set up backgroundImage or backgroundTint, behavior is undefined and will give unexpected results
    public partial class Image : UnityEngine.UIElements.Image, IVisualElement<ImageProps>, IStyledProps<ImageProps>, IMountingListener, IManualState, IStyleListener
    {
        private Bridge<ImageProps> Bridge { get; }
        Bridge<ImageProps> IVisualElement<ImageProps>.Bridge => Bridge;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;

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
        private ImageSize Width {get;set; }
        private ImageSize Height {get;set; }
        private RishString _textureAddress;
        private RishString TextureAddress
        {
            get => _textureAddress;
            set
            {
                if (RishUtils.Compare(_textureAddress, value)) return;

                _textureAddress = value;

                if (value.IsEmpty) return;
                
                Loader?.Load<Texture2D>(value, Sappy.OnTextureLoaded);
            }
        }
        private RishString _spriteAddress;
        private RishString SpriteAddress
        {
            get => _spriteAddress;
            set
            {
                if (RishUtils.Compare(_spriteAddress, value)) return;

                _spriteAddress = value;

                if (value.IsEmpty) return;
                
                Loader?.Load<Sprite>(value, Sappy.OnSpriteLoaded);
            }
        }
        private bool StyleBackgroundSet { get; set; }
        private RishString _vectorAddress;
        private RishString VectorAddress
        {
            get => _vectorAddress;
            set
            {
                if (RishUtils.Compare(_vectorAddress, value)) return;

                _vectorAddress = value;

                if (value.IsEmpty) return;
                
                Loader?.Load<VectorImage>(value, Sappy.OnVectorLoaded);
            }
        }
        private RishString _renderTextureAddress;
        private RishString RenderTextureAddress
        {
            get => _renderTextureAddress;
            set
            {
                if (RishUtils.Compare(_renderTextureAddress, value)) return;

                _renderTextureAddress = value;

                if (value.IsEmpty) return;
                
                Loader?.Load<RenderTexture>(value, Sappy.OnRenderTextureLoaded);
            }
        }
        private StyleLength InlineWidth { get; set; }
        private StyleLength InlineHeight { get; set; }
        
        private bool UseBackground { get; set; }

        void IMountingListener.ElementDidMount()
        {
            Loader = AssetsLoader.GetLoader(this);
            
            Parent = parent;
            Parent?.RegisterCallback<VisualChangeEvent>(Sappy.OnVisualChange);
        }
        void IMountingListener.ElementWillUnmount()
        {
            Parent?.UnregisterCallback<VisualChangeEvent>(Sappy.OnVisualChange);
            Parent = null;
        }
        
        void IManualState.Restart()
        {
            image = null;
            sprite = null;
            vectorImage = null;
            tintColor = Color.white;
            scaleMode = ScaleMode.StretchToFill;
            style.backgroundImage = StyleKeyword.Null;
            style.unityBackgroundImageTintColor = StyleKeyword.Null;

            Loader = null;

            UseBackground = false;
            Width = default;
            Height = default;
            TextureAddress = default;
            SpriteAddress = default;
            VectorAddress = default;
            RenderTextureAddress = default;
            StyleBackgroundSet = false;
            InlineWidth = default;
            InlineHeight = default;
        }
        
        void IStyleListener.StyleSet(Style style)
        {
            InlineWidth = style.width;
            InlineHeight = style.height;
        }
        
        public Image()
        {
            Bridge = new Bridge<ImageProps>(this);
            PickingManager = new RectPickingManager(Bridge);
            
            RegisterCallback<VisualChangeEvent>(Sappy.OnVisualChange);
        }
        
        void IVisualElement<ImageProps>.Setup(ImageProps props)
        {
            UseBackground = props.useBackground;
            
            Width = props.width.Value;
            Height = props.height.Value;

            tintColor = props.tintColor.Value;
            style.unityBackgroundImageTintColor = tintColor;

            // this.uv = Rect.MinMaxRect(0, 0, 1, 1);
            scaleMode = props.scaleMode.Value;

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
                TextureAddress = null;
                SpriteAddress = null;
                VectorAddress = null;
                RenderTextureAddress = null;
            } else 
            {
                var textureAddress = props.textureAddress.Value;
                var textureSet = !textureAddress.IsEmpty;
                var spriteAddress = props.spriteAddress.Value;
                var spriteSet = !textureSet && !spriteAddress.IsEmpty;
                var vectorAddress = props.vectorAddress.Value;
                var vectorSet = !spriteSet && !vectorAddress.IsEmpty;
                var renderTextureAddress = props.renderTextureAddress.Value;
                var renderTextureSet = !vectorSet && !renderTextureAddress.IsEmpty;
                TextureAddress = textureAddress;
                if (textureSet)
                {
                    SpriteAddress = null;
                    VectorAddress = null;
                    RenderTextureAddress = null;
                }
                else
                {
                    SpriteAddress = spriteAddress;
                    if (spriteSet)
                    {
                        VectorAddress = null;
                        RenderTextureAddress = null;
                    }
                    else
                    {
                        VectorAddress = vectorAddress;
                        if (vectorSet)
                        {
                            RenderTextureAddress = null;
                        }
                        else
                        {
                            RenderTextureAddress = renderTextureAddress;
                        }
                    }
                }

                if (!textureSet && !spriteSet && !vectorSet && !renderTextureSet)
                {
                    image = null;
                    sprite = null;
                    vectorImage = null;
                    style.backgroundImage = StyleKeyword.Null;
                }
            }
        }
        void IStyledProps<ImageProps>.OnCustomStyle(IStyler styler, ref ImageProps props)
        {
            styler.SetValue(TextureAddressProp, ref props.textureAddress);
            styler.SetValue(SpriteAddressProp, ref props.spriteAddress);
            styler.SetValue(VectorAddressProp, ref props.vectorAddress);
            styler.SetValue(RenderTextureAddressProp, ref props.renderTextureAddress);
            styler.SetValue(TintColorProp, ref props.tintColor, Color.white);
            props.scaleMode ??= styler.TryGetValue(ScaleModeProp, out var customScaleMode) ? customScaleMode switch
            {
                "scale-and-crop" => ScaleMode.ScaleAndCrop,
                "scale-to-fit" => ScaleMode.ScaleToFit,
                _ => ScaleMode.StretchToFill
            } : default;
            props.width ??= styler.TryGetValue(ImageWidthProp, out var customImageWidth) ? ImageSize.Parse(customImageWidth) : default;
            props.height ??= styler.TryGetValue(ImageHeightProp, out var customImageHeight) ? ImageSize.Parse(customImageHeight) : default;
        }

        [SapTarget(typeof(AssetLoaded<Texture2D>))]
        private void OnTextureLoaded(Asset<Texture2D> asset)
        {
            if (asset.address != TextureAddress)
            {
                return;
            }

            SetTexture(asset.asset);
        }
        private void SetTexture(Texture2D value)
        {
            if (StyleBackgroundSet)
            {
                style.backgroundImage = StyleKeyword.Null;
                StyleBackgroundSet = false;
            }
            
            image = value;
            if (value == null) return;
            sprite = null;
            vectorImage = null;
            style.backgroundImage = StyleKeyword.Null;
            
            if (UseBackground)
            {
                style.backgroundImage = Background.FromTexture2D(value);

                image = null;

                StyleBackgroundSet = true;
            }
        }
        [SapTarget(typeof(AssetLoaded<Sprite>))]
        private void OnSpriteLoaded(Asset<Sprite> asset)
        {
            if (asset.address != SpriteAddress)
            {
                return;
            }

            SetSprite(asset.asset);
        }
        private void SetSprite(Sprite value)
        {
            if (StyleBackgroundSet)
            {
                style.backgroundImage = StyleKeyword.Null;
                StyleBackgroundSet = false;
            }
            
            sprite = value;

            if (value == null) return;
            image = null;
            vectorImage = null;
            style.backgroundImage = StyleKeyword.Null;

            var border = value.border;
            if (UseBackground || border != Vector4.zero)
            {
                var style = this.style;
                
                style.unitySliceTop = Mathf.RoundToInt(border.w);
                style.unitySliceRight = Mathf.RoundToInt(border.z);
                style.unitySliceBottom = Mathf.RoundToInt(border.y);
                style.unitySliceLeft = Mathf.RoundToInt(border.x);
                style.unitySliceScale = 100 / value.pixelsPerUnit;

                style.backgroundImage = Background.FromSprite(value);

                sprite = null;

                StyleBackgroundSet = true;
            }
        }
        [SapTarget(typeof(AssetLoaded<VectorImage>))]
        private void OnVectorLoaded(Asset<VectorImage> asset)
        {
            if (asset.address != VectorAddress)
            {
                return;
            }

            SetVector(asset.asset);
        }
        private void SetVector(VectorImage value)
        {
            if (StyleBackgroundSet)
            {
                style.backgroundImage = StyleKeyword.Null;
                StyleBackgroundSet = false;
            }
            
            vectorImage = value;
            if (value == null) return;
            image = null;
            sprite = null;
            style.backgroundImage = StyleKeyword.Null;
            
            if (UseBackground)
            {
                style.backgroundImage = Background.FromVectorImage(value);

                vectorImage = null;

                StyleBackgroundSet = true;
            }
        }
        [SapTarget(typeof(AssetLoaded<RenderTexture>))]
        private void OnRenderTextureLoaded(Asset<RenderTexture> asset)
        {
            if (asset.address != RenderTextureAddress)
            {
                return;
            }

            SetRenderTexture(asset.asset);
        }
        private void SetRenderTexture(RenderTexture value)
        {
            if (StyleBackgroundSet)
            {
                style.backgroundImage = StyleKeyword.Null;
                StyleBackgroundSet = false;
            }
            
            image = value;
            if (value == null) return;
            sprite = null;
            vectorImage = null;
            style.backgroundImage = StyleKeyword.Null;
            
            if (UseBackground)
            {
                style.backgroundImage = Background.FromRenderTexture(value);

                image = null;

                StyleBackgroundSet = true;
            }
        }
        
        [SapTarget(typeof(EventCallback<VisualChangeEvent>))]
        private void OnVisualChange(VisualChangeEvent evt) => SetSize();
        
        private void SetSize()
        {
            var style = this.style;
            
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
                        : style.backgroundImage.keyword is StyleKeyword.Undefined
                            ? style.backgroundImage.value.texture != null
                                ? new Vector2(style.backgroundImage.value.texture.width, style.backgroundImage.value.texture.height)
                                : style.backgroundImage.value.renderTexture != null
                                    ? new Vector2(style.backgroundImage.value.renderTexture.width, style.backgroundImage.value.renderTexture.height)
                                    : style.backgroundImage.value.sprite != null
                                        ? style.backgroundImage.value.sprite.bounds.size
                                        : style.backgroundImage.value.vectorImage != null
                                            ? new Vector2(style.backgroundImage.value.vectorImage.width, style.backgroundImage.value.vectorImage.height)
                                            : Vector2.negativeInfinity
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
            if (aspectRatio || !this.size.HasValue)
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
                if (int.TryParse(customValue[..^2], out var pixels))
                {
                    return Pixel(pixels);
                }
            } else if (customValue.EndsWith("%"))
            {
                if (int.TryParse(customValue[..^1], out var percent))
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
        public Texture2D texture;
        public Sprite sprite;
        public VectorImage vector;
        public RenderTexture renderTexture;

        public bool useBackground;
        
        /// <summary>
        /// Styled Prop as --props-texture
        /// </summary>
        public RishString? textureAddress;
        /// <summary>
        /// Styled Prop as --props-sprite
        /// </summary>
        public RishString? spriteAddress;
        /// <summary>
        /// Styled Prop as --props-vector
        /// </summary>
        public RishString? vectorAddress;
        /// <summary>
        /// Styled Prop as --props-render-texture
        /// </summary>
        public RishString? renderTextureAddress;
        
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
    }
}