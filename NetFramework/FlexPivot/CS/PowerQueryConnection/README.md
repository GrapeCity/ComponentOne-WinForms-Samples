## PowerQueryConnection
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\CS\PowerQueryConnection)
____
#### Shows how to use Power Query to import data to DataEngine.
____
Power Query (part of Excel) has connectors to multiple data sources, including cloud and big data.
In this sample, Excel is invisible, used behind the scenes from user application code via automation to get data from a Power Query data source directly to DataEngine.
The data is used in the same application for analysis in FlexPivot.

For this sample to work, Excel 2016 must be installed on the machine (or Excel 2013 with Power Query add-in) and DataEngine add-in must be installed in Excel.
To install DataEngine add-in, first execute C1FlexPivot\ExcelAddIn\bin\registerCOM.bat as Administrator,
and then double-click the file C1FlexPivot\ExcelAddIn\bin\C1.DataEngine.ExcelAddIn.vsto
