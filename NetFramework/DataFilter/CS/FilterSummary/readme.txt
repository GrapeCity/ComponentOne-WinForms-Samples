FilterSummary
-----------------------------
This sample demonstrates how to use the FilterSummary for the Checklist filter. 

This sample shows how to use different aggregate expressions and custom format of filter summaries.
The ChecklistFilter class contains the FilterSummary property for customizing filter summary:
- The AggregateType property defines a type of aggregate.
- The Label property sets a text on the left side of the summary, like "{label} {aggregate value}".
- The PropertyName property sets the name of the property for which the aggregate function is applied.
- The CustomFormat is used for formatting aggregation result, like "C0" for the "Max Price" aggregate.