Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Xml
Imports C1.Win.C1Ribbon

''' <summary>
''' The Ribbon element that contains a NumericUpDown.
''' </summary>
Public Class NumericUpDownHost
    Inherits RibbonControlHost

    Public Const XmlNodeName As String = "numericUpDownHost"

    ''' <summary>
    ''' Creates the NumericUpDown control and its host element.
    ''' </summary>
    Public Sub New()
        MyBase.New(New NumericUpDown())
    End Sub

    ''' <summary>
    ''' <inheritdoc />
    ''' </summary>
    Public Overrides ReadOnly Property ControlHostNodeName As String
        Get
            Return XmlNodeName
        End Get
    End Property

    ''' <summary>
    ''' Gets the hosted NumericUpDown control.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property NumericUpDown() As NumericUpDown
        Get
            Return CType(Control, NumericUpDown)
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the value assigned to the NumericUpDown.
    ''' </summary>
    <Category("Data")> _
    <Description("Gets or sets the value assigned to the NumericUpDown.")> _
    Public Property Value() As System.Decimal
        Get
            Return NumericUpDown.Value
        End Get
        Set(ByVal value As System.Decimal)
            NumericUpDown.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the minimum value for the NumericUpDown.
    ''' </summary>
    <Category("Behavior")> _
    <Description("Gets or sets the minimum value for the NumericUpDown.")> _
    <DefaultValue(0)> _
    Public Property Minimum() As System.Decimal
        Get
            Return NumericUpDown.Minimum
        End Get
        Set(ByVal value As System.Decimal)
            NumericUpDown.Minimum = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the maximum value for the NumericUpDown.
    ''' </summary>
    <Category("Behavior")> _
    <Description("Gets or sets the maximum value for the NumericUpDown.")> _
    <DefaultValue(100)> _
    Public Property Maximum() As System.Decimal
        Get
            Return NumericUpDown.Maximum
        End Get
        Set(ByVal value As System.Decimal)
            NumericUpDown.Maximum = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the value to increment or decrement the NumericUpDown when the up or down buttons are clicked.
    ''' </summary>
    <Category("Behavior")> _
    <Description("Gets or sets the value to increment or decrement the NumericUpDown when the up or down buttons are clicked.")> _
    <DefaultValue(1)> _
    Public Property Increment() As System.Decimal
        Get
            Return NumericUpDown.Increment
        End Get
        Set(ByVal value As System.Decimal)
            NumericUpDown.Increment = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the text that appears on the NumericUpDown.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
        End Set
    End Property

    ''' <summary>
    ''' Occurs when the <see cref="Value"/> property changes.
    ''' </summary>
    <Category("Property Changed")> _
    <Description("Occurs when the Value property changes.")> _
    Public Event ValueChanged As EventHandler
    ''' <summary>
    ''' Raises the <see cref="ValueChanged"/> event.
    ''' </summary>
    Protected Overridable Sub OnValueChanged(ByVal e As EventArgs)
        RaiseEvent ValueChanged(Me, e)
    End Sub

    Protected Overrides Sub OnSubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnSubscribeControlEvents(ctrl)
        AddHandler CType(ctrl, NumericUpDown).ValueChanged, AddressOf HandleValueChanged
    End Sub
    Protected Overrides Sub OnUnsubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnUnsubscribeControlEvents(ctrl)
        RemoveHandler CType(ctrl, NumericUpDown).ValueChanged, AddressOf HandleValueChanged
    End Sub

    Private Sub HandleValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnValueChanged(e)
    End Sub

    Protected Overrides Sub LoadControlHostProperties(ByVal node As XmlNode)
        MyBase.LoadControlHostProperties(node)
        Value = Read(node, "value", 0)
        Minimum = Read(node, "minimum", 0)
        Maximum = Read(node, "maximum", 100)
        Increment = Read(node, "increment", 1)
    End Sub

    Protected Overrides Sub SaveControlHostProperties(ByVal writer As XmlWriter)
        MyBase.SaveControlHostProperties(writer)
        Write(writer, "value", Value, 0)
        Write(writer, "minimum", Minimum, 0)
        Write(writer, "maximum", Maximum, 100)
        Write(writer, "increment", Increment, 1)
    End Sub

    Private Shared Function Read(ByVal node As XmlNode, ByVal attName As String, ByVal defVal As Decimal) As Decimal
        Dim att As XmlAttribute = node.Attributes(attName)
        If att IsNot Nothing Then
            Return Decimal.Parse(att.Value)
        End If

        Return defVal
    End Function

    Private Shared Sub Write(ByVal writer As XmlWriter, ByVal attName As String, ByVal value As Decimal, ByVal defVal As Decimal)
        If value <> defVal Then
            writer.WriteAttributeString(attName, value.ToString())
        End If
    End Sub

End Class
