## PieGrouping
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Charts\VB\PieGrouping)
____
#### Demonstrates the use of stacked pie charts to group pie slices by category.
____
Stacked pie charts are concentric pies with each successive "point" forming an inner pie to the previous "point".  Each "point" value contains multiple pie slices represented by a "series". 

This sample creates a stacked pie chart showing the categorization of food products, with each data entry added to the chart as a separate series. 

DataLabels with Compass values of RadialText label each pie element with series (product) name, value and percentage of the whole. 

Grouping of the pie slices is performed by a class of the sample named PieGrouper.  The PieGrouper class simplifies input of values by allowing input with a tree like structure, and grouping values along the branches.  Finally, the class generates ChartDataSeries values for the chart creating the grouped by category concentric pies. 