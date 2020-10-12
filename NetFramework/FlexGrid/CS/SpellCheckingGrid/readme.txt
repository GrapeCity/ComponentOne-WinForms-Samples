SpellCheckingGrid
-------------------------------------------------------------------------------------------
Shows how you can implement as-you-type spell-checking on a C1FlexGrid.

The sample uses a C1SpellChecker control to detect typos in grid cells. It then uses the 
grid's OwnerDraw feature and a few new methods in the C1FlexGrid's CellStyle object to 
paint the familiar red wavy underlines under the misspelled words.

The sample uses the new CellStyle.StringFormat property and the new CellStyle.GetTextRectangle 
method to position the underlines precisely under the offending words.

The sample also shows how to implement modal, dialog-based spell checking on the grid.