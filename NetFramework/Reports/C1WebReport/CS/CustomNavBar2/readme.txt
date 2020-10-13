WebReportCustomNavBar 
------------------------------------------------------------------------
Create a custom navigation bar with 'goto page' and 'export' buttons (and Ajax support).

The C1WebReport control has a built-in navigation bar that you can use with 
paged reports. Just set the NavigationBar.Visible property to true, and customize
its appearance with the NavigationBar.Style property.

If the built-in navigation bar does not look or behave exactly the way you want
it to, you can make it invisible and create your own. This sample creates a 
navigation bar inside a table cell.

Custom navigation bars can also use callbacks to take advantage of Ajax.
To do this, the page adds an onclick attribute to each button containing a 
javascript call that causes the callback.

