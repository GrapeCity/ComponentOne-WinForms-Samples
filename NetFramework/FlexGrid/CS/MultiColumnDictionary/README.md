## MultiColumnDictionary
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\MultiColumnDictionary)
____
#### Use the MultiColumnDictionary class to implement multi-column drop-downs.
____
The MultiColumnDictionary class implements IC1MultiColumnDictionary and can be used as a multi-column data map based on string data or on data sources (any object that implements ITypedList). 

The MultiColumnDictionary class has two constructors. 

One constructor takes a string that contains a pipe-delimited list of items. Each item contains a tab-delimited list of columns. For example:  // create string-based MultiColumnDictionary and assign it to column // note: this will automatically generate keys of type int for each item, // the key values will be stored in the grid. string text = "Row1, Col1\tRow1, Col2|Row2, Col1\tRow2, Col2"; MultiColumnDictionary map = new MultiColumnDictionary(text, 0, true); _flex.Cols[1].DataMap = map;  The other constructor takes four parameters: a data source, the name of the column that contains the data stored in the grid, a list of fields to display in the dropdown list, and the index of the column that should be shown in the grid when the list is closed. For example:  // create data-based MultiColumnDictionary and assign it to column // note: the list will automatically be updated is the data source changes. DataTable dt = GetDataTable("employees"); string[] columnNames = new string[] { "FirstName", "LastName", "Country" }; MultiColumnDictionary map = new MultiColumnDictionary(dt, "EmployeeID", columnNames, 1); _flex.Cols[2].DataMap = map; 