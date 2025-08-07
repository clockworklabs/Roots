using System;
using Motion;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public enum PropertyType { Physical, NonPhysical }
     
    public abstract class MotionValue<T, TI, TS, TT> where T : struct, IEquatable<T> where TI : struct, RishUI.IStyleValue<T> where TS : SpringAnimation<T>, new() where TT : TweenAnimation<T>, new()
    {
        public delegate TI InlineGetter(IStyle inlineStyle);
        public delegate TI ResolvedGetter(IResolvedStyle resolvedStyle);
        public delegate void InlineSetter(IStyle inlineStyle, T value);
        
        private PropertyType PropertyType { get; }
        private InlineGetter Inline { get; }
        private ResolvedGetter Resolved { get; }
        private InlineSetter Setter { get; }

        protected VisualElement Element { get; private set; }
        private bool Initialized => Element != null;

        private T? _value;
        public T? Value
        {
            get => _value;
            private set
            {
                if(value != null)
                {
                    Setter(Element.style, value.Value);
                }
                _value = value;
            }
        }
        
        private AnimationId Animation { get; set; }

        protected MotionValue(PropertyType propertyType, InlineGetter inlineGetter, ResolvedGetter resolvedGetter, InlineSetter inlineSetter)
        {
            PropertyType = propertyType;
            Inline = inlineGetter;
            Resolved = resolvedGetter;
            Setter = inlineSetter;
        }

        public void Reset()
        {
            Animation.Stop();
            Element = null;
            Value = null;
        }

        private Func<T> _getValue;
        private Func<T> CachedGetValue => _getValue ??= GetValue;
        private T GetValue() => Value ?? default;
        private Action<T> _setValue;
        private Action<T> CachedSetValue => _setValue ??= SetValue;
        private void SetValue(T value) => Value = value;
        
        public void Init(VisualElement element)
        {
            if (Initialized)
            {
                throw new UnityException("Already initialized");
            }
            
            Element = element;
            
            var inline = Inline?.Invoke(element.style);
            if (inline is { keyword: RishStyleKeyword.Undefined })
            {
                Value = inline.Value.value;
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
            if (!Value.HasValue)
            {
                var resolved = Resolved?.Invoke(Element.resolvedStyle);
                if (resolved is { keyword: RishStyleKeyword.Undefined })
                {
                    Value = resolved.Value.value;
                }
                else
                {
                    Value = value;
                    animation = default;
                    return false;
                }
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
                    
                    var springAnimation = DoMotion.Spring<T, TS>(CachedGetValue, CachedSetValue, value, transitionDetails.spring);
                    if (velocity.HasValue)
                    {
                        springAnimation.SetInitialVelocity(velocity.Value);
                    }
        
                    animation = springAnimation;
                    break;
                case TransitionType.Tween:
                    animation = DoMotion.Tween<T, TT>(CachedGetValue, CachedSetValue, value, transitionDetails.tween);
                    break;
                case TransitionType.None:
                    Value = value;
                    animation = default;
                    return false;
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

    public class MotionColor : MotionValue<Color, RishUI.StyleColor, ColorSpring, ColorTween>
    {
        public MotionColor(InlineGetter inline, ResolvedGetter resolved, InlineSetter setter) : base(PropertyType.NonPhysical, inline, resolved, setter) { }
    }
    
    public class MotionFloat : MotionValue<float, RishUI.StyleFloat, FloatSpring, FloatTween>
    {
        public MotionFloat(PropertyType propertyType, InlineGetter inline, ResolvedGetter resolved, InlineSetter setter) : base(propertyType, inline, resolved, setter) { }
    }

    public class MotionInt : MotionValue<int, RishUI.StyleInt, IntSpring, IntTween>
    {
        public MotionInt(InlineGetter inline, ResolvedGetter resolved, InlineSetter setter) : base(PropertyType.NonPhysical, inline, resolved, setter) { }
    }

    public class MotionLength : MotionValue<Length, RishUI.StyleLength, LengthSpring, LengthTween>
    {
        public delegate float BasisGetter(VisualElement element);
        
        private BasisGetter Basis { get; }
        
        public MotionLength(InlineGetter inline, ResolvedGetter resolved, InlineSetter setter, BasisGetter basis) : base(PropertyType.Physical, inline, resolved, setter)
        {
            Basis = basis ?? throw new ArgumentException("Length properties need a basis for percentage values");
        }

        protected override Length? Adjust(Length? value, Length target) => !value.HasValue 
            ? new Length(0, target.unit)
            : Fix(value.Value, target.unit, Basis.Invoke(Element));

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

    public class MotionRotate : MotionValue<Angle, RishUI.StyleRotate, AngleSpring, AngleTween>
    {
        public MotionRotate(InlineGetter inline, ResolvedGetter resolved, InlineSetter setter) : base(PropertyType.Physical, inline, resolved, setter) { }
    }

    public class MotionScale : MotionValue<Vector3, RishUI.StyleScale, Vector3Spring, Vector3Tween>
    {
        public MotionScale(InlineGetter inline, ResolvedGetter resolved, InlineSetter setter) : base(PropertyType.Physical, inline, resolved, setter) { }
    }

    public class MotionTransformOrigin : MotionValue<TransformOrigin, RishUI.StyleTransformOrigin, TransformOriginSpring, TransformOriginTween>
    {
        public MotionTransformOrigin(InlineGetter inline, ResolvedGetter resolved, InlineSetter setter) : base(PropertyType.Physical, inline, resolved, setter) { }

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

    public class MotionTranslate : MotionValue<Translate, RishUI.StyleTranslate, TranslateSpring, TranslateTween>
    {
        public MotionTranslate(InlineGetter inline, ResolvedGetter resolved, InlineSetter setter) : base(PropertyType.Physical, inline, resolved, setter) { }

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