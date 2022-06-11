using AccordionExplorer.Samples;
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
            // overview
            _allItems.Add(new SampleItem("Overview",
                "Overview",
                "This view shows the basic C1Accordion features.",
                typeof(Overview)));

            // close pages
            _allItems.Add(new SampleItem("Layout",
                "Layout",
                "This view shows different Layout options for C1Accordion control.",
                typeof(Layout)));

            // simple menu
            _allItems.Add(new SampleItem("SimpleMenu",
                "Simple Menu",
                "This view shows how to use C1Accordion control to create simple Hamburger menu.",
                typeof(SimpleMenu)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
