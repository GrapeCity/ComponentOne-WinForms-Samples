MultiUser
-------------------------------------------------------------
This sample demonstrates grouping C1Schedule control by the Appointment.Owner property.

AppoinmentStorage, OwnerStorage and other C1Schedule storages are bound to data from the NWind database (which is included in the solution). 

The Nwind.mdb Appointments table contains an Owner column for storing information about an Appointment's owner.
This column may contain key values from the Employees table.
AppointmentStorage has OwnerIndexMapping mapped to this column.
The C1Schedule.GroupBy property is set to "Owner".

The default group header appearance is changed by adding employee photo in the event handler for the C1Schedule.BeforeGroupHeaderFormat event.