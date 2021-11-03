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
            // add SampleItem for each sample you want to show
            _allItems.Add(new SampleItem("Overview",
                "Overview",
                "This view shows the basic Sparkline features.",
                new SparklineExplorer.Samples.Overview()));
            _allItems.Add(new SampleItem("Region Sales",
              "Region Sales",
              "This view shows Sparklines in the C1FlexGrid control.",
              new SparklineExplorer.Samples.RegionSales()));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
