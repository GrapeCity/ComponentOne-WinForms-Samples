## AzureC1Report
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\Cs\AzureC1Report)
____
#### View data bound C1Reports using C1ReportViewer in a MS Azure application
____
The sample is a simple Microsoft Azure application that allows users to preview reports from the C1Reports' CommonTasks sample using the C1ReportViewer included in C1 Palomino. Parameterized reports and custom fields are also supported. 

This sample requires the following C1 assemblies: 

- Assemblies included in C1 Palomino: 

- C1.Web.UI.Controls.C1Report.4 - C1.Web.UI.Controls.4 - C1.Web.UI.4 - C1.C1Report.4 

- In order to run reports that use CustomFields, the following C1 assemblies must also be referenced: 

- C1.C1Report.CustomFields.4 - C1.Win.C1Chart.4 - C1.Win.C1SuperTooltip.4 - C1.Win.C1BarCode.4 

Note that C1.C1Report.CustomFields.4's version must match the version of C1.C1Report.4. 

Steps needed to run this sample on a testing/development machine: 

1. Install Microsoft Azure development tools (see Microsoft Azure web site for details). 

2. Import the C1NWind.mdb that comes with many C1 samples into SQLEXPRESS: 

SQLEXPRESS must be installed and running. Use SQL 2008 R2 Import and Export Data tool to import C1NWind.mdb into SQLEXPRESS database named C1NWindSQL. 

3. Add a user to SQLEXPRESS. 

Add a user (name: 'joe', password: 'user') to SQLEXPRESS, with 'connect' and 'select' permissions on the C1NWindSQL database. 

4. Modify connection strings and record sources. 

The CommonTasksSQL.xml included with the sample has been modified to use C1NWindSQL but you may still need to adjust connection strings to fit your installation. Here's specifically what was done: 

- ConnectionString were changed from: 

<ConnectionString>Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c1nwind.mdb;Persist Security Info=False</ConnectionString> 

to ('CORSIE\SQLEXPRESS' is the SQLEXPRESS server name; adjust as needed): 

<ConnectionString>Provider=SQLNCLI10.1;User ID=joe;Password=user;Initial Catalog=C1NWindSQL;Data Source=CORSIE\SQLEXPRESS; Initial File Name="";Server SPN=""</ConnectionString> 

- RecordSource were modified accordingly, e.g. "05: Watermark" report's RecordSource was changed from: 

<RecordSource>SELECT Categories.CategoryName, Products.* FROM Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID;</RecordSource> 

to: 

<RecordSource>SELECT dbo.Categories.CategoryName, dbo.Products.* FROM dbo.Categories INNER JOIN dbo.Products ON dbo.Categories.CategoryID = dbo.Products.CategoryID; </RecordSource> 