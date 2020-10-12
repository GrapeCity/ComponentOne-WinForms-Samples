ExcelEngine
---------------------------------------------
This sample demonstrates how to use C1CalcEngine to calculate a simple Excel style formulas.

This project uses C1CalcEngine to operate with data mined from two grids that represented as two 
Excel-style sheets.The sheets can be addressed as "sheet1" and "sheet2" in the TextBox. 
Respectively the area for calculating is described as A1:B2, e.i. as in Excel.
The first DataSource for CalcEngine is a DataTable descendant, a data source for the first grid.
The second is the second grid itself, a descendant of C1FlexGrid.
You can select areas in two grids to change the formula and calculate the sum.
