Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Editor

Imports Resources = UserCSS.Resources

Namespace Controls
	''' <summary>
	''' Allows a user either to select an existing CSS file or enter CSS style rules into the textbox
	''' </summary>
	Public Partial Class CSSChooser
		Inherits UserControl
		#Region "public enums"

		''' <summary>
		''' Editor mode that CSS will be applied to: design or preview
		''' </summary>
		Public Enum Mode
			Design
			Preview
		End Enum

		#End Region

		#Region "declarations"

		Private _mode As Mode
        Private _editor As C1Editor
        Private _css As String

#End Region

#Region "ctors"

        Public Sub New()
            InitializeComponent()
            InitCSS()
        End Sub

#End Region

#Region "object model"

        ''' <summary>
        ''' Gets or sets editor mode that CSS will be applied to
        ''' </summary>
        <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
        Public Property CSSMode() As Mode
            Get
                Return _mode
            End Get
            Set(ByVal value As Mode)
                _mode = Value
                InitCSS()
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets active editor
        ''' </summary>
        <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
        Public Property Editor() As C1Editor
            Get
                Return _editor
            End Get
            Set(ByVal value As C1Editor)
                _editor = Value
            End Set
        End Property

#End Region

		#Region "implementation"

		''' <summary>
		''' Initializes controls for work with CSS
		''' </summary>
        Private Sub InitCSS()
            If _mode = Mode.Design Then
                tbCustomDesignCSS.Text = Resources.sDesignCSS
            Else
                tbCustomDesignCSS.Text = Resources.sPreviewCSS
            End If
            _css = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
            If _mode = Mode.Design Then
                _css = _css & "\CSS1.css"
            Else
                _css = _css & "\CSS2.css"
            End If
            lblFileName.Text = _css
        End Sub

		''' <summary>
		''' Loads Design or Preview CSS from the file
		''' </summary>
		''' <param name="value"></param>
		Private Sub LoadCSS(value As String)
			Select Case _mode
				Case Mode.Design
					_editor.LoadDesignCSS(value)
					Exit Select
				Case Mode.Preview
					_editor.LoadPreviewCSS(value)
					Exit Select
			End Select
		End Sub

		''' <summary>
		''' Loads Design or Preview CSS from the string
		''' </summary>
		''' <param name="value"></param>
		Private Sub LoadCSSValue(value As String)
			'Only UTF-8 string can be used for the Stream
			Dim stream As Stream = New MemoryStream(Encoding.UTF8.GetBytes(value))
			Select Case _mode
				Case Mode.Design
					_editor.LoadDesignCSS(stream)
					Exit Select
				Case Mode.Preview
					_editor.LoadPreviewCSS(stream)
					Exit Select
			End Select
		End Sub

		#End Region

		#Region "event handlers"

		''' <summary>
		''' Removes using CSS from the editor
		''' </summary>
		Private Sub rbNoDesignCSS_CheckedChanged(sender As Object, e As EventArgs)
			If TryCast(sender, RadioButton).Checked Then
				LoadCSS(Nothing)
			End If
		End Sub

		''' <summary>
		''' Loads a CSS from the previously saved file name
		''' </summary>
		Private Sub rbFileDesignCSS_CheckedChanged(sender As Object, e As EventArgs)
			btnBrowse.Enabled = TryCast(sender, RadioButton).Checked
			If TryCast(sender, RadioButton).Checked Then
				LoadCSS(_css)
			End If
		End Sub

		''' <summary>
		''' Displays the Open File dialog to select a CSS file. 
		''' Selected CSS is loaded into the editor as Design/Preview CSS.
		''' </summary>
		Private Sub btnBrowse_Click(sender As Object, e As EventArgs)
			Using dialog As New OpenFileDialog()
				dialog.Filter = "CSS Files (*.css)|*.css"
				dialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
				If dialog.ShowDialog() = DialogResult.OK Then
					_css = dialog.FileName
					lblFileName.Text = _css
					LoadCSS(_css)
				End If
			End Using
		End Sub

		''' <summary>
		''' Loads text from the Textbox into the editor as Design/Preview CSS
		''' </summary>
		Private Sub rbCustomDesignCSS_CheckedChanged(sender As Object, e As EventArgs)
			tbCustomDesignCSS.Enabled = TryCast(sender, RadioButton).Checked
			btnApplyCSS.Enabled = TryCast(sender, RadioButton).Checked
			If TryCast(sender, RadioButton).Checked Then
				LoadCSSValue(tbCustomDesignCSS.Text)
			End If
		End Sub

		''' <summary>
		''' Loads text from the Textbox into the editor as Design/Preview CSS
		''' </summary>
		Private Sub btnApplyCSS_Click(sender As Object, e As EventArgs)
			LoadCSSValue(tbCustomDesignCSS.Text)
		End Sub

		#End Region
	End Class
End Namespace
