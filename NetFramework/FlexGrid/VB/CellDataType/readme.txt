CellDataType
------------------------------------------------------------------------
Assign cell types (and editors) on a per-cell basis.

Starting with version 2.1 of the FlexGrid, several properties that used to belong to Column objects now belong to the CellStyle.
These include DataType, Format, ComboList, DataMap, and more.

The main advantage of the new approach is that now you can associate these elements with arbitrary cell ranges, rather than with columns only.

This sample creates styles for entering and displaying different data types, and assigns these styles to specific cell ranges, so you can have dates, strings, and currencies in the same column.