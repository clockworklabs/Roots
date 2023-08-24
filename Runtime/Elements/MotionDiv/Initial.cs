using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public struct Initial
    {
        public InitialColor backgroundColor;
        public InitialColor borderBottomColor;
        public InitialLength borderBottomLeftRadius;
        public InitialLength borderBottomRightRadius;
        public InitialFloat borderBottomWidth;
        public InitialColor borderLeftColor;
        public InitialFloat borderLeftWidth;
        public InitialColor borderRightColor;
        public InitialFloat borderRightWidth;
        public InitialColor borderTopColor;
        public InitialLength borderTopLeftRadius;
        public InitialLength borderTopRightRadius;
        public InitialFloat borderTopWidth;
        public InitialLength bottom;
        public InitialColor color;
        public InitialLength flexBasis;
        public InitialFloat flexGrow;
        public InitialFloat flexShrink;
        public InitialLength fontSize;
        public InitialLength height;
        public InitialLength left;
        public InitialLength letterSpacing;
        public InitialLength marginBottom;
        public InitialLength marginLeft;
        public InitialLength marginRight;
        public InitialLength marginTop;
        public InitialLength maxHeight;
        public InitialLength maxWidth;
        public InitialLength minHeight;
        public InitialLength minWidth;
        public InitialFloat opacity;
        public InitialLength paddingBottom;
        public InitialLength paddingLeft;
        public InitialLength paddingRight;
        public InitialLength paddingTop;
        public InitialLength right;
        public InitialRotate rotate;
        public InitialScale scale;
        public InitialLength top;
        public InitialTransformOrigin transformOrigin;
        public InitialTranslate translate;
        public InitialColor unityBackgroundImageTintColor;
        public InitialLength unityParagraphSpacing;
        public InitialInt unitySliceBottom;
        public InitialInt unitySliceLeft;
        public InitialInt unitySliceRight;
        public InitialInt unitySliceTop;
        public InitialColor unityTextOutlineColor;
        public InitialFloat unityTextOutlineWidth;
        public InitialLength width;
        public InitialLength wordSpacing;

        public InitialColorsShorthand borderColor
        {
            set
            {
                borderTopColor = value.top;
                borderRightColor = value.right;
                borderBottomColor = value.bottom;
                borderLeftColor = value.left;
            }
        }
        public InitialLengthsShorthand borderRadius
        {
            set
            {
                borderTopLeftRadius = value.topLeft;
                borderTopRightRadius = value.topRight;
                borderBottomRightRadius = value.bottomRight;
                borderBottomLeftRadius = value.bottomLeft;
            }
        }
        public InitialFloatsShorthand borderWidth
        {
            set
            {
                borderTopWidth = value.top;
                borderRightWidth = value.right;
                borderBottomWidth = value.bottom;
                borderLeftWidth = value.left;
            }
        }
        public InitialFlexShorthand flex
        {
            set
            {
                flexGrow = value.grow;
                flexShrink = value.shrink;
                flexBasis = value.basis;
            }
        }
        public InitialLengthsShorthand margin
        {
            set
            {
                marginTop = value.top;
                marginRight = value.right;
                marginBottom = value.bottom;
                marginLeft = value.left;
            }
        }
        public InitialLengthsShorthand padding
        {
            set
            {
                paddingTop = value.top;
                paddingRight = value.right;
                paddingBottom = value.bottom;
                paddingLeft = value.left;
            }
        }
    }

    public interface IInitialValue<T> where T : struct
    {
        T? value { get; }
        bool skip { get; }
    }

    public readonly struct InitialColor : IInitialValue<Color>
    {
        private readonly Color? _value;
        Color? IInitialValue<Color>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<Color>.skip => _skip;

        public InitialColor(Color value)
        {
            _value = value;
            _skip = false;
        }

        public InitialColor(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialColor(Color value) => new(value);
        public static implicit operator InitialColor(bool animate) => new(animate);
    }

    public readonly struct InitialLength : IInitialValue<Length>
    {
        private readonly Length? _value;
        Length? IInitialValue<Length>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<Length>.skip => _skip;

        public InitialLength(Length value)
        {
            _value = value;
            _skip = false;
        }

        public InitialLength(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialLength(Length value) => new(value);
        public static implicit operator InitialLength(float value) => new(value);
        public static implicit operator InitialLength(bool animate) => new(animate);
    }

    public readonly struct InitialFloat : IInitialValue<float>
    {
        private readonly float? _value;
        float? IInitialValue<float>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<float>.skip => _skip;

        public InitialFloat(float value)
        {
            _value = value;
            _skip = false;
        }

        public InitialFloat(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialFloat(float value) => new(value);
        public static implicit operator InitialFloat(bool animate) => new(animate);
    }

    public readonly struct InitialInt : IInitialValue<int>
    {
        private readonly int? _value;
        int? IInitialValue<int>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<int>.skip => _skip;

        public InitialInt(int value)
        {
            _value = value;
            _skip = false;
        }

        public InitialInt(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialInt(int value) => new(value);
        public static implicit operator InitialInt(bool animate) => new(animate);
    }

    public readonly struct InitialRotate : IInitialValue<Angle>
    {
        private readonly Angle? _value;
        Angle? IInitialValue<Angle>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<Angle>.skip => _skip;

        public InitialRotate(Angle value)
        {
            _value = value;
            _skip = false;
        }

        public InitialRotate(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialRotate(Angle value) => new(value);
        public static implicit operator InitialRotate(float value) => new(value);
        public static implicit operator InitialRotate(bool animate) => new(animate);
    }

    public readonly struct InitialScale : IInitialValue<Vector3>
    {
        private readonly Vector3? _value;
        Vector3? IInitialValue<Vector3>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<Vector3>.skip => _skip;

        public InitialScale(Vector3 value)
        {
            _value = value;
            _skip = false;
        }
        public InitialScale(float value) : this(new Vector3(value, value, value)) { }

        public InitialScale(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialScale(Vector3 value) => new(value);
        public static implicit operator InitialScale(float value) => new(value);
        public static implicit operator InitialScale(bool animate) => new(animate);
    }

    public readonly struct InitialTransformOrigin : IInitialValue<TransformOrigin>
    {
        private readonly TransformOrigin? _value;
        TransformOrigin? IInitialValue<TransformOrigin>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<TransformOrigin>.skip => _skip;

        public InitialTransformOrigin(TransformOrigin value)
        {
            _value = value;
            _skip = false;
        }
        public InitialTransformOrigin(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialTransformOrigin(TransformOrigin value) => new(value);
        public static implicit operator InitialTransformOrigin(bool animate) => new(animate);
    }

    public readonly struct InitialTranslate : IInitialValue<Translate>
    {
        private readonly Translate? _value;
        Translate? IInitialValue<Translate>.value => _value;

        private readonly bool _skip;
        bool IInitialValue<Translate>.skip => _skip;

        public InitialTranslate(Translate value)
        {
            _value = value;
            _skip = false;
        }
        public InitialTranslate(bool animate)
        {
            _value = null;
            _skip = !animate;
        }

        public static implicit operator InitialTranslate(Translate value) => new(value);
        public static implicit operator InitialTranslate(bool animate) => new(animate);
    }
    
    public struct InitialFloatsShorthand
    {
        public InitialFloat top;
        public InitialFloat right;
        public InitialFloat bottom;
        public InitialFloat left;

        public InitialFloatsShorthand(InitialFloat value) : this(value, value, value, value) { }
        
        public InitialFloatsShorthand(InitialFloat topBottom, InitialFloat leftRight) : this(topBottom, leftRight, topBottom, leftRight) { }
        
        public InitialFloatsShorthand(InitialFloat top, InitialFloat leftRight, InitialFloat bottom) : this(top, leftRight, bottom, leftRight) { }

        public InitialFloatsShorthand(InitialFloat top, InitialFloat right, InitialFloat bottom, InitialFloat left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public static implicit operator InitialFloatsShorthand(float value) => new (value);
        public static implicit operator InitialFloatsShorthand(InitialFloat value) => new (value);
        public static implicit operator InitialFloatsShorthand((float, float) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialFloatsShorthand((InitialFloat, InitialFloat) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialFloatsShorthand(Vector2 values) => new (values.x, values.y);
        public static implicit operator InitialFloatsShorthand((float, float, float) values) => new (values.Item1, values.Item2, values.Item3);
        public static implicit operator InitialFloatsShorthand((InitialFloat, InitialFloat, InitialFloat) values) => new (values.Item1, values.Item2, values.Item3);
        public static implicit operator InitialFloatsShorthand(Vector3 values) => new (values.x, values.y, values.z);
        public static implicit operator InitialFloatsShorthand((float, float, float, float) values) => new (values.Item1, values.Item2, values.Item3, values.Item4);
        public static implicit operator InitialFloatsShorthand((InitialFloat, InitialFloat, InitialFloat, InitialFloat) values) => new (values.Item1, values.Item2, values.Item3, values.Item4);
        public static implicit operator InitialFloatsShorthand(Vector4 values) => new (values.x, values.y, values.z, values.w);

        public override string ToString() => $"({top}, {right}, {bottom}, {left})";
    }
    
    public struct InitialLengthsShorthand
    {
        public InitialLength top;
        public InitialLength right;
        public InitialLength bottom;
        public InitialLength left;

        public InitialLength topLeft
        {
            get => top;
            set => top = value;
        }
        public InitialLength topRight
        {
            get => right;
            set => right = value;
        }
        public InitialLength bottomRight
        {
            get => bottom;
            set => bottom = value;
        }
        public InitialLength bottomLeft
        {
            get => left;
            set => left = value;
        }
        
        public InitialLengthsShorthand(InitialLength value) : this(value, value, value, value) { }
        
        public InitialLengthsShorthand(InitialLength topBottom, InitialLength leftRight) : this(topBottom, leftRight, topBottom, leftRight) { }
        
        public InitialLengthsShorthand(InitialLength top, InitialLength leftRight, InitialLength bottom) : this(top, leftRight, bottom, leftRight) { }

        public InitialLengthsShorthand(InitialLength top, InitialLength right, InitialLength bottom, InitialLength left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public static implicit operator InitialLengthsShorthand(float value) => new (value);
        public static implicit operator InitialLengthsShorthand(InitialLength value) => new (value);
        public static implicit operator InitialLengthsShorthand((float, float) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialLengthsShorthand((InitialLength, InitialLength) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialLengthsShorthand(Vector2 values) => new (values.x, values.y);
        public static implicit operator InitialLengthsShorthand((float, float, float) values) => new (values.Item1, values.Item2, values.Item3);
        public static implicit operator InitialLengthsShorthand((InitialLength, InitialLength, InitialLength) values) => new (values.Item1, values.Item2, values.Item3);
        public static implicit operator InitialLengthsShorthand(Vector3 values) => new (values.x, values.y, values.z);
        public static implicit operator InitialLengthsShorthand((float, float, float, float) values) => new (values.Item1, values.Item2, values.Item3, values.Item4);
        public static implicit operator InitialLengthsShorthand((InitialLength, InitialLength, InitialLength, InitialLength) values) => new (values.Item1, values.Item2, values.Item3, values.Item4);
        public static implicit operator InitialLengthsShorthand(Vector4 values) => new (values.x, values.y, values.z, values.w);

        public override string ToString() => $"({top}, {right}, {bottom}, {left})";
    }
    
    public struct InitialColorsShorthand
    {
        public InitialColor top;
        public InitialColor right;
        public InitialColor bottom;
        public InitialColor left;

        public InitialColorsShorthand(InitialColor value) : this(value, value, value, value) { }
        
        public InitialColorsShorthand(InitialColor topBottom, InitialColor leftRight) : this(topBottom, leftRight, topBottom, leftRight) { }
        
        public InitialColorsShorthand(InitialColor top, InitialColor leftRight, InitialColor bottom) : this(top, leftRight, bottom, leftRight) { }

        public InitialColorsShorthand(InitialColor top, InitialColor right, InitialColor bottom, InitialColor left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public static implicit operator InitialColorsShorthand(bool animate) => new (animate);
        public static implicit operator InitialColorsShorthand(Color value) => new (value);
        public static implicit operator InitialColorsShorthand(InitialColor value) => new (value);
        public static implicit operator InitialColorsShorthand((Color, Color) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialColorsShorthand((InitialColor, InitialColor) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialColorsShorthand((Color, Color, Color) values) => new (values.Item1, values.Item2, values.Item3);
        public static implicit operator InitialColorsShorthand((InitialColor, InitialColor, InitialColor) values) => new (values.Item1, values.Item2, values.Item3);
        public static implicit operator InitialColorsShorthand((Color, Color, Color, Color) values) => new (values.Item1, values.Item2, values.Item3, values.Item4);
        public static implicit operator InitialColorsShorthand((InitialColor, InitialColor, InitialColor, InitialColor) values) => new (values.Item1, values.Item2, values.Item3, values.Item4);

        public override string ToString() => $"({top}, {right}, {bottom}, {left})";
    }
    
    public struct InitialFlexShorthand
    {
        public InitialFloat grow;
        public InitialFloat shrink;
        public InitialLength basis;

        public InitialFlexShorthand(InitialFloat grow) : this(grow, 1, 0) { }
        public InitialFlexShorthand(InitialLength basis) : this(1, 1, basis) { }
        public InitialFlexShorthand(InitialFloat grow, InitialFloat shrink) : this(grow, shrink, default) { }
        public InitialFlexShorthand(InitialFloat grow, InitialLength basis) : this(grow, default, basis) { }
        public InitialFlexShorthand(InitialFloat grow, InitialFloat shrink, InitialLength basis)
        {
            this.grow = grow;
            this.shrink = shrink;
            this.basis = basis;
        }

        public static implicit operator InitialFlexShorthand(InitialFloat grow) => new (grow);
        public static implicit operator InitialFlexShorthand(InitialLength basis) => new (basis);
        public static implicit operator InitialFlexShorthand((InitialFloat, InitialFloat) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialFlexShorthand((InitialFloat, InitialLength) values) => new (values.Item1, values.Item2);
        public static implicit operator InitialFlexShorthand((InitialFloat, InitialFloat, InitialLength) values) => new (values.Item1, values.Item2, values.Item3);

        public override string ToString() => $"({grow}, {shrink}, {basis})";
    }
}