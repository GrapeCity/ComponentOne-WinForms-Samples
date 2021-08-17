UnboundColumns
------------------------------------------------------------------------
Additional support for unbound columns.

Instead of using OwnerDraw code to add content to unbound columns, you can take advantage of the GetUnboundValue and SetUnboundValue events.

The sample binds the grid to a regular DataTable, then adds an unbound column.
The GetUnboundValue and SetUnboundValue events are used to store and retrieve the unbound values associated with each data row.