using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace InputPanelExplorer
{
    public class SampleItem
    {
        private Type _sampleType;

        public SampleItem() { }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Type SampleType { get => _sampleType; set => _sampleType = value; }
        public Control Sample
        {
            get
            {
                var control = Activator.CreateInstance(_sampleType) as Control;
                return control;
            }
        }

    }

    public static class SampleDataSource
    {
        private static List<SampleItem> _allItems = new List<SampleItem>();

        static SampleDataSource()
        {
            // add SampleItem for each sample you want to show
            _allItems.Add(new SampleItem()
            {
                Name = "Data Binding",
                Title = "Data Binding",
                Description = "InputPanel can bind to any.NET data source with little or no code, allowing you to create a fully - navigational database browser in seconds.",
                SampleType = typeof(Samples.DataBinding)
            });


            _allItems.Add(new SampleItem()
            {
                Name = "Customization",
                Title = "Customization",
                Description = "You can customize appearance of individual InputPanel fields, change text, layout or other options.",
                SampleType = typeof(Samples.Customization)
            });

            _allItems.Add(new SampleItem()
            {
                Name = "Bill of Sale",
                Title = "Bill of sale",
                Description = "InputGridPanel may be used to design data bound complex business forms with validations.",
                SampleType = typeof(Samples.BillOfSale)
            });

            _allItems.Add(new SampleItem()
            {
                Name = "FlowPanel Сatalogue",
                Title = "FlowPanel Сatalogue",
                Description = "InputFlowPanel can be used to manually design complex flexible layouts where fields are populated with data at runtime.",
                SampleType = typeof(Samples.FlowPanelСatalogue)
            });
            _allItems.Add(new SampleItem()
            {
                Name = "Validation",
                Title = "Validation",
                Description = "When the end-user enters invalid input, a visual alert is automatically displayed and a red frame appears around the control. You can also display custom alerts such as tooltips.",
                SampleType = typeof(Samples.Validation)
            });
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
