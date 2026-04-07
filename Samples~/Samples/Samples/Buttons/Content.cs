using RishUI;
using Roots;
using Roots.Rootstrap;
using Sappy;
using UnityEngine;

namespace RootsSamples
{
    public partial class ButtonsSample
    {
        public partial class Content : RishElement<NoProps, ContentState>
        {
            protected override Element Render() => Col.Create(
                gap: 16,
                children: new Children
                {
                    Group.Create(
                        title: "Variants",
                        children: new Children
                        {
                            Button.Create(action: Sappy.DoPrimary, variant: Button.Variant.Primary, children: "Primary"),
                            Button.Create(action: Sappy.DoSecondary, variant: Button.Variant.Secondary, children: "Secondary"),
                            Button.Create(action: Sappy.DoSuccess, variant: Button.Variant.Success, children: "Success"),
                            Button.Create(action: Sappy.DoDanger, variant: Button.Variant.Danger, children: "Danger"),
                            Button.Create(action: Sappy.DoWarning, variant: Button.Variant.Warning, children: "Warning"),
                            Button.Create(action: Sappy.DoInfo, variant: Button.Variant.Info, children: "Info"),
                            Button.Create(action: Sappy.DoLight, variant: Button.Variant.Light, children: "Light"),
                            Button.Create(action: Sappy.DoDark, variant: Button.Variant.Dark, children: "Dark"),
                            Button.Create(action: Sappy.DoLink, variant: Button.Variant.Link, children: "Link")
                        }),
                    Group.Create(
                        title: "Outline Buttons",
                        children: new Children
                        {
                            Button.Create(action: Sappy.DoPrimary, variant: Button.Variant.PrimaryOutline, children: "Primary"),
                            Button.Create(action: Sappy.DoSecondary, variant: Button.Variant.SecondaryOutline, children: "Secondary"),
                            Button.Create(action: Sappy.DoSuccess, variant: Button.Variant.SuccessOutline, children: "Success"),
                            Button.Create(action: Sappy.DoDanger, variant: Button.Variant.DangerOutline, children: "Danger"),
                            Button.Create(action: Sappy.DoWarning, variant: Button.Variant.WarningOutline, children: "Warning"),
                            Button.Create(action: Sappy.DoInfo, variant: Button.Variant.InfoOutline, children: "Info"),
                            Button.Create(action: Sappy.DoLight, variant: Button.Variant.LightOutline, children: "Light"),
                            Button.Create(action: Sappy.DoDark, variant: Button.Variant.DarkOutline, children: "Dark")
                        }),
                    Group.Create(
                        title: "Sizes",
                        children: new Children
                        {
                            Button.Create(action: Sappy.DoLarge, variant: Button.Variant.Primary, size: Button.Size.Large, children: "Large Button"),
                            Button.Create(action: Sappy.DoLarge, variant: Button.Variant.SecondaryOutline, size: Button.Size.Large, children: "Large Button"),
                            Button.Create(action: Sappy.DoRegular, variant: Button.Variant.Primary, size: Button.Size.Regular, children: "Regular Button"),
                            Button.Create(action: Sappy.DoRegular, variant: Button.Variant.SecondaryOutline, size: Button.Size.Regular, children: "Regular Button"),
                            Button.Create(action: Sappy.DoSmall, variant: Button.Variant.Primary, size: Button.Size.Small, children: "Small Button"),
                            Button.Create(action: Sappy.DoSmall, variant: Button.Variant.SecondaryOutline, size: Button.Size.Small, children: "Small Button")
                        }),
                    Group.Create(
                        title: "Disabled",
                        children: new Children
                        {
                            Button.Create(action: Sappy.DoPrimary, variant: Button.Variant.Primary, disabled: true, children: "Primary Button"),
                            Button.Create(action: Sappy.DoSecondary, variant: Button.Variant.Secondary, disabled: true, children: "Button"),
                            Button.Create(action: Sappy.DoPrimary, variant: Button.Variant.PrimaryOutline, disabled: true, children: "Primary Button"),
                            Button.Create(action: Sappy.DoSecondary, variant: Button.Variant.SecondaryOutline, disabled: true, children: "Button")
                        }),
                    Group.Create(
                        title: "Toggle States",
                        children: new Children
                        {
                            Button.Create(action: Sappy.DoToggle, variant: Button.Variant.Primary, active: State.toggle, children: "Toggle Button"),
                            Button.Create(action: Sappy.DoToggle, variant: Button.Variant.Primary, active: State.toggle, disabled: true, children: "Disabled Toggle Button")
                        }),
                });
            
            [SapTarget]
            private void DoPrimary() => Debug.Log("Primary");
            [SapTarget]
            private void DoSecondary() => Debug.Log("Secondary");
            [SapTarget]
            private void DoSuccess() => Debug.Log("Success");
            [SapTarget]
            private void DoDanger() => Debug.Log("Danger");
            [SapTarget]
            private void DoWarning() => Debug.Log("Warning");
            [SapTarget]
            private void DoInfo() => Debug.Log("Info");
            [SapTarget]
            private void DoLight() => Debug.Log("Light");
            [SapTarget]
            private void DoDark() => Debug.Log("Dark");
            [SapTarget]
            private void DoLink() => Debug.Log("Link");
            
            [SapTarget]
            private void DoLarge() => Debug.Log("Large");
            [SapTarget]
            private void DoRegular() => Debug.Log("Regular");
            [SapTarget]
            private void DoSmall() => Debug.Log("Small");
            
            [SapTarget]
            private void DoToggle()
            {
                SetToggle(!State.toggle);
                Debug.Log("Toggle");
            }
        }

        [RishValueType]
        public struct ContentState
        {
            public bool toggle;
        }
    }
}