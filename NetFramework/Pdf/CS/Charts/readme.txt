Charts
------------------------------------------------------------------------
Creates a PDF document containing charts created with the C1Chart control.

The sample creates metafiles for several 2 and 3D charts, then renders
the metafiles into a PDF document using the DrawImage method.

The charts are rendered as a sequence of graphics commands (they are not 
translated into bitmaps). As a result, the charts are rendered in a 
high-quality, resolution-independent way.

This sample uses C1Chart and C1Chart3D.