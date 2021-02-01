## FlexHierarchical
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\FlexHierarchical)
____
#### Implement hierarchical data binding using the FlexGrid.
____
This is an advanced sample. It implements a composite control (FlexHierarchical) that contains a FlexGrid and a navigation area above it. The user can bind the grid to a hierarchical DataSet (or to DataTable objects within the DataSet) and drill down into child tables. 

Tables that contain child tables display a 'collapsed' icon on the first (fixed) column. Clicking on the icon shows a menu of child tables available. Selecting a menu item navigates to the child table. 

As the user drills down into the child tables, the parent hierarchy is displayed along the top of the control, where the user can click to navigate back up the data hierarchy. (The navigation model is similar to the one used by the Microsoft DataGrid control.) 

The control exposed the contained FlexGrid via a 'FlexGrid' property. It also exposes a 'ButtonTemplate' property that determines the appearance of the navigation buttons. The sample uses a PropertyGrid control so you can change the properties of the FlexHierarchical control at run time and see their effect. 

