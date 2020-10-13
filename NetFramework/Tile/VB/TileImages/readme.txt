TileImages
-----------------------------
The sample shows how to display images on tiles using various techniques.

Tiles can display one or several images. An image can be specified
in the Tile using its Image, ImageKey, or Symbol properties. Also,
it can be specified as a part of the template's ImageElement or stored
in one of the CommonImage objects that belong to C1TileControl.

There are a few tricks when working with images. For example, you
can create a big image that consists of N images in width and M images
in height. If so, the ImageElement.ImageColumns property must be set
to N, and ImageElement.ImageRows property must be set to N. Also,
the ColumnIndex and RowIndex properties can be used to pick a small
image from large matrix.
