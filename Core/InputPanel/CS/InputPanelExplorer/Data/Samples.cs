using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace InputPanelExplorer
{
    public class SampleItem
    {
        public SampleItem(string name, string title, string desc, Control sample)
        {
            Name = name;
            Title = title;
            Description = desc;
            Sample = sample;
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Control Sample { get; set; }
    }

    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems = new List<SampleItem>();

        static SampleDataSource()
        {
            // add SampleItem for each sample you want to show
            _allItems.Add(new SampleItem("Data Binding",
                "Data Binding",
                "InputPanel can bind to any.NET data source with little or no code, allowing you to create a fully - navigational database browser in seconds. Simply connect the InputPanel to a data source, select the record set and a fully bound input control for each field is automatically created for you.",
                new Samples.DataBinding()));
            _allItems.Add(new SampleItem("Customization",
               "Customization",
               "You can customize appearance of individual InputPanel fields, change text, layout or other options.",
               new Samples.Customization()));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
