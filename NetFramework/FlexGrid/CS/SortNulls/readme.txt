SortNulls
------------------------------------------------------------------------
Use a custom sort to place null values at the bottom of the grid.

The sample handles the BeforeSort event that fires when the user clicks the 
column headers to sort the grid. It then cancels the built-in sorting and instead
calls the Sort method with a custom IComparer that places null values at the
bottom of the list regardless of the sort order.