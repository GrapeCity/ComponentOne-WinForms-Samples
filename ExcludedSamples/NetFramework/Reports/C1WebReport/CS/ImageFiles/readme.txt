ImageFiles
----------------------------------------------------------
Display images located in urls stored in a database.

In most cases, report definitions have unbound images embedded 
in them, and bound images are stored as images in the database.

If you want to display images that are stored in files, with
file names stored in the database, then you should add the 
following script to the OnFormat property of the section that
contains the image fields:

	// assign each filename to Picture property of the fImage field.
	// this will cause C1WebReport to load the picture.
	s.OnFormat = "fImage.Picture = filename";

Where 'fImage' is the report field that will show the image, and 'filename'
is the database field that contains the image urls.
