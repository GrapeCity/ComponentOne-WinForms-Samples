## Classic (FlexGridClassic)
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\Classic)
____
#### Grid that derives from C1FlexGrid and provides an object model compatible with the VSFlexGrid control.
____
The FlexGridClassic is meant to be used as a resource for migrating existing code and as a sample of how to implement custom grid controls using C1FlexGrid as a base class. 

All C1FlexGrid methods and properties are available to C1FlexGrid classic. 

A few methods and properties are defined by both grids (for example, Rows returns a RowCollection object in C1FlexGrid and a row count in C1FlexGridClassic). In these cases, use the property (Rows) to access the C1FlexGridClassic implementation and use base.<propertyName> (base.Rows) to use the C1FlexGrid implementation. 

