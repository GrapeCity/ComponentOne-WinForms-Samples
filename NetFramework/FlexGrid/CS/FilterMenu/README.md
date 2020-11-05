## FilterMenu
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\FilterMenu)
____
#### Shows how you can invoke column filter editors from a menu.
____
The C1FlexGrid has a built-in column filtering feature that is enabled using the AllowFiltering property. 

Once filtering is enabled, users can edit filters for each column by clicking the column headers. The filter editor allows users to set the filter based on values present in the column or by specifying conditions that must be met in order for the rows to be visible. 

The grid's object model exposes a rich object model that allows you to configure and control the filters programmatically. 

This sample shows how to extend the filtering UI to provide filter control using a ToolStrip. The ToolStrip contains two menus, one for editing the column filters and one for clearing them. 

After the data is bound, the code populates the "Edit Filter" menu with one item for each column. Clicking these items invokes the filter editor with a call to the "EditFilter" method. 

When the user drops down the "Clear Filter" menu, the code populates the menu with one item for each column that has an active filter. Clicking these items clears the corresponding filter with a call to the ClearFilter method. 



