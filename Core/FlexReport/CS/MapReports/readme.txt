MapReports
---------------------------------------------------------------
Render sample reports which use the Map custom field

The sample renders and previews several sample reports demonstrating the Map
custom field. The reports were created using the report designer application,
and are located in the Maps.flxr file.

Note, some reports in the Maps.flxr file use external service (Google) to obtain
  geographical coordinates of objects. This may take a VERY LONG TIME the first
  time a report runs. After that, the geographical data is cached in a file in
  the binary directory called "geocache.xml", so subsequent runs of the same
  report should be much faster. The pre-generated geocache.xml file may be
  deployed with a report if needed.
