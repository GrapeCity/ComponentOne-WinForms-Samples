## MultiDocumentFilesPrint
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\PrintDocument\CS\MultiDocumentFilesPrint)
____
#### Uses a C1MultiDocument to build and preview a listing of all files matching a mask.
____
This sample builds a listing of all files matching a specified mask in all subdirectories of a specified directory.
The listing of all files is built as either a C1MultiDocument in which each constituent C1PrintDocument represents listing of all matching files in a single directory without subdirectories,
or as one large C1PrintDocument listing all matching files in all subdirectories.

In each case the sample also builds the TOC with entries for each subdirectory and file, and a parallel outline tree.
The TOC is inserted at the beginning of the document.

Due to current limitations, outlines for nested subdirectories are not nested. This is a limitation of C1MultiDocument that will be removed in a future version.

Additionally, an index of all occurrences of all known color names is built and appended at the end of the document.

The sample shows that when the resulting document is large enough (say larger than 1000 pages or so), a C1MultiDocument works much faster and requires less memory.

To run the sample:
1. Build and run the project.
2. Type the name of a directory in the "Directory" textbox, or click the "..." button to the right of it to choose the directory using a dialog.
   Files in that directory and all its subdirectories will be listed.
3. Type in the desired file mask in the "Mask" textbox. Make sure to specify a mask that will only match text files (such as C# code files), 
   binary files are not supported and may cause the sample to crash.
4. Click either "C1MultiDocument" or "C1PrintDocument" button to build and preview the document. Note that for large directory trees, the resulting file may turn out to be very large.
