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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.pgDefaultParameters = New System.Windows.Forms.PropertyGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbxY = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbxX = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxText = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbxDuration = New System.Windows.Forms.TextBox()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1ComboBox1
        '
        Me.C1ComboBox1.AllowSpinLoop = False
        Me.C1ComboBox1.GapHeight = 0
        Me.C1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox1.ItemsDisplayMember = ""
        Me.C1ComboBox1.ItemsValueMember = ""
        Me.C1ComboBox1.Location = New System.Drawing.Point(16, 15)
        Me.C1ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(267, 20)
        Me.C1ComboBox1.TabIndex = 1
        Me.C1ComboBox1.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnReset.Location = New System.Drawing.Point(430, 453)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label4.Location = New System.Drawing.Point(5, 459)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(238, 16)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Tooltip duration (in milliseconds):"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.pgDefaultParameters)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(535, 139)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(405, 308)
        Me.groupBox3.TabIndex = 14
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Tooltip properties:"
        '
        'pgDefaultParameters
        '
        Me.pgDefaultParameters.CommandsBackColor = System.Drawing.Color.White
        Me.pgDefaultParameters.ContextMenuStrip = Me.ContextMenuStrip1
        Me.pgDefaultParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pgDefaultParameters.Location = New System.Drawing.Point(1, 21)
        Me.pgDefaultParameters.Name = "pgDefaultParameters"
        Me.pgDefaultParameters.Size = New System.Drawing.Size(404, 287)
        Me.pgDefaultParameters.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 26)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.groupBox2.Controls.Add(Me.tbxY)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.tbxX)
        Me.groupBox2.Location = New System.Drawing.Point(535, 453)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(405, 32)
        Me.groupBox2.TabIndex = 15
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Tooltip coordinates:"
        '
        'tbxY
        '
        Me.tbxY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxY.Location = New System.Drawing.Point(290, 8)
        Me.tbxY.Name = "tbxY"
        Me.tbxY.ReadOnly = True
        Me.tbxY.Size = New System.Drawing.Size(36, 15)
        Me.tbxY.TabIndex = 8
        Me.tbxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(260, 7)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(27, 16)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Y ="
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(146, 6)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 16)
        Me.label2.TabIndex = 6
        Me.label2.Text = "X ="
        '
        'tbxX
        '
        Me.tbxX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxX.Location = New System.Drawing.Point(173, 7)
        Me.tbxX.Name = "tbxX"
        Me.tbxX.ReadOnly = True
        Me.tbxX.Size = New System.Drawing.Size(36, 15)
        Me.tbxX.TabIndex = 2
        Me.tbxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tbxText)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(535, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(405, 133)
        Me.groupBox1.TabIndex = 13
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tooltip Text:"
        '
        'tbxText
        '
        Me.tbxText.BackColor = System.Drawing.Color.White
        Me.tbxText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbxText.Location = New System.Drawing.Point(1, 21)
        Me.tbxText.Multiline = True
        Me.tbxText.Name = "tbxText"
        Me.tbxText.ReadOnly = True
        Me.tbxText.Size = New System.Drawing.Size(404, 112)
        Me.tbxText.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'tbxDuration
        '
        Me.tbxDuration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbxDuration.Location = New System.Drawing.Point(249, 458)
        Me.tbxDuration.Name = "tbxDuration"
        Me.tbxDuration.Size = New System.Drawing.Size(50, 15)
        Me.tbxDuration.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 486)
        Me.Controls.Add(Me.tbxDuration)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1ComboBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1ComboBox Tooltip sample"
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents Label1 As Label
    Private WithEvents btnReset As Button
    Private WithEvents label4 As Label
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents pgDefaultParameters As PropertyGrid
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents tbxY As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents tbxX As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents tbxText As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Private WithEvents tbxDuration As TextBox
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
End Class
