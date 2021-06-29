## Zip64Demo
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Zip\CS\Zip64Demo)
____
#### Shows how C1Zip supports files larger than 4.3 gigabytes.
____
The traditional Zip format uses 32-bit unsigned integers in its data structures.
This imposes limits on the maximum number of zip entries, maximum entry size, and maximum zip file size.
The limit is 0xffffffff = 4,294,967,295 (4.3 gigabytes).

To circumvent this limit, the Zip64 format was introduced.
This is an extension that raises the limit from 32 to 64 bits, 18,446,744,073,709,551,615 (18.4 exabytes ;-).

Starting with build 2.1.20102.68, C1Zip supports the Zip64 format.

This sample demonstrates this by performing the following steps:
 1. Create a 4.4 gigabyte file containing random digits.
 2. Compress this file into a zip file.
 3. Expand the zip file back into another 4.4 gigabyte file.
 4. ompare the content of the original file and the expanded one.

Warning: This sample deals with very large files and because of that it takes a fairly long time to run.
The sample does provide user feedback as it progresses.
