using System;
using RishUI;
using Sappy;
using UnityEngine.UIElements;

namespace Roots
{
    public interface IAnimatedElement
    {
        void OnAnimateComplete();
        void OnExitComplete();

        IAnimatedElement Parent { get; }
        StyleAnimation StyleAnimation { get; }

        void Unmount();
        void SetStyle(Style style);
    }
    
    public partial class StyleAnimation
    {
        private SapStem<VisualElement> OnChangeStem { get; } = new();
        [SapEvent]
        private event Action<VisualElement> OnChange { add => OnChangeStem.AddTarget(value); remove => OnChangeStem.RemoveTarget(value); }
        private SapStem<Target> OnTargetStem { get; } = new();
        [SapEvent]
        private event Action<Target> OnTarget { add => OnTargetStem.AddTarget(value); remove => OnTargetStem.RemoveTarget(value); }
        private SapStem OnMountedStem { get; } = new();
        [SapEvent]
        private event Action OnMounted { add => OnMountedStem.AddTarget(value); remove => OnMountedStem.RemoveTarget(value); }
        private SapStem OnUnmountRequestedStem { get; } = new();
        [SapEvent]
        private event Action OnUnmountRequested { add => OnUnmountRequestedStem.AddTarget(value); remove => OnUnmountRequestedStem.RemoveTarget(value); }
        private SapStem OnUnmountedStem { get; } = new();
        [SapEvent]
        private event Action OnUnmounted { add => OnUnmountedStem.AddTarget(value); remove => OnUnmountedStem.RemoveTarget(value); }

        private IAnimatedElement Element { get; }
        private Motion Motion { get; }
        private StateMachine Machine { get; }

        private Target Animate { get; set; }
        private Target Exit { get; set; }

        public StyleAnimation(IAnimatedElement element)
        {
            Element = element;
            Motion = new Motion();
            Machine = new StateMachine(this);
            Motion.OnStyle += SappyOnStyle;
            Motion.Completed += SappyOnMotionComplete;
        }

        [SapTarget]
        private void OnMotionComplete()
        {
            if (Machine.IsIn<ActiveState>())
            {
                Element.OnAnimateComplete();
            }
            else
            {
                Element.OnExitComplete();
            }
        }

        private void Reset()
        {
            Motion.Reset();

            Animate = default;
            Exit = default;
        }

        public void OnVisualChange(VisualElement target) => OnChangeStem.Send(target);

        public void SetAnimate(Target animate)
        {
            Animate = animate;
            OnTargetStem.Send(animate);
        }
        public void SetExit(Target exit)
        {
            Exit = exit;
        }

        public void Mounted() => OnMountedStem.Send();
        public void UnmountRequested() => OnUnmountRequestedStem.Send();
        public void Unmounted() => OnUnmountedStem.Send();
        
        private StyleAnimation GetParent() => Element.Parent?.StyleAnimation;

        private void Unmount() => Element.Unmount();

        [SapTarget]
        private void OnStyle(Style style) => Element.SetStyle(style);

        private partial class StateMachine
        {
            private SapStem<State> OnChangeStem { get; } = new();
            public event Action<State> OnChange { add => OnChangeStem.AddTarget(value); remove => OnChangeStem.RemoveTarget(value); }
            
            private UnmountedState UnmountedState { get; }
            private SettingUpState SettingUpState { get; }
            private ActiveState ActiveState { get; }
            private UnmountingState UnmountingState { get; }

            private State Current { get; set; }

            public StateMachine(StyleAnimation element)
            {
                UnmountedState = new UnmountedState(this, element);
                SettingUpState = new SettingUpState(this, element);
                ActiveState = new ActiveState(this, element);
                UnmountingState = new UnmountingState(this, element);

                GoTo<UnmountedState>();
            }

            public void GoTo<TS>() where TS : State
            {
                var next = Get<TS>();
                if (next == null)
                {
                    throw new ArgumentException("Invalid state");
                }

                Current?.Exit();
                Current = next;
                next.Enter();
                
                OnChangeStem.Send(next);
            }

            private State Get<TS>() where TS : State
            {
                if (UnmountedState is TS)
                {
                    return UnmountedState;
                }
                if (SettingUpState is TS)
                {
                    return SettingUpState;
                }
                if (ActiveState is TS)
                {
                    return ActiveState;
                }
                if (UnmountingState is TS)
                {
                    return UnmountingState;
                }

                return null;
            }

            public bool IsIn<TS>() where TS : State => Current is TS;
        }

        private abstract class State
        {
            private StateMachine Machine { get; }
            protected StyleAnimation Element { get; }
            protected Motion Motion { get; }

            protected State(StateMachine machine, StyleAnimation element)
            {
                Machine = machine;
                Element = element;
                Motion = element.Motion;
            }

            public abstract void Enter();
            public abstract void Exit();

            protected void GoTo<TS>() where TS : State => Machine.GoTo<TS>();
        }

        private partial class UnmountedState : State
        {
            public UnmountedState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Element.Reset();
                Element.OnMounted += SappyStartSetUp;
            }

            public override void Exit() {
                Element.OnMounted -= SappyStartSetUp;
            }

            [SapTarget]
            private void StartSetUp() => GoTo<SettingUpState>();
        }

        private partial class SettingUpState : State
        {
            private bool _ready;
            private bool Ready
            {
                get => _ready;
                set
                {
                    _ready = value;

                    if (value && ParentReady)
                    {
                        GoToActive();
                    }
                }
            }
            private bool _parentReady;
            private bool ParentReady
            {
                get => _parentReady;
                set
                {
                    _parentReady = value;

                    if (value && Ready)
                    {
                        GoToActive();
                    }
                }
            }
            
            private StateMachine ParentMachine { get; set; }
            
            public SettingUpState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Ready = false;
                ParentReady = false;
                ParentMachine = null;
                
                Element.OnChange += SappyOnChange;
                Element.OnUnmountRequested += SappyUnmount;
                Element.OnUnmounted += SappyOnUnmounted;
            }

            public override void Exit()
            {
                Element.OnChange -= SappyOnChange;
                Element.OnUnmountRequested -= SappyUnmount;
                Element.OnUnmounted -= SappyOnUnmounted;

                if (ParentMachine != null)
                {
                    ParentMachine.OnChange -= OnParentStateChange;
                }
            }

            [SapTarget]
            private void OnChange(VisualElement element)
            {
                Element.OnChange -= SappyOnChange;
                
                var parent = Element.GetParent();

                if (parent == null || parent.Machine.IsIn<ActiveState>())
                {
                    ParentReady = true;
                }
                else
                {
                    ParentMachine = parent.Machine;
                    ParentMachine.OnChange += OnParentStateChange;
                }
                
                Motion.SetInitial(element, parent?.Motion);
                
                Ready = true;
            }

            private void OnParentStateChange(State state)
            {
                if (state is ActiveState)
                {
                    ParentMachine.OnChange -= OnParentStateChange;
                    ParentReady = true;
                }
            }
            
            private void GoToActive()
            {
                Motion.To(Element.Animate);
                GoTo<ActiveState>();
            }

            [SapTarget]
            private void Unmount() => Element.Unmount();
            [SapTarget]
            private void OnUnmounted() => GoTo<UnmountedState>();
        }

        private partial class ActiveState : State
        {
            public ActiveState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Element.OnTarget += SappyOnTarget;
                Element.OnUnmountRequested += SappyStartUnmounting;
                Element.OnUnmounted += SappyOnUnmounted;
            }

            public override void Exit()
            {
                Element.OnTarget -= SappyOnTarget;
                Element.OnUnmountRequested -= SappyStartUnmounting;
                Element.OnUnmounted -= SappyOnUnmounted;
            }

            [SapTarget]
            private void OnTarget(Target animate) => Motion.To(animate);
            [SapTarget]
            private void StartUnmounting() => GoTo<UnmountingState>();
            [SapTarget]
            private void OnUnmounted() => GoTo<UnmountedState>();
        }

        private partial class UnmountingState : State
        {
            public UnmountingState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Motion.Completed += SappyUnmount;
                Element.OnUnmounted += SappyOnUnmounted;

                if (Element.Exit.IsValid())
                {
                    // TODO: Maybe position absolute and fix layout?
                    Motion.To(Element.Exit);
                }
                else
                {
                    Unmount();
                }
            }

            public override void Exit()
            {
                Motion.Completed -= SappyUnmount;
                Element.OnUnmounted -= SappyOnUnmounted;
            }

            [SapTarget]
            private void Unmount() => Element.Unmount();
            [SapTarget]
            private void OnUnmounted() => GoTo<UnmountedState>();
        }
    }
}