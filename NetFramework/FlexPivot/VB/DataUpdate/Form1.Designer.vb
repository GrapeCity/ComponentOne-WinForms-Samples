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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me._c1FlexPivotPage = New C1.Win.FlexPivot.C1FlexPivotPage()
        Me.panel1.SuspendLayout()
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnClear)
        Me.panel1.Controls.Add(Me.btnAdd)
        Me.panel1.Controls.Add(Me.btnFill)
        Me.panel1.Controls.Add(Me.listBox1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(928, 139)
        Me.panel1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(167, 90)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(167, 57)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add 1000 rows"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(167, 24)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(160, 23)
        Me.btnFill.TabIndex = 3
        Me.btnFill.Text = "Initial fill (3 million rows)"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(541, 9)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(376, 121)
        Me.listBox1.TabIndex = 2
        '
        '_c1FlexPivotPage
        '
        Me._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me._c1FlexPivotPage.Location = New System.Drawing.Point(0, 139)
        Me._c1FlexPivotPage.Margin = New System.Windows.Forms.Padding(2)
        Me._c1FlexPivotPage.Name = "_c1FlexPivotPage"
        Me._c1FlexPivotPage.Size = New System.Drawing.Size(928, 507)
        Me._c1FlexPivotPage.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 646)
        Me.Controls.Add(Me._c1FlexPivotPage)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NorthWind Sales Data Analysis"
        Me.panel1.ResumeLayout(False)
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnClear As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnFill As System.Windows.Forms.Button
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Private WithEvents _c1FlexPivotPage As C1.Win.FlexPivot.C1FlexPivotPage

End Class
