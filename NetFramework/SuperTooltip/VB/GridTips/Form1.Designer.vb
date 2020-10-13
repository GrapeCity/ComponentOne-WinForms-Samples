<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.label2 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me._flex4 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me._flex3 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me._flex2 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        CType(Me._flex4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 271)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(201, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Regular Tooltip associated with each cell"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(408, 271)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(201, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Regular Tooltip with Show/Hide methods"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(408, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(189, 13)
        Me.label3.TabIndex = 9
        Me.label3.Text = "SuperTooltip with Show/Hide methods"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(189, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "SuperTooltip associated with each cell"
        '
        '_flex4
        '
        Me._flex4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me._flex4.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex4.Location = New System.Drawing.Point(411, 287)
        Me._flex4.Name = "_flex4"
        Me._flex4.Rows.DefaultSize = 17
        Me._flex4.Size = New System.Drawing.Size(389, 191)
        Me._flex4.TabIndex = 3
        '
        '_flex3
        '
        Me._flex3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me._flex3.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex3.Location = New System.Drawing.Point(411, 31)
        Me._flex3.Name = "_flex3"
        Me._flex3.Rows.DefaultSize = 17
        Me._flex3.Size = New System.Drawing.Size(389, 191)
        Me._flex3.TabIndex = 2
        '
        '_flex2
        '
        Me._flex2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me._flex2.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex2.Location = New System.Drawing.Point(12, 287)
        Me._flex2.Name = "_flex2"
        Me._flex2.Rows.DefaultSize = 17
        Me._flex2.Size = New System.Drawing.Size(389, 191)
        Me._flex2.TabIndex = 5
        '
        '_flex
        '
        Me._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex.Location = New System.Drawing.Point(12, 31)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(389, 191)
        Me._flex.TabIndex = 4
        Me.C1SuperTooltip1.SetToolTip(Me._flex, resources.GetString("_flex.ToolTip"))
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(12, 498)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(125, 17)
        Me.checkBox1.TabIndex = 10
        Me.checkBox1.Text = "Show tips in balloons"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 527)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._flex4)
        Me.Controls.Add(Me._flex3)
        Me.Controls.Add(Me._flex2)
        Me.Controls.Add(Me._flex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1SuperTooltip: Associate tips with grid cells"
        CType(Me._flex4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents _flex4 As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents _flex3 As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents _flex2 As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox

End Class
