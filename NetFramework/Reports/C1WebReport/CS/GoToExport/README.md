## WebReportGoToExport 
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1WebReport\CS\GoToExport)
____
#### Deliver Pdf, Rtf, Xls, and Html reports through the browser.
____
The .NET 2.0 version of C1WebReport has an Export method that allows you to provide users with Pdf, Rtf, Xls, and Html versions of your report. 

The export functionality is exposed in the navigation bar. Set the HasExportButton property to true to enable this feature, and use the ExportFormats property to define which export formats you want to make available. 

You can also call the Export method directly from your code, and the user will receive the reports in the format you selected right in their browser. You can deploy reports using temporary files or the built-in http handler, depending on the setting of the ExportRenderMethod property. 