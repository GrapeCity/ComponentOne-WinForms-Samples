FilterRow_With_Totals
--------------------------------------------------------------------------------------------------------
This sample shows a how to add totals to a bound grid with a FilterRow.

The main point of the sample is to show how to refresh the totals when the filter changes.
When this happens, the data source is reset and the old totals are cleared.
To restore them, the sample calls the SubTotal method in response to the AfterDataRefresh event.