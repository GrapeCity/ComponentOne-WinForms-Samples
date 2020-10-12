Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Chart


Public Class Form1

	Public Sub New()
		InitializeComponent()
	End Sub	'New
   
   
	Private Sub evaluateCheckBoxes()
		Dim vesc As VisualEffectsStyleCollection = c1Chart1.VisualEffects.Styles
		checkDefaultEffects.Checked = vesc("Default").Enabled
		checkGroup0Effects.Checked = vesc("Group0").Enabled
		checkGroup1Effects.Checked = vesc("Group1").Enabled
	End Sub	'evaluateCheckBoxes
   
   
	Private Sub CheckBoxEffects_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles checkGroup1Effects.CheckedChanged, checkGroup0Effects.CheckedChanged, checkDefaultEffects.CheckedChanged
		Dim cb As CheckBox = sender
		Dim vesc As VisualEffectsStyleCollection = c1Chart1.VisualEffects.Styles
		If cb.Text.Contains("Default") Then
			vesc("Default").Enabled = cb.Checked
		ElseIf cb.Text.Contains("Group0") Then
			vesc("Group0").Enabled = cb.Checked
		ElseIf cb.Text.Contains("Group1") Then
			vesc("Group1").Enabled = cb.Checked
		End If
	End Sub	'CheckBoxEffects_Changed

    
	Private Sub btnVisualEffectsEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVisualEffectsEditor.Click
		c1Chart1.ShowVisualEffectsEditor()
		evaluateCheckBoxes()
	End Sub	'btnVisualEffectsEditor_Click
   
   
	Private Sub btnClearEffects_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearEffects.Click
		Dim vesc As VisualEffectsStyleCollection = c1Chart1.VisualEffects.Styles
		vesc("Default").Enabled = False
		vesc("Group0").Enabled = False
		vesc("Group1").Enabled = False
		evaluateCheckBoxes()
	End Sub	'btnClearEffects_Click

End Class 'Form1
