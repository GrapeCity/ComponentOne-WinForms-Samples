C1Bitmap DataBinding Sample
-----------------------------
This sample demonstrates how to use C1Bitmap control.

The DataBinding example implements data search. If the string matches, the image header is highlighted in yellow.

An example shows how:
- Get images stored in database and load them into C1Bitmap control;
- Search and index data associated with images;

This example includes three additional classes:
- The DataSource class implements connection to the database and fetching with conversion of images to C1Bitmap type. 
- The Effects class is for creating various effects that are demonstrated in this application.
- The BitmapPanel class is used for storing and manipulating images based on C1Bitmap. This class intercepts standard image selection events such as Click and generates its own events. These events allow the user to determine the choice of an image.
