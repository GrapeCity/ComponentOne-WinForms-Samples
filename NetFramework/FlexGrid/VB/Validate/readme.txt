Validate
------------------------------------------------------------------------
Use the ErrorProvider control with the FlexGrid.

The ErrorProvider control allows you to display a blinking caret next to any data-entry control, with a tooltip that describes the error.

It is often a better option that popping up a MessageBox, or showing a string in a status bar where it might go unseen.

The sample checks the data in the grid's ValidateEdit event.
If the data is invalid, it sets the ErrorProvider text associated with the grid, which causes the blinking error icon to appear.