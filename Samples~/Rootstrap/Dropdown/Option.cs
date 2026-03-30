using System;
using RishUI;
using Sappy;

namespace Roots.Rootstrap
{
    public partial class SimpleDropdown
    {
        public partial class Option : RishElement<OptionProps>
        {
            protected override Element Render() => Button.Create(
                action: Sappy.DoAction,
                variant: Button.Variant.Light,
                active: Props.active,
                children: Body.Create(className: Utilities.TextLeft(), text: Props.text));

            [SapTarget]
            private void DoAction() => Action(Props.index);
        }

        [RishValueType]
        public struct OptionProps
        {
            public bool active;
            public int index;
            public RishString text;

            public Action<int> action;
        }
    }
}