EntityFramework
-----------------------------------------------------------------------------
Shows how to implement a BindingList based on an Entity Framework data source.

Please note, for run this sample you need to have an instance of Microsoft SQL 
Server Express.

Also, for different versions of Visual Studio and SQL Server Express you need
use proper connection string "northwndEntities":

 - Visual Studio 2010, SQL Server Express 2008

   "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;
    provider=System.Data.SqlClient;provider connection string=&quot;
    data source=.\SQLEXPRESS;attachdbfilename=|DataDirectory|\northwnd.mdf;
    integrated security=True;connect timeout=30;user instance=True;
    multipleactiveresultsets=True;App=EntityFramework&quot;"

   with default SQLEXPRESS name on your computer;

 - Visual Studio 2012, SQL Server Express 2012

   "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;
    provider=System.Data.SqlClient;provider connection string=&quot;
	data source=(LocalDB\v11.0);attachdbfilename=|DataDirectory|\northwnd.mdf;
	integrated security=True;connect timeout=30;multipleactiveresultsets=True;
	App=EntityFramework&quot;"

 - Visual Studio 2015, SQL Server Express 2014

   "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;
    provider=System.Data.SqlClient;provider connection string=&quot;
	data source=(LocalDB)\MSSQLLocalDB;
	attachdbfilename=|DataDirectory|\northwnd.mdf;integrated security=True;
	connect timeout=30;multipleactiveresultsets=True;App=EntityFramework&quot;"

Otherwise, you need to make appropriate changes in connection string 
"northwndEntities".


Binding WinForms controls to Entity Framework data sources is easy. For
example:

<code>
northwndEntities ctx = new northwndEntities();
_flex.DataSource = ctx.Customers;
</code>

However, this method relies on WinForms automatically building a binding list.
This implicitly built list is somewhat limited: it does not support sorting, 
adding, or removing items. If you run this code and click the grid's column 
headers, it will not sort the data.

If you want to bind WinForms controls to Entity Framework data sources, and
sorting is required, there are a couple of possible solutions:


Option 1) Implement your own BindingList class with sorting support.

This is not a trivial exercise, but there are many examples available.
For example:

	http://www.timvw.be/presenting-the-sortablebindinglistt/
	http://www.eggheadcafe.com/software/aspnet/31429914/sort-a-bindinglist.aspx
	http://www.codeproject.com/KB/linq/bindinglist_sortable.aspx

This sample uses Tim Van Wassenhove's class, described in the first link.

Using the SortableBindingList class is simple:

<code>
northwndEntities ctx = new northwndEntities();
var list = new SortableBindingList<Customers>(ctx.Customers);
_flex.DataSource = list;
</code>

This time the grid will provide sorting as usual.

Filtering is also supported. The C1FlexGrid does not rely on the data source
for this. Simply set the AllowFiltering property to true.


Option 2) Use LiveLinq.

The method listed above and demonstrated in this sample is very simple, but
it still has limitations.

The Microsoft Entity Framework is based on LINQ, which generates enumerations.
When you create a bindable collection from a LINQ statement, the collection
represents a static snapshot of the original query.

If items are added to or removed from the original collection, or if a filter
is applied or modified, the bound collection does not reflect that.

LiveLinq addresses this by implementing live views over LINQ statements. The
views can be used as regular data sources, and provide full support for LINQ
statements including joins, filters, sorts, insert/remove, etc.

LiveLinq is extremely useful in common data-binding scenarios where objects 
are edited and may be filtered in or out of views, have their associated 
subtotals updated and so on. LiveLinq bridges the gap between data and logic, 
and can make data-centric applications much simpler and more efficient.

For more details on LiveLinq, please visit

	http://www.componentone.com/SuperProducts/LiveLinq/


