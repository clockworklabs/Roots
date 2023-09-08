using System.Text;
using RishUI;
using Unity.Collections;
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
        
        private FixedString128Bytes BackgroundTextureAddress;
        private FixedString128Bytes BackgroundSpriteAddress;
        private FixedString128Bytes BackgroundVectorAddress;
        private FixedString128Bytes BackgroundRenderTextureAddress;
        
        private StringBuilder StringBuilder { get; } = new();
        
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
            if (Loader != null)
            {
                var textureAddress = props.backgroundTextureAddress.Value;
                var textureSet = !string.IsNullOrWhiteSpace(textureAddress.Value);
                if (!textureSet)
                {
                    textureAddress = string.Empty;
                }
                if (textureAddress != BackgroundTextureAddress)
                {
                    BackgroundTextureAddress = textureAddress;
                    Loader.Load<Texture2D>(textureAddress.Value, OnTextureLoaded);
                }

                var spriteAddress = props.backgroundSpriteAddress.Value;
                var spriteSet = !textureSet && !string.IsNullOrWhiteSpace(spriteAddress.Value);
                if (!spriteSet)
                {
                    spriteAddress = string.Empty;
                }
                if (spriteAddress != BackgroundSpriteAddress)
                {
                    BackgroundSpriteAddress = spriteAddress;
                    Loader.Load<Sprite>(spriteAddress.Value, OnSpriteLoaded);
                }

                var vectorAddress = props.backgroundVectorAddress.Value;
                var vectorSet = !spriteSet && !string.IsNullOrWhiteSpace(vectorAddress.Value);
                if (!vectorSet)
                {
                    vectorAddress = string.Empty;
                }
                if (vectorAddress != BackgroundVectorAddress)
                {
                    BackgroundVectorAddress = vectorAddress;
                    Loader.Load<VectorImage>(vectorAddress.Value, OnVectorLoaded);
                }

                var renderTextureAddress = props.backgroundRenderTextureAddress.Value;
                var renderTextureSet = !vectorSet && !string.IsNullOrWhiteSpace(renderTextureAddress.Value);
                if (!renderTextureSet)
                {
                    renderTextureAddress = string.Empty;
                }
                if (renderTextureAddress != BackgroundRenderTextureAddress)
                {
                    BackgroundRenderTextureAddress = renderTextureAddress;
                    Loader.Load<RenderTexture>(renderTextureAddress.Value, OnRenderTextureLoaded);
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
            props.backgroundTextureAddress ??= customStyle.TryGetValue(BackgroundTextureAddressProp, out var customTextureAddress) 
                ? customTextureAddress
                : string.Empty;
            props.backgroundSpriteAddress ??= customStyle.TryGetValue(BackgroundSpriteAddressProp, out var customSpriteAddress) 
                ? customSpriteAddress
                : string.Empty;
            props.backgroundVectorAddress ??= customStyle.TryGetValue(BackgroundVectorAddressProp, out var customVectorAddress) 
                ? customVectorAddress
                : string.Empty;
            props.backgroundRenderTextureAddress ??= customStyle.TryGetValue(BackgroundRenderTextureAddressProp, out var customRenderTextureAddress) 
                ? customRenderTextureAddress
                : string.Empty;
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
            style.backgroundImage = Background.FromRenderTexture(renderTexture);
        }

        private void OnMounted(AttachToPanelEvent evt)
        {
            Loader = AssetsLoader.GetLoader(this);
        }
        
        private void OnUnmounted(DetachFromPanelEvent evt)
        {
            Loader = null;
            
            BackgroundTextureAddress = default;
            BackgroundSpriteAddress = default;
            BackgroundVectorAddress = default;
            BackgroundRenderTextureAddress = default;
        }

        public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);
    }

    public struct DivProps
    {
        /// <summary>
        /// Styled Prop as --prop-background-texture
        /// </summary>
        public FixedString128Bytes? backgroundTextureAddress;
        /// <summary>
        /// Styled Prop as --prop-background-sprite
        /// </summary>
        public FixedString128Bytes? backgroundSpriteAddress;
        /// <summary>
        /// Styled Prop as --prop-background-vector
        /// </summary>
        public FixedString128Bytes? backgroundVectorAddress;
        /// <summary>
        /// Styled Prop as --prop-background-render-texture
        /// </summary>
        public FixedString128Bytes? backgroundRenderTextureAddress;
        
        // public Utilities utilities;
    }
}