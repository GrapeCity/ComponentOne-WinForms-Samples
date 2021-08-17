DataEngineQueries
------------------------------------------------------------------------
DataEngine queries for data integration, transformation, and aggregation.

ComponentOne DataEngine powers FlexPivot control, but it is not its only purpose.
DataEngine can also be used on its own, separate from FlexPivot, to integrate (blend, join), transform, and aggregate (analyze) data.
This is done by executing DataEngine queries.
A query takes data from base tables or from other queries, performs operations on that data that can include joining multiple tables, filtering,
calculations, grouping, aggregation, and saves results as a new table in the DataEngine.
Query results can then be used in various ways including but not limited to:
 - showing results in a grid (for example, aggregation results, for analysis);
 - feeding results to FlexPivot for analysis (for example, joining several tables so FlexPivot can analyze the joined table);
 - further programmatically transform the results to perform any batch tasks on data.

This sample shows query results in a grid. It includes the following queries:
 - Join two tables and aggregate: how many times each product was ordered (from Order Details) and how many items are left in stock (from Products table).
 - Join two tables and feed the result to FlexPivot for analysis.
 - Range (from-to) and aggregation: products within specified unit price range.
 - Custom calculation and aggregation: discount information for the specified product.
 - Cascade queries, range (filtering) and aggregation: products that were ordered more than the specified number of times.
 - Cascade queries, date operations, aggregation: orders information by months.