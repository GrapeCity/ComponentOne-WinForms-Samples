FindRow
-----------------------------------------------------------------------------
How to find a row in the underlying datasource.

This samples finds a newly added row in the datasource and automatically
selects it.  The underlying datasource that the grid is attached to is sorted,
so you don't know where the new row will be displayed.  The sample uses the
same IBindingList that the grid is using to find the new row and add it to the
SelectedRows collection.