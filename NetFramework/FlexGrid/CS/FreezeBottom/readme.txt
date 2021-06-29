FlexFreezeBottom
------------------------------------------------------------------------
Show frozen rows at the bottom of a grid.

The sample implements a control (derived from Panel) that contains a FlexGrid.
The contained FlexGrid is positioned with a negative Y coordinate within the panel so that the fixed rows are not visible.

The contained grid is also sized and scrolled via code so that the bottom 'n' rows are visible.

The contained grid is bound to a main FlexGrid and therefore shares the underlying grid model (data, layout, styles, selection, etc).

The whole control (panel and contained grid) is attached to the main FlexGrid and positioned at its bottom. This way, the control always shows the bottom 'n' rows of the main grid.

This is a fairly advanced sample. Most of the code is dedicated to synchronize the grids and keep an illusion that they are the same control, even as the user resizes and makes selections.