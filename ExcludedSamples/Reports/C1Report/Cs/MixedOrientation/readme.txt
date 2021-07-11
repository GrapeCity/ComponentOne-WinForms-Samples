MixedOrientation
------------------------------------------------------------------------
Renders two C1Reports (one portrait, one landscape) into a single pdf document.

C1Report doesn't support mixed orientation in a single report. C1Pdf does, 
each page in the document can have a different size.

This sample renders two C1Reports and then merges them into a single
C1PdfDocument using the C1Report.PageImages property and the C1PdfDocument
DrawImage method.