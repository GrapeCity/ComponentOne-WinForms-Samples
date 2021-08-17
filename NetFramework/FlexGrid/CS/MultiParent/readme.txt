MultiParent
--------------------------------------------------
Shows how to create a complex master-detail display.

You can create simple master-detail forms by binding a master grid to a data table and binding a detail grid to a data relation, e.g.

<code>
  _flexMaster.SetDataBinding(ds, "Orders");
  _flexDetail.SetDataBinding(ds, "Orders.Orders_Details");
</code>

This sample shows how you can create a master grid that allows multiple selection.
The detail grid will show the detail for all master items in the selection.