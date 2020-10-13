PdfChart
------------------------------------------------------------------------
Creates a C1Chart pie chart and converts it to Pdf.

The sample creates a pie chart, converts it into a metafile, then renders
the metafile into a PDF document using the DrawImage method.

The chart is rendered as a sequence of graphics commands (it is not 
translated into a bitmap). As a result, the chart is rendered in a 
high-quality, resolution-independent way.

This sample uses C1Chart.