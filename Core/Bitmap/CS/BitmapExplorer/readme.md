## BitmapExplorer
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/Core\Bitmap\CS\BitmapExplorer)
____
#### This sample demonstrates how to use C1Bitmap control
____
An example shows how:

* Get images stored in SQLite database and load them into C1Bitmap control;
* Search and index data associated with images;
* Create various effects on images such as: flipping images, curving the corners of the image, etc.

This example includes three additional classes:

* The DataSource class implements connection to the database and fetching with conversion of images to C1Bitmap type. 
* The Effects class is for creating various effects that are demonstrated in this application.
* The BitmapPanel class is used for storing and manipulating images based on C1Bitmap. This class intercepts standard image selection events such as Click and generates its own events. These events allow the user to determine the choice of an image.
    
The DataBinding example implements data search. If the string matches, the image header is highlighted in yellow.
The Rotating example implements a mechanism for flipping an image in a different direction and at a different angle.
