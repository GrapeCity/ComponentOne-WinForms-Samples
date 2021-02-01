## CustomColumns
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\VB\CustomColumns)
____
#### Shows how you can customize FlexPivot output tables by adding your own columns.
____
One of the strengths of C1FlexPivot is that it generated output tables that are regular DataTable objects. Once generated, the output tables can be customized, for example by adding custom calculated columns. 

This sample shows a C1FlexPivotPage and a checkbox that allows the user add two custom columns showing the sum and product of the first two regular columns on the FlexPivot table. 

The custom calculated columns are added in the handler for the "Updated" event raised by the FlexPivot engine, so they are always in sync with the FlexPivot output. 

