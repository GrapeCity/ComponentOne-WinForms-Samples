using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace SampleExplorer
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
            _allItems.Add(new SampleItem("Overview",
                "Overview",
                "This view shows all controls included into C1.Win.Input assembly",
                new InputExplorer.Samples.Overview()));
            _allItems.Add(new SampleItem("C1Button",
                "Button",
                "Explore C1Button properties",
                new InputExplorer.Samples.Button()));
            _allItems.Add(new SampleItem("C1CheckBox",
                "CheckBox",
                "Explore C1CheckBox properties",
                new InputExplorer.Samples.CheckBox()));
            _allItems.Add(new SampleItem("C1ComboBox",
                "ComboBox",
                "Explore C1ComboBox properties",
                new InputExplorer.Samples.ComboBox()));
            _allItems.Add(new SampleItem("C1RadioButton",
                "RadioButton",
                "Explore C1RadioButton properties",
                new InputExplorer.Samples.RadioButton()));
            _allItems.Add(new SampleItem("C1RangeSlider",
                "RangeSlider",
                "Explore C1RangeSlider properties",
                new InputExplorer.Samples.RangeSlider()));
            _allItems.Add(new SampleItem("C1SplitButton",
                "SplitButton",
                "Explore C1SplitButton properties",
                new InputExplorer.Samples.SplitButton()));

            // todo:
            // samples for individual controls with PropertyGrid
            // sample which shows all control with themes (and ability to switch)
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
