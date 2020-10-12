C1ScheduleDemo 
==============
Demonstrates typical scheduling application.

The sample application consists of the C1Schedule and C1Calendar controls. 

AppointmentStorage and ContactStorage are bound to data from the NWind database 
	(which is included in the solution). Other storages are used in unbound mode.

C1Schedule displays the appointment data to end-users and responds to their input. 

C1Calendar lets end-users change the date or the set of dates for which the C1Schedule 
	control currently shows its appointment data. This selection is passed to the assigned 
    C1Schedule control, which then loads all the necessary data and represents it
	using the appropriate view. 


