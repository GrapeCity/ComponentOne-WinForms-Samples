DynamicFormat
------------------------------------------------------------------------
Use script properties to format the report based on its contents.

The sample uses a script property (OnPrint) to change properties in 
field objects as the report is rendered.

The nice thing about this approach is that the formatting becomes part 
of the report, not the application. If you save the report and render it
within another application, the formatting will still be applied.
