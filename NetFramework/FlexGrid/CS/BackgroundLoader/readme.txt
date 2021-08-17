BackgroundLoader
---------------------------------------------------------------------------------------
Shows how to populate a large DataTable using a BackgroundWorker.

This sample shows how you can display a grid and keep your application responsive while loading large amounts of data using a BackgroundWorker component.

The BackgroundWorker creates batches of rows and keeps them in a list.
After each batch has been created, the worker raises a ProgressChanged event.
The event handler copies the newly created rows into the DataTable that contains the data being shown by the grid.

Note that the BackgroundWorker cannot add the new rows directly to the DataTable since it is executing in a background thread.
The ProgressChanged event handler, on the other hand, runs in the main thread and can update the table safely.