DataAnnotations
-------------------------------------------------------------------------------
Shows how the C1FlexGrid honors DataAnnotation attributes.

DataAnnotation attributes allow developers to add meta-data to their classes,
making it easier to bridge the gap between models and views. For example, you 
may use DataAnnotations to specify how items should be formatted, what their
captions should be, whether they should be editable or displayed.

To use DataAnnotation attributes in your projects, start by adding a reference 
to the System.ComponentModel.DataAnnotations assembly to your project. Note:
the C1FlexGrid supports the annotations defined in .NET 4, so make sure your
System.ComponentModel.DataAnnotations is version 4.0.0.0 or higher.

Then add the attributes to your data objects as usual. For example:

<code>
    Class MyDataItem
    {
        ' auto-generated CustomerName column header will show "Customer".
        ' (even though the property name Is "CustomerName")
        ' This column also requires non-empty string with minimal length at least 2 symbols.
        <Display(Name:="Customer")>
        <Required>
        <StringLength(Integer.MaxValue, MinimumLength:=2)>
        Public Property CustomerName As String

        ' auto-generated CustomerID column will be invisible.
        <Display(AutoGenerateField:=False)>
        Public Property CustomerID As Integer

        ' auto-generated "Frequency" column will show values formatted as percentages
        ' And will Not allow editing.
        <DisplayFormat(DataFormatString:="0%")>
        <Editable(False)>
        Public Property Frequency As Double

        ' auto-generated "Age" column will allow values in the predefined
        ' range.
        <Required>
        <Range(10, 90)>
        Public Property Age As Integer
	}
</code>

The attributes will be honored by all controls that support DataAttributes, including
the C1FlexGrid for WinForms, Silverlight, and WPF, as well as many other controls.