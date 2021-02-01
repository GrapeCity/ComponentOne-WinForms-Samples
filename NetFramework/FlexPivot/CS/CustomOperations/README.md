## Custom Operations
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\CS\CustomOperations)
____
#### DataEngine queries with custom (user-defined) operations
____
ComponentOne DataEngine supports user-defined operations. Programmers can write arbitrary	code in a custom class, that will constitute the body of a custom operation. User-defined operations have the same superior performance as standard DataEngine operations, because loop over data, including indexing, is performed by DataEngine using the same optimizations as in the standard operations. 

This sample uses two custom operations: 

ProgressiveDiscount: operation without grouping, calculating discount for an order line based on the product and ordered quantity. Different products have different quantity thresholds. 

BigOrders: Group (aggregation) operation calculating total count of 'big' orders for a product. Whether an order is considered big depends on the product and ordered quantity. 

These two operations demonstrate that programmers can write arbitrary code, implementing any business rules they need and get the same lightning-speed performance as with standard DataEngine operations. To compare performance, the sample includes a query using only standard operations for each of the two queries with custom operations. You can try custom queries and their corresponding standard queries with large number of rows, up to 10 million, and see that execution time is virtually the same, just about a second on 10 million rows. 