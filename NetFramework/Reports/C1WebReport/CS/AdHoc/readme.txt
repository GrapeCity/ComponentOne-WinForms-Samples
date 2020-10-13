AdHoc
------------------------------------------------------------------------
Create web reports using parameters provided by the user.

The report shows a sales report and allows the user to select 
some parameters to customize the report.

The sample also shows how you can export the report to an RTF
file on the server and send copies via email.

The sample takes advantage of the automatic caching provided 
by the C1WebReport control. Each combination of parameters is 
automatically stored in a separate slot in the cache and is automatically 
re-utilized if the same parameters are used again. The information in the 
cache is compressed, so the load on the server is dramatically reduced.