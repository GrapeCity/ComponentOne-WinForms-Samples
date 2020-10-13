<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PreviewForm
    Inherits C1.Win.Ribbon.C1RibbonForm

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim C1CustomButton7 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton()
        Dim C1CustomButton8 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewForm))
        Me.atb = New C1.Win.C1Win7Pack.C1TaskbarButton(Me.components)
        Me.extRegDlg = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.fv = New C1.Win.FlexViewer.C1FlexViewer()
        CType(Me.fv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'atb
        '
        Me.atb.ContainerForm = Me
        Me.atb.RegistryProgID = "FlexReportViewerVB"
        Me.atb.WindowAppID = "FlexReportViewerVB"
        '
        'extRegDlg
        '
        Me.extRegDlg.CheckBoxText = "Don't ask me again"
        Me.extRegDlg.Content = "'.flxr' file type is not registered."
        C1CustomButton7.ID = 9
        C1CustomButton7.Name = "registerButton"
        C1CustomButton7.Note = "Register .flxr files with this application to use the Recent Documents list."
        C1CustomButton7.Text = "Register file type for this application"
        C1CustomButton8.ID = 10
        C1CustomButton8.Name = "ignoreButton"
        C1CustomButton8.Note = "You can work without the registration, with empty Recent Documents list."
        C1CustomButton8.Text = "Do not register the file types"
        Me.extRegDlg.CustomButtons.AddRange(New C1.Win.C1Win7Pack.C1CustomButton() {C1CustomButton7, C1CustomButton8})
        Me.extRegDlg.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Information
        Me.extRegDlg.MainInstruction = "This application needs to register .flxr files as associated files to apply chang" &
    "es to the Jump List."
        Me.extRegDlg.NextID = 11
        Me.extRegDlg.WindowTitle = "FlexReport Viewer Destinations"
        '
        'fv
        '
        Me.fv.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.fv.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.fv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fv.Location = New System.Drawing.Point(0, 0)
        Me.fv.Name = "fv"
        Me.fv.Size = New System.Drawing.Size(902, 545)
        Me.fv.TabIndex = 1
        '
        'PreviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(902, 545)
        Me.Controls.Add(Me.fv)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PreviewForm"
        CType(Me.fv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents atb As C1.Win.C1Win7Pack.C1TaskbarButton
    Private WithEvents extRegDlg As C1.Win.C1Win7Pack.C1TaskDialog
    Private WithEvents fv As C1.Win.FlexViewer.C1FlexViewer
End Class
