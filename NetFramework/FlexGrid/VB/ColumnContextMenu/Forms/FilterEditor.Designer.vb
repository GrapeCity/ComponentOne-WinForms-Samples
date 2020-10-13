Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilterEditor
    Inherits C1RibbonForm

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
        Me.btnOk = New C1.Win.C1Input.C1Button()
        Me.btnCancel = New C1.Win.C1Input.C1Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New C1.Win.C1Input.C1Button()
        Me.c1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.C1FilterEditor1 = New C1.Win.DataFilter.C1FilterEditor()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(347, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(428, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.c1ThemeController1.SetTheme(Me.btnCancel, "(default)")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnClear)
        Me.panel1.Controls.Add(Me.btnOk)
        Me.panel1.Controls.Add(Me.btnCancel)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 251)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(506, 29)
        Me.panel1.TabIndex = 1
        Me.c1ThemeController1.SetTheme(Me.panel1, "(default)")
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(3, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.c1ThemeController1.SetTheme(Me.btnClear, "(default)")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'C1FilterEditor1
        '
        Me.C1FilterEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FilterEditor1.Location = New System.Drawing.Point(0, 0)
        Me.C1FilterEditor1.Name = "C1FilterEditor1"
        Me.C1FilterEditor1.Size = New System.Drawing.Size(522, 290)
        Me.C1FilterEditor1.TabIndex = 1
        Me.C1FilterEditor1.Text = "C1FilterEditor1"
        Me.c1ThemeController1.SetTheme(Me.C1FilterEditor1, "(default)")
        '
        'FilterEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 280)
        Me.Controls.Add(Me.C1FilterEditor1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FilterEditor"
        Me.Text = "FilterEditor"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnOk As C1.Win.C1Input.C1Button
    Private WithEvents btnCancel As C1.Win.C1Input.C1Button
    Private WithEvents panel1 As Panel
    Private WithEvents btnClear As C1.Win.C1Input.C1Button
    Private WithEvents C1FilterEditor1 As C1.Win.DataFilter.C1FilterEditor
    Private WithEvents c1ThemeController1 As C1.Win.C1Themes.C1ThemeController
End Class
