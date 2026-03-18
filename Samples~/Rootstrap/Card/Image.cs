using System;
using RishUI;
using RishUI.MemoryManagement;
using Sappy;
using UnityEngine.UIElements;

namespace Roots.Rootstrap
{
    public partial class Card
    {
        private partial class Image : RishElement<ImageProps>, IVisualManipulator, IMountingListener
        {
            private VisualElement _visualChild;
            private VisualElement VisualChild
            {
                get => _visualChild;
                set
                {
                    if (_visualChild == value) return;

                    _visualChild?.UnregisterCallback(Sappy.OnDetachFromPanel.Callback);
                    _visualChild = value;
                    if (value != null)
                    {
                        value.RegisterCallback(Sappy.OnDetachFromPanel.Callback);
                        OnValid(true);
                    }
                    else
                    {
                        OnValid(false);
                    }
                }
            }
            
            bool IVisualManipulator.Evaluate(VisualElement descendant)
            {
                if (descendant != GetVisualChild()) return false;
                VisualChild = descendant;
                return true;
            }
            void IVisualManipulator.Manipulate(VisualManipulationPhase phase, IManipulable descendant)
            {
                if (phase == VisualManipulationPhase.TrickleDown) return;
                using(ManagedContext.New())
                {
                    descendant.AddClassName("card-img");
                }
            }
            
            void IMountingListener.ElementDidMount() { }
            void IMountingListener.ElementWillUnmount()
            {
                VisualChild = null;
            }
        
            protected override Element Render() => Props.content;

            [SapTarget(typeof(EventCallback<DetachFromPanelEvent>))]
            private void OnDetachFromPanel(DetachFromPanelEvent evt)
            {
                if (evt.target != VisualChild) return;
                VisualChild = null;
            }
        }

        [RishValueType]
        internal struct ImageProps
        {
            public Element content;

            public Action<bool> onValid;
        }
    }
}