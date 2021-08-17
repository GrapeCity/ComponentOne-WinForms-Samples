OwnerDraw
------------------------------------------------------------------------
Autosize Owner-Drawn cells.

The C1FlexGrid now fires the OwnerDrawCell event not only when painting, but also when autosizing rows and columns.
This allows the grid to take special formatting and contents applied by your custom drawing routines.

There's no extra work involved, existing owner-draw code will automatically benefit from this addition to the control.