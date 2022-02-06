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
                @"Demonstrates an example of the CustomFieldColumn class usage.
This sample adds the special custom column(Actual Cost) that is calculated as a full cost of the resource multiplied by the amount of the resource usage.
The value in the ""Actual Cost"" column is recalculated each time when any of its source values(such as resource cost or task duration) is changed.",
                typeof(Overview)));
            _allItems.Add(new SampleItem("SaveLoadLayout",
                "SaveLoadLayout",
                @"Replaces the standard Task Information dialog with a custom Form.
This sample shows how to customize the Task Information dialog by handling C1GanttView.ShowDialog event.",
                typeof(SaveLoadLayout)));
            _allItems.Add(new SampleItem("LayoutTypes",
                "LayoutTypes",
                @"Demonstrates a few examples of using custom filters with C1GanttView.
This sample represents how to create the custom filters by combining various existent filters or using advanced filter with multiple conditions.
To apply custom filters, simply click to the buttons on the left side of form. When editing or viewing the project, you could use those filters to view the wanted tasks in separation.",
                typeof(LayoutTypes)));

        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
