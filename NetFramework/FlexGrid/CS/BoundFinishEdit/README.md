## BoundFinishEdit
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\BoundFinishEdit)
____
#### Commit changed to DataRow after editing.
____
After you edit a cell in a data-bound grid, the underlying DataRow doesn't get immediately marked as modified, and its DataRowState property remains unchanged until you move the cursor to a new row or the grid loses focus. 

This is the design behavior, because row-level validation often cannot be performed until all the fields in the row have been edited. 

In some cases, you may want tell the data source that you are done editing the row, even though the cursor and focus haven't changed. The sample shows how you can do that using the CurrencyManager.EndCurrentEdit() method. 

