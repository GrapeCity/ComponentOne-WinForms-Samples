Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Partial Public Class FirstViewPage
    Inherits UserControl
    Public Sub New()
        InitializeComponent()

        'AddHandler product_link1.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.product_link1_LinkClicked)
        AddHandler Me.Load, New EventHandler(AddressOf Me.FirstViewPage_Load)

    End Sub

    Private Sub FirstViewPage_Load(sender As Object, e As EventArgs)
        ' ラベルの背景をPictureBoxコントロールに対して透過にする
        'mainvisual.Controls.Add(product1);
        mainvisual.Controls.Add(product2)
        mainvisual.Controls.Add(product3)
        'mainvisual.Controls.Add(product_body);
        'mainvisual.Controls.Add(product_link1);
        'mainvisual.Controls.Add(product_title);
    End Sub

    Private Sub product_link1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' ファーストビューから製品情報へのリンク
        'System.Diagnostics.Process.Start("");
    End Sub
End Class
