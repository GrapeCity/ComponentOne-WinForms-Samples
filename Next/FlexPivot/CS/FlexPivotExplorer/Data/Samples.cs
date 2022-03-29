using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace FlexPivotExplorer
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
        public Type SampleType { get { return _sampleType; } }
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
            // add SampleItem for each sample you want to show
            _allItems.Add(new SampleItem("Overview",
               "Overview",
               "FlexPivot supports all common aggregation functions and filtering. It is capable of analyzing large data sets with millions of records in seconds or less. The user can specify what kinds of analytics to perform, and see the results in different views including a pivot grid and a chart.", 
               typeof(Samples.Overview)));
            _allItems.Add(new SampleItem("Cube Analysis",
               "Cube Analysis",
               "Shows how to use C1FlexPivot to analyze Cube data.",
               typeof(Samples.CubeAnalysis)));
            _allItems.Add(new SampleItem("Hierarchical Axes",
               "Hierarchical Axes",
               "Shows how to enable hierarchical view for chart axes using ShowHierarchicalAxes property.",
               typeof(Samples.HierarchicalAxes)));
            _allItems.Add(new SampleItem("Legend Groups",
               "Legend Groups",
               "Shows how to enable items grouping for chart legend using LegendGroups property.",
               typeof(Samples.LegendGroups)));
            _allItems.Add(new SampleItem("Extended Palettes",
               "Extended Palettes",
               "Add a set of extended palettes to the default PivotChart's context menu.",
               typeof(Samples.ExtendedPalettes)));
            _allItems.Add(new SampleItem("FlexPivot Slicers",
               "FlexPivot Slicers",
               "Demonstrates how to use C1FlexPivotSlicer control to setup FlexPivot filters.",
               typeof(Samples.FlexPivotSlicers.Form1)));
            _allItems.Add(new SampleItem("FlexPivot Ranges",
               "FlexPivot Ranges",
               "Shows how to group data in ranges.",
               typeof(Samples.FlexPivotRanges.Form1)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
