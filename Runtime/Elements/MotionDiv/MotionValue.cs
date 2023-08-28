using System;
using System.Reflection;
using Motion;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;
using StyleInt = UnityEngine.UIElements.StyleInt;
using StyleFloat = UnityEngine.UIElements.StyleFloat;
using StyleLength = UnityEngine.UIElements.StyleLength;
using StyleColor = UnityEngine.UIElements.StyleColor;
using StyleRotate = UnityEngine.UIElements.StyleRotate;
using StyleScale = UnityEngine.UIElements.StyleScale;
using StyleTransformOrigin = UnityEngine.UIElements.StyleTransformOrigin;
using StyleTranslate = UnityEngine.UIElements.StyleTranslate;

namespace Roots
{
    public enum PropertyType { Physical, NonPhysical }

    public abstract class MotionValue<T, TI, TS, TSA, TTA> where T : struct, IEquatable<T> where TI : struct, IInitialValue<T> where TS : struct, IStyleValue<T> where TSA : SpringAnimation<T>, new() where TTA : TweenAnimation<T>, new()
    {
        private delegate void IntSetter(IStyle style, StyleInt value);
        private delegate void FloatSetter(IStyle style, StyleFloat value);
        private delegate void LengthSetter(IStyle style, StyleLength value);
        private delegate void ColorSetter(IStyle style, StyleColor value);
        private delegate void RotateSetter(IStyle style, StyleRotate value);
        private delegate void ScaleSetter(IStyle style, StyleScale value);
        private delegate void TransformOriginSetter(IStyle style, StyleTransformOrigin value);
        private delegate void TranslateSetter(IStyle style, StyleTranslate value);

        private string PropertyName { get; }
        private Delegate InlineSetter { get; }
        private PropertyType PropertyType { get; }

        protected VisualElement Element { get; private set; }
        private bool Initialized => Element != null;
        
        private T? _value;
        private T Value
        {
            get => _value.Value;
            set
            {
                _value = value;

                switch (value)
                {
                    case int intValue:
                        ((IntSetter) InlineSetter).Invoke(Element.style, intValue);
                        break;
                    case float floatValue:
                        ((FloatSetter) InlineSetter).Invoke(Element.style, floatValue);
                        break;
                    case Length lengthValue:
                        ((LengthSetter) InlineSetter).Invoke(Element.style, lengthValue);
                        break;
                    case Color colorValue:
                        ((ColorSetter) InlineSetter).Invoke(Element.style, colorValue);
                        break;
                    case Angle rotateValue:
                        ((RotateSetter) InlineSetter).Invoke(Element.style, new Rotate(rotateValue));
                        break;
                    case Vector3 scaleValue:
                        ((ScaleSetter) InlineSetter).Invoke(Element.style, new Scale(scaleValue));
                        break;
                    case TransformOrigin transformOriginValue:
                        ((TransformOriginSetter) InlineSetter).Invoke(Element.style, transformOriginValue);
                        break;
                    case Translate translateValue:
                        ((TranslateSetter) InlineSetter).Invoke(Element.style, translateValue);
                        break;
                }
            }
        }
        
        private AnimationId Animation { get; set; }

        protected MotionValue(string propertyName, PropertyType propertyType)
        {
            var type = typeof(T);
            
            PropertyName = propertyName;
            
            var inlinePropertyInfo = typeof(IStyle).GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
            if (inlinePropertyInfo == null)
            {
                throw new ArgumentException("Invalid property");
            }
            
            Type setterType;
            if (type == typeof(int))
            {
                setterType = typeof(IntSetter);
            } else if (type == typeof(float))
            {
                setterType = typeof(FloatSetter);
            } else if (type == typeof(Length))
            {
                setterType = typeof(LengthSetter);
            } else if (type == typeof(Color))
            {
                setterType = typeof(ColorSetter);
            } else if (type == typeof(Angle))
            {
                setterType = typeof(RotateSetter);
            } else if (type == typeof(Vector3))
            {
                setterType = typeof(ScaleSetter);
            } else if (type == typeof(TransformOrigin))
            {
                setterType = typeof(TransformOriginSetter);
            } else if (type == typeof(Translate))
            {
                setterType = typeof(TranslateSetter);
            } else
            {
                throw new ArgumentException("Invalid type");
            }
            
            InlineSetter = Delegate.CreateDelegate(setterType, inlinePropertyInfo.GetSetMethod());

            PropertyType = propertyType;
        }

        public void Reset()
        {
            Element = null;
            _value = null;
            Animation.Stop();
        }

        private T GetValue() => Value;
        private void SetValue(T value) => Value = value;
        
        public void Init(VisualElement element, TS inline, TS resolved)
        {
            if (Initialized)
            {
                throw new UnityException("Already initialized");
            }
            
            Element = element;

            if (inline.keyword == RishStyleKeyword.Undefined)
            {
                _value = inline.value;
            }
            else if(resolved.keyword == RishStyleKeyword.Undefined)
            {
                _value = resolved.value;
            }
        } 

        public bool Animate(T? target, TransitionDetails transition, TransitionDetails defaultTransition, out AnimationId animation)
        {
            if (!Initialized)
            {
                throw new UnityException("Not initialized");
            }

            if (!target.HasValue)
            {
                animation = default;
                return false;
            }
            
            var value = target.Value;
            if (!_value.HasValue)
            {
                Value = value;
                animation = default;
                
                return false;
            }
            
            var transitionDetails = CreateTransitionDetails(transition, defaultTransition, PropertyType);
            
            Value = Adjust(Value, value).Value;
            
            switch (transitionDetails.type)
            {
                case TransitionType.Spring:
                    T? velocity = null;
                    if (Animation.IsActive())
                    {
                        if (Animation.Is<Animation<T>>(out var current))
                        {
                            velocity = current.Velocity;
                        }
                    }
                    velocity = Adjust(velocity, value);
                    
                    var springAnimation = DoMotion.Spring<T, TSA>(GetValue, SetValue, value, transitionDetails.spring);
                    if (velocity.HasValue)
                    {
                        springAnimation.SetInitialVelocity(velocity.Value);
                    }
        
                    animation = springAnimation;
                    break;
                case TransitionType.Tween:
                    animation = DoMotion.Tween<T, TTA>(GetValue, SetValue, value, transitionDetails.tween);
                    break;
                case TransitionType.None:
                    animation = DoMotion.Tween<T, TTA>(GetValue, SetValue, value, new Tween
                    {
                        duration = 0,
                        ease = Ease.Linear
                    });
                    break;
                default:
                    throw new UnityException("Transition type not supported");
            }
            if (animation.Is<Animation<T>>(out var typedAnimation))
            {
                if (transitionDetails.delay.HasValue)
                {
                    var delay = transitionDetails.delay.Value;
                    typedAnimation.SetDelay(delay);
                }

                if (transitionDetails.repeat.HasValue)
                {
                    var repeat = transitionDetails.repeat.Value;
                    if (repeat.count != 0)
                    {
                        typedAnimation.SetLoops(repeat.count > 0 ? repeat.count + 1 : -1, repeat.loopType);
                    }
                    typedAnimation.SetInterval(repeat.interval, repeat.intervalDelay);
                }
            }

            Animation.Stop();
            Animation = animation;
        
            return true;
            
            static TransitionDetails CreateTransitionDetails(TransitionDetails specific, TransitionDetails generic, PropertyType propertyType)
            {
                var transition = specific.type != TransitionType.Default ? specific : generic;
                if (transition.type == TransitionType.Default)
                {
                    transition = propertyType == PropertyType.Physical
                        ? new TransitionDetails(Spring.Default)
                        : new TransitionDetails(Tween.Default);
                }
                
                transition.delay = specific.delay ?? generic.delay;
                transition.repeat = specific.repeat ?? generic.repeat;

                return transition;
            }
        }

        protected virtual T? Adjust(T? value, T target) => value;
    }

    // TODO: Sort all these classes alphabetically
    
    public class MotionFloat : MotionValue<float, InitialFloat, RishUI.StyleFloat, FloatSpring, FloatTween>
    {
        public MotionFloat(string propertyName, PropertyType propertyType) : base(propertyName, propertyType) { }
    }

    public class MotionInt : MotionValue<int, InitialInt, RishUI.StyleInt, IntSpring, IntTween>
    {
        public MotionInt(string propertyName) : base(propertyName, PropertyType.NonPhysical) { }
    }

    public class MotionLength : MotionValue<Length, InitialLength, RishUI.StyleLength, LengthSpring, LengthTween>
    {
        private Func<VisualElement, float> BasisGetter { get; }
        
        public MotionLength(string propertyName, Func<VisualElement, float> basisGetter) : base(propertyName, PropertyType.Physical)
        {
            BasisGetter = basisGetter ?? throw new ArgumentException("Length properties need a basis for percentage values");
        }

        protected override Length? Adjust(Length? value, Length target) => !value.HasValue 
            ? new Length(0, target.unit)
            : Fix(value.Value, target.unit, BasisGetter.Invoke(Element));

        private static Length Fix(Length value, LengthUnit unit, float basis)
        {
            if (value.unit == unit)
            {
                return value;
            }

            return unit switch
            {
                LengthUnit.Percent => new Length(value.value / basis * 100, LengthUnit.Percent),
                LengthUnit.Pixel => new Length(value.value / 100 * basis, LengthUnit.Pixel),
                _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, "Invalid unit")
            };
        }
    }

    public class MotionColor : MotionValue<Color, InitialColor, RishUI.StyleColor, ColorSpring, ColorTween>
    {
        public MotionColor(string propertyName) : base(propertyName, PropertyType.NonPhysical) { }
    }

    public class MotionRotate : MotionValue<Angle, InitialRotate, RishUI.StyleRotate, AngleSpring, AngleTween>
    {
        public MotionRotate(string propertyName) : base(propertyName, PropertyType.Physical) { }
    }

    public class MotionScale : MotionValue<Vector3, InitialScale, RishUI.StyleScale, Vector3Spring, Vector3Tween>
    {
        public MotionScale(string propertyName) : base(propertyName, PropertyType.Physical) { }
    }

    public class MotionTransformOrigin : MotionValue<TransformOrigin, InitialTransformOrigin, RishUI.StyleTransformOrigin, TransformOriginSpring, TransformOriginTween>
    {
        public MotionTransformOrigin(string propertyName) : base(propertyName, PropertyType.Physical) { }

        protected override TransformOrigin? Adjust(TransformOrigin? value, TransformOrigin target)
        {
            Length x, y;
            float z;
            if (!value.HasValue)
            {
                x = new Length(0, target.x.unit);
                y = new Length(0, target.y.unit);
                z = 0;
            } else
            {
                x = Fix(value.Value.x, target.x.unit, Element.layout.width);
                y = Fix(value.Value.y, target.y.unit, Element.layout.height);
                z = value.Value.z;
            }

            return new TransformOrigin(x, y, z);
        }

        private static Length Fix(Length value, LengthUnit unit, float basis)
        {
            if (value.unit == unit)
            {
                return value;
            }

            return unit switch
            {
                LengthUnit.Percent => new Length(value.value / basis * 100, LengthUnit.Percent),
                LengthUnit.Pixel => new Length(value.value / 100 * basis, LengthUnit.Pixel),
                _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, "Invalid unit")
            };
        }
    }

    public class MotionTranslate : MotionValue<Translate, InitialTranslate, RishUI.StyleTranslate, TranslateSpring, TranslateTween>
    {
        public MotionTranslate(string propertyName) : base(propertyName, PropertyType.Physical) { }

        protected override Translate? Adjust(Translate? value, Translate target)
        {
            Length x, y;
            float z;
            if (!value.HasValue)
            {
                x = new Length(0, target.x.unit);
                y = new Length(0, target.y.unit);
                z = 0;
            } else
            {
                x = Fix(value.Value.x, target.x.unit, Element.layout.width);
                y = Fix(value.Value.y, target.y.unit, Element.layout.height);
                z = value.Value.z;
            }

            return new Translate(x, y, z);
        }

        private static Length Fix(Length value, LengthUnit unit, float basis)
        {
            if (value.unit == unit)
            {
                return value;
            }

            return unit switch
            {
                LengthUnit.Percent => new Length(value.value / basis * 100, LengthUnit.Percent),
                LengthUnit.Pixel => new Length(value.value / 100 * basis, LengthUnit.Pixel),
                _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, "Invalid unit")
            };
        }
    }
    
    public class IntSpring : SpringAnimation<int>
    {
        protected override int Add(int a, int b) => a + b;

        protected override int Subtract(int a, int b) => a - b;

        protected override int Multiply(int a, float b) => Mathf.RoundToInt(a * b);

        protected override float SqrMagnitude(int a) => a * a;
    }
    
    public class LengthSpring : SpringAnimation<Length>
    {
        protected override Length Add(Length a, Length b) => a.unit != b.unit ? throw new ArgumentException("Both Lengths must have the same unit") : new Length(a.value + b.value, a.unit);

        protected override Length Subtract(Length a, Length b) => a.unit != b.unit ? throw new ArgumentException("Both Lengths must have the same unit") : new Length(a.value - b.value, a.unit);

        protected override Length Multiply(Length a, float b) => new (a.value * b, a.unit);

        protected override float SqrMagnitude(Length a) => a.value * a.value;
    }
        
    public class LengthTween : TweenAnimation<Length>
    {
        protected override Length LinearInterpolation(Length a, Length b, float t) => a.unit != b.unit ? throw new ArgumentException("Both Lengths must have the same unit") : new Length(Mathf.Lerp(a.value, b.value, t), a.unit);

        protected override Length GetVelocity(Length a, Length b, float dt) => a.unit != b.unit ? throw new ArgumentException("Both Lengths must have the same unit") : new Length((b.value - a.value) / dt, a.unit);
    }
    
    public class AngleSpring : SpringAnimation<Angle>
    {
        protected override Angle Add(Angle a, Angle b) => a.ToDegrees() + b.ToDegrees();

        protected override Angle Subtract(Angle a, Angle b) => a.ToDegrees() - b.ToDegrees();

        protected override Angle Multiply(Angle a, float b) => a.ToDegrees() * b;

        protected override float SqrMagnitude(Angle a) => a.ToDegrees() * a.ToDegrees();
    }
        
    public class AngleTween : TweenAnimation<Angle>
    {
        protected override Angle LinearInterpolation(Angle a, Angle b, float t) => Mathf.Lerp(a.ToDegrees(), b.ToDegrees(), t);

        protected override Angle GetVelocity(Angle a, Angle b, float dt) => (b.ToDegrees() - a.ToDegrees()) / dt;
    }
    
    public class TransformOriginSpring : SpringAnimation<TransformOrigin>
    {
        protected override TransformOrigin Add(TransformOrigin a, TransformOrigin b)
        {
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.x = {a.x} and b.x = {b.x}")
                : new Length(a.x.value + b.x.value, a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.y = {a.y} and b.y = {b.y}")
                : new Length(a.y.value + b.y.value, a.y.unit);
            var z = a.z + b.z;

            return new TransformOrigin(x, y, z);
        }

        protected override TransformOrigin Subtract(TransformOrigin a, TransformOrigin b)
        {
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.x = {a.x} and b.x = {b.x}")
                : new Length(a.x.value - b.x.value, a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.y = {a.y} and b.y = {b.y}")
                : new Length(a.y.value - b.y.value, a.y.unit);
            var z = a.z - b.z;

            return new TransformOrigin(x, y, z);
        }

        protected override TransformOrigin Multiply(TransformOrigin a, float b)
        {
            var x = new Length(a.x.value * b, a.x.unit);
            var y = new Length(a.y.value * b, a.y.unit);
            var z = a.z * b;

            return new TransformOrigin(x, y, z);
        }

        protected override float SqrMagnitude(TransformOrigin a)
        {
            var xSqr = a.x.value * a.x.value;
            var ySqr = a.y.value * a.y.value;
            var zSqr = a.z * a.z;

            return xSqr + ySqr + zSqr;
        }
    }
        
    public class TransformOriginTween : TweenAnimation<TransformOrigin>
    {
        protected override TransformOrigin LinearInterpolation(TransformOrigin a, TransformOrigin b, float t)
        {
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.x = {a.x} and b.x = {b.x}")
                : new Length(Mathf.Lerp(a.x.value, b.x.value, t), a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.y = {a.y} and b.y = {b.y}")
                : new Length(Mathf.Lerp(a.y.value, b.y.value, t), a.y.unit);
            var z = Mathf.Lerp(a.z, b.z, t);

            return new TransformOrigin(x, y, z);
        }

        protected override TransformOrigin GetVelocity(TransformOrigin a, TransformOrigin b, float dt)
        {
            var inv = 1 / dt;
            
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.x = {a.x} and b.x = {b.x}")
                : new Length((b.x.value - a.x.value) * inv, a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException($"Both Lengths must have the same unit. Instead: a.y = {a.y} and b.y = {b.y}")
                : new Length((b.y.value - a.y.value) * inv, a.y.unit);
            var z = (b.z - a.z) * inv;

            return new TransformOrigin(x, y, z);
        }
    }
    
    public class TranslateSpring : SpringAnimation<Translate>
    {
        protected override Translate Add(Translate a, Translate b)
        {
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length(a.x.value + b.x.value, a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length(a.y.value + b.y.value, a.y.unit);
            var z = a.z + b.z;

            return new Translate(x, y, z);
        }

        protected override Translate Subtract(Translate a, Translate b)
        {
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length(a.x.value - b.x.value, a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length(a.y.value - b.y.value, a.y.unit);
            var z = a.z - b.z;

            return new Translate(x, y, z);
        }

        protected override Translate Multiply(Translate a, float b)
        {
            var x = new Length(a.x.value * b, a.x.unit);
            var y = new Length(a.y.value * b, a.y.unit);
            var z = a.z * b;

            return new Translate(x, y, z);
        }

        protected override float SqrMagnitude(Translate a)
        {
            var xSqr = a.x.value * a.x.value;
            var ySqr = a.y.value * a.y.value;
            var zSqr = a.z * a.z;

            return xSqr + ySqr + zSqr;
        }
    }
        
    public class TranslateTween : TweenAnimation<Translate>
    {
        protected override Translate LinearInterpolation(Translate a, Translate b, float t)
        {
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length(Mathf.Lerp(a.x.value, b.x.value, t), a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length(Mathf.Lerp(a.y.value, b.y.value, t), a.y.unit);
            var z = Mathf.Lerp(a.z, b.z, t);

            return new Translate(x, y, z);
        }

        protected override Translate GetVelocity(Translate a, Translate b, float dt)
        {
            var inv = 1 / dt;
            
            var x = a.x.unit != b.x.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length((b.x.value - a.x.value) * inv, a.x.unit);
            var y = a.y.unit != b.y.unit
                ? throw new ArgumentException("Both Lengths must have the same unit")
                : new Length((b.y.value - a.y.value) * inv, a.y.unit);
            var z = (b.z - a.z) * inv;

            return new Translate(x, y, z);
        }
    }
}