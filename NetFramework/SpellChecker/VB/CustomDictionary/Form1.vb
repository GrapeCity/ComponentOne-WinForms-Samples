Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class Form1
    Dim _customDict As New MySpellDictionary

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _spell.CustomDictionary = _customDict
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            _spell.CustomDictionary = _customDict
        Else
            _spell.CustomDictionary = Nothing
        End If

    End Sub

    Partial Public Class MySpellDictionary
        Implements C1.Win.C1SpellChecker.ISpellDictionary

        Public Function Contains(ByVal word As String) As Boolean Implements C1.Win.C1SpellChecker.ISpellDictionary.Contains
            Return word.StartsWith("z", StringComparison.InvariantCultureIgnoreCase)
        End Function

    End Class



End Class
