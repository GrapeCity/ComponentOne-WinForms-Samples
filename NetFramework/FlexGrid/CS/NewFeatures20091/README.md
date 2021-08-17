## NewFeatures V1/2009
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\NewFeatures20091)
____
#### Shows new features added for the V1/2009 release.
____
This release adds six features that were requested by users.
The sample contains one tab to demonstrate each of the new features:
1. NewRowWatermark property.
   This new property allows you to specify a string that is displayed in the new row template that appears when the AllowAddNew property is set to true.
2. ClipboardCopyMode property.
   This new property allows you to configure the grid so the column and/or row headers are included in the data provided by the Clip property and 
   also in the content copied to the clipboard when the AutoClipboard property is set to true.
3. RowValidating and RowValidated events.
   These events fire when the grid loses focus or when a different row is selected.
   They allow you to perform row-level validation and optionally prevent the user from leaving a row if it fails validation.
4. BeforeSubtotal and AfterSubtotal events.
   These events fire before and after each subtotal row is created after a cell to the Subtotal method. 
   They allow you to customize the subtotal rows and modify their style, content, or suspend the creation of some subtotal rows altogether.
5. AllowMergingFixed property.
   This property allows you to specify different merging modes for fixed and scrollable cells.
   It is especially useful in situations where you want to merge column headers using one merge mode and data using a different mode.
6. More options for the EditOptions property:

* EditFlags.ExitOnLeftRightKeys.
      When this flag is set to true (the default setting), the built-in text and numeric editors exit edit mode if the user presses the left arrow key when 
      the caret is at the first position or when the user presses the right key and the caret is at the last position (TextLength).
      When this flag is set to false, the built-in text and numeric editors do not exit edit mode until the user presses enter or clicks a different cell.

* EditFlags.EditOnRequest.
      When this flag is set to true (the default 	setting), the grid does not enter edit mode until the user starts typing or double-clicks a cell (Excel behavior).
      When this flag is set to false, the grid enters edit mode automatically whenever it gets the focus or the selection changes (Access behavior).
