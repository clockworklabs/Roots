using System;
using Motion;
using RishUI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots.WIP
{
    public abstract class MotionValue<T, TS, TSA, TTA> where T : struct, IEquatable<T> where TS : struct, IStyleValue<T> where TSA : SpringAnimation<T>, new() where TTA : TweenAnimation<T>, new()
    {
        private string PropertyName { get; }
        private PropertyType PropertyType { get; }

        protected VisualElement Element { get; private set; }
        private bool Initialized => Element != null;

        public T? Value { get; set; }
        
        private AnimationId Animation { get; set; }

        protected MotionValue(string propertyName, PropertyType propertyType)
        {
            PropertyName = propertyName;
            PropertyType = propertyType;
        }

        public void Reset()
        {
            Element = null;
            Value = null;
            Animation.Stop();
        }

        private T GetValue() => Value ?? default;
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
                Value = inline.value;
            }
            else if(resolved.keyword == RishStyleKeyword.Undefined)
            {
                Value = resolved.value;
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

    // TODO: Sort all these classes alphabetically
    
    public class MotionFloat : MotionValue<float, RishUI.StyleFloat, FloatSpring, FloatTween>
    {
        public MotionFloat(string propertyName, PropertyType propertyType) : base(propertyName, propertyType) { }
    }

    public class MotionInt : MotionValue<int, RishUI.StyleInt, IntSpring, IntTween>
    {
        public MotionInt(string propertyName) : base(propertyName, PropertyType.NonPhysical) { }
    }

    public class MotionLength : MotionValue<Length, RishUI.StyleLength, LengthSpring, LengthTween>
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

    public class MotionColor : MotionValue<Color, RishUI.StyleColor, ColorSpring, ColorTween>
    {
        public MotionColor(string propertyName) : base(propertyName, PropertyType.NonPhysical) { }
    }

    public class MotionRotate : MotionValue<Angle, RishUI.StyleRotate, AngleSpring, AngleTween>
    {
        public MotionRotate(string propertyName) : base(propertyName, PropertyType.Physical) { }
    }

    public class MotionScale : MotionValue<Vector3, RishUI.StyleScale, Vector3Spring, Vector3Tween>
    {
        public MotionScale(string propertyName) : base(propertyName, PropertyType.Physical) { }
    }

    public class MotionTransformOrigin : MotionValue<TransformOrigin, RishUI.StyleTransformOrigin, TransformOriginSpring, TransformOriginTween>
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

    public class MotionTranslate : MotionValue<Translate, RishUI.StyleTranslate, TranslateSpring, TranslateTween>
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
}