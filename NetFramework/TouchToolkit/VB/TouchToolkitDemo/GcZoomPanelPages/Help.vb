Imports C1.Win.TouchToolKit
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPanelPages
    Partial Public Class Help
        Inherits Form
        Public Sub New()
            InitializeComponent()
            AddHandler button1.Click, AddressOf button1_Click
            AddHandler gcZoomPanel1.ZoomFactorChanged, AddressOf gcZoomPanel1_ZoomFactorChanged
        End Sub

        Public ReadOnly Property C1ZoomPanel() As C1ZoomPanel
            Get
                Return gcZoomPanel1
            End Get
        End Property

        Protected Overrides Sub OnLoad(e As EventArgs)
            toolStripStatusLabel1.Text = " ZoomFactor:" + (gcZoomPanel1.ZoomFactor * 100).ToString() + "%"

            MyBase.OnLoad(e)
        End Sub

        Private id As Integer = 1
        Private Sub gcZoomPanel1_ZoomFactorChanged(sender As Object, e As EventArgs)
            listBox1.Items.Add(id.ToString() + " ZoomFactor:" + (gcZoomPanel1.ZoomFactor * 100).ToString() + "%")
            toolStripStatusLabel1.Text = " ZoomFactor:" + (gcZoomPanel1.ZoomFactor * 100).ToString() + "%"
            id += 1
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs)
            id = 0
            listBox1.Items.Clear()
        End Sub

        Protected Overrides Sub OnClosing(e As CancelEventArgs)
            MyBase.OnClosing(e)
        End Sub
    End Class
End Namespace
