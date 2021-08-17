## QuickStart
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\CS\QuickStart)
____
#### Shows Northwind sales data.
____
This project uses a SQL query to retrieve NorthWind sales data and performs analytics on that data.
The C1FlexPivotPage allows the user to see different views of the data, including a pivot grid and a chart.

This sample also demonstrates two data options available in C1FlexPivot (third option, OLAP cub is demonstrated in a separated sample).
To see difference in performance, try selecting radio buttons for different number of rows.
For smaller data sets, not exceding about 100,000 rows, a standard ADO.NET DataTable can be used.
For larger data sets, C1 DataEngine provides a much more performant option. It can handle tens of millions rows and more very fast, usually in a fraction of a second.

A menu item is added to C1FlexPivotPage where the user can select preconfigured analytical views.
