Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports C1.Win.C1Themes

Public Partial Class Form1
	Inherits Form
	Private Shared ReadOnly ApplicationThemeFont As New Font("Tahoma", 14)

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub SetApplicationTheme(themeName As String)
		lblApplicationTheme.Value = themeName
		C1ThemeController.ApplicationTheme = themeName
	End Sub

    Private Sub ctdbgThemes_Resize(sender As Object, e As EventArgs) Handles ctdbgThemes.Resize
        If ctdbgThemes.Splits.Count > 0 And ctdbgThemes.Splits(0).DisplayColumns.Count > 0 Then
            ctdbgThemes.Splits(0).DisplayColumns(0).Width = ctdbgThemes.ClientSize.Width - ctdbgThemes.Splits(0).RecordSelectorWidth - 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ctdbgThemes_Resize(Nothing, EventArgs.Empty)

        '
        ctdbgThemes.SetDataBinding()
        Dim themes As String() = C1ThemeController.GetThemes()
        For Each s As String In themes
            ctdbgThemes.AddRow(s)
        Next

        '
        lblApplicationTheme.Value = C1ThemeController.ApplicationTheme
    End Sub

    Private Sub ctdbgThemes_DoubleClick(sender As Object, e As EventArgs) Handles ctdbgThemes.DoubleClick
        If ctdbgThemes.Row >= 0 AndAlso ctdbgThemes.Row < ctdbgThemes.Rows.Count Then
            Dim dr As DataRowView = ctdbgThemes.GetDataBoundItem(ctdbgThemes.Row)
            If dr IsNot Nothing Then
                SetApplicationTheme(DirectCast(dr.Row.ItemArray(0), String))
            End If
        End If
    End Sub

    Private Sub c1ThemeController1_ObjectThemeApplied(sender As C1.Win.C1Themes.C1ThemeController, e As C1.Win.C1Themes.ObjectThemeEventArgs) Handles c1ThemeController1.ObjectThemeApplied
        If e.[Object] Is lblApplicationTheme Then
            lblApplicationTheme.Font = ApplicationThemeFont
        End If

        If e.[Object] Is ctdbgThemes Then
            ctdbgThemes.EvenRowStyle.BackColor = Color.Red
            ctdbgThemes.EvenRowStyle.BackColor2 = Color.White
            ctdbgThemes.EvenRowStyle.GradientMode = C1.Win.C1TrueDBGrid.GradientModeEnum.ForwardDiagonal
        End If
    End Sub
End Class
