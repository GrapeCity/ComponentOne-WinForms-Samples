Links
------------------------------------------------------------------------
Create web reports with links to other reports.

The main report list product categories. When a category is clicked,
a new window opens with a report of products in the selected category.

This is done by setting the LinkTarget property on a field in the main
report to a script that invokes the second page and passes the 
category id as a parameter.