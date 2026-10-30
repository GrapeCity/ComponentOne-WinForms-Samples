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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.c1InputPanel1 = New C1.Win.InputPanel.C1InputPanel()
        Me.inputGroupHeader1 = New C1.Win.InputPanel.InputGroupHeader()
        Me.inputLabel1 = New C1.Win.InputPanel.InputLabel()
        Me.cmbScenario = New C1.Win.InputPanel.InputComboBox()
        Me.btnRunScenario = New C1.Win.InputPanel.InputButton()
        Me.inputLabel2 = New C1.Win.InputPanel.InputLabel()
        Me.lblDescription = New C1.Win.InputPanel.InputLabel()
        Me.inputGroupHeader2 = New C1.Win.InputPanel.InputGroupHeader()
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel1
        '
        Me.c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel1)
        Me.c1InputPanel1.Items.Add(Me.cmbScenario)
        Me.c1InputPanel1.Items.Add(Me.btnRunScenario)
        Me.c1InputPanel1.Items.Add(Me.inputLabel2)
        Me.c1InputPanel1.Items.Add(Me.lblDescription)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader2)
        Me.c1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel1.Name = "c1InputPanel1"
        Me.c1InputPanel1.Size = New System.Drawing.Size(920, 548)
        Me.c1InputPanel1.TabIndex = 2
        '
        'inputGroupHeader1
        '
        Me.inputGroupHeader1.Text = "Test scenario"
        '
        'inputLabel1
        '
        Me.inputLabel1.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far
        Me.inputLabel1.Text = "Scenario:"
        Me.inputLabel1.Width = 80
        '
        'cmbScenario
        '
        Me.cmbScenario.Break = C1.Win.InputPanel.BreakType.None
        Me.cmbScenario.DropDownStyle = C1.Win.InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbScenario.Width = 215
        '
        'btnRunScenario
        '
        Me.btnRunScenario.Image = CType(resources.GetObject("btnRunScenario.Image"), System.Drawing.Image)
        Me.btnRunScenario.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnRunScenario.Text = "Run"
        '
        'inputLabel2
        '
        Me.inputLabel2.Height = 80
        Me.inputLabel2.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far
        Me.inputLabel2.Text = "Description:"
        Me.inputLabel2.Width = 80
        '
        'lblDescription
        '
        Me.lblDescription.Height = 80
        Me.lblDescription.Width = 500
        '
        'inputGroupHeader2
        '
        Me.inputGroupHeader2.Text = "Sample for selected scenario"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 548)
        Me.Controls.Add(Me.c1InputPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "UI Automation scenarios"
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1InputPanel1 As C1.Win.InputPanel.C1InputPanel
    Private WithEvents inputGroupHeader1 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel1 As C1.Win.InputPanel.InputLabel
    Private WithEvents cmbScenario As C1.Win.InputPanel.InputComboBox
    Private WithEvents btnRunScenario As C1.Win.InputPanel.InputButton
    Private WithEvents inputLabel2 As C1.Win.InputPanel.InputLabel
    Private WithEvents lblDescription As C1.Win.InputPanel.InputLabel
    Private WithEvents inputGroupHeader2 As C1.Win.InputPanel.InputGroupHeader
End Class
