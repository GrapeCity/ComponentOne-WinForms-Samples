﻿PdfView
------------------------------------------------------------------------
Immplements a PDF viewer using C1FlexViewer as the UI, and C1PdfDocumentSource as the engine.

This sample is built around a form with a C1.Win.FlexViewer.C1FlexViewer controll, and a C1.Win.C1Document.C1PdfDocumentSource component assigned to its DocumentSource property.
An arbitrary PDF file can be loaded into the viweer using the C1PdfDocumentSource.LoadFromFile() method (accessible through the File Open button in the sample).

C1PdfDocumentSource supports most PDF viewing features such as outlines and embedded fonts.
Also available are text selection and search, printing and export to external formats such as HTML, various image formats etc.