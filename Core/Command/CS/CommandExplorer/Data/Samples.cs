using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace CommandExplorer
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
            _allItems.Add(new SampleItem("DockingOverview",
               "Docking Overview",
               "The C1DockingTab control implements the familiar tab control interface with enhanced appearance and behavioral settings.", 
               new Samples.DockingOverview()));
            _allItems.Add(new SampleItem("Docking",
                "Docking",
                "C1DockingTabs can float and dock to any edge of the application. Choose among four different docking styles, including Visual Studio one.", // Float and dock tabs to create different workspaces
                new Samples.Docking()));
            _allItems.Add(new SampleItem("ToolbarsOverview",
               "Toolbars and Menus",
               "This demo shows C1Menu, C1ContextMenu and C1Toolbar which share the same set of commands.",
               new Samples.ToolbarsOverview()));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
