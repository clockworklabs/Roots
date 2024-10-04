using RishUI;

namespace Roots.Samples
{
    public partial class SamplesViewer : RishElement<SamplesViewerProps, SamplesViewerState>
    {
        protected override Element Render()
        {
            if(Props.samples.Count <= 0) return Element.Null;

            return Props.samples[State.index].content;
        }
    }

    [RishValueType]
    public struct SamplesViewerProps
    {
        public RishList<SampleDefinition> samples;
    }

    [RishValueType]
    public struct SamplesViewerState
    {
        public int index;
    }
}