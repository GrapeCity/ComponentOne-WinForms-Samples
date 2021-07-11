SimpleFilter
------------------------------------------------------------------------
Implements a custom DataSource with filtering and sorting.

The sample shows how to implement a class that allows any generic list
(List<T>) to be used as a filtered, sortable data source for C1Report.

The custom data source implements the IC1ReportRecordset interface,
and uses the C1Report script engine to apply the filter condition to
the list and extract the elements that should be included in the report.

It also implements a simple but efficient sorting scheme using reflection
on the generic type T of the elements contained in the list.