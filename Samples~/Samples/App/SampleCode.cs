#if UNITY_EDITOR
using System;
using System.Linq;
using RishUI;
using Roots;
using Roots.Experimental.Rootstrap;
using Roots.Rootstrap;
using UnityEditor;
using UnityEngine.UIElements;

namespace RootsSamples
{
    public partial class SampleCode : RishElement<SampleCodeProps, SampleCodeState>, IPropsListener
    {
        void IPropsListener.PropsDidChange()
        {
            if (!Props.open) return;

            var sample = SamplesApp.All[Props.index];
            
            var sampleName = sample.Name;
            var folderName = sampleName.Replace(" ", "");

            var script = AssetDatabase.LoadAssetAtPath<MonoScript>($"Assets/_Project/Roots/Samples/{folderName}/{folderName}Sample.cs");

            string code;
            if (script == null)
            {
                code = "// Code not found.";
            }
            else
            {
                var sourceCode = script.text;

                string searchText;
                string indentation;
                if (sourceCode.Contains("Element ISample.Factory() => Content.Create("))
                {
                    script = AssetDatabase.LoadAssetAtPath<MonoScript>($"Assets/_Project/Roots/Samples/{folderName}/Content.cs");
                    sourceCode = script.text;
                    searchText = "protected override Element Render() =>";
                    indentation = "            ";
                }
                else
                {
                    searchText = "Element ISample.Factory() =>";
                    indentation = "        ";
                }
                
                var startIndex = sourceCode.IndexOf(searchText, StringComparison.Ordinal) + searchText.Length;
                var endIndex = sourceCode.IndexOf(";", startIndex, StringComparison.Ordinal) + 1;

                var relevantCode = sourceCode.Substring(startIndex, endIndex - startIndex);
                
                var lines = relevantCode.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
                var trimmedLines = lines.Select(line => line.StartsWith(indentation) ? line[indentation.Length..] : line);

                code = string.Join(Environment.NewLine, trimmedLines);
            }
            SetCode(code);
        }
        void IPropsListener.PropsWillChange() { }
        
        protected override Element Render() => Props.open
            ? Div.Create(
                className: new ClassName {
                    "content-rect",
                    "thin-border"
                },
                style: StyleUtilities.Height(Length.Percent(30)),
                children: VScrollView.Create(
                        className: new ClassName
                        {
                            "absolute-fill",
                            "m-2"
                        },
                        children: Body.Create(text: State.code)))
            : Element.Null;
    }

    [RishValueType]
    public struct SampleCodeProps
    {
        public int index;
        public bool open;
    }
    [RishValueType]
    public struct SampleCodeState
    {
        public RishString code;
    }
}
#endif