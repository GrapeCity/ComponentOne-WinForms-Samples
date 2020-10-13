Imports C1.Win.C1BarCode
Imports C1.Win.C1Ribbon
Imports System.Reflection


Public Class QRCodeProperties

    Public Sub New(ByVal vis As VisualStyle)
        InitializeComponent()

        VisualStyle = vis

        btnOK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnForeColourDialog.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnShowBackColourDialog.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        txtSymbolSize.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        txtCodeVersion.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        cmbErrorCorrectionLevel.VisualStyle = C1.Win.C1List.VisualStyle.Custom
        Dim mi As MethodInfo = btnOK.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim ti As MethodInfo = txtSymbolSize.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim ci As MethodInfo = cmbErrorCorrectionLevel.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        mi.Invoke(btnOK, New Object() {})
        mi.Invoke(btnCancel, New Object() {})
        mi.Invoke(btnForeColourDialog, New Object() {})
        mi.Invoke(btnShowBackColourDialog, New Object() {})
        ti.Invoke(txtSymbolSize, New Object() {})
        ti.Invoke(txtCodeVersion, New Object() {})
        ci.Invoke(cmbErrorCorrectionLevel, New Object() {})
    End Sub

    Private Sub QRCodeProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vsName As Array = [Enum].GetNames(GetType(ErrorCorrectionLevel))
        With cmbErrorCorrectionLevel
            Dim x As String
            For Each x In vsName
                .AddItem(x)
            Next
        End With
    End Sub

    Private Sub btnForeColourDialog_Click(sender As Object, e As EventArgs) Handles btnForeColourDialog.Click
        Using dlg As New ColorDialog()
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                btnDisplayForeColour.BackColor = dlg.Color
                btnFore1.BackColor = dlg.Color
                btnFore2.BackColor = dlg.Color
                btnFore3.BackColor = dlg.Color
            End If
        End Using
    End Sub

    Private Sub btnShowBackColourDialog_Click(sender As Object, e As EventArgs) Handles btnShowBackColourDialog.Click
        Using dlg As New ColorDialog()
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                btnDisplayBackColour.BackColor = dlg.Color
                btnBack.BackColor = dlg.Color
            End If
        End Using
    End Sub

    Private Sub txtSymbolSize_ValueChanged(sender As Object, e As EventArgs) Handles txtSymbolSize.ValueChanged
        If txtSymbolSize.Value >= 10 Then
            txtSymbolSize.Value = 10
        ElseIf txtSymbolSize.Value <= 2 Then
            txtSymbolSize.Value = 2
        End If
    End Sub

    Private Sub txtCodeVersion_ValueChanged(sender As Object, e As EventArgs) Handles txtCodeVersion.ValueChanged
        If txtCodeVersion.Value >= MaxSupportedVersion Then
            txtCodeVersion.Value = MaxSupportedVersion
        ElseIf txtCodeVersion.Value <= 0 Then
            txtCodeVersion.Value = 0
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        My.Settings.QRForeColour = btnDisplayForeColour.BackColor
        My.Settings.QRBackColour = btnDisplayBackColour.BackColor
        My.Settings.QRSymbolSize = txtSymbolSize.Value
        My.Settings.QRCodeVersion = txtCodeVersion.Value
        If Trim(cmbErrorCorrectionLevel.Text) = "Set Error Level" Then

        Else
            My.Settings.QRErrorCorrectionLevel = CType([Enum].Parse(GetType(ErrorCorrectionLevel), cmbErrorCorrectionLevel.Text), ErrorCorrectionLevel)
        End If
    End Sub
End Class
