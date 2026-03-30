using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace RootsSamples
{
    public partial class SamplesApp
    {
        private static List<ISample> SamplesList { get; } = new();
        
        private static ReadOnlyCollection<ISample> _all;
        public static ReadOnlyCollection<ISample> All => _all ??= SamplesList.AsReadOnly();

        static SamplesApp()
        {
            var assembly = Assembly.GetExecutingAssembly();
            
            var sampleInterfaceType = typeof(ISample);

            foreach (var type in assembly.GetTypes())
            {
                if (type.IsClass && sampleInterfaceType.IsAssignableFrom(type))
                {
                    SamplesList.Add(Activator.CreateInstance(type) as ISample);
                }
            }
            
            SamplesList.Sort((a, b) => a.Order == b.Order ? string.Compare(a.Name, b.Name, StringComparison.Ordinal) : a.Order.CompareTo(b.Order));
        }
    }
}