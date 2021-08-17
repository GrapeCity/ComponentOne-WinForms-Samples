## DragImages
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\DragImages)
____
#### Shows how to customize Ole Drag and Drop to use cell images.
____
The sample uses the StartDrag event to store the cell image in the drag/drop Data object.
It also handles the DragEnter event to allow dropping images on the grid and the DragDrop event to actually store the image in the target cell.

The sample sets the grid's DragMode to automatic, in order to get the standard mouse behavior to start dragging operations.
It sets the DropMode to manual since the dropping is handled by the event handlers.
