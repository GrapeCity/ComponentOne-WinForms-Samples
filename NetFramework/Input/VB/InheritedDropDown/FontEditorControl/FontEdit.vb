
' FontEdit control
Imports C1.Win.C1Input

<
ToolboxBitmap(GetType(FontEdit)),
LicenseProvider(GetType(LicenseProvider))
>
Public Class FontEdit
    Inherits C1DropDownControl

    Private _dropDownForm As DropDownForm
    Friend _lastValue As Font = Nothing

    Public Sub New()
        _dropDownForm = New FontEditForm
        MyBase.DropDownForm = _dropDownForm
        MyBase.DataType = GetType(Font)
        MyBase.ShowUpDownButtons = False
        MyBase.InterceptArrowKeys = False
        MyBase.EmptyAsNull = True
    End Sub

    ' properties
    < _
    Description("The font edited in the control."), _
    Editor(GetType(FontEditor), GetType(UITypeEditor)), _
    TypeConverter(GetType(FontConverter)) _
    > _
    Public Shadows Property Value() As Object
        Get
            Dim v As Object = MyBase.Value
            If TypeOf v Is Font Then Return v
            Return Nothing
        End Get
        Set(ByVal xValue As Object)
            MyBase.Value = xValue
        End Set
    End Property

    < _
    Description("Enumeration value determining the formatting and parsing method."), _
    TypeConverter(GetType(FormatTypeConverter)) _
    > _
    Public Shadows Property FormatType() As FormatTypeEnum
        Get
            Return MyBase.FormatType
        End Get
        Set(ByVal Value As FormatTypeEnum)
            MyBase.FormatType = Value
        End Set
    End Property

    ' methods
    Protected Overrides Sub OnValueChanged(ByVal e As EventArgs)
        MyBase.OnValueChanged(e)
        Try
            Dim obj As Object = Me.Value
            If obj Is Nothing Then
                _lastValue = Nothing
            Else
                _lastValue = CType(obj, Font)
            End If
        Catch
        End Try
    End Sub

    Protected Overrides Sub OnDropDownOpened(ByVal e As EventArgs)
        MyBase.OnDropDownOpened(e)

        ' Needed because many instances of FontEdit class
        ' share the single instance of FontEditForm class
        MyBase.DropDownForm = _dropDownForm
    End Sub


    ' hidden properties
    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property ScrollBars() As ScrollBars
        Get
            Return MyBase.ScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            MyBase.ScrollBars = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property Lines() As String()
        Get
            Return MyBase.Lines
        End Get
        Set(ByVal Value As String())
            MyBase.Lines = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) _
    > _
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal Value As String)
            MyBase.Text = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property AcceptsReturn() As Boolean
        Get
            Return MyBase.AcceptsReturn
        End Get
        Set(ByVal Value As Boolean)
            MyBase.AcceptsReturn = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property AcceptsTab() As Boolean
        Get
            Return MyBase.AcceptsTab
        End Get
        Set(ByVal Value As Boolean)
            MyBase.AcceptsTab = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property InterceptArrowKeys() As Boolean
        Get
            Return MyBase.InterceptArrowKeys
        End Get
        Set(ByVal Value As Boolean)
            MyBase.InterceptArrowKeys = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Overrides Property Multiline() As Boolean
        Get
            Return MyBase.Multiline
        End Get
        Set(ByVal Value As Boolean)
            MyBase.Multiline = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property PasswordChar() As Char
        Get
            Return MyBase.PasswordChar
        End Get
        Set(ByVal Value As Char)
            MyBase.PasswordChar = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Overrides Property ShowUpDownButtons() As Boolean
        Get
            Return MyBase.ShowUpDownButtons
        End Get
        Set(ByVal Value As Boolean)
            MyBase.ShowUpDownButtons = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property WordWrap() As Boolean
        Get
            Return MyBase.WordWrap
        End Get
        Set(ByVal Value As Boolean)
            MyBase.WordWrap = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Overrides Property DataType() As Type
        Get
            Return MyBase.DataType
        End Get
        Set(ByVal Value As Type)
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) _
    > _
    Public Shadows ReadOnly Property PostValidation() As PostValidation
        Get
            Return MyBase.PostValidation
        End Get
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property TextDetached() As Boolean
        Get
            Return MyBase.TextDetached
        End Get
        Set(ByVal Value As Boolean)
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property CurrentTimeZone() As Boolean
        Get
            Return MyBase.CurrentTimeZone
        End Get
        Set(ByVal Value As Boolean)
            MyBase.CurrentTimeZone = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property GMTOffset() As TimeSpan
        Get
            Return MyBase.GMTOffset
        End Get
        Set(ByVal Value As TimeSpan)
            MyBase.GMTOffset = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property MinShortYear() As Int32
        Get
            Return MyBase.MinShortYear
        End Get
        Set(ByVal Value As Int32)
            MyBase.MinShortYear = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property DropDownFormClassName() As String
        Get
            Return MyBase.DropDownFormClassName
        End Get
        Set(ByVal Value As String)
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property CustomFormat() As String
        Get
            Return MyBase.CustomFormat
        End Get
        Set(ByVal Value As String)
            MyBase.CustomFormat = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Overrides Property DateTimeInput() As Boolean
        Get
            Return MyBase.DateTimeInput
        End Get
        Set(ByVal Value As Boolean)
            MyBase.DateTimeInput = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) _
    > _
    Public Shadows ReadOnly Property DisplayFormat() As FormatInfo
        Get
            Return MyBase.DisplayFormat
        End Get
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) _
    > _
    Public Shadows ReadOnly Property EditFormat() As FormatInfo
        Get
            Return MyBase.EditFormat
        End Get
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) _
    > _
    Public Shadows Property EditMask() As String
        Get
            Return MyBase.EditMask
        End Get
        Set(ByVal Value As String)
            MyBase.EditMask = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Property EmptyAsNull() As Boolean
        Get
            Return MyBase.EmptyAsNull
        End Get
        Set(ByVal Value As Boolean)
            MyBase.EmptyAsNull = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) _
    > _
    Public Shadows ReadOnly Property MaskInfo() As MaskInfo
        Get
            Return MyBase.MaskInfo
        End Get
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Overrides Property NumericInput() As Boolean
        Get
            Return MyBase.NumericInput
        End Get
        Set(ByVal Value As Boolean)
            MyBase.NumericInput = Value
        End Set
    End Property

    < _
    Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) _
    > _
    Public Shadows ReadOnly Property ParseInfo() As ParseInfo
        Get
            Return MyBase.ParseInfo
        End Get
    End Property

    ' hidden events
    < _
    Browsable(False), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Event UpDownButtonClick As UpDownButtonClickEventHandler
    <EditorBrowsable(EditorBrowsableState.Never)> _
    Protected Overrides Sub OnUpDownButtonClick(ByVal e As UpDownButtonClickEventArgs)
        MyBase.OnUpDownButtonClick(e)
        RaiseEvent UpDownButtonClick(Me, e)
    End Sub

    <Browsable(False)> _
    Public Shadows Event PostValidating As PostValidationEventHandler
    Protected Overrides Sub OnPostValidating(ByVal e As PostValidationEventArgs)
        MyBase.OnPostValidating(e)
        RaiseEvent PostValidating(Me, e)
    End Sub

    <Browsable(False)> _
    Public Shadows Event PostValidated As PostValidationEventHandler
    Protected Overrides Sub OnPostValidated(ByVal e As PostValidationEventArgs)
        MyBase.OnPostValidated(e)
        RaiseEvent PostValidated(Me, e)
    End Sub

    < _
    Browsable(False), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Event AcceptsTabChanged As EventHandler
    <EditorBrowsable(EditorBrowsableState.Never)> _
    Protected Overrides Sub OnAcceptsTabChanged(ByVal e As EventArgs)
        MyBase.OnAcceptsTabChanged(e)
        RaiseEvent AcceptsTabChanged(Me, e)
    End Sub

    < _
    Browsable(False), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Event DataTypeChanged As EventHandler
    <EditorBrowsable(EditorBrowsableState.Never)> _
    Protected Overrides Sub OnDataTypeChanged(ByVal e As EventArgs)
        MyBase.OnDataTypeChanged(e)
        RaiseEvent DataTypeChanged(Me, e)
    End Sub

    < _
    Browsable(False), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Event MultilineChanged As EventHandler
    <EditorBrowsable(EditorBrowsableState.Never)> _
    Protected Overrides Sub OnMultilineChanged(ByVal e As EventArgs)
        MyBase.OnMultilineChanged(e)
        RaiseEvent MultilineChanged(Me, e)
    End Sub

    < _
    Browsable(False), _
    EditorBrowsable(EditorBrowsableState.Never) _
    > _
    Public Shadows Event TextChanged As EventHandler
    <EditorBrowsable(EditorBrowsableState.Never)> _
    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        RaiseEvent TextChanged(Me, e)
    End Sub
End Class

' FormatTypeConverter
Friend Class FormatTypeConverter
    Inherits EnumConverter

    Public Sub New(ByVal tp As Type)
        MyBase.New(tp)
    End Sub

    Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overloads Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
        Dim arr As Object() = {FormatTypeEnum.DefaultFormat, FormatTypeEnum.UseEvent}
        Return New StandardValuesCollection(arr)
    End Function
End Class
