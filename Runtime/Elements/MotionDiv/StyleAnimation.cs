using System;
using RishUI;
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
    
    public class StyleAnimation
    {
        private event Action<VisualElement> OnChange;
        private event Action<Target> OnTarget;
        private event Action OnMounted;
        private event Action OnUnmountRequested;
        private event Action OnUnmounted;

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
            Motion.OnStyle += OnStyle;
            Motion.Completed += OnMotionComplete;
        }

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

        public void OnVisualChange(VisualElement target) => OnChange?.Invoke(target);

        public void SetAnimate(Target animate)
        {
            Animate = animate;
            OnTarget?.Invoke(animate);
        }
        public void SetExit(Target exit)
        {
            Exit = exit;
        }

        public void Mounted() => OnMounted?.Invoke();
        public void UnmountRequested() => OnUnmountRequested?.Invoke();
        public void Unmounted() => OnUnmounted?.Invoke();
        
        private StyleAnimation GetParent() => Element.Parent?.StyleAnimation;

        private void Unmount() => Element.Unmount();

        private void OnStyle(Style style) => Element.SetStyle(style);

        private class StateMachine
        {
            public event Action<State> OnChange;
            
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
                
                OnChange?.Invoke(next);
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

        private class UnmountedState : State
        {
            public UnmountedState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Element.Reset();
                Element.OnMounted += StartSetUp;
            }

            public override void Exit() {
                Element.OnMounted -= StartSetUp;
            }

            private void StartSetUp() => GoTo<SettingUpState>();
        }

        private class SettingUpState : State
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
                
                Element.OnChange += OnChange;
                Element.OnUnmountRequested += Unmount;
                Element.OnUnmounted += OnUnmounted;
            }

            public override void Exit()
            {
                Element.OnChange -= OnChange;
                Element.OnUnmountRequested -= Unmount;
                Element.OnUnmounted -= OnUnmounted;

                if (ParentMachine != null)
                {
                    ParentMachine.OnChange -= OnParentStateChange;
                }
            }

            private void OnChange(VisualElement element)
            {
                Element.OnChange -= OnChange;
                
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

            private void Unmount() => Element.Unmount();
            private void OnUnmounted() => GoTo<UnmountedState>();
        }

        private class ActiveState : State
        {
            public ActiveState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Element.OnTarget += OnTarget;
                Element.OnUnmountRequested += StartUnmounting;
                Element.OnUnmounted += OnUnmounted;
            }

            public override void Exit()
            {
                Element.OnTarget -= OnTarget;
                Element.OnUnmountRequested -= StartUnmounting;
                Element.OnUnmounted -= OnUnmounted;
            }

            private void OnTarget(Target animate) => Motion.To(animate);

            private void StartUnmounting() => GoTo<UnmountingState>();
            private void OnUnmounted() => GoTo<UnmountedState>();
        }

        private class UnmountingState : State
        {
            public UnmountingState(StateMachine machine, StyleAnimation element) : base(machine, element) { }

            public override void Enter()
            {
                Motion.Completed += Unmount;
                Element.OnUnmounted += OnUnmounted;

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
                Motion.Completed -= Unmount;
                Element.OnUnmounted -= OnUnmounted;
            }

            private void Unmount() => Element.Unmount();

            private void OnUnmounted() => GoTo<UnmountedState>();
        }
    }
}