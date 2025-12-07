<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Readme file for C1FlexGridPrintable, .NET 2.x version.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Thank you for your interest in ComponentOne C1FlexGridPrintable.

C1FlexGridPrintable is an extension of C1FlexGrid for .NET (2.x version) 
product. In addition to features provided by the regular C1FlexGrid, 
C1FlexGridPrintable adds the ability to print, preview or export the 
C1FlexGrid control using the C1Preview product also available from 
ComponentOne. Also, C1FlexGridPrintable allows to embed a grid into a 
C1PrintDocument document.

C1FlexGridPrintable is shipped as a sample with full source code. It 
provides a single WinForms control, C1FlexGridPrintable, which inherits 
from C1FlexGrid. The resulting assembly name is 
C1.Win.FlexGridPrintable.2. The C1FlexGridPrintable project references 
the following dlls shipped by ComponentOne (listed in parentheses are 
the minimal required assembly versions of the dlls):

  - C1.Win.FlexGrid.2 (2.6.20061.250)
  - C1.C1Preview.2      (2.0.20062.40852)
  - C1.Win.C1Preview.2  (2.0.20062.40852)

(For the latest versions of all C1 components, please visit our
prerelease site http://prerelease.componentone.com.)

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Overview of C1FlexGridPrintable component
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

The name of the control is C1FlexGridPrintable, it inherits from
C1FlexGrid and is in the same namespace (C1.Win.FlexGrid).

C1FlexGridPrintable is a WinForms control, as such it can be placed on 
the Visual Studio's toolbox and from there dropped on a form. In a new 
application where you are planning to use C1FlexGrid and know beforehand 
that you will be needing the printing/exporting capabilities, this is 
the recommended way to use C1FlexGridPrintable - drop it on the form and 
use in your app instead of the regular C1FlexGrid.

Additionally, C1FlexGridPrintable can be used to print/export an 
existing C1FlexGrid. For this, a C1FlexGridPrintable constructor is 
provided which takes a C1FlexGrid object as a parameter. 
Printing/exporting operations on the created C1FlexGridPrintable will 
print/export the original C1FlexGrid.

The following code snippet demonstrates the second approach to print 
preview an existing grid:

  using C1.Win.FlexGrid;
  ...
  C1FlexGrid flexGrid = new C1FlexGrid();
  ...
  C1FlexGridPrintable printer = new C1FlexGridPrintable(flexGrid);
  printer.PrintPreview();
  
Also, C1FlexGridPrintable can be inserted in a C1PrintDocument using the 
RenderC1Printable render object of C1Preview. For example, the following 
code creates a C1PrintDocument, inserts a C1FlexGridPrintable into it, 
and previews the resulting document:
 
  using C1.Win.FlexGrid;
  using C1.C1Preview;
  using C1.Win.C1Preview;
  ...
  C1FlexGridPrintable printableFlexGrid = new C1FlexGridPrintable();
  ...
  C1PrintDocument doc = new C1PrintDocument();
  RenderC1Printable rc1 = new RenderC1Printable();
  rc1.Object = printableFlexGrid;
  doc.Body.Children.Add(rc1);
  C1PrintPreviewDialog preview = new C1PrintPreviewDialog();
  preview.Document = doc;
  preview.ShowDialog();

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1FlexGridPrintable object model
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

In addition to all properties and methods of the base C1FlexGrid, 
C1FlexGridPrintable provides the following properties, methods and 
events:

========================================================================
C1FlexGridPrintable properties
========================================================================

public PrintInfo C1FlexGridPrintable.PrintInfo {get;}
  This is a complex property providing several properties that allow
  to fine-tune the process of printing or exporting the grid.

public int CurRow {get;}
  Runtime-only; gets the index of the grid row currently being
  processed by the printing code (used to show progress).

========================================================================
C1FlexGridPrintable methods
========================================================================

public void PrintPreview();
  Shows the print preview.

public void Print();
  Prints the grid using the default printer settings.

public void Print(PrinterSettings printerSettings);
  Prints the grid using the specified printer settings.
  
public void Print(System.IO.Stream mystream)
  Outputs the prepared C1PrintDocument into the specified stream.

public System.IO.Stream PrintToStream();
  Outputs the prepared C1PrintDocument into the new stream.

public void ExportTo();
  Shows the export dialog and exports the grid to the file specified
  by the user.

public void ExportTo(string outputFileName);
  Exports the grid to the specified file. The format is determined by
  the file extension.

public void ExportToHtml(string outputFileName);
  Exports the grid to the specified file as HTML.

public void ExportToPdf(string outputFileName);
  Exports the grid to the specified file as PDF.

public void ExportToRtf(string outputFileName);
  Exports the grid to the specified file as RTF.

public void ExportToExcel(string outputFileName);
  Exports the grid to the specified file as Excel.

public void ExportToExcel(string outputFileName, bool onePagePerSheet);
  Exports the grid to the specified file as Excel.
  The onePagePerSheet parameter determines whether each page is
  exported as a single work sheet or not.

========================================================================
C1FlexGridPrintable events
========================================================================

The following events are fired by C1FlexGridPrintable:

public event CancelEventHandler StartPrinting
public event CancelEventHandler AfterRowPrinted
public event CancelEventHandler EndPrinting
public event OwnerDrawPageEventHandler OwnerDrawPageHeader
public event OwnerDrawPageEventHandler OwnerDrawPageFooter

And allow to perform certain actions as the grid is printed.

In event handlers for OwnerDrawPageHeader and OwnerDrawPageFooter events 
one can use public methods of class C1OwnerDrawPrint:

public void RenderDirectText(object x, object y, string text,
  object width, Font font, Color textColor, TextAlignEnum align)
- Renders text for the document.

public void RenderDirectImage(object x, object y, Image image,
  object width, object height, ImageAlignEnum align)
- Renders an image for the document.


========================================================================
  public class PrintInfo
========================================================================

public bool ShowHiddenRows {get;set}
  Gets or sets the value indicating whether to print hidden rows.
  The default value is false.

public bool ShowHiddenCols {get;set}
  Gets or sets the value indicating whether to print hidden columns.
  The default value is false.

public bool RepeatFixedRows {get;set}
  Gets or sets the value indicating whether to repeat fixed rows on
  each page.
  The default value is true.

public bool RepeatFixedCols {get;set}
  Gets or sets the value indicating whether to repeat fixed columns
  on each page.
  The default value is true.

public bool UseGridColors {get;set}
  Gets or sets the value indicating whether the grid color scheme is
  used to print the grid.
  The default value is true.

public WrapTextEnum WrapText {get;set;}
  Gets or sets the value indicating whether word wrap is on for text
  in the grid cells.
  The default value is WrapTextEnum.Wrap.

public FillEmptyEnum FillAreaWidth {get;set;}
  Gets or sets the mode of stretching the printout to the page width.
  The default value is FillEmptyEnum.ExtendAll.

public PageBreaksEnum PageBreak {get;set;}
  Gets or sets the horizontal page break mode.
  The default value is PageBreaksEnum.FitIntoArea.

public string PageHeader {get;set;}
  Gets or sets the header to be printed at the top of each page.
  The default is an empty string. The following special sequences are
  allowed in the string:
  - "\t" - the first such sequence centers the text that follows;
           the second sequence right-aligns the text that follows.
  - "\p" - the current page number.
  - "\P" - the total page count.

public C1.Win.FlexGrid.CellStyle PageHeaderStyle {get;set;}
  Gets or sets the style used to render the page header.

public int PageHeaderHeight {get;set;}
  Gets or sets the height of the page header, in hundreds of an inch.
  The default value is 30.

public bool IsOwnerDrawPageHeader {get;set;}
  Gets or sets a value indicating whether the page header is owner
  drawn.
  The default value is false.

public string PageFooter {get;set;}
  Gets or sets the header to be printed at the bottom of each page.
  The default is an empty string. The same special characters are
  allowed as in PageHeader.

public C1.Win.FlexGrid.CellStyle PageFooterStyle {get;set;}
  Gets or sets the style used to render the page footer.

public int PageFooterHeight {get;set;}
  Gets or sets the height of the page footer, in hundreds of an inch.
  The default value is 30.
  
public bool IsOwnerDrawPageFooter {get;set;}
  Gets or sets a value indicating whether the page footer is owner
  drawn.
  The default value is false.

public int MaxRowHeight {get;set;}
  Gets or sets the maximum row height, in hundredths of an inch.
  The default value is 30.

public RowHeightEnum VarRowHeight {get;set;}
  Gets or sets the value controlling the heights of rows in the
  printout.
  The default value is RowHeightEnum.StretchToFit.

public bool ShowOptionsDialog {get;set;}
  Gets or sets the value indicating whether the options dialog is
  displayed when the grid is about to be printed or previewed.
  The default value is false.

public bool ShowProgressForm {get;set;}
  Gets or sets the value indicating whether the progress form is
  shown while the grid is being prepared for printing.
  The default value is true.

public PageSettings PageSettings {get;set;}
  Gets or sets the page settings to be used for printing.

public string ProgressCaption {get;set;}
  Gets or sets the caption of the progress form.
  The default value is an empty string.

========================================================================
Enumerations
========================================================================

public enum FillEmptyEnum
  Specifies how empty space is printed:
  - ExtendAll
    All columns are extended proportionally (default);
  - None
    Empty space on the right;
  - ExtendLastCol
    Last (rightmost) column is extended to the rigth edge of the page.

public enum PageBreaksEnum
  Specifies when page breaks are applied:
  - FitIntoArea
    No horizontal page breaks, all columns are fit into the page width
    (default);
  - OnColumn
    Columns' widths are taken from the grid, horizontal page breaks
    are inserted when needed.

public enum WrapTextEnum
  Specifies how cell text is wrapped:
  - Wrap
    Always wrap text in cells (default);
  - NoWrap
    Never wrap text in cells;
  - LikeCell
    Text wrapping is controlled by individual column styles' WrapText
    property.

public enum RowHeightEnum
  Specifies the height of printed rows:
  - StretchToFit
    Stretch row to fit all data in cells (default);
  - LikeGrid
    Fixed height taken from the grid;
  - StretchToMax
    Stretch row as needed but not greater than the value of
    PrintInfo.MaxRowHeight property.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1FlexGridPrintable maintenance log:
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

18-Jun-2009 A.Manuzin <alexanderm@componentone.com>
	C1FlexGridPrintable.cs:
	C1FlexGridPrintable does not use cell's style during printing.
	Fixed.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The END.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
