DataIndex
------------------------------------------------------------------------
Use the Row.DataIndex property to get the underlying data row.

The Index property returns the index of a Row in the Rows collection, including fixed and node (subtotal) rows.
The DataIndex property counts only the data rows, and returns -1 for fixed and node rows.

The sample uses the DataIndex property to count the number of data rows on the grid and to get the DataRow object underlying the current row.