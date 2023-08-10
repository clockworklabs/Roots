using System;
using Motion;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public struct Repeat
    {
        public int count;
        // TODO: Support additive
        public LoopType loopType;
        public int interval;
        public float intervalDelay;

        public Repeat(int count)
        {
            this.count = count;
            loopType = default;
            interval = default;
            intervalDelay = default;
        }
        public Repeat(bool repeat)
        {
            count = repeat ? -1 : 0;
            loopType = default;
            interval = default;
            intervalDelay = default;
        }

        public static implicit operator Repeat(int count) => new(count);
        public static implicit operator Repeat(bool repeat) => new(repeat);
    }

    public enum TransitionType { Default, Spring, Tween, None }
    
    public struct TransitionDetails
    {
        private enum Type
        {
            Default,
            Spring,
            Linear,
            SineIn,
            Sine,
            SineOut,
            QuadIn,
            Quad,
            QuadOut,
            CubicIn,
            Cubic,
            CubicOut,
            QuartIn,
            Quart,
            QuartOut,
            QuintIn,
            Quint,
            QuintOut,
            ExpoIn,
            Expo,
            ExpoOut,
            CircleIn,
            Circle,
            CircleOut,
            BackIn,
            Back,
            BackOut,
            ElasticIn,
            Elastic,
            ElasticOut,
            BounceIn,
            Bounce,
            BounceOut,
            None
        }

        public float? delay;
        public Repeat? repeat;

        private readonly Type internalType;
        private readonly float f0;
        private readonly float f1;
        private readonly float f2;
        private readonly float f3;
        private readonly float f4;
        
        public TransitionDetails(TransitionDetails other)
        {
            delay = other.delay;
            repeat = other.repeat;
            internalType = other.internalType;
            f0 = other.f0;
            f1 = other.f1;
            f2 = other.f2;
            f3 = other.f3;
            f4 = other.f4;
        }
        
        public TransitionDetails(Spring spring)
        {
            delay = default;
            repeat = default;
            internalType = Type.Spring;
            f0 = spring.stiffness;
            f1 = spring.inverseMass;
            f2 = spring.damping;
            f3 = spring.sqrRestSpeed;
            f4 = spring.sqrRestDelta;
        }
        
        public TransitionDetails(Tween tween)
        {
            delay = default;
            repeat = default;
            internalType = GetEasingType(tween.ease);
            f0 = tween.duration;
            f1 = default;
            f2 = default;
            f3 = default;
            f4 = default;
        }

        private TransitionDetails(bool animate)
        {
            delay = default;
            repeat = default;
            internalType = animate ? Type.Default : Type.None;
            f0 = default;
            f1 = default;
            f2 = default;
            f3 = default;
            f4 = default;
        }

        public TransitionType type => internalType switch
        {
            Type.Default => TransitionType.Default,
            Type.None => TransitionType.None,
            Type.Spring => TransitionType.Spring,
            _ => TransitionType.Tween
        };
        public Spring spring
        {
            get
            {
                if (internalType != Type.Spring)
                {
                    throw new UnityException("Not a spring transition");
                }

                return new Spring
                {
                    stiffness = f0,
                    inverseMass = f1,
                    damping = f2,
                    sqrRestSpeed = f3,
                    sqrRestDelta = f4
                };
            }
        }
        public Tween tween
        {
            get
            {
                if (internalType is Type.None or Type.Spring)
                {
                    throw new UnityException("Not a tween transition");
                }

                return new Tween {
                    duration = f0,
                    ease = GetEase(internalType)
                };
            }
        }
        
        internal TransitionDetails New(Spring spring) => new (spring)
        {
            delay = delay,
            repeat = repeat
        };
        internal TransitionDetails New(Tween tween) => new (tween)
        {
            delay = delay,
            repeat = repeat
        };
        
        public static implicit operator TransitionDetails(Spring spring) => new(spring);
        public static implicit operator TransitionDetails(Tween tween) => new(tween);
        public static implicit operator TransitionDetails(bool animate) => new (animate);

        private static Type GetEasingType(Ease ease)
        {
            return ease switch
            {
                Ease.Linear => Type.Linear,
                Ease.SineIn => Type.SineIn,
                Ease.Sine => Type.Sine,
                Ease.SineOut => Type.SineOut,
                Ease.QuadIn => Type.QuadIn,
                Ease.Quad => Type.Quad,
                Ease.QuadOut => Type.QuadOut,
                Ease.CubicIn => Type.CubicIn,
                Ease.Cubic => Type.Cubic,
                Ease.CubicOut => Type.CubicOut,
                Ease.QuartIn => Type.QuartIn,
                Ease.Quart => Type.Quart,
                Ease.QuartOut => Type.QuartOut,
                Ease.QuintIn => Type.QuintIn,
                Ease.Quint => Type.Quint,
                Ease.QuintOut => Type.QuintOut,
                Ease.ExpoIn => Type.ExpoIn,
                Ease.Expo => Type.Expo,
                Ease.ExpoOut => Type.ExpoOut,
                Ease.CircleIn => Type.CircleIn,
                Ease.Circle => Type.Circle,
                Ease.CircleOut => Type.CircleOut,
                Ease.BackIn => Type.BackIn,
                Ease.Back => Type.Back,
                Ease.BackOut => Type.BackOut,
                Ease.ElasticIn => Type.ElasticIn,
                Ease.Elastic => Type.Elastic,
                Ease.ElasticOut => Type.ElasticOut,
                Ease.BounceIn => Type.BounceIn,
                Ease.Bounce => Type.Bounce,
                Ease.BounceOut => Type.BounceOut,
                _ => throw new ArgumentOutOfRangeException(nameof(ease), ease, null)
            };
        }
        private static Ease GetEase(Type type)
        {
            return type switch
            {
                Type.Linear => Ease.Linear,
                Type.SineIn => Ease.SineIn,
                Type.Sine => Ease.Sine,
                Type.SineOut => Ease.SineOut,
                Type.QuadIn => Ease.QuadIn,
                Type.Quad => Ease.Quad,
                Type.QuadOut => Ease.QuadOut,
                Type.CubicIn => Ease.CubicIn,
                Type.Cubic => Ease.Cubic,
                Type.CubicOut => Ease.CubicOut,
                Type.QuartIn => Ease.QuartIn,
                Type.Quart => Ease.Quart,
                Type.QuartOut => Ease.QuartOut,
                Type.QuintIn => Ease.QuintIn,
                Type.Quint => Ease.Quint,
                Type.QuintOut => Ease.QuintOut,
                Type.ExpoIn => Ease.ExpoIn,
                Type.Expo => Ease.Expo,
                Type.ExpoOut => Ease.ExpoOut,
                Type.CircleIn => Ease.CircleIn,
                Type.Circle => Ease.Circle,
                Type.CircleOut => Ease.CircleOut,
                Type.BackIn => Ease.BackIn,
                Type.Back => Ease.Back,
                Type.BackOut => Ease.BackOut,
                Type.ElasticIn => Ease.ElasticIn,
                Type.Elastic => Ease.Elastic,
                Type.ElasticOut => Ease.ElasticOut,
                Type.BounceIn => Ease.BounceIn,
                Type.Bounce => Ease.Bounce,
                Type.BounceOut => Ease.BounceOut,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
    
    public struct Transition
    {
        public enum StaggerDirection { Normal, Reverse }
        // public enum When { Default, BeforeChildren, AfterChildren }

        public float delayChildren;
        public float staggerChildren;
        public StaggerDirection staggerDirection;
        // TODO
        // public When when;
        
        public TransitionDetails backgroundColor;
        public TransitionDetails borderBottomColor;
        public TransitionDetails borderBottomLeftRadius;
        public TransitionDetails borderBottomRightRadius;
        public TransitionDetails borderBottomWidth;
        public TransitionDetails borderLeftColor;
        public TransitionDetails borderLeftWidth;
        public TransitionDetails borderRightColor;
        public TransitionDetails borderRightWidth;
        public TransitionDetails borderTopColor;
        public TransitionDetails borderTopLeftRadius;
        public TransitionDetails borderTopRightRadius;
        public TransitionDetails borderTopWidth;
        public TransitionDetails bottom;
        public TransitionDetails color;
        public TransitionDetails flexBasis;
        public TransitionDetails flexGrow;
        public TransitionDetails flexShrink;
        public TransitionDetails fontSize;
        public TransitionDetails height;
        public TransitionDetails left;
        public TransitionDetails letterSpacing;
        public TransitionDetails marginBottom;
        public TransitionDetails marginLeft;
        public TransitionDetails marginRight;
        public TransitionDetails marginTop;
        public TransitionDetails maxHeight;
        public TransitionDetails maxWidth;
        public TransitionDetails minHeight;
        public TransitionDetails minWidth;
        public TransitionDetails opacity;
        public TransitionDetails paddingBottom;
        public TransitionDetails paddingLeft;
        public TransitionDetails paddingRight;
        public TransitionDetails paddingTop;
        public TransitionDetails right;
        public TransitionDetails rotate;
        public TransitionDetails scale;
        public TransitionDetails top;
        public TransitionDetails transformOrigin;
        public TransitionDetails translate;
        public TransitionDetails unityBackgroundImageTintColor;
        public TransitionDetails unityParagraphSpacing;
        public TransitionDetails unitySliceBottom;
        public TransitionDetails unitySliceLeft;
        public TransitionDetails unitySliceRight;
        public TransitionDetails unitySliceTop;
        public TransitionDetails unityTextOutlineColor;
        public TransitionDetails unityTextOutlineWidth;
        public TransitionDetails width;
        public TransitionDetails wordSpacing;

        public TransitionDetails defaultTransition;
        
        public float delay {
            // get => defaultTransition.delay;
            set => defaultTransition.delay = value;
        }
        public Repeat repeat {
            // get => defaultTransition.repeat;
            set => defaultTransition.repeat = value;
        }
        public Spring spring {
            set => defaultTransition = defaultTransition.New(value);
        }
        public Tween tween {
            set => defaultTransition = defaultTransition.New(value);
        }

        public TransitionDetails all
        {
            set
            {
                backgroundColor = value;
                borderBottomColor = value;
                borderBottomLeftRadius = value;
                borderBottomRightRadius = value;
                borderBottomWidth = value;
                borderLeftColor = value;
                borderLeftWidth = value;
                borderRightColor = value;
                borderRightWidth = value;
                borderTopColor = value;
                borderTopLeftRadius = value;
                borderTopRightRadius = value;
                borderTopWidth = value;
                bottom = value;
                color = value;
                flexBasis = value;
                flexGrow = value;
                flexShrink = value;
                fontSize = value;
                height = value;
                left = value;
                letterSpacing = value;
                marginBottom = value;
                marginLeft = value;
                marginRight = value;
                marginTop = value;
                maxHeight = value;
                maxWidth = value;
                minHeight = value;
                minWidth = value;
                opacity = value;
                paddingBottom = value;
                paddingLeft = value;
                paddingRight = value;
                paddingTop = value;
                right = value;
                rotate = value;
                scale = value;
                top = value;
                transformOrigin = value;
                translate = value;
                unityBackgroundImageTintColor = value;
                unityParagraphSpacing = value;
                unitySliceBottom = value;
                unitySliceLeft = value;
                unitySliceRight = value;
                unitySliceTop = value;
                unityTextOutlineColor = value;
                unityTextOutlineWidth = value;
                width = value;
                wordSpacing = value;
            }
        }

        public TransitionDetails borderColor
        {
            set
            {
                borderTopColor = value;
                borderRightColor = value;
                borderBottomColor = value;
                borderLeftColor = value;
            }
        }

        public TransitionDetails borderRadius
        {
            set
            {
                borderTopLeftRadius = value;
                borderTopRightRadius = value;
                borderBottomRightRadius = value;
                borderBottomLeftRadius = value;
            }
        }

        public TransitionDetails borderWidth
        {
            set
            {
                borderTopWidth = value;
                borderRightWidth = value;
                borderBottomWidth = value;
                borderLeftWidth = value;
            }
        }

        public TransitionDetails margin
        {
            set
            {
                marginTop = value;
                marginRight = value;
                marginBottom = value;
                marginLeft = value;
            }
        }

        public TransitionDetails flex
        {
            set
            {
                flexGrow = value;
                flexShrink = value;
                flexBasis = value;
            }
        }

        public TransitionDetails padding
        {
            set
            {
                paddingTop = value;
                paddingRight = value;
                paddingBottom = value;
                paddingLeft = value;
            }
        }

        public Transition(Spring spring)
        {
            delayChildren = default;
            staggerChildren = default;
            staggerDirection = default;
            // when = default;
            backgroundColor = default;
            borderBottomColor = default;
            borderBottomLeftRadius = default;
            borderBottomRightRadius = default;
            borderBottomWidth = default;
            borderLeftColor = default;
            borderLeftWidth = default;
            borderRightColor = default;
            borderRightWidth = default;
            borderTopColor = default;
            borderTopLeftRadius = default;
            borderTopRightRadius = default;
            borderTopWidth = default;
            bottom = default;
            color = default;
            flexBasis = default;
            flexGrow = default;
            flexShrink = default;
            fontSize = default;
            height = default;
            left = default;
            letterSpacing = default;
            marginBottom = default;
            marginLeft = default;
            marginRight = default;
            marginTop = default;
            maxHeight = default;
            maxWidth = default;
            minHeight = default;
            minWidth = default;
            opacity = default;
            paddingBottom = default;
            paddingLeft = default;
            paddingRight = default;
            paddingTop = default;
            right = default;
            rotate = default;
            scale = default;
            top = default;
            transformOrigin = default;
            translate = default;
            unityBackgroundImageTintColor = default;
            unityParagraphSpacing = default;
            unitySliceBottom = default;
            unitySliceLeft = default;
            unitySliceRight = default;
            unitySliceTop = default;
            unityTextOutlineColor = default;
            unityTextOutlineWidth = default;
            width = default;
            wordSpacing = default;
            defaultTransition = new TransitionDetails(spring);
        }

        public Transition(Tween tween)
        {
            delayChildren = default;
            staggerChildren = default;
            staggerDirection = default;
            // when = default;
            backgroundColor = default;
            borderBottomColor = default;
            borderBottomLeftRadius = default;
            borderBottomRightRadius = default;
            borderBottomWidth = default;
            borderLeftColor = default;
            borderLeftWidth = default;
            borderRightColor = default;
            borderRightWidth = default;
            borderTopColor = default;
            borderTopLeftRadius = default;
            borderTopRightRadius = default;
            borderTopWidth = default;
            bottom = default;
            color = default;
            flexBasis = default;
            flexGrow = default;
            flexShrink = default;
            fontSize = default;
            height = default;
            left = default;
            letterSpacing = default;
            marginBottom = default;
            marginLeft = default;
            marginRight = default;
            marginTop = default;
            maxHeight = default;
            maxWidth = default;
            minHeight = default;
            minWidth = default;
            opacity = default;
            paddingBottom = default;
            paddingLeft = default;
            paddingRight = default;
            paddingTop = default;
            right = default;
            rotate = default;
            scale = default;
            top = default;
            transformOrigin = default;
            translate = default;
            unityBackgroundImageTintColor = default;
            unityParagraphSpacing = default;
            unitySliceBottom = default;
            unitySliceLeft = default;
            unitySliceRight = default;
            unitySliceTop = default;
            unityTextOutlineColor = default;
            unityTextOutlineWidth = default;
            width = default;
            wordSpacing = default;
            defaultTransition = new TransitionDetails(tween);
        }

        public Transition(TransitionDetails transition)
        {
            delayChildren = default;
            staggerChildren = default;
            staggerDirection = default;
            // when = default;
            backgroundColor = default;
            borderBottomColor = default;
            borderBottomLeftRadius = default;
            borderBottomRightRadius = default;
            borderBottomWidth = default;
            borderLeftColor = default;
            borderLeftWidth = default;
            borderRightColor = default;
            borderRightWidth = default;
            borderTopColor = default;
            borderTopLeftRadius = default;
            borderTopRightRadius = default;
            borderTopWidth = default;
            bottom = default;
            color = default;
            flexBasis = default;
            flexGrow = default;
            flexShrink = default;
            fontSize = default;
            height = default;
            left = default;
            letterSpacing = default;
            marginBottom = default;
            marginLeft = default;
            marginRight = default;
            marginTop = default;
            maxHeight = default;
            maxWidth = default;
            minHeight = default;
            minWidth = default;
            opacity = default;
            paddingBottom = default;
            paddingLeft = default;
            paddingRight = default;
            paddingTop = default;
            right = default;
            rotate = default;
            scale = default;
            top = default;
            transformOrigin = default;
            translate = default;
            unityBackgroundImageTintColor = default;
            unityParagraphSpacing = default;
            unitySliceBottom = default;
            unitySliceLeft = default;
            unitySliceRight = default;
            unitySliceTop = default;
            unityTextOutlineColor = default;
            unityTextOutlineWidth = default;
            width = default;
            wordSpacing = default;
            defaultTransition = transition;
        }
    }
    
    public struct Target
    {
        public Color? backgroundColor;
        public Color? borderBottomColor;
        public Length? borderBottomLeftRadius;
        public Length? borderBottomRightRadius;
        public float? borderBottomWidth;
        public Color? borderLeftColor;
        public float? borderLeftWidth;
        public Color? borderRightColor;
        public float? borderRightWidth;
        public Color? borderTopColor;
        public Length? borderTopLeftRadius;
        public Length? borderTopRightRadius;
        public float? borderTopWidth;
        public Length? bottom;
        public Color? color;
        public Length? flexBasis;
        public float? flexGrow;
        public float? flexShrink;
        public Length? fontSize;
        public Length? height;
        public Length? left;
        public Length? letterSpacing;
        public Length? marginBottom;
        public Length? marginLeft;
        public Length? marginRight;
        public Length? marginTop;
        public Length? maxHeight;
        public Length? maxWidth;
        public Length? minHeight;
        public Length? minWidth;
        public float? opacity;
        public Length? paddingBottom;
        public Length? paddingLeft;
        public Length? paddingRight;
        public Length? paddingTop;
        public Length? right;
        public Angle? rotate;
        // TODO: Make this to allow just one float
        public Vector3? scale;
        public Length? top;
        public TransformOrigin? transformOrigin;
        public Translate? translate;
        public Color? unityBackgroundImageTintColor;
        public Length? unityParagraphSpacing;
        public int? unitySliceBottom;
        public int? unitySliceLeft;
        public int? unitySliceRight;
        public int? unitySliceTop;
        public Color? unityTextOutlineColor;
        public float? unityTextOutlineWidth;
        public Length? width;
        public Length? wordSpacing;

        public Transition transition;

        public TargetColorsShorthand borderColor
        {
            set
            {
                borderTopColor = value.top;
                borderRightColor = value.right;
                borderBottomColor = value.bottom;
                borderLeftColor = value.left;
            }
        }

        public TargetLengthsShorthand borderRadius
        {
            set
            {
                borderTopLeftRadius = value.topLeft;
                borderTopRightRadius = value.topRight;
                borderBottomRightRadius = value.bottomRight;
                borderBottomLeftRadius = value.bottomLeft;
            }
        }

        public TargetFloatsShorthand borderWidth
        {
            set
            {
                borderTopWidth = value.top;
                borderRightWidth = value.right;
                borderBottomWidth = value.bottom;
                borderLeftWidth = value.left;
            }
        }

        public TargetFlexShorthand flex
        {
            set
            {
                flexGrow = value.grow;
                flexShrink = value.shrink;
                flexBasis = value.basis;
            }
        }

        public TargetLengthsShorthand margin
        {
            set
            {
                marginTop = value.top;
                marginRight = value.right;
                marginBottom = value.bottom;
                marginLeft = value.left;
            }
        }

        public TargetLengthsShorthand padding
        {
            set
            {
                paddingTop = value.top;
                paddingRight = value.right;
                paddingBottom = value.bottom;
                paddingLeft = value.left;
            }
        }

        internal bool IsValid()
        {
            return backgroundColor.HasValue ||
                   borderBottomColor.HasValue ||
                   borderBottomLeftRadius.HasValue ||
                   borderBottomRightRadius.HasValue ||
                   borderBottomWidth.HasValue ||
                   borderLeftColor.HasValue ||
                   borderLeftWidth.HasValue ||
                   borderRightColor.HasValue ||
                   borderRightWidth.HasValue ||
                   borderTopColor.HasValue ||
                   borderTopLeftRadius.HasValue ||
                   borderTopRightRadius.HasValue ||
                   borderTopWidth.HasValue ||
                   bottom.HasValue ||
                   color.HasValue ||
                   flexBasis.HasValue ||
                   flexGrow.HasValue ||
                   flexShrink.HasValue ||
                   fontSize.HasValue ||
                   height.HasValue ||
                   left.HasValue ||
                   letterSpacing.HasValue ||
                   marginBottom.HasValue ||
                   marginLeft.HasValue ||
                   marginRight.HasValue ||
                   marginTop.HasValue ||
                   maxHeight.HasValue ||
                   maxWidth.HasValue ||
                   minHeight.HasValue ||
                   minWidth.HasValue ||
                   opacity.HasValue ||
                   paddingBottom.HasValue ||
                   paddingLeft.HasValue ||
                   paddingRight.HasValue ||
                   paddingTop.HasValue ||
                   right.HasValue ||
                   rotate.HasValue ||
                   scale.HasValue ||
                   top.HasValue ||
                   transformOrigin.HasValue ||
                   translate.HasValue ||
                   unityBackgroundImageTintColor.HasValue ||
                   unityParagraphSpacing.HasValue ||
                   unitySliceBottom.HasValue ||
                   unitySliceLeft.HasValue ||
                   unitySliceRight.HasValue ||
                   unitySliceTop.HasValue ||
                   unityTextOutlineColor.HasValue ||
                   unityTextOutlineWidth.HasValue ||
                   width.HasValue ||
                   wordSpacing.HasValue;
        }
    }

    public struct TargetColorsShorthand
    {
        public Color top;
        public Color right;
        public Color bottom;
        public Color left;

        public TargetColorsShorthand(Color value) : this(value, value, value, value) { }

        public TargetColorsShorthand(Color topBottom, Color leftRight) : this(topBottom, leftRight, topBottom, leftRight) { }

        public TargetColorsShorthand(Color top, Color leftRight, Color bottom) : this(top, leftRight, bottom, leftRight) { }

        public TargetColorsShorthand(Color top, Color right, Color bottom, Color left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public static implicit operator TargetColorsShorthand(Color value) => new(value);
        public static implicit operator TargetColorsShorthand((Color, Color) values) => new(values.Item1, values.Item2);
        public static implicit operator TargetColorsShorthand((Color, Color, Color) values) => new(values.Item1, values.Item2, values.Item3);
        public static implicit operator TargetColorsShorthand((Color, Color, Color, Color) values) => new(values.Item1, values.Item2, values.Item3, values.Item4);
    }

    public struct TargetLengthsShorthand
    {
        public Length top;
        public Length right;
        public Length bottom;
        public Length left;

        public Length topLeft
        {
            get => top;
            set => top = value;
        }

        public Length topRight
        {
            get => right;
            set => right = value;
        }

        public Length bottomRight
        {
            get => bottom;
            set => bottom = value;
        }

        public Length bottomLeft
        {
            get => left;
            set => left = value;
        }

        public TargetLengthsShorthand(Length value) : this(value, value, value, value) { }

        public TargetLengthsShorthand(Length topBottom, Length leftRight) : this(topBottom, leftRight, topBottom, leftRight) { }

        public TargetLengthsShorthand(Length top, Length leftRight, Length bottom) : this(top, leftRight, bottom, leftRight) { }

        public TargetLengthsShorthand(Length top, Length right, Length bottom, Length left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public static implicit operator TargetLengthsShorthand(float value) => new(value);
        public static implicit operator TargetLengthsShorthand(Length value) => new(value);

        public static implicit operator TargetLengthsShorthand((float, float) values) => new(values.Item1, values.Item2);
        public static implicit operator TargetLengthsShorthand((Length, Length) values) => new(values.Item1, values.Item2);

        public static implicit operator TargetLengthsShorthand((float, float, float) values) => new(values.Item1, values.Item2, values.Item3);
        public static implicit operator TargetLengthsShorthand((Length, Length, Length) values) => new(values.Item1, values.Item2, values.Item3);

        public static implicit operator TargetLengthsShorthand((float, float, float, float) values) => new(values.Item1, values.Item2, values.Item3, values.Item4);
        public static implicit operator TargetLengthsShorthand((Length, Length, Length, Length) values) => new(values.Item1, values.Item2, values.Item3, values.Item4);
    }

    public struct TargetFloatsShorthand
    {
        public float top;
        public float right;
        public float bottom;
        public float left;

        public TargetFloatsShorthand(float value) : this(value, value, value, value) { }

        public TargetFloatsShorthand(float topBottom, float leftRight) : this(topBottom, leftRight, topBottom, leftRight) { }

        public TargetFloatsShorthand(float top, float leftRight, float bottom) : this(top, leftRight, bottom, leftRight) { }

        public TargetFloatsShorthand(float top, float right, float bottom, float left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public static implicit operator TargetFloatsShorthand(float value) => new(value);
        public static implicit operator TargetFloatsShorthand((float, float) values) => new(values.Item1, values.Item2);
        public static implicit operator TargetFloatsShorthand(Vector2 values) => new(values.x, values.y);

        public static implicit operator TargetFloatsShorthand((float, float, float) values) => new(values.Item1, values.Item2, values.Item3);
        public static implicit operator TargetFloatsShorthand(Vector3 values) => new(values.x, values.y, values.z);

        public static implicit operator TargetFloatsShorthand((float, float, float, float) values) => new(values.Item1, values.Item2, values.Item3, values.Item4);
        public static implicit operator TargetFloatsShorthand(Vector4 values) => new(values.x, values.y, values.z, values.w);
    }

    public struct TargetFlexShorthand
    {
        public float grow;
        public float shrink;
        public Length basis;

        public TargetFlexShorthand(float grow) : this(grow, 1, 0) { }

        public TargetFlexShorthand(Length basis) : this(1, 1, basis) { }

        public TargetFlexShorthand(float grow, float shrink) : this(grow, shrink, default) { }

        public TargetFlexShorthand(float grow, Length basis) : this(grow, default, basis) { }

        public TargetFlexShorthand(float grow, float shrink, Length basis)
        {
            this.grow = grow;
            this.shrink = shrink;
            this.basis = basis;
        }

        public static implicit operator TargetFlexShorthand(float grow) => new(grow);
        public static implicit operator TargetFlexShorthand(Length basis) => new(basis);

        public static implicit operator TargetFlexShorthand((float, float) values) =>
            new(values.Item1, values.Item2);

        public static implicit operator TargetFlexShorthand((float, Length) values) =>
            new(values.Item1, values.Item2);

        public static implicit operator TargetFlexShorthand((float, float, Length) values) =>
            new(values.Item1, values.Item2, values.Item3);
    }
}