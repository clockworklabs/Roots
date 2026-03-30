using RishUI;

namespace Roots.Rootstrap
{
    public struct ProgressBar
    {
        public float value;
        public ProgressColor? color;
        public RishString label;

        public ProgressBar(float value, ProgressColor? color = null, RishString label = default)
        {
            this.value = value;
            this.color = color;
            this.label = label;
        }

        public static implicit operator ProgressBar(float value) => new()
        {
            value = value
        };
    }
}