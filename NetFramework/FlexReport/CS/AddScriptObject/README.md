## AddScriptObject
#### [Download as zip](https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\FlexReport\CS\AddScriptObject)
____
#### Add custom objects to FlexReport's script engine.
____
FlexReport uses a script engine running a version of VBScript language to evaluate expressions and execute report script events.
You can also use the script engine in your applications by calling the Evaluate and Execute methods.

In addition to the standard VBScript functions and constants, the FlexReport's script engine exposes many report-specific objects 
(such as the report object itself, sections, sub-sections and fields, aggregate functions and so on) that can be used in script expressions.

The C1FlexReport.GetScriptObject event allows you to add your own custom objects to the report's script context.
Typical uses include business objects that can return information that is not stored in any database, or helper objects that provide functions not available in FlexReport's VBScript.

In this sample, the C1FlexReport.GetScriptObject event handler allows the report to access a TextBox control living on the parent form, 
and to use the MathHelper object implemented in the sample that provides a Factorial function.
Note that in the report (you can access the report definition via the "Edit Report..." context menu on the c1FlexReport1 object in the Visual Studio forms designer) 
not only the TextBox's text is shown, but its colors and font size are used by the report's GlobalScripts script to set up the report field.
