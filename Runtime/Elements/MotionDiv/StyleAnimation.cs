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
        private SapTargets<Action<VisualElement>> OnChange => OnChangeStem.Targets;
        private SapStem<Target> OnTargetStem { get; } = new();
        private SapTargets<Action<Target>> OnTarget => OnTargetStem.Targets;
        private SapStem OnMountedStem { get; } = new();
        private SapTargets<Action> OnMounted => OnMountedStem.Targets;
        private SapStem OnUnmountRequestedStem { get; } = new();
        private SapTargets<Action> OnUnmountRequested => OnUnmountRequestedStem.Targets;
        private SapStem OnUnmountedStem { get; } = new();
        private SapTargets<Action> OnUnmounted => OnUnmountedStem.Targets;

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
            Motion.OnStyle.Add(Sappy.OnStyle);
            Motion.Completed.Add(Sappy.OnMotionComplete);
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
        private void OnStyle(Style style) =>  Element.SetStyle(style);

        private class StateMachine
        {
            private SapStem<State> OnChangeStem { get; } = new();
            public SapTargets<Action<State>> OnChange => OnChangeStem.Targets;
            
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
                Element.OnMounted.Add(Sappy.StartSetUp);
            }

            public override void Exit() {
                Element.OnMounted.Remove(Sappy.StartSetUp);
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
                
                Element.OnChange.Add(Sappy.OnChange);
                Element.OnUnmountRequested.Add(Sappy.Unmount);
                Element.OnUnmounted.Add(Sappy.OnUnmounted);
            }

            public override void Exit()
            {
                Element.OnChange.Remove(Sappy.OnChange);
                Element.OnUnmountRequested.Remove(Sappy.Unmount);
                Element.OnUnmounted.Remove(Sappy.OnUnmounted);

                if (ParentMachine != null)
                {
                    ParentMachine.OnChange.Remove(Sappy.OnParentStateChange);
                }
            }

            [SapTarget]
            private void OnChange(VisualElement element)
            {
                Element.OnChange.Remove(Sappy.OnChange);
                
                var parent = Element.GetParent();

                if (parent == null || parent.Machine.IsIn<ActiveState>())
                {
                    ParentReady = true;
                }
                else
                {
                    ParentMachine = parent.Machine;
                    ParentMachine.OnChange.Add(Sappy.OnParentStateChange);
                }

                Motion.SetInitial(element, parent?.Motion);
                
                Ready = true;
            }

            [SapTarget]
            private void OnParentStateChange(State state)
            {
                if (state is ActiveState)
                {
                    ParentMachine.OnChange.Remove(Sappy.OnParentStateChange);
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
                Element.OnTarget.Add(Sappy.OnTarget);
                Element.OnUnmountRequested.Add(Sappy.StartUnmounting);
                Element.OnUnmounted.Add(Sappy.OnUnmounted);
            }

            public override void Exit()
            {
                Element.OnTarget.Remove(Sappy.OnTarget);
                Element.OnUnmountRequested.Remove(Sappy.StartUnmounting);
                Element.OnUnmounted.Remove(Sappy.OnUnmounted);
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
                Motion.Completed.Add(Sappy.Unmount);
                Element.OnUnmounted.Add(Sappy.OnUnmounted);

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
                Motion.Completed.Remove(Sappy.Unmount);
                Element.OnUnmounted.Remove(Sappy.OnUnmounted);
            }

            [SapTarget]
            private void Unmount() => Element.Unmount();
            [SapTarget]
            private void OnUnmounted() => GoTo<UnmountedState>();
        }
    }
}