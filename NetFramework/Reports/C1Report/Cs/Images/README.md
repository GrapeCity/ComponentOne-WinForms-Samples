## Images
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\Cs\Images)
____
#### Load images into report using two methods.
____
The first method is the simplest. The DataSource is a DataTable with an Image field (DataType == typeof(Image)). The report field sets the Picture property to the name of the image field in the data source. The images come directly from the DataTable. 

The second method is a little different. The DataSource contains a field with image file names. The sample uses a script attached to the detail section OnFormat event that loads the images from the corresponding files at render time. 