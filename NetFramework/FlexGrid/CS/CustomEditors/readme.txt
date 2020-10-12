CustomEditors
------------------------------------------------------------------------
Use built-in, .NET, and custom edit controls with the FlexGrid.

The sample shows how to implement the IC1EmbeddedEditor interface to
allow any .NET controls to be used as grid editors. In addition to
the built-in editors (checkboxes, masked text, combo, list), you can
use the C1Input editors or even implement your own.

The sample also shows how you can use the .NET UIEditor classes as 
C1FlexGrid editors.

You can attach any editor to any grid row, column, or cell range using
the new CellStyle.Editor property.