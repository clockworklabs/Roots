using System;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class MotionDiv : RishElement<MotionDivProps, MotionDivState>, IAnimatedElement, IMountingListener, ICustomUnmountListener, IPropsListener<MotionDivProps>
    {
        private StyleAnimation Animation { get; }
        private IAnimatedElement Parent { get; set; }

        public MotionDiv()
        {
            Animation = new StyleAnimation(this);
        }

        void IMountingListener.ComponentDidMount()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
            Parent = GetFirstAncestorOfType<IAnimatedElement>();
            
            Animation.Mounted();
        }

        void IMountingListener.ComponentWillUnmount() {
            UnregisterCallback<VisualChangeEvent>(OnVisualChange);
        }

        void ICustomUnmountListener.UnmountRequested() => Animation.UnmountRequested();
        void ICustomUnmountListener.Unmounted() => Animation.Unmounted();

        void IPropsListener<MotionDivProps>.PropsDidChange(MotionDivProps? prev)
        {
            bool animateDirty;
            bool exitDirty;
            if (prev.HasValue)
            {
                var prevValue = prev.Value;

                animateDirty = !RishUtils.SmartCompare(prevValue.animate, Props.animate);
                exitDirty = !RishUtils.SmartCompare(prevValue.exit, Props.exit);
            }
            else
            {
                SetDescriptor(GetInitialDescriptor(Props.descriptor, Props.initial, Props.animate));

                animateDirty = true;
                exitDirty = true;
            }

            if (animateDirty)
            {
                Animation.SetAnimate(Props.animate);
            }
            if (exitDirty)
            {
                Animation.SetExit(Props.exit);
            }
        }
        void IPropsListener<MotionDivProps>.PropsWillChange() { }
        
        protected override Element Render() => Div.Create(descriptor: State.descriptor, children: Props.children);

        private void OnVisualChange(VisualChangeEvent evt) => Animation.OnVisualChange(evt.target as VisualElement);
        
        IAnimatedElement IAnimatedElement.Parent => Parent;
        StyleAnimation IAnimatedElement.StyleAnimation => Animation;
        void IAnimatedElement.Unmount() => CanUnmount();
        void IAnimatedElement.SetStyle(Style style) => SetDescriptor(new DOMDescriptor
        {
            name = State.descriptor.name,
            className = State.descriptor.className,
            style = style
        });
        void IAnimatedElement.OnAnimateComplete() => Props.onAnimateComplete?.Invoke();
        void IAnimatedElement.OnExitComplete() => Props.onExitComplete?.Invoke();
        
        private static DOMDescriptor GetInitialDescriptor(DOMDescriptor descriptor, Initial initial, Target animate)
        {
            var style = descriptor.style;

            if (initial.backgroundColor is IInitialValue<Color> backgroundColor)
            {
                if (backgroundColor.skip && animate.backgroundColor.HasValue)
                {
                    style.backgroundColor = animate.backgroundColor.Value;
                }
                else if (backgroundColor.value.HasValue)
                {
                    style.backgroundColor = backgroundColor.value.Value;
                }
            }
            if (initial.borderBottomColor is IInitialValue<Color> borderBottomColor)
            {
                if (borderBottomColor.skip && animate.borderBottomColor.HasValue)
                {
                    style.borderBottomColor = animate.borderBottomColor.Value;
                }
                else if (borderBottomColor.value.HasValue)
                {
                    style.borderBottomColor = borderBottomColor.value.Value;
                }
            }
            if (initial.borderBottomLeftRadius is IInitialValue<Length> borderBottomLeftRadius)
            {
                if (borderBottomLeftRadius.skip && animate.borderBottomLeftRadius.HasValue)
                {
                    style.borderBottomLeftRadius = animate.borderBottomLeftRadius.Value;
                }
                else if (borderBottomLeftRadius.value.HasValue)
                {
                    style.borderBottomLeftRadius = borderBottomLeftRadius.value.Value;
                }
            }
            if (initial.borderBottomRightRadius is IInitialValue<Length> borderBottomRightRadius)
            {
                if (borderBottomRightRadius.skip && animate.borderBottomRightRadius.HasValue)
                {
                    style.borderBottomRightRadius = animate.borderBottomRightRadius.Value;
                }
                else if (borderBottomRightRadius.value.HasValue)
                {
                    style.borderBottomRightRadius = borderBottomRightRadius.value.Value;
                }
            }
            if (initial.borderBottomWidth is IInitialValue<float> borderBottomWidth)
            {
                if (borderBottomWidth.skip && animate.borderBottomWidth.HasValue)
                {
                    style.borderBottomWidth = animate.borderBottomWidth.Value;
                }
                else if (borderBottomWidth.value.HasValue)
                {
                    style.borderBottomWidth = borderBottomWidth.value.Value;
                }
            }
            if (initial.borderLeftColor is IInitialValue<Color> borderLeftColor)
            {
                if (borderLeftColor.skip && animate.borderLeftColor.HasValue)
                {
                    style.borderLeftColor = animate.borderLeftColor.Value;
                }
                else if (borderLeftColor.value.HasValue)
                {
                    style.borderLeftColor = borderLeftColor.value.Value;
                }
            }
            if (initial.borderLeftWidth is IInitialValue<float> borderLeftWidth)
            {
                if (borderLeftWidth.skip && animate.borderLeftWidth.HasValue)
                {
                    style.borderLeftWidth = animate.borderLeftWidth.Value;
                }
                else if (borderLeftWidth.value.HasValue)
                {
                    style.borderLeftWidth = borderLeftWidth.value.Value;
                }
            }
            if (initial.borderRightColor is IInitialValue<Color> borderRightColor)
            {
                if (borderRightColor.skip && animate.borderRightColor.HasValue)
                {
                    style.borderRightColor = animate.borderRightColor.Value;
                }
                else if (borderRightColor.value.HasValue)
                {
                    style.borderRightColor = borderRightColor.value.Value;
                }
            }
            if (initial.borderRightWidth is IInitialValue<float> borderRightWidth)
            {
                if (borderRightWidth.skip && animate.borderRightWidth.HasValue)
                {
                    style.borderRightWidth = animate.borderRightWidth.Value;
                }
                else if (borderRightWidth.value.HasValue)
                {
                    style.borderRightWidth = borderRightWidth.value.Value;
                }
            }
            if (initial.borderTopColor is IInitialValue<Color> borderTopColor)
            {
                if (borderTopColor.skip && animate.borderTopColor.HasValue)
                {
                    style.borderTopColor = animate.borderTopColor.Value;
                }
                else if (borderTopColor.value.HasValue)
                {
                    style.borderTopColor = borderTopColor.value.Value;
                }
            }
            if (initial.borderTopLeftRadius is IInitialValue<Length> borderTopLeftRadius)
            {
                if (borderTopLeftRadius.skip && animate.borderTopLeftRadius.HasValue)
                {
                    style.borderTopLeftRadius = animate.borderTopLeftRadius.Value;
                }
                else if (borderTopLeftRadius.value.HasValue)
                {
                    style.borderTopLeftRadius = borderTopLeftRadius.value.Value;
                }
            }
            if (initial.borderTopRightRadius is IInitialValue<Length> borderTopRightRadius)
            {
                if (borderTopRightRadius.skip && animate.borderTopRightRadius.HasValue)
                {
                    style.borderTopRightRadius = animate.borderTopRightRadius.Value;
                }
                else if (borderTopRightRadius.value.HasValue)
                {
                    style.borderTopRightRadius = borderTopRightRadius.value.Value;
                }
            }
            if (initial.borderTopWidth is IInitialValue<float> borderTopWidth)
            {
                if (borderTopWidth.skip && animate.borderTopWidth.HasValue)
                {
                    style.borderTopWidth = animate.borderTopWidth.Value;
                }
                else if (borderTopWidth.value.HasValue)
                {
                    style.borderTopWidth = borderTopWidth.value.Value;
                }
            }
            if (initial.bottom is IInitialValue<Length> bottom)
            {
                if (bottom.skip && animate.bottom.HasValue)
                {
                    style.bottom = animate.bottom.Value;
                }
                else if (bottom.value.HasValue)
                {
                    style.bottom = bottom.value.Value;
                }
            }
            if (initial.color is IInitialValue<Color> color)
            {
                if (color.skip && animate.color.HasValue)
                {
                    style.color = animate.color.Value;
                }
                else if (color.value.HasValue)
                {
                    style.color = color.value.Value;
                }
            }
            if (initial.flexBasis is IInitialValue<Length> flexBasis)
            {
                if (flexBasis.skip && animate.flexBasis.HasValue)
                {
                    style.flexBasis = animate.flexBasis.Value;
                }
                else if (flexBasis.value.HasValue)
                {
                    style.flexBasis = flexBasis.value.Value;
                }
            }
            if (initial.flexGrow is IInitialValue<float> flexGrow)
            {
                if (flexGrow.skip && animate.flexGrow.HasValue)
                {
                    style.flexGrow = animate.flexGrow.Value;
                }
                else if (flexGrow.value.HasValue)
                {
                    style.flexGrow = flexGrow.value.Value;
                }
            }
            if (initial.flexShrink is IInitialValue<float> flexShrink)
            {
                if (flexShrink.skip && animate.flexShrink.HasValue)
                {
                    style.flexShrink = animate.flexShrink.Value;
                }
                else if (flexShrink.value.HasValue)
                {
                    style.flexShrink = flexShrink.value.Value;
                }
            }
            if (initial.fontSize is IInitialValue<Length> fontSize)
            {
                if (fontSize.skip && animate.fontSize.HasValue)
                {
                    style.fontSize = animate.fontSize.Value;
                }
                else if (fontSize.value.HasValue)
                {
                    style.fontSize = fontSize.value.Value;
                }
            }
            if (initial.height is IInitialValue<Length> height)
            {
                if (height.skip && animate.height.HasValue)
                {
                    style.height = animate.height.Value;
                }
                else if (height.value.HasValue)
                {
                    style.height = height.value.Value;
                }
            }
            if (initial.left is IInitialValue<Length> left)
            {
                if (left.skip && animate.left.HasValue)
                {
                    style.left = animate.left.Value;
                }
                else if (left.value.HasValue)
                {
                    style.left = left.value.Value;
                }
            }
            if (initial.letterSpacing is IInitialValue<Length> letterSpacing)
            {
                if (letterSpacing.skip && animate.letterSpacing.HasValue)
                {
                    style.letterSpacing = animate.letterSpacing.Value;
                }
                else if (letterSpacing.value.HasValue)
                {
                    style.letterSpacing = letterSpacing.value.Value;
                }
            }
            if (initial.marginBottom is IInitialValue<Length> marginBottom)
            {
                if (marginBottom.skip && animate.marginBottom.HasValue)
                {
                    style.marginBottom = animate.marginBottom.Value;
                }
                else if (marginBottom.value.HasValue)
                {
                    style.marginBottom = marginBottom.value.Value;
                }
            }
            if (initial.marginLeft is IInitialValue<Length> marginLeft)
            {
                if (marginLeft.skip && animate.marginLeft.HasValue)
                {
                    style.marginLeft = animate.marginLeft.Value;
                }
                else if (marginLeft.value.HasValue)
                {
                    style.marginLeft = marginLeft.value.Value;
                }
            }
            if (initial.marginRight is IInitialValue<Length> marginRight)
            {
                if (marginRight.skip && animate.marginRight.HasValue)
                {
                    style.marginRight = animate.marginRight.Value;
                }
                else if (marginRight.value.HasValue)
                {
                    style.marginRight = marginRight.value.Value;
                }
            }
            if (initial.marginTop is IInitialValue<Length> marginTop)
            {
                if (marginTop.skip && animate.marginTop.HasValue)
                {
                    style.marginTop = animate.marginTop.Value;
                }
                else if (marginTop.value.HasValue)
                {
                    style.marginTop = marginTop.value.Value;
                }
            }
            if (initial.maxHeight is IInitialValue<Length> maxHeight)
            {
                if (maxHeight.skip && animate.maxHeight.HasValue)
                {
                    style.maxHeight = animate.maxHeight.Value;
                }
                else if (maxHeight.value.HasValue)
                {
                    style.maxHeight = maxHeight.value.Value;
                }
            }
            if (initial.maxWidth is IInitialValue<Length> maxWidth)
            {
                if (maxWidth.skip && animate.maxWidth.HasValue)
                {
                    style.maxWidth = animate.maxWidth.Value;
                }
                else if (maxWidth.value.HasValue)
                {
                    style.maxWidth = maxWidth.value.Value;
                }
            }
            if (initial.minHeight is IInitialValue<Length> minHeight)
            {
                if (minHeight.skip && animate.minHeight.HasValue)
                {
                    style.minHeight = animate.minHeight.Value;
                }
                else if (minHeight.value.HasValue)
                {
                    style.minHeight = minHeight.value.Value;
                }
            }
            if (initial.minWidth is IInitialValue<Length> minWidth)
            {
                if (minWidth.skip && animate.minWidth.HasValue)
                {
                    style.minWidth = animate.minWidth.Value;
                }
                else if (minWidth.value.HasValue)
                {
                    style.minWidth = minWidth.value.Value;
                }
            }
            if (initial.opacity is IInitialValue<float> opacity)
            {
                if (opacity.skip && animate.opacity.HasValue)
                {
                    style.opacity = animate.opacity.Value;
                }
                else if (opacity.value.HasValue)
                {
                    style.opacity = opacity.value.Value;
                }
            }
            if (initial.paddingBottom is IInitialValue<Length> paddingBottom)
            {
                if (paddingBottom.skip && animate.paddingBottom.HasValue)
                {
                    style.paddingBottom = animate.paddingBottom.Value;
                }
                else if (paddingBottom.value.HasValue)
                {
                    style.paddingBottom = paddingBottom.value.Value;
                }
            }
            if (initial.paddingLeft is IInitialValue<Length> paddingLeft)
            {
                if (paddingLeft.skip && animate.paddingLeft.HasValue)
                {
                    style.paddingLeft = animate.paddingLeft.Value;
                }
                else if (paddingLeft.value.HasValue)
                {
                    style.paddingLeft = paddingLeft.value.Value;
                }
            }
            if (initial.paddingRight is IInitialValue<Length> paddingRight)
            {
                if (paddingRight.skip && animate.paddingRight.HasValue)
                {
                    style.paddingRight = animate.paddingRight.Value;
                }
                else if (paddingRight.value.HasValue)
                {
                    style.paddingRight = paddingRight.value.Value;
                }
            }
            if (initial.paddingTop is IInitialValue<Length> paddingTop)
            {
                if (paddingTop.skip && animate.paddingTop.HasValue)
                {
                    style.paddingTop = animate.paddingTop.Value;
                }
                else if (paddingTop.value.HasValue)
                {
                    style.paddingTop = paddingTop.value.Value;
                }
            }
            if (initial.right is IInitialValue<Length> right)
            {
                if (right.skip && animate.right.HasValue)
                {
                    style.right = animate.right.Value;
                }
                else if (right.value.HasValue)
                {
                    style.right = right.value.Value;
                }
            }
            if (initial.rotate is IInitialValue<Angle> rotate)
            {
                if (rotate.skip && animate.rotate.HasValue)
                {
                    style.rotate = animate.rotate.Value;
                }
                else if (rotate.value.HasValue)
                {
                    style.rotate = rotate.value.Value;
                }
            }
            if (initial.scale is IInitialValue<Vector3> scale)
            {
                if (scale.skip && animate.scale.HasValue)
                {
                    style.scale = animate.scale.Value;
                }
                else if (scale.value.HasValue)
                {
                    style.scale = scale.value.Value;
                }
            }
            if (initial.top is IInitialValue<Length> top)
            {
                if (top.skip && animate.top.HasValue)
                {
                    style.top = animate.top.Value;
                }
                else if (top.value.HasValue)
                {
                    style.top = top.value.Value;
                }
            }
            if (initial.transformOrigin is IInitialValue<TransformOrigin> transformOrigin)
            {
                if (transformOrigin.skip && animate.transformOrigin.HasValue)
                {
                    style.transformOrigin = animate.transformOrigin.Value;
                }
                else if (transformOrigin.value.HasValue)
                {
                    style.transformOrigin = transformOrigin.value.Value;
                }
            }
            if (initial.translate is IInitialValue<Translate> translate)
            {
                if (translate.skip && animate.translate.HasValue)
                {
                    style.translate = animate.translate.Value;
                }
                else if (translate.value.HasValue)
                {
                    style.translate = translate.value.Value;
                }
            }
            if (initial.unityBackgroundImageTintColor is IInitialValue<Color> unityBackgroundImageTintColor)
            {
                if (unityBackgroundImageTintColor.skip && animate.unityBackgroundImageTintColor.HasValue)
                {
                    style.unityBackgroundImageTintColor = animate.unityBackgroundImageTintColor.Value;
                }
                else if (unityBackgroundImageTintColor.value.HasValue)
                {
                    style.unityBackgroundImageTintColor = unityBackgroundImageTintColor.value.Value;
                }
            }
            if (initial.unityParagraphSpacing is IInitialValue<Length> unityParagraphSpacing)
            {
                if (unityParagraphSpacing.skip && animate.unityParagraphSpacing.HasValue)
                {
                    style.unityParagraphSpacing = animate.unityParagraphSpacing.Value;
                }
                else if (unityParagraphSpacing.value.HasValue)
                {
                    style.unityParagraphSpacing = unityParagraphSpacing.value.Value;
                }
            }
            if (initial.unitySliceBottom is IInitialValue<int> unitySliceBottom)
            {
                if (unitySliceBottom.skip && animate.unitySliceBottom.HasValue)
                {
                    style.unitySliceBottom = animate.unitySliceBottom.Value;
                }
                else if (unitySliceBottom.value.HasValue)
                {
                    style.unitySliceBottom = unitySliceBottom.value.Value;
                }
            }
            if (initial.unitySliceLeft is IInitialValue<int> unitySliceLeft)
            {
                if (unitySliceLeft.skip && animate.unitySliceLeft.HasValue)
                {
                    style.unitySliceLeft = animate.unitySliceLeft.Value;
                }
                else if (unitySliceLeft.value.HasValue)
                {
                    style.unitySliceLeft = unitySliceLeft.value.Value;
                }
            }
            if (initial.unitySliceRight is IInitialValue<int> unitySliceRight)
            {
                if (unitySliceRight.skip && animate.unitySliceRight.HasValue)
                {
                    style.unitySliceRight = animate.unitySliceRight.Value;
                }
                else if (unitySliceRight.value.HasValue)
                {
                    style.unitySliceRight = unitySliceRight.value.Value;
                }
            }
            if (initial.unitySliceTop is IInitialValue<int> unitySliceTop)
            {
                if (unitySliceTop.skip && animate.unitySliceTop.HasValue)
                {
                    style.unitySliceTop = animate.unitySliceTop.Value;
                }
                else if (unitySliceTop.value.HasValue)
                {
                    style.unitySliceTop = unitySliceTop.value.Value;
                }
            }
            if (initial.unityTextOutlineColor is IInitialValue<Color> unityTextOutlineColor)
            {
                if (unityTextOutlineColor.skip && animate.unityTextOutlineColor.HasValue)
                {
                    style.unityTextOutlineColor = animate.unityTextOutlineColor.Value;
                }
                else if (unityTextOutlineColor.value.HasValue)
                {
                    style.unityTextOutlineColor = unityTextOutlineColor.value.Value;
                }
            }
            if (initial.unityTextOutlineWidth is IInitialValue<float> unityTextOutlineWidth)
            {
                if (unityTextOutlineWidth.skip && animate.unityTextOutlineWidth.HasValue)
                {
                    style.unityTextOutlineWidth = animate.unityTextOutlineWidth.Value;
                }
                else if (unityTextOutlineWidth.value.HasValue)
                {
                    style.unityTextOutlineWidth = unityTextOutlineWidth.value.Value;
                }
            }
            if (initial.width is IInitialValue<Length> width)
            {
                if (width.skip && animate.width.HasValue)
                {
                    style.width = animate.width.Value;
                }
                else if (width.value.HasValue)
                {
                    style.width = width.value.Value;
                }
            }
            if (initial.wordSpacing is IInitialValue<Length> wordSpacing)
            {
                if (wordSpacing.skip && animate.wordSpacing.HasValue)
                {
                    style.wordSpacing = animate.wordSpacing.Value;
                }
                else if (wordSpacing.value.HasValue)
                {
                    style.wordSpacing = wordSpacing.value.Value;
                }
            }

            return new DOMDescriptor
            {
                name = descriptor.name,
                className = descriptor.className,
                style = style
            };
        }
    }

    [RishValueType]
    public struct MotionDivProps
    {
        public Initial initial;
        public Target animate;
        public Target exit; // TODO: Add wait for children animations
        
        [IgnoreComparison]
        public Action onAnimateComplete;
        [IgnoreComparison]
        public Action onExitComplete;

        // TODO
        // public bool drag;

        // TODO: Create parent element with multiple children based on hover and press
        // public Target whileHover;
        // public Target whilePress;

        [DOMDescriptor]
        public DOMDescriptor descriptor;
        public Children children;
    }

    [RishValueType]
    public struct MotionDivState
    {
        public DOMDescriptor descriptor;
    }
}