## MultiUser Custom Forms
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Schedule\VB\MultiUserCustomForms)
____
#### This sample demonstrates using custom AppointmentForm with C1Ribbon control.
____
AppoinmentStorage, OwnerStorage and other C1Schedule storages are bound to data from the NWind database (which is included in the solution). 

The Nwind.mdb Appointments table contains an Owner column for storing information about an Appointment's owner. This column may contain key values from the Employees table. AppointmentStorage has OwnerIndexMapping mapped to this column. The C1Schedule.GroupBy property is set to "Owner". 

The AppointmentForm class uses C1Ribbon control to mimic MS Office 2010 interface. It demonstrates how to work with different appointment properties and how to show default RecurrenceDialog to create or edit appointment recurrence pattern. 

The Form1 class demonstrates how to handle C1Schedule events to show AppointmentForm for existent appointment or to create new appointment. It handles C1Schedule.ContextMenuStrip.MouseClick event so that to create appointment with the correct settings according to the end-user selection. 

The SeriesDialog form is shown when end-user tries to edit recurrent appointment. It allows to select what object should be edited, the individual occurrence or the whole recurrence pattern. 

The RibbonControls project demonstrates a sample of standard ComboBox control which can be hosted in the C1Ribbon control. It is used in the AppointmentForm class because default ribbon combo box doesn't supply DataSource, DataBindings and OwnerDraw items. 

