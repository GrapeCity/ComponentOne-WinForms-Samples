## MultiParent
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\MultiParent)
____
#### Shows how to create a complex master-detail display.
____
You can create simple master-detail forms by binding a master grid to a data table and binding a detail grid to a data relation, e.g.

```
  _flexMaster.SetDataBinding(ds, "Orders");
  _flexDetail.SetDataBinding(ds, "Orders.Orders_Details");
```
This sample shows how you can create a master grid that allows multiple selection.
The detail grid will show the detail for all master items in the selection.

![screenshot](screenshot.png)
