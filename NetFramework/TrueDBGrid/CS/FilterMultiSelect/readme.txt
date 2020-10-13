FilterMultiSelect
-----------------------------------------------------------------------------
How to set up multiple selections in column filters.

This sample contains a checked list box of column names on the left and the grid and the right.
If a column selected in the list then FilterMultiSelect of the column is set to True and the 
filter drop down allow to select multiple values from the list.
Initially a few columns are checked in the list and two of them have initial set of filter values.
"CustomerID" column allows filtering by initial letters because of FilterOperator property set to "like%".