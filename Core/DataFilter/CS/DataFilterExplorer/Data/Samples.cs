using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataFilterExplorer.Data
{
    public class SampleItem
    {
        private Type _sampleType;
        public SampleItem(string name, string title, string desc, Type sampleType)
        {
            Name = name;
            Title = title;
            Description = desc;
            _sampleType = sampleType ?? throw new ArgumentException("sampleType can't be null");
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Type SampleType => _sampleType;
        public Control Sample => Activator.CreateInstance(_sampleType) as Control;
    }

    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems = new List<SampleItem>();

        static SampleDataSource()
        {
            // add SampleItem for each sample you want to show
            _allItems.Add(new SampleItem("Overview",
               "Overview",
               "Shows how to use C1DataFilter control to filter the C1FlexGrid control.",
               typeof(Samples.Overview)));
            _allItems.Add(new SampleItem("FilterSummary",
                "Filter summary",
                "Shows how to use the FilterSummary for the Checklist filter. ",
                typeof(Samples.FilterSummary)));
            _allItems.Add(new SampleItem("ChartAsDataFilter",
                "Custom filter - Chart",
                "Shows how to use FlexChart control as a custom filter for DataFilter control.",
                typeof(Samples.ChartAsDataFilter)));
            _allItems.Add(new SampleItem("UnboundMode",
                "Unbound mode",
                "Shows how to use C1DataFilter control in unbound mode.",
                typeof(Samples.UnboundMode)));
            _allItems.Add(new SampleItem("DataFilterAndDataEngine",
                "DataFilter and DataEngine",
                "Shows how to filtering in the C1FlexGrid using the C1DataFilter when the C1DataEngine is a data source.",
                typeof(Samples.DataFilterAndDataEngine)));
            _allItems.Add(new SampleItem("FilterEditor",
                "Filter Editor",
                "This sample shows the basic features of C1FilterEditor.",
                typeof(Samples.FilterEditor))); 
            _allItems.Add(new SampleItem("FilterEditorAndDataEngine",
                "FilterEditor and DataEngine",
                "Shows how to filtering in the C1FlexGrid using the C1FilterEditor when the DataEngine is a data source.",
                typeof(Samples.FilterEditorAndDataEngine)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
