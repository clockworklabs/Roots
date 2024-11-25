using System;
using System.Collections.Generic;
using Motion;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots.WIP
{
    public class Motion
    {
        public event Action<Style> OnStyle;
        public event Action Completed;
        
        private MotionColor BackgroundColor { get; }
        private MotionColor BorderBottomColor { get; }
        private MotionLength BorderBottomLeftRadius { get; }
        private MotionLength BorderBottomRightRadius { get; }
        private MotionFloat BorderBottomWidth { get; }
        private MotionColor BorderLeftColor { get; }
        private MotionFloat BorderLeftWidth { get; }
        private MotionColor BorderRightColor { get; }
        private MotionFloat BorderRightWidth { get; }
        private MotionColor BorderTopColor { get; }
        private MotionLength BorderTopLeftRadius { get; }
        private MotionLength BorderTopRightRadius { get; }
        private MotionFloat BorderTopWidth { get; }
        private MotionLength Bottom { get; }
        private MotionColor Color { get; }
        private MotionLength FlexBasis { get; }
        private MotionFloat FlexGrow { get; }
        private MotionFloat FlexShrink { get; }
        private MotionLength FontSize { get; }
        private MotionLength Height { get; }
        private MotionLength Left { get; }
        private MotionLength LetterSpacing { get; }
        private MotionLength MarginBottom { get; }
        private MotionLength MarginLeft { get; }
        private MotionLength MarginRight { get; }
        private MotionLength MarginTop { get; }
        private MotionLength MaxHeight { get; }
        private MotionLength MaxWidth { get; }
        private MotionLength MinHeight { get; }
        private MotionLength MinWidth { get; }
        private MotionFloat Opacity { get; }
        private MotionLength PaddingBottom { get; }
        private MotionLength PaddingLeft { get; }
        private MotionLength PaddingRight { get; }
        private MotionLength PaddingTop { get; }
        private MotionLength Right { get; }
        private MotionRotate Rotate { get; }
        private MotionScale Scale { get; }
        private MotionLength Top { get; }
        private MotionTransformOrigin TransformOrigin { get; } // TODO: Test
        private MotionTranslate Translate { get; } // TODO: Test
        private MotionColor UnityBackgroundImageTintColor { get; }
        private MotionLength UnityParagraphSpacing { get; }
        private MotionInt UnitySliceBottom { get; } // TODO: Test
        private MotionInt UnitySliceLeft { get; } // TODO: Test
        private MotionInt UnitySliceRight { get; } // TODO: Test
        private MotionInt UnitySliceTop { get; } // TODO: Test
        private MotionColor UnityTextOutlineColor { get; }
        private MotionFloat UnityTextOutlineWidth { get; }
        private MotionLength Width { get; }
        private MotionLength WordSpacing { get; }

        private VisualElement Element { get; set; }
        private GroupAnimationId Animation { get; set; }

        private Target LastTarget { get; set; }
        private Motion Parent { get; set; }
        private int StaggerIndex { get; set; }
        
        private List<AnimationId> GroupAnimations { get; } = new(51);

        public Motion()
        {
            BackgroundColor = new MotionColor("backgroundColor");
            BorderBottomColor = new MotionColor("borderBottomColor");
            BorderBottomLeftRadius = new MotionLength("borderBottomLeftRadius", e => Mathf.Max(e.layout.width, e.layout.height));
            BorderBottomRightRadius = new MotionLength("borderBottomRightRadius", e => Mathf.Max(e.layout.width, e.layout.height));
            BorderBottomWidth = new MotionFloat("borderBottomWidth", PropertyType.Physical);
            BorderLeftColor = new MotionColor("borderLeftColor");
            BorderLeftWidth = new MotionFloat("borderLeftWidth", PropertyType.Physical);
            BorderRightColor = new MotionColor("borderRightColor");
            BorderRightWidth = new MotionFloat("borderRightWidth", PropertyType.Physical);
            BorderTopColor = new MotionColor("borderTopColor");
            BorderTopLeftRadius = new MotionLength("borderTopLeftRadius", e => Mathf.Max(e.layout.width, e.layout.height));
            BorderTopRightRadius = new MotionLength("borderTopRightRadius", e => Mathf.Max(e.layout.width, e.layout.height));
            BorderTopWidth = new MotionFloat("borderTopWidth", PropertyType.Physical);
            Bottom = new MotionLength("bottom", e => e?.parent?.layout.height ?? default);
            Color = new MotionColor("color");
            FlexBasis = new MotionLength("flexBasis", e => e?.parent?.resolvedStyle.flexDirection is FlexDirection.Column or FlexDirection.ColumnReverse ? e.parent.layout.height : e.parent.layout.width);
            FlexGrow = new MotionFloat("flexGrow", PropertyType.Physical);
            FlexShrink = new MotionFloat("flexShrink", PropertyType.Physical);
            FontSize = new MotionLength("fontSize", e => e?.parent?.resolvedStyle.fontSize ?? default);
            Height = new MotionLength("height", e => e?.parent?.layout.height ?? default);
            Left = new MotionLength("left", e => e?.parent?.layout.width ?? default);
            LetterSpacing = new MotionLength("letterSpacing", e => e?.parent?.resolvedStyle.letterSpacing ?? default);
            MarginBottom = new MotionLength("marginBottom", e => e?.parent?.layout.height ?? default);
            MarginLeft = new MotionLength("marginLeft", e => e?.parent?.layout.width ?? default);
            MarginRight = new MotionLength("marginRight", e => e?.parent?.layout.width ?? default);
            MarginTop = new MotionLength("marginTop", e => e?.parent?.layout.height ?? default);
            MaxHeight = new MotionLength("maxHeight", e => e?.parent?.layout.height ?? default);
            MaxWidth = new MotionLength("maxWidth", e => e?.parent?.layout.width ?? default);
            MinHeight = new MotionLength("minHeight", e => e?.parent?.layout.height ?? default);
            MinWidth = new MotionLength("minWidth", e => e?.parent?.layout.width ?? default);
            Opacity = new MotionFloat("opacity", PropertyType.NonPhysical);
            PaddingBottom = new MotionLength("paddingBottom", e => e?.parent?.layout.height ?? default);
            PaddingLeft = new MotionLength("paddingLeft", e => e?.parent?.layout.width ?? default);
            PaddingRight = new MotionLength("paddingRight", e => e?.parent?.layout.width ?? default);
            PaddingTop = new MotionLength("paddingTop", e => e?.parent?.layout.height ?? default);
            Right = new MotionLength("right", e => e?.parent?.layout.width ?? default);
            Rotate = new MotionRotate("rotate");
            Scale = new MotionScale("scale");
            Top = new MotionLength("top", e => e?.parent?.layout.height ?? default);
            TransformOrigin = new MotionTransformOrigin("transformOrigin");
            Translate = new MotionTranslate("translate");
            UnityBackgroundImageTintColor = new MotionColor("unityBackgroundImageTintColor");
            UnityParagraphSpacing = new MotionLength("unityParagraphSpacing", e => e?.parent?.resolvedStyle.unityParagraphSpacing ?? default);
            UnitySliceBottom = new MotionInt("unitySliceBottom");
            UnitySliceLeft = new MotionInt("unitySliceLeft");
            UnitySliceRight = new MotionInt("unitySliceRight");
            UnitySliceTop = new MotionInt("unitySliceTop");
            UnityTextOutlineColor = new MotionColor("unityTextOutlineColor");
            UnityTextOutlineWidth = new MotionFloat("unityTextOutlineWidth", PropertyType.Physical);
            Width = new MotionLength("width", e => e?.parent?.layout.width ?? default);
            WordSpacing = new MotionLength("wordSpacing", e => e?.parent?.resolvedStyle.wordSpacing ?? default);
        }

        public void Reset()
        {
            Animation.OnComplete(null);
            Animation.Stop();
            
            BackgroundColor.Reset();
            BorderBottomColor.Reset();
            BorderBottomLeftRadius.Reset();
            BorderBottomRightRadius.Reset();
            BorderBottomWidth.Reset();
            BorderLeftColor.Reset();
            BorderLeftWidth.Reset();
            BorderRightColor.Reset();
            BorderRightWidth.Reset();
            BorderTopColor.Reset();
            BorderTopLeftRadius.Reset();
            BorderTopRightRadius.Reset();
            BorderTopWidth.Reset();
            Bottom.Reset();
            Color.Reset();
            FlexBasis.Reset();
            FlexGrow.Reset();
            FlexShrink.Reset();
            FontSize.Reset();
            Height.Reset();
            Left.Reset();
            LetterSpacing.Reset();
            MarginBottom.Reset();
            MarginLeft.Reset();
            MarginRight.Reset();
            MarginTop.Reset();
            MaxHeight.Reset();
            MaxWidth.Reset();
            MinHeight.Reset();
            MinWidth.Reset();
            Opacity.Reset();
            PaddingBottom.Reset();
            PaddingLeft.Reset();
            PaddingRight.Reset();
            PaddingTop.Reset();
            Right.Reset();
            Rotate.Reset();
            Scale.Reset();
            Top.Reset();
            TransformOrigin.Reset();
            Translate.Reset();
            UnityBackgroundImageTintColor.Reset();
            UnityParagraphSpacing.Reset();
            UnitySliceBottom.Reset();
            UnitySliceLeft.Reset();
            UnitySliceRight.Reset();
            UnitySliceTop.Reset();
            UnityTextOutlineColor.Reset();
            UnityTextOutlineWidth.Reset();
            Width.Reset();
            WordSpacing.Reset();

            Element = null;
            LastTarget = default;
            Parent = null;
            StaggerIndex = 0;
            AnimatingChildrenCount = -1;
            
            #if UNITY_EDITOR
            if (AnimatingChildren.Count > 0)
            {
                Debug.LogWarning("This should never happen");
            }
            AnimatingChildren.Clear();
            #endif
        }

        public void SetInitial(VisualElement element, Motion parent)
        {
            Element = element;
            
            var inlineStyle = element.style;
            var resolvedStyle = element.resolvedStyle;

            BackgroundColor.Init(element, inlineStyle.backgroundColor, resolvedStyle.backgroundColor);
            BorderBottomColor.Init(element, inlineStyle.borderBottomColor, resolvedStyle.borderBottomColor);
            BorderBottomLeftRadius.Init(element, inlineStyle.borderBottomLeftRadius, resolvedStyle.borderBottomLeftRadius);
            BorderBottomRightRadius.Init(element, inlineStyle.borderBottomRightRadius, resolvedStyle.borderBottomRightRadius);
            BorderBottomWidth.Init(element, inlineStyle.borderBottomWidth, resolvedStyle.borderBottomWidth);
            BorderLeftColor.Init(element, inlineStyle.borderLeftColor, resolvedStyle.borderLeftColor);
            BorderLeftWidth.Init(element, inlineStyle.borderLeftWidth, resolvedStyle.borderLeftWidth);
            BorderRightColor.Init(element, inlineStyle.borderRightColor, resolvedStyle.borderRightColor);
            BorderRightWidth.Init(element, inlineStyle.borderRightWidth, resolvedStyle.borderRightWidth);
            BorderTopColor.Init(element, inlineStyle.borderTopColor, resolvedStyle.borderTopColor);
            BorderTopLeftRadius.Init(element, inlineStyle.borderTopLeftRadius, resolvedStyle.borderTopLeftRadius);
            BorderTopRightRadius.Init(element, inlineStyle.borderTopRightRadius, resolvedStyle.borderTopRightRadius);
            BorderTopWidth.Init(element, inlineStyle.borderTopWidth, resolvedStyle.borderTopWidth);
            Bottom.Init(element, inlineStyle.bottom, resolvedStyle.bottom);
            Color.Init(element, inlineStyle.color, resolvedStyle.color);
            FlexBasis.Init(element, inlineStyle.flexBasis, resolvedStyle.flexBasis);
            FlexGrow.Init(element, inlineStyle.flexGrow, resolvedStyle.flexGrow);
            FlexShrink.Init(element, inlineStyle.flexShrink, resolvedStyle.flexShrink);
            FontSize.Init(element, inlineStyle.fontSize, resolvedStyle.fontSize);
            Height.Init(element, inlineStyle.height, resolvedStyle.height);
            Left.Init(element, inlineStyle.left, resolvedStyle.left);
            LetterSpacing.Init(element, inlineStyle.letterSpacing, resolvedStyle.letterSpacing);
            MarginBottom.Init(element, inlineStyle.marginBottom, resolvedStyle.marginBottom);
            MarginLeft.Init(element, inlineStyle.marginLeft, resolvedStyle.marginLeft);
            MarginRight.Init(element, inlineStyle.marginRight, resolvedStyle.marginRight);
            MarginTop.Init(element, inlineStyle.marginTop, resolvedStyle.marginTop);
            MaxHeight.Init(element, inlineStyle.maxHeight, resolvedStyle.maxHeight);
            MaxWidth.Init(element, inlineStyle.maxWidth, resolvedStyle.maxWidth);
            MinHeight.Init(element, inlineStyle.minHeight, resolvedStyle.minHeight);
            MinWidth.Init(element, inlineStyle.minWidth, resolvedStyle.minWidth);
            Opacity.Init(element, inlineStyle.opacity, resolvedStyle.opacity);
            PaddingBottom.Init(element, inlineStyle.paddingBottom, resolvedStyle.paddingBottom);
            PaddingLeft.Init(element, inlineStyle.paddingLeft, resolvedStyle.paddingLeft);
            PaddingRight.Init(element, inlineStyle.paddingRight, resolvedStyle.paddingRight);
            PaddingTop.Init(element, inlineStyle.paddingTop, resolvedStyle.paddingTop);
            Right.Init(element, inlineStyle.right, resolvedStyle.right);
            Rotate.Init(element, inlineStyle.rotate, resolvedStyle.rotate.angle); // TODO: Test
            Scale.Init(element, inlineStyle.scale, resolvedStyle.scale.value); // TODO: Test
            Top.Init(element, inlineStyle.top, resolvedStyle.top);
            TransformOrigin.Init(element, inlineStyle.transformOrigin, new TransformOrigin(resolvedStyle.transformOrigin.x, resolvedStyle.transformOrigin.y, resolvedStyle.transformOrigin.z)); // TODO: Test
            Translate.Init(element, inlineStyle.translate, new Translate(resolvedStyle.translate.x, resolvedStyle.translate.y, resolvedStyle.translate.z)); // TODO: Test
            UnityBackgroundImageTintColor.Init(element, inlineStyle.unityBackgroundImageTintColor, resolvedStyle.unityBackgroundImageTintColor);
            UnityParagraphSpacing.Init(element, inlineStyle.unityParagraphSpacing, resolvedStyle.unityParagraphSpacing);
            UnitySliceBottom.Init(element, inlineStyle.unitySliceBottom, resolvedStyle.unitySliceBottom);
            UnitySliceLeft.Init(element, inlineStyle.unitySliceLeft, resolvedStyle.unitySliceLeft);
            UnitySliceRight.Init(element, inlineStyle.unitySliceRight, resolvedStyle.unitySliceRight);
            UnitySliceTop.Init(element, inlineStyle.unitySliceTop, resolvedStyle.unitySliceTop);
            UnityTextOutlineColor.Init(element, inlineStyle.unityTextOutlineColor, resolvedStyle.unityTextOutlineColor);
            UnityTextOutlineWidth.Init(element, inlineStyle.unityTextOutlineWidth, resolvedStyle.unityTextOutlineWidth);
            Width.Init(element, inlineStyle.width, resolvedStyle.width);
            WordSpacing.Init(element, inlineStyle.wordSpacing, resolvedStyle.wordSpacing);

            Parent = parent;
        }

        public void To(Target target)
        {
            if (RishUtils.SmartCompare(LastTarget, target)) return;
            
            LastTarget = target;
            
            if (!target.IsValid())
            {
                return;
            }
            
            Animation.OnComplete(null);

            GroupAnimations.Clear();

            var transition = target.transition;

            StaggerIndex = Parent?.RegisterChildAnimation(this) ?? 0;
            
            if(BackgroundColor.Animate(target.backgroundColor, transition.backgroundColor, transition.defaultTransition, out var backgroundColorAnimation)) {
                GroupAnimations.Add(backgroundColorAnimation);
            }
            if(BorderBottomColor.Animate(target.borderBottomColor, transition.borderBottomColor, transition.defaultTransition, out var borderBottomColorAnimation)) {
                GroupAnimations.Add(borderBottomColorAnimation);
            }
            if(BorderBottomLeftRadius.Animate(target.borderBottomLeftRadius, transition.borderBottomLeftRadius, transition.defaultTransition, out var borderBottomLeftRadiusAnimation)) {
                GroupAnimations.Add(borderBottomLeftRadiusAnimation);
            }
            if(BorderBottomRightRadius.Animate(target.borderBottomRightRadius, transition.borderBottomRightRadius, transition.defaultTransition, out var borderBottomRightRadiusAnimation)) {
                GroupAnimations.Add(borderBottomRightRadiusAnimation);
            }
            if(BorderBottomWidth.Animate(target.borderBottomWidth, transition.borderBottomWidth, transition.defaultTransition, out var borderBottomWidthAnimation)) {
                GroupAnimations.Add(borderBottomWidthAnimation);
            }
            if(BorderLeftColor.Animate(target.borderLeftColor, transition.borderLeftColor, transition.defaultTransition, out var borderLeftColorAnimation)) {
                GroupAnimations.Add(borderLeftColorAnimation);
            }
            if(BorderLeftWidth.Animate(target.borderLeftWidth, transition.borderLeftWidth, transition.defaultTransition, out var borderLeftWidthAnimation)) {
                GroupAnimations.Add(borderLeftWidthAnimation);
            }
            if(BorderRightColor.Animate(target.borderRightColor, transition.borderRightColor, transition.defaultTransition, out var borderRightColorAnimation)) {
                GroupAnimations.Add(borderRightColorAnimation);
            }
            if(BorderRightWidth.Animate(target.borderRightWidth, transition.borderRightWidth, transition.defaultTransition, out var borderRightWidthAnimation)) {
                GroupAnimations.Add(borderRightWidthAnimation);
            }
            if(BorderTopColor.Animate(target.borderTopColor, transition.borderTopColor, transition.defaultTransition, out var borderTopColorAnimation)) {
                GroupAnimations.Add(borderTopColorAnimation);
            }
            if(BorderTopLeftRadius.Animate(target.borderTopLeftRadius, transition.borderTopLeftRadius, transition.defaultTransition, out var borderTopLeftRadiusAnimation)) {
                GroupAnimations.Add(borderTopLeftRadiusAnimation);
            }
            if(BorderTopRightRadius.Animate(target.borderTopRightRadius, transition.borderTopRightRadius, transition.defaultTransition, out var borderTopRightRadiusAnimation)) {
                GroupAnimations.Add(borderTopRightRadiusAnimation);
            }
            if(BorderTopWidth.Animate(target.borderTopWidth, transition.borderTopWidth, transition.defaultTransition, out var borderTopWidthAnimation)) {
                GroupAnimations.Add(borderTopWidthAnimation);
            }
            if(Bottom.Animate(target.bottom, transition.bottom, transition.defaultTransition, out var bottomAnimation)) {
                GroupAnimations.Add(bottomAnimation);
            }
            if(Color.Animate(target.color, transition.color, transition.defaultTransition, out var colorAnimation)) {
                GroupAnimations.Add(colorAnimation);
            }
            if(FlexBasis.Animate(target.flexBasis, transition.flexBasis, transition.defaultTransition, out var flexBasisAnimation)) {
                GroupAnimations.Add(flexBasisAnimation);
            }
            if(FlexGrow.Animate(target.flexGrow, transition.flexGrow, transition.defaultTransition, out var flexGrowAnimation)) {
                GroupAnimations.Add(flexGrowAnimation);
            }
            if(FlexShrink.Animate(target.flexShrink, transition.flexShrink, transition.defaultTransition, out var flexShrinkAnimation)) {
                GroupAnimations.Add(flexShrinkAnimation);
            }
            if(FontSize.Animate(target.fontSize, transition.fontSize, transition.defaultTransition, out var fontSizeAnimation)) {
                GroupAnimations.Add(fontSizeAnimation);
            }
            if(Height.Animate(target.height, transition.height, transition.defaultTransition, out var heightAnimation)) {
                GroupAnimations.Add(heightAnimation);
            }
            if(Left.Animate(target.left, transition.left, transition.defaultTransition, out var leftAnimation)) {
                GroupAnimations.Add(leftAnimation);
            }
            if(LetterSpacing.Animate(target.letterSpacing, transition.letterSpacing, transition.defaultTransition, out var letterSpacingAnimation)) {
                GroupAnimations.Add(letterSpacingAnimation);
            }
            if(MarginBottom.Animate(target.marginBottom, transition.marginBottom, transition.defaultTransition, out var marginBottomAnimation)) {
                GroupAnimations.Add(marginBottomAnimation);
            }
            if(MarginLeft.Animate(target.marginLeft, transition.marginLeft, transition.defaultTransition, out var marginLeftAnimation)) {
                GroupAnimations.Add(marginLeftAnimation);
            }
            if(MarginRight.Animate(target.marginRight, transition.marginRight, transition.defaultTransition, out var marginRightAnimation)) {
                GroupAnimations.Add(marginRightAnimation);
            }
            if(MarginTop.Animate(target.marginTop, transition.marginTop, transition.defaultTransition, out var marginTopAnimation)) {
                GroupAnimations.Add(marginTopAnimation);
            }
            if(MaxHeight.Animate(target.maxHeight, transition.maxHeight, transition.defaultTransition, out var maxHeightAnimation)) {
                GroupAnimations.Add(maxHeightAnimation);
            }
            if(MaxWidth.Animate(target.maxWidth, transition.maxWidth, transition.defaultTransition, out var maxWidthAnimation)) {
                GroupAnimations.Add(maxWidthAnimation);
            }
            if(MinHeight.Animate(target.minHeight, transition.minHeight, transition.defaultTransition, out var minHeightAnimation)) {
                GroupAnimations.Add(minHeightAnimation);
            }
            if(MinWidth.Animate(target.minWidth, transition.minWidth, transition.defaultTransition, out var minWidthAnimation)) {
                GroupAnimations.Add(minWidthAnimation);
            }
            if(Opacity.Animate(target.opacity, transition.opacity, transition.defaultTransition, out var opacityAnimation)) {
                GroupAnimations.Add(opacityAnimation);
            }
            if(PaddingBottom.Animate(target.paddingBottom, transition.paddingBottom, transition.defaultTransition, out var paddingBottomAnimation)) {
                GroupAnimations.Add(paddingBottomAnimation);
            }
            if(PaddingLeft.Animate(target.paddingLeft, transition.paddingLeft, transition.defaultTransition, out var paddingLeftAnimation)) {
                GroupAnimations.Add(paddingLeftAnimation);
            }
            if(PaddingRight.Animate(target.paddingRight, transition.paddingRight, transition.defaultTransition, out var paddingRightAnimation)) {
                GroupAnimations.Add(paddingRightAnimation);
            }
            if(PaddingTop.Animate(target.paddingTop, transition.paddingTop, transition.defaultTransition, out var paddingTopAnimation)) {
                GroupAnimations.Add(paddingTopAnimation);
            }
            if(Right.Animate(target.right, transition.right, transition.defaultTransition, out var rightAnimation)) {
                GroupAnimations.Add(rightAnimation);
            }
            if(Rotate.Animate(target.rotate, transition.rotate, transition.defaultTransition, out var rotateAnimation)) {
                GroupAnimations.Add(rotateAnimation);
            }
            if(Scale.Animate(target.scale, transition.scale, transition.defaultTransition, out var scaleAnimation)) {
                GroupAnimations.Add(scaleAnimation);
            }
            if(Top.Animate(target.top, transition.top, transition.defaultTransition, out var topAnimation)) {
                GroupAnimations.Add(topAnimation);
            }
            if(TransformOrigin.Animate(target.transformOrigin, transition.transformOrigin, transition.defaultTransition, out var transformOriginAnimation)) {
                GroupAnimations.Add(transformOriginAnimation);
            }
            if(Translate.Animate(target.translate, transition.translate, transition.defaultTransition, out var translateAnimation)) {
                GroupAnimations.Add(translateAnimation);
            }
            if(UnityBackgroundImageTintColor.Animate(target.unityBackgroundImageTintColor, transition.unityBackgroundImageTintColor, transition.defaultTransition, out var unityBackgroundImageTintColorAnimation)) {
                GroupAnimations.Add(unityBackgroundImageTintColorAnimation);
            }
            if(UnityParagraphSpacing.Animate(target.unityParagraphSpacing, transition.unityParagraphSpacing, transition.defaultTransition, out var unityParagraphSpacingAnimation)) {
                GroupAnimations.Add(unityParagraphSpacingAnimation);
            }
            if(UnitySliceBottom.Animate(target.unitySliceBottom, transition.unitySliceBottom, transition.defaultTransition, out var unitySliceBottomAnimation)) {
                GroupAnimations.Add(unitySliceBottomAnimation);
            }
            if(UnitySliceLeft.Animate(target.unitySliceLeft, transition.unitySliceLeft, transition.defaultTransition, out var unitySliceLeftAnimation)) {
                GroupAnimations.Add(unitySliceLeftAnimation);
            }
            if(UnitySliceRight.Animate(target.unitySliceRight, transition.unitySliceRight, transition.defaultTransition, out var unitySliceRightAnimation)) {
                GroupAnimations.Add(unitySliceRightAnimation);
            }
            if(UnitySliceTop.Animate(target.unitySliceTop, transition.unitySliceTop, transition.defaultTransition, out var unitySliceTopAnimation)) {
                GroupAnimations.Add(unitySliceTopAnimation);
            }
            if(UnityTextOutlineColor.Animate(target.unityTextOutlineColor, transition.unityTextOutlineColor, transition.defaultTransition, out var unityTextOutlineColorAnimation)) {
                GroupAnimations.Add(unityTextOutlineColorAnimation);
            }
            if(UnityTextOutlineWidth.Animate(target.unityTextOutlineWidth, transition.unityTextOutlineWidth, transition.defaultTransition, out var unityTextOutlineWidthAnimation)) {
                GroupAnimations.Add(unityTextOutlineWidthAnimation);
            }
            if(Width.Animate(target.width, transition.width, transition.defaultTransition, out var widthAnimation)) {
                GroupAnimations.Add(widthAnimation);
            }
            if(WordSpacing.Animate(target.wordSpacing, transition.wordSpacing, transition.defaultTransition, out var wordSpacingAnimation)) {
                GroupAnimations.Add(wordSpacingAnimation);
            }

            Animation.Stop();

            // TODO: If parent animates before children, delay animation start
            // TODO: If parent animates after children, start animation
            Animation = DoMotion.Group(GroupAnimations).OnStep(OnStep).OnComplete(OnComplete);

            // if (Parent != null)
            // {
                // Debug.Log("Animate child");
                // if (Parent.Animation.IsPlaying(out var playing))
                // {
                //     Debug.Log(playing);
                // }
                // else
                // {
                //     Debug.Log("Not found");
                // }
            // }
            // else
            // {
                // Debug.Log("Animate parent");
            // }
            // switch (transition.when)
            // {
            //     case Transition.When.Default:
            //         // TODO: Play right away (unless parent has to play first)
            //         break;
            //     case Transition.When.BeforeChildren:
            //         // TODO: Play right away (unless parent has to play first) and delay children
            //         break;
            //     case Transition.When.AfterChildren:
            //         // TODO: Play children and delay this
            //         break;
            // }

            if (Parent != null)
            {
                Animation.OnAboutToStart(SetDelay);
            }
        }

        private void OnStep()
        {
            var style = new Style();
            if(BackgroundColor.Value.HasValue) {
                style.backgroundColor = BackgroundColor.Value.Value;
            }
            if(BorderBottomColor.Value.HasValue) {
                style.borderBottomColor = BorderBottomColor.Value.Value;
            }
            if(BorderBottomLeftRadius.Value.HasValue) {
                style.borderBottomLeftRadius = BorderBottomLeftRadius.Value.Value;
            }
            if(BorderBottomRightRadius.Value.HasValue) {
                style.borderBottomRightRadius = BorderBottomRightRadius.Value.Value;
            }
            if(BorderBottomWidth.Value.HasValue) {
                style.borderBottomWidth = BorderBottomWidth.Value.Value;
            }
            if(BorderLeftColor.Value.HasValue) {
                style.borderLeftColor = BorderLeftColor.Value.Value;
            }
            if(BorderLeftWidth.Value.HasValue) {
                style.borderLeftWidth = BorderLeftWidth.Value.Value;
            }
            if(BorderRightColor.Value.HasValue) {
                style.borderRightColor = BorderRightColor.Value.Value;
            }
            if(BorderRightWidth.Value.HasValue) {
                style.borderRightWidth = BorderRightWidth.Value.Value;
            }
            if(BorderTopColor.Value.HasValue) {
                style.borderTopColor = BorderTopColor.Value.Value;
            }
            if(BorderTopLeftRadius.Value.HasValue) {
                style.borderTopLeftRadius = BorderTopLeftRadius.Value.Value;
            }
            if(BorderTopRightRadius.Value.HasValue) {
                style.borderTopRightRadius = BorderTopRightRadius.Value.Value;
            }
            if(BorderTopWidth.Value.HasValue) {
                style.borderTopWidth = BorderTopWidth.Value.Value;
            }
            if(Bottom.Value.HasValue) {
                style.bottom = Bottom.Value.Value;
            }
            if(Color.Value.HasValue) {
                style.color = Color.Value.Value;
            }
            if(FlexBasis.Value.HasValue) {
                style.flexBasis = FlexBasis.Value.Value;
            }
            if(FlexGrow.Value.HasValue) {
                style.flexGrow = FlexGrow.Value.Value;
            }
            if(FlexShrink.Value.HasValue) {
                style.flexShrink = FlexShrink.Value.Value;
            }
            if(FontSize.Value.HasValue) {
                style.fontSize = FontSize.Value.Value;
            }
            if(Height.Value.HasValue) {
                style.height = Height.Value.Value;
            }
            if(Left.Value.HasValue) {
                style.left = Left.Value.Value;
            }
            if(LetterSpacing.Value.HasValue) {
                style.letterSpacing = LetterSpacing.Value.Value;
            }
            if(MarginBottom.Value.HasValue) {
                style.marginBottom = MarginBottom.Value.Value;
            }
            if(MarginLeft.Value.HasValue) {
                style.marginLeft = MarginLeft.Value.Value;
            }
            if(MarginRight.Value.HasValue) {
                style.marginRight = MarginRight.Value.Value;
            }
            if(MarginTop.Value.HasValue) {
                style.marginTop = MarginTop.Value.Value;
            }
            if(MaxHeight.Value.HasValue) {
                style.maxHeight = MaxHeight.Value.Value;
            }
            if(MaxWidth.Value.HasValue) {
                style.maxWidth = MaxWidth.Value.Value;
            }
            if(MinHeight.Value.HasValue) {
                style.minHeight = MinHeight.Value.Value;
            }
            if(MinWidth.Value.HasValue) {
                style.minWidth = MinWidth.Value.Value;
            }
            if(Opacity.Value.HasValue) {
                style.opacity = Opacity.Value.Value;
            }
            if(PaddingBottom.Value.HasValue) {
                style.paddingBottom = PaddingBottom.Value.Value;
            }
            if(PaddingLeft.Value.HasValue) {
                style.paddingLeft = PaddingLeft.Value.Value;
            }
            if(PaddingRight.Value.HasValue) {
                style.paddingRight = PaddingRight.Value.Value;
            }
            if(PaddingTop.Value.HasValue) {
                style.paddingTop = PaddingTop.Value.Value;
            }
            if(Right.Value.HasValue) {
                style.right = Right.Value.Value;
            }
            if(Rotate.Value.HasValue) {
                style.rotate = Rotate.Value.Value;
            }
            if(Scale.Value.HasValue) {
                style.scale = Scale.Value.Value;
            }
            if(Top.Value.HasValue) {
                style.top = Top.Value.Value;
            }
            if(TransformOrigin.Value.HasValue) {
                style.transformOrigin = TransformOrigin.Value.Value;
            }
            if(Translate.Value.HasValue) {
                style.translate = Translate.Value.Value;
            }
            if(UnityBackgroundImageTintColor.Value.HasValue) {
                style.unityBackgroundImageTintColor = UnityBackgroundImageTintColor.Value.Value;
            }
            if(UnityParagraphSpacing.Value.HasValue) {
                style.unityParagraphSpacing = UnityParagraphSpacing.Value.Value;
            }
            if(UnitySliceBottom.Value.HasValue) {
                style.unitySliceBottom = UnitySliceBottom.Value.Value;
            }
            if(UnitySliceLeft.Value.HasValue) {
                style.unitySliceLeft = UnitySliceLeft.Value.Value;
            }
            if(UnitySliceRight.Value.HasValue) {
                style.unitySliceRight = UnitySliceRight.Value.Value;
            }
            if(UnitySliceTop.Value.HasValue) {
                style.unitySliceTop = UnitySliceTop.Value.Value;
            }
            if(UnityTextOutlineColor.Value.HasValue) {
                style.unityTextOutlineColor = UnityTextOutlineColor.Value.Value;
            }
            if(UnityTextOutlineWidth.Value.HasValue) {
                style.unityTextOutlineWidth = UnityTextOutlineWidth.Value.Value;
            }
            if(Width.Value.HasValue) {
                style.width = Width.Value.Value;
            }
            if(WordSpacing.Value.HasValue) {
                style.wordSpacing = WordSpacing.Value.Value;
            }
            
            OnStyle?.Invoke(style);
        }

        private void OnComplete()
        {
            Animation.OnStep(null);
            Animation.OnComplete(null);
            Completed?.Invoke();
        }

        private HashSet<Motion> AnimatingChildren { get; } = new();
        private int AnimatingChildrenCount { get; set; } = -1;
        private int RegisterChildAnimation(Motion child)
        {
            if (child == null)
            {
                throw new ArgumentException("Child can't be null");
            }
            
            if (AnimatingChildren.Contains(child))
            {
                // TODO: This would be a very weird case
                #if UNITY_EDITOR
                Debug.LogWarning("Something very weird just happened");
                #endif
                return 0;
            }

            AnimatingChildren.Add(child);
            var count = AnimatingChildren.Count;
            AnimatingChildrenCount = count;
            return count;
        }
        private float GetChildDelay(Motion child)
        {
            if (child == null)
            {
                throw new ArgumentException("Child can't be null");
            }

            if (!AnimatingChildren.Contains(child))
            {
                // throw new ArgumentException("Child must register animation first");
                #if UNITY_EDITOR
                Debug.LogWarning("Child must register animation first");
                #endif
                return 0;
            }

            AnimatingChildren.Remove(child);
            var transition = LastTarget.transition;
            
            var index = transition.staggerDirection == Transition.StaggerDirection.Normal ? child.StaggerIndex : AnimatingChildrenCount - child.StaggerIndex;
            
            var delay = transition.delayChildren;

            if (!Mathf.Approximately(transition.staggerChildren, 0))
            {
                delay += index * transition.staggerChildren;
            }

            return delay;
        }

        private void SetDelay() => Animation.SetDelay(Parent?.GetChildDelay(this) ?? 0);
    }
}