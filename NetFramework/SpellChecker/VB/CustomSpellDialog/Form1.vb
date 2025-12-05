Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.SpellChecker

Partial Public Class Form1
    Inherits Form
    Private _checkRichTextBox As Boolean = False

    ' ** initialize 
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        RichTextBox1.Text = TextBox1.Text
    End Sub

    ' ** keep track of last editor with focus 
    Private Sub textBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.Enter
        _checkRichTextBox = False
    End Sub
    Private Sub richTextBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox1.Enter
        _checkRichTextBox = True
    End Sub

    ' ** spell check editors 
    Private Sub btnSpellCheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Using dlg As New SpellDialog()
            AddHandler dlg.Load, AddressOf dlg_Load
            AddHandler dlg.FormClosed, AddressOf dlg_FormClosed

            If _checkRichTextBox Then
                c1SpellChecker1.CheckControl(textBox1, False, dlg)
            Else
                c1SpellChecker1.CheckControl(textBox1, False, dlg)
            End If
        End Using
    End Sub
    Private Sub btnSpellCheckCustom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Using dlg As New SpellDialogWord()
            AddHandler dlg.Load, AddressOf dlg_Load
            AddHandler dlg.FormClosed, AddressOf dlg_FormClosed

            If _checkRichTextBox Then
                C1SpellChecker1.CheckControl(TextBox1, False, dlg)
            Else
                C1SpellChecker1.CheckControl(TextBox1, False, dlg)
            End If
        End Using
    End Sub

    ' ** dialog event handlers 
    Private Sub dlg_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim dlg As SpellDialog = TryCast(sender, SpellDialog)
        If dlg IsNot Nothing Then
            status.Text = String.Format("Checking spelling... {0}", dlg.ErrorCount)
        Else
            Dim dlgw As SpellDialogWord = TryCast(sender, SpellDialogWord)
            status.Text = String.Format("Checking spelling... {0}", dlgw.ErrorCount)
        End If
        Console.WriteLine(Me.status.Text)
    End Sub
    Private Sub dlg_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Dim dlg As SpellDialog = TryCast(sender, SpellDialog)
        If dlg IsNot Nothing Then
            status.Text = String.Format("Spell-check done, {0} errors handled; result {1}.", dlg.ErrorCount, dlg.DialogResult)
        Else
            Dim dlgw As SpellDialogWord = TryCast(sender, SpellDialogWord)
            status.Text = String.Format("Spell-check done, {0} errors handled; result {1}.", dlgw.ErrorCount, dlgw.DialogResult)
        End If
        Console.WriteLine(Me.status.Text)
    End Sub

    Private Sub c1SpellChecker1_BadWordFound(ByVal sender As Object, ByVal e As BadWordEventArgs)
        Console.WriteLine("Bad word found {0}, {1} of {2}", e.BadWord.Text, e.BadWordList.IndexOf(e.BadWord) + 1, e.BadWordList.Count)
        If e.Dialog IsNot Nothing Then
            ' show some feedback on the status line 
            Dim index As Integer = e.BadWordList.IndexOf(e.BadWord) + 1
            status.Text = String.Format("Error {0} of {1}: '{2}'", index, e.BadWordList.Count, e.BadWord.Text)
            ' prevent control from underlining words that start with a capital 
            'if (char.IsUpper(e.BadWord.Text[0])) 
            '{ 
            ' e.Cancel = true; 
            '} 
        Else
        End If
    End Sub

End Class
