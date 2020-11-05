## SqlFilter
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Olap\CS\SqlFilter)
____
#### Shows Northwind sales data.
____
This project uses a SQL query to build a DataTable containing the NorthWind sales data, then uses this table as a data source for a C1OlapPage control. 

The C1OlapPage allows the user to see different views of the data, including an Olap grid and an Olap chart. 

The interesting part of this project is that not all data is loaded into memory at a time. The program updates the SQL query with a WHERE clause to include only the customers selected by the user in the value filter of the Customer field. 

The sample uses a CachedDataTable class that has a sql template and a 'where clause' string. The table and re-queries the db when the where clause changes. The cache is used to prevent hitting the db repeatedly every time the user changes the query. Instead, those results are cached and stay in memory. Whether caching the data in memory is a good idea depends on the nature and size of your data and application. 

The more important thing is the sample keeps two lists: "all customers", and "active customers". The "all customers" list is used to populate the field's filter list, so users can select customers that are not currently in the dataset. The "active customers" list is the one used in the analysis. 