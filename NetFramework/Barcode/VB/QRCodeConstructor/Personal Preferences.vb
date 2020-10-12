Imports C1.Win.C1Ribbon
Imports System.Reflection

Public Class Personal_Preferences

    Public Sub New(ByVal vs As VisualStyle)

        InitializeComponent()
        VisualStyle = vs
        chkUseOfficeTheme.BackColor = BackgroundColor
        chkShowToolTips.BackColor = BackgroundColor
        C1SuperTooltip1.Opacity = My.Settings.TootipOpacity
        C1SuperTooltip1.BackgroundGradient = Utils.GetSuperToolTipBackgroundGradient
        chkShowPrintOutput.BackColor = BackgroundColor
        ' there is currently an issue with c1 split container and c1 input not always receiving visual styles.
        btnOK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        txtOpacity.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        cmbIntDial.VisualStyle = C1.Win.C1List.VisualStyle.Custom
        cmbVisualStyle.VisualStyle = C1.Win.C1List.VisualStyle.Custom
        Dim ti As MethodInfo = txtOpacity.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim mi As MethodInfo = btnOK.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim ci As MethodInfo = cmbVisualStyle.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        ti.Invoke(txtOpacity, New Object() {})
        mi.Invoke(btnOK, New Object() {})
        mi.Invoke(btnCancel, New Object() {})
        ci.Invoke(cmbVisualStyle, New Object() {})
        ci.Invoke(cmbIntDial, New Object() {})
    End Sub

    Private Sub Personal_Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vsName As Array = [Enum].GetNames(GetType(VisualStyle))
        With cmbVisualStyle
            Dim x As String
            For Each x In vsName
                .AddItem(x)
            Next
        End With

        cmbIntDial.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        For Each s As String In dialcodes
            cmbIntDial.AddItem(s)
        Next
        cmbIntDial.Text = "Set Default Dialling Code"
        txtOpacity.Value = C1SuperTooltip1.Opacity * 100
    End Sub

    Private Sub chkUseOfficeTheme_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseOfficeTheme.CheckedChanged
        If chkUseOfficeTheme.Checked Then
            cmbVisualStyle.Enabled = False
        Else
            cmbVisualStyle.Enabled = True
        End If
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If chkUseOfficeTheme.Checked Then
            My.Settings.UseOfficeVisualStyle = True
        Else
            'I'm indebted to Andrey Dryazgov for the correct syntax to parse the enum
            If cmbVisualStyle.Text = "Select Visual Style to use" Then
            Else
                My.Settings.VisualStyleToUse = CType([Enum].Parse(GetType(VisualStyle), cmbVisualStyle.Text), VisualStyle)
            End If
        End If
        If chkShowToolTips.Checked Then
            My.Settings.ShowTooltips = True
        Else
            My.Settings.ShowTooltips = False
        End If
        My.Settings.TootipOpacity = txtOpacity.Value / 100

        If cmbIntDial.Text <> "Set Default Dialing Code" Then
            Dim str As String = Trim(cmbIntDial.Text)
            Dim strarray As String() = str.Split(",")
            My.Settings.DefaultIntDialCode = "+" & strarray(1)
        End If
        If chkShowPrintOutput.Checked Then
            My.Settings.ShowTextInPrintOutput = True
        Else
            My.Settings.ShowTextInPrintOutput = False
        End If
    End Sub


    Private Sub txtOpacity_ValueChanged(sender As Object, e As EventArgs) Handles txtOpacity.ValueChanged
        If txtOpacity.Value >= 100 Then
            txtOpacity.Value = 100
        ElseIf txtOpacity.Value <= 0 Then
            txtOpacity.Value = 0
        End If
        C1SuperTooltip1.Opacity = txtOpacity.Value / 100
    End Sub
End Class
