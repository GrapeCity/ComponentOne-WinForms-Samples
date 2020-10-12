MapReports
---------------------------------------------------------------
Render sample reports which use the Map custom field

The sample renders and previews several sample reports demonstrating the Map
custom field. The reports were created using the report designer application,
and are located in the Maps.xml file.

This sample requires the following assemblies and files:

- C1Reports release 2012v1 or later, .NET 4.0 version;
- C1.C1Report.CustomFields.4 which ships with C1Reports;
- C1NWindMaps.mdb (included in the sample);
- WorldMap4NWind.kmz file (included in the sample);
- us_states_abbr.kmz file (included in the sample);
- C1.WPF.4.dll and C1.WPF.Maps.4.dll assemblies (not included with the sample,
  but may be copied from the report designer app directory installed together
  with C1Reports components);

Notes:

- projects referencing CustomFields cannot target .NET 3.5/4.0 "client" profiles
  (this is because the CustomFields assembly includes certain design time
  features used by the reports designer);

- if using/referencing the pre-built C1.C1Report.CustomFields.4 binary that
  ships with C1Reports, it is mandatory to use C1.C1Report.4 and
  C1.Win.C1Report.4 assemblies from the same release. But, it is NOT necessary
  to use the C1.WPF.4.dll and C1.WPF.Maps.4.dll assemblies that were included
  in the C1Reports release - newer versions may be used.

- some reports in the Maps.xml file use external service (Google) to obtain
  geographical coordinates of objects. This may take a VERY LONG TIME the first
  time a report runs. After that, the geographical data is cached in a file in
  the binary directory called "geocache.xml", so subsequent runs of the same
  report should be much faster. The pre-generated geocache.xml file may be
  deployed with a report if needed.
