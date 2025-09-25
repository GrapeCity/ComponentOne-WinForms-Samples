FlexGrid Context Menu
--------------------------------------------
This application extends the functionality of the C1FlexGrid control by introducing a right-click context menu. The menu dynamically adjusts based on the clicked area whether it's a column header, row header, or cell using the ContextMenuStrip property and the ColumnContextMenuOpening event. 

Command Categories

1. Column Header
   • Built-in Commands
   • Rename: Change the column header text.

2. Row Header
   • Delete Row: Remove the selected row.
   • Add Row Above: Insert a new row above the selected row.
   • Add Row Below: Insert a new row below the selected row.

3. Cell
   • Cut / Copy / Paste: Perform basic clipboard operations.
   • Clear Content: Remove the contents of the selected cells.
   • Select All: Highlight the entire grid.
   • Edit Cell: Enable inline editing for the selected cell.
   • Delete Row: Remove the row containing the active cell.
   • Add Row Above: Insert a new row above the active cell’s row.
   • Add Row Below: Insert a new row below the active cell’s row.
   • Filter: Filter by the current cell value or clear applied filters.
   • Sort Ascending: Sort by ascending order based on the selected column.
   • Sort Descending: Sort by descending order based on the selected column.