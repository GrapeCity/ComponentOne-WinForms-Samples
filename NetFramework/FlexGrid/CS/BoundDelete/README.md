## BoundDelete
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\BoundDelete)
____
#### Deletes rows from a bound FlexGrid.
____
You can delete rows by selecting them, then hitting the Delete key. This works because the AllowDelete property is set to true. 

You can delete rows in code using the Rows.Selected property, e.g. 

_flex.Redraw = false; foreach (Row r in _flex.Rows.Selected) _flex.Rows.Remove(r.Index); _flex.Redraw = true; 