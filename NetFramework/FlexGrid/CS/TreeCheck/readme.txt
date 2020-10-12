TreeCheck
---------------------------------------------------------
Shows how to implement a tree with three-state checkboxes.

The sample shows a directory tree where each node has a checkbox.

Checking or unchecking a node automatically checks/unchecks all child 
nodes to match, and updates the state of the parent nodes so they are 
checked/unchecked/indeterminate depending on the state of the child nodes.

Notice how the code is similar to the one used with a standard TreeView control. 
Except the standard TreeView does not support three-state checkboxes...