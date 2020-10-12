LoadSpeed
------------------------------------------------------------------------
Shows three techniques for loading data into a FlexGrid.

The sample compares three techniques for loading data into the grid:

1) AddItem with regular string concatenation and Redraw = true (slowest)

2) AddItem with StringBuilder concatenation and Redraw = false (faster)

3) Direct cell assignment (no string conversion) and Redraw = false (fastest)