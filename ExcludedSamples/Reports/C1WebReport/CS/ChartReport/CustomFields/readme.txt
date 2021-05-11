CustomFields
------------------------------------------------------------------------
Custom Chart and Gradient fields that can be added to any report.

The Chart and Gradient fields are custom fields in a C1.Win.C1Report.CustomFields assembly.
(chart fields use the C1Chart control, which must be installed in the designer folder or in the GAC)

To create your own custom fields, follow these steps:

  1 - Derive the custom field class from the C1Report.Field class
  2 - Override the GetRenderContent method to provide the field content
  3 - Put the custom field assembly in the GAC or in the designer folder
  4 - Add an entry to the C1ReportDesigner.exe.settings file under the
      <customfields> node, specifying the assembly and custom field class names.

For details on creating and deploying custom fields, refer to the C1Report component documentation.	  
