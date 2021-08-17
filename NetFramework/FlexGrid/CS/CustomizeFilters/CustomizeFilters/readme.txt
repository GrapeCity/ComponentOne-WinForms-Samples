CustomizeFilters
--------------------------------------------------------------------------------
Shows how you can customize the C1FlexGrid column filters programmatically.

The C1FlexGrid provides a built-in filtering mechanism that is enabled by setting the AllowFiltering property to true.
Once filtering is enabled for the grid, you can customize the filter used by each column by using the column's AllowFiltering and Filter properties.

This sample shows how you can enable filtering and initialize the filters on two columns using code. The code initializes the filters on two columns:

The "ShipRegion" column is initialized to show only two states. This is done using a value filter as follows:

<code>
	// initialize "ShipRegion" column filter to show only two values: "AK" and "CA"
	var col = _flex.Cols["ShipRegion"];
	col.AllowFiltering = AllowFiltering.ByValue;
	var vf = col.Filter as ValueFilter;
	vf.ShowValues = new object[] { "AK", "CA" };
</code>

The "UnitPrice" column is initialized to show only items with a unit price greater than $30. This is done using a condition filter as follows:

<code>
	// initialize "UnitPrice" column filter to show only values greater than $30
	var col = _flex.Cols["UnitPrice"];
	col.AllowFiltering = AllowFiltering.ByCondition;
	var cf = col.Filter as ConditionFilter;
	cf.Condition1.Operator = ConditionOperator.GreaterThan;
	cf.Condition1.Parameter = 30;
</code>

After both column filters have been initialized, the filter is applied with a call to the grid's ApplyFilter method.