BoundDelete
------------------------------------------------------------------------
Deletes rows from a bound FlexGrid.

You can delete rows by selecting them, then hitting the Delete key.
This works because the AllowDelete property is set to true.
You can delete rows in code using the Rows.Selected property, e.g.

<code>
   _flex.Redraw = false;
   foreach (Row r in _flex.Rows.Selected)
      _flex.Rows.Remove(r.Index);
   _flex.Redraw = true;
</code>