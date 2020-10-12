CustomData
------------------------------------------------------------------------
Create custom data source objects for use with C1Report.

C1Report allows you to use many types of data sources. Any object that implements
the IBindingList and ITypedList can be used directly (e.g. DataView objects).

Alternatively, you can implement the IC1ReportRecordset interface and use your
objects as data sources. The sample illustrates this by creating a data source object
with information from a disk directory.
