CustomForms
-----------------------------------------
Demonstrates how to use the C1Schedule and C1Calendar controls to create and store a timetable of a Fitness Center. 

The sample shows how to:
 - bind to custom data;
 - use a custom Appointment Form;
 - use a custom Reminder Form;
 - work with components in code.
The sample doesn't show built-in context menus and ReminderForm.

At run time, the user can:
 - Create new exercises by double-clicking on desired day and time.
 - Edit exercises in-place or in ExerciseForm.
 - Copy timetable information from one day/week to another one.
 - Clear current week timetable.

The ExerciseForm class represents a form which is used instead of the built-in AppointmentForm.
The ReminderForm class represents a form which is used instead of the built-in ReminderForm.

Data binding:    
 - LabelStorage is bound to the LevelCollection collection.
 - ResourceStorage is bound to the ArrayList of Location objects.
 - CategoryStorage is bound to ExerciseCategories list.
DataSource and mappings for these 3 storages are set in code.

For more details see the sample's code comments.