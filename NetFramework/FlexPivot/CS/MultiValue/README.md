## MultiValue
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\CS\MultiValue)
____
#### Shows how you can use C1FlexPivot to analyze multiple fields in one view.
____
By default, C1FlexPivot only allows one value field per view. When the user adds a field to the Values list, the new field replaces any  other fields that might be there.

Starting with build 70, the C1FlexPivotFieldList class has a new MaxItems property.
This property allows you to determine how many fields are allowed in each field list (Rows, Columns, Filters, and Values).

If you set the MaxItems of the Values list to a number higher than one, users will be able to add multiple fields to the values list,
and the analysis will be performed on all of them at once.

For example:

```
	// prepare to define FlexPivot view
    var fp = this.c1FlexPivotPage1.FlexPivotEngine;
	fp.BeginUpdate();

	// group data by product and country
    fp.RowFields.Add("ProductName");
    fp.ColumnFields.Add("Country");

	// show total extended price and freight values
    fp.ValueFields.MaxItems = 5;
    fp.ValueFields.Add("ExtendedPrice", "Freight");

	// ready
	fp.EndUpdate();
```
You can also use the MaxItems property on the Rows, Columns, and Filters lists if you want to limit the number of fields users can add to those lists.
It rarely makes sense to have more than three or four Row or Column fields for example.
