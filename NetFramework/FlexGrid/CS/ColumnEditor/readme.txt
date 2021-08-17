ColumnEditor
------------------------------------------------------------------------
Expose the FlexGrid design-time column editor in your controls.

If you use the FlexGrid in UserControls and would like to allow users to edit the grid columns using the design-time editor,
your control must implement the ISupportInitialize interface and forward the notifications to the FlexGrid. This sample shows how to do it.

To use the design-time column editor, open the form at design time, select the user control, and check the "GridColumns" property in the Property Window.
Clicking the button next to the property value will open the FlexGrid's column editor which will allow you to customize the columns in the grid contained in the user control.