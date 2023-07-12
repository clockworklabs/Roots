using RishUI;

namespace Roots
{
    public partial class VStack : RishElement<VStackProps>
    {
        protected override Element Render() => Stack.Create(direction: StackDirection.Vertical, gap: Props.gap, smGap: Props.smGap, mdGap: Props.mdGap, lgGap: Props.lgGap, xlGap: Props.xlGap, xxlGap: Props.xxlGap, children: Props.children);
    }

    [RishValueType]
    public struct VStackProps
    {
        public int? gap;
        public int? smGap;
        public int? mdGap;
        public int? lgGap;
        public int? xlGap;
        public int? xxlGap;
        public Children children;
    }
}
