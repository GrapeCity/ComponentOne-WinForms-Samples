## TriStateBound
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\TriStateBound)
____
#### Provide three-state (grayable) values in boolean columns.
____
By default, the grid will show DBNulls as grayed checkboxes, but once you change them it will toggle between true and false (that's what a boolean is).
That's the MS Access behavior.

If you want to allow null values in the table, you can handle the ValidateEdit event and assign the underlying value directly, allowing for DBNulls.
That's the MS DataGrid behavior.
