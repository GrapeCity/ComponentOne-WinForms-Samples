<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim C1CustomButton1 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1CustomButton2 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1RadioButton1 As C1.Win.C1Win7Pack.C1RadioButton = New C1.Win.C1Win7Pack.C1RadioButton
        Dim C1CustomButton3 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1CustomButton4 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1CustomButton5 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1CustomButton6 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1CustomButton7 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1CustomButton8 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1RadioButton2 As C1.Win.C1Win7Pack.C1RadioButton = New C1.Win.C1Win7Pack.C1RadioButton
        Dim C1RadioButton3 As C1.Win.C1Win7Pack.C1RadioButton = New C1.Win.C1Win7Pack.C1RadioButton
        Dim C1RadioButton4 As C1.Win.C1Win7Pack.C1RadioButton = New C1.Win.C1Win7Pack.C1RadioButton
        Dim C1RadioButton5 As C1.Win.C1Win7Pack.C1RadioButton = New C1.Win.C1Win7Pack.C1RadioButton
        Dim C1RadioButton6 As C1.Win.C1Win7Pack.C1RadioButton = New C1.Win.C1Win7Pack.C1RadioButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dialogEnableDisable = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.dialogCommonButtons = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.dialogElevation = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.dialogCustomButtons = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.dialogError = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.dialogProgress2 = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.dialogIcons = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.btnClose = New System.Windows.Forms.Button
        Me.dialogProgress1 = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.linkTimer = New System.Windows.Forms.LinkLabel
        Me.linkProgress2 = New System.Windows.Forms.LinkLabel
        Me.linkProgress1 = New System.Windows.Forms.LinkLabel
        Me.linkEnableDisable = New System.Windows.Forms.LinkLabel
        Me.linkCustomButtons = New System.Windows.Forms.LinkLabel
        Me.linkCommonButtons = New System.Windows.Forms.LinkLabel
        Me.linkError = New System.Windows.Forms.LinkLabel
        Me.dialogTimer = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.linkIcons = New System.Windows.Forms.LinkLabel
        Me.linkElevation = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'dialogEnableDisable
        '
        C1CustomButton1.ID = 9
        C1CustomButton1.Name = "enableButton"
        C1CustomButton1.Text = "Enable"
        C1CustomButton2.Enabled = False
        C1CustomButton2.ID = 10
        C1CustomButton2.Name = "disableButton"
        C1CustomButton2.Text = "Disable"
        Me.dialogEnableDisable.CustomButtons.AddRange(New C1.Win.C1Win7Pack.C1CustomButton() {C1CustomButton1, C1CustomButton2})
        Me.dialogEnableDisable.MainInstruction = "Click on the buttons below to enable or disable the radio button."
        Me.dialogEnableDisable.NextID = 12
        C1RadioButton1.Enabled = False
        C1RadioButton1.ID = 11
        C1RadioButton1.Name = "Radio1"
        C1RadioButton1.Text = "Sample Radio button"
        Me.dialogEnableDisable.RadioButtons.AddRange(New C1.Win.C1Win7Pack.C1RadioButton() {C1RadioButton1})
        Me.dialogEnableDisable.UseCommandLinks = False
        Me.dialogEnableDisable.WindowTitle = "Enable/Disable Sample"
        '
        'dialogCommonButtons
        '
        Me.dialogCommonButtons.CommonButtons = CType((((((C1.Win.C1Win7Pack.TaskDialogCommonButtons.Ok Or C1.Win.C1Win7Pack.TaskDialogCommonButtons.Yes) _
                    Or C1.Win.C1Win7Pack.TaskDialogCommonButtons.No) _
                    Or C1.Win.C1Win7Pack.TaskDialogCommonButtons.Cancel) _
                    Or C1.Win.C1Win7Pack.TaskDialogCommonButtons.Retry) _
                    Or C1.Win.C1Win7Pack.TaskDialogCommonButtons.Close), C1.Win.C1Win7Pack.TaskDialogCommonButtons)
        Me.dialogCommonButtons.MainInstruction = "Click on any of the buttons below to get a specific message box."
        Me.dialogCommonButtons.WindowTitle = "Common Buttons Sample"
        '
        'dialogElevation
        '
        Me.dialogElevation.Content = "Click the Admin Stuff button to close the dialog box."
        C1CustomButton3.ID = 9
        C1CustomButton3.Name = "adminTaskButton"
        C1CustomButton3.Note = "Run some admin tasks"
        C1CustomButton3.ShowElevationIcon = True
        C1CustomButton3.Text = "Admin stuff"
        Me.dialogElevation.CustomButtons.AddRange(New C1.Win.C1Win7Pack.C1CustomButton() {C1CustomButton3})
        Me.dialogElevation.NextID = 10
        Me.dialogElevation.WindowTitle = "Elevated task example"
        '
        'dialogCustomButtons
        '
        C1CustomButton4.ID = 9
        C1CustomButton4.Name = "Button1"
        C1CustomButton4.Text = "Custom Button 1"
        C1CustomButton5.ID = 10
        C1CustomButton5.Name = "Button2"
        C1CustomButton5.Text = "Custom Button 2"
        C1CustomButton6.ID = 11
        C1CustomButton6.Name = "Button3"
        C1CustomButton6.Text = "Custom Close Button"
        Me.dialogCustomButtons.CustomButtons.AddRange(New C1.Win.C1Win7Pack.C1CustomButton() {C1CustomButton4, C1CustomButton5, C1CustomButton6})
        Me.dialogCustomButtons.MainInstruction = "Click on any of the following buttons to display a specific message box."
        Me.dialogCustomButtons.NextID = 12
        Me.dialogCustomButtons.WindowTitle = "Custom Buttons Sample"
        '
        'dialogError
        '
        Me.dialogError.CheckBoxText = "Don't ask me again"
        Me.dialogError.CheckedByDefault = True
        Me.dialogError.CollapsedControlText = "Show details"
        Me.dialogError.Content = "Error message goes here..."
        C1CustomButton7.ID = 9
        C1CustomButton7.Name = "sendButton"
        C1CustomButton7.Note = "I'm in a giving mood."
        C1CustomButton7.Text = "Send Feedback"
        C1CustomButton8.ID = 10
        C1CustomButton8.Name = "dontSendButton"
        C1CustomButton8.Note = "I don't feel like being helpful."
        C1CustomButton8.Text = "No Thanks"
        Me.dialogError.CustomButtons.AddRange(New C1.Win.C1Win7Pack.C1CustomButton() {C1CustomButton7, C1CustomButton8})
        Me.dialogError.ExpandedControlText = "Hide details"
        Me.dialogError.ExpandedInformation = "Stack trace goes here..."
        Me.dialogError.ExpandFooterArea = True
        Me.dialogError.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.[Error]
        Me.dialogError.MainInstruction = "An unexpected error occurred. Please send feedback now!"
        Me.dialogError.NextID = 11
        Me.dialogError.WindowTitle = "Error Sample"
        '
        'dialogProgress2
        '
        Me.dialogProgress2.MainInstruction = "A marquee-style progress indicator:"
        Me.dialogProgress2.ProgressBar.State = C1.Win.C1Win7Pack.TaskDialogProgressBarState.Indeterminate
        Me.dialogProgress2.ProgressBar.Visible = True
        Me.dialogProgress2.WindowTitle = "Progress Effects Sample"
        '
        'dialogIcons
        '
        Me.dialogIcons.FooterText = "Footer Text"
        Me.dialogIcons.MainInstruction = "Select one of the following radio buttons to change the main and footer icons."
        Me.dialogIcons.NextID = 14
        C1RadioButton2.ID = 9
        C1RadioButton2.Name = "radioNone"
        C1RadioButton2.Text = "None"
        C1RadioButton3.ID = 10
        C1RadioButton3.Name = "radioError"
        C1RadioButton3.Text = "Error"
        C1RadioButton4.ID = 11
        C1RadioButton4.Name = "radioWarning"
        C1RadioButton4.Text = "Warning"
        C1RadioButton5.ID = 12
        C1RadioButton5.Name = "radioInformation"
        C1RadioButton5.Text = "Information"
        C1RadioButton6.ID = 13
        C1RadioButton6.Name = "radioShield"
        C1RadioButton6.Text = "Shield"
        Me.dialogIcons.RadioButtons.AddRange(New C1.Win.C1Win7Pack.C1RadioButton() {C1RadioButton2, C1RadioButton3, C1RadioButton4, C1RadioButton5, C1RadioButton6})
        Me.dialogIcons.WindowTitle = "Icons Sample"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(195, 225)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dialogProgress1
        '
        Me.dialogProgress1.EnableTimer = True
        Me.dialogProgress1.ProgressBar.Maximum = 5000
        Me.dialogProgress1.ProgressBar.Visible = True
        Me.dialogProgress1.WindowTitle = "Progress Sample"
        '
        'linkTimer
        '
        Me.linkTimer.AutoSize = True
        Me.linkTimer.Location = New System.Drawing.Point(20, 218)
        Me.linkTimer.Name = "linkTimer"
        Me.linkTimer.Size = New System.Drawing.Size(74, 13)
        Me.linkTimer.TabIndex = 18
        Me.linkTimer.TabStop = True
        Me.linkTimer.Text = "Timer Sample"
        '
        'linkProgress2
        '
        Me.linkProgress2.AutoSize = True
        Me.linkProgress2.Location = New System.Drawing.Point(20, 193)
        Me.linkProgress2.Name = "linkProgress2"
        Me.linkProgress2.Size = New System.Drawing.Size(128, 13)
        Me.linkProgress2.TabIndex = 17
        Me.linkProgress2.TabStop = True
        Me.linkProgress2.Text = "Progress Effects Sample"
        '
        'linkProgress1
        '
        Me.linkProgress1.AutoSize = True
        Me.linkProgress1.Location = New System.Drawing.Point(20, 168)
        Me.linkProgress1.Name = "linkProgress1"
        Me.linkProgress1.Size = New System.Drawing.Size(91, 13)
        Me.linkProgress1.TabIndex = 16
        Me.linkProgress1.TabStop = True
        Me.linkProgress1.Text = "Progress Sample"
        '
        'linkEnableDisable
        '
        Me.linkEnableDisable.AutoSize = True
        Me.linkEnableDisable.Location = New System.Drawing.Point(20, 68)
        Me.linkEnableDisable.Name = "linkEnableDisable"
        Me.linkEnableDisable.Size = New System.Drawing.Size(124, 13)
        Me.linkEnableDisable.TabIndex = 12
        Me.linkEnableDisable.TabStop = True
        Me.linkEnableDisable.Text = "Enable/Disable Sample"
        '
        'linkCustomButtons
        '
        Me.linkCustomButtons.AutoSize = True
        Me.linkCustomButtons.Location = New System.Drawing.Point(20, 43)
        Me.linkCustomButtons.Name = "linkCustomButtons"
        Me.linkCustomButtons.Size = New System.Drawing.Size(130, 13)
        Me.linkCustomButtons.TabIndex = 11
        Me.linkCustomButtons.TabStop = True
        Me.linkCustomButtons.Text = "Custom Buttons Sample"
        '
        'linkCommonButtons
        '
        Me.linkCommonButtons.AutoSize = True
        Me.linkCommonButtons.Location = New System.Drawing.Point(20, 18)
        Me.linkCommonButtons.Name = "linkCommonButtons"
        Me.linkCommonButtons.Size = New System.Drawing.Size(137, 13)
        Me.linkCommonButtons.TabIndex = 10
        Me.linkCommonButtons.TabStop = True
        Me.linkCommonButtons.Text = "Common Buttons Sample"
        '
        'linkError
        '
        Me.linkError.AutoSize = True
        Me.linkError.Location = New System.Drawing.Point(20, 118)
        Me.linkError.Name = "linkError"
        Me.linkError.Size = New System.Drawing.Size(72, 13)
        Me.linkError.TabIndex = 14
        Me.linkError.TabStop = True
        Me.linkError.Text = "Error Sample"
        '
        'dialogTimer
        '
        Me.dialogTimer.EnableTimer = True
        Me.dialogTimer.WindowTitle = "Timer Sample"
        '
        'linkIcons
        '
        Me.linkIcons.AutoSize = True
        Me.linkIcons.Location = New System.Drawing.Point(20, 143)
        Me.linkIcons.Name = "linkIcons"
        Me.linkIcons.Size = New System.Drawing.Size(74, 13)
        Me.linkIcons.TabIndex = 15
        Me.linkIcons.TabStop = True
        Me.linkIcons.Text = "Icons Sample"
        '
        'linkElevation
        '
        Me.linkElevation.AutoSize = True
        Me.linkElevation.Location = New System.Drawing.Point(20, 93)
        Me.linkElevation.Name = "linkElevation"
        Me.linkElevation.Size = New System.Drawing.Size(144, 13)
        Me.linkElevation.TabIndex = 13
        Me.linkElevation.TabStop = True
        Me.linkElevation.Text = "Elevation Required Sample"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.linkTimer)
        Me.Controls.Add(Me.linkProgress2)
        Me.Controls.Add(Me.linkProgress1)
        Me.Controls.Add(Me.linkEnableDisable)
        Me.Controls.Add(Me.linkCustomButtons)
        Me.Controls.Add(Me.linkCommonButtons)
        Me.Controls.Add(Me.linkError)
        Me.Controls.Add(Me.linkIcons)
        Me.Controls.Add(Me.linkElevation)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1TaskDialog Samples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dialogEnableDisable As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents dialogCommonButtons As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents dialogElevation As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents dialogCustomButtons As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents dialogError As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents dialogProgress2 As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents dialogIcons As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents dialogProgress1 As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents linkTimer As System.Windows.Forms.LinkLabel
    Private WithEvents linkProgress2 As System.Windows.Forms.LinkLabel
    Private WithEvents linkProgress1 As System.Windows.Forms.LinkLabel
    Private WithEvents linkEnableDisable As System.Windows.Forms.LinkLabel
    Private WithEvents linkCustomButtons As System.Windows.Forms.LinkLabel
    Private WithEvents linkCommonButtons As System.Windows.Forms.LinkLabel
    Private WithEvents linkError As System.Windows.Forms.LinkLabel
    Private WithEvents dialogTimer As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents linkIcons As System.Windows.Forms.LinkLabel
    Private WithEvents linkElevation As System.Windows.Forms.LinkLabel

End Class
