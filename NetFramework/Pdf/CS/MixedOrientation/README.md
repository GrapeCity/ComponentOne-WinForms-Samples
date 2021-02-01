## MixedOrientation
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Pdf\CS\MixedOrientation)
____
#### Renders two C1Reports (one portrait, one landscape) into a single pdf document.
____
C1Report doesn't support mixed orientation in a single report. C1Pdf does, each page in the document can have a different size. 

This sample renders two C1Reports and then merges them into a single C1PdfDocument using the C1Report.PageImages property and the C1PdfDocument DrawImage method. 

Please note that this sample requires 2.6.20083.* or later version of C1Report. 