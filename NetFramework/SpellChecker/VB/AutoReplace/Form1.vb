Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class Form1
    Dim _dt As DataTable

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _dt = New DataTable("Corrections")
        _dt.Columns.Add("key", GetType(String))
        _dt.Columns.Add("text", GetType(String))
        _dt.Rows.Add("(c)", "©")
        _dt.Rows.Add("(r)", "®")
        _dt.Rows.Add("(tm)", "™")
        _dt.Rows.Add("1/2", "½")
        _dt.Rows.Add("1/4", "¼")
        _dt.Rows.Add("teh", "the")
        _dt.Rows.Add("abouta", "about a")
        _dt.Rows.Add("becuase", "because")
        _dt.Rows.Add("cant", "can't")
        _dt.Rows.Add("decison", "decision")
        _dt.Rows.Add("efort", "effort")
        _dt.Rows.Add("feild", "field")
        DataGridView1.DataSource = _dt

        UpdateAutoReplaceList()
        AddHandler _dt.DefaultView.ListChanged, AddressOf DefaultView_ListChanged
    End Sub

    Public Sub DefaultView_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
        UpdateAutoReplaceList()
    End Sub

    Private Sub UpdateAutoReplaceList()
        C1SpellChecker1.AutoReplaceList.Clear()
        For Each dr As DataRow In _dt.Rows
            C1SpellChecker1.AutoReplaceList(dr("key").ToString()) = dr("text").ToString()
        Next
    End Sub

    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.F7 Then
            C1SpellChecker1.CheckControl(RichTextBox1)
        End If
    End Sub

End Class
