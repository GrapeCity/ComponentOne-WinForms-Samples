## XMLData
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\Cs\XMLData)
____
#### Use any XML document as a report data source.
____
XML is very flexible, to use it as a report source you need some additional 'glue' that tells the report engine which elements are tables, fields, etc. (You could use attributes, node values, etc as data). 

Using DataSet.ReadXml is a way to get this 'glue'. It loads XML documents into DataSet objects, and you can assign the DataTables directly to the DataSource.Recordset property. 

If the DataSet.ReadXml doesn't parse the data exactly the what you want, or if you want additional flexibility such as XPath filtering, then you can implement your custom data source by supporting the IC1ReportRecordset interface. 

This sample shows this approach. It implements a custom report data source that lets you use XML/XPath to select nodes, then exposes each node as a 'record' and its subnodes as 'fields'. 