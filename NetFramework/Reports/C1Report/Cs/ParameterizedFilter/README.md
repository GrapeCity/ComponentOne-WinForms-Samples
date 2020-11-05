## ParameterizedFilter
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\Cs\ParameterizedFilter)
____
#### Create reports with a parameterized filter.
____
C1Report supports parameterized reports through the use of a PARAMETERS clause in the RecordSource string. This mechanism prompts users for parameters and modifies the SQL string to retrieve only the selected records. 

This sample shows how you can use this mechanism to modify the Filter property instead. This can be useful in situations where you supply a data source object using the Recordset property. In these situations, the RecordSource property is not used (the control does not retrieve any data), but the Filter property still applies. 