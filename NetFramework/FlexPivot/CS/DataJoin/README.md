## DataJoin
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexPivot\CS\DataJoin)
____
#### Analyzing multiple data tables with user-selectable joins between them.
____
C1 DataEngine can perform data blending (joins) of multiple data tables on the client. This makes it possible for end users to analyse data spread over multiple tables in seconds or less, without calling the server and so avoid long delays from bringing that, usually large, joined data to the client. 

This sample shows a more advanced use of data join functionality, where the user can select an arbitrary set of fields from any of the tables, and the code in the sample builds a dynamic query and executes it to get the joined table that is fed to FlexPivot for analysis. A more simple and perhaps more common case where joins are known beforehand, so simple pre-built queries can be used instead of building dynamic query is provided in the DataEngineQueries sample. 