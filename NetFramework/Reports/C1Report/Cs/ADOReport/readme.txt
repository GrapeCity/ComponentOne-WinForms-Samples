ADOReport
--------------------------------------------------------
Use ADODB.Recordset objects as C1Report data sources.

The sample shows how to write a wrapper class that implements the IC1ReportRecordset interface
based on a regular ADODB.Recordset object.

This class can then be used as a data source for C1Report by assigning it to the
C1Report.DataSource.Recordset property. For example:

	// get regular ADO recordset
	ADODB.Recordset rs = GetADODBRecordset();

	// use ADO recordset as report data source
	_c1r.DataSource.Recordset = new ADOReportSource(rs);
	
