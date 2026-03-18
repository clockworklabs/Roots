using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Unity.Plastic.Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

namespace Roots.Rootstrap
{
    public static class FontAwesomeGenerator
    {
        [MenuItem("Assets/Create/Roots/Generate FontAwesome File")]
        public static void Generate()
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            var textAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(path);
            var text = Regex.Replace(textAsset.text, @"^  ""([^""]+)"":\s*\{", "  {", RegexOptions.Multiline);
            
            var icons = JsonConvert.DeserializeObject<RawIconData[]>($"[{text.Substring(1, text.Length - 2)}]").Where(icon => icon.free != null && icon.free.Length > 0).ToArray();
            
            var builder = new StringBuilder();

            builder.AppendLine(@"using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roots.Rootstrap
{
    public static class FontAwesome
    {
        [Flags]
        public enum Styles { Brands = 1, Regular = 2, Solid = 4, }

        public class IconData
        {
            public string Label { get; }
            public string Unicode { get; }
            public Styles Styles { get; }
            public ReadOnlyCollection<string> SearchTerms { get; }

            public IconData(string label, string unicode, Styles styles, string[] searchTerms)
            {
                Label = label;
                Unicode = unicode;
                Styles = styles;
                SearchTerms = new ReadOnlyCollection<string>(searchTerms);
            }

            public static implicit operator string(IconData data) => data.Unicode;
            public static implicit operator RishUI.RishString(IconData data) => data.Unicode;
        }
");

            foreach (var icon in icons)
            {
                builder.Append($@"        private static IconData _{icon.PropertyName};
        public static IconData FA_{icon.PropertyName} => _{icon.PropertyName} ??= new IconData(""{icon.label}"", ""{icon.UnicodeEscapeSequence}"", ");
                for(int i = 0, n = icon.free.Length; i < n; i++)
                {
                    if (i > 0)
                    {
                        builder.Append(" | ");
                    }
                    builder.Append(icon.free[i] switch
                    {
                        "brands" => "Styles.Brands",
                        "regular" => "Styles.Regular",
                        "solid" => "Styles.Solid",
                    });
                }
                builder.Append(", new string[] {");
                for (int i = 0, n = icon.search.terms.Length; i < n; i++)
                {
                    if (i > 0)
                    {
                        builder.Append(",");
                    }
                    builder.Append($" \"{icon.search.terms[i]}\"");
                }
                builder.AppendLine(" });");
            }

            builder.AppendLine(@"
        private static ReadOnlyCollection<IconData> _all;
        public static ReadOnlyCollection<IconData> All => _all ??= new ReadOnlyCollection<IconData>(new IconData[]
        {");
            
            foreach (var icon in icons)
            {
                builder.AppendLine($"            FA_{icon.PropertyName},");
            }

            builder.AppendLine(@"        });
        
        public static IconData GetByLabel(string v) => v switch
        {");
            
            foreach (var icon in icons)
            {
                builder.AppendLine($"            \"{icon.label}\" => FA_{icon.PropertyName},");
            }

            builder.AppendLine(@"        };
        
        public static IconData GetByUnicode(string v) => v switch
        {");
            
            foreach (var icon in icons)
            {
                builder.AppendLine($"            \"{icon.UnicodeEscapeSequence}\" => FA_{icon.PropertyName},");
            }
            
            builder.AppendLine(@"};
        
        public static List<IconData> Search(string v)
        {
            var results = new List<IconData>();
            Search(v, results);
            return results;
        }
        public static bool Search(string v, List<IconData> results)
        {
            results.Clear();
            foreach (var icon in All)
            {
                if (icon.Label.Contains(v, StringComparison.OrdinalIgnoreCase) ||
                    icon.Unicode.Contains(v, StringComparison.OrdinalIgnoreCase) ||
                    icon.SearchTerms.Any(term => term.Contains(v, StringComparison.OrdinalIgnoreCase)))
                {
                    results.Add(icon);
                }
            }
            return results.Count > 0;
        }
    }
}");

            var regularIcons = icons.Where(icon => icon.free.Contains("regular")).ToList();
            regularIcons.Sort((a, b) => a.UnicodeValue.CompareTo(b.UnicodeValue));
            builder.AppendLine($"// Regular ({regularIcons.Count}): {DebugStyleSequence(regularIcons)}");
            var solidIcons = icons.Where(icon => icon.free.Contains("solid")).ToList();
            solidIcons.Sort((a, b) => a.UnicodeValue.CompareTo(b.UnicodeValue));
            builder.AppendLine($"// Solid ({solidIcons.Count}): {DebugStyleSequence(solidIcons)}");
            var brandsIcons = icons.Where(icon => icon.free.Contains("brands")).ToList();
            brandsIcons.Sort((a, b) => a.UnicodeValue.CompareTo(b.UnicodeValue));
            builder.AppendLine($"// Brands ({brandsIcons.Count}): {DebugStyleSequence(brandsIcons)}");

            var outputPath = $"{Path.GetDirectoryName(path).Replace("\\", "/")}/FontAwesome.cs";
            File.WriteAllText(outputPath, builder.ToString());
            AssetDatabase.ImportAsset(outputPath);
            AssetDatabase.SaveAssets();
        }
        
        [MenuItem("Assets/Create/Roots/Generate FontAwesome File", true)]
        private static bool ValidateGenerate()
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            return !string.IsNullOrWhiteSpace(path) && Path.GetFileName(path).Equals("icons.json", StringComparison.OrdinalIgnoreCase);
        }

        private static string DebugStyleSequence(List<RawIconData> icons)
        {
            var groups = new List<Vector2Int>();
            var prevUnicode = -1;
            foreach (var unicode in icons.Select(icon => icon.UnicodeValue))
            {
                if (groups.Count <= 0 || prevUnicode < 0 || unicode > prevUnicode + 1)
                {
                    groups.Add(new Vector2Int(unicode, unicode));
                }
                else
                {
                    var groupIndex = groups.Count - 1;
                    var group = groups[groupIndex];
                    group.y = unicode;
                    groups[groupIndex] = group;
                }
                prevUnicode = unicode;
            }

            var sequenceBuilder = new StringBuilder();
            for (int i = 0, n = groups.Count; i < n; i++)
            {
                var group = groups[i];
                if (i > 0)
                {
                    sequenceBuilder.Append(",");
                }
                var firstChar = group.x;
                var lastChar = group.y;
                if (firstChar == lastChar)
                {
                    sequenceBuilder.Append($"{firstChar:x8}");
                }
                else
                {
                    sequenceBuilder.Append($"{firstChar:x8}-{lastChar:x8}");
                }
            }
            
            return sequenceBuilder.ToString().ToUpperInvariant();
        }
        
        private class RawIconData
        {
            public SearchData search;
            public string unicode;
            public string label;
            public string[] free;

            private string _propertyName;
            public string PropertyName => _propertyName ??= label.Replace(" ", "");

            private int? _unicodeValue;
            public int UnicodeValue => _unicodeValue ??= Convert.ToInt32(unicode, 16);

            private string _unicodeEscapeSequence;
            public string UnicodeEscapeSequence => _unicodeEscapeSequence ??= $"\\U{UnicodeValue:X8}";
        }

        private class SearchData
        {
            public string[] terms;
        }
    }
}