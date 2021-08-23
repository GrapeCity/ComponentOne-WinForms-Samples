ParseParameters
------------------------------------------------------------------------
Parse a PARAMETERS statement in a RecordSource string.

C1Report allows you to create parameterized reports that prompt the
user for parameter values automatically before the report is rendered.

This sample shows how you can parse the PARAMETERS clause in case you
want to implement your own parameter dialog (or customize the handling
of parameters in some other way).