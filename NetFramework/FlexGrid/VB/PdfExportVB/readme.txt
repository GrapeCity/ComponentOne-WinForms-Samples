PdfExport
------------------------------------------------------------------------
Use C1Pdf method to export C1FlexGrids to pdf files.

This sample is similar to the CustomPrint sample. It marks selected rows 
and columns as break points, then breaks the grid into several images and
renders the images into a C1PdfDocument.

The number of rows and columns per page determine the zoom factor, which
is calculated automatically.