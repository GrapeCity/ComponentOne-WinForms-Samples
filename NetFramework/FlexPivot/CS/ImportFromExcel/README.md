## ImportFromExcel	
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\CS\ImportFromExcel)
____
#### Importing data from Excel.
____
This project shows how to import data from an Excel spreadsheet to C1 DataEngine so that end users can perform data analysis in C1FlexPivotPage control.

Notes:
 1. To work with data in an Excel/Access file, you need a driver of the same platform as the installed MS Office (x86 or x64).
    The OLE DB driver (Microsoft Access Database Engine 2016 Redistributable) can be downloaded at https://www.microsoft.com/en-us/download/details.aspx?id=54920.
 2. When loading data from an Excel/Access file an "An exception of type 'System.InvalidOperationException' occurred in System.Data.dll..." appears,
    then in the project settings you must specify the platform that matches the installed OLE DB driver: Build -> Platform target = 'x86' or 'x64'.
