PdfForm
------------------------------------------------------------------------
Creates a Pdf version of a paper form.

Drawing into a C1Pdf document is a lot like drawing into a GDI+ 
Graphics object. You can use familiar commands such as DrawRectangle, 
DrawString, etc. and the same Font, Brush, and Pen objects.

C1Pdf can also render Metafiles (without converting them into bitmaps).

This sample loads an empty fax cover form (created in Visio and saved as
an enhanced metafile), then uses the DrawString method to fill in the
fields based on information you enter on the main form.

