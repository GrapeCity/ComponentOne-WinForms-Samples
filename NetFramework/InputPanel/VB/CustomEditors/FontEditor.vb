Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design
Imports System.Reflection
Imports C1.Win.C1InputPanel

''' <summary>
''' The host component for the FontEditorControl on an input panel.
''' </summary>
<DefaultEvent("SelectedFontChanged")> _
Public Class FontEditorHost
    Inherits InputControlHost

#Region "** ctor"

    Public Sub New()
        MyBase.New(New FontEditorControl())
    End Sub

#End Region

#Region "** properties"

    ''' <summary>
    ''' Gets the hosted font editor control.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property FontEditor() As FontEditorControl
        Get
            Return CType(Control, FontEditorControl)
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the selected font.
    ''' </summary>
    <Category("Data")> _
    <Description("Gets or sets the selected font.")> _
    <DefaultValue(CType(Nothing, String))> _
    Public Property SelectedFont() As Font
        Get
            Return FontEditor.SelectedFont
        End Get
        Set(ByVal value As Font)
            FontEditor.SelectedFont = value
        End Set
    End Property

#End Region

#Region "** events"

    ''' <summary>
    ''' Fires when the <see cref="SelectedFont"/> property is changed.
    ''' </summary>
    <Category("Property Changed")> _
    <Description("Fires when the value of the SelectedFont property changes.")> _
    Public Event SelectedFontChanged As EventHandler
    ''' <summary>
    ''' Raises the <see cref="SelectedFontChanged"/> event.
    ''' </summary>
    Protected Overridable Sub OnSelectedFontChanged(ByVal e As EventArgs)
        RaiseEvent SelectedFontChanged(Me, e)
    End Sub

#End Region

#Region "** methods"

    Protected Overrides Sub OnSubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnSubscribeControlEvents(ctrl)
        AddHandler CType(ctrl, FontEditorControl).SelectedFontChanged, AddressOf HandleSelectedFontChanged
    End Sub

    Protected Overrides Sub OnUnsubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnUnsubscribeControlEvents(ctrl)
        RemoveHandler CType(ctrl, FontEditorControl).SelectedFontChanged, AddressOf HandleSelectedFontChanged
    End Sub

    Private Sub HandleSelectedFontChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnSelectedFontChanged(e)
    End Sub

#End Region

End Class

''' <summary>
''' Uses the font UITypeEditor to show a form where users can choose fonts.
''' </summary>
Public Class FontEditorControl
    Inherits ComboBox
    Implements IServiceProvider, IWindowsFormsEditorService

#Region "** fields"

    ' UITypeEditor responsible for editing the values
    Private _editor As FontEditor

    ' current editor value 
    Private _selectedFont As Font

#End Region

#Region "** static members"

    Private Shared _fontConverter As TypeConverter

    ' cache the font converter in a static field
    Shared Sub New()
        _fontConverter = TypeDescriptor.GetConverter(GetType(Font))
    End Sub

#End Region

#Region "** ctor"

    Public Sub New()
        _editor = New FontEditor()

        ' initialize combo
        DrawMode = DrawMode.OwnerDrawFixed
    End Sub

#End Region

#Region "** property"

    ''' <summary>
    ''' Gets or sets the selected font.
    ''' </summary>
    Public Property SelectedFont() As Font
        Get
            Dim result As Font = Nothing
            Try
                result = CType(_fontConverter.ConvertFromString(Text), Font)
            Catch
            End Try
            Return result
        End Get
        Set(ByVal value As Font)
            If value IsNot Nothing Then
                Text = _fontConverter.ConvertToString(value)
            Else
                Text = String.Empty
            End If
            If Not FontsAreEqual(_selectedFont, value) Then
                _selectedFont = value
                OnSelectedFontChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Returns true if two fonts are equivalent.
    ''' </summary>
    Public Shared Function FontsAreEqual(ByVal font1 As Font, ByVal font2 As Font) As Boolean
        If font1 Is Nothing Then
            Return font2 Is Nothing
        Else
            Return font1.Equals(font2)
        End If
    End Function

#End Region

#Region "** event"

    ''' <summary>
    ''' Fires when the <see cref="SelectedFont"/> property is changed.
    ''' </summary>
    Public Event SelectedFontChanged As EventHandler
    ''' <summary>
    ''' Raises the <see cref="SelectedFontChanged"/> event.
    ''' </summary>
    Protected Overridable Sub OnSelectedFontChanged(ByVal e As EventArgs)
        RaiseEvent SelectedFontChanged(Me, e)
    End Sub

#End Region

#Region "** overrides"

    Protected Overrides Sub OnValidating(ByVal e As CancelEventArgs)
        If Text.Length > 0 AndAlso SelectedFont Is Nothing Then
            e.Cancel = True
        End If
        MyBase.OnValidating(e)
    End Sub

    Protected Overrides Sub OnValidated(ByVal e As EventArgs)
        MyBase.OnValidated(e)
        SelectedFont = SelectedFont
    End Sub

    Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Return OrElse keyData = Keys.Escape Then
            If Not FontsAreEqual(_selectedFont, SelectedFont) Then
                Return True
            End If
        End If
        Return MyBase.IsInputKey(keyData)
    End Function

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If (Not IsDisposed) AndAlso (e.KeyData = Keys.Return OrElse e.KeyData = Keys.Escape) Then
            Dim newSelectedFont As Font = SelectedFont
            If Not FontsAreEqual(newSelectedFont, _selectedFont) Then
                SelectedFont = IIf(e.KeyData = Keys.Escape, _selectedFont, newSelectedFont)
                SelectAll()
                e.Handled = True
            End If
        End If
        MyBase.OnKeyDown(e)
    End Sub

    ' if the user can type, show drop down when requested
    Protected Overrides Sub OnDropDown(ByVal e As EventArgs)
        ' fire event as usual
        MyBase.OnDropDown(EventArgs.Empty)

        ' show editor and get the new value
        Dim value As Object = _editor.EditValue(CType(Me, IServiceProvider), SelectedFont)
        If TypeOf value Is Font Then
            SelectedFont = CType(_fontConverter.ConvertFromString(_fontConverter.ConvertToString(value)), Font)
            SelectAll()
        End If

        ' hide the standard drop-down
        Win32.PostMessage(Handle, Win32.CB_SHOWDROPDOWN, IntPtr.Zero, IntPtr.Zero)
    End Sub

#End Region

#Region "** interfaces"

    Private Function IntGetService(ByVal serviceType As Type) As Object Implements IServiceProvider.GetService
        If GetType(IWindowsFormsEditorService).Equals(serviceType) Then
            Return CType(Me, IWindowsFormsEditorService)
        End If
        Return Nothing
    End Function

    Private Sub IntDropDownControl(ByVal ctrl As Control) Implements IWindowsFormsEditorService.DropDownControl
    End Sub

    Private Sub IntCloseDropDown() Implements IWindowsFormsEditorService.CloseDropDown
    End Sub

    Private Function IntShowDialog(ByVal dialog As Form) As DialogResult Implements IWindowsFormsEditorService.ShowDialog
        Return dialog.ShowDialog()
    End Function

#End Region

End Class
