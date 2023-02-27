SortDataMap
--------------------------------------------------------------------------------------------
Shows how you can sort columns taking into account the DataMap attached to the column.

The FlexGrid allows you to attach data maps to columns. Data maps allow you to customize the information that is shown in the cells.
For example, instead of showing customer IDs, data maps allow you to show the customer names instead.

Data maps are also used when editing cells. Instead of typing in a customer ID, you pick the customer by name, from a drop-down list.

However, when you sort the grid based on columns that have data maps attached to them, the sort order is determined by the underlying data source,
which is usually a DataTable object that doesn't know anything about the data map.
Because of this, the sort order reflects the raw data, not the mapped data.
In our example, the rows are sorted by customer ID, not by customer name.

This sample shows how you can make the grid sort the rows by mapped value, rather than by raw data.

The sample handles the BeforeSort event to add a new column to the DataTable.
This new column is made invisible and is filled with the mapped values.
The grid then sorts the table based on this new column, rather than on the one that was clicked.

The sample also handles the AfterEdit event to update the content of the hidden sort column after the user edits the column that contains the data map, so the sorting is updated automatically.