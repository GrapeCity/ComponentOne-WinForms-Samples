CustomMerging4
------------------------------------------------------------------------
Shows how to customize grouping by overriding the GetData method.

You can override the GetMergedRange method to customize grouping. 

But in some cases you may want to use the default merging logic, except
based on arbitrary data (rather than on the actual cell contents). In
these cases you can override both GetMergedRange and GetData, and have
GetData provide your custom data while the grid is calculating the 
merged ranges.

(Based on an original sample provided by Mike Hoeffner)