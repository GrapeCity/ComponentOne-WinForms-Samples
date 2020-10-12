LegacyDates
------------------------------------------------------------------------
Use an unbound column to convert dates stored as strings into real dates.

The sample binds the grid to a data source where dates are stored as "yyyyMMdd" strings.
It then hides that column and adds an unbound column to display and edit DateTime objects.

The GetUnboundValue and SetUnboundValue events are used to convert dates between
the two formats so the columns are always in synch.