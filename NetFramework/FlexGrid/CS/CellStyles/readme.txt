CellStyles
------------------------------------------------------------------------------------------
Shows how you can assign styles to individual cells and modify them on the fly.

The sample contains buttons that allow users to change cell font styles and text alignment.

In most applications, styles are shared among many cells that have the same attributes.
For example, the Normal style is used for scrollable cells, the Fixed style is used for 
row and column header cells, etc.

In this sample, each cell has its own individual style, not shared with any other cells.
This allows users to modify the style of any cell without affecting any other cells.

When the user clicks a button in the toolstrip, the sample enumerates all the individual
cells in the selected range. For each cell, it performs these steps:

1) Get the current cell style
2) Create a new style and use the MergeWith method to copy the attributes from the original style
3) Change the attribute that corresponds to the button that was clicked
4) Assign the modified style to the cell.

