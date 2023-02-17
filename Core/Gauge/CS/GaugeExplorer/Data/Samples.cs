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
            _allItems.Add(new SampleItem("SimpleGauges",
                "Simple Gauges",
                @"Show off your data in style with Gauges for WinForms.",
                typeof(SimpleGauges)));
            _allItems.Add(new SampleItem("RadialGauges",
                "Radial Gauges",
                @"Create circular, helical, half-circular, rectangular and clamshell shaped radial gauges. Add numeric counters, state indicators, ranges, multiple pointers, scales, labels, images and more.",
                typeof(RadialGauges)));
            _allItems.Add(new SampleItem("LinearGauges",
                "Linear Gauges",
                @"Create rulers, progress bars, thermometers and more with linear gauges. Represent data values with pointers and moving ranges.",
                typeof(LinearGauges)));
            _allItems.Add(new SampleItem("Advanced",
                "Advanced Types",
                @"Create advanced gauges where the scale sweeps more than 360 degrees or rotates around a stationary pointer.",
                typeof(Advanced)));
            _allItems.Add(new SampleItem("Interaction",
                "Interaction",
                @"Users can now interact with the C1RadialGauge and C1LinearGauges. Use Gauges for WinForms for unique input by allowing users to drag the pointers like a knob. The gauge pointers can even snap to specific intervals. You can also create custom buttons with specific styles for each state (over, pressed, normal, etc) and use them throughout the gauge controls.",
                typeof(Interaction)));
            _allItems.Add(new SampleItem("BulletGraph",
                "BulletGraph",
                @"BulletGraph is a type of linear gauge designed specifically for use in dashboards and information screens. It displays a single key measure along with a comparative measure and qualitative ranges to instantly signal whether the measure is good, bad, or in some other state.",
                typeof(BulletGraph)));
            _allItems.Add(new SampleItem("BulletGraph in FlexGrid",
                "BulletGraph in FlexGrid",
                @"This demo shows how to use BulletGraph in FlexGrid. BulletGraph can be used in FlexGrid to draw it in a cell.",
                typeof(FlexGridWithBulletGraph)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
