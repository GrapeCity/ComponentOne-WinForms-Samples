## C1FlexGridPrinterTest1
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/Core\PrintDocument\CS\C1FlexGridPrintable2\Test1)
____
#### Shows how to use the C1FlexGridPrinter class library that replaces the old C1FlexGridPrintable.
____
This is an integrated test app that print previews FlexGrids from the
various C1FlexGrid samples using the C1FlexGridPrinter library.

The "SampleForms" subdirectory contains forms representing the included
FlexGrid samples. Usually the file name indicates which FlexGrid
sample is represented. For example, "Hyperlink.cs" and associated files
represent the Hyperlink sample.

=== Running the sample:

To display a print preview of a particular sample's grid, follow these steps:

* Run the application.
* Select the required sample from the drop-down list in the main app's window.
* Click the "Show Selected Sample" button to open the sample form containing the grid.
* Without closing the sample form with the grid, click the "PrintPreview Selected Sample" button.

You may adjust the PrintInfo properties in the main application's window as
needed at any moment - those will be used for the next print preview.

=== Sample categories:

All included samples fall into one of these categories:

* Samples printed "as is" using the C1FlexGridPrinter class (for example,
   "Analyze"). Those are samples containing a single grid without owner-
   drawn cells or other customizations. For these samples, the
   corresponding file(s) in the SampleForms subdirectory are exact
   copies of the files in the FlexGrid sample, usually just renamed
   after the original sample.

* Samples containing owner-drawn cells (for example, "BarChart"). To print
   owner-drawn cells, the grid must be of type C1FlexGridPrintable2
   (derived from C1FlexGrid). Conversion of an existing form using
   C1FlexGrid usually includes simply changing the FlexGrid's
   declaration and constructor call in the form code. This is all that
   is required to print owner-drawn cells (as the "BarChart" sample
   demonstrates).

* Samples declaring and using classes derived from C1FlexGrid (for example,
   "DataTree"). For full printing functionality, such classes need to be
   derived from C1FlexGridPrintable2 rather than from C1FlexGrid. For
   details, see the DataTree sample and especially the
   DataTree.C1FlexDataTree.cs file in it. Changes compared to the
   original sample are marked with "#region C1FlexGridPrinter".

* Some samples need to print several grids in a single document
   (for example, "CustomPrintMultiGrid"). In those cases, the sample form must
   derive from the IFlexSample (declared in IFlexSample.cs), and
   implement the MakeDoc method that creates and returns a
   C1PrintDocument containing all grids that need to be printed. Again,
   the changes in the original sample code in such cases are marked with
   "#region C1FlexGridPrinter".

=== Adding your own samples:

You may easily add your own forms containing C1FlexGrid to this app to see how
they print. To do so, follow these steps:

* Add your form to the SampleForms folder in the project.
* If your form contains a single C1FlexGrid that you want to print
  preview, simply add your form to the main form's combo - see
  FillSamplesCombo() method in MainForm.cs for details.

* In more complex cases, decide how you want to print your grid, and
  follow the matching sample from those listed above (for example, to print a
  grid with owner-drawn cells, follow the "BarChart" sample).

=== Interesting samples:

Some of the more interesting samples included in this integrated application
that demonstrate specific printing techniques include:

* DataTree: printing nested grids.
* CustomPrint: explicitly controlling the number of rows and columns printed per page.
* HostControls: printing controls hosted in grid cells.
* Hyperlink: preserving hyperlinks (useful for print preview or export).
* MergeStyles: printing custom borders using the C1PrintDocument object model.
* RTFGrid: rendering RTF as C1.C1Preview.RenderRichText rather than relying on owner draw cell support.
* Splits: custom renders four grids representing "splits".
