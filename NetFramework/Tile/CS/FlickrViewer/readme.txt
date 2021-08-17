FlickrViewer
-----------------------------
The sample shows photos from Flickr using C1TileControl.

Images are downloaded without blocking the calling thread.
The sample creates the internal queue of requests passed to server one-by-one.
Tiles show two images: the thumbnail and the author's avatar (and also some textual info).
When you click the tile it opens large image.