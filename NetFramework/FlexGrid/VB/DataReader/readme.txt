DataReader
------------------------------------------------------------------------
Populate a grid from a DataReader.

This sample shows how to do it, but note that it is often faster to 
load data using traditional data binding, especially for large data sets.
That is because when you load the grid in unbound mode, the grid needs
to store the data itself, and grow the number of rows one by one. 

In bound mode, ADO.NET does the same thing, except it has access to all 
the data and can often do the job more efficiently.