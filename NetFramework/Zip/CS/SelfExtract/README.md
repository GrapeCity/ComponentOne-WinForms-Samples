## SelfExtract
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Zip\CS\SelfExtract)
____
#### Self-extracting application.
____
The sample contains a zip file embedded as a resource. The user can select a destination directory, then click a button to extract all the embedded files into the selected destination. 

To extract the files, the sample copies the embedded zip resource to a temporary file, then uses C1Zip to extract all entries in the zip file to the destination directory. Finally, the temporary zip file is deleted. 

The zip file may contain any number of subdirectories. The subdirectory structure is preserved when the file is expanded. 

To change the content of the embedded resource, use Visual Studio to remove the .zip resource from the project, then add any other zip file (make sure the BuildAction property is set to Embedded Resource). 