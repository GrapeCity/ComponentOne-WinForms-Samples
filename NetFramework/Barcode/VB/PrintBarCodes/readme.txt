PrintBarCode
--------------------------------------------
Demonstrates how to print barcodes created with the C1BarCode control.

The sample creates a PrintDocument object and uses the PrintPage event
to compose each document page. Pages are created using standard GDI+
commands (methods in the Graphics class).

To draw the barcodes, the sample assigns some text to a C1BarCode control,
then retrieves the barcode image (using the control's Image property), and
renders the image using the Graphics.DrawImage method.