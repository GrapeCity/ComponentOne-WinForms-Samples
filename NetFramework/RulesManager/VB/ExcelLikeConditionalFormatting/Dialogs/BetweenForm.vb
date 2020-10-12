Imports System.ComponentModel

Public Class BetweenForm
    Private Sub BetweenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStylePreset.SelectedIndex = 0
    End Sub

    <Browsable(False)>
    Public ReadOnly Property SelectedStylePreset As Highlight
        Get
            Dim selectedStylePresetText = cmbStylePreset.Text
            Dim stylePresets = [Enum].GetValues(GetType(Highlight)).Cast(Of Highlight)().ToList()
            Return stylePresets.First(Function(stylePreset) stylePreset.ToString().ToLower() = selectedStylePresetText.ToLower().Replace(" ", ""))
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property MinimumValue As String
        Get
            Dim textMinimumValue = tbMinimumValue?.Text

            If textMinimumValue IsNot Nothing Then
                Return textMinimumValue
            End If

            Return String.Empty
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property MaximumValue As String
        Get
            Dim textMaximumValue = tbMaximumValue?.Text

            If textMaximumValue IsNot Nothing Then
                Return textMaximumValue
            End If

            Return String.Empty
        End Get
    End Property
End Class