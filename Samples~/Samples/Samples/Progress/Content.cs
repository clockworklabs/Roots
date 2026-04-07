using Motion;
using RishUI;
using Roots;
using Roots.Rootstrap;
using Sappy;
using UnityEngine;

namespace RootsSamples
{
    public partial class ProgressSample
    {
        public partial class Content : RishElement<NoProps, ContentState>, IMountingListener
        {
            void IMountingListener.ElementDidMount() => Randomize();
            void IMountingListener.ElementWillUnmount() { }
            
            protected override Element Render() => Col.Create(
                gap: 16,
                children: new Children
                {
                    SimpleProgress.Create(animated: false, value: State.v0, label: "Loading..."),
                    SimpleProgress.Create(value: State.v1),
                    SimpleProgress.Create(size: ProgressSize.Thin, value: State.v2),
                    SimpleProgress.Create(color: ProgressColor.Danger, value: State.v3),
                    SimpleProgress.Create(spring: Spring.Bouncy, value: State.v4, label: $"{Mathf.Ceil(State.v4 * 100)}%"),
                    StackedProgress.Create(values: new ()
                    {
                        new ProgressBar(State.v5),
                        new ProgressBar(State.v6, ProgressColor.Success),
                        new ProgressBar(State.v7, ProgressColor.Warning),
                    }),
                    Button.Create(variant: Button.Variant.Primary, size: Button.Size.Large, action: Sappy.Randomize, children: "Randomize"),
                });

            [SapTarget]
            private void Randomize()
            {
                SetV0(Random.value);
                SetV1(Random.value);
                SetV2(Random.value);
                SetV3(Random.value);
                SetV4(Random.value);
                SetV5(Random.value);
                SetV6(Random.Range(0, 1 - State.v5));
                SetV7(Random.Range(0, 1 - State.v5 - State.v6));
            }
        }

        [RishValueType]
        public struct ContentState
        {
            public float v0;
            public float v1;
            public float v2;
            public float v3;
            public float v4;
            public float v5;
            public float v6;
            public float v7;
        }
    }
}