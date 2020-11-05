## CustomColumns
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Olap\CS\CustomColumns\CustomColumns)
____
#### Shows how you can customize OLAP output tables by adding your own columns.
____
One of the strengths of C1Olap is that it generated output tables that are regular DataTable objects. Once generated, the output tables can be customized, for example by adding custom calculated columns. 

This sample shows a C1OlapPage and a checkbox that allows the user add two custom columns showing the sum and product of the first two regular columns on the OLAP table. 

The custom calculated columns are added in the handler for the "Updated" event raised by the OLAP engine, so they are always in sync with the OLAP output. 

