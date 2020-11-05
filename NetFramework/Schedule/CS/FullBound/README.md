## FullBound
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Schedule\CS\FullBound)
____
#### Demonstrates binding C1Schedule's data storages to data. 
____
All C1Schedule storages are bound to data from the NWind database (which is included in the solution).  The Nwind.mdb database contains 6 tables (one table per storage): 

- Appointments - the sample uses it to store Appointment data; - Categories - the sample uses it to store Category data; - Employees - the sample uses it to store Contact data; - Labels - the sample uses it to store Label data; - Products - the sample uses it to store Resource data; - Statuses - the sample uses it to store Status data.  How to bind DataStorage to your data: 

1. Place C1Schedule on the form. 2. From C1Schedule's smart tag choose DataSource for the storage you want to bind. 3. Open C1Schedule's SmartDesigner "Data Source settings" window. 4. Select DataMember (if it is needed). 5. Choose mappings for all required fields and for optional fields if it is needed for your application. 

You can bind all storages, only part of them, or not bind them at all. Don't forget to fill data adapters at the form loading ant to update them at the form closing. 

C1Schedule displays the appointments data to end-users and responds to their input. 

C1Calendar lets end-users change the date or the set of dates for which the C1Schedule currently shows its appointments data. This selection is passed to the assigned C1Schedule control, which then loads all the necessary data and represents them using appropriate view. 





