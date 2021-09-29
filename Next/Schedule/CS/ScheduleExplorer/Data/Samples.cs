using ScheduleExplorer.Samples;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace SampleExplorer
{
    public class SampleItem
    {
        private Type _sampleType;
        public SampleItem(string name, string title, string desc, Type sampleType)
        {
            if (sampleType == null)
                throw new ArgumentException("sampleType can't be null");
            Name = name;
            Title = title;
            Description = desc;
            _sampleType = sampleType;
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Control Sample
        {
            get
            {
                var c = Activator.CreateInstance(_sampleType) as Control;
                return c;
            }
        }
    }

    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems = new List<SampleItem>();

        static SampleDataSource()
        {
            _allItems.Add(new SampleItem("Overview",
                "Overview",
                "Demonstrates typical scheduling application",
                typeof(C1ScheduleDemo)));

            _allItems.Add(new SampleItem("UnBound",
                "UnBound",
                "Demonstrates using C1Schedule in unbound mode",
                typeof(UnBound)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
