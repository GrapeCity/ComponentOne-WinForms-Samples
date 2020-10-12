ChartInReport
------------------------------------------------------------------------
Shows a C1WebChart in a C1WebReport.

The sample shows how you can add a chart created with C1WebChart to
C1WebReport. This is done using the StartSection event to read the
chart image off the C1WebChart control and assign it to the Picture
property of a report field.

The C1WebReport ImageRenderMethod is set to HttpHandler, so there are
no temporary files.

The C1WebReport EnableCallbacks is set to true, so Ajax is enabled and
paging is smooth.

