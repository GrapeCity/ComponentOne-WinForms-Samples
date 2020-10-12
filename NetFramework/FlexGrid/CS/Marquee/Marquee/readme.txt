Marquee
---------------------------------------------------------------------
Shows how you can implement an Excel-style marquee on a C1FlexGrid.

The sample uses the Paint event to calculate the position of the marquee. 

If the position has changed since the last paint event, then the control
is invalidated to erase the old marquee.

If the new position is not empty, then the new marquee is painted at
the new position.