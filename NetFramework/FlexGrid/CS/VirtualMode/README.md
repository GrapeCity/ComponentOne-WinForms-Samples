## VirtualMode
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\VirtualMode)
____
#### Shows how to display large data sets while loading only a few rows at a time.
____
This sample is based on the following article:

http://msdn.microsoft.com/en-us/library/ms171624.aspx

The article describes how to implement a simple "virtual mode" in the DataGridView control.
The purpose is to retrieve data only as it is needed, a technique called "just-in-time data loading".

This technique is useful if you are working with large tables and want to avoid startup delays and excessive data consumption by retrieving only the data 
that is necessary for display and retrieving additional data only when the user scrolls new rows into view.

This sample implements the same technique and enhances it by supporting changes to the database (read/write cache).

The core of the sample is the VirtualDataSource class, which connects to a database, builds a dynamic cache,
and exposes GetValue and SetValue methods that update the cache as needed getting data form the database and writing any changes back to it.

The sample connects the VirtualDataSource class to the C1FlexGrid using the GetUnboundValue and SetUnboundValue events, which exist specifically to support this type of scenario.
