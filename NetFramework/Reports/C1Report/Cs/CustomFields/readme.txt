CustomFields
------------------------------------------------------------------------
Custom Chart, Gradient, SuperLabel and QRCode fields that can be added to any report.

Implements custom fields Chart (uses C1.Win.C1Chart.C1Chart control),
Gradient, SuperLabel (uses C1.Win.C1SuperTooltip.C1SuperLabel control)
and QRCode (uses C1.Win.C1BarCode.C1QRCode control) custom fields in a
C1.Win.C1Report.CustomFields assembly.

For Chart, SuperLabel and QRCode custom fields to work, corresponding ComponentOne
assemblies must be installed in the designer folder or in the GAC.

To create your own custom fields, follow these steps:

  1. Derive the custom field class from the C1Report.Field class;
  2. Override the GetRenderContent method to provide the field content;
  3. Put the custom field assembly in the GAC or in the designer folder;
  4. Add an entry to the C1ReportDesigner.exe.settings file under the <customfields> node,
     specifying the assembly and custom field class names.

For details on creating and deploying custom fields, refer to the C1Report component documentation.

IMPORTANT NOTE: The CustomFields assembly CANNOT BE USED in projects with "Client profile" targets!

*** History of changes:

* 30-Aug-2016 (.NET 4.0 ONLY): Undefined DYNAMIC_ASMS for Chart and SuperLabel fields.

* 24-Apr-2015: Add Step, Histogram, Radar and Polar chart type of Chart custom field.

* 11-Mar-2015: C1.Win.* dlls removed from the dlls folder, C1.WPF.* updated to build 4.0.20143.448.

* 22-Feb-2012 (.NET 4.0 ONLY): added support for CanGrow/CanShrink to SuperLabel.

* 17-Feb-2012 (.NET 4.0 ONLY): C1.C1Report.CustomFields.4.dll prebuilt version is now synchronized
  with main C1Reports assembly version.

* 07-Feb-2012: added several new properties to the Chart field (note: some are breaking changes,
  certain options must be now set explicitly).

* 07-Feb-2012 (.NET 4.0 ONLY): added new Map custom field.

* 19-Oct-2011 (.NET 4.0 ONLY): fixed: SuperLabel could not be bound to a data field
  (field name was shown instead of data even if Calculated was set to true).

* 19-Oct-2011 (.NET 4.0 ONLY): changed the DynLoader to do "lazy" loading of assemblies,
  and make adding support for new types easier.

* 25-Sep-2011 (.NET 4.0 ONLY): new custom field QRCode. Provides QR (Quick Response) 2D barcode.
  QRCode uses the C1QRCode control provided by C1.Win.C1BarCode.4 assembly, see C1QRCode
  documentation for details.

* 19-Aug-2011: new property added to the Chart custom field:

  public string DataYLabels {get; set;}
    Gets or sets a string containing text labels to use for DataY.
    If null or empty, field names specified by DataY are used as before.

* New in 2011 v1 .NET 4.0 release: New custom field SuperLabel added:

  SuperLabel allows to render HTML using the C1SuperLabel provided by C1.Win.C1SuperTooltip.4
  assembly. That assembly is loaded dynamically, same was as with the chart assembly described
  below. All notes regarding dynamic loading, using and licensing the Chart field also apply to the
  SuperLabel field, with the following two differences:

  - SuperLabel is rendered using the C1.Win.C1SuperTooltip.C1SuperLabel control; - That control
  resides in C1.Win.C1SuperTooltip.4 assembly available from ComponentOne.

  The line that should be added to your app's licenses.licx to avoid the nag screen when using
  SuperLabel is:

  C1.Win.C1SuperTooltip.C1SuperLabel, C1.Win.C1SuperTooltip.4

  You need a valid C1SuperTooltip license (that product is included in ComponentOne Studio for
  WinForms).

  As with chart, you can switch from dynamic to static loading of both chart and super label, by
  removing the definition of DYNAMIC_ASMS from code (note that DYNAMIC_CHART_ASM was renamed to
  DYNAMIC_ASMS).

IMPORTANT NOTE for users of Visual Studio 2010/C# 4.0, C1Report version 4.6.20103.* and later only:

  CustomFields_2010 project and C1.C1Report.CustomFields.4 assembly no longer directly reference the
  C1Chart assembly. Instead, it loads and uses that assembly dynamically. This is done to remove
  dependency of CustomFields on the specific version of C1Chart assembly. Thus the pre-built
  C1.C1Report.CustomFields.4.dll may be used in your application as long as the version of C1Report
  stays the same - but C1Chart may be updated without rebuilding the CustomFields dll.

  To avoid showing the C1Chart nag screen in your app using the pre-built version of CustomFields,
  follow these steps:

  1. Add a reference to C1.Win.C1Chart.4 assembly to your project; 2. Add the following line to your
  project's licenses.licx file:

  C1.Win.C1Chart.C1Chart, C1.Win.C1Chart.4

  (You also need a valid C1Chart license installed on the machine used to build your project, of
  course.)

  To revert to the old behavior of CustomFields assembly in VS2010, follow these steps:

  1. Add a reference to C1.Win.C1Chart.4 assembly to CustomFields_2010 project;
  2. Remove the following line from the top of Chart.cs file:
  #define DYNAMIC_ASMS
  3. You may optionally remove the file DynLoader.cs from the project as well.

<product>C1Report;WinForms</product>
