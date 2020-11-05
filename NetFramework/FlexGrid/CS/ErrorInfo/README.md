## ErrorInfo
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\ErrorInfo)
____
#### Show error information on the grid.
____
The C1FlexGrid control supports the IDataErrorInfo interface. This is the .NET mechanism used by data source objects to expose errors in the data. 

When the ShowErrors property is set to true, the grid will detect errors and show them using an icon in the cells (for field-specific errors) or along the first column (for record-level errors). When the user moves the mouse over the error icon, a tooltip shows the error description. This UI is also a .NET standard, used in the ErrorProvider class. 

To add error information to DataTables, use the DataRow's SetColumnError method and RowError property. The former attached error information to fields. The latter, to entire records. 

If your grid is unbound, or the data source you are using does not support the IDataErrorInfo interface, you can use the GetCellErrorInfo and GetRowErrorInfo events instead, and assign the error message you want to use to the e.ErrorText property. 