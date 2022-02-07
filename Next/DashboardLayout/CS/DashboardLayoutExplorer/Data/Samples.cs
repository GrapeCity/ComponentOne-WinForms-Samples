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
                @"This demo shows the basic features of C1DashboardLayout. 
Dashboard Layout visualizes data. It helps to organize and combining the elements into a screen report for instant data monitoring.",
                typeof(Overview)));
            _allItems.Add(new SampleItem("SaveLoadLayout",
                "Save And Load Layout",
                @"This demo shows how to save and load C1DashboardLayout layout.
Save and load layout from file or stream using the SaveLayout and LoadLayout methods.",
                typeof(SaveLoadLayout)));
            _allItems.Add(new SampleItem("LayoutTypes",
                "Layout Types",
                @"This demo shows how the C1DashboardLayout looks at different layout types.
Dashboard Layout has different layout types which defines some behavior and appearance features.",
                typeof(LayoutTypes)));

        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
