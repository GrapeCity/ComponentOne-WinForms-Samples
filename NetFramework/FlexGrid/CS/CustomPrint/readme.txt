CustomPrint
------------------------------------------------------------------------
Use the CreateImage method to print grids with arbitrary row and column breaks.

The PrintGrid method allows you to customize several parameters when printing and previewing grids. However, it only offers limited control over row and column breaks.

This sample marks selected rows and columns as break points, then implements a class derived from PrintDocument that can be used to print or preview the grid honoring the pre-set break points.

The PrintDocument class creates grid images for each page and sets the zoom level so all images will fit on the page.