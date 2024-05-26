Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports C1.Win.C1Themes

Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()
        ApplyDefaultTheme()
    End Sub

    Private Sub ApplyDefaultTheme()
        SetApplicationTheme("Office365White")
    End Sub

    ''' <summary>
    ''' Sets the specified theme as the application theme - i.e. the theme used by default
    ''' by all C1ThemeControllers in the application.
    ''' </summary>
    ''' <param name="themeName">The name of the theme.</param>
    Private Sub SetApplicationTheme(themeName As String)
        tbApplicationTheme.Value = themeName
        C1ThemeController.ApplicationTheme = themeName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Create another form to show that changing ApplicationTheme automatically
        ' propagages to all form in an application on which there is a C1ThemeController:
        Dim f2 = New Form2()
        f2.SetDesktopLocation(Me.DesktopBounds.Right + 10, Me.DesktopBounds.Top)
        f2.Show()
        '
        ctdbgThemes_Resize(Nothing, EventArgs.Empty)

        ' Get the list of available themes and populate the grid with them:
        ctdbgThemes.SetDataBinding()
        Dim themes As String() = C1ThemeController.GetThemes()
        For Each s As String In themes
            ctdbgThemes.AddRow(s)
        Next
        '
        tbApplicationTheme.Value = C1ThemeController.ApplicationTheme
    End Sub

    Private Sub ctdbgThemes_Resize(sender As Object, e As EventArgs) Handles ctdbgThemes.Resize
        If ctdbgThemes.Splits.Count > 0 And ctdbgThemes.Splits(0).DisplayColumns.Count > 0 Then
            ctdbgThemes.Splits(0).DisplayColumns(0).Width = ctdbgThemes.ClientSize.Width - ctdbgThemes.Splits(0).RecordSelectorWidth - 1
        End If
    End Sub

    Private Sub ctdbgThemes_DoubleClick(sender As Object, e As EventArgs) Handles ctdbgThemes.DoubleClick
        If ctdbgThemes.Row >= 0 AndAlso ctdbgThemes.Row < ctdbgThemes.Rows.Count Then
            SetApplicationTheme(DirectCast(ctdbgThemes.Rows(ctdbgThemes.Row)(0), String))
        End If
    End Sub

    Private Sub btnSetAsApplicationTheme_Click(sender As Object, e As EventArgs) Handles btnSetAsApplicationTheme.Click
        If ctdbgThemes.Row >= 0 AndAlso ctdbgThemes.Row < ctdbgThemes.Rows.Count Then
            SetApplicationTheme(DirectCast(ctdbgThemes.Rows(ctdbgThemes.Row)(0), String))
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim theme As String = C1ThemeController.RegisterTheme(openFileDialog1.FileName)
                ctdbgThemes.AddRow(theme)
            Catch ex As Exception
                MessageBox.Show(String.Format("Cannot add theme, error:" & Environment.NewLine & "{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If ctdbgThemes.Row >= 0 AndAlso ctdbgThemes.Row < ctdbgThemes.Rows.Count Then
            Dim theme As String = DirectCast(ctdbgThemes.Rows(ctdbgThemes.Row)(0), String)
            Try
                C1ThemeController.UnregisterTheme(theme)
                ctdbgThemes.Rows.RemoveAt(ctdbgThemes.Row)
            Catch ex As Exception
                MessageBox.Show(String.Format("Cannot remove theme, error:" & Environment.NewLine & "{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End If
    End Sub
End Class
