ReportDictionary
------------------------------------------------------------------------
Add a custom look up dictionary object to C1Report's script engine.

C1Report uses a script engine to evaluate expressions and execute
report events. You can use the script engine in your applications
by calling the Evaluate and Execute methods.

By default, the script engine exposes report sections, fields, 
datasource fields and aggregate functions as custom objects that can be 
used in script expressions.

The AddScriptObject method allows you to add your own custom objects to 
the report's script context. Typical uses include business objects that 
return information that not stored in any database, or helper objects
that provide methods not available in VBScript.

This sample adds a custom lookup dictionary that is used to replace numbers
with strings. For example, an expression such as

	LookUp.GetValue("supplier", 1)

Would be translated in the supplier name by the LookUp object.