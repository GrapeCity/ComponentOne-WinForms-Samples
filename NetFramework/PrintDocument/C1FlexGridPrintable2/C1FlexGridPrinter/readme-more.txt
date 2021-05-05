<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Readme file for C1FlexGridPrinter.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Thank you for your interest in ComponentOne C1FlexGridPrinter.

C1FlexGridPrinter is a library providing classes that allow rendering a
C1FlexGrid control into a C1PrintDocument so that it can be printed, previewed,
or exported to any of the formats supported by C1PrintDocument. 

This project references the following NuGet packages: 

  - C1.Win.C1FlexGrid
  - C1.Win.Printing       

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1FlexGridPrinter maintenance log (NOTE: classes overview is below)
Legend: [+] - bug fixed, [*] - new feature.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

* Version 1.0.0.3, May-2021:
  [+] Using new C1.Win.Printing package.

* Version 1.0.0.2, 05-Apr-2011 (thanks to Wolfgang Knauf again):
  [+] Got rid of compile warnings.

* Version 1.0.0.1, 22-Oct-2010 (thanks to Wolfgang Knauf):
  [+] Crash if a tree node's text was empty.
  [+] "Minus" glyph displayed near tree nodes without any children.

* Version 1.0.0.0: original release.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Overview of the C1FlexGridPrinter class library
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

C1FlexGridPrinter is a class library designed to enable printing, previewing,
or exporting a C1FlexGrid control using the C1PrintDocument component. 
It also allows you to insert a C1FlexGrid into a C1PrintDocument along with other data
(including other grids), thus creating a complex document or report.

The two main public classes providing this functionality are:

C1.Win.C1FlexGrid.C1FlexGridPrinter
  Represents a class that may be used to insert a C1FlexGrid into a
  C1PrintDocument.

C1.Win.C1FlexGrid.C1FlexGridPrintable2 : C1FlexGrid
  Represents a C1FlexGrid that can be inserted into a C1PrintDocument
  for printing, preview, or export.

C1FlexGridPrinter provides most of the functionality but it does not
derive from C1FlexGrid (hence the class is light-weight). The following
snippet of code demonstrates how C1FlexGridPrinter may be used to print
preview an existing C1FlexGrid:

  C1FlexGrid flex = new C1FlexGrid();
  //... fill the grid with data and so on here ...
  C1FlexGridPrinter printer = new C1FlexGridPrinter(flex);
  printer.PrintPreview();

A more flexible (and the recommended) approach is to create a
C1PrintDocument in your own code, and use C1FlexGridPrinter to render
FlexGrid(s) into it. Here's a sample that prints two grids in sequence,
adding a header text before each grid, and a page break between them:

  C1FlexGrid flex1 = new C1FlexGrid();
  C1FlexGrid flex2 = new C1FlexGrid();
 //... fill grids with data and so on here...
  C1FlexGridPrinter printer1 = new C1FlexGridPrinter(flex1);
  C1FlexGridPrinter printer2 = new C1FlexGridPrinter(flex2);
  // create C1PrintDocument that will contain both grids:
  C1PrintDocument doc = new C1PrintDocument();
  // header for 1st grid:
  RenderText hdr1 = new RenderText("Grid 1 Header");
  doc.Body.Children.Add(hdr1);
  // render 1st grid into the document:
  doc.Body.Children.Add(printer1.MakeGridTable(doc));
  // header for 2nd grid with a page break in front:
  RenderText hdr2 = new RenderText("Grid 2 Header");
  hdr2.BreakBefore = BreakEnum.Page;
  doc.Body.Children.Add(hdr2);
  // render 2nd grid into the document:
  doc.Body.Children.Add(printer2.MakeGridTable(doc));
  // now that the document is complete, it can be printed, exported or
  // previewed as needed - preview here:
  C1PrintPreviewDialog pview = new C1PrintPreviewDialog();
  pview.Document = doc;
  pview.ShowDialog();

The class derived from C1FlexGrid - C1FlexGridPrintable2 - is
primarily intended to print owner-drawn cells and use some of the
advanced printing techniques to customize the way the grid is printed
(for example, C1FlexGridPrintable2 provides the PrintCell event, which
inserts page breaks before or after specific cells as in the
C1FlexGrid CustomPrint sample).

If you want to print a C1FlexGrid that uses owner-drawn cells,
basically all you have to do is change the type of your grid from
C1FlexGrid to C1FlexGridPrintable2, adjust the class constructor call
accordingly, and use C1FlexGridPrinter on that grid as described above.
C1FlexGridPrinter will automatically invoke your OwnerDrawCell event
handler when the grid is printed, passing metafile graphics into it,
and render the resulting metafile into the printout.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1FlexGridPrinter class
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Represents a class that may be used to insert a C1FlexGrid into a
C1PrintDocument.

========================================================================
C1FlexGridPrinter ctor
========================================================================

public C1FlexGridPrinter(C1FlexGrid grid)
  Initializes a new instance of the C1FlexGridPrinter class.
  grid - The C1FlexGrid that is to be printed.

========================================================================
C1FlexGridPrinter properties
========================================================================

public C1FlexGridPrintInfo PrintInfo {get;set;}
  Gets or sets print info that allows adjusting the way the grid is
  rendered. Cannot be null.

========================================================================
C1FlexGridPrinter events
========================================================================

public event LongOperationEventHandler LongOperation {add;remove;}
  Fired periodically while the grid is being rendered.
  Allows showing progress and canceling the operation.

========================================================================
C1FlexGridPrinter methods
========================================================================
public void PrintPreview()
  Shows the print preview dialog box with a C1PrintDocument representing
  the grid.

public C1PrintDocument MakeDocument()
  Creates a C1PrintDocument that can be used to print, preview, or export
  the grid. Page header and footer specified by the grid's
  PrintParameters are honored.
  returns: The C1PrintDocument representing the grid.

public RenderTable MakeGridTable(C1PrintDocument doc)
  Creates a render object representing the grid.
  doc - The document that is to contain the created render object, or
        null. Note that this method does not add the created object to
        the document - it is the responsibility of the caller to do
        so.
  returns: The render object created.
  remarks: The passed C1PrintDocument object, if not null, is used to
           optimize the way the grid is rendered.

public RenderObject MakePageHeader()
  Makes a RenderText object representing the page header as specified in
  the grid's PrintParameters. The returned object may be assigned to a
  C1PrintDocument's PageLayout.PageHeader.
  returns: The page header render object.

public RenderObject MakePageFooter()
  Makes a RenderText object representing the page footer as specified in
  the grid's PrintParameters. The returned object may be assigned to a
  C1PrintDocument's PageLayout.PageFooter.
  returns: The page header footer object.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1FlexGridPrintable2.PrintCellEventArgs : RowColEventArgs
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Represents arguments for the C1FlexGridPrintable2.PrintCell event.

========================================================================
C1FlexGridPrintable2.PrintCellEventArgs ctor
========================================================================

public PrintCellEventArgs(C1.C1Preview.TableCell tableCell,
                          int gridRow, int gridCol)
  Initializes a new instance of PrintCellEventArgs class.
  tableCell - The cell of the RenderTable object.
  gridRow - The C1FlexGrid row index.
  gridCol - The C1FlexGrid column index.

========================================================================
C1FlexGridPrintable2.PrintCellEventArgs properties
========================================================================

public TableCell TableCell {get;}
  Gets the current table cell.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1FlexGridPrintable2 class
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Represents a C1.Win.C1FlexGrid.C1FlexGrid that can be inserted into a
C1.C1Preview.C1PrintDocument for printing, preview, or export.

========================================================================
C1FlexGridPrintable2 ctor
========================================================================

public C1FlexGridPrintable2()
  Initializes a new instance of the C1FlexGridPrintable2 class.

========================================================================
C1FlexGridPrintable2 properties
========================================================================

public bool IsPrinting {get;}
  Gets a value indicating whether the grid is currently printing. This
  property may be used in an OwnerDrawCell event handler to change owner
  drawing when printing.

public C1FlexGridPrinter Printer {get;}
  Gets the C1FlexGridPrinter used by the current C1FlexGridPrintable2.

========================================================================
C1FlexGridPrintable2 events
========================================================================

public event PrintCellEventHandler PrintCell {add;remove;}
  Fired immediately after a render object representing the cell has been
  added to the render table representing the grid. Use this event to
  adjust printed cell attributes.

public event EventHandler PrintStarting {add;remove;}
  Fired before the render object representing the grid is created by
  C1FlexGridPrinter. This event may be used to adjust the properties of
  the grid prior to printing.

public event EventHandler PrintEnded {add;remove;}
  Fired after the render object representing the grid has been created
  by C1FlexGridPrinter. If the grid's properties were adjusted for
  printing in the PrintStarting handler, this event may be used to
  revert those changes.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1FlexGridPrintInfo class
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Provides properties that can adjust how a C1FlexGrid is rendered in
a C1PrintDocument.

========================================================================
C1FlexGridPrintInfo properties
========================================================================

public bool AllowHorzSplit {get;set;}
  Gets or sets a value indicating whether the grid may be split across
  multiple pages if it is too wide to fit on a single page.
  The default value is true.

public bool PrintFixedRows {get;set;}
  Gets or sets a value indicating whether to print fixed rows.
  The default value is true.

public bool PrintFixedCols {get;set;}
  Gets or sets a value indicating whether to print fixed columns.
  The default value is true.

public bool RepeatFixedRows {get;set;}
  Gets or sets a value indicating whether to print fixed rows on all
  pages. This property is ignored if PrintFixedRows is false.
  The default value is true.

public bool RepeatFixedCols {get;set;}
  Gets or sets a value indicating whether to repeat fixed columns on all
  pages if the grid is too wide to fit on one page.
  This property is ignored if PrintFixedCols is false.
  The default value is true.

public bool AutoRowHeights {get;set;}
  Gets or sets a value indicating whether row heights are resized
  automatically to accommodate all data. If this property is false, row
  heights are the same as in the grid.
  The default value is true.

public bool AutoColWidths {get;set;}
  Gets or sets a value indicating whether column widths are resized
  automatically to accommodate all data. If this property is false,
  column widths are the same as in the grid.
  The default value is false.
  Note that if the grid contains cells with very long text that are
  wider than a printed page, setting this property to true would result
  in data clipping.

public int MaxColWidth {get;set;}
  Gets or sets the maximum column width in the printed grid, in screen
  (96 dpi) pixels. This is especially useful if the grid contains
  columns that are too wide to fit on a printed page.
  The default value is 500.

public bool PrintHighlight {get;set;}
  Gets or sets a value indicating whether highlighted cells are printed
  as such.
  The default value is false.

public bool PrintBorders {get;set;}
  Gets or sets a value indicating whether borders specified by the grid
  styles are printed. Set this property to false if you want to use
  C1PrintDocument's Style.Borders and/or Style.GridLines to specify how
  borders are printed instead.
  The default value is true.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The END.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>