## SortMappedColumns
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\SortMappedColumns)
____
#### Shows how to sort mapped columns with a C1FlexGrid.
____
The C1FlexGrid allows you to associate data maps with each column so they store a key and display a corresponding associated value.
For example, the grid could have a column that contains Customer IDs mapped to Customer names.
In this case, the grid would store the customer IDs internally, but would display the customer names instead.

In these situations, sorting will be based on the key, and not on the mapped value.
This happens because the sort is handled by the data source object (usually a DataTable), and the data source has no knowledge of the mapping.

If you want the sorting to be done based on the mapped values (not on the keys), then the easiest alternative is to create calculated columns that contain the mapped values,
and handle the grid's BeforeSort event to defer the sort to the calculated columns.
For example:

```
    // intercept sort command and sort by mapped column instead
    void _flex_BeforeSort(object sender, C1.Win.C1FlexGrid.SortColEventArgs e)
    {
        if (_flex.Cols[e.Col].Name == "CustomerID")
        {
            int col = _flex.Cols["CustomerMapped"].Index;
            _flex.Sort(e.Order, col);
            _flex.ShowSortAt(e.Order, col);
            e.Handled = true;
        }
        else if (_flex.Cols[e.Col].Name == "EmployeeID")
        {
            int col = _flex.Cols["EmployeeMapped"].Index;
            _flex.Sort(e.Order, col);
            _flex.ShowSortAt(e.Order, col);
            e.Handled = true;
        }
    }
```
The code checks the name of the column being sorted on, and if it is one of the mapped columns it sorts based on value instead of key.
It calls the ShowSortAt method to display the sort glyph on the column that was clicked by the user.

Creating the calculated columns can be done in two ways:
1. Using DataRelations. If the tables that contain the values and the keys belong to the same DataSet and are linked by relations,
   then the calculated expression can be built easily, using the Parent(relation).Property syntax.
   For example:

```
    ds.Tables["Orders"].Columns.Add(
		"CustomerMapped",	// column name
		typeof(string),		// column type
		"Parent(Order_Customer).CompanyName"); // expression
```
2. Using IIF statements. If the tables are not connected by relations, you can use the IIF statement to build lookup tables.
   This can be done automatically with a method such as the BuildExpression used in this sample:

```
    string BuildExpression(int i, DataTable dt, string key, string value)
    {
        if (i < dt.Rows.Count)
        {
            return string.Format("IIF({0} = '{1}', '{2}', {3})",
                key,
                dt.Rows[i][key],
                dt.Rows[i][value].ToString().Replace("'", "''"),
                BuildExpression(i + 1, dt, key, value));
        }
        else
        {
            return "'NOT FOUND'";
        }
    }
```