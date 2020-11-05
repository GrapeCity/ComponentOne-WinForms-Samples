## FilterRow
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\FilterRow)
____
#### Implement a FilterRow on a FlexGrid control.
____
To use this sample class, bind a FlexGrid to a DataTable or DataView object, then create a FilterRow passing the grid as a parameter to the constructor. 

The FilterRow class will then do three things: 

1 - Add a new Fixed row to the grid. This new row will be the 'filter row'. 

2 - Trap mouse and keyboard events to select cells in the filter row. The user can select the filter row by clicking on its cells, by pressing F3, or by moving to the top row and pressing the up arrow. The user can remove the filter by clicking the first fixed column on the filter row, then pressing the Delete key. 

3 - Trap the RowColChange event to update the filter expression and apply it to the grid's data source. The filter expression may contain: a) Simple values (e.g. "Smith"). These are translated into filter expressions such as "like 'Smith*'". If you type "s" in the filter row, the grid will show only rows where the corresponding entry starts with "s". b) Logical expressions (e.g. "> a", "= US"). These are translated into filter expressions such as "> 'a'" and "= 'US'". If you type ">=12" in the filter row, the grid will show rows where the corresponding entry is 12 or a higher value. 