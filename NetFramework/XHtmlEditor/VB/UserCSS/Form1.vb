Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Resources = UserCSS.Resources

Public Partial Class Form1
	Inherits Form
	#Region "ctor"

	Public Sub New()
		InitializeComponent()
		InitEditor()
	End Sub

	#End Region

	#Region "implementation"

	''' <summary>
	''' Loads content into the editor from the resources
	''' </summary>
	Private Sub InitEditor()
		editor.LoadXml(Resources.sEditorText, Nothing)
	End Sub

	#End Region

	#Region "event handlers"

	''' <summary>
	''' Switches editor to the Design or Preview mode accordingly to the current tab page
	''' </summary>
	Private Sub tabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
		If TryCast(sender, TabControl).SelectedIndex = 0 Then
            editor.Mode = C1.Win.C1Editor.EditorMode.Design
        Else
            editor.Mode = C1.Win.C1Editor.EditorMode.Preview
		End If
	End Sub

	#End Region
End Class
