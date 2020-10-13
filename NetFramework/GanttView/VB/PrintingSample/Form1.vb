Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Windows.Forms
Imports C1.C1Preview
Imports C1.C1Report
Imports C1.Framework
Imports C1.Win.C1GanttView
Imports C1.Win.C1GanttView.Printing
Imports C1.Win.C1Preview

Public Partial Class Form1
	Inherits Form
	Public Sub New()
        InitializeComponent()
        ganttView.PrintInfo.CurrentPageSettings.Landscape = False
	End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ganttView.PrintInfo.Print("CustomStyle.c1d")
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        ganttView.PrintInfo.Preview("CustomStyle.c1d")
    End Sub

End Class
