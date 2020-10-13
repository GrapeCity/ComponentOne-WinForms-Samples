Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Editor
Imports C1.Win.C1Editor.UICustomization

''' <summary>
''' Represents a form for basic text formatting.
''' </summary>
Friend Partial Class FormattingForm
	Inherits Form
	Implements IFormattingDialog
	#Region "ctors"

	Public Sub New()
		InitializeComponent()
		'_cbFontFamily combobox must be initialized by fonts from the current system
		For Each fontFamily__1 As FontFamily In FontFamily.Families
			_cbFontFamily.Items.Add(fontFamily__1.Name)
        Next
        AddHandler _rbNone.CheckedChanged, New EventHandler(AddressOf _rbNone_CheckedChanged)
    End Sub

	#End Region

	#Region "declarations"

	Private _support As FormattingSupport

	#End Region

	#Region "private methods"

	''' <summary>
	''' Translates a CSS color representation to a GDI+ <see cref="T:System.Drawing.Color"></see> structure.
	''' </summary>
	''' <param name="cssColor">The string with the CSS color representation.</param>
	''' <returns>The <see cref="T:System.Drawing.Color"></see> structure that represents the translated HTML color.</returns>
	Private Function ToColor(cssColor As String) As Color
		Dim color__1 As Color = Color.Empty

		If Not String.IsNullOrEmpty(cssColor) Then
			color__1 = ColorTranslator.FromHtml(cssColor)
		End If

		Return color__1
	End Function

	''' <summary>
	''' Converts a GDI+ <see cref="Color"/> structure to a CSS hex-formatted string.
	''' </summary>
	''' <param name="color">The Color structure to be converted.</param>
	''' <returns>The CSS hex-formatted color.</returns>
	Private Function ToCSSString(color As System.Nullable(Of Color)) As String
        If color.HasValue Then
            Return ToCSSString(color.Value)
        Else
            Return String.Empty
        End If
    End Function

	''' <summary>
	''' Converts a GDI+ <see cref="Color"/> structure to a CSS hex-formatted string.
	''' </summary>
	''' <param name="color">The Color structure to be converted.</param>
	''' <returns>The CSS hex-formatted color.</returns>
	Private Function ToCSSString(color As Color) As String
		If color.IsEmpty Then
			Return ""
		End If
		Dim cssString As String
		Dim R As String = GetByteInToHexNumber(color.R)
		Dim G As String = GetByteInToHexNumber(color.G)
		Dim B As String = GetByteInToHexNumber(color.B)
		cssString = String.Format("#{0}{1}{2}", R, G, B)
		Return cssString
	End Function

	Private Function GetByteInToHexNumber(b As Byte) As String
		Dim R As String = Convert.ToString(b, 16)
		If R.Length = 1 Then
			R = "0" & R
		End If
		Return R
	End Function

	#End Region

	#Region "#event handlers"

	Private Sub _tbTextColor_Validated(sender As Object, e As EventArgs)
		_support.ForeColor = ToColor(TryCast(sender, TextBox).Text)
	End Sub

    Private Sub _rbNone_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _support Is Nothing Then
            Exit Sub
        End If
        If _rbNone.Checked Then
            _support.Underline = False
            _support.Overline = False
            _support.Strikeout = False
        End If
    End Sub

#End Region

#Region "IFormattingDialog Members"

    ''' <summary>
    ''' Binds data from the item to GUI controls on the form.
    ''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
    ''' to read data from the item and write it back.
    ''' </summary>
    ''' <param name="item">The item to be bound to the GUI controls.</param>
    Private Sub IFormattingDialog_BindData(support As FormattingSupport) Implements IFormattingDialog.BindData
        _support = Nothing
        _rbNone.Checked = True
        _support = support
        'data biniding is used to link each control with corresponding data member
        _cbBold.DataBindings.Add("Checked", _support, "Bold")
        _cbItalic.DataBindings.Add("Checked", _support, "Italic")
        _cbInvisible.DataBindings.Add("Checked", _support, "Hidden")
        _rbUnderline.DataBindings.Add("Checked", _support, "Underline")
        _rbOverline.DataBindings.Add("Checked", _support, "Overline")
        _rbStrikeout.DataBindings.Add("Checked", _support, "Strikeout")
        _cbFontFamily.DataBindings.Add("Text", _support, "FontName")
        _tbSize.DataBindings.Add("Text", _support, "FontSize")
        _tbTextColor.Text = ToCSSString(_support.ForeColor)
    End Sub

    ''' <summary>
    ''' Shows the form with the specified owner to the user.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
    ''' the top-level window that will own this form.</param>
    ''' <returns>True if the form was displayed successfully and the item was changed.</returns>
    Private Function IFormattingDialog_Show(owner As IWin32Window) As Boolean Implements IFormattingDialog.Show
        'returns true if the dialog was executed and OK button was pressed
        Return ShowDialog(owner) = DialogResult.OK
    End Function

#End Region

End Class
