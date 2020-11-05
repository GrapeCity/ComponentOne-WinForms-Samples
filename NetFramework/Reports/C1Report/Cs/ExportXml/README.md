## ExportXml
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\Cs\ExportXml)
____
#### Export reports to an Xml format.
____
This sample shows how you can implement a custom export filter and export reports to Xml. 

Custom export filters derive from the C1.Win.C1Report.ExportFilter base class and override methods to render sections and fields. This sample implements an XmlFilter class that renders report elements into an XmlWriter. 

Once you have a filter, use the RenderToFilter method to render the report into the filter. 

Export filters are flexible and powerful. All the C1Report built-in export filters (Pdf, Html, Rtf, etc) use this approach. 