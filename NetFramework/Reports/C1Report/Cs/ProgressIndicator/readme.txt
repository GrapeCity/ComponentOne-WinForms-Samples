Progress Indicator
---------------------------------------------------------------
Display a progress indicator form while a report is rendered.

This sample renders a long report with an option of progress 
indicators. A progress indicator form with a Cancel button or 
a simple StatusBar.

The progress indicator form is interesting because it allows
the user to cancel the report. The progress indicator form 
is generic. The constructor takes a C1Report object as a 
parameter and automatically wires up the necessary events.