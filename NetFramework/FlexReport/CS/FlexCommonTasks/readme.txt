FlexCommonTasks
------------------------------------------------------------------------
Demonstrates the reports from the FlexCommonTasks.flxr report definition file.

The sample shows a FlexViewer control with a side bar that lists the reports from the FlexCommonTasks.flxr file.
The reports show various aspects of FlexReport, including parameterized reports, charts, subreports etc.
You can run the sample to see the reports in action, or open the FlexCommonTasks.flxr file in the report designer app to see how they are constructed.

The sample assumes that the C1NWind.mdb sample database can be found at the following standard location:

"c:\Users\<user name>\Documents\ComponentOne Samples\Common\C1NWind.mdb"

The connection strings in the .flxr file use the ?(SpecialFolder.MyDocuments) syntax to locate the C1NWind.mdb:

Data Source=?(SpecialFolder.MyDocuments)\ComponentOne Samples\Common\C1NWind.mdb

To see how the whole ConnectionString looks, open the FlexCommonTasks.flxr in a text editor such as Notepad, and search for "ConnectionString".