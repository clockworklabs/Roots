using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class Div : VisualElement, IVisualElement<DivProps>, IStyledProps<Div, DivProps>
    {
        VisualElement IElement.GetDOMChild() => this;
        
        private PickingManager PickingManager { get; }
        PickingManager ICustomPicking.Manager => PickingManager;
        
        private StyledPropsManager<Div, DivProps> PropsManager { get; }
        StyledPropsManager<Div, DivProps> IStyledProps<Div, DivProps>.Manager => PropsManager;

        private static readonly CustomStyleProperty<string> BackgroundTextureAddressProp = new("--props-background-texture"); 
        private static readonly CustomStyleProperty<string> BackgroundSpriteAddressProp = new("--props-background-sprite"); 
        private static readonly CustomStyleProperty<string> BackgroundVectorAddressProp = new("--props-background-vector"); 
        private static readonly CustomStyleProperty<string> BackgroundRenderTextureAddressProp = new("--props-background-render-texture"); 

        private AssetsLoader Loader { get; set; }
        
        private string BackgroundTextureAddress;
        private Texture2D CachedTexture { get; set; }
        private string BackgroundSpriteAddress;
        private Sprite CachedSprite { get; set; }
        private string BackgroundVectorAddress;
        private VectorImage CachedVector { get; set; }
        private string BackgroundRenderTextureAddress;
        private RenderTexture CachedRenderTexture { get; set; }
        
        public Div()
        {
            PickingManager = new RectPickingManager(this);
            PropsManager = new StyledPropsManager<Div, DivProps>(this);
            
            RegisterCallback<AttachToPanelEvent>(OnMounted);
            RegisterCallback<DetachFromPanelEvent>(OnUnmounted);
        }

        void IVisualElement<DivProps>.Setup(DivProps props) => PropsManager.Setup(props);
        void IStyledProps<Div, DivProps>.Setup(DivProps props, bool dirty)
        {
            ClearBackground();
            
            if (Loader != null)
            {
                var textureAddress = props.backgroundTextureAddress;
                var textureSet = !string.IsNullOrWhiteSpace(textureAddress);
                if (!textureSet)
                {
                    BackgroundTextureAddress = default;
                    CachedTexture = null;
                }
                else
                {
                    SetTexture(CachedTexture);
                    if (textureAddress != BackgroundTextureAddress)
                    {
                        BackgroundTextureAddress = textureAddress;
                        Loader.Load<Texture2D>(textureAddress, OnTextureLoaded);
                    }
                }

                var spriteAddress = props.backgroundSpriteAddress;
                var spriteSet = !textureSet && !string.IsNullOrWhiteSpace(spriteAddress);
                if (!spriteSet)
                {
                    BackgroundSpriteAddress = default;
                    CachedSprite = null;
                }
                else
                {
                    SetSprite(CachedSprite);
                    if (spriteAddress != BackgroundSpriteAddress)
                    {
                        BackgroundSpriteAddress = spriteAddress;
                        Loader.Load<Sprite>(spriteAddress, OnSpriteLoaded);
                    }
                }

                var vectorAddress = props.backgroundVectorAddress;
                var vectorSet = !spriteSet && !string.IsNullOrWhiteSpace(vectorAddress);
                if (!vectorSet)
                {
                    BackgroundVectorAddress = default;
                    CachedVector = null;
                }
                else
                {
                    SetVector(CachedVector);
                    if (vectorAddress != BackgroundVectorAddress)
                    {
                        BackgroundVectorAddress = vectorAddress;
                        Loader.Load<VectorImage>(vectorAddress, OnVectorLoaded);
                    }
                }

                var renderTextureAddress = props.backgroundRenderTextureAddress;
                var renderTextureSet = !vectorSet && !string.IsNullOrWhiteSpace(renderTextureAddress);
                if (!renderTextureSet)
                {
                    BackgroundRenderTextureAddress = default;
                    CachedRenderTexture = null;
                }
                else
                {
                    SetRenderTexture(CachedRenderTexture);
                    if (renderTextureAddress != BackgroundRenderTextureAddress)
                    {
                        BackgroundRenderTextureAddress = renderTextureAddress;
                        Loader.Load<RenderTexture>(renderTextureAddress, OnRenderTextureLoaded);
                    }
                }
            }
            else
            {
                Debug.LogError("App needs an Asset Loader");
            }
            
            // this.AddClassNames(props.utilities, StringBuilder);
        }

        void IStyledProps<Div, DivProps>.OnCustomStyle(ref DivProps props)
        {
            PropsManager.SetValue(BackgroundTextureAddressProp, ref props.backgroundTextureAddress);
            PropsManager.SetValue(BackgroundSpriteAddressProp, ref props.backgroundSpriteAddress);
            PropsManager.SetValue(BackgroundVectorAddressProp, ref props.backgroundVectorAddress);
            PropsManager.SetValue(BackgroundRenderTextureAddressProp, ref props.backgroundRenderTextureAddress);
        }

        private void OnTextureLoaded(Asset<Texture2D> asset)
        {
            if (asset.address != BackgroundTextureAddress)
            {
                return;
            }

            SetTexture(asset.asset);
        }
        private void SetTexture(Texture2D texture)
        {
            CachedTexture = texture;
            CachedSprite = null;
            CachedVector = null;
            CachedRenderTexture = null;
            style.backgroundImage = Background.FromTexture2D(texture);
        }
        private void OnSpriteLoaded(Asset<Sprite> asset)
        {
            if (asset.address != BackgroundSpriteAddress)
            {
                return;
            }

            SetSprite(asset.asset);
        }
        private void SetSprite(Sprite sprite)
        {
            CachedTexture = null;
            CachedSprite = sprite;
            CachedVector = null;
            CachedRenderTexture = null;
            style.backgroundImage = Background.FromSprite(sprite);
        }
        private void OnVectorLoaded(Asset<VectorImage> asset)
        {
            if (asset.address != BackgroundVectorAddress)
            {
                return;
            }

            SetVector(asset.asset);
        }
        private void SetVector(VectorImage vectorImage)
        {
            CachedTexture = null;
            CachedSprite = null;
            CachedVector = vectorImage;
            CachedRenderTexture = null;
            style.backgroundImage = Background.FromVectorImage(vectorImage);
        }
        private void OnRenderTextureLoaded(Asset<RenderTexture> asset)
        {
            if (asset.address != BackgroundRenderTextureAddress)
            {
                return;
            }

            SetRenderTexture(asset.asset);
        }
        private void SetRenderTexture(RenderTexture renderTexture)
        {
            CachedTexture = null;
            CachedSprite = null;
            CachedVector = null;
            CachedRenderTexture = renderTexture;
            style.backgroundImage = Background.FromRenderTexture(renderTexture);
        }

        private void ClearBackground()
        {
            style.backgroundImage = default;
        }

        private void OnMounted(AttachToPanelEvent evt)
        {
            Loader = AssetsLoader.GetLoader(this);
        }
        
        private void OnUnmounted(DetachFromPanelEvent evt)
        {
            Loader = null;
            
            BackgroundTextureAddress = default;
            CachedTexture = null;
            BackgroundSpriteAddress = default;
            CachedSprite = null;
            BackgroundVectorAddress = default;
            CachedVector = null;
            BackgroundRenderTextureAddress = default;
            CachedRenderTexture = null;
        }

        public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);
    }

    public struct DivProps
    {
        /// <summary>
        /// Styled Prop as --props-background-texture
        /// </summary>
        public RishString? backgroundTextureAddress;
        /// <summary>
        /// Styled Prop as --props-background-sprite
        /// </summary>
        public RishString? backgroundSpriteAddress;
        /// <summary>
        /// Styled Prop as --props-background-vector
        /// </summary>
        public RishString? backgroundVectorAddress;
        /// <summary>
        /// Styled Prop as --props-background-render-texture
        /// </summary>
        public RishString? backgroundRenderTextureAddress;
        
        // public Utilities utilities;
    }
}