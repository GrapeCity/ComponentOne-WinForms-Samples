## PageCountGroup
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\Cs\PageCountGroup)
____
#### Keep separate page counts for each group in a report.
____
C1Report has a built-in Pages variable that allows you to print "Page n of m" fields. This requires a second pass through the report, because the control doesn't know how many pages the report will have until it is complete. 

In some cases, you may want to keep separate page counts for each group in a report. This sample shows how you can do that using two passes. The sample calls the Render() method once to count how many pages will be in each group, then a second time to render the groups with the page counts. 

