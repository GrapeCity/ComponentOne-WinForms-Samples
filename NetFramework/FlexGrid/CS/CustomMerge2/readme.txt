CustomMerge2
------------------------------------------------------------------------
Implement your own merging logic to mix merging modes.

The C1FlexGrid control offers several built-in merging modes (free, spill, nodes, row/col control, etc).
But there are some limitations.
For example, none of the built-in modes allows you to create merged ranges that span both rows and columns.

This sample shows how you can overcome this limitation by inheriting from the C1FlexGrid and implementing a custom version of the virtual GetMergeRange method.

To see the effect of the custom merging, set the following:
 1. "AllowMerging" to Free.
 2. "Rows" checkbox to true.
 3. "Cols" checkbox to false.

Then click the "Custom" checkbox and watch how the header changes.