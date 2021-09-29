FlexGridExplorer
----------------------------
Shows all the features of FlexGrid control.

FlexGridExplorer is the single source for you to learn about FlexGrid. 
It shows all the features of FlexGrid in an easy to explore hierarchy.

Included samples:
- Overview.
  This view shows the basic FlexGrid features.
- Filtering.
  FlexGrid provides three built-in filters that allow filtering most data types easily and efficiently. Value filters show a list of values present in the column and allow the user to select which specific values should be displayed. Conditional filters show two conditions defined by an operator and a parameter (e.g. 'greater than' and '2') and allows the user to combine multiple operators using AND and OR conditions. In some cases, you may want to implement custom filtering by creating a filter class and an editor class which allows users to configure the filter at runtime. This demo shows default text and numeric filtering, as well as custom color, date and range filtering.
- Scrolling.
  Turn on delayed scrolling by just setting the ScrollOptions property. Using ShowScrollTip event, you can set a scroll tip based on the current scroll position and sort order.
- Freezing.
  FlexGrid supports freezing rows and columns both from code and by end-user. To allow the user to freeze rows and columns with the mouse, set the AllowFreezing property to Columns to freeze only columns, Rows to freeze only rows, or Both to freeze both columns and rows.
- PinnedColumns.
  FlexGrid supports pinning singe column at time (top sample) or column range (bottom sample). To allow the user to pin and unpin columns, set AllowPinning property to SingleColumn or ColumnRange.
- Performance.
  FlexGrid is capable of handling millions of records and includes a few tricks for getting optimal performance. For instance, set the Redraw property to false before data binding to prevent the grid from painting during load time. Set the AutoResize property to false to turn off automatic column and row resize, which can be expensive for larger data sets. Click 'Generate Items' in this demo to fill a list of items and populate the FlexGrid.
- Unbound.
  FlexGrid is designed for optimal performance in both bound and unbound modes. When working with an unbound FlexGrid, you have complete control over column behavior. In this demo we created a form where users enter Proceeds and Payments and we wired up the remaining columns to calculate new values.
- RowDetails InputPanel.
  Row detail allow to show additional content in the expandable area after the regular row. To use row detail for inline editing, set the RowDetailProvider property to the lambda expression returning a new instance of the C1InputPanelRowDetail class.
- RowDetails FlexGrid.
  Row details allow to show additional content in the expandable area after the regular row. You can use row detail for master - detail data presentation by using C1FlexGridRowDetail control.
- RowDetails Inheritance.
  Row details allow to show additional content in the expandable area after the regular row. To customize appearance or functionality of the standard detail control, you can derive the new row detail control from the C1InputPanelRowDetail and override one or more virtual methods of the IC1FlexGridRowDetail interface.
- RowDetails Custom.
  Row details allow to show additional content in the expandable area after the regular row. You can create your own row detail control and setup it as you want.The custom row detail control must implement the IC1FlexGridRowDetail interface.