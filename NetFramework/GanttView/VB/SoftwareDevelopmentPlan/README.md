## SoftwareDevelopmentPlan
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\GanttView\VB\SoftwareDevelopmentPlan)
____
#### Demonstrates an example that uses C1Ribbon to replace ToolStrip in C1GanttView
____
This sample put C1Ribbon, C1Status and C1GanttView in the same C1RibbonForm. The GanttView's toolstrip will be hidden and we use a ribbon to replace and extend its functionalities. This GanttView represents a Software development project, we customize some settings such as: add a vacation day and change time begin/end working day in default calendar, change nonworking day's color... When a dialog is showing, the status bar will display BUSY on the left, otherwise READY. This sample handles C1GanttView.SelectedIndexChanged event to update TaskMode of current selected task into two RibbonToggleButtons. 

Update: 

A track bar has added to left side of status bar. It provides a convenient way to zoom in / zoom out the chart by dragging the track bar. View tab have been added to Ribbon, it contains some items to do zoom operations such as: ZoomSelectedTask, ZoomEntireProject, Custom Zoom... 