## ZipReport
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexReport\CS\ZipReport)
____
#### Render reports using compressed and encrypted report definition files
____
This sample uses C1Zip to open a compressed and encrypted report definition file and load it into C1FlexReport on the fly. 

Compressing the report definition files allows you to save disk space and reduce download times. 

Encrypting the report definition files protects your report definitions and data connection information. 

The password to FlexCommonTasks.zip is "flex". The .flxr file uses the DataDirectory syntax to access the C1Nwind.mdb file. It assumes that that file is located in the "ComponentOne Samples\Common" sub-folder of the current user's personal folder, usually: 

"c:\Users\<user>\Documents\ComponentOne Samples\Common\C1NWind.mdb" 