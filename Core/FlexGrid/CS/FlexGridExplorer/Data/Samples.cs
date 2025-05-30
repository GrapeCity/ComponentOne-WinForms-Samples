﻿using FlexGridExplorer.Samples;
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
            _allItems.Add(new SampleItem("AdvancedFiltering",
                "Advanced Filtering",
                "The demo shows how you can customize the FlexGrid's column filters using inheritance and composition from the code.",
                typeof(AdvancedFiltering)));
            _allItems.Add(new SampleItem("ApplySearch",
                "Searching",
                "The demo shows how you can search the FlexGrid's cells using ApplySearch method from the code.",
                typeof(ApplySearch)));
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
            _allItems.Add(new SampleItem("Multiple Range Selection",
                "Multiple Range Selection",
                "This feature shows how you can select the grid's multiple cells ranges.",
                typeof(MultiRangeSelection)));
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
            _allItems.Add(new SampleItem("HoverStyle",
                "Hover Style",
                "Hover style allows you to highlight cells under the mouse cursor",
                typeof(HoverStyle)));
            _allItems.Add(new SampleItem("CustomCells",
                "Custom Cells",
                "The OwnerDrawCell event allows you to customize the way each cell is rendered. You can modify some elements of the cell or override the painting completely. In this example, OwnerDraw mode is used to display alpha-blended progress bars on cells to implement a user interface similar to that of Windows Media Player.",
                typeof(CustomCells)));
            // editing
            // grouping
            // merging
            // print, import&export
            // searching
            // styling
            // validation
            //Merging
            _allItems.Add(new SampleItem("CellMerging",
           "Cell Merging",
           "FlexGrid can automatically merge cells down columns or across rows based on the cell contents. There are several different merging rules which you can select by setting AllowMerging property.",
           typeof(CellMerging)));
            //custom cell merging
            _allItems.Add(new SampleItem("CustomCellMerging",
             "Custom Cell Merging",
             "FlexGrid offers several built-in cell merging modes that handle most common display scenarios: free, spill, nodes, row/column control, fixed only, and outline. If none of the built-in modes meet your needs, you can inherit from FlexGrid and implement a custom version. This example uses custom merge logic to render a TV schedule that merges programs across columns and rows.",
             typeof(CustomCellMerging)));

            _allItems.Add(new SampleItem("ColumnFooters",
                "Column Footers",
                "Footers can be shown in FlexGrid columns, the footer can be fixed or as an additional row at the end, each column footer can show predefined calculated aggregates like sum, avg, min, max. Footers can also show values based on expressions, i.e. calculations based on several columns. The feature comes with full design time support to add columns footers with expressions and captions.",
                typeof(ColumnFooters)));

            //Sparkline
            _allItems.Add(new SampleItem("Sparkline",
               "Sparkline",
               "The Sparkline property of column is used for sparkline customization. You can change the sparkline type, the series color, the showing and color of different marker types and X axis, line weight for the Line sparkline type and the distance between bars for the WinLoss and Column types.",
               typeof(Sparkline)));

            //Column Sizing
            _allItems.Add(new SampleItem("ColumnSizing",
               "Column Sizing",
               "FlexGrid supports different column sizing modes. Columns can have fixed size with manually assigned values. Column size can be adjusted by content using AutoSizeCols method. Star-sizing allows you to specify the width of a column with respect to the total width available.",
               typeof(ColumnSizing)));
            
            //Dynamic Grouping
            _allItems.Add(new SampleItem("DynamicGrouping",
               "Dynamic Grouping",
               "Dynamic grouping automatically sorts the data, splits it into groups, and adds collapsible group rows above or below each group. The group rows may include aggregate values for one or more columns.",
               typeof(DynamicGrouping)));

            //Grouping Panel
            _allItems.Add(new SampleItem("GroupingPanel",
               "Grouping Panel",
               "FlexGridGroupPanel offers group data of the associated FlexGrid control by dragging columns from grid to group panel. Depending on selected options groups might be collapsed or expanded after grouping and columns might be hidden or visible.",
               typeof(GroupingPanel)));

            //Error Info
            _allItems.Add(new SampleItem("ErrorInfo",
               "Error Info",
               "When the ShowErrors property is set to true, the grid will detect errors and show them using an icon in the cells (for field-specific errors) or along the first column (for record-level errors). When the user moves the mouse over the error icon, a tooltip shows the error description",
               typeof(ErrorInfo)));

            _allItems.Add(new SampleItem("ColumnEditors",
              "Column Editors",
              "FlexGrid for WinForms supports numerous types custom editors. Any control that derives from the base Control class can be used as a basic grid editor. This demo shows many common column data types and their desired editors. Double-click within a cell to edit its contents.",
              typeof(ColumnEditor)));

            _allItems.Add(new SampleItem("Subtotals",
             "Subtotals",
             "Use the Subtotal method to automatically calculate totals for individual columns. When the end user drags a column header to a different position, the grid instantly reorganizes the data and recalculates the subtotals.",
              typeof(Subtotals)));

            _allItems.Add(new SampleItem("TreeGrid",
              "Tree Grid",
              "FlexGrid can behave as a tree view. It has the expected features of a tree view plus those of an extensive data grid. Users can drag items, perform sorts, insert new items, edit text inline, and even print. Use the SetCellImage or the SetCellCheck methods to easily add images or checkboxes to items.",
              typeof(TreeGrid)));
            
            _allItems.Add(new SampleItem("PdfExport",
             "Export to Pdf",
             "This sample marks selected rows and columns as break points, then breaks the grid into several images and renders the images into a C1PdfDocument.",
             typeof(PdfExport)));

            _allItems.Add(new SampleItem("ExportAndPrint",
             "Export and Print",
             "Save and Load data directly from Excel using the SaveExcel and LoadExcel methods. FlexGrid supports many different exporting options, such as whether to include formatting, fixed cells, merged ranges, mapped values and more. You can also directly print FlexGrid by just calling the PrintGrid method while optionally showing preview and progress dialogs. For more control over printing, FlexGrid has a custom Printable class which can be used to combine multiple grids in one document or add surrounding content.",
             typeof(ExportAndPrint)));
        }

        public static IList<SampleItem> AllItems
        {
            get { return _allItems; }
        }
    }
}
