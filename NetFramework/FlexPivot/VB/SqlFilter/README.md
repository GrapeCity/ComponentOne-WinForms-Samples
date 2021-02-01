## SqlFilter
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\VB\SqlFilter)
____
#### Shows Northwind sales data.
____
This project uses a SQL query to build a DataTable containing the NorthWind sales data, then uses this table as a data source for a C1OlapPage control. 

The C1OlapPage allows the user to see different views of the data, including an Olap grid and an Olap chart. 

The interesting part of this project is that not all data is loaded into memory at a time. The program updates the SQL query with a WHERE clause to include only the customers selected by the user in the value filter of the Customer field. 