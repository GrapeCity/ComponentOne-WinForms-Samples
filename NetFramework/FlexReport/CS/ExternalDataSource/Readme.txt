ExternalDataSource
------------------------------------------------------------
IC1FlexReportRecordset and IC1FlexReportExternalRecordset implementation

This sample demostrates how to implement the IC1FlexReportRecordset and 
IC1FlexReportExternalRecordset interfaces which allow an assembly to be used as
a custom record source for C1FlexReport.

To use this assembly in a report you can follow these steps:

- Run the C1FlexReportDesigner.4.exe application;
- Select "New Report";
- Select "Connection to object in external assembly" as the Data Provider;
- Press "..." to the right of Connection String, and select the ExtRecordset.dll in the file picker;
- Select "External recordset sample" in the Data source box;
- Select fields and finish the wizard as usual.

To adjust the properties of the external recordset, you can click "Properties" 
in the bottom right corner of the data source editor to call the EditParams() method.
In this sample this allows to specify the number of records in the record set.
