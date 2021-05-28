## MapReports
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexReport\CS\MapReports)
____
#### Render sample reports which use the Map custom field
____
The sample renders and previews several sample reports demonstrating the Map custom field. The reports were created using the report designer application, and are located in the Maps.flxr file. 

This sample requires the following assemblies and files: 

- C1FlexReport release 2016v2 or later, .NET 4.0 version; - C1.Win.FlexReport.CustomFields.4 which ships with C1FlexReport; - C1NWind.mdb (included in the sample); - WorldMap4NWind.kmz file (included in the sample); - us_states_abbr.kmz file (included in the sample); - C1.Win.4, C1.C1Zip.4, and C1.Win.Map.4 (not included with the sample, but may be copied from the report designer app directory installed together with C1Reports components); 

Notes: 

- projects referencing CustomFields cannot target .NET 4.0 "client" profiles (this is because the CustomFields assembly includes certain design time features used by the reports designer); 

- some reports in the Maps.flxr file use external service (Google) to obtain geographical coordinates of objects. This may take a VERY LONG TIME the first time a report runs. After that, the geographical data is cached in a file in the binary directory called "geocache.xml", so subsequent runs of the same report should be much faster. The pre-generated geocache.xml file may be deployed with a report if needed. 