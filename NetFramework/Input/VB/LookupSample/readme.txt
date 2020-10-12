LookupSample
------------------------------------------------------------------------
Creating a DB lookup dropdown control.

The sample shows how to create a custom dropdown control with names
from a lookup table. The UpDown button scrolls the names, while the
[...] button allows to enter a new name.

The sample uses the standard nwind.mdb (the sample assumes that it is
located at "C:\Program Files\ComponentOne Studio.NET\Common\Nwind.mdb",
update if needed). The Orders table is used. The EmployeeID is
replaced with the employee name from the Employees table - this is
achieved with user formatting (FormatType=UserEvent). In the
Formatting event handler, the name (Text) is searched by code (Value).
In the Parsing event, the inverse search is done - the EmployeeID is
found by the name. The dropdown list is built from the employees names
sorted by name. Double-clicking on a name sets the id as
Orders.EmployeeID. Pressing UpDonw the employee names are scrolled,
the EmployeeID is kept in sync. The [...] button opens a dialog form
which allows to add a new employee to the list.
