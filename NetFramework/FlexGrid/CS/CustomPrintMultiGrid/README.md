## CustomPrintMultiGrid
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\CustomPrintMultiGrid)
____
#### Use the CreateImage method to print multiple grids in a single document.
____
The PrintGrid method allows you to customize several parameters when printing and previewing grids. However, it only allows you to print one grid per document. 

This sample implements a class derived from PrintDocument that can be used to print or preview multiple grids, with page breaks set at specific rows and columns. 

The PrintDocument class creates grid images for each page and sets the zoom level so all images will fit on the page. 