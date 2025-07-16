## CustomScheduleTableViews 
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Schedule\CS\CustomTableViews)
____
#### Demonstrates how to build custom Agenda and Table views representing scheduling data.
____
The sample application includes C1.Win.Schedule.Extended assembly which contains table and agenda views.
Table and Agenda views allows you to represent C1Schedule's data in compact form aceptable for quick search and group operations like removing appointments.
These views are separate controls, so you can use them in any place of your application.
Both views require reference to the C1Schedule control, filled with data.
They can only show Appointments which are loaded into the owning C1Schedule control.

The C1.Win.Schedule.Extended assembly contains 2 controls you can use to extend your scheduling app.
The AgendaView control represents appointments grouped by the start date. 
You can set this view to show agenda for current day, next 7 days or for the whole interval of days represented by the C1Schedule control.
The main goal of AgendaView is to show nearest events in compact form, so that end-user can quickly pick some event without navigating via C1Schedule calendar views.

The TableView control represents all appointments in a table view which supports sorting, filtering, in-place editing and removing appointments by end-user.
This view can be customized by changing properties of AppointmentField objects. This allows to show or hide appointment fields, setup grouping or sort options.
Set TableView.Active property to true to filter out inactive appointments from this view.

Double click on eny appointment in the AgendaView or TableView opens C1Schedule's AppointmentForm for editing.
All end-user changes are propagated from C1Schedule control to table views and vice versa with no custom code.

Both AgendaView and TableView controls are inherited from the C1FlexGrid control.
That allows you to customize appearance and behavior based on FlexGrid's object model.
The ComponentOne Themes are supported in both views with no code.
