FakeStudio
------------------------------------------------------------------------
Create a user interface that looks like Visual Studio.

This sample has no code. It contains a single C1Sizer control with
three rows and three columns, and several child controls arranged within
the C1SizerGrid.

The layout grid was set up at design time with the C1Sizer's grid editor.

Most of the rows and columns were set up as splitters, to the user
can resize them at runtime using the mouse.

Some rows were set up as fixed-size, so when the form is resized they
are not resized proportionally, but retain their dimension (this is
especially useful to set up headers).

Some of the grid panes contains Panel controls, which in turn contain
other controls that are docked within the panel. The C1Sizer itself is 
docked to fill the form. This shows how the C1Sizer control works with 
the layout support provided by the .NET framework.