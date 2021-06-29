FlexReportExplorer
------------------------------------------------------------------------
Presents various reports as a categorized list, allows to generate and view the reports.

This sample loads a categorized list of reports, with categories such as enterprise, financial, medical and so on.
Some reports demonstrate specific features of FlexReport, such as conditional formatting or watermarks,
while others combine various features to produce reports that might be used in different real-life applications.
C1TileControl is used to represent the report list.

Note that unlike most other FlexReport samples, FlexReportExplorer comes with its own version of C1NWind.mdb and a few other .mdb files, all of which live in the sample's Data directory.
While the report definitions in .flxr files included with this sample reference C1NWind.mdb using the FlexReport standard syntax:

Data Source=?(SpecialFolder.MyDocuments)\ComponentOne Samples\Common\C1NWind.mdb

The sample's initialization code locates the sample's own Data directory and adjusts connection strings of the loaded reports to point to it.

The list of reports is loaded from the ReportInfos.xml file included as a resource.
You may extend the list to include your own reports, in which case you will also need to include screenshots of your reports (to be shown in the tiles representing the reports, 
and in the previews), and take into account that the sample adjusts connection strings of the loaded reports as described above.
For more details see MainForm.vb.