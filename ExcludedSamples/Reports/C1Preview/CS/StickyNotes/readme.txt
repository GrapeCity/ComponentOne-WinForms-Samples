StickyNotes
----------------------------------------
Shows how to attach a "sticky note" to an object in a C1PrintDocument

This sample is based on the "ObjectsCoordinates" sample (which shows
how to find and highlight a RenderObject under the mouse in the preview).

In addition to that, the current sample allows the end user to enter a
short text associated with the highlighted object, and then creates a
RenderText with the entered text (the "sticky note") and adds it to the
document placing it near the original highlighted object. The document
is then regenerated with the "sticky note".

NOTE: This sample requires C1Report build 2/3/4.6.20111.54312 or later.
