C1DataExtender
------------------------------------------------------------------------
Demonstrates how to set up grid column styles using an ADO.NET DataSet Extender.

This sample depends on the following assemblies:
	C1.C1DataExtender.2.dll
	C1.Win.C1FlexGrid.2.dll

** Overview

DataSet Extender is a schema which sits on top of an ADO.NET typed DataSet schema 
and provides additional properties to the DataSet's DataTable and DataColumn objects.

These properties also allow you to define additional performance features of C1DataViewSet.

DataSet Extender is represented by its root DataSetExtender class and appears as a 
global project item. Usually a single DataSet Extender is necessary for a specific 
typed DataSet.

** Creating the DataSet Extender 

To create a DataSet Extender, complete the steps below:

1) From the VS IDE menu, select "Project | Add New Item | DataSet Extender".

2) In the "Name" textbox enter "NWindDataSetExtender" and press the "Add" button. 
   (NWindDataSetExtender is created as a global project item and its designer 
   automatically appears in a separate window of the VS IDE.)

3) Select the DataSet Extender root node in the designer and set its DataSet 
   property to "NwindDataSet". The NWindDataSet schema will be extended 
   by this DataSet Extender.

** Column Styles

Column Styles are a mechanism to define UI related properties for DataTable and C1DataView 
columns, which can be recognized and applied by C1 controls.

Some examples include FormatMask, EditMask, Visible, lookup lists related properties, and so on.

Column Styles can be defined for C1DataView column. However, the most effective way is to 
define them in DataSet Extender, because this definition will be automatically applied to 
corresponding C1ViewColumn of any C1DataViewSet which references the DataSet Extender.

Usage of column styles is demonstrated in Form1 form.

There is c1DataViewSet1 viewset connected to nwindDataSet1 typed DataSet.

c1DataViewSet1.SchemaExtender is set to "NWindDataSetExtender", which means
that the viewset uses DataSet Extender with the specified name, the latter
is defined as a global project item.

c1DataViewSet1 has a single C1DataView named "DataView" with definition:
"Select * From Orders"

c1FlexGrid1 control is placed on the form and bound to "DataView" view
of c1DataViewSet1. 

Run the sample and investigate the grid transformation:

1) OrderID column, the primary key of the view and underlying "Orders"
   DataTable, is not shown.

2) Foreign key (FK) columns - CustomerID, EmployeeID and ShipVia - are 
   represented by lookup comboboxes showing a list of items, which
   represent rows from parent DataTable for this foreign key.
   Note that rows from parent tables, "Customers" and "Shippers" are
   represented by the value of a single column ("CompanyName" of each table),
   while row representation of "Employees" has more complex format:
    <LastName><comma><FirstName>

3) ShipCountry column, which is just a string column, not a foreign key, is 
   also represented by a drop-down list showing a list of countries.

4) DateTime columns, "OrderDate" and "RequiredDate" have odd formatting, for
   example, "Date:  1994 - 09 - 01".
   At the same time, DateTime column,"ShippedDate" has regular short date 
   format.

Examine how the grid was defined in DataSet Extender:

1) Close the application and return to design-time.

2) Double-click the NWindDataSetExtender.cs project item to open its designer. 

Notice that DataSet Extender properties in PropertyGrid.ColumnStyles property 
contain a collection of global styles, which can be applied to any DataColumn 
according the specified rule (see below about rules).
ColumnStyles collection includes styles with the followings definitions
(listed below are only those properties whose defaults are changed):

FK_Style
ItemListType = ForeignKey
This style will be applied to all Foreign Key columns, and forces them
to have a lookup combobox with item representing rows from parent DataTable.

PK_Style (Name = "PK_Style")
Visible = false
This style will be applied to all Primary Key columns to make them 
invisible.

Date_Style
Format = "Da\te:  yyyy - MM - dd"
This is a default style for columns of type DateTime, and will be applied
to all the columns with DataType = System.DateTime.

The following styles define style attributes for different kinds of number 
data types: Decimal_Style, Float_Style and Integer_Style.

These styles are mapped to different kinds of DataColumn(s) by defining the 
ColumnStyleRules property, which contains a collection of rules which maps 
styles to specific columns. The rules defined here are as follows:

Rule = ForeighnKey
ColumnStyleName = "FK_Style"
This rule states that style with name "FK_Style" (defined before in the 
ColumnStyles collection) will be applied to all columns which are foreign
keys (Rule = ForeighnKey).

Rule = PrimaryKey
ColumnStyleName = "PK_Style"
This rule states that style with name "PK_Style" will be applied to all 
columns which are primary keys.

Rule = TypeBased
ColumnType = System.DateTime
ColumnStyleName = "Date_Style"
This rule states that style with name "Date_Style" will be applied to all 
columns having DataType = System.DateTime (Rule = TypeBased indicates that 
each column should be matched against a type defined in ColumnType).

The collection includes additional rules that map styles to number data type 
columns.

Most of the information shown in the grid has come from these definitions, 
with the exception of the following:
- Specific format of "ShippedDate" column.
- More complex representation of parent rows from "Employees" DataTable 
  and drop-down value list of the "ShipCountry" column.

To redefine the format of "ShippedDate" column, select this column under the
"Orders" table node in the DataSet Extender designer tree. In the PropertyGrid,
locate the ColumnStyle property, which defines a local for this column 
style. This style is inherited from global style corresponding to this 
column according to the style mapping rules, "Date_Style" in our case, and 
allows you to redefine any style property to name specifics for this column. 
Notice that the Format property is redefined here with the value "d", 
which means short date format (according to System.String.Format method 
specification).

In the same manner, a value list for "ShipCountry" column is defined. Select
this field in the list and ensure that its ColumnStyle property has 
ItemListType = FixedValues and ItemList collection is filled with country
names.

Now investigate how parent row items have been formatted for the "EmployeeID"
column. This formatting is specified for the parent DataTable, but not for the 
foreign key (FK) column referencing it; therefore, specify a formatting once 
for the table and all FK columns related to this table will use this formatting.

In our case, "Employees" DataTable is a parent for Orders.EmployeeID column.
In DataSet Extender designer tree, expand the "Employees" table node and make 
sure that RowDisplayValue property value is set to True for LastName and 
FirstName columns, while all other columns have RowDisplayValue property set to 
False. 

RowDisplayValue = True indicates that this column value should be included
in a string representing this row. 

Now select the "Employees" DataTable and expand RowDisplay property in the 
PropertyGrid. Its RowDisplayColumns collection property allows you to change the 
order in which row display columns appear in a resulting string representing a 
row. 

This collection also allows you to add/remove columns included in row display
(as an alternative to setting RowDisplayValue property for column).

By default, display row is constructed as a concatenation of column values
from RowDisplayColumns collection separated by a space.

In our case, we want to separate column values by a comma. This is done
using the RowDisplayFormat property, which is defined as:
"{0}, {1}"

The possible value of this property fully conforms to format string specified
for System.String.Format method. A parameter markup element, "{n}", represents
a value of column from RowDisplayColumns collection with the index n. In
our case, {0} references LastName column (index 0) and {1} references FirstName
column (index 1).

Column styles can be redefined on a C1ViewColumn level (column of C1DataView
from C1ViewSet) as well.

You may notice that captions of "CustomerID" and "EmployeeID" columns in the 
grid are actually shown as "Customer" and "Employee", respectively (without 
ending "ID"). User friendly captions can be defined in two ways:

1) Globally, in the typed DataSet Designer, in the Caption property of DataColumn.
   The "EmployeeID" column is defined this way.

2) Locally, in the C1DataViewSet, for specific column of concrete C1DataView. This
   method was used to define the "CustomerID" C1ViewColumn. To check this 
   property setting, in the Form1 form open c1DataViewSet1 component editor, 
   select the "CustomerID" column of the "DataView" view and make sure that the 
   Caption property for this column is set to "Customer".
