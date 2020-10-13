CustomFilters
---------------------------------------------------------------------------
Shows how to implement custom filters for the C1FlexGrid.

The C1FlexGrid provides three built-in column filters that allow filtering
most data types easily and efficiently. These filters are:

- ValueFilter: Shows a list of values present in the column and allows the
  user to select which specific values should be displayed.
  
- ConditionFilter: Shows two conditions defined by an operator and a 
  parameter (e.g. "greater than" and "2") and allows the user to combine
  the operators with an AND or an OR condition.
  
- ColumnFilter: Combines a ValueFilter and a ConditionFilter and allows 
  users to choose which one to use for each column at runtime.
  
In some cases, you may want to implement your own specialized filters. For
example, if the grid displays geographic information you may want to use
a filter that limits the distance between a certain target location and the
location described by a row or column on the grid.

This can be done by creating two classes:

- A filter class that implements the IC1ColumnFilter interface, and
- An editor class that implements the IC1ColumnFilterEditor interface.

The editor allows users to modify and configure the filter at runtime.

This sample shows the implementation of a three custom filter classes:

- ColorFilter:  selects colors which are close to a given target color.
- DateFilter:   selects dates using a MonthCalendar (like the filter in Win7)
- StringFilter: selects strings based on ranges (like the filter in Win7)

