## FlexCalc
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexGrid\CS\FlexCalc\FlexCalc)
____
#### This sample demonstrates how you can add an Excel-like calculation engine to the FlexGrid.
____
The core of the sample is a CalcEngine class that includes a parser and an evaluator.
The parser converts strings into expressions, and the evaluator calculates the value of the expressions.
For example:

```
	var ce = new CalcEngine();
	var expression = ce.Parse("1+2+3");
	var value = expression.Evaluate();
```
Alternatively, the CalcEngine can parse and evaluate strings with a single call to the Evaluate method. For example:

```
	var ce = new CalcEngine();
	var value = ce.Evaluate("1+2+3");
```
The second method is often more convenient since it doesn't require the caller to keep track of the parsed expressions.
To improve the efficiency of this method, the CalcEngine keeps a cache of parsed expressions.
The cache is implemented using WeakReference objects to avoid accumulating unused expressions.

The CalcEngine class is completely independent of the FlexGrid and may be re-used in  other projects that require expression evaluation.
The class is extensible and can be customized for specific applications as described below:

* Functions. The CalcEngine has about 70 built-in functions found in Excel (Excel has about 350). To add more functions, use the RegisterFunction method.
   This method takes the function name, number of parameters, and a delegate that is invoked when the function is called and returns the function value.

* DataContext: The CalcEngine has a DataContext property that allows you to add arbitrary objects to the engine's context.
   For example, if you set the engine's DataContext property to an object of type Customer,
   then you can use the properties of the Customer object in your expressions (e.g. assuming the Customer class had a "Sales" property, then you could evaluate "Sales * 12%").

* External Objects. The CalcEngine supports 'external' objects that are added to the engine context dynamically.
   For example, Excel ranges are represented by strings such as "A1".
   These objects cannot be created ahead of time.
   Instead, the sample uses a "FlexCalcEngine" class that extends the base CalcEngine and overrides the GetExternalObject method to create cell range objects dynamically.

The cell range objects support multi-cell ranges, allowing you to use formulas such as "sum(a1:b12, d1:e12)".

To use the CalcEngine within the FlexGrid, the sample uses a "FlexCalc" class that extends the base C1FlexGrid and overrides a few methods, including the following:

* GetDataDisplay: This method is overridden to detect the presence of formulas in grid cells and to evaluate them. Formulas are strings that start with an equals sign ("=").
* SetData: This method is overridden to detect changes to any cell and to invalidate all visible cells that contain formulas, causing them to be re-evaluated with the new values.
   This is much simpler and easier than keeping track of dependencies between formulas.

In addition to the CalcEngine, the sample implements a formula bar above the grid.
The formula bar shows the coordinates of the current cell using Excel notation and allows viewing and editing the content of the selected cell.

Finally, the sample uses owner-draw to display the row and column coordinates in the grid's header cells and implements an Excel-like marquee that highlights the selection.

![screenshot](screenshot.PNG)
