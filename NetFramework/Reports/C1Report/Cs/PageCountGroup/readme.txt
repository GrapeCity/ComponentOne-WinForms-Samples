PageCountGroup
------------------------------------------------------------------------
Keep separate page counts for each group in a report.

C1Report has a built-in Pages variable that allows you to print "Page
n of m" fields. This requires a second pass through the report, because
the control doesn't know how many pages the report will have until it
is complete.

In some cases, you may want to keep separate page counts for each group
in a report. This sample shows how you can do that using two passes. 
The sample calls the Render() method once to count how many pages will
be in each group, then a second time to render the groups with the page
counts.

