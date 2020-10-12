InMemoryCompression
------------------------------------------------------------------
Shows how to create and use an in-memory archive.

The C1ZipFile class allows you to easily create and manage zip files.

In some cases, however, you may want to use compression without any
files. This sample shows how to accomplish this using the 
C1ZStreamReader and C1ZStreamWriter classes.

The sample uses a hashtable as an archive containing compressed
streams, and has methods for adding (compressing) files to the
archive and extracting (expanding) files from the archive.