## ODataRecordset
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexReport\CS\ODataDataSource)
____
#### How to use data provided by the OData service.
____
This sample demostrates how to use data provided by the OData service in the C1FlexReport, it contains ODataRecordset class providing access to the OData entity set, 
following properties can be specified for the ODataRecordset:

* URL of OData service, for example, http://services.odata.org/V3/OData/OData.svc/
* Name of the entity set ODataRecorset implements IC1FlexReportExternalRecordset interface.

To use this assembly in a report you can follow these steps:

* Run the C1FlexReportDesigner.4.exe application;
* Select "New Report";
* Select "Connection to object in external assembly" as the Data Provider;
* Press "..." to the right of Connection String, and select the ODataRecordset.dll in the file picker;
* Select "External recordset sample" in the Data source box;
* Select fields and finish the wizard as usual.
To adjust the properties of the ODataRecordset, you can click "Properties" in the bottom right corner of the data source editor to call the EditParams() method.

This sample uses ODataLib to parse OData service responses, to install ODataLib for OData, run the following command in the Package Manager Console:

   Install-Package Microsoft.Data.OData
