using FlexGridExplorer.Samples;
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
                "This view shows the basic FlexGrid features",
                typeof(Overview)));
            _allItems.Add(new SampleItem("Filtering",
                "Filtering",
                "FlexGrid provides three built-in filters that allow filtering most data types easily and efficiently. Value filters show a list of values present in the column and allow the user to select which specific values should be displayed. Conditional filters show two conditions defined by an operator and a parameter (e.g. 'greater than' and '2') and allows the user to combine multiple operators using AND and OR conditions. In some cases, you may want to implement custom filtering by creating a filter class and an editor class which allows users to configure the filter at runtime. This demo shows default text and numeric filtering, as well as custom color, date and range filtering.",
                typeof(CustomFiltering)));
            _allItems.Add(new SampleItem("Scrolling",
                "Scrolling",
                "Turn on delayed scrolling by just setting the ScrollOptions property. Using ShowScrollTip event, you can set a scroll tip based on the current scroll position and sort order.",
                typeof(Scrolling)));
            _allItems.Add(new SampleItem("Freezing",
                "Freezing",
                "FlexGrid supports freezing rows and columns both from code and by end-user. To allow the user to freeze rows and columns with the mouse, set the AllowFreezing property to Columns to freeze only columns, Rows to freeze only rows, or Both to freeze both columns and rows.",
                typeof(Freezing)));
            _allItems.Add(new SampleItem("PinnedColumns",
                "Pinning Columns",
                "FlexGrid supports pinning singe column at time (top sample) or column range (bottom sample). To allow the user to pin and unpin columns, set AllowPinning property to SingleColumn or ColumnRange.",
                typeof(PinnedColumn)));
            _allItems.Add(new SampleItem("Performance",
                "Performance",
                "FlexGrid is capable of handling millions of records and includes a few tricks for getting optimal performance. For instance, set the Redraw property to false before data binding to prevent the grid from painting during load time. Set the AutoResize property to false to turn off automatic column and row resize, which can be expensive for larger data sets. Click 'Generate Items' in this demo to fill a list of items and populate the FlexGrid.",
                typeof(Performance)));
            _allItems.Add(new SampleItem("Unbound",
                "Unbound",
                "FlexGrid is designed for optimal performance in both bound and unbound modes. When working with an unbound FlexGrid, you have complete control over column behavior. In this demo we created a form where users enter Proceeds and Payments and we wired up the remaining columns to calculate new values.",
                typeof(Unbound)));
            _allItems.Add(new SampleItem("ColumnBands",
                "ColumnBands",
                "Column bands provide a simple and convenient way to organize FlexGrid's columns into logical groups - bands.",
                typeof(ColumnBands)));
            _allItems.Add(new SampleItem("ColumnBandsLayout",
                "ColumnBands Layout",
                "This view shows how to quickly switch between different layouts using the C1FlexGridBandedView component.",
                typeof(ColumnBandsLayout)));            
            _allItems.Add(new SampleItem("ColumnBandsAdvanced",
                "Advanced Bands",
                "Multi row column bands allow to organize data into complex layouts of data cells.",
                typeof(ColumnBandsAdvanced)));
            _allItems.Add(new SampleItem("ColumnBandsGrouping",
                "Bands Order Management",
                "This view demonstrates a Order Management view grouped by CompanyName created with the C1FlexGridBandedView component.",
                typeof(ColumnBandsGrouping)));
            _allItems.Add(new SampleItem("Selection statistics",
                "Selection statistics",
                "Selection statistics shows count of cells, average and summary of cell values.",
                typeof(SelectionStatistics)));
            _allItems.Add(new SampleItem("Column Picker",
                "Column Picker",
                "Column picker allow to control the grid's columns visible state.",
                typeof(ColumnPicker)));

            // columns
            // data binding
            // row details
            _allItems.Add(new SampleItem("InputPanelSample",
                "RowDetails InputPanel",
                "Row detail allow to show additional content in the expandable area after the regular row. To use row detail for inline editing, set the RowDetailProvider property to the lambda expression returning a new instance of the C1InputPanelRowDetail class.",
                typeof(FlexGridExplorer.Samples.RowDetails.InputPanelSample)));
            _allItems.Add(new SampleItem("FlexGridSample",
                "RowDetails FlexGrid",
                "Row details allow to show additional content in the expandable area after the regular row. You can use row detail for master - detail data presentation by using C1FlexGridRowDetail control.",
                typeof(FlexGridExplorer.Samples.RowDetails.FlexGridSample)));
            _allItems.Add(new SampleItem("InheritanceSample",
                "RowDetails Inheritance",
                "Row details allow to show additional content in the expandable area after the regular row. To customize appearance or functionality of the standard detail control, you can derive the new row detail control from the C1InputPanelRowDetail and override one or more virtual methods of the IC1FlexGridRowDetail interface.",
                typeof(FlexGridExplorer.Samples.RowDetails.InheritanceSample)));
            _allItems.Add(new SampleItem("CustomSample",
                "RowDetails Custom",
                "Row details allow to show additional content in the expandable area after the regular row. You can create your own row detail control and setup it as you want.The custom row detail control must implement the IC1FlexGridRowDetail interface.",
                typeof(FlexGridExplorer.Samples.RowDetails.CustomSample)));
            // editing
            // grouping
            // merging
            // print, import&export
            // searching
            // styling
            // validation

        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
