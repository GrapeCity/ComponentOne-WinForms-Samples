## BarChart
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\VB\BarChart)
____
#### Draw bar charts using the grid cells.
____
This sample uses OwnerDrawn cells to build a chart based on the grid data.

It starts by binding the grid to a data source.
It then uses the Aggregate method to find the largest value on each of the columns that will contain bar charts, and saves that information in the column's UserData member.

Next, the application sets the DrawMode property to OwnerDraw, which causes the grid to fire the OwnerDrawCell event.
Finally, the OwnerDrawCell event handler retrieves the scaling information from the column, draws the cell background as usual, then the bar, then the cell foreground.

The nice thing about this approach is that you can sort, move, and resize columns and the bars will be updated automatically.
You can also add text and images to cells as usual, and that will be displayed along with the bars.

If you edit a cell, the bar will be updated as usual.
However, if you type a very large value, or a negative one, the bar will not be drawn correctly.
This is because the scaling information is stored in the column (UserData) in the Form_Load event, and is not updated after that.
You can fix this by calling the scaling routines from the AfterDataRefresh event. 
This is left as an exercise for the reader.
