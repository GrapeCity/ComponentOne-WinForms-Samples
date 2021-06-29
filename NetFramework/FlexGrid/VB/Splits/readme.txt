Splits
------------------------------------------------------------------------
Split a C1FlexGrid into multiple views.

The C1FlexGrid control doesn't have built-in splits. Instead, it has frozen rows and columns, which perform a similar function.

If you need full-fledged splits, then you have to follow these steps:
1. Create multiple instances of the control (one per 'split view') and arrange them on the form.
2. Select one of the splits to be the 'master' view. This is the one that will hold the data for the subordinate views.
3. Set the DataSource property on each of the subordinate views to reference the master view. 
For example:

<code>
_flexSub1.DataSource = _flexSub2.DataSource = _flexMaster;
</code>

4. Write code to display scrollbars and synchronize the scrolling as appropriate for the layout you selected.

The sample shows how to create a 4-way split, with two views on top and two below.