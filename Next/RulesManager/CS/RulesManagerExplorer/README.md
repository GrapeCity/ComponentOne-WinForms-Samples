## RulesManagerExplorer
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/Next\RulesManager\CS\RulesManagerExplorer)
____
#### Shows the main features of the RulesManager control.
____
Includes next samples: 

* FlexGridConditionalFormatting. The C1RulesManager provides a conditional formatting for a control which supports IFormattableView interface.
  Such support is built-in for C1FlexGrid control. The rules manager control contains a collection of rules which can be setup in variety of parameters - with predefined or custom expression,
  with different styling options. Also each rule can be applied to the whole data or specific range of it.
  Each UI element of control (e.g. header, add or remove rule buttons, rule expression editor, etc.) can be hidden separately if such UI element would not be used in final application.

* ExcelLikeConditionalFormatting. The C1RulesManager control provides API for setting up rule expression, style and to which range of data such rule should be applied.
  Using of API allows to develop application which even not show rules manager control in the application, but apply conditional formatting.
  As an example of such application can be excel-like app which use for setup of rules some forms with predefined expression and
  styles or some menu items which apply gradient rule (data bars, color scales, icon sets) to the selected cells of grid.

* DataGridViewConditionalFormatting. The C1RulesManager provides a conditional formatting for a control which supports IFormattableView interface.
  Any WinForms control (e.g. MS DataGridView) can be extended for using with C1RulesManager by implementing such interface.
  This sample shows such basic implementation.
  Due to the fact that gradient rules support was not added in the provided implementation and to not confuse end-user about not-working functionality,
  the gradient rules tab was hidden in the rules manager UI.

* ChartConditionalFormatting. Conditional formatting can be used not only with grid controls, but for example with charts.
  Implementation of IFormattableView C1RulesManager interface allows to add such possibility.
  The sample contains 2 chart controls - FlexChart and FlexPie which implements IFormattableView interface.
  The single C1RulesManager is bound to both controls to show the same data (UnitsOnOrder column of DataTable) in the different representations.
