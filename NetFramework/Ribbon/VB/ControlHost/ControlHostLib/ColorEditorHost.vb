Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.Reflection
Imports C1.Win.C1Ribbon
Imports System.Xml
Imports System.Globalization

''' <summary>
''' The host component for the ColorEditorControl on a Ribbon.
''' </summary>
<DefaultEvent("SelectedColorChanged")> _
Public Class ColorEditorHost
    Inherits RibbonControlHost

    Public Const XmlNodeName As String = "colorEditorHost"

#Region "** ctor"

    Public Sub New()
        MyBase.New(New ColorEditorControl())
    End Sub

#End Region

#Region "** properties"

    ''' <summary>
    ''' <inheritdoc />
    ''' </summary>
    Public Overrides ReadOnly Property ControlHostNodeName As String
        Get
            Return XmlNodeName
        End Get
    End Property

    ''' <summary>
    ''' Gets the hosted color editor control.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property ColorEditor() As ColorEditorControl
        Get
            Return CType(Control, ColorEditorControl)
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the selected color.
    ''' </summary>
    <Category("Data")> _
    <Description("Gets or sets the selected color.")> _
    Public Property SelectedColor() As Color
        Get
            Return ColorEditor.SelectedColor
        End Get
        Set(ByVal value As Color)
            ColorEditor.SelectedColor = value
        End Set
    End Property
    Private Function ShouldSerializeSelectedColor() As Boolean
        Return SelectedColor <> Color.Empty
    End Function
    Private Sub ResetSelectedColor()
        SelectedColor = Color.Empty
    End Sub

#End Region

#Region "** events"

    ''' <summary>
    ''' Fires when the <see cref="SelectedColor"/> property is changed.
    ''' </summary>
    <Category("Property Changed")> _
    <Description("Fires when the value of the SelectedColor property changes.")> _
    Public Event SelectedColorChanged As EventHandler
    ''' <summary>
    ''' Raises the <see cref="SelectedColorChanged"/> event.
    ''' </summary>
    Protected Overridable Sub OnSelectedColorChanged(ByVal e As EventArgs)
        RaiseEvent SelectedColorChanged(Me, e)
    End Sub

#End Region

#Region "** methods"

    Protected Overrides Sub OnSubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnSubscribeControlEvents(ctrl)
        AddHandler CType(ctrl, ColorEditorControl).SelectedColorChanged, AddressOf HandleSelectedColorChanged
    End Sub

    Protected Overrides Sub OnUnsubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnUnsubscribeControlEvents(ctrl)
        RemoveHandler CType(ctrl, ColorEditorControl).SelectedColorChanged, AddressOf HandleSelectedColorChanged
    End Sub

    Private Sub HandleSelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnSelectedColorChanged(e)
    End Sub

    Protected Overrides Sub LoadControlHostProperties(ByVal node As XmlNode)
        MyBase.LoadControlHostProperties(node)
        Dim s As String = Read(node, "selectedColor", String.Empty)
        If s.Length > 0 Then
            Dim tc As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
            SelectedColor = CType(tc.ConvertFromString(Nothing, CultureInfo.InvariantCulture, s), Color)
        End If
    End Sub

    Protected Overrides Sub SaveControlHostProperties(ByVal writer As XmlWriter)
        MyBase.SaveControlHostProperties(writer)
        If ShouldSerializeSelectedColor() Then
            Dim tc As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
            Dim s As String = tc.ConvertToString(Nothing, CultureInfo.InvariantCulture, SelectedColor)
            writer.WriteAttributeString("selectedColor", s)
        End If
    End Sub

    Private Shared Function Read(ByVal node As XmlNode, ByVal attName As String, ByVal defVal As String) As String
        Dim att As XmlAttribute = node.Attributes(attName)
        If att IsNot Nothing Then
            Return att.Value
        End If

        Return defVal
    End Function

#End Region

End Class

''' <summary>
''' Uses the Color UITypeEditor to show a form where users can pick colors.
''' </summary>
Public Class ColorEditorControl
    Inherits ComboBox
    Implements IServiceProvider, IWindowsFormsEditorService

#Region "** fields"

    ' UITypeEditor responsible for editing the values
    Private _editor As ColorEditor

    ' form used to show the drop down
    Private _form As Form

    ' current editor value 
    Private _selectedColor As Color = Color.Empty

#End Region

#Region "** static members"

    Private Shared _colorConverter As TypeConverter

    ' cache the color converter in a static field
    Shared Sub New()
        _colorConverter = TypeDescriptor.GetConverter(GetType(Color))
    End Sub

#End Region

#Region "** ctor"

    Sub New()
        _editor = New ColorEditor()

        ' initialize combo
        DrawMode = DrawMode.OwnerDrawFixed
        DropDownHeight = 1

        ' initialize drop down editor
        _form = New Form()
        _form.StartPosition = FormStartPosition.Manual
        _form.FormBorderStyle = FormBorderStyle.None
        _form.ShowInTaskbar = False
        _form.TopLevel = True
        _form.KeyPreview = True
        AddHandler _form.Deactivate, AddressOf _form_Deactivate
        AddHandler _form.KeyDown, AddressOf _form_KeyDown
    End Sub

#End Region

#Region "** property"

    ''' <summary>
    ''' Gets or sets the color value.
    ''' </summary>
    Public Property SelectedColor() As Color
        Get
            Dim result As Color = Color.Empty
            Try
                result = CType(_colorConverter.ConvertFromString(Text), Color)
            Catch
            End Try
            Return result
        End Get
        Set(ByVal value As Color)
            Text = _colorConverter.ConvertToString(value)
            UpdateSelectedColor(value)
        End Set
    End Property

#End Region

#Region "** event"

    ''' <summary>
    ''' Fires when the <see cref="SelectedColor"/> property is changed.
    ''' </summary>
    Public Event SelectedColorChanged As EventHandler
    ''' <summary>
    ''' Raises the <see cref="SelectedColorChanged"/> event.
    ''' </summary>
    Protected Overridable Sub OnSelectedColorChanged(ByVal e As EventArgs)
        RaiseEvent SelectedColorChanged(Me, e)
    End Sub

#End Region

#Region "** private"

    ' close drop down when form deactivated
    Private Sub _form_Deactivate(ByVal sender As Object, ByVal e As EventArgs)
        CType(Me, IWindowsFormsEditorService).CloseDropDown()
    End Sub

    ' close drop down when the user presses the Esc button
    Private Sub _form_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyData = Keys.Escape Then
            CType(Me, IWindowsFormsEditorService).CloseDropDown()
            e.Handled = True
        End If
    End Sub

    ' raises the ColorChanged event if necessary
    Private Sub UpdateSelectedColor(ByVal newSelectedColor As Color)
        If _selectedColor <> newSelectedColor Then
            _selectedColor = newSelectedColor
            OnSelectedColorChanged(EventArgs.Empty)
        End If
    End Sub

#End Region

#Region "** overrides"

    Protected Overrides Sub OnValidating(ByVal e As CancelEventArgs)
        If Text.Length > 0 AndAlso SelectedColor = Color.Empty Then
            e.Cancel = True
        End If
        MyBase.OnValidating(e)
    End Sub

    Protected Overrides Sub OnValidated(ByVal e As EventArgs)
        MyBase.OnValidated(e)
        UpdateSelectedColor(SelectedColor)
    End Sub

    Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Return OrElse keyData = Keys.Escape Then
            If SelectedColor <> _selectedColor Then
                Return True
            End If
        End If
        Return MyBase.IsInputKey(keyData)
    End Function

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If (Not IsDisposed) AndAlso (e.KeyData = Keys.Return OrElse e.KeyData = Keys.Escape) Then
            Dim newSelectedColor As Color = SelectedColor
            If newSelectedColor <> _selectedColor Then
                If e.KeyData = Keys.Escape Then
                    SelectedColor = _selectedColor
                ElseIf newSelectedColor <> Color.Empty OrElse Text.Length = 0 Then
                    UpdateSelectedColor(newSelectedColor)
                End If
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
        Dim value As Object = _editor.EditValue(CType(Me, IServiceProvider), SelectedColor)
        If TypeOf value Is Color Then
            SelectedColor = CType(value, Color)
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
        ' size form
        _form.ClientSize = ctrl.Size

        ' calculate form location to avoid being off the screen
        Dim pt As Point = New Point()
        Dim rect As Rectangle = Parent.RectangleToScreen(Bounds)
        pt.Y = rect.Bottom
        If rect.Width > _form.Width Then
            pt.X = rect.Right - _form.Width
        Else
            pt.X = rect.Left
        End If
        Dim screenRc As Rectangle = Screen.GetWorkingArea(Me)
        If rect.Bottom + _form.Height > screenRc.Bottom Then
            pt.Y = rect.Top - _form.Height
        End If
        If pt.Y < 0 Then
            pt.Y = 0
        End If
        If rect.X + _form.Width > screenRc.Right Then
            pt.X = screenRc.Right - _form.Width
        End If
        If pt.X < 0 Then
            pt.X = 0
        End If

        ' position form
        _form.Location = pt

        ' add control to form and show it
        _form.Controls.Add(ctrl)
        _form.Show()

        ' wait until user makes a selection
        While ctrl.Visible
            Application.DoEvents()
            Win32.MsgWaitForMultipleObjects(1, IntPtr.Zero, 0, 5, 255)
        End While

        ' done
        _form.Controls.Clear()
    End Sub

    Private Sub IntCloseDropDown() Implements IWindowsFormsEditorService.CloseDropDown
        _form.Hide()
    End Sub

    Private Function IntShowDialog(ByVal dialog As Form) As DialogResult Implements IWindowsFormsEditorService.ShowDialog
        Return DialogResult.OK
    End Function

#End Region

End Class
