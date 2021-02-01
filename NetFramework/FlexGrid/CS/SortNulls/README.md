## SortNulls
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\SortNulls)
____
#### Use a custom sort to place null values at the bottom of the grid.
____
The sample handles the BeforeSort event that fires when the user clicks the column headers to sort the grid. It then cancels the built-in sorting and instead calls the Sort method with a custom IComparer that places null values at the bottom of the list regardless of the sort order. 