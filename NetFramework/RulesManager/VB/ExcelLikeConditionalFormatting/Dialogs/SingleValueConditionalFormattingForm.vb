Imports System.ComponentModel

Public Class SingleValueConditionalFormattingForm
    Private Sub SingleValueConditionalFormattingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Public ReadOnly Property Value As String
        Get
            Dim textValue = tbValue?.Text

            If textValue IsNot Nothing Then
                Return textValue
            End If

            Return String.Empty
        End Get
    End Property

End Class