FlexGridReport
------------------------------------------------------------------------
Use a C1FlexGrid control as a data source for your reports.

The sample builds a report based on a C1FlexGrid control. This is done 
in two steps: 

First, the sample creates a report definition based on the names and 
widths of the grid columns.

Then is creates a DataSource object that retrieves data from the grid
and feeds it to the report component.

Note that in this sample, the grid is bound to a DataTable, which could
be used directly as a data source. But the approach used here is 
general and would work on unbound grids as well.