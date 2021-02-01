## LockedColumns
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\LockedColumns)
____
#### Prevent the user from selecting certain columns.
____
The C1FlexGrid has an AllowEditing property that can be used to prevent users from editing cells in certain rows and columns. However, it doesn't have properties to prevent users from selecting cells in certain rows and columns. 

This sample uses the BeforeSelChange event to prevent the user from selecting cells in certain columns. The code doesn't simply cancel invalid selections, it moves the cursor past the locked columns. 