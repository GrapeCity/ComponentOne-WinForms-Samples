## CustomizeFilters
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\CustomizeFilters\CustomizeFilters)
____
#### Shows how you can customize the C1FlexGrid column filters programmatically.
____
The C1FlexGrid provides a built-in filtering mechanism that is enabled by setting the AllowFiltering property to true. Once filtering is enabled for the grid, you can customize the filter used by each column by using the column's AllowFiltering and Filter properties. 

This sample shows how you can enable filtering and initialize the filters on two columns using code. The code initializes the filters on two columns: 

The "ShipRegion" column is initialized to show only two states. This is done using a value filter as follows: 

```
	// initialize "ShipRegion" column filter to show only two values: "AK" and "CA"
	var col = _flex.Cols["ShipRegion"];
	col.AllowFiltering = AllowFiltering.ByValue;
	var vf = col.Filter as ValueFilter;
	vf.ShowValues = new object[] { "AK", "CA" };
```

The "UnitPrice" column is initialized to show only items with a unit price greater than $30. This is done using a condition filter as follows: 

```
	// initialize "UnitPrice" column filter to show only values greater than $30
	var col = _flex.Cols["UnitPrice"];
	col.AllowFiltering = AllowFiltering.ByCondition;
	var cf = col.Filter as ConditionFilter;
	cf.Condition1.Operator = ConditionOperator.GreaterThan;
	cf.Condition1.Parameter = 30;
```

After both column filters have been initialized, the filter is applied with a call to the grid's ApplyFilter method. 