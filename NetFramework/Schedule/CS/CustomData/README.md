## CustomData
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Schedule\CS\CustomData)
____
#### Demonstrates creating and storing a Fitness Center schedule using the C1Schedule and C1Calendar controls. 
____
The sample shows how to:

* bind to custom data;
* use a custom Appointment Form;
* work with components in code.
The sample shows the timetable as a WeekView. It prevents C1Schedule from switching to other views.
It doesn't show built-in context menus and ReminderForm.

At run time, the user can:

* create new exercises by double-clicking on desired day and time;
* edit exercises in-place or in ExerciseForm;
* copy timetable information from one day/week to another one;
* clear current week timetable;
When closed the application saves all timetable information to the FitnessClub database which is included in the solution.

Data binding:    

* AppoinmentStorage is bound to the TimeTable table from the FitnessClub database;
* ContactStorage is bound to the Instructors table from the FitnessClub database;
* LabelStorage is bound to the LevelCollection collection;
* ResourceStorage is bound to the ArrayList of Location objects;
* CategoryStorage is bound to ExerciseCategories list.
DataSource and mappings for first 2 storages are set from Smart Designers.
DataSource and mappings for last 3 storages are set from code.

The ExerciseForm class represents a form which is used instead of built-in AppointmentForm.
For more details see the sample's code comments.
